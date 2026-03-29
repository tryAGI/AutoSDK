//HintName: G.Models.BatchStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Stats about the batch.
    /// </summary>
    public sealed partial class BatchStats
    {
        /// <summary>
        /// Output only. The number of requests in the batch.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestCount")]
        public string? RequestCount { get; set; }

        /// <summary>
        /// Output only. The number of requests that were successfully processed.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("successfulRequestCount")]
        public string? SuccessfulRequestCount { get; set; }

        /// <summary>
        /// Output only. The number of requests that failed to be processed.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failedRequestCount")]
        public string? FailedRequestCount { get; set; }

        /// <summary>
        /// Output only. The number of requests that are still pending processing.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pendingRequestCount")]
        public string? PendingRequestCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStats" /> class.
        /// </summary>
        /// <param name="requestCount">
        /// Output only. The number of requests in the batch.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="successfulRequestCount">
        /// Output only. The number of requests that were successfully processed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="failedRequestCount">
        /// Output only. The number of requests that failed to be processed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pendingRequestCount">
        /// Output only. The number of requests that are still pending processing.<br/>
        /// Included only in responses
        /// </param>
        public BatchStats(
            string? requestCount,
            string? successfulRequestCount,
            string? failedRequestCount,
            string? pendingRequestCount)
        {
            this.RequestCount = requestCount;
            this.SuccessfulRequestCount = successfulRequestCount;
            this.FailedRequestCount = failedRequestCount;
            this.PendingRequestCount = pendingRequestCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStats" /> class.
        /// </summary>
        public BatchStats()
        {
        }
    }
}