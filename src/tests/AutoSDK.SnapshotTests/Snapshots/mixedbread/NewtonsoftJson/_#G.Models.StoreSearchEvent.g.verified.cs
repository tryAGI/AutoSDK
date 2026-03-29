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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Timestamp when the event was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Default Value: search
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// IDs of the vector stores searched
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> StoreIds { get; set; } = default!;

        /// <summary>
        /// Time taken to search the vector store<br/>
        /// Default Value: PT0S
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_time")]
        public string? SearchTime { get; set; }

        /// <summary>
        /// Query used to search the vector store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// Rewritten query if query rewriting was enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rewritten_query")]
        public string? RewrittenQuery { get; set; }

        /// <summary>
        /// Whether to rerank the results<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rerank")]
        public bool? Rerank { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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