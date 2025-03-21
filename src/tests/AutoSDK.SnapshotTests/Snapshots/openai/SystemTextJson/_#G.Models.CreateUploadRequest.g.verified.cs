//HintName: G.Models.CreateUploadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUploadRequest
    {
        /// <summary>
        /// The number of bytes in the file you are uploading.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Bytes { get; set; }

        /// <summary>
        /// The name of the file to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The MIME type of the file.<br/>
        /// This must fall within the supported MIME types for your file purpose. See the supported MIME types for assistants and vision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// The intended purpose of the uploaded file.<br/>
        /// See the [documentation on File purposes](/docs/api-reference/files/create#files-create-purpose).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateUploadRequestPurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateUploadRequestPurpose Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadRequest" /> class.
        /// </summary>
        /// <param name="bytes">
        /// The number of bytes in the file you are uploading.
        /// </param>
        /// <param name="filename">
        /// The name of the file to upload.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the file.<br/>
        /// This must fall within the supported MIME types for your file purpose. See the supported MIME types for assistants and vision.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file.<br/>
        /// See the [documentation on File purposes](/docs/api-reference/files/create#files-create-purpose).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUploadRequest(
            int bytes,
            string filename,
            string mimeType,
            global::G.CreateUploadRequestPurpose purpose)
        {
            this.Bytes = bytes;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadRequest" /> class.
        /// </summary>
        public CreateUploadRequest()
        {
        }
    }
}