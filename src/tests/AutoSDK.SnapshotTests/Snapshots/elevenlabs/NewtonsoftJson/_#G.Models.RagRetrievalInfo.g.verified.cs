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
        [global::Newtonsoft.Json.JsonProperty("chunks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RagChunkMetadata> Chunks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingModelEnum EmbeddingModel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieval_query", Required = global::Newtonsoft.Json.Required.Always)]
        public string RetrievalQuery { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rag_latency_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public double RagLatencySecs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RagRetrievalInfo" /> class.
        /// </summary>
        /// <param name="chunks"></param>
        /// <param name="embeddingModel"></param>
        /// <param name="retrievalQuery"></param>
        /// <param name="ragLatencySecs"></param>
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