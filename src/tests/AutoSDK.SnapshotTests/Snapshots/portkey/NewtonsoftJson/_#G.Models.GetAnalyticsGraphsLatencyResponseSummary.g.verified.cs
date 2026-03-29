//HintName: G.Models.GetAnalyticsGraphsLatencyResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsLatencyResponseSummary
    {
        /// <summary>
        /// Average latency in ms across all data points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg", Required = global::Newtonsoft.Json.Required.Always)]
        public int Avg { get; set; } = default!;

        /// <summary>
        /// 50th percentile latency in ms across all data points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p50", Required = global::Newtonsoft.Json.Required.Always)]
        public int P50 { get; set; } = default!;

        /// <summary>
        /// 90th percentile latency in ms across all data points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p90", Required = global::Newtonsoft.Json.Required.Always)]
        public int P90 { get; set; } = default!;

        /// <summary>
        /// 99th percentile latency in ms across all data points
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p99", Required = global::Newtonsoft.Json.Required.Always)]
        public int P99 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsLatencyResponseSummary" /> class.
        /// </summary>
        /// <param name="avg">
        /// Average latency in ms across all data points
        /// </param>
        /// <param name="p50">
        /// 50th percentile latency in ms across all data points
        /// </param>
        /// <param name="p90">
        /// 90th percentile latency in ms across all data points
        /// </param>
        /// <param name="p99">
        /// 99th percentile latency in ms across all data points
        /// </param>
        public GetAnalyticsGraphsLatencyResponseSummary(
            int avg,
            int p50,
            int p90,
            int p99)
        {
            this.Avg = avg;
            this.P50 = p50;
            this.P90 = p90;
            this.P99 = p99;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsLatencyResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsGraphsLatencyResponseSummary()
        {
        }
    }
}