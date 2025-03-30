//HintName: G.Models.BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_phone_number_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentPhoneNumberId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToNumber { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentPhoneNumberId"></param>
        /// <param name="toNumber"></param>
        /// <param name="conversationInitiationClientData"></param>
        public BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost(
            string agentId,
            string agentPhoneNumberId,
            string toNumber,
            global::G.ConversationInitiationClientDataRequestInput? conversationInitiationClientData)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentPhoneNumberId = agentPhoneNumberId ?? throw new global::System.ArgumentNullException(nameof(agentPhoneNumberId));
            this.ToNumber = toNumber ?? throw new global::System.ArgumentNullException(nameof(toNumber));
            this.ConversationInitiationClientData = conversationInitiationClientData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost" /> class.
        /// </summary>
        public BodyHandleAnOutboundCallViaTwilioV1ConvaiTwilioOutboundCallPost()
        {
        }
    }
}