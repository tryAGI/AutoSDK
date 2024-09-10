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
        /// The model to be used for the rerank request.<br/>
        /// Example: Salesforce/Llama-Rank-V1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The search query to be used for ranking.<br/>
        /// Example: What animals can I find near Peru?
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// List of documents, which can be either strings or objects.<br/>
        /// Example: [, , , ]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::System.Collections.Generic.IList<global::G.RerankRequestDocumentsVariant1Item>, global::System.Collections.Generic.IList<string>> Documents { get; set; } = default!;

        /// <summary>
        /// The number of top results to return.<br/>
        /// Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_n")]
        public int TopN { get; set; }

        /// <summary>
        /// Whether to return supplied documents with the response.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_documents")]
        public bool ReturnDocuments { get; set; }

        /// <summary>
        /// List of keys in the JSON Object document to rank by. Defaults to use all supplied keys for ranking.<br/>
        /// Example: [title, text]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rank_fields")]
        public global::System.Collections.Generic.IList<string>? RankFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}