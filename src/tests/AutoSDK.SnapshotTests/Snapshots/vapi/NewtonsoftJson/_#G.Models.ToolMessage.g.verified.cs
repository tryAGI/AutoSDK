//HintName: G.Models.ToolMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolMessage
    {
        /// <summary>
        /// This is the role of the message author<br/>
        /// Default Value: tool
        /// </summary>
        /// <default>global::G.ToolMessageRole.Tool</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolMessageRoleJsonConverter))]
        public global::G.ToolMessageRole Role { get; set; } = global::G.ToolMessageRole.Tool;

        /// <summary>
        /// This is the content of the tool message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// This is the ID of the tool call this message is responding to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// This is an optional name for the participant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is an optional metadata for the message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// This is the content of the tool message
        /// </param>
        /// <param name="toolCallId">
        /// This is the ID of the tool call this message is responding to
        /// </param>
        /// <param name="name">
        /// This is an optional name for the participant
        /// </param>
        /// <param name="metadata">
        /// This is an optional metadata for the message
        /// </param>
        /// <param name="role">
        /// This is the role of the message author<br/>
        /// Default Value: tool
        /// </param>
        public ToolMessage(
            string content,
            string toolCallId,
            string? name,
            object? metadata,
            global::G.ToolMessageRole role = global::G.ToolMessageRole.Tool)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Name = name;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessage" /> class.
        /// </summary>
        public ToolMessage()
        {
        }
    }
}