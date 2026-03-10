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
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WhatsappPhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WhatsappUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_language_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateLanguageCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TemplateParamsItem> TemplateParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_client_data")]
        public global::G.ConversationInitiationClientDataRequestInput? ConversationInitiationClientData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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