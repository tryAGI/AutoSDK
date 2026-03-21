//HintName: G.Models.CreateImageToVideoRequestVeo31PromptImagePromptImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestVeo31PromptImagePromptImage
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
        /// The position of the image in the output video. "first" will use the image as the first frame of the video, "last" will use the image as the last frame of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateImageToVideoRequestVeo31PromptImagePromptImagePosition Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestVeo31PromptImagePromptImage" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="position">
        /// The position of the image in the output video. "first" will use the image as the first frame of the video, "last" will use the image as the last frame of the video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestVeo31PromptImagePromptImage(
            string uri,
            global::G.CreateImageToVideoRequestVeo31PromptImagePromptImagePosition position)
        {
            this.Uri = uri;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestVeo31PromptImagePromptImage" /> class.
        /// </summary>
        public CreateImageToVideoRequestVeo31PromptImagePromptImage()
        {
        }
    }
}