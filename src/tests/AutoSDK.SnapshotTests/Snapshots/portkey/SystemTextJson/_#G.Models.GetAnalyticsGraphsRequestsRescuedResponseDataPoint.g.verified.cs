//HintName: G.Models.GetAnalyticsGraphsRequestsRescuedResponseDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsRequestsRescuedResponseDataPoint
    {
        /// <summary>
        /// The timestamp for the data point bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem> Retry { get; set; }

        /// <summary>
        /// Total requests rescued using fallback for this data point bucket
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
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsRequestsRescuedResponseDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The timestamp for the data point bucket
        /// </param>
        /// <param name="retry"></param>
        /// <param name="fallback">
        /// Total requests rescued using fallback for this data point bucket
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsRequestsRescuedResponseDataPoint(
            global::System.DateTime timestamp,
            global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsRequestsRescuedResponseDataPointRetryItem> retry,
            int fallback)
        {
            this.Timestamp = timestamp;
            this.Retry = retry ?? throw new global::System.ArgumentNullException(nameof(retry));
            this.Fallback = fallback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsRequestsRescuedResponseDataPoint" /> class.
        /// </summary>
        public GetAnalyticsGraphsRequestsRescuedResponseDataPoint()
        {
        }
    }
}