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
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Total size of the file in bytes
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
        /// Number of parts to split the upload into<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_count")]
        public int? PartCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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