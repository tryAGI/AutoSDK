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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WhatsAppTemplateDocumentParamDetails Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateDocumentParam" /> class.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="type">
        /// Default Value: document
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppTemplateDocumentParam(
            global::G.WhatsAppTemplateDocumentParamDetails document,
            string? type)
        {
            this.Type = type;
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateDocumentParam" /> class.
        /// </summary>
        public WhatsAppTemplateDocumentParam()
        {
        }
    }
}