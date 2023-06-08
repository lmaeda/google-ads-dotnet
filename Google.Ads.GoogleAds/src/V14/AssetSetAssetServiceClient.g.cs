// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V14.Services
{
    /// <summary>Settings for <see cref="AssetSetAssetServiceClient"/> instances.</summary>
    public sealed partial class AssetSetAssetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssetSetAssetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssetSetAssetServiceSettings"/>.</returns>
        public static AssetSetAssetServiceSettings GetDefault() => new AssetSetAssetServiceSettings();

        /// <summary>Constructs a new <see cref="AssetSetAssetServiceSettings"/> object with default settings.</summary>
        public AssetSetAssetServiceSettings()
        {
        }

        private AssetSetAssetServiceSettings(AssetSetAssetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAssetSetAssetsSettings = existing.MutateAssetSetAssetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssetSetAssetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetSetAssetServiceClient.MutateAssetSetAssets</c> and
        /// <c>AssetSetAssetServiceClient.MutateAssetSetAssetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateAssetSetAssetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssetSetAssetServiceSettings"/> object.</returns>
        public AssetSetAssetServiceSettings Clone() => new AssetSetAssetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssetSetAssetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AssetSetAssetServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssetSetAssetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssetSetAssetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AssetSetAssetServiceClientBuilder() : base(AssetSetAssetServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AssetSetAssetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssetSetAssetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssetSetAssetServiceClient Build()
        {
            AssetSetAssetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssetSetAssetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssetSetAssetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssetSetAssetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssetSetAssetServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<AssetSetAssetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssetSetAssetServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssetSetAssetServiceClient.ChannelPool;
    }

    /// <summary>AssetSetAssetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage asset set asset.
    /// </remarks>
    public abstract partial class AssetSetAssetServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssetSetAssetService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AssetSetAssetService scopes.</summary>
        /// <remarks>
        /// The default AssetSetAssetService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AssetSetAssetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AssetSetAssetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AssetSetAssetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AssetSetAssetServiceClient"/>.</returns>
        public static stt::Task<AssetSetAssetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssetSetAssetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssetSetAssetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AssetSetAssetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssetSetAssetServiceClient"/>.</returns>
        public static AssetSetAssetServiceClient Create() => new AssetSetAssetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssetSetAssetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssetSetAssetServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AssetSetAssetServiceClient"/>.</returns>
        internal static AssetSetAssetServiceClient Create(grpccore::CallInvoker callInvoker, AssetSetAssetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssetSetAssetService.AssetSetAssetServiceClient grpcClient = new AssetSetAssetService.AssetSetAssetServiceClient(callInvoker);
            return new AssetSetAssetServiceClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC AssetSetAssetService client</summary>
        public virtual AssetSetAssetService.AssetSetAssetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes asset set assets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAssetSetAssetsResponse MutateAssetSetAssets(MutateAssetSetAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes asset set assets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetSetAssetsResponse> MutateAssetSetAssetsAsync(MutateAssetSetAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes asset set assets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetSetAssetsResponse> MutateAssetSetAssetsAsync(MutateAssetSetAssetsRequest request, st::CancellationToken cancellationToken) =>
            MutateAssetSetAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes asset set assets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset set assets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset set assets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAssetSetAssetsResponse MutateAssetSetAssets(string customerId, scg::IEnumerable<AssetSetAssetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAssetSetAssets(new MutateAssetSetAssetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes asset set assets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset set assets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset set assets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetSetAssetsResponse> MutateAssetSetAssetsAsync(string customerId, scg::IEnumerable<AssetSetAssetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAssetSetAssetsAsync(new MutateAssetSetAssetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes asset set assets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset set assets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset set assets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetSetAssetsResponse> MutateAssetSetAssetsAsync(string customerId, scg::IEnumerable<AssetSetAssetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAssetSetAssetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AssetSetAssetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage asset set asset.
    /// </remarks>
    public sealed partial class AssetSetAssetServiceClientImpl : AssetSetAssetServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAssetSetAssetsRequest, MutateAssetSetAssetsResponse> _callMutateAssetSetAssets;

        /// <summary>
        /// Constructs a client wrapper for the AssetSetAssetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AssetSetAssetServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AssetSetAssetServiceClientImpl(AssetSetAssetService.AssetSetAssetServiceClient grpcClient, AssetSetAssetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AssetSetAssetServiceSettings effectiveSettings = settings ?? AssetSetAssetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateAssetSetAssets = clientHelper.BuildApiCall<MutateAssetSetAssetsRequest, MutateAssetSetAssetsResponse>("MutateAssetSetAssets", grpcClient.MutateAssetSetAssetsAsync, grpcClient.MutateAssetSetAssets, effectiveSettings.MutateAssetSetAssetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAssetSetAssets);
            Modify_MutateAssetSetAssetsApiCall(ref _callMutateAssetSetAssets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAssetSetAssetsApiCall(ref gaxgrpc::ApiCall<MutateAssetSetAssetsRequest, MutateAssetSetAssetsResponse> call);

        partial void OnConstruction(AssetSetAssetService.AssetSetAssetServiceClient grpcClient, AssetSetAssetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssetSetAssetService client</summary>
        public override AssetSetAssetService.AssetSetAssetServiceClient GrpcClient { get; }

        partial void Modify_MutateAssetSetAssetsRequest(ref MutateAssetSetAssetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes asset set assets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAssetSetAssetsResponse MutateAssetSetAssets(MutateAssetSetAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAssetSetAssetsRequest(ref request, ref callSettings);
            return _callMutateAssetSetAssets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes asset set assets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAssetSetAssetsResponse> MutateAssetSetAssetsAsync(MutateAssetSetAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAssetSetAssetsRequest(ref request, ref callSettings);
            return _callMutateAssetSetAssets.Async(request, callSettings);
        }
    }
}
