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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// References the ID of the ToolCallContent that initiated this tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// The content returned by the tool execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Indicates whether the tool execution resulted in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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