//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// fal REST API for programmatic access to platform resources.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Production server
        /// </summary>
        public const string DefaultBaseUrl = "https://api.fal.ai/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::G.AutoSDKClientOptions Options { get; }


        /// <inheritdoc/>
        public global::System.Func<string> CreateIdempotencyKey { get; set; } = () => global::System.Guid.NewGuid().ToString("D");
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.EstimatePricingRequestVariant1EstimateTypeJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingRequestVariant1EstimateTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingRequestVariant2EstimateTypeJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingRequestVariant2EstimateTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsHistoryRequestItemConditionTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsHistoryRequestItemConditionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsStreamRequestItemConditionTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsStreamRequestItemConditionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceRequestInstanceTypeJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceRequestInstanceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceRequestSectorJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceRequestSectorNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelsStatusJsonConverter(),
                    new global::G.JsonConverters.GetModelsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetUsageTimeframeJsonConverter(),
                    new global::G.JsonConverters.GetUsageTimeframeNullableJsonConverter(),
                    new global::G.JsonConverters.GetUsageBoundToTimeframeJsonConverter(),
                    new global::G.JsonConverters.GetUsageBoundToTimeframeNullableJsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsTimeframeJsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsTimeframeNullableJsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsBoundToTimeframeJsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsBoundToTimeframeNullableJsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointStatusJsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointSortByJsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointSortByNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsHistoryRunSourceJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsHistoryRunSourceNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsStreamRunSourceJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsStreamRunSourceNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointStatusJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointSortByJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointSortByNullableJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportSourceJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportSourceNullableJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportTimeframeJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportTimeframeNullableJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportBoundToTimeframeJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportBoundToTimeframeNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseModelMetadataStatusJsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseModelMetadataStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseModelMetadataLicenseTypeJsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseModelMetadataLicenseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseModelMetadataKindJsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseModelMetadataKindNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseModelEnterpriseStatusEnumJsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseModelEnterpriseStatusEnumNullableJsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetPricingResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetPricingResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseEstimateTypeJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseEstimateTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetUsageResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetUsageResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetBillingEventsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetBillingEventsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SearchRequestsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.SearchRequestsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListWorkflowsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ListWorkflowsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRootResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRootResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListDirectoryResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessListDirectoryResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessDownloadFileResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessDownloadFileResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadFromUrlResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadFromUrlResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadLocalFileResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadLocalFileResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetMetricsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetMetricsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsHistoryResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsHistoryResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsStreamResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsStreamResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseInstanceInstanceTypeJsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseInstanceInstanceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseInstanceRegionJsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseInstanceRegionNullableJsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseInstanceSectorJsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseInstanceSectorNullableJsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseInstanceStatusJsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseInstanceStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseInstanceTypeJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseInstanceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseRegionJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseRegionNullableJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseSectorJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseSectorNullableJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseStatusJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseInstanceTypeJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseInstanceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseRegionJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseRegionNullableJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseSectorJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseSectorNullableJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseStatusJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteComputeInstanceResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.DeleteComputeInstanceResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseKeyScopeJsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseKeyScopeNullableJsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateApiKeyResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateApiKeyResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteApiKeyResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.DeleteApiKeyResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetAccountBillingResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetAccountBillingResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetMetaResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetMetaResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.EstimatePricingRequestVariant1, global::G.EstimatePricingRequestVariant2>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.GetModelsResponseModelOpenapiVariant1, global::G.GetModelsResponseModelOpenapiVariant2>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.GetModelsResponseModelEnterpriseStatusEnum?, global::G.GetModelsResponseModelEnterpriseStatusEnum2>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AccountClient Account => new AccountClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ComputeClient Compute => new ComputeClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public KeysClient Keys => new KeysClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetaClient Meta => new MetaClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ServerlessClient Serverless => new ServerlessClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WorkflowsClient Workflows => new WorkflowsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            CreateIdempotencyKey = CreateIdempotencyKey,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the Api with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations,
            global::G.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations,
            global::G.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            Options = options ?? new global::G.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}