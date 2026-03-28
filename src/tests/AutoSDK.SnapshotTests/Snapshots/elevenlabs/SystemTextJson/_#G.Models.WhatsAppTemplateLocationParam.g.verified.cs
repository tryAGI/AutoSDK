//HintName: G.Models.WhatsAppTemplateLocationParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateLocationParam
    {
        /// <summary>
        /// Default Value: location
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WhatsAppTemplateLocationParamDetails Location { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateLocationParam" /> class.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="type">
        /// Default Value: location
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppTemplateLocationParam(
            global::G.WhatsAppTemplateLocationParamDetails location,
            string? type)
        {
            this.Type = type;
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateLocationParam" /> class.
        /// </summary>
        public WhatsAppTemplateLocationParam()
        {
        }
    }
}