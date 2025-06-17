//HintName: G.Models.RerankRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankRequest
    {
        /// <summary>
        /// A list of document objects or strings to rerank.<br/>
        /// If a document is provided the text fields is required and all other fields will be preserved in the response.<br/>
        /// The total max chunks (length of documents * max_chunks_per_doc) must be less than 10000.<br/>
        /// We recommend a maximum of 1,000 documents for optimal endpoint performance.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.RerankDocument>> Documents { get; set; } = default!;

        /// <summary>
        /// The maximum number of chunks to produce internally from a document<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_chunks_per_doc")]
        public int? MaxChunksPerDoc { get; set; }

        /// <summary>
        /// The identifier of the model to use, eg `rerank-v3.5`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The search query
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// If a JSON object is provided, you can specify which keys you would like to have considered for reranking. The model will rerank based on order of the fields passed in (i.e. rank_fields=['title','author','text'] will rerank using the values in title, author, text  sequentially. If the length of title, author, and text exceeds the context length of the model, the chunking will not re-consider earlier fields). If not provided, the model will use the default text field for ranking.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rank_fields")]
        public global::System.Collections.Generic.IList<string>? RankFields { get; set; }

        /// <summary>
        /// - If false, returns results without the doc text - the api will return a list of {index, relevance score} where index is inferred from the list passed into the request.<br/>
        /// - If true, returns results with the doc text passed in - the api will return an ordered list of {index, text, relevance score} where index + text refers to the list passed into the request.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// The number of most relevant documents or indices to return, defaults to the length of the documents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        /// <param name="documents">
        /// A list of document objects or strings to rerank.<br/>
        /// If a document is provided the text fields is required and all other fields will be preserved in the response.<br/>
        /// The total max chunks (length of documents * max_chunks_per_doc) must be less than 10000.<br/>
        /// We recommend a maximum of 1,000 documents for optimal endpoint performance.
        /// </param>
        /// <param name="maxChunksPerDoc">
        /// The maximum number of chunks to produce internally from a document<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="model">
        /// The identifier of the model to use, eg `rerank-v3.5`.
        /// </param>
        /// <param name="query">
        /// The search query
        /// </param>
        /// <param name="rankFields">
        /// If a JSON object is provided, you can specify which keys you would like to have considered for reranking. The model will rerank based on order of the fields passed in (i.e. rank_fields=['title','author','text'] will rerank using the values in title, author, text  sequentially. If the length of title, author, and text exceeds the context length of the model, the chunking will not re-consider earlier fields). If not provided, the model will use the default text field for ranking.
        /// </param>
        /// <param name="returnDocuments">
        /// - If false, returns results without the doc text - the api will return a list of {index, relevance score} where index is inferred from the list passed into the request.<br/>
        /// - If true, returns results with the doc text passed in - the api will return an ordered list of {index, text, relevance score} where index + text refers to the list passed into the request.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topN">
        /// The number of most relevant documents or indices to return, defaults to the length of the documents
        /// </param>
        public RerankRequest(
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.RerankDocument>> documents,
            string query,
            int? maxChunksPerDoc,
            string? model,
            global::System.Collections.Generic.IList<string>? rankFields,
            bool? returnDocuments,
            int? topN)
        {
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.MaxChunksPerDoc = maxChunksPerDoc;
            this.Model = model;
            this.RankFields = rankFields;
            this.ReturnDocuments = returnDocuments;
            this.TopN = topN;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        public RerankRequest()
        {
        }
    }
}