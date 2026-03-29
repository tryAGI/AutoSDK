//HintName: G.Models.GetAnalyticsGraphsFeedbacksResponseDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsFeedbacksResponseDataPoint
    {
        /// <summary>
        /// The timestamp for the data point bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Total feedbacks for this data point bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsFeedbacksResponseDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The timestamp for the data point bucket
        /// </param>
        /// <param name="total">
        /// Total feedbacks for this data point bucket
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsFeedbacksResponseDataPoint(
            global::System.DateTime timestamp,
            int total)
        {
            this.Timestamp = timestamp;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsFeedbacksResponseDataPoint" /> class.
        /// </summary>
        public GetAnalyticsGraphsFeedbacksResponseDataPoint()
        {
        }
    }
}