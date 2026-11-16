//HintName: G.Models.ImageUrlInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model for image input validation.
    /// </summary>
    public sealed partial class ImageUrlInput
    {
        /// <summary>
        /// Input type identifier<br/>
        /// Default Value: image_url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The image input specification.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImageUrlInput2 ImageUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUrlInput" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// The image input specification.
        /// </param>
        /// <param name="type">
        /// Input type identifier<br/>
        /// Default Value: image_url
        /// </param>
        public ImageUrlInput(
            global::G.ImageUrlInput2 imageUrl,
            string? type)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUrlInput" /> class.
        /// </summary>
        public ImageUrlInput()
        {
        }

    }
}