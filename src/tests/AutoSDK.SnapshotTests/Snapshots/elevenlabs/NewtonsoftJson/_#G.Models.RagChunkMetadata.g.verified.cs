//HintName: G.Models.RagChunkMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RagChunkMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DocumentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChunkId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_distance", Required = global::Newtonsoft.Json.Required.Always)]
        public double VectorDistance { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RagChunkMetadata" /> class.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="chunkId"></param>
        /// <param name="vectorDistance"></param>
        public RagChunkMetadata(
            string documentId,
            string chunkId,
            double vectorDistance)
        {
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.ChunkId = chunkId ?? throw new global::System.ArgumentNullException(nameof(chunkId));
            this.VectorDistance = vectorDistance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RagChunkMetadata" /> class.
        /// </summary>
        public RagChunkMetadata()
        {
        }
    }
}