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
        /// List of documents, which can be either strings or objects.<br/>
        /// Default Value: [, , , ]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>> Documents { get; set; } = default!;

        /// <summary>
        /// The model to be used for the rerank request.<br/>
        /// Default Value: Salesforce/Llama-Rank-V1<br/>
        /// Example: Salesforce/Llama-Rank-V1
        /// </summary>
        /// <default>"Salesforce/Llama-Rank-V1"</default>
        /// <example>Salesforce/Llama-Rank-V1</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The search query to be used for ranking.<br/>
        /// Default Value: What animals can I find near Peru?<br/>
        /// Example: What animals can I find near Peru?
        /// </summary>
        /// <default>"What animals can I find near Peru?"</default>
        /// <example>What animals can I find near Peru?</example>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// List of keys in the JSON Object document to rank by. Defaults to use all supplied keys for ranking.<br/>
        /// Example: [title, text]
        /// </summary>
        /// <example>[title, text]</example>
        [global::Newtonsoft.Json.JsonProperty("rank_fields")]
        public global::System.Collections.Generic.IList<string>? RankFields { get; set; }

        /// <summary>
        /// Whether to return supplied documents with the response.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// The number of top results to return.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
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
        /// List of documents, which can be either strings or objects.<br/>
        /// Default Value: [, , , ]
        /// </param>
        /// <param name="model">
        /// The model to be used for the rerank request.<br/>
        /// Default Value: Salesforce/Llama-Rank-V1<br/>
        /// Example: Salesforce/Llama-Rank-V1
        /// </param>
        /// <param name="query">
        /// The search query to be used for ranking.<br/>
        /// Default Value: What animals can I find near Peru?<br/>
        /// Example: What animals can I find near Peru?
        /// </param>
        /// <param name="rankFields">
        /// List of keys in the JSON Object document to rank by. Defaults to use all supplied keys for ranking.<br/>
        /// Example: [title, text]
        /// </param>
        /// <param name="returnDocuments">
        /// Whether to return supplied documents with the response.<br/>
        /// Example: true
        /// </param>
        /// <param name="topN">
        /// The number of top results to return.<br/>
        /// Example: 2
        /// </param>
        public RerankRequest(
            global::G.OneOf<global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.IList<string>> documents,
            string model,
            string query,
            global::System.Collections.Generic.IList<string>? rankFields,
            bool? returnDocuments,
            int? topN)
        {
            this.Documents = documents;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
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