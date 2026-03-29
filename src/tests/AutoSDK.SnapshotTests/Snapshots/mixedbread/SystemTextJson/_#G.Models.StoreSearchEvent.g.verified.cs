//HintName: G.Models.StoreSearchEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a search event in a vector store.
    /// </summary>
    public sealed partial class StoreSearchEvent
    {
        /// <summary>
        /// Unique identifier for the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Timestamp when the event was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Default Value: search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// IDs of the vector stores searched
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> StoreIds { get; set; }

        /// <summary>
        /// Time taken to search the vector store<br/>
        /// Default Value: PT0S
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_time")]
        public string? SearchTime { get; set; }

        /// <summary>
        /// Query used to search the vector store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Rewritten query if query rewriting was enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewritten_query")]
        public string? RewrittenQuery { get; set; }

        /// <summary>
        /// Whether to rerank the results<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank")]
        public bool? Rerank { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSearchEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the event
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created
        /// </param>
        /// <param name="storeIds">
        /// IDs of the vector stores searched
        /// </param>
        /// <param name="query">
        /// Query used to search the vector store
        /// </param>
        /// <param name="type">
        /// Default Value: search
        /// </param>
        /// <param name="searchTime">
        /// Time taken to search the vector store<br/>
        /// Default Value: PT0S
        /// </param>
        /// <param name="rewrittenQuery">
        /// Rewritten query if query rewriting was enabled
        /// </param>
        /// <param name="rerank">
        /// Whether to rerank the results<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreSearchEvent(
            global::System.Guid id,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::System.Guid> storeIds,
            string query,
            string? type,
            string? searchTime,
            string? rewrittenQuery,
            bool? rerank)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Type = type;
            this.StoreIds = storeIds ?? throw new global::System.ArgumentNullException(nameof(storeIds));
            this.SearchTime = searchTime;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.RewrittenQuery = rewrittenQuery;
            this.Rerank = rerank;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSearchEvent" /> class.
        /// </summary>
        public StoreSearchEvent()
        {
        }
    }
}