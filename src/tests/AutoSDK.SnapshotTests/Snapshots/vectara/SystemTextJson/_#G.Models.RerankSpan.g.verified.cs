//HintName: G.Models.RerankSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reranking of the search result.
    /// </summary>
    public sealed partial class RerankSpan
    {
        /// <summary>
        /// This value is always `rerank`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Time taken in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_millis")]
        public int? LatencyMillis { get; set; }

        /// <summary>
        /// When the span started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The new search results after reranking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reranked_search_results")]
        public global::System.Collections.Generic.IList<global::G.RerankedSearchResult>? RerankedSearchResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankSpan" /> class.
        /// </summary>
        /// <param name="type">
        /// This value is always `rerank`.
        /// </param>
        /// <param name="latencyMillis">
        /// Time taken in milliseconds.
        /// </param>
        /// <param name="startedAt">
        /// When the span started.
        /// </param>
        /// <param name="rerankedSearchResults">
        /// The new search results after reranking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankSpan(
            string? type,
            int? latencyMillis,
            global::System.DateTime? startedAt,
            global::System.Collections.Generic.IList<global::G.RerankedSearchResult>? rerankedSearchResults)
        {
            this.Type = type;
            this.LatencyMillis = latencyMillis;
            this.StartedAt = startedAt;
            this.RerankedSearchResults = rerankedSearchResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankSpan" /> class.
        /// </summary>
        public RerankSpan()
        {
        }
    }
}