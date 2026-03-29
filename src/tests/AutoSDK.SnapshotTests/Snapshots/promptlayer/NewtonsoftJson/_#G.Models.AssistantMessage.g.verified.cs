//HintName: G.Models.AssistantMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessage
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_variables")]
        public global::System.Collections.Generic.IList<string>? InputVariables { get; set; }

        /// <summary>
        /// Default Value: f-string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_format")]
        public global::G.AssistantMessageTemplateFormat? TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::System.Collections.Generic.IList<global::G.ContentVariant1Item>? Content { get; set; }

        /// <summary>
        /// Default Value: assistant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// This field is deprecated. Please use `tool_calls` field to specify tool calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_call")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.FunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessage" /> class.
        /// </summary>
        /// <param name="inputVariables">
        /// Default Value: []
        /// </param>
        /// <param name="templateFormat">
        /// Default Value: f-string
        /// </param>
        /// <param name="content"></param>
        /// <param name="role">
        /// Default Value: assistant
        /// </param>
        /// <param name="name"></param>
        /// <param name="toolCalls"></param>
        public AssistantMessage(
            global::System.Collections.Generic.IList<string>? inputVariables,
            global::G.AssistantMessageTemplateFormat? templateFormat,
            global::System.Collections.Generic.IList<global::G.ContentVariant1Item>? content,
            string? role,
            string? name,
            global::System.Collections.Generic.IList<global::G.ToolCall>? toolCalls)
        {
            this.InputVariables = inputVariables;
            this.TemplateFormat = templateFormat;
            this.Content = content;
            this.Role = role;
            this.Name = name;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessage" /> class.
        /// </summary>
        public AssistantMessage()
        {
        }
    }
}