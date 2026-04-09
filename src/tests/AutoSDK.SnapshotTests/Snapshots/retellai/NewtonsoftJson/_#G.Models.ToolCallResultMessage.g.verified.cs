//HintName: G.Models.ToolCallResultMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallResultMessage
    {
        /// <summary>
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </summary>
        /// <example>Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6</example>
        [global::Newtonsoft.Json.JsonProperty("message_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string MessageId { get; set; } = default!;

        /// <summary>
        /// This is the result of a tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolCallResultMessageRoleJsonConverter))]
        public global::G.ToolCallResultMessageRole Role { get; set; }

        /// <summary>
        /// Tool call id, globally unique.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// Result of the tool call, can be a string, a stringified json, etc.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Whether the tool call was successful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("successful")]
        public bool? Successful { get; set; }

        /// <summary>
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </summary>
        /// <example>1703302428855</example>
        [global::Newtonsoft.Json.JsonProperty("created_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public long CreatedTimestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResultMessage" /> class.
        /// </summary>
        /// <param name="messageId">
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </param>
        /// <param name="toolCallId">
        /// Tool call id, globally unique.
        /// </param>
        /// <param name="content">
        /// Result of the tool call, can be a string, a stringified json, etc.
        /// </param>
        /// <param name="createdTimestamp">
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </param>
        /// <param name="role">
        /// This is the result of a tool call.
        /// </param>
        /// <param name="successful">
        /// Whether the tool call was successful.
        /// </param>
        public ToolCallResultMessage(
            string messageId,
            string toolCallId,
            string content,
            long createdTimestamp,
            global::G.ToolCallResultMessageRole role,
            bool? successful)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.Role = role;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Successful = successful;
            this.CreatedTimestamp = createdTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResultMessage" /> class.
        /// </summary>
        public ToolCallResultMessage()
        {
        }
    }
}