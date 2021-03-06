// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: EncounterResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGo.RocketAPI.GeneratedCode {

  /// <summary>Holder for reflection information generated from EncounterResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class EncounterResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for EncounterResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdFbmNvdW50ZXJSZXNwb25zZS5wcm90bxIhUG9rZW1vbkdvLlJvY2tldEFQ",
            "SS5HZW5lcmF0ZWRDb2RlIocFChFFbmNvdW50ZXJSZXNwb25zZRIQCgh1bmtu",
            "b3duMRgBIAEoBRIQCgh1bmtub3duMhgCIAEoAxIPCgdhcGlfdXJsGAMgASgJ",
            "Ek8KCHVua25vd242GAYgASgLMj0uUG9rZW1vbkdvLlJvY2tldEFQSS5HZW5l",
            "cmF0ZWRDb2RlLkVuY291bnRlclJlc3BvbnNlLlVua25vd242Ek8KCHVua25v",
            "d243GAcgASgLMj0uUG9rZW1vbkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2Rl",
            "LkVuY291bnRlclJlc3BvbnNlLlVua25vd243Ek0KB3BheWxvYWQYZCADKAsy",
            "PC5Qb2tlbW9uR28uUm9ja2V0QVBJLkdlbmVyYXRlZENvZGUuRW5jb3VudGVy",
            "UmVzcG9uc2UuUGF5bG9hZBIUCgxlcnJvck1lc3NhZ2UYZSABKAkalAEKCFVu",
            "a25vd242EhAKCHVua25vd24xGAEgASgFElgKCHVua25vd24yGAIgASgLMkYu",
            "UG9rZW1vbkdvLlJvY2tldEFQSS5HZW5lcmF0ZWRDb2RlLkVuY291bnRlclJl",
            "c3BvbnNlLlVua25vd242LlVua25vd24yGhwKCFVua25vd24yEhAKCHVua25v",
            "d24xGAEgASgMGkMKCFVua25vd243EhEKCXVua25vd243MRgBIAEoDBIRCgl1",
            "bmtub3duNzIYAiABKAMSEQoJdW5rbm93bjczGAMgASgMGloKB1BheWxvYWQS",
            "DwoHUG9rZW1vbhgBIAEoBRISCgpCYWNrZ3JvdW5kGAIgASgFEg4KBlN0YXR1",
            "cxgDIAEoBRIaChJDYXB0dXJlUHJvYmFiaWxpdHkYBCABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse), global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Parser, new[]{ "Unknown1", "Unknown2", "ApiUrl", "Unknown6", "Unknown7", "Payload", "ErrorMessage" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6), global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6.Parser, new[]{ "Unknown1", "Unknown2" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6.Types.Unknown2), global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6.Types.Unknown2.Parser, new[]{ "Unknown1" }, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown7), global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown7.Parser, new[]{ "Unknown71", "Unknown72", "Unknown73" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Payload), global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Payload.Parser, new[]{ "Pokemon", "Background", "Status", "CaptureProbability" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class EncounterResponse : pb::IMessage<EncounterResponse> {
    private static readonly pb::MessageParser<EncounterResponse> _parser = new pb::MessageParser<EncounterResponse>(() => new EncounterResponse());
    public static pb::MessageParser<EncounterResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public EncounterResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public EncounterResponse(EncounterResponse other) : this() {
      unknown1_ = other.unknown1_;
      unknown2_ = other.unknown2_;
      apiUrl_ = other.apiUrl_;
      Unknown6 = other.unknown6_ != null ? other.Unknown6.Clone() : null;
      Unknown7 = other.unknown7_ != null ? other.Unknown7.Clone() : null;
      payload_ = other.payload_.Clone();
      errorMessage_ = other.errorMessage_;
    }

    public EncounterResponse Clone() {
      return new EncounterResponse(this);
    }

    /// <summary>Field number for the "unknown1" field.</summary>
    public const int Unknown1FieldNumber = 1;
    private int unknown1_;
    public int Unknown1 {
      get { return unknown1_; }
      set {
        unknown1_ = value;
      }
    }

    /// <summary>Field number for the "unknown2" field.</summary>
    public const int Unknown2FieldNumber = 2;
    private long unknown2_;
    public long Unknown2 {
      get { return unknown2_; }
      set {
        unknown2_ = value;
      }
    }

    /// <summary>Field number for the "api_url" field.</summary>
    public const int ApiUrlFieldNumber = 3;
    private string apiUrl_ = "";
    public string ApiUrl {
      get { return apiUrl_; }
      set {
        apiUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unknown6" field.</summary>
    public const int Unknown6FieldNumber = 6;
    private global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6 unknown6_;
    public global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6 Unknown6 {
      get { return unknown6_; }
      set {
        unknown6_ = value;
      }
    }

    /// <summary>Field number for the "unknown7" field.</summary>
    public const int Unknown7FieldNumber = 7;
    private global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown7 unknown7_;
    public global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown7 Unknown7 {
      get { return unknown7_; }
      set {
        unknown7_ = value;
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 100;
    private static readonly pb::FieldCodec<global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Payload> _repeated_payload_codec
        = pb::FieldCodec.ForMessage(802, global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Payload.Parser);
    private readonly pbc::RepeatedField<global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Payload> payload_ = new pbc::RepeatedField<global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Payload>();
    public pbc::RepeatedField<global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Payload> Payload {
      get { return payload_; }
    }

    /// <summary>Field number for the "errorMessage" field.</summary>
    public const int ErrorMessageFieldNumber = 101;
    private string errorMessage_ = "";
    /// <summary>
    /// Should be moved to an error-proto file if error is always 101 field
    /// </summary>
    public string ErrorMessage {
      get { return errorMessage_; }
      set {
        errorMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as EncounterResponse);
    }

    public bool Equals(EncounterResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unknown1 != other.Unknown1) return false;
      if (Unknown2 != other.Unknown2) return false;
      if (ApiUrl != other.ApiUrl) return false;
      if (!object.Equals(Unknown6, other.Unknown6)) return false;
      if (!object.Equals(Unknown7, other.Unknown7)) return false;
      if(!payload_.Equals(other.payload_)) return false;
      if (ErrorMessage != other.ErrorMessage) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Unknown1 != 0) hash ^= Unknown1.GetHashCode();
      if (Unknown2 != 0L) hash ^= Unknown2.GetHashCode();
      if (ApiUrl.Length != 0) hash ^= ApiUrl.GetHashCode();
      if (unknown6_ != null) hash ^= Unknown6.GetHashCode();
      if (unknown7_ != null) hash ^= Unknown7.GetHashCode();
      hash ^= payload_.GetHashCode();
      if (ErrorMessage.Length != 0) hash ^= ErrorMessage.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Unknown1 != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Unknown1);
      }
      if (Unknown2 != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Unknown2);
      }
      if (ApiUrl.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ApiUrl);
      }
      if (unknown6_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Unknown6);
      }
      if (unknown7_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Unknown7);
      }
      payload_.WriteTo(output, _repeated_payload_codec);
      if (ErrorMessage.Length != 0) {
        output.WriteRawTag(170, 6);
        output.WriteString(ErrorMessage);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Unknown1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown1);
      }
      if (Unknown2 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Unknown2);
      }
      if (ApiUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApiUrl);
      }
      if (unknown6_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unknown6);
      }
      if (unknown7_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unknown7);
      }
      size += payload_.CalculateSize(_repeated_payload_codec);
      if (ErrorMessage.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ErrorMessage);
      }
      return size;
    }

    public void MergeFrom(EncounterResponse other) {
      if (other == null) {
        return;
      }
      if (other.Unknown1 != 0) {
        Unknown1 = other.Unknown1;
      }
      if (other.Unknown2 != 0L) {
        Unknown2 = other.Unknown2;
      }
      if (other.ApiUrl.Length != 0) {
        ApiUrl = other.ApiUrl;
      }
      if (other.unknown6_ != null) {
        if (unknown6_ == null) {
          unknown6_ = new global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6();
        }
        Unknown6.MergeFrom(other.Unknown6);
      }
      if (other.unknown7_ != null) {
        if (unknown7_ == null) {
          unknown7_ = new global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown7();
        }
        Unknown7.MergeFrom(other.Unknown7);
      }
      payload_.Add(other.payload_);
      if (other.ErrorMessage.Length != 0) {
        ErrorMessage = other.ErrorMessage;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Unknown1 = input.ReadInt32();
            break;
          }
          case 16: {
            Unknown2 = input.ReadInt64();
            break;
          }
          case 26: {
            ApiUrl = input.ReadString();
            break;
          }
          case 50: {
            if (unknown6_ == null) {
              unknown6_ = new global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6();
            }
            input.ReadMessage(unknown6_);
            break;
          }
          case 58: {
            if (unknown7_ == null) {
              unknown7_ = new global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown7();
            }
            input.ReadMessage(unknown7_);
            break;
          }
          case 802: {
            payload_.AddEntriesFrom(input, _repeated_payload_codec);
            break;
          }
          case 810: {
            ErrorMessage = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the EncounterResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Unknown6 : pb::IMessage<Unknown6> {
        private static readonly pb::MessageParser<Unknown6> _parser = new pb::MessageParser<Unknown6>(() => new Unknown6());
        public static pb::MessageParser<Unknown6> Parser { get { return _parser; } }

        public static pbr::MessageDescriptor Descriptor {
          get { return global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Descriptor.NestedTypes[0]; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        public Unknown6() {
          OnConstruction();
        }

        partial void OnConstruction();

        public Unknown6(Unknown6 other) : this() {
          unknown1_ = other.unknown1_;
          Unknown2 = other.unknown2_ != null ? other.Unknown2.Clone() : null;
        }

        public Unknown6 Clone() {
          return new Unknown6(this);
        }

        /// <summary>Field number for the "unknown1" field.</summary>
        public const int Unknown1FieldNumber = 1;
        private int unknown1_;
        public int Unknown1 {
          get { return unknown1_; }
          set {
            unknown1_ = value;
          }
        }

        /// <summary>Field number for the "unknown2" field.</summary>
        public const int Unknown2FieldNumber = 2;
        private global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6.Types.Unknown2 unknown2_;
        public global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6.Types.Unknown2 Unknown2 {
          get { return unknown2_; }
          set {
            unknown2_ = value;
          }
        }

        public override bool Equals(object other) {
          return Equals(other as Unknown6);
        }

        public bool Equals(Unknown6 other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Unknown1 != other.Unknown1) return false;
          if (!object.Equals(Unknown2, other.Unknown2)) return false;
          return true;
        }

        public override int GetHashCode() {
          int hash = 1;
          if (Unknown1 != 0) hash ^= Unknown1.GetHashCode();
          if (unknown2_ != null) hash ^= Unknown2.GetHashCode();
          return hash;
        }

        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        public void WriteTo(pb::CodedOutputStream output) {
          if (Unknown1 != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(Unknown1);
          }
          if (unknown2_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(Unknown2);
          }
        }

        public int CalculateSize() {
          int size = 0;
          if (Unknown1 != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown1);
          }
          if (unknown2_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unknown2);
          }
          return size;
        }

        public void MergeFrom(Unknown6 other) {
          if (other == null) {
            return;
          }
          if (other.Unknown1 != 0) {
            Unknown1 = other.Unknown1;
          }
          if (other.unknown2_ != null) {
            if (unknown2_ == null) {
              unknown2_ = new global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6.Types.Unknown2();
            }
            Unknown2.MergeFrom(other.Unknown2);
          }
        }

        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 8: {
                Unknown1 = input.ReadInt32();
                break;
              }
              case 18: {
                if (unknown2_ == null) {
                  unknown2_ = new global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6.Types.Unknown2();
                }
                input.ReadMessage(unknown2_);
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the Unknown6 message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static partial class Types {
          [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
          public sealed partial class Unknown2 : pb::IMessage<Unknown2> {
            private static readonly pb::MessageParser<Unknown2> _parser = new pb::MessageParser<Unknown2>(() => new Unknown2());
            public static pb::MessageParser<Unknown2> Parser { get { return _parser; } }

            public static pbr::MessageDescriptor Descriptor {
              get { return global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Types.Unknown6.Descriptor.NestedTypes[0]; }
            }

            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            public Unknown2() {
              OnConstruction();
            }

            partial void OnConstruction();

            public Unknown2(Unknown2 other) : this() {
              unknown1_ = other.unknown1_;
            }

            public Unknown2 Clone() {
              return new Unknown2(this);
            }

            /// <summary>Field number for the "unknown1" field.</summary>
            public const int Unknown1FieldNumber = 1;
            private pb::ByteString unknown1_ = pb::ByteString.Empty;
            public pb::ByteString Unknown1 {
              get { return unknown1_; }
              set {
                unknown1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
              }
            }

            public override bool Equals(object other) {
              return Equals(other as Unknown2);
            }

            public bool Equals(Unknown2 other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              if (Unknown1 != other.Unknown1) return false;
              return true;
            }

            public override int GetHashCode() {
              int hash = 1;
              if (Unknown1.Length != 0) hash ^= Unknown1.GetHashCode();
              return hash;
            }

            public override string ToString() {
              return pb::JsonFormatter.ToDiagnosticString(this);
            }

            public void WriteTo(pb::CodedOutputStream output) {
              if (Unknown1.Length != 0) {
                output.WriteRawTag(10);
                output.WriteBytes(Unknown1);
              }
            }

            public int CalculateSize() {
              int size = 0;
              if (Unknown1.Length != 0) {
                size += 1 + pb::CodedOutputStream.ComputeBytesSize(Unknown1);
              }
              return size;
            }

            public void MergeFrom(Unknown2 other) {
              if (other == null) {
                return;
              }
              if (other.Unknown1.Length != 0) {
                Unknown1 = other.Unknown1;
              }
            }

            public void MergeFrom(pb::CodedInputStream input) {
              uint tag;
              while ((tag = input.ReadTag()) != 0) {
                switch(tag) {
                  default:
                    input.SkipLastField();
                    break;
                  case 10: {
                    Unknown1 = input.ReadBytes();
                    break;
                  }
                }
              }
            }

          }

        }
        #endregion

      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Unknown7 : pb::IMessage<Unknown7> {
        private static readonly pb::MessageParser<Unknown7> _parser = new pb::MessageParser<Unknown7>(() => new Unknown7());
        public static pb::MessageParser<Unknown7> Parser { get { return _parser; } }

        public static pbr::MessageDescriptor Descriptor {
          get { return global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Descriptor.NestedTypes[1]; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        public Unknown7() {
          OnConstruction();
        }

        partial void OnConstruction();

        public Unknown7(Unknown7 other) : this() {
          unknown71_ = other.unknown71_;
          unknown72_ = other.unknown72_;
          unknown73_ = other.unknown73_;
        }

        public Unknown7 Clone() {
          return new Unknown7(this);
        }

        /// <summary>Field number for the "unknown71" field.</summary>
        public const int Unknown71FieldNumber = 1;
        private pb::ByteString unknown71_ = pb::ByteString.Empty;
        public pb::ByteString Unknown71 {
          get { return unknown71_; }
          set {
            unknown71_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "unknown72" field.</summary>
        public const int Unknown72FieldNumber = 2;
        private long unknown72_;
        public long Unknown72 {
          get { return unknown72_; }
          set {
            unknown72_ = value;
          }
        }

        /// <summary>Field number for the "unknown73" field.</summary>
        public const int Unknown73FieldNumber = 3;
        private pb::ByteString unknown73_ = pb::ByteString.Empty;
        public pb::ByteString Unknown73 {
          get { return unknown73_; }
          set {
            unknown73_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        public override bool Equals(object other) {
          return Equals(other as Unknown7);
        }

        public bool Equals(Unknown7 other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Unknown71 != other.Unknown71) return false;
          if (Unknown72 != other.Unknown72) return false;
          if (Unknown73 != other.Unknown73) return false;
          return true;
        }

        public override int GetHashCode() {
          int hash = 1;
          if (Unknown71.Length != 0) hash ^= Unknown71.GetHashCode();
          if (Unknown72 != 0L) hash ^= Unknown72.GetHashCode();
          if (Unknown73.Length != 0) hash ^= Unknown73.GetHashCode();
          return hash;
        }

        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        public void WriteTo(pb::CodedOutputStream output) {
          if (Unknown71.Length != 0) {
            output.WriteRawTag(10);
            output.WriteBytes(Unknown71);
          }
          if (Unknown72 != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(Unknown72);
          }
          if (Unknown73.Length != 0) {
            output.WriteRawTag(26);
            output.WriteBytes(Unknown73);
          }
        }

        public int CalculateSize() {
          int size = 0;
          if (Unknown71.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(Unknown71);
          }
          if (Unknown72 != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(Unknown72);
          }
          if (Unknown73.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(Unknown73);
          }
          return size;
        }

        public void MergeFrom(Unknown7 other) {
          if (other == null) {
            return;
          }
          if (other.Unknown71.Length != 0) {
            Unknown71 = other.Unknown71;
          }
          if (other.Unknown72 != 0L) {
            Unknown72 = other.Unknown72;
          }
          if (other.Unknown73.Length != 0) {
            Unknown73 = other.Unknown73;
          }
        }

        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 10: {
                Unknown71 = input.ReadBytes();
                break;
              }
              case 16: {
                Unknown72 = input.ReadInt64();
                break;
              }
              case 26: {
                Unknown73 = input.ReadBytes();
                break;
              }
            }
          }
        }

      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Payload : pb::IMessage<Payload> {
        private static readonly pb::MessageParser<Payload> _parser = new pb::MessageParser<Payload>(() => new Payload());
        public static pb::MessageParser<Payload> Parser { get { return _parser; } }

        public static pbr::MessageDescriptor Descriptor {
          get { return global::PokemonGo.RocketAPI.GeneratedCode.EncounterResponse.Descriptor.NestedTypes[2]; }
        }

        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        public Payload() {
          OnConstruction();
        }

        partial void OnConstruction();

        public Payload(Payload other) : this() {
          pokemon_ = other.pokemon_;
          background_ = other.background_;
          status_ = other.status_;
          captureProbability_ = other.captureProbability_;
        }

        public Payload Clone() {
          return new Payload(this);
        }

        /// <summary>Field number for the "Pokemon" field.</summary>
        public const int PokemonFieldNumber = 1;
        private int pokemon_;
        public int Pokemon {
          get { return pokemon_; }
          set {
            pokemon_ = value;
          }
        }

        /// <summary>Field number for the "Background" field.</summary>
        public const int BackgroundFieldNumber = 2;
        private int background_;
        public int Background {
          get { return background_; }
          set {
            background_ = value;
          }
        }

        /// <summary>Field number for the "Status" field.</summary>
        public const int StatusFieldNumber = 3;
        private int status_;
        public int Status {
          get { return status_; }
          set {
            status_ = value;
          }
        }

        /// <summary>Field number for the "CaptureProbability" field.</summary>
        public const int CaptureProbabilityFieldNumber = 4;
        private int captureProbability_;
        public int CaptureProbability {
          get { return captureProbability_; }
          set {
            captureProbability_ = value;
          }
        }

        public override bool Equals(object other) {
          return Equals(other as Payload);
        }

        public bool Equals(Payload other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Pokemon != other.Pokemon) return false;
          if (Background != other.Background) return false;
          if (Status != other.Status) return false;
          if (CaptureProbability != other.CaptureProbability) return false;
          return true;
        }

        public override int GetHashCode() {
          int hash = 1;
          if (Pokemon != 0) hash ^= Pokemon.GetHashCode();
          if (Background != 0) hash ^= Background.GetHashCode();
          if (Status != 0) hash ^= Status.GetHashCode();
          if (CaptureProbability != 0) hash ^= CaptureProbability.GetHashCode();
          return hash;
        }

        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        public void WriteTo(pb::CodedOutputStream output) {
          if (Pokemon != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(Pokemon);
          }
          if (Background != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(Background);
          }
          if (Status != 0) {
            output.WriteRawTag(24);
            output.WriteInt32(Status);
          }
          if (CaptureProbability != 0) {
            output.WriteRawTag(32);
            output.WriteInt32(CaptureProbability);
          }
        }

        public int CalculateSize() {
          int size = 0;
          if (Pokemon != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Pokemon);
          }
          if (Background != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Background);
          }
          if (Status != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Status);
          }
          if (CaptureProbability != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(CaptureProbability);
          }
          return size;
        }

        public void MergeFrom(Payload other) {
          if (other == null) {
            return;
          }
          if (other.Pokemon != 0) {
            Pokemon = other.Pokemon;
          }
          if (other.Background != 0) {
            Background = other.Background;
          }
          if (other.Status != 0) {
            Status = other.Status;
          }
          if (other.CaptureProbability != 0) {
            CaptureProbability = other.CaptureProbability;
          }
        }

        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 8: {
                Pokemon = input.ReadInt32();
                break;
              }
              case 16: {
                Background = input.ReadInt32();
                break;
              }
              case 24: {
                Status = input.ReadInt32();
                break;
              }
              case 32: {
                CaptureProbability = input.ReadInt32();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
