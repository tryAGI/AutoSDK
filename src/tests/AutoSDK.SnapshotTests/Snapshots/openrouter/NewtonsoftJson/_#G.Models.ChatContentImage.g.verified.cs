//HintName: G.Models.ChatContentImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Image content part for vision models
    /// </summary>
    public sealed partial class ChatContentImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatContentImageType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatContentImageImageUrl ImageUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentImage" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
        public ChatContentImage(
            global::G.ChatContentImageImageUrl imageUrl,
            global::G.ChatContentImageType type)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentImage" /> class.
        /// </summary>
        public ChatContentImage()
        {
        }
    }
}