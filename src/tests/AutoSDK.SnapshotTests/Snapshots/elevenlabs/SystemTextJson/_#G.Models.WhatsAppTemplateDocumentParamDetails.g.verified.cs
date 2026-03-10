//HintName: G.Models.WhatsAppTemplateDocumentParamDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateDocumentParamDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Link { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateDocumentParamDetails" /> class.
        /// </summary>
        /// <param name="link"></param>
        /// <param name="filename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppTemplateDocumentParamDetails(
            string link,
            string? filename)
        {
            this.Link = link ?? throw new global::System.ArgumentNullException(nameof(link));
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateDocumentParamDetails" /> class.
        /// </summary>
        public WhatsAppTemplateDocumentParamDetails()
        {
        }
    }
}