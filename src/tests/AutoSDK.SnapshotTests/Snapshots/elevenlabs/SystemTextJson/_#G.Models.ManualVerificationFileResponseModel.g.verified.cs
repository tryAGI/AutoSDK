//HintName: G.Models.ManualVerificationFileResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"file_id":"CwhRBWXzGAHq8TQ4Fs18","file_name":"file.mp3","mime_type":"audio/mpeg","size_bytes":1000000,"upload_date_unix":1714204800}
    /// </summary>
    public sealed partial class ManualVerificationFileResponseModel
    {
        /// <summary>
        /// The ID of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// The MIME type of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// The size of the file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeBytes { get; set; }

        /// <summary>
        /// The date of the file in Unix time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UploadDateUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualVerificationFileResponseModel" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
        /// <param name="fileName">
        /// The name of the file.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the file.
        /// </param>
        /// <param name="sizeBytes">
        /// The size of the file in bytes.
        /// </param>
        /// <param name="uploadDateUnix">
        /// The date of the file in Unix time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManualVerificationFileResponseModel(
            string fileId,
            string fileName,
            string mimeType,
            int sizeBytes,
            int uploadDateUnix)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.SizeBytes = sizeBytes;
            this.UploadDateUnix = uploadDateUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualVerificationFileResponseModel" /> class.
        /// </summary>
        public ManualVerificationFileResponseModel()
        {
        }
    }
}