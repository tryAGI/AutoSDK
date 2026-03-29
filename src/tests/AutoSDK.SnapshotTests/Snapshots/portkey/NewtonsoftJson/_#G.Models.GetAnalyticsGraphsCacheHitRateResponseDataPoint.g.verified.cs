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
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// Total simple cache hits for this data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("simple_hits", Required = global::Newtonsoft.Json.Required.Always)]
        public int SimpleHits { get; set; } = default!;

        /// <summary>
        /// Total semantic cache hits for this data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("semantic_hits", Required = global::Newtonsoft.Json.Required.Always)]
        public int SemanticHits { get; set; } = default!;

        /// <summary>
        /// Percentage cache hit rate for this data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate", Required = global::Newtonsoft.Json.Required.Always)]
        public int Rate { get; set; } = default!;

        /// <summary>
        /// Cumulative simple cache cost savings in cents based on all previous data point buckets and this bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cumulative_simple_cache_savings", Required = global::Newtonsoft.Json.Required.Always)]
        public int CumulativeSimpleCacheSavings { get; set; } = default!;

        /// <summary>
        /// Cumulative semantic cache cost savings in cents based on all previous data point buckets and this bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cumulative_semantic_cache_savings", Required = global::Newtonsoft.Json.Required.Always)]
        public int CumulativeSemanticCacheSavings { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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