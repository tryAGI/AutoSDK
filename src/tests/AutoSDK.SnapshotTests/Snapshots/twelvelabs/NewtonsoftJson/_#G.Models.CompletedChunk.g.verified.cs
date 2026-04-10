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
        [global::Newtonsoft.Json.JsonProperty("chunk_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChunkIndex { get; set; } = default!;

        /// <summary>
        /// The ETag value you received after uploading the chunk. When you upload a chunk to a presigned URLs, the response includes an ETag. Use this value and submit it as proof of successful upload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proof", Required = global::Newtonsoft.Json.Required.Always)]
        public string Proof { get; set; } = default!;

        /// <summary>
        /// The verification method. Supported value: `etag`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proof_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CompletedChunkProofTypeJsonConverter))]
        public global::G.CompletedChunkProofType ProofType { get; set; }

        /// <summary>
        /// The number of bytes uploaded for this chunk. For all chunks except the last, this value equals [`chunk_size`](/v1.3/api-reference/upload-content/multipart-uploads/create#response.body.chunk_size). For the last chunk, it may be smaller.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_size", Required = global::Newtonsoft.Json.Required.Always)]
        public long ChunkSize { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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