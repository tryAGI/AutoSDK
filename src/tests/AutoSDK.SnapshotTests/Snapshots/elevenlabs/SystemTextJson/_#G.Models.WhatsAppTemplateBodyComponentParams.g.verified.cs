//HintName: G.Models.WhatsAppTemplateBodyComponentParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateBodyComponentParams
    {
        /// <summary>
        /// Default Value: body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WhatsAppTemplateTextParam> Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateBodyComponentParams" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: body
        /// </param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppTemplateBodyComponentParams(
            global::System.Collections.Generic.IList<global::G.WhatsAppTemplateTextParam> parameters,
            string? type)
        {
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateBodyComponentParams" /> class.
        /// </summary>
        public WhatsAppTemplateBodyComponentParams()
        {
        }
    }
}