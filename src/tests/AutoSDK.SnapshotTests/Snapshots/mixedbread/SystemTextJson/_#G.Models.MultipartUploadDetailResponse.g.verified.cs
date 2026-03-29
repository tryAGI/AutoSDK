//HintName: G.Models.MultipartUploadDetailResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultipartUploadDetailResponse
    {
        /// <summary>
        /// The multipart upload record ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Original filename
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Total file size in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FileSize { get; set; }

        /// <summary>
        /// MIME type of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// Number of parts the file was split into
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PartCount { get; set; }

        /// <summary>
        /// When the upload was initiated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Parts that have already been uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_parts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MultipartUploadPart> CompletedParts { get; set; }

        /// <summary>
        /// Presigned URLs for the parts that still need to be uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MultipartUploadPartUrl> PartUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadDetailResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The multipart upload record ID
        /// </param>
        /// <param name="filename">
        /// Original filename
        /// </param>
        /// <param name="fileSize">
        /// Total file size in bytes
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the file
        /// </param>
        /// <param name="partCount">
        /// Number of parts the file was split into
        /// </param>
        /// <param name="createdAt">
        /// When the upload was initiated
        /// </param>
        /// <param name="completedParts">
        /// Parts that have already been uploaded
        /// </param>
        /// <param name="partUrls">
        /// Presigned URLs for the parts that still need to be uploaded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultipartUploadDetailResponse(
            string id,
            string filename,
            long fileSize,
            string mimeType,
            int partCount,
            string createdAt,
            global::System.Collections.Generic.IList<global::G.MultipartUploadPart> completedParts,
            global::System.Collections.Generic.IList<global::G.MultipartUploadPartUrl> partUrls)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.FileSize = fileSize;
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.PartCount = partCount;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CompletedParts = completedParts ?? throw new global::System.ArgumentNullException(nameof(completedParts));
            this.PartUrls = partUrls ?? throw new global::System.ArgumentNullException(nameof(partUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadDetailResponse" /> class.
        /// </summary>
        public MultipartUploadDetailResponse()
        {
        }
    }
}