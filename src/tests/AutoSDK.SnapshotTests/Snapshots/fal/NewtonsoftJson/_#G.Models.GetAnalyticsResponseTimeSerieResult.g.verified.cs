//HintName: G.Models.GetAnalyticsResponseTimeSerieResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Performance and reliability analytics. Only requested metrics (via expand parameter) will be present in the response. 'prepare_duration' reflects queue/prepare time before execution; 'duration' is request execution time.
    /// </summary>
    public sealed partial class GetAnalyticsResponseTimeSerieResult
    {
        /// <summary>
        /// Endpoint identifier for these statistics
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EndpointId { get; set; } = default!;

        /// <summary>
        /// Total number of requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_count")]
        public int? RequestCount { get; set; }

        /// <summary>
        /// Number of successful requests (2xx responses)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success_count")]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// Number of user errors (4xx responses)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_error_count")]
        public int? UserErrorCount { get; set; }

        /// <summary>
        /// Number of server errors (5xx responses)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_count")]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// 50th percentile queue/prepare time before execution in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p50_prepare_duration")]
        public double? P50PrepareDuration { get; set; }

        /// <summary>
        /// 75th percentile queue/prepare time before execution in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p75_prepare_duration")]
        public double? P75PrepareDuration { get; set; }

        /// <summary>
        /// 90th percentile queue/prepare time before execution in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p90_prepare_duration")]
        public double? P90PrepareDuration { get; set; }

        /// <summary>
        /// 50th percentile request execution duration in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p50_duration")]
        public double? P50Duration { get; set; }

        /// <summary>
        /// 75th percentile request execution duration in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p75_duration")]
        public double? P75Duration { get; set; }

        /// <summary>
        /// 90th percentile request execution duration in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p90_duration")]
        public double? P90Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsResponseTimeSerieResult" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// Endpoint identifier for these statistics
        /// </param>
        /// <param name="requestCount">
        /// Total number of requests
        /// </param>
        /// <param name="successCount">
        /// Number of successful requests (2xx responses)
        /// </param>
        /// <param name="userErrorCount">
        /// Number of user errors (4xx responses)
        /// </param>
        /// <param name="errorCount">
        /// Number of server errors (5xx responses)
        /// </param>
        /// <param name="p50PrepareDuration">
        /// 50th percentile queue/prepare time before execution in seconds
        /// </param>
        /// <param name="p75PrepareDuration">
        /// 75th percentile queue/prepare time before execution in seconds
        /// </param>
        /// <param name="p90PrepareDuration">
        /// 90th percentile queue/prepare time before execution in seconds
        /// </param>
        /// <param name="p50Duration">
        /// 50th percentile request execution duration in seconds
        /// </param>
        /// <param name="p75Duration">
        /// 75th percentile request execution duration in seconds
        /// </param>
        /// <param name="p90Duration">
        /// 90th percentile request execution duration in seconds
        /// </param>
        public GetAnalyticsResponseTimeSerieResult(
            string endpointId,
            int? requestCount,
            int? successCount,
            int? userErrorCount,
            int? errorCount,
            double? p50PrepareDuration,
            double? p75PrepareDuration,
            double? p90PrepareDuration,
            double? p50Duration,
            double? p75Duration,
            double? p90Duration)
        {
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.RequestCount = requestCount;
            this.SuccessCount = successCount;
            this.UserErrorCount = userErrorCount;
            this.ErrorCount = errorCount;
            this.P50PrepareDuration = p50PrepareDuration;
            this.P75PrepareDuration = p75PrepareDuration;
            this.P90PrepareDuration = p90PrepareDuration;
            this.P50Duration = p50Duration;
            this.P75Duration = p75Duration;
            this.P90Duration = p90Duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsResponseTimeSerieResult" /> class.
        /// </summary>
        public GetAnalyticsResponseTimeSerieResult()
        {
        }
    }
}