//HintName: G.Models.ChunkInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChunkInfo
    {
        /// <summary>
        /// The index of the chunk. The platform uses 1-based indexing, and this value matches the value of the [`chunk_index`](/v1.3/api-reference/upload-content/multipart-uploads/create#response.body.upload_urls.chunk_index) field in the list of upload URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The current status of this chunk. This field can take one of the following values:<br/>
        /// - `completed`: Successfully uploaded and reported.<br/>
        /// - `pending`: Not yet reported. A chunk may be in this status if it has been uploaded but not yet reported.<br/>
        /// - `failed`: The upload process failed; you must retry uploading this chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChunkInfoStatusJsonConverter))]
        public global::G.ChunkInfoStatus? Status { get; set; }

        /// <summary>
        /// The date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when this chunk was successfully reported as uploaded. The value of this field is `null` for pending or failed chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_at")]
        public global::System.DateTime? UploadedAt { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// A detailed error message explaining why this chunk failed. The platform returns this field only when the status is failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkInfo" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the chunk. The platform uses 1-based indexing, and this value matches the value of the [`chunk_index`](/v1.3/api-reference/upload-content/multipart-uploads/create#response.body.upload_urls.chunk_index) field in the list of upload URLs.
        /// </param>
        /// <param name="status">
        /// The current status of this chunk. This field can take one of the following values:<br/>
        /// - `completed`: Successfully uploaded and reported.<br/>
        /// - `pending`: Not yet reported. A chunk may be in this status if it has been uploaded but not yet reported.<br/>
        /// - `failed`: The upload process failed; you must retry uploading this chunk.
        /// </param>
        /// <param name="uploadedAt">
        /// The date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when this chunk was successfully reported as uploaded. The value of this field is `null` for pending or failed chunks.
        /// </param>
        /// <param name="updatedAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was last updated.
        /// </param>
        /// <param name="error">
        /// A detailed error message explaining why this chunk failed. The platform returns this field only when the status is failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChunkInfo(
            int? index,
            global::G.ChunkInfoStatus? status,
            global::System.DateTime? uploadedAt,
            global::System.DateTime? updatedAt,
            string? error)
        {
            this.Index = index;
            this.Status = status;
            this.UploadedAt = uploadedAt;
            this.UpdatedAt = updatedAt;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkInfo" /> class.
        /// </summary>
        public ChunkInfo()
        {
        }
    }
}