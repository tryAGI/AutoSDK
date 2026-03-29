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
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stats", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsErrorsStacksResponseDataPointStat> Stats { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsStacksResponseDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The timestamp for the data point bucket
        /// </param>
        /// <param name="stats"></param>
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