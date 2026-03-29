//HintName: G.Models.PercentileLatencyCutoffs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Percentile-based latency cutoffs. All specified cutoffs must be met for an endpoint to be preferred.
    /// </summary>
    public sealed partial class PercentileLatencyCutoffs
    {
        /// <summary>
        /// Maximum p50 latency (seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50")]
        public double? P50 { get; set; }

        /// <summary>
        /// Maximum p75 latency (seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p75")]
        public double? P75 { get; set; }

        /// <summary>
        /// Maximum p90 latency (seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90")]
        public double? P90 { get; set; }

        /// <summary>
        /// Maximum p99 latency (seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99")]
        public double? P99 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentileLatencyCutoffs" /> class.
        /// </summary>
        /// <param name="p50">
        /// Maximum p50 latency (seconds)
        /// </param>
        /// <param name="p75">
        /// Maximum p75 latency (seconds)
        /// </param>
        /// <param name="p90">
        /// Maximum p90 latency (seconds)
        /// </param>
        /// <param name="p99">
        /// Maximum p99 latency (seconds)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PercentileLatencyCutoffs(
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
        /// Initializes a new instance of the <see cref="PercentileLatencyCutoffs" /> class.
        /// </summary>
        public PercentileLatencyCutoffs()
        {
        }
    }
}