using System;
using Google.Protobuf.Collections;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class NavManager : MonoBehaviour
{
    [System.Serializable]
    public struct SceneSetting
    {
        public int SceneId;
        public int AddY;
    }

    /// <summary>
    /// 寻路代理
    /// </summary>
    public NavMeshAgent Agent;

    private NavMeshPath path;

    public List<Action> Funcs;

    public void Add(Action func)
    {
        Funcs.Add(func);
    }

    public static void Execute(Action func)
    {
        Instance.Add(func);
    }

    /// <summary>
    /// 这里指的网关服务器链表
    /// </summary>
    private LinkedList<ServerClient> m_ServerClientList;

    [Header("寻路服务器IP")] public string ServerIP = "192.168.31.130";
    [Header("寻路服务器端口")] public int ServerPort = 29001;

    /// <summary>
    /// 场景高度设置
    /// </summary>
    public SceneSetting[] SceneSettings;

    private Dictionary<int, int> m_SceneSettingsDic;

    public static NavManager Instance;

    private void Awake()
    {
        Instance = this;
        Agent.gameObject.SetActive(false);
    }

    void Start()
    {
        Funcs = new List<Action>();
        m_ServerClientList = new LinkedList<ServerClient>();
        path = new NavMeshPath();

        m_SceneSettingsDic = new Dictionary<int, int>();
        int len = SceneSettings.Length;
        for (int i = 0; i < len; i++)
        {
            SceneSetting sceneSetting = SceneSettings[i];
            m_SceneSettingsDic[sceneSetting.SceneId] = sceneSetting.AddY;
        }

        StarListen();
    }

    /// <summary>
    /// 获取路径点
    /// </summary>
    /// <param name="sceneId"></param>
    /// <param name="beginPos"></param>
    /// <param name="endPos"></param>
    /// <param name="addY"></param>
    public NavMeshPath GetNavPath(int sceneId, Vector3 beginPos, Vector3 endPos, out int addY)
    {
        m_SceneSettingsDic.TryGetValue(sceneId, out var y);

        beginPos += new Vector3(0, y, 0);
        endPos += new Vector3(0, y, 0);

        Agent.Warp(beginPos);
        Agent.gameObject.SetActive(true);
        Agent.CalculatePath(endPos, path);
        addY = y;
        return path;
    }

    /// <summary>
    /// 
    /// </summary>
    private void Update()
    {
        var curr = m_ServerClientList.First;
        while (curr != null)
        {
            curr.Value.OnUpdate();
            curr = curr.Next;
        }

        if (Funcs.Count <= 0) return;
        for (var i = Funcs.Count - 1; i >= 0; i--)
        {
            Funcs[i]();
            Funcs.Remove(Funcs[i]);
        }
    }

    /// <summary>
    /// Socket监听
    /// </summary>
    private Socket m_ListenSocket;

    #region StarListen 启动监听

    /// <summary>
    /// 启动监听
    /// </summary>
    private void StarListen()
    {
        //实例化socket
        m_ListenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //向操作系统申请一个可用的ip和端口用来通讯
        m_ListenSocket.Bind(new IPEndPoint(IPAddress.Parse(ServerIP), ServerPort));

        m_ListenSocket.Listen(20);

        Debug.LogFormat("NavServer {0} Start", m_ListenSocket.LocalEndPoint);

        Thread mThread = new Thread(ListenClientCallBack);
        mThread.Start();
    }

    #endregion;

    #region ListenClientCallBack 监听回调

    /// <summary>
    /// 监听回调
    /// </summary>
    /// <param name="obj"></param>
    private void ListenClientCallBack(object obj)
    {
        while (true)
        {
            //接收服务器客户端请求
            Socket socket = m_ListenSocket.Accept();

            IPEndPoint point = (IPEndPoint)socket.RemoteEndPoint;

            Debug.LogFormat("Game Server{0} Connection successful", point.ToString());

            //实例化一个服务器客户端
            AddServerClient(new ServerClient(socket));
        }
    }

    #endregion;

    public void AddServerClient(ServerClient serverClient)
    {
        m_ServerClientList.AddLast(serverClient);
    }

    public void RemoveServerClient(ServerClient serverClient)
    {
        Debug.LogFormat("Game Server disconnect");
        m_ServerClientList.Remove(serverClient);
    }
}