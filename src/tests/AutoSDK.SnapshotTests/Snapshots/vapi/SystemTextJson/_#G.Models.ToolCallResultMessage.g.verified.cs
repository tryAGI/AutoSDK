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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// The ID of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCallId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// The name of the tool that returned the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The result of the tool call in JSON format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

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
        /// The metadata for the tool call result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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