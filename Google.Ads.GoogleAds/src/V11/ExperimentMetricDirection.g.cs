// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/enums/experiment_metric_direction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/enums/experiment_metric_direction.proto</summary>
  public static partial class ExperimentMetricDirectionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/enums/experiment_metric_direction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExperimentMetricDirectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZW51bXMvZXhwZXJpbWVudF9t",
            "ZXRyaWNfZGlyZWN0aW9uLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTEuZW51bXMivAEKHUV4cGVyaW1lbnRNZXRyaWNEaXJlY3Rpb25FbnVtIpoB",
            "ChlFeHBlcmltZW50TWV0cmljRGlyZWN0aW9uEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEg0KCU5PX0NIQU5HRRACEgwKCElOQ1JFQVNFEAMSDAoI",
            "REVDUkVBU0UQBBIZChVOT19DSEFOR0VfT1JfSU5DUkVBU0UQBRIZChVOT19D",
            "SEFOR0VfT1JfREVDUkVBU0UQBkL4AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxMS5lbnVtc0IeRXhwZXJpbWVudE1ldHJpY0RpcmVjdGlvblByb3Rv",
            "UAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRz",
            "L2dvb2dsZWFkcy92MTEvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WMTEuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "MTFcRW51bXPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTE6OkVudW1z",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Enums.ExperimentMetricDirectionEnum), global::Google.Ads.GoogleAds.V11.Enums.ExperimentMetricDirectionEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Enums.ExperimentMetricDirectionEnum.Types.ExperimentMetricDirection) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the type of experiment metric direction.
  /// </summary>
  public sealed partial class ExperimentMetricDirectionEnum : pb::IMessage<ExperimentMetricDirectionEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExperimentMetricDirectionEnum> _parser = new pb::MessageParser<ExperimentMetricDirectionEnum>(() => new ExperimentMetricDirectionEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExperimentMetricDirectionEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Enums.ExperimentMetricDirectionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExperimentMetricDirectionEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExperimentMetricDirectionEnum(ExperimentMetricDirectionEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExperimentMetricDirectionEnum Clone() {
      return new ExperimentMetricDirectionEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExperimentMetricDirectionEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExperimentMetricDirectionEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExperimentMetricDirectionEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ExperimentMetricDirectionEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The type of experiment metric direction.
      /// </summary>
      public enum ExperimentMetricDirection {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The goal of the experiment is to not change the metric.
        /// </summary>
        [pbr::OriginalName("NO_CHANGE")] NoChange = 2,
        /// <summary>
        /// The goal of the experiment is to increate the metric.
        /// </summary>
        [pbr::OriginalName("INCREASE")] Increase = 3,
        /// <summary>
        /// The goal of the experiment is to decrease the metric.
        /// </summary>
        [pbr::OriginalName("DECREASE")] Decrease = 4,
        /// <summary>
        /// The goal of the experiment is to either not change or increase the
        /// metric.
        /// </summary>
        [pbr::OriginalName("NO_CHANGE_OR_INCREASE")] NoChangeOrIncrease = 5,
        /// <summary>
        /// The goal of the experiment is to either not change or decrease the
        /// metric.
        /// </summary>
        [pbr::OriginalName("NO_CHANGE_OR_DECREASE")] NoChangeOrDecrease = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
