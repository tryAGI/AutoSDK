//HintName: G.Models.IncompleteUploadSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IncompleteUploadSummary
    {
        /// <summary>
        /// The unique identifier of your upload session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadId { get; set; }

        /// <summary>
        /// The status of your upload session. This field can take one of the following values:<br/>
        /// - `active`: The upload session is currently in progress. Continue uploading and reporting the completion of each chunk.<br/>
        /// - `completed`: The upload session is finished, and your asset is now ready for use.<br/>
        /// - `failed`: The upload session has failed. You must restart with a new session.<br/>
        /// - `expired`: The upload session has expired after 24 hours, and you must create a new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MultipartUploadStatusTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MultipartUploadStatusType Status { get; set; }

        /// <summary>
        /// Total size of the file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TotalSize { get; set; }

        /// <summary>
        /// The size of each chunk in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ChunkSize { get; set; }

        /// <summary>
        /// The total number of chunks in this upload session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalChunks { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="IncompleteUploadSummary" /> class.
        /// </summary>
        /// <param name="uploadId">
        /// The unique identifier of your upload session.
        /// </param>
        /// <param name="status">
        /// The status of your upload session. This field can take one of the following values:<br/>
        /// - `active`: The upload session is currently in progress. Continue uploading and reporting the completion of each chunk.<br/>
        /// - `completed`: The upload session is finished, and your asset is now ready for use.<br/>
        /// - `failed`: The upload session has failed. You must restart with a new session.<br/>
        /// - `expired`: The upload session has expired after 24 hours, and you must create a new session.
        /// </param>
        /// <param name="totalSize">
        /// Total size of the file in bytes.
        /// </param>
        /// <param name="chunkSize">
        /// The size of each chunk in bytes.
        /// </param>
        /// <param name="totalChunks">
        /// The total number of chunks in this upload session.
        /// </param>
        /// <param name="createdAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was created.
        /// </param>
        /// <param name="expiresAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource will expire.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IncompleteUploadSummary(
            string uploadId,
            global::G.MultipartUploadStatusType status,
            long totalSize,
            long chunkSize,
            int totalChunks,
            global::System.DateTime? createdAt,
            global::System.DateTime? expiresAt)
        {
            this.UploadId = uploadId ?? throw new global::System.ArgumentNullException(nameof(uploadId));
            this.Status = status;
            this.TotalSize = totalSize;
            this.ChunkSize = chunkSize;
            this.TotalChunks = totalChunks;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IncompleteUploadSummary" /> class.
        /// </summary>
        public IncompleteUploadSummary()
        {
        }
    }
}