//HintName: G.Models.TwilioSMSChatTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TwilioSMSChatTransport
    {
        /// <summary>
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: chat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversationType")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TwilioSMSChatTransportConversationTypeJsonConverter))]
        public global::G.TwilioSMSChatTransportConversationType? ConversationType { get; set; }

        /// <summary>
        /// This is the phone number that will be used to send the SMS.<br/>
        /// If provided, will create a new session. If not provided, uses existing session's phoneNumberId.<br/>
        /// The phone number must have SMS enabled and belong to your organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumberId")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// This is the customer who will receive the SMS.<br/>
        /// If provided, will create a new session. If not provided, uses existing session's customer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer")]
        public global::G.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// This is the customerId of the customer who will receive the SMS.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customerId")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// Whether to use LLM-generated messages for outbound SMS.<br/>
        /// When true (default), input is processed by the assistant for a response.<br/>
        /// When false, the input text is forwarded directly as the SMS message without LLM processing.<br/>
        /// Useful for sending pre-defined messages or notifications.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("useLLMGeneratedMessageForOutbound")]
        public bool? UseLLMGeneratedMessageForOutbound { get; set; }

        /// <summary>
        /// The type of transport to use for sending the chat response.<br/>
        /// Currently supports 'twilio.sms' for SMS delivery via Twilio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TwilioSMSChatTransportTypeJsonConverter))]
        public global::G.TwilioSMSChatTransportType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioSMSChatTransport" /> class.
        /// </summary>
        /// <param name="conversationType">
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: chat
        /// </param>
        /// <param name="phoneNumberId">
        /// This is the phone number that will be used to send the SMS.<br/>
        /// If provided, will create a new session. If not provided, uses existing session's phoneNumberId.<br/>
        /// The phone number must have SMS enabled and belong to your organization.
        /// </param>
        /// <param name="customer">
        /// This is the customer who will receive the SMS.<br/>
        /// If provided, will create a new session. If not provided, uses existing session's customer.
        /// </param>
        /// <param name="customerId">
        /// This is the customerId of the customer who will receive the SMS.
        /// </param>
        /// <param name="useLLMGeneratedMessageForOutbound">
        /// Whether to use LLM-generated messages for outbound SMS.<br/>
        /// When true (default), input is processed by the assistant for a response.<br/>
        /// When false, the input text is forwarded directly as the SMS message without LLM processing.<br/>
        /// Useful for sending pre-defined messages or notifications.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="type">
        /// The type of transport to use for sending the chat response.<br/>
        /// Currently supports 'twilio.sms' for SMS delivery via Twilio.
        /// </param>
        public TwilioSMSChatTransport(
            global::G.TwilioSMSChatTransportConversationType? conversationType,
            string? phoneNumberId,
            global::G.CreateCustomerDTO? customer,
            string? customerId,
            bool? useLLMGeneratedMessageForOutbound,
            global::G.TwilioSMSChatTransportType type)
        {
            this.ConversationType = conversationType;
            this.PhoneNumberId = phoneNumberId;
            this.Customer = customer;
            this.CustomerId = customerId;
            this.UseLLMGeneratedMessageForOutbound = useLLMGeneratedMessageForOutbound;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioSMSChatTransport" /> class.
        /// </summary>
        public TwilioSMSChatTransport()
        {
        }
    }
}