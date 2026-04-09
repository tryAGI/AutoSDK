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
                    new global::G.JsonConverters.GetModelsResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.GetModelsResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.GetPricingResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetPricingResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetPricingResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.GetPricingResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.GetPricingResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.GetPricingResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.GetPricingResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.GetPricingResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseEstimateTypeJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseEstimateTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.EstimatePricingResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.GetUsageResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetUsageResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetUsageResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.GetUsageResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.GetUsageResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.GetUsageResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.GetUsageResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.GetUsageResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.GetUsageResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.GetUsageResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.GetAnalyticsResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.GetBillingEventsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetBillingEventsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetBillingEventsResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.GetBillingEventsResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.GetBillingEventsResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.GetBillingEventsResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.GetBillingEventsResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.GetBillingEventsResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.GetBillingEventsResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.GetBillingEventsResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorType6JsonConverter(),
                    new global::G.JsonConverters.DeleteRequestPayloadsResponseErrorType6NullableJsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.ListRequestsByEndpointResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.SearchRequestsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.SearchRequestsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SearchRequestsResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.SearchRequestsResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.SearchRequestsResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.SearchRequestsResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.SearchRequestsResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.SearchRequestsResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.ListWorkflowsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ListWorkflowsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListWorkflowsResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ListWorkflowsResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ListWorkflowsResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ListWorkflowsResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ListWorkflowsResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.ListWorkflowsResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorType6JsonConverter(),
                    new global::G.JsonConverters.GetWorkflowResponseErrorType6NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorType6JsonConverter(),
                    new global::G.JsonConverters.ServerlessFlushAppQueueResponseErrorType6NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRootResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRootResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRootResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ServerlessListRootResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRootResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ServerlessListRootResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListDirectoryResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessListDirectoryResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListDirectoryResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ServerlessListDirectoryResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListDirectoryResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ServerlessListDirectoryResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessDownloadFileResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessDownloadFileResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessDownloadFileResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ServerlessDownloadFileResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessDownloadFileResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ServerlessDownloadFileResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessDownloadFileResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.ServerlessDownloadFileResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadFromUrlResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadFromUrlResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadFromUrlResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadFromUrlResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadFromUrlResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadFromUrlResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadLocalFileResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadLocalFileResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadLocalFileResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadLocalFileResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadLocalFileResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadLocalFileResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadLocalFileResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.ServerlessUploadLocalFileResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetMetricsResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetMetricsResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetMetricsResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ServerlessGetMetricsResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessGetMetricsResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ServerlessGetMetricsResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsHistoryResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsHistoryResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsHistoryResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsHistoryResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsHistoryResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsHistoryResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsStreamResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsStreamResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsStreamResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsStreamResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsStreamResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ServerlessLogsStreamResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType6JsonConverter(),
                    new global::G.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType6NullableJsonConverter(),
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
                    new global::G.JsonConverters.ListComputeInstancesResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.ListComputeInstancesResponseErrorType4NullableJsonConverter(),
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
                    new global::G.JsonConverters.CreateComputeInstanceResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.CreateComputeInstanceResponseErrorType5NullableJsonConverter(),
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
                    new global::G.JsonConverters.GetComputeInstanceResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.GetComputeInstanceResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteComputeInstanceResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.DeleteComputeInstanceResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteComputeInstanceResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.DeleteComputeInstanceResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteComputeInstanceResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.DeleteComputeInstanceResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteComputeInstanceResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.DeleteComputeInstanceResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteComputeInstanceResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.DeleteComputeInstanceResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseKeyScopeJsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseKeyScopeNullableJsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.ListApiKeysResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.CreateApiKeyResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateApiKeyResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateApiKeyResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.CreateApiKeyResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.CreateApiKeyResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.CreateApiKeyResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.CreateApiKeyResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.CreateApiKeyResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.CreateApiKeyResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.CreateApiKeyResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteApiKeyResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.DeleteApiKeyResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteApiKeyResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.DeleteApiKeyResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteApiKeyResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.DeleteApiKeyResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.DeleteApiKeyResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.DeleteApiKeyResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.GetAccountBillingResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetAccountBillingResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetAccountBillingResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.GetAccountBillingResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.GetAccountBillingResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.GetAccountBillingResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.GetAccountBillingResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.GetAccountBillingResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.GetAccountBillingResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.GetAccountBillingResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.GetFocusReportResponseErrorType2NullableJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportResponseErrorType3JsonConverter(),
                    new global::G.JsonConverters.GetFocusReportResponseErrorType3NullableJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportResponseErrorType4JsonConverter(),
                    new global::G.JsonConverters.GetFocusReportResponseErrorType4NullableJsonConverter(),
                    new global::G.JsonConverters.GetFocusReportResponseErrorType5JsonConverter(),
                    new global::G.JsonConverters.GetFocusReportResponseErrorType5NullableJsonConverter(),
                    new global::G.JsonConverters.GetMetaResponseErrorTypeJsonConverter(),
                    new global::G.JsonConverters.GetMetaResponseErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetMetaResponseErrorType2JsonConverter(),
                    new global::G.JsonConverters.GetMetaResponseErrorType2NullableJsonConverter(),
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
        public AccountClient Account => new AccountClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ComputeClient Compute => new ComputeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public KeysClient Keys => new KeysClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetaClient Meta => new MetaClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ServerlessClient Serverless => new ServerlessClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WorkflowsClient Workflows => new WorkflowsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
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
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
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