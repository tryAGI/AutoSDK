//HintName: G.Models.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items
    {
        /// <summary>
        /// The role of the sender (user or assistant).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContent Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the sender (user or assistant).
        /// </param>
        /// <param name="content"></param>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items(
            string role,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContent content)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items" /> class.
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items()
        {
        }
    }
}