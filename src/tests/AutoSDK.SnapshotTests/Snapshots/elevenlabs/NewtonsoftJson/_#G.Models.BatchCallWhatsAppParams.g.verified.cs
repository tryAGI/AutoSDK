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
        [global::Newtonsoft.Json.JsonProperty("whatsapp_phone_number_id")]
        public string? WhatsappPhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("whatsapp_call_permission_request_template_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string WhatsappCallPermissionRequestTemplateName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("whatsapp_call_permission_request_template_language_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string WhatsappCallPermissionRequestTemplateLanguageCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallWhatsAppParams" /> class.
        /// </summary>
        /// <param name="whatsappPhoneNumberId"></param>
        /// <param name="whatsappCallPermissionRequestTemplateName"></param>
        /// <param name="whatsappCallPermissionRequestTemplateLanguageCode"></param>
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