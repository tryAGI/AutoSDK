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
        [global::Newtonsoft.Json.JsonProperty("recipients", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OutboundCallRecipient> Recipients { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scheduled_time_unix")]
        public int? ScheduledTimeUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_phone_number_id")]
        public string? AgentPhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("whatsapp_params")]
        public global::G.BatchCallWhatsAppParams? WhatsappParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Default Value: {"ringing_timeout_secs":60}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("telephony_call_config")]
        public global::G.TelephonyCallConfig? TelephonyCallConfig { get; set; }

        /// <summary>
        /// Maximum number of simultaneous calls for this batch. When set, dispatch is governed by this limit rather than workspace/agent capacity percentages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_concurrency_limit")]
        public int? TargetConcurrencyLimit { get; set; }

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
        /// <param name="recipients"></param>
        /// <param name="scheduledTimeUnix"></param>
        /// <param name="agentPhoneNumberId"></param>
        /// <param name="whatsappParams"></param>
        /// <param name="timezone"></param>
        /// <param name="telephonyCallConfig">
        /// Default Value: {"ringing_timeout_secs":60}
        /// </param>
        /// <param name="targetConcurrencyLimit">
        /// Maximum number of simultaneous calls for this batch. When set, dispatch is governed by this limit rather than workspace/agent capacity percentages.
        /// </param>
        public BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost(
            string callName,
            string agentId,
            global::System.Collections.Generic.IList<global::G.OutboundCallRecipient> recipients,
            int? scheduledTimeUnix,
            string? agentPhoneNumberId,
            global::G.BatchCallWhatsAppParams? whatsappParams,
            string? timezone,
            global::G.TelephonyCallConfig? telephonyCallConfig,
            int? targetConcurrencyLimit)
        {
            this.CallName = callName ?? throw new global::System.ArgumentNullException(nameof(callName));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
            this.ScheduledTimeUnix = scheduledTimeUnix;
            this.AgentPhoneNumberId = agentPhoneNumberId;
            this.WhatsappParams = whatsappParams;
            this.Timezone = timezone;
            this.TelephonyCallConfig = telephonyCallConfig;
            this.TargetConcurrencyLimit = targetConcurrencyLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost" /> class.
        /// </summary>
        public BodySubmitABatchCallRequestV1ConvaiBatchCallingSubmitPost()
        {
        }
    }
}