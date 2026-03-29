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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BashCodeExecutionToolResultContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_use_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolUseId { get; set; } = default!;

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public object? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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