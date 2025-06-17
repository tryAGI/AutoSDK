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
        [global::Newtonsoft.Json.JsonProperty("call_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallName { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("scheduled_time_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int? ScheduledTimeUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recipients", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OutboundCallRecipient> Recipients { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost" /> class.
        /// </summary>
        /// <param name="callName"></param>
        /// <param name="agentId"></param>
        /// <param name="agentPhoneNumberId"></param>
        /// <param name="scheduledTimeUnix"></param>
        /// <param name="recipients"></param>
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