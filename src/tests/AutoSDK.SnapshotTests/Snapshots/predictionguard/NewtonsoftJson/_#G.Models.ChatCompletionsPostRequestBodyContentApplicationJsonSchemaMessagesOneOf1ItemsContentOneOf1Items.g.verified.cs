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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The text to provide.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1ItemsImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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