//HintName: G.Models.VectorStoreChunkSearchParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Query parameters for searching vector store chunks.
    /// </summary>
    public sealed partial class VectorStoreChunkSearchParams
    {
        /// <summary>
        /// Search query text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// IDs or names of vector stores to search
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_store_identifiers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> VectorStoreIdentifiers { get; set; } = default!;

        /// <summary>
        /// Number of results to return<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Optional filter conditions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? Filters { get; set; }

        /// <summary>
        /// Optional list of file IDs to filter chunks by (inclusion filter)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>? FileIds { get; set; }

        /// <summary>
        /// Search configuration options
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_options")]
        public global::G.VectorStoreChunkSearchOptions? SearchOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreChunkSearchParams" /> class.
        /// </summary>
        /// <param name="query">
        /// Search query text
        /// </param>
        /// <param name="vectorStoreIdentifiers">
        /// IDs or names of vector stores to search
        /// </param>
        /// <param name="topK">
        /// Number of results to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="filters">
        /// Optional filter conditions
        /// </param>
        /// <param name="fileIds">
        /// Optional list of file IDs to filter chunks by (inclusion filter)
        /// </param>
        /// <param name="searchOptions">
        /// Search configuration options
        /// </param>
        public VectorStoreChunkSearchParams(
            string query,
            global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> vectorStoreIdentifiers,
            int? topK,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? filters,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds,
            global::G.VectorStoreChunkSearchOptions? searchOptions)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.VectorStoreIdentifiers = vectorStoreIdentifiers ?? throw new global::System.ArgumentNullException(nameof(vectorStoreIdentifiers));
            this.TopK = topK;
            this.Filters = filters;
            this.FileIds = fileIds;
            this.SearchOptions = searchOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreChunkSearchParams" /> class.
        /// </summary>
        public VectorStoreChunkSearchParams()
        {
        }
    }
}