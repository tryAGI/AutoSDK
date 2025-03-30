//HintName: G.Models.SearchSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The search portion of the query pipeline. This occurs before any reranking span.
    /// </summary>
    public sealed partial class SearchSpan
    {
        /// <summary>
        /// This value is always `search`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Time taken in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_millis")]
        public int? LatencyMillis { get; set; }

        /// <summary>
        /// Indicates when the span started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The search results before reranking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_results")]
        public global::System.Collections.Generic.IList<global::G.IndividualSearchResult>? SearchResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSpan" /> class.
        /// </summary>
        /// <param name="type">
        /// This value is always `search`.
        /// </param>
        /// <param name="latencyMillis">
        /// Time taken in milliseconds.
        /// </param>
        /// <param name="startedAt">
        /// Indicates when the span started.
        /// </param>
        /// <param name="searchResults">
        /// The search results before reranking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchSpan(
            string? type,
            int? latencyMillis,
            global::System.DateTime? startedAt,
            global::System.Collections.Generic.IList<global::G.IndividualSearchResult>? searchResults)
        {
            this.Type = type;
            this.LatencyMillis = latencyMillis;
            this.StartedAt = startedAt;
            this.SearchResults = searchResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSpan" /> class.
        /// </summary>
        public SearchSpan()
        {
        }
    }
}