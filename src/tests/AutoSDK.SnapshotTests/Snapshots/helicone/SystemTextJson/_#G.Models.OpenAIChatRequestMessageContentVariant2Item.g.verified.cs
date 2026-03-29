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
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::G.OpenAIChatRequestMessageContentVariant2ItemImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestMessageContentVariant2Item" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="imageUrl"></param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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