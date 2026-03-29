//HintName: G.Models.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A result choice.
    /// </summary>
    public sealed partial class ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessage
    {
        /// <summary>
        /// The role of the sender (user or assistant).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The reasoning content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// The tool call function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessageToolCallsItems>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the sender (user or assistant).
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        /// <param name="reasoning">
        /// The reasoning content of the message.
        /// </param>
        /// <param name="toolCalls">
        /// The tool call function.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessage(
            string? role,
            string? content,
            string? reasoning,
            global::System.Collections.Generic.IList<global::G.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessageToolCallsItems>? toolCalls)
        {
            this.Role = role;
            this.Content = content;
            this.Reasoning = reasoning;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessage" /> class.
        /// </summary>
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessage()
        {
        }
    }
}