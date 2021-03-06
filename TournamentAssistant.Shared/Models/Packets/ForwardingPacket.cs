// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protobuf/Models/Packets/forwarding_packet.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TournamentAssistantShared.Models.Packets {

  /// <summary>Holder for reflection information generated from protobuf/Models/Packets/forwarding_packet.proto</summary>
  public static partial class ForwardingPacketReflection {

    #region Descriptor
    /// <summary>File descriptor for protobuf/Models/Packets/forwarding_packet.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ForwardingPacketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9wcm90b2J1Zi9Nb2RlbHMvUGFja2V0cy9mb3J3YXJkaW5nX3BhY2tldC5w",
            "cm90bxIoVG91cm5hbWVudEFzc2lzdGFudFNoYXJlZC5Nb2RlbHMuUGFja2V0",
            "cxohcHJvdG9idWYvTW9kZWxzL3BhY2tldF90eXBlLnByb3RvGhlnb29nbGUv",
            "cHJvdG9idWYvYW55LnByb3RvIpEBChBGb3J3YXJkaW5nUGFja2V0EhIKCmZv",
            "cndhcmRfdG8YASADKAkSOgoEdHlwZRgCIAEoDjIsLlRvdXJuYW1lbnRBc3Np",
            "c3RhbnRTaGFyZWQuTW9kZWxzLlBhY2tldFR5cGUSLQoPc3BlY2lmaWNfcGFj",
            "a2V0GAMgASgLMhQuZ29vZ2xlLnByb3RvYnVmLkFueUIrqgIoVG91cm5hbWVu",
            "dEFzc2lzdGFudFNoYXJlZC5Nb2RlbHMuUGFja2V0c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::TournamentAssistantShared.Models.PacketTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TournamentAssistantShared.Models.Packets.ForwardingPacket), global::TournamentAssistantShared.Models.Packets.ForwardingPacket.Parser, new[]{ "ForwardTo", "Type", "SpecificPacket" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ForwardingPacket : pb::IMessage<ForwardingPacket>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ForwardingPacket> _parser = new pb::MessageParser<ForwardingPacket>(() => new ForwardingPacket());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ForwardingPacket> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TournamentAssistantShared.Models.Packets.ForwardingPacketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ForwardingPacket() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ForwardingPacket(ForwardingPacket other) : this() {
      forwardTo_ = other.forwardTo_.Clone();
      type_ = other.type_;
      specificPacket_ = other.specificPacket_ != null ? other.specificPacket_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ForwardingPacket Clone() {
      return new ForwardingPacket(this);
    }

    /// <summary>Field number for the "forward_to" field.</summary>
    public const int ForwardToFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_forwardTo_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> forwardTo_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ForwardTo {
      get { return forwardTo_; }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::TournamentAssistantShared.Models.PacketType type_ = global::TournamentAssistantShared.Models.PacketType.Acknowledgement;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TournamentAssistantShared.Models.PacketType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "specific_packet" field.</summary>
    public const int SpecificPacketFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Any specificPacket_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any SpecificPacket {
      get { return specificPacket_; }
      set {
        specificPacket_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ForwardingPacket);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ForwardingPacket other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!forwardTo_.Equals(other.forwardTo_)) return false;
      if (Type != other.Type) return false;
      if (!object.Equals(SpecificPacket, other.SpecificPacket)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= forwardTo_.GetHashCode();
      if (Type != global::TournamentAssistantShared.Models.PacketType.Acknowledgement) hash ^= Type.GetHashCode();
      if (specificPacket_ != null) hash ^= SpecificPacket.GetHashCode();
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
      forwardTo_.WriteTo(output, _repeated_forwardTo_codec);
      if (Type != global::TournamentAssistantShared.Models.PacketType.Acknowledgement) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (specificPacket_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SpecificPacket);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      forwardTo_.WriteTo(ref output, _repeated_forwardTo_codec);
      if (Type != global::TournamentAssistantShared.Models.PacketType.Acknowledgement) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (specificPacket_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SpecificPacket);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += forwardTo_.CalculateSize(_repeated_forwardTo_codec);
      if (Type != global::TournamentAssistantShared.Models.PacketType.Acknowledgement) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (specificPacket_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpecificPacket);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ForwardingPacket other) {
      if (other == null) {
        return;
      }
      forwardTo_.Add(other.forwardTo_);
      if (other.Type != global::TournamentAssistantShared.Models.PacketType.Acknowledgement) {
        Type = other.Type;
      }
      if (other.specificPacket_ != null) {
        if (specificPacket_ == null) {
          SpecificPacket = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        SpecificPacket.MergeFrom(other.SpecificPacket);
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
            forwardTo_.AddEntriesFrom(input, _repeated_forwardTo_codec);
            break;
          }
          case 16: {
            Type = (global::TournamentAssistantShared.Models.PacketType) input.ReadEnum();
            break;
          }
          case 26: {
            if (specificPacket_ == null) {
              SpecificPacket = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(SpecificPacket);
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
            forwardTo_.AddEntriesFrom(ref input, _repeated_forwardTo_codec);
            break;
          }
          case 16: {
            Type = (global::TournamentAssistantShared.Models.PacketType) input.ReadEnum();
            break;
          }
          case 26: {
            if (specificPacket_ == null) {
              SpecificPacket = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(SpecificPacket);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
