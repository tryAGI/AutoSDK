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
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentId { get; set; }

        /// <summary>
        /// Whether to create the RAG index if it does not exist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_if_missing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CreateIfMissing { get; set; }

        /// <summary>
        /// Embedding model to use for the RAG index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingModelEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbeddingModelEnum Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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