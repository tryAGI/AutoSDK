//HintName: G.Models.ToolCallInvocationMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallInvocationMessage
    {
        /// <summary>
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </summary>
        /// <example>Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6</example>
        [global::Newtonsoft.Json.JsonProperty("message_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string MessageId { get; set; } = default!;

        /// <summary>
        /// This is a tool call invocation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolCallInvocationMessageRoleJsonConverter))]
        public global::G.ToolCallInvocationMessageRole Role { get; set; }

        /// <summary>
        /// Tool call id, globally unique.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// Name of the function in this tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Arguments for this tool call, it's a stringified JSON object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments", Required = global::Newtonsoft.Json.Required.Always)]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// Optional thought signature from Google Gemini thinking models. This is used internally to maintain reasoning chain in multi-turn function calling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thought_signature")]
        public string? ThoughtSignature { get; set; }

        /// <summary>
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </summary>
        /// <example>1703302428855</example>
        [global::Newtonsoft.Json.JsonProperty("created_timestamp")]
        public long? CreatedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallInvocationMessage" /> class.
        /// </summary>
        /// <param name="messageId">
        /// Unique id of the message<br/>
        /// Example: Jabr9TXYYJHfvl6Syypi88rdAHYHmcq6
        /// </param>
        /// <param name="toolCallId">
        /// Tool call id, globally unique.
        /// </param>
        /// <param name="name">
        /// Name of the function in this tool call.
        /// </param>
        /// <param name="arguments">
        /// Arguments for this tool call, it's a stringified JSON object.
        /// </param>
        /// <param name="role">
        /// This is a tool call invocation.
        /// </param>
        /// <param name="thoughtSignature">
        /// Optional thought signature from Google Gemini thinking models. This is used internally to maintain reasoning chain in multi-turn function calling.
        /// </param>
        /// <param name="createdTimestamp">
        /// Create timestamp of the message<br/>
        /// Example: 1703302428855
        /// </param>
        public ToolCallInvocationMessage(
            string messageId,
            string toolCallId,
            string name,
            string arguments,
            global::G.ToolCallInvocationMessageRole role,
            string? thoughtSignature,
            long? createdTimestamp)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.Role = role;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.ThoughtSignature = thoughtSignature;
            this.CreatedTimestamp = createdTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallInvocationMessage" /> class.
        /// </summary>
        public ToolCallInvocationMessage()
        {
        }
    }
}