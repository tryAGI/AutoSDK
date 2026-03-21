//HintName: G.Models.CreateTextToImageRequestGen4ImageReferenceImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToImageRequestGen4ImageReferenceImage
    {
        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        /// <example>https://example.com/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// A tag to identify the reference image. This is used to reference the image in prompt text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGen4ImageReferenceImage" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="tag">
        /// A tag to identify the reference image. This is used to reference the image in prompt text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestGen4ImageReferenceImage(
            string uri,
            string? tag)
        {
            this.Uri = uri;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGen4ImageReferenceImage" /> class.
        /// </summary>
        public CreateTextToImageRequestGen4ImageReferenceImage()
        {
        }
    }
}