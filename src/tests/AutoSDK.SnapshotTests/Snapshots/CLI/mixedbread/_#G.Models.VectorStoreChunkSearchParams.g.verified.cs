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
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// IDs or names of vector stores to search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> VectorStoreIdentifiers { get; set; }

        /// <summary>
        /// Number of results to return<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Optional filter conditions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>))]
        public global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? Filters { get; set; }

        /// <summary>
        /// Optional list of file IDs to filter chunks by (inclusion filter)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>))]
        public global::G.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>? FileIds { get; set; }

        /// <summary>
        /// Search configuration options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_options")]
        public global::G.VectorStoreChunkSearchOptions? SearchOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreChunkSearchParams(
            string query,
            global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> vectorStoreIdentifiers,
            int? topK,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? filters,
            global::G.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds,
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