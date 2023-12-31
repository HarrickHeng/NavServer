// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto_GS2WS.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HHFramework.Proto {

  /// <summary>Holder for reflection information generated from Proto_GS2WS.proto</summary>
  public static partial class ProtoGS2WSReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto_GS2WS.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoGS2WSReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQcm90b19HUzJXUy5wcm90bxIRSEhGcmFtZXdvcmsuUHJvdG8iJwoTR1My",
            "V1NfUmVnR2FtZVNlcnZlchIQCghTZXJ2ZXJJZBgBIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GS2WS_RegGameServer), global::HHFramework.Proto.GS2WS_RegGameServer.Parser, new[]{ "ServerId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///游戏服务器注册到中心服务器
  /// </summary>
  public sealed partial class GS2WS_RegGameServer : HHFramework.IProto, pb::IMessage<GS2WS_RegGameServer> {
    private static readonly pb::MessageParser<GS2WS_RegGameServer> _parser = new pb::MessageParser<GS2WS_RegGameServer>(() => new GS2WS_RegGameServer());
    public ushort ProtoId => ProtoIdDefine.Proto_GS2WS_RegGameServer;
    public string ProtoEnName => "GS2WS_RegGameServer";
    public ProtoCategory Category => ProtoCategory.GameServer2WorldServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GS2WS_RegGameServer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoGS2WSReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GS2WS_RegGameServer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GS2WS_RegGameServer(GS2WS_RegGameServer other) : this() {
      serverId_ = other.serverId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GS2WS_RegGameServer Clone() {
      return new GS2WS_RegGameServer(this);
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
      return Equals(other as GS2WS_RegGameServer);
    }

    public bool Equals(GS2WS_RegGameServer other) {
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

    public void MergeFrom(GS2WS_RegGameServer other) {
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

  #endregion

}

#endregion Designer generated code
