// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protobuf/Models/server_settings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TournamentAssistantShared.Models {

  /// <summary>Holder for reflection information generated from protobuf/Models/server_settings.proto</summary>
  public static partial class ServerSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for protobuf/Models/server_settings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServerSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVwcm90b2J1Zi9Nb2RlbHMvc2VydmVyX3NldHRpbmdzLnByb3RvEiBUb3Vy",
            "bmFtZW50QXNzaXN0YW50U2hhcmVkLk1vZGVscxoacHJvdG9idWYvTW9kZWxz",
            "L3RlYW0ucHJvdG8iuQEKDlNlcnZlclNldHRpbmdzEhMKC3NlcnZlcl9uYW1l",
            "GAEgASgJEhAKCHBhc3N3b3JkGAIgASgJEhQKDGVuYWJsZV90ZWFtcxgDIAEo",
            "CBI1CgV0ZWFtcxgEIAMoCzImLlRvdXJuYW1lbnRBc3Npc3RhbnRTaGFyZWQu",
            "TW9kZWxzLlRlYW0SHgoWc2NvcmVfdXBkYXRlX2ZyZXF1ZW5jeRgFIAEoBRIT",
            "CgtiYW5uZWRfbW9kcxgGIAMoCUIjqgIgVG91cm5hbWVudEFzc2lzdGFudFNo",
            "YXJlZC5Nb2RlbHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::TournamentAssistantShared.Models.TeamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TournamentAssistantShared.Models.ServerSettings), global::TournamentAssistantShared.Models.ServerSettings.Parser, new[]{ "ServerName", "Password", "EnableTeams", "Teams", "ScoreUpdateFrequency", "BannedMods" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ServerSettings : pb::IMessage<ServerSettings>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ServerSettings> _parser = new pb::MessageParser<ServerSettings>(() => new ServerSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TournamentAssistantShared.Models.ServerSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerSettings(ServerSettings other) : this() {
      serverName_ = other.serverName_;
      password_ = other.password_;
      enableTeams_ = other.enableTeams_;
      teams_ = other.teams_.Clone();
      scoreUpdateFrequency_ = other.scoreUpdateFrequency_;
      bannedMods_ = other.bannedMods_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerSettings Clone() {
      return new ServerSettings(this);
    }

    /// <summary>Field number for the "server_name" field.</summary>
    public const int ServerNameFieldNumber = 1;
    private string serverName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ServerName {
      get { return serverName_; }
      set {
        serverName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 2;
    private string password_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "enable_teams" field.</summary>
    public const int EnableTeamsFieldNumber = 3;
    private bool enableTeams_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableTeams {
      get { return enableTeams_; }
      set {
        enableTeams_ = value;
      }
    }

    /// <summary>Field number for the "teams" field.</summary>
    public const int TeamsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::TournamentAssistantShared.Models.Team> _repeated_teams_codec
        = pb::FieldCodec.ForMessage(34, global::TournamentAssistantShared.Models.Team.Parser);
    private readonly pbc::RepeatedField<global::TournamentAssistantShared.Models.Team> teams_ = new pbc::RepeatedField<global::TournamentAssistantShared.Models.Team>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::TournamentAssistantShared.Models.Team> Teams {
      get { return teams_; }
    }

    /// <summary>Field number for the "score_update_frequency" field.</summary>
    public const int ScoreUpdateFrequencyFieldNumber = 5;
    private int scoreUpdateFrequency_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ScoreUpdateFrequency {
      get { return scoreUpdateFrequency_; }
      set {
        scoreUpdateFrequency_ = value;
      }
    }

    /// <summary>Field number for the "banned_mods" field.</summary>
    public const int BannedModsFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _repeated_bannedMods_codec
        = pb::FieldCodec.ForString(50);
    private readonly pbc::RepeatedField<string> bannedMods_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> BannedMods {
      get { return bannedMods_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerName != other.ServerName) return false;
      if (Password != other.Password) return false;
      if (EnableTeams != other.EnableTeams) return false;
      if(!teams_.Equals(other.teams_)) return false;
      if (ScoreUpdateFrequency != other.ScoreUpdateFrequency) return false;
      if(!bannedMods_.Equals(other.bannedMods_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ServerName.Length != 0) hash ^= ServerName.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
      if (EnableTeams != false) hash ^= EnableTeams.GetHashCode();
      hash ^= teams_.GetHashCode();
      if (ScoreUpdateFrequency != 0) hash ^= ScoreUpdateFrequency.GetHashCode();
      hash ^= bannedMods_.GetHashCode();
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
      if (ServerName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ServerName);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
      if (EnableTeams != false) {
        output.WriteRawTag(24);
        output.WriteBool(EnableTeams);
      }
      teams_.WriteTo(output, _repeated_teams_codec);
      if (ScoreUpdateFrequency != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(ScoreUpdateFrequency);
      }
      bannedMods_.WriteTo(output, _repeated_bannedMods_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ServerName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ServerName);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
      if (EnableTeams != false) {
        output.WriteRawTag(24);
        output.WriteBool(EnableTeams);
      }
      teams_.WriteTo(ref output, _repeated_teams_codec);
      if (ScoreUpdateFrequency != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(ScoreUpdateFrequency);
      }
      bannedMods_.WriteTo(ref output, _repeated_bannedMods_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ServerName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerName);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      if (EnableTeams != false) {
        size += 1 + 1;
      }
      size += teams_.CalculateSize(_repeated_teams_codec);
      if (ScoreUpdateFrequency != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ScoreUpdateFrequency);
      }
      size += bannedMods_.CalculateSize(_repeated_bannedMods_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerSettings other) {
      if (other == null) {
        return;
      }
      if (other.ServerName.Length != 0) {
        ServerName = other.ServerName;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
      if (other.EnableTeams != false) {
        EnableTeams = other.EnableTeams;
      }
      teams_.Add(other.teams_);
      if (other.ScoreUpdateFrequency != 0) {
        ScoreUpdateFrequency = other.ScoreUpdateFrequency;
      }
      bannedMods_.Add(other.bannedMods_);
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
            ServerName = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
          case 24: {
            EnableTeams = input.ReadBool();
            break;
          }
          case 34: {
            teams_.AddEntriesFrom(input, _repeated_teams_codec);
            break;
          }
          case 40: {
            ScoreUpdateFrequency = input.ReadInt32();
            break;
          }
          case 50: {
            bannedMods_.AddEntriesFrom(input, _repeated_bannedMods_codec);
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
            ServerName = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
          case 24: {
            EnableTeams = input.ReadBool();
            break;
          }
          case 34: {
            teams_.AddEntriesFrom(ref input, _repeated_teams_codec);
            break;
          }
          case 40: {
            ScoreUpdateFrequency = input.ReadInt32();
            break;
          }
          case 50: {
            bannedMods_.AddEntriesFrom(ref input, _repeated_bannedMods_codec);
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
