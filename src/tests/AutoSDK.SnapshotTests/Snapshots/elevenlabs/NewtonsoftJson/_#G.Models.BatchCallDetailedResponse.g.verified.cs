//HintName: G.Models.BatchCallDetailedResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Detailed response model for a batch call including all recipients.
    /// </summary>
    public sealed partial class BatchCallDetailedResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number_id")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_provider")]
        public global::G.TelephonyProvider? PhoneProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("whatsapp_params")]
        public global::G.BatchCallWhatsAppParams? WhatsappParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scheduled_time_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int ScheduledTimeUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_calls_dispatched", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCallsDispatched { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_calls_scheduled", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCallsScheduled { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_calls_finished", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCallsFinished { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int LastUpdatedAtUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BatchCallStatus Status { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retry_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int RetryCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("telephony_call_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TelephonyCallConfig TelephonyCallConfig { get; set; } = default!;

        /// <summary>
        /// Maximum number of simultaneous calls for this batch. When set, dispatch is governed by this limit rather than workspace/agent capacity percentages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_concurrency_limit")]
        public int? TargetConcurrencyLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recipients", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OutboundCallRecipientResponseModel> Recipients { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallDetailedResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="agentId"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="scheduledTimeUnix"></param>
        /// <param name="totalCallsDispatched">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCallsScheduled">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCallsFinished">
        /// Default Value: 0
        /// </param>
        /// <param name="lastUpdatedAtUnix"></param>
        /// <param name="status"></param>
        /// <param name="retryCount">
        /// Default Value: 0
        /// </param>
        /// <param name="telephonyCallConfig"></param>
        /// <param name="agentName"></param>
        /// <param name="recipients"></param>
        /// <param name="phoneNumberId"></param>
        /// <param name="phoneProvider"></param>
        /// <param name="whatsappParams"></param>
        /// <param name="timezone"></param>
        /// <param name="targetConcurrencyLimit">
        /// Maximum number of simultaneous calls for this batch. When set, dispatch is governed by this limit rather than workspace/agent capacity percentages.
        /// </param>
        public BatchCallDetailedResponse(
            string id,
            string name,
            string agentId,
            int createdAtUnix,
            int scheduledTimeUnix,
            int totalCallsDispatched,
            int totalCallsScheduled,
            int totalCallsFinished,
            int lastUpdatedAtUnix,
            global::G.BatchCallStatus status,
            int retryCount,
            global::G.TelephonyCallConfig telephonyCallConfig,
            string agentName,
            global::System.Collections.Generic.IList<global::G.OutboundCallRecipientResponseModel> recipients,
            string? phoneNumberId,
            global::G.TelephonyProvider? phoneProvider,
            global::G.BatchCallWhatsAppParams? whatsappParams,
            string? timezone,
            int? targetConcurrencyLimit)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PhoneNumberId = phoneNumberId;
            this.PhoneProvider = phoneProvider;
            this.WhatsappParams = whatsappParams;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.CreatedAtUnix = createdAtUnix;
            this.ScheduledTimeUnix = scheduledTimeUnix;
            this.Timezone = timezone;
            this.TotalCallsDispatched = totalCallsDispatched;
            this.TotalCallsScheduled = totalCallsScheduled;
            this.TotalCallsFinished = totalCallsFinished;
            this.LastUpdatedAtUnix = lastUpdatedAtUnix;
            this.Status = status;
            this.RetryCount = retryCount;
            this.TelephonyCallConfig = telephonyCallConfig ?? throw new global::System.ArgumentNullException(nameof(telephonyCallConfig));
            this.TargetConcurrencyLimit = targetConcurrencyLimit;
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallDetailedResponse" /> class.
        /// </summary>
        public BatchCallDetailedResponse()
        {
        }
    }
}