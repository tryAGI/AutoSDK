//HintName: G.Models.CreateAssetUploadResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetUploadResponse
    {
        /// <summary>
        /// The unique identifier of this upload session. Store this value, as you'll need it for the following subsequent operations:<br/>
        /// - Reporting completed chunks<br/>
        /// - Requesting additional presigned URLs<br/>
        /// - Retrieving the status of this upload session<br/>
        /// This identifier remains valid for 24 hours from the time of creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        public string? UploadId { get; set; }

        /// <summary>
        /// The unique identifier for the asset being created. Store this value, as you'll need it to reference the asset in other API calls. Note that this identifier is reserved immediately, but the asset becomes available for other operations only after the upload is completed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// An array containing the initial set of presigned URLs for uploading chunks. Each URL corresponds to a specific chunk.<br/>
        /// Note the following about the presigned URLs:<br/>
        /// - URLs expire after one hour.<br/>
        /// - Depending on the size of the file, the initial set may not include URLs for all chunks. If you need more URLs, you can request additional ones using the [`POST`](/v1.3/api-reference/upload-content/multipart-uploads/get-additional-presigned-urls) method of the `/assets/multipart-uploads/{upload_id}/presigned-urls` endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_urls")]
        public global::System.Collections.Generic.IList<global::G.PresignedURLChunk>? UploadUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? UploadHeaders { get; set; }

        /// <summary>
        /// The size in bytes for each chunk, except for the last chunk, which may be smaller. Use this value to divide your file into chunks of this exact size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_size")]
        public long? ChunkSize { get; set; }

        /// <summary>
        /// The total number of chunks into which your file must be split. Calculated as: ceiling(`total_size` / `chunk_size`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_chunks")]
        public int? TotalChunks { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the upload URL will expire. Upload URLs expire 24 hours from their creation. After expiration, you cannot resume the upload, and you must create a new upload session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetUploadResponse" /> class.
        /// </summary>
        /// <param name="uploadId">
        /// The unique identifier of this upload session. Store this value, as you'll need it for the following subsequent operations:<br/>
        /// - Reporting completed chunks<br/>
        /// - Requesting additional presigned URLs<br/>
        /// - Retrieving the status of this upload session<br/>
        /// This identifier remains valid for 24 hours from the time of creation.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier for the asset being created. Store this value, as you'll need it to reference the asset in other API calls. Note that this identifier is reserved immediately, but the asset becomes available for other operations only after the upload is completed successfully.
        /// </param>
        /// <param name="uploadUrls">
        /// An array containing the initial set of presigned URLs for uploading chunks. Each URL corresponds to a specific chunk.<br/>
        /// Note the following about the presigned URLs:<br/>
        /// - URLs expire after one hour.<br/>
        /// - Depending on the size of the file, the initial set may not include URLs for all chunks. If you need more URLs, you can request additional ones using the [`POST`](/v1.3/api-reference/upload-content/multipart-uploads/get-additional-presigned-urls) method of the `/assets/multipart-uploads/{upload_id}/presigned-urls` endpoint.
        /// </param>
        /// <param name="uploadHeaders"></param>
        /// <param name="chunkSize">
        /// The size in bytes for each chunk, except for the last chunk, which may be smaller. Use this value to divide your file into chunks of this exact size.
        /// </param>
        /// <param name="totalChunks">
        /// The total number of chunks into which your file must be split. Calculated as: ceiling(`total_size` / `chunk_size`).
        /// </param>
        /// <param name="expiresAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the upload URL will expire. Upload URLs expire 24 hours from their creation. After expiration, you cannot resume the upload, and you must create a new upload session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetUploadResponse(
            string? uploadId,
            string? assetId,
            global::System.Collections.Generic.IList<global::G.PresignedURLChunk>? uploadUrls,
            global::System.Collections.Generic.Dictionary<string, string>? uploadHeaders,
            long? chunkSize,
            int? totalChunks,
            global::System.DateTime? expiresAt)
        {
            this.UploadId = uploadId;
            this.AssetId = assetId;
            this.UploadUrls = uploadUrls;
            this.UploadHeaders = uploadHeaders;
            this.ChunkSize = chunkSize;
            this.TotalChunks = totalChunks;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetUploadResponse" /> class.
        /// </summary>
        public CreateAssetUploadResponse()
        {
        }
    }
}