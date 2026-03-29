//HintName: G.Models.BashCodeExecutionToolResultContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result from bash code execution tool.
    /// </summary>
    public sealed partial class BashCodeExecutionToolResultContent
    {
        /// <summary>
        /// Default Value: bash_code_execution_tool_result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BashCodeExecutionToolResultContentTypeJsonConverter))]
        public global::G.BashCodeExecutionToolResultContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolUseId { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public object? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BashCodeExecutionToolResultContent" /> class.
        /// </summary>
        /// <param name="toolUseId"></param>
        /// <param name="type">
        /// Default Value: bash_code_execution_tool_result
        /// </param>
        /// <param name="content">
        /// Default Value: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BashCodeExecutionToolResultContent(
            string toolUseId,
            global::G.BashCodeExecutionToolResultContentType? type,
            object? content)
        {
            this.Type = type;
            this.ToolUseId = toolUseId ?? throw new global::System.ArgumentNullException(nameof(toolUseId));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BashCodeExecutionToolResultContent" /> class.
        /// </summary>
        public BashCodeExecutionToolResultContent()
        {
        }
    }
}