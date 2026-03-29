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
        [global::System.Text.Json.Serialization.JsonPropertyName("avg")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Avg { get; set; }

        /// <summary>
        /// 50th percentile latency in ms across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int P50 { get; set; }

        /// <summary>
        /// 90th percentile latency in ms across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int P90 { get; set; }

        /// <summary>
        /// 99th percentile latency in ms across all data points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int P99 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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