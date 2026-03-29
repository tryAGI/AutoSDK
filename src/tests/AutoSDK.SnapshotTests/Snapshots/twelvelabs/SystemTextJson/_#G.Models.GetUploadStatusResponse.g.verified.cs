//HintName: G.Models.GetUploadStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUploadStatusResponse
    {
        /// <summary>
        /// The unique identifier of your upload session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        public string? UploadId { get; set; }

        /// <summary>
        /// The status of your upload session. This field can take one of the following values:<br/>
        /// - `active`: The upload session is currently in progress. Continue uploading and reporting the completion of each chunk.<br/>
        /// - `completed`: The upload session is finished, and your asset is now ready for use.<br/>
        /// - `failed`: The upload session has failed. You must restart with a new session.<br/>
        /// - `expired`: The upload session has expired after 24 hours, and you must create a new session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MultipartUploadStatusTypeJsonConverter))]
        public global::G.MultipartUploadStatusType? Status { get; set; }

        /// <summary>
        /// Detailed status for each chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_chunks")]
        public global::System.Collections.Generic.IList<global::G.ChunkInfo>? UploadedChunks { get; set; }

        /// <summary>
        /// The number of chunks successfully uploaded and reported. When this value equals `total_chunks`, the status of your upload session transitions to `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks_completed")]
        public int? ChunksCompleted { get; set; }

        /// <summary>
        /// The number of chunks that failed to upload. If the number is greater than 0, check the `uploaded_chunks` array for specific failures and retry those chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks_failed")]
        public int? ChunksFailed { get; set; }

        /// <summary>
        /// The number of chunks not yet successfully uploaded. This value is calculated as: `total_chunks` - `chunks_completed` - `chunks_failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks_pending")]
        public int? ChunksPending { get; set; }

        /// <summary>
        /// An object that provides information about pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_info")]
        public global::G.PageInfo? PageInfo { get; set; }

        /// <summary>
        /// The size of your file in bytes. You provided this value when you created the upload session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size")]
        public long? TotalSize { get; set; }

        /// <summary>
        /// The number of bytes successfully uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_size")]
        public long? UploadedSize { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUploadStatusResponse" /> class.
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
        /// <param name="uploadedChunks">
        /// Detailed status for each chunk.
        /// </param>
        /// <param name="chunksCompleted">
        /// The number of chunks successfully uploaded and reported. When this value equals `total_chunks`, the status of your upload session transitions to `completed`.
        /// </param>
        /// <param name="chunksFailed">
        /// The number of chunks that failed to upload. If the number is greater than 0, check the `uploaded_chunks` array for specific failures and retry those chunks.
        /// </param>
        /// <param name="chunksPending">
        /// The number of chunks not yet successfully uploaded. This value is calculated as: `total_chunks` - `chunks_completed` - `chunks_failed`.
        /// </param>
        /// <param name="pageInfo">
        /// An object that provides information about pagination.
        /// </param>
        /// <param name="totalSize">
        /// The size of your file in bytes. You provided this value when you created the upload session.
        /// </param>
        /// <param name="uploadedSize">
        /// The number of bytes successfully uploaded
        /// </param>
        /// <param name="createdAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was created.
        /// </param>
        /// <param name="updatedAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUploadStatusResponse(
            string? uploadId,
            global::G.MultipartUploadStatusType? status,
            global::System.Collections.Generic.IList<global::G.ChunkInfo>? uploadedChunks,
            int? chunksCompleted,
            int? chunksFailed,
            int? chunksPending,
            global::G.PageInfo? pageInfo,
            long? totalSize,
            long? uploadedSize,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.UploadId = uploadId;
            this.Status = status;
            this.UploadedChunks = uploadedChunks;
            this.ChunksCompleted = chunksCompleted;
            this.ChunksFailed = chunksFailed;
            this.ChunksPending = chunksPending;
            this.PageInfo = pageInfo;
            this.TotalSize = totalSize;
            this.UploadedSize = uploadedSize;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUploadStatusResponse" /> class.
        /// </summary>
        public GetUploadStatusResponse()
        {
        }
    }
}