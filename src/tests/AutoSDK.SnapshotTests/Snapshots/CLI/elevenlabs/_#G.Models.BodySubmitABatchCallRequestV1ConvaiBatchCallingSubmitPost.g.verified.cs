//HintName: G.Models.BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallName { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_time_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? ScheduledTimeUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OutboundCallRecipient> Recipients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost" /> class.
        /// </summary>
        /// <param name="callName"></param>
        /// <param name="agentId"></param>
        /// <param name="agentPhoneNumberId"></param>
        /// <param name="scheduledTimeUnix"></param>
        /// <param name="recipients"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost(
            string callName,
            string agentId,
            string agentPhoneNumberId,
            int? scheduledTimeUnix,
            global::System.Collections.Generic.IList<global::G.OutboundCallRecipient> recipients)
        {
            this.CallName = callName ?? throw new global::System.ArgumentNullException(nameof(callName));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentPhoneNumberId = agentPhoneNumberId ?? throw new global::System.ArgumentNullException(nameof(agentPhoneNumberId));
            this.ScheduledTimeUnix = scheduledTimeUnix;
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost" /> class.
        /// </summary>
        public BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost()
        {
        }
    }
}