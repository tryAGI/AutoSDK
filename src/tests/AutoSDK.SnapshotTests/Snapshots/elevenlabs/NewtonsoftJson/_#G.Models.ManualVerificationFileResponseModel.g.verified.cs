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
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// The name of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// The MIME type of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// The size of the file in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int SizeBytes { get; set; } = default!;

        /// <summary>
        /// The date of the file in Unix time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_date_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int UploadDateUnix { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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