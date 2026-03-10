//HintName: G.Models.WhatsAppTemplateDocumentParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateDocumentParam
    {
        /// <summary>
        /// Default Value: document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WhatsAppTemplateDocumentParamDetails Document { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateDocumentParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: document
        /// </param>
        /// <param name="document"></param>
        public WhatsAppTemplateDocumentParam(
            global::G.WhatsAppTemplateDocumentParamDetails document,
            string? type)
        {
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateDocumentParam" /> class.
        /// </summary>
        public WhatsAppTemplateDocumentParam()
        {
        }
    }
}