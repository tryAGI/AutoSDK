//HintName: G.Models.CompletedChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletedChunk
    {
        /// <summary>
        /// The number that identifies which chunk you uploaded. When you received presigned URLs from the platform, each URL was assigned an index number. Use that same number. The chunks are numbered starting from 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkIndex { get; set; }

        /// <summary>
        /// The ETag value you received after uploading the chunk. When you upload a chunk to a presigned URLs, the response includes an ETag. Use this value and submit it as proof of successful upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proof")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Proof { get; set; }

        /// <summary>
        /// The verification method. Supported value: `etag`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proof_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompletedChunkProofTypeJsonConverter))]
        public global::G.CompletedChunkProofType ProofType { get; set; }

        /// <summary>
        /// The number of bytes uploaded for this chunk. For all chunks except the last, this value equals [`chunk_size`](/v1.3/api-reference/upload-content/multipart-uploads/create#response.body.chunk_size). For the last chunk, it may be smaller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ChunkSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletedChunk" /> class.
        /// </summary>
        /// <param name="chunkIndex">
        /// The number that identifies which chunk you uploaded. When you received presigned URLs from the platform, each URL was assigned an index number. Use that same number. The chunks are numbered starting from 1.
        /// </param>
        /// <param name="proof">
        /// The ETag value you received after uploading the chunk. When you upload a chunk to a presigned URLs, the response includes an ETag. Use this value and submit it as proof of successful upload.
        /// </param>
        /// <param name="chunkSize">
        /// The number of bytes uploaded for this chunk. For all chunks except the last, this value equals [`chunk_size`](/v1.3/api-reference/upload-content/multipart-uploads/create#response.body.chunk_size). For the last chunk, it may be smaller.
        /// </param>
        /// <param name="proofType">
        /// The verification method. Supported value: `etag`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletedChunk(
            int chunkIndex,
            string proof,
            long chunkSize,
            global::G.CompletedChunkProofType proofType)
        {
            this.ChunkIndex = chunkIndex;
            this.Proof = proof ?? throw new global::System.ArgumentNullException(nameof(proof));
            this.ProofType = proofType;
            this.ChunkSize = chunkSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletedChunk" /> class.
        /// </summary>
        public CompletedChunk()
        {
        }
    }
}