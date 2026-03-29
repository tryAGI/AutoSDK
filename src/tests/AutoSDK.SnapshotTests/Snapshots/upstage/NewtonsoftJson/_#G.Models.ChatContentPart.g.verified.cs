//HintName: G.Models.ChatContentPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentPart
    {
        /// <summary>
        /// The type of content part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatContentPartType Type { get; set; } = default!;

        /// <summary>
        /// The text content (for text type).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The image URL (for image_url type).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public global::G.ChatContentPartImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentPart" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of content part.
        /// </param>
        /// <param name="text">
        /// The text content (for text type).
        /// </param>
        /// <param name="imageUrl">
        /// The image URL (for image_url type).
        /// </param>
        public ChatContentPart(
            global::G.ChatContentPartType type,
            string? text,
            global::G.ChatContentPartImageUrl? imageUrl)
        {
            this.Type = type;
            this.Text = text;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentPart" /> class.
        /// </summary>
        public ChatContentPart()
        {
        }
    }
}