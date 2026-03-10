//HintName: G.Models.GetOrCreateRAGIndexRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrCreateRAGIndexRequestModel
    {
        /// <summary>
        /// ID of the knowledgebase document for which to retrieve the index
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DocumentId { get; set; } = default!;

        /// <summary>
        /// Whether to create the RAG index if it does not exist
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("create_if_missing", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CreateIfMissing { get; set; } = default!;

        /// <summary>
        /// Embedding model to use for the RAG index
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingModelEnum Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrCreateRAGIndexRequestModel" /> class.
        /// </summary>
        /// <param name="documentId">
        /// ID of the knowledgebase document for which to retrieve the index
        /// </param>
        /// <param name="createIfMissing">
        /// Whether to create the RAG index if it does not exist
        /// </param>
        /// <param name="model">
        /// Embedding model to use for the RAG index
        /// </param>
        public GetOrCreateRAGIndexRequestModel(
            string documentId,
            bool createIfMissing,
            global::G.EmbeddingModelEnum model)
        {
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.CreateIfMissing = createIfMissing;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrCreateRAGIndexRequestModel" /> class.
        /// </summary>
        public GetOrCreateRAGIndexRequestModel()
        {
        }
    }
}