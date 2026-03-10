//HintName: G.Models.RagConfigWorkflowOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RagConfigWorkflowOverride
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_model")]
        public global::G.EmbeddingModelEnum? EmbeddingModel { get; set; }

        /// <summary>
        /// Maximum vector distance of retrieved chunks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_vector_distance")]
        public double? MaxVectorDistance { get; set; }

        /// <summary>
        /// Maximum total length of document chunks retrieved from RAG.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_documents_length")]
        public int? MaxDocumentsLength { get; set; }

        /// <summary>
        /// Maximum number of RAG document chunks to initially retrieve from the vector store. These are then further filtered by vector distance and total length.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_retrieved_rag_chunks_count")]
        public int? MaxRetrievedRagChunksCount { get; set; }

        /// <summary>
        /// Number of candidates evaluated in ANN vector search. Higher number means better results, but higher latency. Minimum recommended value is 100. If disabled, the default value is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_candidates")]
        public int? NumCandidates { get; set; }

        /// <summary>
        /// Custom prompt for rewriting user queries before RAG retrieval. The conversation history will be automatically appended at the end. If not set, the default prompt will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_rewrite_prompt_override")]
        public string? QueryRewritePromptOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RagConfigWorkflowOverride" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="embeddingModel"></param>
        /// <param name="maxVectorDistance">
        /// Maximum vector distance of retrieved chunks.
        /// </param>
        /// <param name="maxDocumentsLength">
        /// Maximum total length of document chunks retrieved from RAG.
        /// </param>
        /// <param name="maxRetrievedRagChunksCount">
        /// Maximum number of RAG document chunks to initially retrieve from the vector store. These are then further filtered by vector distance and total length.
        /// </param>
        /// <param name="numCandidates">
        /// Number of candidates evaluated in ANN vector search. Higher number means better results, but higher latency. Minimum recommended value is 100. If disabled, the default value is used.
        /// </param>
        /// <param name="queryRewritePromptOverride">
        /// Custom prompt for rewriting user queries before RAG retrieval. The conversation history will be automatically appended at the end. If not set, the default prompt will be used.
        /// </param>
        public RagConfigWorkflowOverride(
            bool? enabled,
            global::G.EmbeddingModelEnum? embeddingModel,
            double? maxVectorDistance,
            int? maxDocumentsLength,
            int? maxRetrievedRagChunksCount,
            int? numCandidates,
            string? queryRewritePromptOverride)
        {
            this.Enabled = enabled;
            this.EmbeddingModel = embeddingModel;
            this.MaxVectorDistance = maxVectorDistance;
            this.MaxDocumentsLength = maxDocumentsLength;
            this.MaxRetrievedRagChunksCount = maxRetrievedRagChunksCount;
            this.NumCandidates = numCandidates;
            this.QueryRewritePromptOverride = queryRewritePromptOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RagConfigWorkflowOverride" /> class.
        /// </summary>
        public RagConfigWorkflowOverride()
        {
        }
    }
}