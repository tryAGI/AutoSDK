//HintName: G.Models.BatchCallWhatsAppParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchCallWhatsAppParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_phone_number_id")]
        public string? WhatsappPhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_call_permission_request_template_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WhatsappCallPermissionRequestTemplateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_call_permission_request_template_language_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WhatsappCallPermissionRequestTemplateLanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallWhatsAppParams" /> class.
        /// </summary>
        /// <param name="whatsappPhoneNumberId"></param>
        /// <param name="whatsappCallPermissionRequestTemplateName"></param>
        /// <param name="whatsappCallPermissionRequestTemplateLanguageCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchCallWhatsAppParams(
            string whatsappCallPermissionRequestTemplateName,
            string whatsappCallPermissionRequestTemplateLanguageCode,
            string? whatsappPhoneNumberId)
        {
            this.WhatsappCallPermissionRequestTemplateName = whatsappCallPermissionRequestTemplateName ?? throw new global::System.ArgumentNullException(nameof(whatsappCallPermissionRequestTemplateName));
            this.WhatsappCallPermissionRequestTemplateLanguageCode = whatsappCallPermissionRequestTemplateLanguageCode ?? throw new global::System.ArgumentNullException(nameof(whatsappCallPermissionRequestTemplateLanguageCode));
            this.WhatsappPhoneNumberId = whatsappPhoneNumberId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallWhatsAppParams" /> class.
        /// </summary>
        public BatchCallWhatsAppParams()
        {
        }
    }
}