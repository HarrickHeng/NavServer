// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto_GS2GWS.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HHFramework.Proto {

  /// <summary>Holder for reflection information generated from Proto_GS2GWS.proto</summary>
  public static partial class ProtoGS2GWSReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto_GS2GWS.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoGS2GWSReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b19HUzJHV1MucHJvdG8SEUhIRnJhbWV3b3JrLlByb3RvIiYKEEdT",
            "MkdXU19IZWFydGJlYXQSEgoKU2VydmVyVGltZRgBIAEoA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GS2GWS_Heartbeat), global::HHFramework.Proto.GS2GWS_Heartbeat.Parser, new[]{ "ServerTime" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///游戏服务器向网关服务器返回心跳消息
  /// </summary>
  public sealed partial class GS2GWS_Heartbeat : HHFramework.IProto, pb::IMessage<GS2GWS_Heartbeat> {
    private static readonly pb::MessageParser<GS2GWS_Heartbeat> _parser = new pb::MessageParser<GS2GWS_Heartbeat>(() => new GS2GWS_Heartbeat());
    public ushort ProtoId => ProtoIdDefine.Proto_GS2GWS_Heartbeat;
    public string ProtoEnName => "GS2GWS_Heartbeat";
    public ProtoCategory Category => ProtoCategory.GameServer2GatewayServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GS2GWS_Heartbeat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoGS2GWSReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GS2GWS_Heartbeat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GS2GWS_Heartbeat(GS2GWS_Heartbeat other) : this() {
      serverTime_ = other.serverTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GS2GWS_Heartbeat Clone() {
      return new GS2GWS_Heartbeat(this);
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

    public override bool Equals(object other) {
      return Equals(other as GS2GWS_Heartbeat);
    }

    public bool Equals(GS2GWS_Heartbeat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerTime != other.ServerTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ServerTime != 0L) hash ^= ServerTime.GetHashCode();
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ServerTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ServerTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(GS2GWS_Heartbeat other) {
      if (other == null) {
        return;
      }
      if (other.ServerTime != 0L) {
        ServerTime = other.ServerTime;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
