//HintName: G.Models.ChatCompletionRequestToolMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestToolMessage
    {
        /// <summary>
        /// The role of the messages author, in this case `tool`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestToolMessageRoleJsonConverter))]
        public global::G.ChatCompletionRequestToolMessageRole Role { get; set; }

        /// <summary>
        /// The contents of the tool message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Tool call that this message is responding to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestToolMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the tool message.
        /// </param>
        /// <param name="toolCallId">
        /// Tool call that this message is responding to.
        /// </param>
        /// <param name="role">
        /// The role of the messages author, in this case `tool`.
        /// </param>
        public ChatCompletionRequestToolMessage(
            string content,
            string toolCallId,
            global::G.ChatCompletionRequestToolMessageRole role)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestToolMessage" /> class.
        /// </summary>
        public ChatCompletionRequestToolMessage()
        {
        }
    }
}