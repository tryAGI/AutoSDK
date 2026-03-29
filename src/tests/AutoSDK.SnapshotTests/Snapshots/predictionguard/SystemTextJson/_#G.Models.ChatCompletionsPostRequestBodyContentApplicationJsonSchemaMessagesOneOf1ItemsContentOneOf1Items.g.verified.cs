//HintName: G.Models.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1Items.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1Items
    {
        /// <summary>
        /// The type of content ('text', 'image_url').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The text to provide.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1ItemsImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1Items" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of content ('text', 'image_url').
        /// </param>
        /// <param name="text">
        /// The text to provide.
        /// </param>
        /// <param name="imageUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1Items(
            string? type,
            string? text,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1ItemsImageUrl? imageUrl)
        {
            this.Type = type;
            this.Text = text;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1Items" /> class.
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1Items()
        {
        }
    }
}