//HintName: G.Models.QueryPerformance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The performance information for a query.
    /// </summary>
    public sealed partial class QueryPerformance
    {
        /// <summary>
        /// The ratio of cache hits to total cache lookups.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_hit_ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CacheHitRatio { get; set; }

        /// <summary>
        /// A qualitative description of the cache hit ratio (`hot`, `warm`, or `cold`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CacheTemperature { get; set; }

        /// <summary>
        /// Request time measured on the server, including time spent waiting for other queries to complete if the namespace was at its concurrency limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_total_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ServerTotalMs { get; set; }

        /// <summary>
        /// Request time measured on the server, excluding time spent waiting due to the namespace concurrency limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_execution_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int QueryExecutionMs { get; set; }

        /// <summary>
        /// The number of unindexed documents processed by the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exhaustive_search_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExhaustiveSearchCount { get; set; }

        /// <summary>
        /// the approximate number of documents in the namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approx_namespace_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ApproxNamespaceSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryPerformance" /> class.
        /// </summary>
        /// <param name="cacheHitRatio">
        /// The ratio of cache hits to total cache lookups.
        /// </param>
        /// <param name="cacheTemperature">
        /// A qualitative description of the cache hit ratio (`hot`, `warm`, or `cold`).
        /// </param>
        /// <param name="serverTotalMs">
        /// Request time measured on the server, including time spent waiting for other queries to complete if the namespace was at its concurrency limit.
        /// </param>
        /// <param name="queryExecutionMs">
        /// Request time measured on the server, excluding time spent waiting due to the namespace concurrency limit.
        /// </param>
        /// <param name="exhaustiveSearchCount">
        /// The number of unindexed documents processed by the query.
        /// </param>
        /// <param name="approxNamespaceSize">
        /// the approximate number of documents in the namespace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryPerformance(
            double cacheHitRatio,
            string cacheTemperature,
            int serverTotalMs,
            int queryExecutionMs,
            int exhaustiveSearchCount,
            int approxNamespaceSize)
        {
            this.CacheHitRatio = cacheHitRatio;
            this.CacheTemperature = cacheTemperature ?? throw new global::System.ArgumentNullException(nameof(cacheTemperature));
            this.ServerTotalMs = serverTotalMs;
            this.QueryExecutionMs = queryExecutionMs;
            this.ExhaustiveSearchCount = exhaustiveSearchCount;
            this.ApproxNamespaceSize = approxNamespaceSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryPerformance" /> class.
        /// </summary>
        public QueryPerformance()
        {
        }
    }
}