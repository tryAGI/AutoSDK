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
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_variables")]
        public global::System.Collections.Generic.IList<string>? InputVariables { get; set; }

        /// <summary>
        /// Default Value: f-string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolMessageTemplateFormatJsonConverter))]
        public global::G.ToolMessageTemplateFormat? TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ContentItem5> Content { get; set; } = default!;

        /// <summary>
        /// Default Value: tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toolCallId"></param>
        /// <param name="inputVariables">
        /// Default Value: []
        /// </param>
        /// <param name="templateFormat">
        /// Default Value: f-string
        /// </param>
        /// <param name="role">
        /// Default Value: tool
        /// </param>
        /// <param name="name"></param>
        public ToolMessage(
            global::System.Collections.Generic.IList<global::G.ContentItem5> content,
            string toolCallId,
            global::System.Collections.Generic.IList<string>? inputVariables,
            global::G.ToolMessageTemplateFormat? templateFormat,
            string? role,
            string? name)
        {
            this.InputVariables = inputVariables;
            this.TemplateFormat = templateFormat;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessage" /> class.
        /// </summary>
        public ToolMessage()
        {
        }
    }
}