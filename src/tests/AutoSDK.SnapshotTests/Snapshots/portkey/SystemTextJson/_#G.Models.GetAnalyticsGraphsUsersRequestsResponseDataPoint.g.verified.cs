//HintName: G.Models.GetAnalyticsGraphsUsersRequestsResponseDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsUsersRequestsResponseDataPoint
    {
        /// <summary>
        /// The timestamp for the data point bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Average requests per user for this data point bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Avg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsUsersRequestsResponseDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The timestamp for the data point bucket
        /// </param>
        /// <param name="avg">
        /// Average requests per user for this data point bucket
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsUsersRequestsResponseDataPoint(
            global::System.DateTime timestamp,
            int avg)
        {
            this.Timestamp = timestamp;
            this.Avg = avg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsUsersRequestsResponseDataPoint" /> class.
        /// </summary>
        public GetAnalyticsGraphsUsersRequestsResponseDataPoint()
        {
        }
    }
}