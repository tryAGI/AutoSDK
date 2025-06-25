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
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestedFormat { get; set; }

        /// <summary>
        /// The file extension of the additional format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_extension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileExtension { get; set; }

        /// <summary>
        /// The content type of the additional format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// Whether the content is base64 encoded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_base64_encoded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBase64Encoded { get; set; }

        /// <summary>
        /// The content of the additional format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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