//HintName: G.Models.WhatsAppTemplateTextParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateTextParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameter_name")]
        public string? ParameterName { get; set; }

        /// <summary>
        /// Default Value: text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateTextParam" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="parameterName"></param>
        /// <param name="type">
        /// Default Value: text
        /// </param>
        public WhatsAppTemplateTextParam(
            string text,
            string? parameterName,
            string? type)
        {
            this.ParameterName = parameterName;
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateTextParam" /> class.
        /// </summary>
        public WhatsAppTemplateTextParam()
        {
        }
    }
}