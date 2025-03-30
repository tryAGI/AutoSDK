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
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChunkId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_distance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double VectorDistance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RagChunkMetadata" /> class.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="chunkId"></param>
        /// <param name="vectorDistance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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