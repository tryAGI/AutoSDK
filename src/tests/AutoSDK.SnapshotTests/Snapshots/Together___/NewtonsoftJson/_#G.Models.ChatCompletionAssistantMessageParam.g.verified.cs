//HintName: G.Models.ChatCompletionAssistantMessageParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionAssistantMessageParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_call")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ChatCompletionAssistantMessageParamFunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatCompletionAssistantMessageParamRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolChoice2>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAssistantMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <param name="toolCalls"></param>
        public ChatCompletionAssistantMessageParam(
            string? content,
            string? name,
            global::G.ChatCompletionAssistantMessageParamRole role,
            global::System.Collections.Generic.IList<global::G.ToolChoice2>? toolCalls)
        {
            this.Content = content;
            this.Name = name;
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAssistantMessageParam" /> class.
        /// </summary>
        public ChatCompletionAssistantMessageParam()
        {
        }
    }
}