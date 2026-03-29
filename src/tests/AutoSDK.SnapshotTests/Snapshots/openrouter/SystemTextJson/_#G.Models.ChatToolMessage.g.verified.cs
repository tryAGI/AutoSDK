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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatToolMessageRoleJsonConverter))]
        public global::G.ChatToolMessageRole Role { get; set; }

        /// <summary>
        /// Tool response content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatToolMessageContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatToolMessageContent Content { get; set; }

        /// <summary>
        /// ID of the assistant message tool call this message responds to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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