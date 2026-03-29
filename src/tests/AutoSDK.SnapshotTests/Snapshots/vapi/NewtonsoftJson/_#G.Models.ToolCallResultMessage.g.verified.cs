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
        /// The role of the tool call result in the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// The ID of the tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolCallId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// The name of the tool that returned the result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The result of the tool call in JSON format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public string Result { get; set; } = default!;

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
        /// The metadata for the tool call result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResultMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the tool call result in the conversation.
        /// </param>
        /// <param name="toolCallId">
        /// The ID of the tool call.
        /// </param>
        /// <param name="name">
        /// The name of the tool that returned the result.
        /// </param>
        /// <param name="result">
        /// The result of the tool call in JSON format.
        /// </param>
        /// <param name="time">
        /// The timestamp when the message was sent.
        /// </param>
        /// <param name="secondsFromStart">
        /// The number of seconds from the start of the conversation.
        /// </param>
        /// <param name="metadata">
        /// The metadata for the tool call result.
        /// </param>
        public ToolCallResultMessage(
            string role,
            string toolCallId,
            string name,
            string result,
            double time,
            double secondsFromStart,
            object? metadata)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Time = time;
            this.SecondsFromStart = secondsFromStart;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResultMessage" /> class.
        /// </summary>
        public ToolCallResultMessage()
        {
        }
    }
}