//HintName: G.JsonSerializerContextTypes.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::G.OneOf<global::G.EstimatePricingRequestVariant1, global::G.EstimatePricingRequestVariant2>? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingRequestVariant1? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingRequestVariant1EstimateType? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::G.EstimatePricingRequestVariant1Endpoints2>? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingRequestVariant1Endpoints2? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingRequestVariant2? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingRequestVariant2EstimateType? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::G.EstimatePricingRequestVariant2Endpoints2>? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingRequestVariant2Endpoints2? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessUploadFromUrlRequest? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessUploadLocalFileRequest? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ServerlessLogsHistoryRequestItem>? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsHistoryRequestItem? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsHistoryRequestItemConditionType? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ServerlessLogsStreamRequestItem>? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsStreamRequestItem? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsStreamRequestItemConditionType? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceRequest? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceRequestInstanceType? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceRequestSector? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiKeyRequest? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsStatus? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<global::System.DateTime?, string>? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageTimeframe? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageBoundToTimeframe? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsTimeframe? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsBoundToTimeframe? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRequestsByEndpointStatus? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRequestsByEndpointSortBy? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsHistoryRunSource? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsStreamRunSource? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRequestsByEndpointStatus? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRequestsByEndpointSortBy? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetFocusReportSource? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetFocusReportTimeframe? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetFocusReportBoundToTimeframe? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponse? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetModelsResponseModel>? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseModel? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseModelMetadata? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseModelMetadataStatus? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseModelMetadataLicenseType? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseModelMetadataGroup? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseModelMetadataKind? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<global::G.GetModelsResponseModelOpenapiVariant1, global::G.GetModelsResponseModelOpenapiVariant2>? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseModelOpenapiVariant1? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseModelOpenapiVariant2? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseModelOpenapiVariant2Error? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<global::G.GetModelsResponseModelEnterpriseStatusEnum?, global::G.GetModelsResponseModelEnterpriseStatusEnum2>? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseModelEnterpriseStatusEnum? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseModelEnterpriseStatusEnum2? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseModelEnterpriseStatusEnumError? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponse2? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseError? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponseErrorType? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponse3? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponse4? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetModelsResponse5? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetPricingResponse? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetPricingResponsePrice>? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetPricingResponsePrice? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetPricingResponse2? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetPricingResponseError? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetPricingResponseErrorType? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetPricingResponse3? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetPricingResponse4? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetPricingResponse5? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingResponse? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingResponseEstimateType? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingResponse2? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingResponseError? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingResponseErrorType? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingResponse3? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingResponse4? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.EstimatePricingResponse5? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageResponse? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetUsageResponseTimeSerie>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageResponseTimeSerie? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetUsageResponseTimeSerieResult>? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageResponseTimeSerieResult? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetUsageResponseSummaryItem>? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageResponseSummaryItem? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageResponse2? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageResponseError? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageResponseErrorType? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageResponse3? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageResponse4? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageResponse5? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetUsageResponse6? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsResponse? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsResponseTimeSerie>? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsResponseTimeSerie? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsResponseTimeSerieResult>? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsResponseTimeSerieResult? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsResponseSummaryItem>? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsResponseSummaryItem? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsResponse2? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsResponseError? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsResponseErrorType? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsResponse3? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsResponse4? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsResponse5? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnalyticsResponse6? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetBillingEventsResponse? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.GetBillingEventsResponseBillingEvent>? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetBillingEventsResponseBillingEvent? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetBillingEventsResponse2? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetBillingEventsResponseError? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetBillingEventsResponseErrorType? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetBillingEventsResponse3? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetBillingEventsResponse4? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetBillingEventsResponse5? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetBillingEventsResponse6? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteRequestPayloadsResponse? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.DeleteRequestPayloadsResponseCdnDeleteResult>? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteRequestPayloadsResponseCdnDeleteResult? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteRequestPayloadsResponse2? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteRequestPayloadsResponseError? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteRequestPayloadsResponseErrorType? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteRequestPayloadsResponse3? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteRequestPayloadsResponse4? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteRequestPayloadsResponse5? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteRequestPayloadsResponse6? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteRequestPayloadsResponse7? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRequestsByEndpointResponse? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ListRequestsByEndpointResponseItem>? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRequestsByEndpointResponseItem? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRequestsByEndpointResponse2? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRequestsByEndpointResponseError? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRequestsByEndpointResponseErrorType? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRequestsByEndpointResponse3? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRequestsByEndpointResponse4? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRequestsByEndpointResponse5? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListRequestsByEndpointResponse6? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SearchRequestsResponse? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.SearchRequestsResponseResult>? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SearchRequestsResponseResult? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SearchRequestsResponse2? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SearchRequestsResponseError? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SearchRequestsResponseErrorType? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SearchRequestsResponse3? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SearchRequestsResponse4? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.SearchRequestsResponse5? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListWorkflowsResponse? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ListWorkflowsResponseWorkflow>? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListWorkflowsResponseWorkflow? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListWorkflowsResponse2? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListWorkflowsResponseError? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListWorkflowsResponseErrorType? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListWorkflowsResponse3? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListWorkflowsResponse4? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListWorkflowsResponse5? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetWorkflowResponse? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetWorkflowResponseWorkflow? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetWorkflowResponse2? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetWorkflowResponseError? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetWorkflowResponseErrorType? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetWorkflowResponse3? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetWorkflowResponse4? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetWorkflowResponse5? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetWorkflowResponse6? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetWorkflowResponse7? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessGetAppQueueInfoResponse? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessGetAppQueueInfoResponse2? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessGetAppQueueInfoResponseError? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessGetAppQueueInfoResponseErrorType? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessGetAppQueueInfoResponse3? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessGetAppQueueInfoResponse4? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessGetAppQueueInfoResponse5? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessGetAppQueueInfoResponse6? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessFlushAppQueueResponse? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessFlushAppQueueResponseError? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessFlushAppQueueResponseErrorType? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ServerlessListRootResponseItem>? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRootResponseItem? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRootResponse? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRootResponseError? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRootResponseErrorType? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ServerlessListDirectoryResponseItem>? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListDirectoryResponseItem? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListDirectoryResponse? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListDirectoryResponseError? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListDirectoryResponseErrorType? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessDownloadFileResponse2? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessDownloadFileResponseError? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessDownloadFileResponseErrorType? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessDownloadFileResponse3? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessDownloadFileResponse4? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessDownloadFileResponse5? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessUploadFromUrlResponse? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessUploadFromUrlResponseError? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessUploadFromUrlResponseErrorType? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessUploadLocalFileResponse? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessUploadLocalFileResponseError? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessUploadLocalFileResponseErrorType? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessGetMetricsResponse? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessGetMetricsResponseError? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessGetMetricsResponseErrorType? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsHistoryResponse? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ServerlessLogsHistoryResponseItem>? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsHistoryResponseItem? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsHistoryResponse2? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsHistoryResponseError? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsHistoryResponseErrorType? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsHistoryResponse3? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsHistoryResponse4? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsStreamResponse2? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsStreamResponseError? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsStreamResponseErrorType? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsStreamResponse3? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessLogsStreamResponse4? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRequestsByEndpointResponse? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ServerlessListRequestsByEndpointResponseItem>? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRequestsByEndpointResponseItem? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRequestsByEndpointResponse2? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRequestsByEndpointResponseError? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRequestsByEndpointResponseErrorType? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRequestsByEndpointResponse3? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRequestsByEndpointResponse4? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRequestsByEndpointResponse5? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRequestsByEndpointResponse6? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ServerlessListRequestsByEndpointResponse7? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListComputeInstancesResponse? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ListComputeInstancesResponseInstance>? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListComputeInstancesResponseInstance? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListComputeInstancesResponseInstanceInstanceType? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListComputeInstancesResponseInstanceRegion? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListComputeInstancesResponseInstanceSector? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListComputeInstancesResponseInstanceStatus? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListComputeInstancesResponse2? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListComputeInstancesResponseError? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListComputeInstancesResponseErrorType? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListComputeInstancesResponse3? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListComputeInstancesResponse4? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListComputeInstancesResponse5? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceResponse? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceResponseInstanceType? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceResponseRegion? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceResponseSector? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceResponseStatus? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceResponse2? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceResponseError? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceResponseErrorType? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceResponse3? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceResponse4? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceResponse5? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputeInstanceResponse6? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetComputeInstanceResponse? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetComputeInstanceResponseInstanceType? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetComputeInstanceResponseRegion? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetComputeInstanceResponseSector? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetComputeInstanceResponseStatus? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetComputeInstanceResponse2? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetComputeInstanceResponseError? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetComputeInstanceResponseErrorType? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetComputeInstanceResponse3? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetComputeInstanceResponse4? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetComputeInstanceResponse5? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetComputeInstanceResponse6? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteComputeInstanceResponse? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteComputeInstanceResponseError? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteComputeInstanceResponseErrorType? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListApiKeysResponse? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ListApiKeysResponseKey>? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListApiKeysResponseKey? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListApiKeysResponseKeyScope? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListApiKeysResponse2? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListApiKeysResponseError? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListApiKeysResponseErrorType? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListApiKeysResponse3? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListApiKeysResponse4? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.ListApiKeysResponse5? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiKeyResponse? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiKeyResponse2? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiKeyResponseError? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiKeyResponseErrorType? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiKeyResponse3? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiKeyResponse4? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiKeyResponse5? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiKeyResponse6? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteApiKeyResponse? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteApiKeyResponseError? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.DeleteApiKeyResponseErrorType? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAccountBillingResponse? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAccountBillingResponseCredits? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAccountBillingResponse2? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAccountBillingResponseError? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAccountBillingResponseErrorType? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAccountBillingResponse3? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAccountBillingResponse4? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAccountBillingResponse5? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAccountBillingResponse6? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetFocusReportResponse? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetFocusReportResponseError? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetFocusReportResponseErrorType? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetMetaResponse? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetMetaResponse2? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetMetaResponseError? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetMetaResponseErrorType? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetMetaResponse3? Type309 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ServerlessLogsHistoryRequestItem>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ServerlessLogsStreamRequestItem>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetModelsResponseModel>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetPricingResponsePrice>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetUsageResponseTimeSerie>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetUsageResponseTimeSerieResult>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetUsageResponseSummaryItem>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsResponseTimeSerie>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsResponseTimeSerieResult>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetAnalyticsResponseSummaryItem>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.GetBillingEventsResponseBillingEvent>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.DeleteRequestPayloadsResponseCdnDeleteResult>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ListRequestsByEndpointResponseItem>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.SearchRequestsResponseResult>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ListWorkflowsResponseWorkflow>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ServerlessListRootResponseItem>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ServerlessListDirectoryResponseItem>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ServerlessLogsHistoryResponseItem>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ServerlessListRequestsByEndpointResponseItem>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ListComputeInstancesResponseInstance>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::G.ListApiKeysResponseKey>? ListType22 { get; set; }
    }
}