//HintName: G.Models.RagConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RagConfig
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Default Value: e5_mistral_7b_instruct
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingModelEnumJsonConverter))]
        public global::G.EmbeddingModelEnum? EmbeddingModel { get; set; }

        /// <summary>
        /// Maximum vector distance of retrieved chunks.<br/>
        /// Default Value: 0.6F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_vector_distance")]
        public double? MaxVectorDistance { get; set; }

        /// <summary>
        /// Maximum total length of document chunks retrieved from RAG.<br/>
        /// Default Value: 50000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_documents_length")]
        public int? MaxDocumentsLength { get; set; }

        /// <summary>
        /// Maximum number of RAG document chunks to initially retrieve from the vector store. These are then further filtered by vector distance and total length.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_retrieved_rag_chunks_count")]
        public int? MaxRetrievedRagChunksCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RagConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
        /// <param name="embeddingModel">
        /// Default Value: e5_mistral_7b_instruct
        /// </param>
        /// <param name="maxVectorDistance">
        /// Maximum vector distance of retrieved chunks.<br/>
        /// Default Value: 0.6F
        /// </param>
        /// <param name="maxDocumentsLength">
        /// Maximum total length of document chunks retrieved from RAG.<br/>
        /// Default Value: 50000
        /// </param>
        /// <param name="maxRetrievedRagChunksCount">
        /// Maximum number of RAG document chunks to initially retrieve from the vector store. These are then further filtered by vector distance and total length.<br/>
        /// Default Value: 20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RagConfig(
            bool? enabled,
            global::G.EmbeddingModelEnum? embeddingModel,
            double? maxVectorDistance,
            int? maxDocumentsLength,
            int? maxRetrievedRagChunksCount)
        {
            this.Enabled = enabled;
            this.EmbeddingModel = embeddingModel;
            this.MaxVectorDistance = maxVectorDistance;
            this.MaxDocumentsLength = maxDocumentsLength;
            this.MaxRetrievedRagChunksCount = maxRetrievedRagChunksCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RagConfig" /> class.
        /// </summary>
        public RagConfig()
        {
        }
    }
}