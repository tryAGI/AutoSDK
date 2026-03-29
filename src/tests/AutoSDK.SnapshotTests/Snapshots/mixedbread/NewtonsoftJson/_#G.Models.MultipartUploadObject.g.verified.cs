//HintName: G.Models.MultipartUploadObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultipartUploadObject
    {
        /// <summary>
        /// The multipart upload record ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Original filename
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Total file size in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_size", Required = global::Newtonsoft.Json.Required.Always)]
        public long FileSize { get; set; } = default!;

        /// <summary>
        /// MIME type of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// Number of parts the file was split into
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("part_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int PartCount { get; set; } = default!;

        /// <summary>
        /// When the upload was initiated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadObject" /> class.
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
        public MultipartUploadObject(
            string id,
            string filename,
            long fileSize,
            string mimeType,
            int partCount,
            string createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.FileSize = fileSize;
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.PartCount = partCount;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadObject" /> class.
        /// </summary>
        public MultipartUploadObject()
        {
        }
    }
}