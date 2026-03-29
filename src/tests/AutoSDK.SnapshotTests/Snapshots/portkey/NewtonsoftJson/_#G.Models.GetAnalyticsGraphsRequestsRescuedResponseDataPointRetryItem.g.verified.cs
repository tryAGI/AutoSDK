//HintName: G.Models.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem
    {
        /// <summary>
        /// Retry attempt count at which the request was rescued
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retry_success_count")]
        public int? RetrySuccessCount { get; set; }

        /// <summary>
        /// Total requests rescued at this retry attempt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem" /> class.
        /// </summary>
        /// <param name="retrySuccessCount">
        /// Retry attempt count at which the request was rescued
        /// </param>
        /// <param name="count">
        /// Total requests rescued at this retry attempt
        /// </param>
        public GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem(
            int? retrySuccessCount,
            int? count)
        {
            this.RetrySuccessCount = retrySuccessCount;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem" /> class.
        /// </summary>
        public GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem()
        {
        }
    }
}