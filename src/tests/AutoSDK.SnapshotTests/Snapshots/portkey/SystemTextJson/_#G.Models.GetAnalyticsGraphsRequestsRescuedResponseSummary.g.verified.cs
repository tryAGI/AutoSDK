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
        [global::System.Text.Json.Serialization.JsonPropertyName("retry")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Retry { get; set; }

        /// <summary>
        /// Total requests rescued using fallback across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Fallback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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