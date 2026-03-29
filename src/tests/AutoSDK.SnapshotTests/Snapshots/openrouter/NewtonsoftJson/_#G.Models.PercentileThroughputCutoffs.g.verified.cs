//HintName: G.Models.PercentileThroughputCutoffs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Percentile-based throughput cutoffs. All specified cutoffs must be met for an endpoint to be preferred.
    /// </summary>
    public sealed partial class PercentileThroughputCutoffs
    {
        /// <summary>
        /// Minimum p50 throughput (tokens/sec)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p50")]
        public double? P50 { get; set; }

        /// <summary>
        /// Minimum p75 throughput (tokens/sec)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p75")]
        public double? P75 { get; set; }

        /// <summary>
        /// Minimum p90 throughput (tokens/sec)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p90")]
        public double? P90 { get; set; }

        /// <summary>
        /// Minimum p99 throughput (tokens/sec)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p99")]
        public double? P99 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentileThroughputCutoffs" /> class.
        /// </summary>
        /// <param name="p50">
        /// Minimum p50 throughput (tokens/sec)
        /// </param>
        /// <param name="p75">
        /// Minimum p75 throughput (tokens/sec)
        /// </param>
        /// <param name="p90">
        /// Minimum p90 throughput (tokens/sec)
        /// </param>
        /// <param name="p99">
        /// Minimum p99 throughput (tokens/sec)
        /// </param>
        public PercentileThroughputCutoffs(
            double? p50,
            double? p75,
            double? p90,
            double? p99)
        {
            this.P50 = p50;
            this.P75 = p75;
            this.P90 = p90;
            this.P99 = p99;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentileThroughputCutoffs" /> class.
        /// </summary>
        public PercentileThroughputCutoffs()
        {
        }
    }
}