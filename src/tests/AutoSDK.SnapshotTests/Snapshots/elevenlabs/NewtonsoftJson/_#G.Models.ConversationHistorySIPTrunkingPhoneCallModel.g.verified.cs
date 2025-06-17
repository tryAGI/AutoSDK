//HintName: G.Models.ConversationHistorySIPTrunkingPhoneCallModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistorySIPTrunkingPhoneCallModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("direction", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversationHistorySIPTrunkingPhoneCallModelDirection Direction { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumberId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExternalNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ConversationHistorySIPTrunkingPhoneCallModelType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_sid", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallSid { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistorySIPTrunkingPhoneCallModel" /> class.
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="phoneNumberId"></param>
        /// <param name="agentNumber"></param>
        /// <param name="externalNumber"></param>
        /// <param name="type"></param>
        /// <param name="callSid"></param>
        public ConversationHistorySIPTrunkingPhoneCallModel(
            global::G.ConversationHistorySIPTrunkingPhoneCallModelDirection direction,
            string phoneNumberId,
            string agentNumber,
            string externalNumber,
            string callSid,
            global::G.ConversationHistorySIPTrunkingPhoneCallModelType type)
        {
            this.Direction = direction;
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.AgentNumber = agentNumber ?? throw new global::System.ArgumentNullException(nameof(agentNumber));
            this.ExternalNumber = externalNumber ?? throw new global::System.ArgumentNullException(nameof(externalNumber));
            this.CallSid = callSid ?? throw new global::System.ArgumentNullException(nameof(callSid));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistorySIPTrunkingPhoneCallModel" /> class.
        /// </summary>
        public ConversationHistorySIPTrunkingPhoneCallModel()
        {
        }
    }
}