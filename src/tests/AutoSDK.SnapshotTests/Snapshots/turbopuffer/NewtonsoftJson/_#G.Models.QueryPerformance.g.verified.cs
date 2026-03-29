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
        [global::Newtonsoft.Json.JsonProperty("cache_hit_ratio", Required = global::Newtonsoft.Json.Required.Always)]
        public double CacheHitRatio { get; set; } = default!;

        /// <summary>
        /// A qualitative description of the cache hit ratio (`hot`, `warm`, or `cold`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_temperature", Required = global::Newtonsoft.Json.Required.Always)]
        public string CacheTemperature { get; set; } = default!;

        /// <summary>
        /// Request time measured on the server, including time spent waiting for other queries to complete if the namespace was at its concurrency limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_total_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int ServerTotalMs { get; set; } = default!;

        /// <summary>
        /// Request time measured on the server, excluding time spent waiting due to the namespace concurrency limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_execution_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int QueryExecutionMs { get; set; } = default!;

        /// <summary>
        /// The number of unindexed documents processed by the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exhaustive_search_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExhaustiveSearchCount { get; set; } = default!;

        /// <summary>
        /// the approximate number of documents in the namespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approx_namespace_size", Required = global::Newtonsoft.Json.Required.Always)]
        public int ApproxNamespaceSize { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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