//HintName: G.Models.UpdatePhoneNumberRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePhoneNumberRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inbound_trunk_config")]
        public global::G.InboundSIPTrunkConfigRequestModel? InboundTrunkConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outbound_trunk_config")]
        public global::G.OutboundSIPTrunkConfigRequestModel? OutboundTrunkConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("livekit_stack")]
        public global::G.LivekitStackType? LivekitStack { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="label"></param>
        /// <param name="inboundTrunkConfig"></param>
        /// <param name="outboundTrunkConfig"></param>
        /// <param name="livekitStack"></param>
        public UpdatePhoneNumberRequest(
            string? agentId,
            string? label,
            global::G.InboundSIPTrunkConfigRequestModel? inboundTrunkConfig,
            global::G.OutboundSIPTrunkConfigRequestModel? outboundTrunkConfig,
            global::G.LivekitStackType? livekitStack)
        {
            this.AgentId = agentId;
            this.Label = label;
            this.InboundTrunkConfig = inboundTrunkConfig;
            this.OutboundTrunkConfig = outboundTrunkConfig;
            this.LivekitStack = livekitStack;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberRequest" /> class.
        /// </summary>
        public UpdatePhoneNumberRequest()
        {
        }
    }
}