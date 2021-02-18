// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protobuf/Models/beatmap.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TournamentAssistantShared.Models {

  /// <summary>Holder for reflection information generated from protobuf/Models/beatmap.proto</summary>
  public static partial class BeatmapReflection {

    #region Descriptor
    /// <summary>File descriptor for protobuf/Models/beatmap.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BeatmapReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1wcm90b2J1Zi9Nb2RlbHMvYmVhdG1hcC5wcm90bxIgVG91cm5hbWVudEFz",
            "c2lzdGFudFNoYXJlZC5Nb2RlbHMaJHByb3RvYnVmL01vZGVscy9jaGFyYWN0",
            "ZXJpc3RpYy5wcm90bxoocHJvdG9idWYvTW9kZWxzL2JlYXRtYXBfZGlmZmlj",
            "dWx0eS5wcm90byK8AQoHQmVhdG1hcBIMCgRuYW1lGAEgASgJEhAKCGxldmVs",
            "X2lkGAIgASgJEkgKDmNoYXJhY3RlcmlzdGljGAMgASgLMjAuVG91cm5hbWVu",
            "dEFzc2lzdGFudFNoYXJlZC5Nb2RlbHMuQ2hhcmFjdGVyaXN0aWMSRwoKZGlm",
            "ZmljdWx0eRgEIAEoDjIzLlRvdXJuYW1lbnRBc3Npc3RhbnRTaGFyZWQuTW9k",
            "ZWxzLkJlYXRtYXBEaWZmaWN1bHR5QiOqAiBUb3VybmFtZW50QXNzaXN0YW50",
            "U2hhcmVkLk1vZGVsc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::TournamentAssistantShared.Models.CharacteristicReflection.Descriptor, global::TournamentAssistantShared.Models.BeatmapDifficultyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TournamentAssistantShared.Models.Beatmap), global::TournamentAssistantShared.Models.Beatmap.Parser, new[]{ "Name", "LevelId", "Characteristic", "Difficulty" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Beatmap : pb::IMessage<Beatmap>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Beatmap> _parser = new pb::MessageParser<Beatmap>(() => new Beatmap());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Beatmap> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TournamentAssistantShared.Models.BeatmapReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Beatmap() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Beatmap(Beatmap other) : this() {
      name_ = other.name_;
      levelId_ = other.levelId_;
      characteristic_ = other.characteristic_ != null ? other.characteristic_.Clone() : null;
      difficulty_ = other.difficulty_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Beatmap Clone() {
      return new Beatmap(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 2;
    private string levelId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LevelId {
      get { return levelId_; }
      set {
        levelId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "characteristic" field.</summary>
    public const int CharacteristicFieldNumber = 3;
    private global::TournamentAssistantShared.Models.Characteristic characteristic_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TournamentAssistantShared.Models.Characteristic Characteristic {
      get { return characteristic_; }
      set {
        characteristic_ = value;
      }
    }

    /// <summary>Field number for the "difficulty" field.</summary>
    public const int DifficultyFieldNumber = 4;
    private global::TournamentAssistantShared.Models.BeatmapDifficulty difficulty_ = global::TournamentAssistantShared.Models.BeatmapDifficulty.Easy;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TournamentAssistantShared.Models.BeatmapDifficulty Difficulty {
      get { return difficulty_; }
      set {
        difficulty_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Beatmap);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Beatmap other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (LevelId != other.LevelId) return false;
      if (!object.Equals(Characteristic, other.Characteristic)) return false;
      if (Difficulty != other.Difficulty) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (LevelId.Length != 0) hash ^= LevelId.GetHashCode();
      if (characteristic_ != null) hash ^= Characteristic.GetHashCode();
      if (Difficulty != global::TournamentAssistantShared.Models.BeatmapDifficulty.Easy) hash ^= Difficulty.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (LevelId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LevelId);
      }
      if (characteristic_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Characteristic);
      }
      if (Difficulty != global::TournamentAssistantShared.Models.BeatmapDifficulty.Easy) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Difficulty);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (LevelId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LevelId);
      }
      if (characteristic_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Characteristic);
      }
      if (Difficulty != global::TournamentAssistantShared.Models.BeatmapDifficulty.Easy) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Difficulty);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (LevelId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LevelId);
      }
      if (characteristic_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Characteristic);
      }
      if (Difficulty != global::TournamentAssistantShared.Models.BeatmapDifficulty.Easy) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Difficulty);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Beatmap other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.LevelId.Length != 0) {
        LevelId = other.LevelId;
      }
      if (other.characteristic_ != null) {
        if (characteristic_ == null) {
          Characteristic = new global::TournamentAssistantShared.Models.Characteristic();
        }
        Characteristic.MergeFrom(other.Characteristic);
      }
      if (other.Difficulty != global::TournamentAssistantShared.Models.BeatmapDifficulty.Easy) {
        Difficulty = other.Difficulty;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            LevelId = input.ReadString();
            break;
          }
          case 26: {
            if (characteristic_ == null) {
              Characteristic = new global::TournamentAssistantShared.Models.Characteristic();
            }
            input.ReadMessage(Characteristic);
            break;
          }
          case 32: {
            Difficulty = (global::TournamentAssistantShared.Models.BeatmapDifficulty) input.ReadEnum();
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            LevelId = input.ReadString();
            break;
          }
          case 26: {
            if (characteristic_ == null) {
              Characteristic = new global::TournamentAssistantShared.Models.Characteristic();
            }
            input.ReadMessage(Characteristic);
            break;
          }
          case 32: {
            Difficulty = (global::TournamentAssistantShared.Models.BeatmapDifficulty) input.ReadEnum();
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
