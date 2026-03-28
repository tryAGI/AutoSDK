//HintName: G.Models.WhatsAppTemplateImageParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateImageParam
    {
        /// <summary>
        /// Default Value: image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WhatsAppTemplateImageParamDetails Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateImageParam" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="type">
        /// Default Value: image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppTemplateImageParam(
            global::G.WhatsAppTemplateImageParamDetails image,
            string? type)
        {
            this.Type = type;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateImageParam" /> class.
        /// </summary>
        public WhatsAppTemplateImageParam()
        {
        }
    }
}