// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/user_list_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/services/user_list_service.proto</summary>
  public static partial class UserListServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/services/user_list_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9zZXJ2aWNlcy91c2VyX2xpc3Rf",
            "c2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuc2Vydmlj",
            "ZXMaMWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YwL3Jlc291cmNlcy91c2VyX2xp",
            "c3QucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aIGdvb2ds",
            "ZS9wcm90b2J1Zi9maWVsZF9tYXNrLnByb3RvIisKEkdldFVzZXJMaXN0UmVx",
            "dWVzdBIVCg1yZXNvdXJjZV9uYW1lGAEgASgJInYKFk11dGF0ZVVzZXJMaXN0",
            "c1JlcXVlc3QSEwoLY3VzdG9tZXJfaWQYASABKAkSRwoKb3BlcmF0aW9ucxgC",
            "IAMoCzIzLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnNlcnZpY2VzLlVzZXJM",
            "aXN0T3BlcmF0aW9uIuEBChFVc2VyTGlzdE9wZXJhdGlvbhIvCgt1cGRhdGVf",
            "bWFzaxgEIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE1hc2sSPQoGY3Jl",
            "YXRlGAEgASgLMisuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAucmVzb3VyY2Vz",
            "LlVzZXJMaXN0SAASPQoGdXBkYXRlGAIgASgLMisuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjAucmVzb3VyY2VzLlVzZXJMaXN0SAASEAoGcmVtb3ZlGAMgASgJ",
            "SABCCwoJb3BlcmF0aW9uImIKF011dGF0ZVVzZXJMaXN0c1Jlc3BvbnNlEkcK",
            "B3Jlc3VsdHMYAiADKAsyNi5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5zZXJ2",
            "aWNlcy5NdXRhdGVVc2VyTGlzdFJlc3VsdCItChRNdXRhdGVVc2VyTGlzdFJl",
            "c3VsdBIVCg1yZXNvdXJjZV9uYW1lGAEgASgJMv0CCg9Vc2VyTGlzdFNlcnZp",
            "Y2USpQEKC0dldFVzZXJMaXN0EjQuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAu",
            "c2VydmljZXMuR2V0VXNlckxpc3RSZXF1ZXN0GisuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjAucmVzb3VyY2VzLlVzZXJMaXN0IjOC0+STAi0SKy92MC97cmVz",
            "b3VyY2VfbmFtZT1jdXN0b21lcnMvKi91c2VyTGlzdHMvKn0SwQEKD011dGF0",
            "ZVVzZXJMaXN0cxI4Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnNlcnZpY2Vz",
            "Lk11dGF0ZVVzZXJMaXN0c1JlcXVlc3QaOS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MC5zZXJ2aWNlcy5NdXRhdGVVc2VyTGlzdHNSZXNwb25zZSI5gtPkkwIz",
            "Ii4vdjAvY3VzdG9tZXJzL3tjdXN0b21lcl9pZD0qfS91c2VyTGlzdHM6bXV0",
            "YXRlOgEqQtQBCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuc2Vydmlj",
            "ZXNCFFVzZXJMaXN0U2VydmljZVByb3RvUAFaSGdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MC9zZXJ2aWNl",
            "cztzZXJ2aWNlc6ICA0dBQaoCIEdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLlNl",
            "cnZpY2VzygIgR29vZ2xlXEFkc1xHb29nbGVBZHNcVjBcU2VydmljZXNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Resources.UserListReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.GetUserListRequest), global::Google.Ads.GoogleAds.V0.Services.GetUserListRequest.Parser, new[]{ "ResourceName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.MutateUserListsRequest), global::Google.Ads.GoogleAds.V0.Services.MutateUserListsRequest.Parser, new[]{ "CustomerId", "Operations" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.UserListOperation), global::Google.Ads.GoogleAds.V0.Services.UserListOperation.Parser, new[]{ "UpdateMask", "Create", "Update", "Remove" }, new[]{ "Operation" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.MutateUserListsResponse), global::Google.Ads.GoogleAds.V0.Services.MutateUserListsResponse.Parser, new[]{ "Results" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.MutateUserListResult), global::Google.Ads.GoogleAds.V0.Services.MutateUserListResult.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [UserListService.GetUserList][google.ads.googleads.v0.services.UserListService.GetUserList].
  /// </summary>
  public sealed partial class GetUserListRequest : pb::IMessage<GetUserListRequest> {
    private static readonly pb::MessageParser<GetUserListRequest> _parser = new pb::MessageParser<GetUserListRequest>(() => new GetUserListRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetUserListRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.UserListServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUserListRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUserListRequest(GetUserListRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUserListRequest Clone() {
      return new GetUserListRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the user list to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetUserListRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetUserListRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetUserListRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Request message for [UserListService.MutateUserLists][google.ads.googleads.v0.services.UserListService.MutateUserLists].
  /// </summary>
  public sealed partial class MutateUserListsRequest : pb::IMessage<MutateUserListsRequest> {
    private static readonly pb::MessageParser<MutateUserListsRequest> _parser = new pb::MessageParser<MutateUserListsRequest>(() => new MutateUserListsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateUserListsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.UserListServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateUserListsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateUserListsRequest(MutateUserListsRequest other) : this() {
      customerId_ = other.customerId_;
      operations_ = other.operations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateUserListsRequest Clone() {
      return new MutateUserListsRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// The ID of the customer whose user lists are being modified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "operations" field.</summary>
    public const int OperationsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Services.UserListOperation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V0.Services.UserListOperation.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.UserListOperation> operations_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.UserListOperation>();
    /// <summary>
    /// The list of operations to perform on individual user lists.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.UserListOperation> Operations {
      get { return operations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateUserListsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateUserListsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if(!operations_.Equals(other.operations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      hash ^= operations_.GetHashCode();
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
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      operations_.WriteTo(output, _repeated_operations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      size += operations_.CalculateSize(_repeated_operations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateUserListsRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      operations_.Add(other.operations_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A single operation (create, update) on a user list.
  /// </summary>
  public sealed partial class UserListOperation : pb::IMessage<UserListOperation> {
    private static readonly pb::MessageParser<UserListOperation> _parser = new pb::MessageParser<UserListOperation>(() => new UserListOperation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListOperation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.UserListServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListOperation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListOperation(UserListOperation other) : this() {
      updateMask_ = other.updateMask_ != null ? other.updateMask_.Clone() : null;
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          Create = other.Create.Clone();
          break;
        case OperationOneofCase.Update:
          Update = other.Update.Clone();
          break;
        case OperationOneofCase.Remove:
          Remove = other.Remove;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListOperation Clone() {
      return new UserListOperation(this);
    }

    /// <summary>Field number for the "update_mask" field.</summary>
    public const int UpdateMaskFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
    /// <summary>
    /// FieldMask that determines which resource fields are modified in an update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.FieldMask UpdateMask {
      get { return updateMask_; }
      set {
        updateMask_ = value;
      }
    }

    /// <summary>Field number for the "create" field.</summary>
    public const int CreateFieldNumber = 1;
    /// <summary>
    /// Create operation: No resource name is expected for the new user list.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Resources.UserList Create {
      get { return operationCase_ == OperationOneofCase.Create ? (global::Google.Ads.GoogleAds.V0.Resources.UserList) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Create;
      }
    }

    /// <summary>Field number for the "update" field.</summary>
    public const int UpdateFieldNumber = 2;
    /// <summary>
    /// Update operation: The user list is expected to have a valid resource
    /// name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Resources.UserList Update {
      get { return operationCase_ == OperationOneofCase.Update ? (global::Google.Ads.GoogleAds.V0.Resources.UserList) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Update;
      }
    }

    /// <summary>Field number for the "remove" field.</summary>
    public const int RemoveFieldNumber = 3;
    /// <summary>
    /// Remove operation: A resource name for the removed user list is expected,
    /// in this format:
    ///
    /// `customers/{customer_id}/userLists/{user_list_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Remove {
      get { return operationCase_ == OperationOneofCase.Remove ? (string) operation_ : ""; }
      set {
        operation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        operationCase_ = OperationOneofCase.Remove;
      }
    }

    private object operation_;
    /// <summary>Enum of possible cases for the "operation" oneof.</summary>
    public enum OperationOneofCase {
      None = 0,
      Create = 1,
      Update = 2,
      Remove = 3,
    }
    private OperationOneofCase operationCase_ = OperationOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationOneofCase OperationCase {
      get { return operationCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearOperation() {
      operationCase_ = OperationOneofCase.None;
      operation_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListOperation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListOperation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UpdateMask, other.UpdateMask)) return false;
      if (!object.Equals(Create, other.Create)) return false;
      if (!object.Equals(Update, other.Update)) return false;
      if (Remove != other.Remove) return false;
      if (OperationCase != other.OperationCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
      if (operationCase_ == OperationOneofCase.Create) hash ^= Create.GetHashCode();
      if (operationCase_ == OperationOneofCase.Update) hash ^= Update.GetHashCode();
      if (operationCase_ == OperationOneofCase.Remove) hash ^= Remove.GetHashCode();
      hash ^= (int) operationCase_;
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
      if (operationCase_ == OperationOneofCase.Create) {
        output.WriteRawTag(10);
        output.WriteMessage(Create);
      }
      if (operationCase_ == OperationOneofCase.Update) {
        output.WriteRawTag(18);
        output.WriteMessage(Update);
      }
      if (operationCase_ == OperationOneofCase.Remove) {
        output.WriteRawTag(26);
        output.WriteString(Remove);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (updateMask_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateMask);
      }
      if (operationCase_ == OperationOneofCase.Create) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Create);
      }
      if (operationCase_ == OperationOneofCase.Update) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Update);
      }
      if (operationCase_ == OperationOneofCase.Remove) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Remove);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserListOperation other) {
      if (other == null) {
        return;
      }
      if (other.updateMask_ != null) {
        if (updateMask_ == null) {
          updateMask_ = new global::Google.Protobuf.WellKnownTypes.FieldMask();
        }
        UpdateMask.MergeFrom(other.UpdateMask);
      }
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          if (Create == null) {
            Create = new global::Google.Ads.GoogleAds.V0.Resources.UserList();
          }
          Create.MergeFrom(other.Create);
          break;
        case OperationOneofCase.Update:
          if (Update == null) {
            Update = new global::Google.Ads.GoogleAds.V0.Resources.UserList();
          }
          Update.MergeFrom(other.Update);
          break;
        case OperationOneofCase.Remove:
          Remove = other.Remove;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            global::Google.Ads.GoogleAds.V0.Resources.UserList subBuilder = new global::Google.Ads.GoogleAds.V0.Resources.UserList();
            if (operationCase_ == OperationOneofCase.Create) {
              subBuilder.MergeFrom(Create);
            }
            input.ReadMessage(subBuilder);
            Create = subBuilder;
            break;
          }
          case 18: {
            global::Google.Ads.GoogleAds.V0.Resources.UserList subBuilder = new global::Google.Ads.GoogleAds.V0.Resources.UserList();
            if (operationCase_ == OperationOneofCase.Update) {
              subBuilder.MergeFrom(Update);
            }
            input.ReadMessage(subBuilder);
            Update = subBuilder;
            break;
          }
          case 26: {
            Remove = input.ReadString();
            break;
          }
          case 34: {
            if (updateMask_ == null) {
              updateMask_ = new global::Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(updateMask_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for user list mutate.
  /// </summary>
  public sealed partial class MutateUserListsResponse : pb::IMessage<MutateUserListsResponse> {
    private static readonly pb::MessageParser<MutateUserListsResponse> _parser = new pb::MessageParser<MutateUserListsResponse>(() => new MutateUserListsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateUserListsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.UserListServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateUserListsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateUserListsResponse(MutateUserListsResponse other) : this() {
      results_ = other.results_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateUserListsResponse Clone() {
      return new MutateUserListsResponse(this);
    }

    /// <summary>Field number for the "results" field.</summary>
    public const int ResultsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Services.MutateUserListResult> _repeated_results_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V0.Services.MutateUserListResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.MutateUserListResult> results_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.MutateUserListResult>();
    /// <summary>
    /// All results for the mutate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.MutateUserListResult> Results {
      get { return results_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateUserListsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateUserListsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!results_.Equals(other.results_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= results_.GetHashCode();
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
      results_.WriteTo(output, _repeated_results_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += results_.CalculateSize(_repeated_results_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateUserListsResponse other) {
      if (other == null) {
        return;
      }
      results_.Add(other.results_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            results_.AddEntriesFrom(input, _repeated_results_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The result for the user list mutate.
  /// </summary>
  public sealed partial class MutateUserListResult : pb::IMessage<MutateUserListResult> {
    private static readonly pb::MessageParser<MutateUserListResult> _parser = new pb::MessageParser<MutateUserListResult>(() => new MutateUserListResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateUserListResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.UserListServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateUserListResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateUserListResult(MutateUserListResult other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateUserListResult Clone() {
      return new MutateUserListResult(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Returned for successful operations.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateUserListResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateUserListResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateUserListResult other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
