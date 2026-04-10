//HintName: G.Models.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string FromNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToNumber { get; set; } = default!;

        /// <summary>
        /// Default Value: inbound
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("direction")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirectionJsonConverter))]
        public global::G.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection? Direction { get; set; }

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
        /// Initializes a new instance of the <see cref="BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="fromNumber"></param>
        /// <param name="toNumber"></param>
        /// <param name="direction">
        /// Default Value: inbound
        /// </param>
        /// <param name="conversationInitiationClientData"></param>
        public BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost(
            string agentId,
            string fromNumber,
            string toNumber,
            global::G.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection? direction,
            global::G.ConversationInitiationClientDataRequestInput? conversationInitiationClientData)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.FromNumber = fromNumber ?? throw new global::System.ArgumentNullException(nameof(fromNumber));
            this.ToNumber = toNumber ?? throw new global::System.ArgumentNullException(nameof(toNumber));
            this.Direction = direction;
            this.ConversationInitiationClientData = conversationInitiationClientData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost" /> class.
        /// </summary>
        public BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPost()
        {
        }
    }
}