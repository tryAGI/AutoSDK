//HintName: G.Models.CreateMultipartUploadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMultipartUploadRequest
    {
        /// <summary>
        /// Name of the file including extension
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Total size of the file in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_size", Required = global::Newtonsoft.Json.Required.Always)]
        public long FileSize { get; set; } = default!;

        /// <summary>
        /// MIME type of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// Number of parts to split the upload into<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("part_count")]
        public int? PartCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMultipartUploadRequest" /> class.
        /// </summary>
        /// <param name="filename">
        /// Name of the file including extension
        /// </param>
        /// <param name="fileSize">
        /// Total size of the file in bytes
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the file
        /// </param>
        /// <param name="partCount">
        /// Number of parts to split the upload into<br/>
        /// Default Value: 1
        /// </param>
        public CreateMultipartUploadRequest(
            string filename,
            long fileSize,
            string mimeType,
            int? partCount)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.FileSize = fileSize;
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.PartCount = partCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMultipartUploadRequest" /> class.
        /// </summary>
        public CreateMultipartUploadRequest()
        {
        }
    }
}