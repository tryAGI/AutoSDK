//HintName: G.Models.RerankRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankRequest
    {
        /// <summary>
        /// The model to use for reranking.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The query to rank against.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// Array of documents to rank.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Documents { get; set; } = default!;

        /// <summary>
        /// Boolean setting whether to return documents in output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for reranking.
        /// </param>
        /// <param name="query">
        /// The query to rank against.
        /// </param>
        /// <param name="documents">
        /// Array of documents to rank.
        /// </param>
        /// <param name="returnDocuments">
        /// Boolean setting whether to return documents in output.
        /// </param>
        public RerankRequest(
            string model,
            string query,
            global::System.Collections.Generic.IList<string> documents,
            bool? returnDocuments)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.ReturnDocuments = returnDocuments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        public RerankRequest()
        {
        }
    }
}