//HintName: G.Models.RequestGen4ImageTurboReferenceImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestGen4ImageTurboReferenceImage
    {
        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        /// <example>https://example.com/image.jpg</example>
        [global::Newtonsoft.Json.JsonProperty("uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// A tag to identify the reference image. This is used to reference the image in prompt text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestGen4ImageTurboReferenceImage" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="tag">
        /// A tag to identify the reference image. This is used to reference the image in prompt text.
        /// </param>
        public RequestGen4ImageTurboReferenceImage(
            string uri,
            string? tag)
        {
            this.Uri = uri;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestGen4ImageTurboReferenceImage" /> class.
        /// </summary>
        public RequestGen4ImageTurboReferenceImage()
        {
        }
    }
}