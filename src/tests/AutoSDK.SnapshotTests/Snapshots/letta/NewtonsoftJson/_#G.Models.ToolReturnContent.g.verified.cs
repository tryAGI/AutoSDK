//HintName: G.Models.ToolReturnContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolReturnContent
    {
        /// <summary>
        /// Indicates this content represents a tool return event.<br/>
        /// Default Value: tool_return
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// References the ID of the ToolCallContent that initiated this tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// The content returned by the tool execution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Indicates whether the tool execution resulted in an error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsError { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReturnContent" /> class.
        /// </summary>
        /// <param name="toolCallId">
        /// References the ID of the ToolCallContent that initiated this tool call.
        /// </param>
        /// <param name="content">
        /// The content returned by the tool execution.
        /// </param>
        /// <param name="isError">
        /// Indicates whether the tool execution resulted in an error.
        /// </param>
        /// <param name="type">
        /// Indicates this content represents a tool return event.<br/>
        /// Default Value: tool_return
        /// </param>
        public ToolReturnContent(
            string toolCallId,
            string content,
            bool isError,
            string? type)
        {
            this.Type = type;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.IsError = isError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReturnContent" /> class.
        /// </summary>
        public ToolReturnContent()
        {
        }
    }
}