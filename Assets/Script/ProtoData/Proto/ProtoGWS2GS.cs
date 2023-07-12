// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto_GWS2GS.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HHFramework.Proto {

  /// <summary>Holder for reflection information generated from Proto_GWS2GS.proto</summary>
  public static partial class ProtoGWS2GSReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto_GWS2GS.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoGWS2GSReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b19HV1MyR1MucHJvdG8SEUhIRnJhbWV3b3JrLlByb3RvIisKF0dX",
            "UzJHU19SZWdHYXRld2F5U2VydmVyEhAKCFNlcnZlcklkGAEgASgFIjQKEEdX",
            "UzJHU19IZWFydGJlYXQSEgoKU2VydmVyVGltZRgBIAEoAxIMCgRQaW5nGAIg",
            "ASgFIksKEUdXUzJHU19MZWF2ZVNjZW5lEg4KBlJvbGVJZBgBIAEoAxIPCgdT",
            "Y2VuZUlkGAIgASgFEhUKDVRhcmdldFNjZW5lSWQYAyABKAUiIwoOR1dTMkdT",
            "X09mZmxpbmUSEQoJQWNjb3VudElkGAEgASgDIk8KF0dXUzJHU19FbnRlclNj",
            "ZW5lX0FwcGx5Eg4KBlJvbGVJZBgBIAEoAxITCgtQcmV2U2NlbmVJZBgCIAEo",
            "BRIPCgdTY2VuZUlkGAMgASgFIjQKEUdXUzJHU19FbnRlclNjZW5lEg4KBlJv",
            "bGVJZBgBIAEoAxIPCgdTY2VuZUlkGAIgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GWS2GS_RegGatewayServer), global::HHFramework.Proto.GWS2GS_RegGatewayServer.Parser, new[]{ "ServerId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GWS2GS_Heartbeat), global::HHFramework.Proto.GWS2GS_Heartbeat.Parser, new[]{ "ServerTime", "Ping" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GWS2GS_LeaveScene), global::HHFramework.Proto.GWS2GS_LeaveScene.Parser, new[]{ "RoleId", "SceneId", "TargetSceneId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GWS2GS_Offline), global::HHFramework.Proto.GWS2GS_Offline.Parser, new[]{ "AccountId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GWS2GS_EnterScene_Apply), global::HHFramework.Proto.GWS2GS_EnterScene_Apply.Parser, new[]{ "RoleId", "PrevSceneId", "SceneId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GWS2GS_EnterScene), global::HHFramework.Proto.GWS2GS_EnterScene.Parser, new[]{ "RoleId", "SceneId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///网关服务器注册到游戏服务器
  /// </summary>
  public sealed partial class GWS2GS_RegGatewayServer : HHFramework.IProto, pb::IMessage<GWS2GS_RegGatewayServer> {
    private static readonly pb::MessageParser<GWS2GS_RegGatewayServer> _parser = new pb::MessageParser<GWS2GS_RegGatewayServer>(() => new GWS2GS_RegGatewayServer());
    public ushort ProtoId => ProtoIdDefine.Proto_GWS2GS_RegGatewayServer;
    public string ProtoEnName => "GWS2GS_RegGatewayServer";
    public ProtoCategory Category => ProtoCategory.GatewayServer2GameServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GWS2GS_RegGatewayServer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoGWS2GSReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_RegGatewayServer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_RegGatewayServer(GWS2GS_RegGatewayServer other) : this() {
      serverId_ = other.serverId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_RegGatewayServer Clone() {
      return new GWS2GS_RegGatewayServer(this);
    }

    /// <summary>Field number for the "ServerId" field.</summary>
    public const int ServerIdFieldNumber = 1;
    private int serverId_;
    /// <summary>
    ///服务器编号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ServerId {
      get { return serverId_; }
      set {
        serverId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GWS2GS_RegGatewayServer);
    }

    public bool Equals(GWS2GS_RegGatewayServer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerId != other.ServerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ServerId != 0) hash ^= ServerId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ServerId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ServerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ServerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ServerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(GWS2GS_RegGatewayServer other) {
      if (other == null) {
        return;
      }
      if (other.ServerId != 0) {
        ServerId = other.ServerId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ServerId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///网关服务器发送心跳到游戏服
  /// </summary>
  public sealed partial class GWS2GS_Heartbeat : HHFramework.IProto, pb::IMessage<GWS2GS_Heartbeat> {
    private static readonly pb::MessageParser<GWS2GS_Heartbeat> _parser = new pb::MessageParser<GWS2GS_Heartbeat>(() => new GWS2GS_Heartbeat());
    public ushort ProtoId => ProtoIdDefine.Proto_GWS2GS_Heartbeat;
    public string ProtoEnName => "GWS2GS_Heartbeat";
    public ProtoCategory Category => ProtoCategory.GatewayServer2GameServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GWS2GS_Heartbeat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoGWS2GSReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_Heartbeat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_Heartbeat(GWS2GS_Heartbeat other) : this() {
      serverTime_ = other.serverTime_;
      ping_ = other.ping_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_Heartbeat Clone() {
      return new GWS2GS_Heartbeat(this);
    }

    /// <summary>Field number for the "ServerTime" field.</summary>
    public const int ServerTimeFieldNumber = 1;
    private long serverTime_;
    /// <summary>
    ///服务器时间
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ServerTime {
      get { return serverTime_; }
      set {
        serverTime_ = value;
      }
    }

    /// <summary>Field number for the "Ping" field.</summary>
    public const int PingFieldNumber = 2;
    private int ping_;
    /// <summary>
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Ping {
      get { return ping_; }
      set {
        ping_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GWS2GS_Heartbeat);
    }

    public bool Equals(GWS2GS_Heartbeat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerTime != other.ServerTime) return false;
      if (Ping != other.Ping) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ServerTime != 0L) hash ^= ServerTime.GetHashCode();
      if (Ping != 0) hash ^= Ping.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ServerTime != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ServerTime);
      }
      if (Ping != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Ping);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ServerTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ServerTime);
      }
      if (Ping != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Ping);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(GWS2GS_Heartbeat other) {
      if (other == null) {
        return;
      }
      if (other.ServerTime != 0L) {
        ServerTime = other.ServerTime;
      }
      if (other.Ping != 0) {
        Ping = other.Ping;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ServerTime = input.ReadInt64();
            break;
          }
          case 16: {
            Ping = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///网关服务器向游戏服务器发送角色离开场景消息
  /// </summary>
  public sealed partial class GWS2GS_LeaveScene : HHFramework.IProto, pb::IMessage<GWS2GS_LeaveScene> {
    private static readonly pb::MessageParser<GWS2GS_LeaveScene> _parser = new pb::MessageParser<GWS2GS_LeaveScene>(() => new GWS2GS_LeaveScene());
    public ushort ProtoId => ProtoIdDefine.Proto_GWS2GS_LeaveScene;
    public string ProtoEnName => "GWS2GS_LeaveScene";
    public ProtoCategory Category => ProtoCategory.GatewayServer2GameServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GWS2GS_LeaveScene> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoGWS2GSReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_LeaveScene() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_LeaveScene(GWS2GS_LeaveScene other) : this() {
      roleId_ = other.roleId_;
      sceneId_ = other.sceneId_;
      targetSceneId_ = other.targetSceneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_LeaveScene Clone() {
      return new GWS2GS_LeaveScene(this);
    }

    /// <summary>Field number for the "RoleId" field.</summary>
    public const int RoleIdFieldNumber = 1;
    private long roleId_;
    /// <summary>
    ///角色编号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RoleId {
      get { return roleId_; }
      set {
        roleId_ = value;
      }
    }

    /// <summary>Field number for the "SceneId" field.</summary>
    public const int SceneIdFieldNumber = 2;
    private int sceneId_;
    /// <summary>
    ///场景编号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "TargetSceneId" field.</summary>
    public const int TargetSceneIdFieldNumber = 3;
    private int targetSceneId_;
    /// <summary>
    ///目标场景编号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TargetSceneId {
      get { return targetSceneId_; }
      set {
        targetSceneId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GWS2GS_LeaveScene);
    }

    public bool Equals(GWS2GS_LeaveScene other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoleId != other.RoleId) return false;
      if (SceneId != other.SceneId) return false;
      if (TargetSceneId != other.TargetSceneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (RoleId != 0L) hash ^= RoleId.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (TargetSceneId != 0) hash ^= TargetSceneId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RoleId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RoleId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(SceneId);
      }
      if (TargetSceneId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TargetSceneId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RoleId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RoleId);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SceneId);
      }
      if (TargetSceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TargetSceneId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(GWS2GS_LeaveScene other) {
      if (other == null) {
        return;
      }
      if (other.RoleId != 0L) {
        RoleId = other.RoleId;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.TargetSceneId != 0) {
        TargetSceneId = other.TargetSceneId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            RoleId = input.ReadInt64();
            break;
          }
          case 16: {
            SceneId = input.ReadInt32();
            break;
          }
          case 24: {
            TargetSceneId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///网关服务器向游戏服务器发送角色下线消息
  /// </summary>
  public sealed partial class GWS2GS_Offline : HHFramework.IProto, pb::IMessage<GWS2GS_Offline> {
    private static readonly pb::MessageParser<GWS2GS_Offline> _parser = new pb::MessageParser<GWS2GS_Offline>(() => new GWS2GS_Offline());
    public ushort ProtoId => ProtoIdDefine.Proto_GWS2GS_Offline;
    public string ProtoEnName => "GWS2GS_Offline";
    public ProtoCategory Category => ProtoCategory.GatewayServer2GameServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GWS2GS_Offline> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoGWS2GSReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_Offline() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_Offline(GWS2GS_Offline other) : this() {
      accountId_ = other.accountId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_Offline Clone() {
      return new GWS2GS_Offline(this);
    }

    /// <summary>Field number for the "AccountId" field.</summary>
    public const int AccountIdFieldNumber = 1;
    private long accountId_;
    /// <summary>
    ///玩家账号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long AccountId {
      get { return accountId_; }
      set {
        accountId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GWS2GS_Offline);
    }

    public bool Equals(GWS2GS_Offline other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AccountId != other.AccountId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (AccountId != 0L) hash ^= AccountId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (AccountId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(AccountId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (AccountId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AccountId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(GWS2GS_Offline other) {
      if (other == null) {
        return;
      }
      if (other.AccountId != 0L) {
        AccountId = other.AccountId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            AccountId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///网关服务器向游戏服务器发送角色进入场景申请消息
  /// </summary>
  public sealed partial class GWS2GS_EnterScene_Apply : HHFramework.IProto, pb::IMessage<GWS2GS_EnterScene_Apply> {
    private static readonly pb::MessageParser<GWS2GS_EnterScene_Apply> _parser = new pb::MessageParser<GWS2GS_EnterScene_Apply>(() => new GWS2GS_EnterScene_Apply());
    public ushort ProtoId => ProtoIdDefine.Proto_GWS2GS_EnterScene_Apply;
    public string ProtoEnName => "GWS2GS_EnterScene_Apply";
    public ProtoCategory Category => ProtoCategory.GatewayServer2GameServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GWS2GS_EnterScene_Apply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoGWS2GSReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_EnterScene_Apply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_EnterScene_Apply(GWS2GS_EnterScene_Apply other) : this() {
      roleId_ = other.roleId_;
      prevSceneId_ = other.prevSceneId_;
      sceneId_ = other.sceneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_EnterScene_Apply Clone() {
      return new GWS2GS_EnterScene_Apply(this);
    }

    /// <summary>Field number for the "RoleId" field.</summary>
    public const int RoleIdFieldNumber = 1;
    private long roleId_;
    /// <summary>
    ///角色编号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RoleId {
      get { return roleId_; }
      set {
        roleId_ = value;
      }
    }

    /// <summary>Field number for the "PrevSceneId" field.</summary>
    public const int PrevSceneIdFieldNumber = 2;
    private int prevSceneId_;
    /// <summary>
    ///上一场景编号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PrevSceneId {
      get { return prevSceneId_; }
      set {
        prevSceneId_ = value;
      }
    }

    /// <summary>Field number for the "SceneId" field.</summary>
    public const int SceneIdFieldNumber = 3;
    private int sceneId_;
    /// <summary>
    ///场景编号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GWS2GS_EnterScene_Apply);
    }

    public bool Equals(GWS2GS_EnterScene_Apply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoleId != other.RoleId) return false;
      if (PrevSceneId != other.PrevSceneId) return false;
      if (SceneId != other.SceneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (RoleId != 0L) hash ^= RoleId.GetHashCode();
      if (PrevSceneId != 0) hash ^= PrevSceneId.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RoleId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RoleId);
      }
      if (PrevSceneId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PrevSceneId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(SceneId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RoleId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RoleId);
      }
      if (PrevSceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PrevSceneId);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SceneId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(GWS2GS_EnterScene_Apply other) {
      if (other == null) {
        return;
      }
      if (other.RoleId != 0L) {
        RoleId = other.RoleId;
      }
      if (other.PrevSceneId != 0) {
        PrevSceneId = other.PrevSceneId;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            RoleId = input.ReadInt64();
            break;
          }
          case 16: {
            PrevSceneId = input.ReadInt32();
            break;
          }
          case 24: {
            SceneId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///网关服务器向游戏服务器发送角色进入场景消息
  /// </summary>
  public sealed partial class GWS2GS_EnterScene : HHFramework.IProto, pb::IMessage<GWS2GS_EnterScene> {
    private static readonly pb::MessageParser<GWS2GS_EnterScene> _parser = new pb::MessageParser<GWS2GS_EnterScene>(() => new GWS2GS_EnterScene());
    public ushort ProtoId => ProtoIdDefine.Proto_GWS2GS_EnterScene;
    public string ProtoEnName => "GWS2GS_EnterScene";
    public ProtoCategory Category => ProtoCategory.GatewayServer2GameServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GWS2GS_EnterScene> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoGWS2GSReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_EnterScene() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_EnterScene(GWS2GS_EnterScene other) : this() {
      roleId_ = other.roleId_;
      sceneId_ = other.sceneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2GS_EnterScene Clone() {
      return new GWS2GS_EnterScene(this);
    }

    /// <summary>Field number for the "RoleId" field.</summary>
    public const int RoleIdFieldNumber = 1;
    private long roleId_;
    /// <summary>
    ///角色编号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RoleId {
      get { return roleId_; }
      set {
        roleId_ = value;
      }
    }

    /// <summary>Field number for the "SceneId" field.</summary>
    public const int SceneIdFieldNumber = 2;
    private int sceneId_;
    /// <summary>
    ///场景编号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GWS2GS_EnterScene);
    }

    public bool Equals(GWS2GS_EnterScene other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoleId != other.RoleId) return false;
      if (SceneId != other.SceneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (RoleId != 0L) hash ^= RoleId.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RoleId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RoleId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(SceneId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RoleId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RoleId);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SceneId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(GWS2GS_EnterScene other) {
      if (other == null) {
        return;
      }
      if (other.RoleId != 0L) {
        RoleId = other.RoleId;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            RoleId = input.ReadInt64();
            break;
          }
          case 16: {
            SceneId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
