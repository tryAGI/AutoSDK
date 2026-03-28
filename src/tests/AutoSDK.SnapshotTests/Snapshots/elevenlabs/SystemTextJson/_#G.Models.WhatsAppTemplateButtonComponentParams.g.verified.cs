//HintName: G.Models.WhatsAppTemplateButtonComponentParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateButtonComponentParams
    {
        /// <summary>
        /// Default Value: button
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateButtonComponentParams" /> class.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="index"></param>
        /// <param name="subType"></param>
        /// <param name="type">
        /// Default Value: button
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppTemplateButtonComponentParams(
            global::System.Collections.Generic.IList<global::G.WhatsAppTemplateTextParam> parameters,
            int index,
            string subType,
            string? type)
        {
            this.Type = type;
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Index = index;
            this.SubType = subType ?? throw new global::System.ArgumentNullException(nameof(subType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateButtonComponentParams" /> class.
        /// </summary>
        public WhatsAppTemplateButtonComponentParams()
        {
        }
    }
}