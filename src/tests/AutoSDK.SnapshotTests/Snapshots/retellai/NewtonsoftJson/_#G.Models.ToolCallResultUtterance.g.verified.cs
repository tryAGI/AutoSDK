//HintName: G.Models.ToolCallResultUtterance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallResultUtterance
    {
        /// <summary>
        /// This is the result of a tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolCallResultUtteranceRoleJsonConverter))]
        public global::G.ToolCallResultUtteranceRole Role { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResultUtterance" /> class.
        /// </summary>
        /// <param name="toolCallId">
        /// Tool call id, globally unique.
        /// </param>
        /// <param name="content">
        /// Result of the tool call, can be a string, a stringified json, etc.
        /// </param>
        /// <param name="role">
        /// This is the result of a tool call.
        /// </param>
        /// <param name="successful">
        /// Whether the tool call was successful.
        /// </param>
        public ToolCallResultUtterance(
            string toolCallId,
            string content,
            global::G.ToolCallResultUtteranceRole role,
            bool? successful)
        {
            this.Role = role;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Successful = successful;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResultUtterance" /> class.
        /// </summary>
        public ToolCallResultUtterance()
        {
        }
    }
}