//HintName: G.Models.ChatMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a single message in the chat history, excluding the current user turn. It has two properties: `role` and `message`. The `role` identifies the sender (`CHATBOT`, `SYSTEM`, or `USER`), while the `message` contains the text content.<br/>
    /// The chat_history parameter should not be used for `SYSTEM` messages in most cases. Instead, to add a `SYSTEM` role message at the beginning of a conversation, the `preamble` parameter should be used.
    /// </summary>
    public sealed partial class ChatMessage
    {
        /// <summary>
        /// Contents of the chat message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// One of `CHATBOT`, `SYSTEM`, `TOOL` or `USER` to identify who the message is coming from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        /// <param name="message">
        /// Contents of the chat message.
        /// </param>
        /// <param name="role">
        /// One of `CHATBOT`, `SYSTEM`, `TOOL` or `USER` to identify who the message is coming from.
        /// </param>
        /// <param name="toolCalls"></param>
        public ChatMessage(
            string message,
            global::G.ChatRole role,
            global::System.Collections.Generic.IList<global::G.ToolCall>? toolCalls)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        public ChatMessage()
        {
        }
    }
}