// Copyright 2022 Google LLC
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
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V11.Services;

namespace Google.Ads.GoogleAds.Tests.V11.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGeoTargetConstantServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void SuggestGeoTargetConstantsRequestObject()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            SuggestGeoTargetConstantsRequest request = new SuggestGeoTargetConstantsRequest
            {
                LocationNames = new SuggestGeoTargetConstantsRequest.Types.LocationNames(),
                GeoTargets = new SuggestGeoTargetConstantsRequest.Types.GeoTargets(),
                Locale = "locale9e6d21fb",
                CountryCode = "country_code8debec55",
            };
            SuggestGeoTargetConstantsResponse expectedResponse = new SuggestGeoTargetConstantsResponse
            {
                GeoTargetConstantSuggestions =
                {
                    new GeoTargetConstantSuggestion(),
                },
            };
            mockGrpcClient.Setup(x => x.SuggestGeoTargetConstants(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null, null);
            SuggestGeoTargetConstantsResponse response = client.SuggestGeoTargetConstants(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task SuggestGeoTargetConstantsRequestObjectAsync()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            SuggestGeoTargetConstantsRequest request = new SuggestGeoTargetConstantsRequest
            {
                LocationNames = new SuggestGeoTargetConstantsRequest.Types.LocationNames(),
                GeoTargets = new SuggestGeoTargetConstantsRequest.Types.GeoTargets(),
                Locale = "locale9e6d21fb",
                CountryCode = "country_code8debec55",
            };
            SuggestGeoTargetConstantsResponse expectedResponse = new SuggestGeoTargetConstantsResponse
            {
                GeoTargetConstantSuggestions =
                {
                    new GeoTargetConstantSuggestion(),
                },
            };
            mockGrpcClient.Setup(x => x.SuggestGeoTargetConstantsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestGeoTargetConstantsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null, null);
            SuggestGeoTargetConstantsResponse responseCallSettings = await client.SuggestGeoTargetConstantsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            SuggestGeoTargetConstantsResponse responseCancellationToken = await client.SuggestGeoTargetConstantsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
