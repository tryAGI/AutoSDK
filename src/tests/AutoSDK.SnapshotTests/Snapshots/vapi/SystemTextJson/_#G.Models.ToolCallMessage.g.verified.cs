//HintName: G.Models.ToolCallMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallMessage
    {
        /// <summary>
        /// The role of the tool call in the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// The list of tool calls made during the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCalls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> ToolCalls { get; set; }

        /// <summary>
        /// The message content for the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The timestamp when the message was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// The number of seconds from the start of the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondsFromStart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SecondsFromStart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the tool call in the conversation.
        /// </param>
        /// <param name="toolCalls">
        /// The list of tool calls made during the conversation.
        /// </param>
        /// <param name="message">
        /// The message content for the tool call.
        /// </param>
        /// <param name="time">
        /// The timestamp when the message was sent.
        /// </param>
        /// <param name="secondsFromStart">
        /// The number of seconds from the start of the conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallMessage(
            string role,
            global::System.Collections.Generic.IList<object> toolCalls,
            string message,
            double time,
            double secondsFromStart)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.ToolCalls = toolCalls ?? throw new global::System.ArgumentNullException(nameof(toolCalls));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Time = time;
            this.SecondsFromStart = secondsFromStart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallMessage" /> class.
        /// </summary>
        public ToolCallMessage()
        {
        }
    }
}