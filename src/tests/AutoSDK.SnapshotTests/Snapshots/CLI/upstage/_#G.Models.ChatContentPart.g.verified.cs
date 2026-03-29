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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatContentPartTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatContentPartType Type { get; set; }

        /// <summary>
        /// The text content (for text type).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The image URL (for image_url type).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::G.ChatContentPartImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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