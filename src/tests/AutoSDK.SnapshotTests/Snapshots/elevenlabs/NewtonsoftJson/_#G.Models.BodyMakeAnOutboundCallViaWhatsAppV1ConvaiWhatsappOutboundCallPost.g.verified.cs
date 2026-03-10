//HintName: G.Models.BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("whatsapp_phone_number_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WhatsappPhoneNumberId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("whatsapp_user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WhatsappUserId { get; set; } = default!;

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_initiation_client_data")]
        public global::G.ConversationInitiationClientDataRequestInput? ConversationInitiationClientData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost" /> class.
        /// </summary>
        /// <param name="whatsappPhoneNumberId"></param>
        /// <param name="whatsappUserId"></param>
        /// <param name="whatsappCallPermissionRequestTemplateName"></param>
        /// <param name="whatsappCallPermissionRequestTemplateLanguageCode"></param>
        /// <param name="agentId"></param>
        /// <param name="conversationInitiationClientData"></param>
        public BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost(
            string whatsappPhoneNumberId,
            string whatsappUserId,
            string whatsappCallPermissionRequestTemplateName,
            string whatsappCallPermissionRequestTemplateLanguageCode,
            string agentId,
            global::G.ConversationInitiationClientDataRequestInput? conversationInitiationClientData)
        {
            this.WhatsappPhoneNumberId = whatsappPhoneNumberId ?? throw new global::System.ArgumentNullException(nameof(whatsappPhoneNumberId));
            this.WhatsappUserId = whatsappUserId ?? throw new global::System.ArgumentNullException(nameof(whatsappUserId));
            this.WhatsappCallPermissionRequestTemplateName = whatsappCallPermissionRequestTemplateName ?? throw new global::System.ArgumentNullException(nameof(whatsappCallPermissionRequestTemplateName));
            this.WhatsappCallPermissionRequestTemplateLanguageCode = whatsappCallPermissionRequestTemplateLanguageCode ?? throw new global::System.ArgumentNullException(nameof(whatsappCallPermissionRequestTemplateLanguageCode));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConversationInitiationClientData = conversationInitiationClientData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost" /> class.
        /// </summary>
        public BodyMakeAnOutboundCallViaWhatsAppV1ConvaiWhatsappOutboundCallPost()
        {
        }
    }
}