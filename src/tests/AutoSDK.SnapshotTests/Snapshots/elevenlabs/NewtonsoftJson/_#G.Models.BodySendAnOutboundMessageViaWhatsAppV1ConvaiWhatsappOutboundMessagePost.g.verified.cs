//HintName: G.Models.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost
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
        [global::Newtonsoft.Json.JsonProperty("template_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TemplateName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_language_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string TemplateLanguageCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_params", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TemplateParamsItem> TemplateParams { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost" /> class.
        /// </summary>
        /// <param name="whatsappPhoneNumberId"></param>
        /// <param name="whatsappUserId"></param>
        /// <param name="templateName"></param>
        /// <param name="templateLanguageCode"></param>
        /// <param name="templateParams"></param>
        /// <param name="agentId"></param>
        /// <param name="conversationInitiationClientData"></param>
        public BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost(
            string whatsappPhoneNumberId,
            string whatsappUserId,
            string templateName,
            string templateLanguageCode,
            global::System.Collections.Generic.IList<global::G.TemplateParamsItem> templateParams,
            string agentId,
            global::G.ConversationInitiationClientDataRequestInput? conversationInitiationClientData)
        {
            this.WhatsappPhoneNumberId = whatsappPhoneNumberId ?? throw new global::System.ArgumentNullException(nameof(whatsappPhoneNumberId));
            this.WhatsappUserId = whatsappUserId ?? throw new global::System.ArgumentNullException(nameof(whatsappUserId));
            this.TemplateName = templateName ?? throw new global::System.ArgumentNullException(nameof(templateName));
            this.TemplateLanguageCode = templateLanguageCode ?? throw new global::System.ArgumentNullException(nameof(templateLanguageCode));
            this.TemplateParams = templateParams ?? throw new global::System.ArgumentNullException(nameof(templateParams));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConversationInitiationClientData = conversationInitiationClientData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost" /> class.
        /// </summary>
        public BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePost()
        {
        }
    }
}