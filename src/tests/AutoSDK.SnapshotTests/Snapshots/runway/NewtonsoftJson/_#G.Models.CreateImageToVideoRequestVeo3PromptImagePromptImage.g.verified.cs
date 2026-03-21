//HintName: G.Models.CreateImageToVideoRequestVeo3PromptImagePromptImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestVeo3PromptImagePromptImage
    {
        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        /// <example>https://example.com/image.jpg</example>
        [global::Newtonsoft.Json.JsonProperty("uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// The position of the image in the output video. "first" will use the image as the first frame of the video.
        /// </summary>
        /// <default>"first"</default>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public string Position { get; set; } = "first";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestVeo3PromptImagePromptImage" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="position">
        /// The position of the image in the output video. "first" will use the image as the first frame of the video.
        /// </param>
        public CreateImageToVideoRequestVeo3PromptImagePromptImage(
            string uri,
            string position = "first")
        {
            this.Uri = uri;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestVeo3PromptImagePromptImage" /> class.
        /// </summary>
        public CreateImageToVideoRequestVeo3PromptImagePromptImage()
        {
        }
    }
}