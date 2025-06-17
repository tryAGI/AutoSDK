//HintName: G.Models.BodyHandleAnOutboundCallViaSIPTrunkV1ConvaiSipTrunkOutboundCallPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyHandleAnOutboundCallViaSIPTrunkV1ConvaiSipTrunkOutboundCallPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentPhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToNumber { get; set; }

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
        /// Initializes a new instance of the <see cref="BodyHandleAnOutboundCallViaSIPTrunkV1ConvaiSipTrunkOutboundCallPost" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentPhoneNumberId"></param>
        /// <param name="toNumber"></param>
        /// <param name="conversationInitiationClientData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyHandleAnOutboundCallViaSIPTrunkV1ConvaiSipTrunkOutboundCallPost(
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
        /// Initializes a new instance of the <see cref="BodyHandleAnOutboundCallViaSIPTrunkV1ConvaiSipTrunkOutboundCallPost" /> class.
        /// </summary>
        public BodyHandleAnOutboundCallViaSIPTrunkV1ConvaiSipTrunkOutboundCallPost()
        {
        }
    }
}