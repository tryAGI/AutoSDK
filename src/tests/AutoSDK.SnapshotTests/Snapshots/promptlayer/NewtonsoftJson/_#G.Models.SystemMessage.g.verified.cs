//HintName: G.Models.SystemMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemMessage
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
        public global::G.SystemMessageTemplateFormat? TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ContentItem2> Content { get; set; } = default!;

        /// <summary>
        /// Default Value: system
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

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
        /// Initializes a new instance of the <see cref="SystemMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="inputVariables">
        /// Default Value: []
        /// </param>
        /// <param name="templateFormat">
        /// Default Value: f-string
        /// </param>
        /// <param name="role">
        /// Default Value: system
        /// </param>
        /// <param name="name"></param>
        public SystemMessage(
            global::System.Collections.Generic.IList<global::G.ContentItem2> content,
            global::System.Collections.Generic.IList<string>? inputVariables,
            global::G.SystemMessageTemplateFormat? templateFormat,
            string? role,
            string? name)
        {
            this.InputVariables = inputVariables;
            this.TemplateFormat = templateFormat;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMessage" /> class.
        /// </summary>
        public SystemMessage()
        {
        }
    }
}