//HintName: G.Models.GetAnalyticsGraphsRequestsRescuedResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsRequestsRescuedResponseSummary
    {
        /// <summary>
        /// Total requests rescued using retries across all data points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retry", Required = global::Newtonsoft.Json.Required.Always)]
        public int Retry { get; set; } = default!;

        /// <summary>
        /// Total requests rescued using fallback across all data points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallback", Required = global::Newtonsoft.Json.Required.Always)]
        public int Fallback { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsRequestsRescuedResponseSummary" /> class.
        /// </summary>
        /// <param name="retry">
        /// Total requests rescued using retries across all data points
        /// </param>
        /// <param name="fallback">
        /// Total requests rescued using fallback across all data points
        /// </param>
        public GetAnalyticsGraphsRequestsRescuedResponseSummary(
            int retry,
            int fallback)
        {
            this.Retry = retry;
            this.Fallback = fallback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsRequestsRescuedResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsGraphsRequestsRescuedResponseSummary()
        {
        }
    }
}