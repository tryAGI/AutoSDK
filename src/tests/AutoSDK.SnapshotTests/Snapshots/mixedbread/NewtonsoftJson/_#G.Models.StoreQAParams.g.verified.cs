//HintName: G.Models.StoreQAParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Query parameters for question answering.
    /// </summary>
    public sealed partial class StoreQAParams
    {
        /// <summary>
        /// Question to answer. If not provided, the question will be extracted from the passed messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// IDs or names of stores to search
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store_identifiers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> StoreIdentifiers { get; set; } = default!;

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
        public global::G.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>? FileIds { get; set; }

        /// <summary>
        /// Search configuration options
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_options")]
        public global::G.StoreChunkSearchOptions? SearchOptions { get; set; }

        /// <summary>
        /// Whether to stream the answer<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional custom instructions (followed only when not in conflict with existing rules)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

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
        /// Initializes a new instance of the <see cref="StoreQAParams" /> class.
        /// </summary>
        /// <param name="storeIdentifiers">
        /// IDs or names of stores to search
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
        /// <param name="instructions">
        /// Additional custom instructions (followed only when not in conflict with existing rules)
        /// </param>
        /// <param name="qaOptions">
        /// Question answering configuration options
        /// </param>
        public StoreQAParams(
            global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> storeIdentifiers,
            string? query,
            int? topK,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? filters,
            global::G.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds,
            global::G.StoreChunkSearchOptions? searchOptions,
            bool? stream,
            string? instructions,
            global::G.QuestionAnsweringOptions? qaOptions)
        {
            this.Query = query;
            this.StoreIdentifiers = storeIdentifiers ?? throw new global::System.ArgumentNullException(nameof(storeIdentifiers));
            this.TopK = topK;
            this.Filters = filters;
            this.FileIds = fileIds;
            this.SearchOptions = searchOptions;
            this.Stream = stream;
            this.Instructions = instructions;
            this.QaOptions = qaOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreQAParams" /> class.
        /// </summary>
        public StoreQAParams()
        {
        }
    }
}