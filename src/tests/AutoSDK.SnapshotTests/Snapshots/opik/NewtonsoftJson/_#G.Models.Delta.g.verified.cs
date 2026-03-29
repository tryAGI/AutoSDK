//HintName: G.Models.Delta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Delta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_content")]
        public string? ReasoningContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_call")]
        public global::G.FunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Delta" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="reasoningContent"></param>
        /// <param name="toolCalls"></param>
        /// <param name="functionCall"></param>
        public Delta(
            string? role,
            string? content,
            string? reasoningContent,
            global::System.Collections.Generic.IList<global::G.ToolCall>? toolCalls,
            global::G.FunctionCall? functionCall)
        {
            this.Role = role;
            this.Content = content;
            this.ReasoningContent = reasoningContent;
            this.ToolCalls = toolCalls;
            this.FunctionCall = functionCall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Delta" /> class.
        /// </summary>
        public Delta()
        {
        }
    }
}