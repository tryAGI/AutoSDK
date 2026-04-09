//HintName: G.Models.ChatToolMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tool response message
    /// </summary>
    public sealed partial class ChatToolMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatToolMessageRoleJsonConverter))]
        public global::G.ChatToolMessageRole Role { get; set; }

        /// <summary>
        /// Tool response content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatToolMessageContent Content { get; set; } = default!;

        /// <summary>
        /// ID of the assistant message tool call this message responds to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// Tool response content
        /// </param>
        /// <param name="toolCallId">
        /// ID of the assistant message tool call this message responds to
        /// </param>
        /// <param name="role"></param>
        public ChatToolMessage(
            global::G.ChatToolMessageContent content,
            string toolCallId,
            global::G.ChatToolMessageRole role)
        {
            this.Role = role;
            this.Content = content;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolMessage" /> class.
        /// </summary>
        public ChatToolMessage()
        {
        }
    }
}