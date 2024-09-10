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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The search query to be used for ranking.<br/>
        /// Example: What animals can I find near Peru?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// List of documents, which can be either strings or objects.<br/>
        /// Example: [, , , ]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::System.Collections.Generic.IList<global::G.RerankRequestDocumentsVariant1Item>, global::System.Collections.Generic.IList<string>> Documents { get; set; }

        /// <summary>
        /// The number of top results to return.<br/>
        /// Example: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int TopN { get; set; }

        /// <summary>
        /// Whether to return supplied documents with the response.<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_documents")]
        public bool ReturnDocuments { get; set; }

        /// <summary>
        /// List of keys in the JSON Object document to rank by. Defaults to use all supplied keys for ranking.<br/>
        /// Example: [title, text]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank_fields")]
        public global::System.Collections.Generic.IList<string>? RankFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}