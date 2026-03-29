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
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// The list of tool calls made during the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolCalls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> ToolCalls { get; set; } = default!;

        /// <summary>
        /// The message content for the tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The timestamp when the message was sent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public double Time { get; set; } = default!;

        /// <summary>
        /// The number of seconds from the start of the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secondsFromStart", Required = global::Newtonsoft.Json.Required.Always)]
        public double SecondsFromStart { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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