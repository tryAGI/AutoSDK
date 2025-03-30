//HintName: G.Models.RagRetrievalInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RagRetrievalInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RagChunkMetadata> Chunks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingModelEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbeddingModelEnum EmbeddingModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RetrievalQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_latency_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RagLatencySecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RagRetrievalInfo" /> class.
        /// </summary>
        /// <param name="chunks"></param>
        /// <param name="embeddingModel"></param>
        /// <param name="retrievalQuery"></param>
        /// <param name="ragLatencySecs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RagRetrievalInfo(
            global::System.Collections.Generic.IList<global::G.RagChunkMetadata> chunks,
            global::G.EmbeddingModelEnum embeddingModel,
            string retrievalQuery,
            double ragLatencySecs)
        {
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
            this.EmbeddingModel = embeddingModel;
            this.RetrievalQuery = retrievalQuery ?? throw new global::System.ArgumentNullException(nameof(retrievalQuery));
            this.RagLatencySecs = ragLatencySecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RagRetrievalInfo" /> class.
        /// </summary>
        public RagRetrievalInfo()
        {
        }
    }
}