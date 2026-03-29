//HintName: G.Models.RerankParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for reranking documents.
    /// </summary>
    public sealed partial class RerankParams
    {
        /// <summary>
        /// The model to use for reranking documents.<br/>
        /// Default Value: mixedbread-ai/mxbai-rerank-large-v2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The query to rerank the documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// The input documents to rerank.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<string, object, global::System.Collections.Generic.IList<object>>> Input { get; set; } = default!;

        /// <summary>
        /// The fields of the documents to rank.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rank_fields")]
        public global::System.Collections.Generic.IList<string>? RankFields { get; set; }

        /// <summary>
        /// The number of documents to return.<br/>
        /// Default Value: -1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Whether to return the documents.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_input")]
        public bool? ReturnInput { get; set; }

        /// <summary>
        /// Wether or not to rewrite the query before passing it to the reranking model<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rewrite_query")]
        public bool? RewriteQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankParams" /> class.
        /// </summary>
        /// <param name="query">
        /// The query to rerank the documents.
        /// </param>
        /// <param name="input">
        /// The input documents to rerank.
        /// </param>
        /// <param name="model">
        /// The model to use for reranking documents.<br/>
        /// Default Value: mixedbread-ai/mxbai-rerank-large-v2
        /// </param>
        /// <param name="rankFields">
        /// The fields of the documents to rank.
        /// </param>
        /// <param name="topK">
        /// The number of documents to return.<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="returnInput">
        /// Whether to return the documents.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="rewriteQuery">
        /// Wether or not to rewrite the query before passing it to the reranking model<br/>
        /// Default Value: false
        /// </param>
        public RerankParams(
            string query,
            global::System.Collections.Generic.IList<global::G.AnyOf<string, object, global::System.Collections.Generic.IList<object>>> input,
            string? model,
            global::System.Collections.Generic.IList<string>? rankFields,
            int? topK,
            bool? returnInput,
            bool? rewriteQuery)
        {
            this.Model = model;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.RankFields = rankFields;
            this.TopK = topK;
            this.ReturnInput = returnInput;
            this.RewriteQuery = rewriteQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankParams" /> class.
        /// </summary>
        public RerankParams()
        {
        }
    }
}