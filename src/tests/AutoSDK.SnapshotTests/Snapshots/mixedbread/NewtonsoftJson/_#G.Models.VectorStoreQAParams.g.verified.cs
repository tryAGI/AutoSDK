//HintName: G.Models.VectorStoreQAParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Query parameters for question answering.
    /// </summary>
    public sealed partial class VectorStoreQAParams
    {
        /// <summary>
        /// Question to answer. If not provided, the question will be extracted from the passed messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

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
        /// Whether to stream the answer<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Question answering configuration options
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("qa_options")]
        public global::G.QuestionAnsweringOptions? QaOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreQAParams" /> class.
        /// </summary>
        /// <param name="vectorStoreIdentifiers">
        /// IDs or names of vector stores to search
        /// </param>
        /// <param name="query">
        /// Question to answer. If not provided, the question will be extracted from the passed messages.
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
        /// <param name="stream">
        /// Whether to stream the answer<br/>
        /// Default Value: false
        /// </param>
        /// <param name="qaOptions">
        /// Question answering configuration options
        /// </param>
        public VectorStoreQAParams(
            global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> vectorStoreIdentifiers,
            string? query,
            int? topK,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? filters,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds,
            global::G.VectorStoreChunkSearchOptions? searchOptions,
            bool? stream,
            global::G.QuestionAnsweringOptions? qaOptions)
        {
            this.Query = query;
            this.VectorStoreIdentifiers = vectorStoreIdentifiers ?? throw new global::System.ArgumentNullException(nameof(vectorStoreIdentifiers));
            this.TopK = topK;
            this.Filters = filters;
            this.FileIds = fileIds;
            this.SearchOptions = searchOptions;
            this.Stream = stream;
            this.QaOptions = qaOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreQAParams" /> class.
        /// </summary>
        public VectorStoreQAParams()
        {
        }
    }
}