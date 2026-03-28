//HintName: G.Models.WhatsAppTemplateHeaderComponentParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateHeaderComponentParams
    {
        /// <summary>
        /// Default Value: header
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ParametersItem> Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateHeaderComponentParams" /> class.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="type">
        /// Default Value: header
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppTemplateHeaderComponentParams(
            global::System.Collections.Generic.IList<global::G.ParametersItem> parameters,
            string? type)
        {
            this.Type = type;
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateHeaderComponentParams" /> class.
        /// </summary>
        public WhatsAppTemplateHeaderComponentParams()
        {
        }
    }
}