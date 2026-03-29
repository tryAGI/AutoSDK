//HintName: G.Models.GetAnalyticsGraphsCacheHitRateResponseDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsCacheHitRateResponseDataPoint
    {
        /// <summary>
        /// The timestamp for the data point bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Total simple cache hits for this data point bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simple_hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SimpleHits { get; set; }

        /// <summary>
        /// Total semantic cache hits for this data point bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semantic_hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SemanticHits { get; set; }

        /// <summary>
        /// Percentage cache hit rate for this data point bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rate { get; set; }

        /// <summary>
        /// Cumulative simple cache cost savings in cents based on all previous data point buckets and this bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cumulative_simple_cache_savings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CumulativeSimpleCacheSavings { get; set; }

        /// <summary>
        /// Cumulative semantic cache cost savings in cents based on all previous data point buckets and this bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cumulative_semantic_cache_savings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CumulativeSemanticCacheSavings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsCacheHitRateResponseDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The timestamp for the data point bucket
        /// </param>
        /// <param name="simpleHits">
        /// Total simple cache hits for this data point bucket
        /// </param>
        /// <param name="semanticHits">
        /// Total semantic cache hits for this data point bucket
        /// </param>
        /// <param name="rate">
        /// Percentage cache hit rate for this data point bucket
        /// </param>
        /// <param name="cumulativeSimpleCacheSavings">
        /// Cumulative simple cache cost savings in cents based on all previous data point buckets and this bucket
        /// </param>
        /// <param name="cumulativeSemanticCacheSavings">
        /// Cumulative semantic cache cost savings in cents based on all previous data point buckets and this bucket
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsCacheHitRateResponseDataPoint(
            global::System.DateTime timestamp,
            int simpleHits,
            int semanticHits,
            int rate,
            int cumulativeSimpleCacheSavings,
            int cumulativeSemanticCacheSavings)
        {
            this.Timestamp = timestamp;
            this.SimpleHits = simpleHits;
            this.SemanticHits = semanticHits;
            this.Rate = rate;
            this.CumulativeSimpleCacheSavings = cumulativeSimpleCacheSavings;
            this.CumulativeSemanticCacheSavings = cumulativeSemanticCacheSavings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsCacheHitRateResponseDataPoint" /> class.
        /// </summary>
        public GetAnalyticsGraphsCacheHitRateResponseDataPoint()
        {
        }
    }
}