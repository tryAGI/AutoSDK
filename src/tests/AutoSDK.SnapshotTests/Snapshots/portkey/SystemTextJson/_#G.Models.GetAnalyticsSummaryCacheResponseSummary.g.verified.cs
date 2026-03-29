//HintName: G.Models.GetAnalyticsSummaryCacheResponseSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsSummaryCacheResponseSummary
    {
        /// <summary>
        /// Total cache hits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        public int? Hits { get; set; }

        /// <summary>
        /// Average latency for a cache hit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_latency")]
        public int? AvgLatency { get; set; }

        /// <summary>
        /// Total requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        public int? TotalRequests { get; set; }

        /// <summary>
        /// Percentage speedup for cache hits compared to non cache hit requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_speedup")]
        public int? CacheSpeedup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsSummaryCacheResponseSummary" /> class.
        /// </summary>
        /// <param name="hits">
        /// Total cache hits
        /// </param>
        /// <param name="avgLatency">
        /// Average latency for a cache hit
        /// </param>
        /// <param name="totalRequests">
        /// Total requests
        /// </param>
        /// <param name="cacheSpeedup">
        /// Percentage speedup for cache hits compared to non cache hit requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsSummaryCacheResponseSummary(
            int? hits,
            int? avgLatency,
            int? totalRequests,
            int? cacheSpeedup)
        {
            this.Hits = hits;
            this.AvgLatency = avgLatency;
            this.TotalRequests = totalRequests;
            this.CacheSpeedup = cacheSpeedup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsSummaryCacheResponseSummary" /> class.
        /// </summary>
        public GetAnalyticsSummaryCacheResponseSummary()
        {
        }
    }
}