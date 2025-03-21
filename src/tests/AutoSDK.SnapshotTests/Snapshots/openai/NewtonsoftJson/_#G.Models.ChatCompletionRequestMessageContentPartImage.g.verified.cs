//HintName: G.Models.ChatCompletionRequestMessageContentPartImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Learn about [image inputs](/docs/guides/vision).
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionRequestMessageContentPartImageImageUrl ImageUrl { get; set; } = default!;

        /// <summary>
        /// The type of the content part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatCompletionRequestMessageContentPartImageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartImage" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type">
        /// The type of the content part.
        /// </param>
        public ChatCompletionRequestMessageContentPartImage(
            global::G.ChatCompletionRequestMessageContentPartImageImageUrl imageUrl,
            global::G.ChatCompletionRequestMessageContentPartImageType type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartImage" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartImage()
        {
        }
    }
}