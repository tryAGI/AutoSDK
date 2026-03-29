//HintName: G.Models.PresignedURLChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresignedURLChunk
    {
        /// <summary>
        /// The index of this chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_index")]
        public int? ChunkIndex { get; set; }

        /// <summary>
        /// The presigned URL for uploading this chunk. Each URL can only be used once and expires after 1 hour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignedURLChunk" /> class.
        /// </summary>
        /// <param name="chunkIndex">
        /// The index of this chunk.
        /// </param>
        /// <param name="url">
        /// The presigned URL for uploading this chunk. Each URL can only be used once and expires after 1 hour.
        /// </param>
        /// <param name="expiresAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource will expire.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresignedURLChunk(
            int? chunkIndex,
            string? url,
            global::System.DateTime? expiresAt)
        {
            this.ChunkIndex = chunkIndex;
            this.Url = url;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignedURLChunk" /> class.
        /// </summary>
        public PresignedURLChunk()
        {
        }
    }
}