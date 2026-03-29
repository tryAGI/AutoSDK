//HintName: G.Models.CreateAttachmentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAttachmentResponse
    {
        /// <summary>
        /// Name of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Mime type of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Size of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Content of the file in string format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAttachmentResponse" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the file
        /// </param>
        /// <param name="mimeType">
        /// Mime type of the file
        /// </param>
        /// <param name="size">
        /// Size of the file
        /// </param>
        /// <param name="content">
        /// Content of the file in string format
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAttachmentResponse(
            string? name,
            string? mimeType,
            string? size,
            string? content)
        {
            this.Name = name;
            this.MimeType = mimeType;
            this.Size = size;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAttachmentResponse" /> class.
        /// </summary>
        public CreateAttachmentResponse()
        {
        }
    }
}