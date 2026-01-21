//HintName: G.Models.ImageReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The image object<br/>
    /// Example: {"type":"image","url":"https://example.com/image.jpg"}
    /// </summary>
    public sealed partial class ImageReference
    {
        /// <summary>
        /// Default Value: image
        /// </summary>
        /// <default>global::G.ImageReferenceType.Image</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ImageReferenceType Type { get; set; } = global::G.ImageReferenceType.Image;

        /// <summary>
        /// The URL of the image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReference" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: image
        /// </param>
        /// <param name="url">
        /// The URL of the image
        /// </param>
        public ImageReference(
            string url,
            global::G.ImageReferenceType type = global::G.ImageReferenceType.Image)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReference" /> class.
        /// </summary>
        public ImageReference()
        {
        }
    }
}