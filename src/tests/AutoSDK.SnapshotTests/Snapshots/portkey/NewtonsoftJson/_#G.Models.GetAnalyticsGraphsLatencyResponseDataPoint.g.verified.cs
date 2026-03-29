//HintName: G.Models.GetAnalyticsGraphsLatencyResponseDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsLatencyResponseDataPoint
    {
        /// <summary>
        /// The timestamp for the data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// Average latency in ms for this data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg", Required = global::Newtonsoft.Json.Required.Always)]
        public int Avg { get; set; } = default!;

        /// <summary>
        /// 50th percentile latency in ms for this data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p50", Required = global::Newtonsoft.Json.Required.Always)]
        public int P50 { get; set; } = default!;

        /// <summary>
        /// 90th percentile latency in ms for this data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p90", Required = global::Newtonsoft.Json.Required.Always)]
        public int P90 { get; set; } = default!;

        /// <summary>
        /// 99th percentile latency in ms for this data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p99", Required = global::Newtonsoft.Json.Required.Always)]
        public int P99 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsLatencyResponseDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The timestamp for the data point bucket
        /// </param>
        /// <param name="avg">
        /// Average latency in ms for this data point bucket
        /// </param>
        /// <param name="p50">
        /// 50th percentile latency in ms for this data point bucket
        /// </param>
        /// <param name="p90">
        /// 90th percentile latency in ms for this data point bucket
        /// </param>
        /// <param name="p99">
        /// 99th percentile latency in ms for this data point bucket
        /// </param>
        public GetAnalyticsGraphsLatencyResponseDataPoint(
            global::System.DateTime timestamp,
            int avg,
            int p50,
            int p90,
            int p99)
        {
            this.Timestamp = timestamp;
            this.Avg = avg;
            this.P50 = p50;
            this.P90 = p90;
            this.P99 = p99;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsLatencyResponseDataPoint" /> class.
        /// </summary>
        public GetAnalyticsGraphsLatencyResponseDataPoint()
        {
        }
    }
}