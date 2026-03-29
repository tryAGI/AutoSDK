//HintName: G.Models.PiiRedactionConfigDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PiiRedactionConfigDTO
    {
        /// <summary>
        /// The entity types to redact<br/>
        /// Example: [GDPR, HEALTH_INFORMATION, HIPAA_SAFE_HARBOR, QUEBEC_PRIVACY_ACT, EMAIL_ADDRESS, NAME, PHONE_NUMBER]
        /// </summary>
        /// <example>[GDPR, HEALTH_INFORMATION, HIPAA_SAFE_HARBOR, QUEBEC_PRIVACY_ACT, EMAIL_ADDRESS, NAME, PHONE_NUMBER]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_types")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PiiRedactionEntityTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PiiRedactionEntityTypeEnum EntityTypes { get; set; }

        /// <summary>
        /// The type of processed text to return (marker or mask)<br/>
        /// Example: MARKER
        /// </summary>
        /// <example>MARKER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_text_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PiiRedactionConfigDTOProcessedTextTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PiiRedactionConfigDTOProcessedTextType ProcessedTextType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiRedactionConfigDTO" /> class.
        /// </summary>
        /// <param name="entityTypes">
        /// The entity types to redact<br/>
        /// Example: [GDPR, HEALTH_INFORMATION, HIPAA_SAFE_HARBOR, QUEBEC_PRIVACY_ACT, EMAIL_ADDRESS, NAME, PHONE_NUMBER]
        /// </param>
        /// <param name="processedTextType">
        /// The type of processed text to return (marker or mask)<br/>
        /// Example: MARKER
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PiiRedactionConfigDTO(
            global::G.PiiRedactionEntityTypeEnum entityTypes,
            global::G.PiiRedactionConfigDTOProcessedTextType processedTextType)
        {
            this.EntityTypes = entityTypes;
            this.ProcessedTextType = processedTextType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiRedactionConfigDTO" /> class.
        /// </summary>
        public PiiRedactionConfigDTO()
        {
        }
    }
}