//HintName: G.Models.ChatCompletionMessageParamAssistant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageParamAssistant
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionMessageParamAssistantRoleJsonConverter))]
        public global::G.ChatCompletionMessageParamAssistantRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartText>, object>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_call")]
        public global::G.ChatCompletionMessageParamAssistantFunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageReasoning>? Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageParamAssistant" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="functionCall"></param>
        /// <param name="name"></param>
        /// <param name="toolCalls"></param>
        /// <param name="reasoning"></param>
        public ChatCompletionMessageParamAssistant(
            global::G.ChatCompletionMessageParamAssistantRole role,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartText>, object>? content,
            global::G.ChatCompletionMessageParamAssistantFunctionCall? functionCall,
            string? name,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessageToolCall>? toolCalls,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessageReasoning>? reasoning)
        {
            this.Role = role;
            this.Content = content;
            this.FunctionCall = functionCall;
            this.Name = name;
            this.ToolCalls = toolCalls;
            this.Reasoning = reasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageParamAssistant" /> class.
        /// </summary>
        public ChatCompletionMessageParamAssistant()
        {
        }
    }
}