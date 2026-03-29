//HintName: G.Models.OpenAIChatRequestMessageContentVariant2Item.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIChatRequestMessageContentVariant2Item
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public global::G.OpenAIChatRequestMessageContentVariant2ItemImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestMessageContentVariant2Item" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="imageUrl"></param>
        /// <param name="text"></param>
        public OpenAIChatRequestMessageContentVariant2Item(
            string type,
            global::G.OpenAIChatRequestMessageContentVariant2ItemImageUrl? imageUrl,
            string? text)
        {
            this.ImageUrl = imageUrl;
            this.Text = text;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestMessageContentVariant2Item" /> class.
        /// </summary>
        public OpenAIChatRequestMessageContentVariant2Item()
        {
        }
    }
}