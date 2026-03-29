//HintName: G.Models.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The incremental message delta (streaming only).
    /// </summary>
    public sealed partial class ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsDelta
    {
        /// <summary>
        /// The role of the sender (user or assistant).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsDelta" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the sender (user or assistant).
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsDelta(
            string? role,
            string? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsDelta" /> class.
        /// </summary>
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsDelta()
        {
        }
    }
}