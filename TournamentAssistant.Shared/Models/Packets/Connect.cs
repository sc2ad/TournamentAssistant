// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protobuf/Models/Packets/connect.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TournamentAssistantShared.Models.Packets {

  /// <summary>Holder for reflection information generated from protobuf/Models/Packets/connect.proto</summary>
  public static partial class ConnectReflection {

    #region Descriptor
    /// <summary>File descriptor for protobuf/Models/Packets/connect.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConnectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVwcm90b2J1Zi9Nb2RlbHMvUGFja2V0cy9jb25uZWN0LnByb3RvEihUb3Vy",
            "bmFtZW50QXNzaXN0YW50U2hhcmVkLk1vZGVscy5QYWNrZXRzIu0BCgdDb25u",
            "ZWN0ElMKC2NsaWVudF90eXBlGAEgASgOMj4uVG91cm5hbWVudEFzc2lzdGFu",
            "dFNoYXJlZC5Nb2RlbHMuUGFja2V0cy5Db25uZWN0LkNvbm5lY3RUeXBlcxIM",
            "CgRuYW1lGAIgASgJEhAKCHBhc3N3b3JkGAMgASgJEg8KB3VzZXJfaWQYBCAB",
            "KAkSFgoOY2xpZW50X3ZlcnNpb24YBSABKAUiRAoMQ29ubmVjdFR5cGVzEgoK",
            "BlBsYXllchAAEg8KC0Nvb3JkaW5hdG9yEAESFwoTVGVtcG9yYXJ5Q29ubmVj",
            "dGlvbhACQiuqAihUb3VybmFtZW50QXNzaXN0YW50U2hhcmVkLk1vZGVscy5Q",
            "YWNrZXRzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TournamentAssistantShared.Models.Packets.Connect), global::TournamentAssistantShared.Models.Packets.Connect.Parser, new[]{ "ClientType", "Name", "Password", "UserId", "ClientVersion" }, null, new[]{ typeof(global::TournamentAssistantShared.Models.Packets.Connect.Types.ConnectTypes) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Connect : pb::IMessage<Connect>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Connect> _parser = new pb::MessageParser<Connect>(() => new Connect());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Connect> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TournamentAssistantShared.Models.Packets.ConnectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Connect() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Connect(Connect other) : this() {
      clientType_ = other.clientType_;
      name_ = other.name_;
      password_ = other.password_;
      userId_ = other.userId_;
      clientVersion_ = other.clientVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Connect Clone() {
      return new Connect(this);
    }

    /// <summary>Field number for the "client_type" field.</summary>
    public const int ClientTypeFieldNumber = 1;
    private global::TournamentAssistantShared.Models.Packets.Connect.Types.ConnectTypes clientType_ = global::TournamentAssistantShared.Models.Packets.Connect.Types.ConnectTypes.Player;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TournamentAssistantShared.Models.Packets.Connect.Types.ConnectTypes ClientType {
      get { return clientType_; }
      set {
        clientType_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 3;
    private string password_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 4;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_version" field.</summary>
    public const int ClientVersionFieldNumber = 5;
    private int clientVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ClientVersion {
      get { return clientVersion_; }
      set {
        clientVersion_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Connect);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Connect other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientType != other.ClientType) return false;
      if (Name != other.Name) return false;
      if (Password != other.Password) return false;
      if (UserId != other.UserId) return false;
      if (ClientVersion != other.ClientVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientType != global::TournamentAssistantShared.Models.Packets.Connect.Types.ConnectTypes.Player) hash ^= ClientType.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (ClientVersion != 0) hash ^= ClientVersion.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ClientType != global::TournamentAssistantShared.Models.Packets.Connect.Types.ConnectTypes.Player) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ClientType);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Password);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(UserId);
      }
      if (ClientVersion != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(ClientVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ClientType != global::TournamentAssistantShared.Models.Packets.Connect.Types.ConnectTypes.Player) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ClientType);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Password);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(UserId);
      }
      if (ClientVersion != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(ClientVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ClientType != global::TournamentAssistantShared.Models.Packets.Connect.Types.ConnectTypes.Player) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ClientType);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (ClientVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ClientVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Connect other) {
      if (other == null) {
        return;
      }
      if (other.ClientType != global::TournamentAssistantShared.Models.Packets.Connect.Types.ConnectTypes.Player) {
        ClientType = other.ClientType;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.ClientVersion != 0) {
        ClientVersion = other.ClientVersion;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ClientType = (global::TournamentAssistantShared.Models.Packets.Connect.Types.ConnectTypes) input.ReadEnum();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Password = input.ReadString();
            break;
          }
          case 34: {
            UserId = input.ReadString();
            break;
          }
          case 40: {
            ClientVersion = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ClientType = (global::TournamentAssistantShared.Models.Packets.Connect.Types.ConnectTypes) input.ReadEnum();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Password = input.ReadString();
            break;
          }
          case 34: {
            UserId = input.ReadString();
            break;
          }
          case 40: {
            ClientVersion = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Connect message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum ConnectTypes {
        [pbr::OriginalName("Player")] Player = 0,
        [pbr::OriginalName("Coordinator")] Coordinator = 1,
        [pbr::OriginalName("TemporaryConnection")] TemporaryConnection = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code