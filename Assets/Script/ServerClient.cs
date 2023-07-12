using System;
using System.Net.Sockets;
using HHFramework;
using UnityEngine.AI;
using HHFramework.Proto;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class ServerClient
{
    /// <summary>
    /// Socket事件监听派发器
    /// </summary>
    public EventDispatcher EventDispatcher { get; private set; }

    /// <summary>
    /// Socket连接器
    /// </summary>
    public ClientSocket ClientSocket { get; private set; }

    public ServerClient(Socket socket)
    {
        EventDispatcher = new EventDispatcher();

        ClientSocket = new ClientSocket(socket, EventDispatcher);
        ClientSocket.OnConnectFail = () => { NavManager.Instance.RemoveServerClient(this); };
        ClientSocket.OnDisConnect = () => { NavManager.Instance.RemoveServerClient(this); };

        AddEventListener();
    }

    public void OnUpdate()
    {
        ClientSocket.OnUpdate();
    }

    /// <summary>
    /// 监听服务器客户端 连接到服务器
    /// </summary>
    private void AddEventListener()
    {
        EventDispatcher.AddEventListener(ProtoIdDefine.Proto_GS2NS_GetNavPath, OnGS2NS_GetNavPath);
        EventDispatcher.AddEventListener(ProtoIdDefine.Proto_GS2NS_Heartbeat, OnGS2NS_Heartbeat);
    }

    private void OnGS2NS_Heartbeat(byte[] buffer)
    {
        var proto = GS2NS_Heartbeat.Parser.ParseFrom(buffer);
        var retProto = new NS2GS_Heartbeat
        {
            ServerTime = proto.ServerTime
        };
        ClientSocket.SendMsg(retProto);
    }

    private void OnGS2NS_GetNavPath(byte[] buffer)
    {
        var proto = GS2NS_GetNavPath.Parser.ParseFrom(buffer);
        NavManager.Execute(() =>
        {
            var path =
                NavManager.Instance.GetNavPath(proto.SceneId,
                    new Vector3(proto.BeginPos.X, proto.BeginPos.Y, proto.BeginPos.Z),
                    new Vector3(proto.EndPos.X, proto.EndPos.Y, proto.EndPos.Z), out var addY);
            var retProto = new NS2GS_ReturnNavPath
            {
                TaskId = proto.TaskId
            };

            if (path.status == NavMeshPathStatus.PathComplete)
            {
                retProto.Valid = true;
                var vector3S = path.corners;
                for (int i = 0, len = vector3S.Length; i < len; ++i)
                {
                    var vector = vector3S[i];
                    retProto.Path.Add(new NS2GS_Vector3() { X = vector.x, Y = vector.y - addY, Z = vector.z });
                }
            }

            ClientSocket.SendMsg(retProto);
        });
    }
}