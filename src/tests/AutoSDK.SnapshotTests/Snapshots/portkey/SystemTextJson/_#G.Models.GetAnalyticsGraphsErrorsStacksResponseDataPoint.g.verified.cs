//HintName: G.Models.GetAnalyticsGraphsErrorsStacksResponseDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsErrorsStacksResponseDataPoint
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
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsErrorsStacksResponseDataPointStat> Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsStacksResponseDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The timestamp for the data point bucket
        /// </param>
        /// <param name="stats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsErrorsStacksResponseDataPoint(
            global::System.DateTime timestamp,
            global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsErrorsStacksResponseDataPointStat> stats)
        {
            this.Timestamp = timestamp;
            this.Stats = stats ?? throw new global::System.ArgumentNullException(nameof(stats));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsStacksResponseDataPoint" /> class.
        /// </summary>
        public GetAnalyticsGraphsErrorsStacksResponseDataPoint()
        {
        }
    }
}