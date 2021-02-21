// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protobuf/Models/Packets/acknowledgement.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TournamentAssistantShared.Models.Packets {

  /// <summary>Holder for reflection information generated from protobuf/Models/Packets/acknowledgement.proto</summary>
  public static partial class AcknowledgementReflection {

    #region Descriptor
    /// <summary>File descriptor for protobuf/Models/Packets/acknowledgement.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AcknowledgementReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1wcm90b2J1Zi9Nb2RlbHMvUGFja2V0cy9hY2tub3dsZWRnZW1lbnQucHJv",
            "dG8SKFRvdXJuYW1lbnRBc3Npc3RhbnRTaGFyZWQuTW9kZWxzLlBhY2tldHMi",
            "wQEKD0Fja25vd2xlZGdlbWVudBIRCglwYWNrZXRfaWQYASABKAkSWwoEdHlw",
            "ZRgCIAEoDjJNLlRvdXJuYW1lbnRBc3Npc3RhbnRTaGFyZWQuTW9kZWxzLlBh",
            "Y2tldHMuQWNrbm93bGVkZ2VtZW50LkFja25vd2xlZGdlbWVudFR5cGUiPgoT",
            "QWNrbm93bGVkZ2VtZW50VHlwZRITCg9NZXNzYWdlUmVjZWl2ZWQQABISCg5G",
            "aWxlRG93bmxvYWRlZBABQiuqAihUb3VybmFtZW50QXNzaXN0YW50U2hhcmVk",
            "Lk1vZGVscy5QYWNrZXRzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TournamentAssistantShared.Models.Packets.Acknowledgement), global::TournamentAssistantShared.Models.Packets.Acknowledgement.Parser, new[]{ "PacketId", "Type" }, null, new[]{ typeof(global::TournamentAssistantShared.Models.Packets.Acknowledgement.Types.AcknowledgementType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Acknowledgement : pb::IMessage<Acknowledgement>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Acknowledgement> _parser = new pb::MessageParser<Acknowledgement>(() => new Acknowledgement());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Acknowledgement> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TournamentAssistantShared.Models.Packets.AcknowledgementReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Acknowledgement() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Acknowledgement(Acknowledgement other) : this() {
      packetId_ = other.packetId_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Acknowledgement Clone() {
      return new Acknowledgement(this);
    }

    /// <summary>Field number for the "packet_id" field.</summary>
    public const int PacketIdFieldNumber = 1;
    private string packetId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PacketId {
      get { return packetId_; }
      set {
        packetId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::TournamentAssistantShared.Models.Packets.Acknowledgement.Types.AcknowledgementType type_ = global::TournamentAssistantShared.Models.Packets.Acknowledgement.Types.AcknowledgementType.MessageReceived;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TournamentAssistantShared.Models.Packets.Acknowledgement.Types.AcknowledgementType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Acknowledgement);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Acknowledgement other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PacketId != other.PacketId) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PacketId.Length != 0) hash ^= PacketId.GetHashCode();
      if (Type != global::TournamentAssistantShared.Models.Packets.Acknowledgement.Types.AcknowledgementType.MessageReceived) hash ^= Type.GetHashCode();
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
      if (PacketId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PacketId);
      }
      if (Type != global::TournamentAssistantShared.Models.Packets.Acknowledgement.Types.AcknowledgementType.MessageReceived) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PacketId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PacketId);
      }
      if (Type != global::TournamentAssistantShared.Models.Packets.Acknowledgement.Types.AcknowledgementType.MessageReceived) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PacketId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PacketId);
      }
      if (Type != global::TournamentAssistantShared.Models.Packets.Acknowledgement.Types.AcknowledgementType.MessageReceived) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Acknowledgement other) {
      if (other == null) {
        return;
      }
      if (other.PacketId.Length != 0) {
        PacketId = other.PacketId;
      }
      if (other.Type != global::TournamentAssistantShared.Models.Packets.Acknowledgement.Types.AcknowledgementType.MessageReceived) {
        Type = other.Type;
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
          case 10: {
            PacketId = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::TournamentAssistantShared.Models.Packets.Acknowledgement.Types.AcknowledgementType) input.ReadEnum();
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
          case 10: {
            PacketId = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::TournamentAssistantShared.Models.Packets.Acknowledgement.Types.AcknowledgementType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Acknowledgement message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum AcknowledgementType {
        [pbr::OriginalName("MessageReceived")] MessageReceived = 0,
        [pbr::OriginalName("FileDownloaded")] FileDownloaded = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code