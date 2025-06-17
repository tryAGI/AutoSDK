//HintName: G.Models.AdditionalFormatResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdditionalFormatResponseModel
    {
        /// <summary>
        /// The requested format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_format", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestedFormat { get; set; } = default!;

        /// <summary>
        /// The file extension of the additional format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_extension", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileExtension { get; set; } = default!;

        /// <summary>
        /// The content type of the additional format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// Whether the content is base64 encoded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_base64_encoded", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsBase64Encoded { get; set; } = default!;

        /// <summary>
        /// The content of the additional format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFormatResponseModel" /> class.
        /// </summary>
        /// <param name="requestedFormat">
        /// The requested format.
        /// </param>
        /// <param name="fileExtension">
        /// The file extension of the additional format.
        /// </param>
        /// <param name="contentType">
        /// The content type of the additional format.
        /// </param>
        /// <param name="isBase64Encoded">
        /// Whether the content is base64 encoded.
        /// </param>
        /// <param name="content">
        /// The content of the additional format.
        /// </param>
        public AdditionalFormatResponseModel(
            string requestedFormat,
            string fileExtension,
            string contentType,
            bool isBase64Encoded,
            string content)
        {
            this.RequestedFormat = requestedFormat ?? throw new global::System.ArgumentNullException(nameof(requestedFormat));
            this.FileExtension = fileExtension ?? throw new global::System.ArgumentNullException(nameof(fileExtension));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.IsBase64Encoded = isBase64Encoded;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFormatResponseModel" /> class.
        /// </summary>
        public AdditionalFormatResponseModel()
        {
        }
    }
}