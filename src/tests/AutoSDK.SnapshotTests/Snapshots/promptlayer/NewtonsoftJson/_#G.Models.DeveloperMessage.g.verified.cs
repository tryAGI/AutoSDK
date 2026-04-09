//HintName: G.Models.DeveloperMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeveloperMessage
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DeveloperMessageTemplateFormatJsonConverter))]
        public global::G.DeveloperMessageTemplateFormat? TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ContentItem4> Content { get; set; } = default!;

        /// <summary>
        /// Default Value: developer
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
        /// Initializes a new instance of the <see cref="DeveloperMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="inputVariables">
        /// Default Value: []
        /// </param>
        /// <param name="templateFormat">
        /// Default Value: f-string
        /// </param>
        /// <param name="role">
        /// Default Value: developer
        /// </param>
        /// <param name="name"></param>
        public DeveloperMessage(
            global::System.Collections.Generic.IList<global::G.ContentItem4> content,
            global::System.Collections.Generic.IList<string>? inputVariables,
            global::G.DeveloperMessageTemplateFormat? templateFormat,
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
        /// Initializes a new instance of the <see cref="DeveloperMessage" /> class.
        /// </summary>
        public DeveloperMessage()
        {
        }
    }
}