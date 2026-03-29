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
        [global::Newtonsoft.Json.JsonProperty("upload_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadId { get; set; } = default!;

        /// <summary>
        /// The status of your upload session. This field can take one of the following values:<br/>
        /// - `active`: The upload session is currently in progress. Continue uploading and reporting the completion of each chunk.<br/>
        /// - `completed`: The upload session is finished, and your asset is now ready for use.<br/>
        /// - `failed`: The upload session has failed. You must restart with a new session.<br/>
        /// - `expired`: The upload session has expired after 24 hours, and you must create a new session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MultipartUploadStatusType Status { get; set; } = default!;

        /// <summary>
        /// Total size of the file in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_size", Required = global::Newtonsoft.Json.Required.Always)]
        public long TotalSize { get; set; } = default!;

        /// <summary>
        /// The size of each chunk in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_size", Required = global::Newtonsoft.Json.Required.Always)]
        public long ChunkSize { get; set; } = default!;

        /// <summary>
        /// The total number of chunks in this upload session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_chunks", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalChunks { get; set; } = default!;

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource will expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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