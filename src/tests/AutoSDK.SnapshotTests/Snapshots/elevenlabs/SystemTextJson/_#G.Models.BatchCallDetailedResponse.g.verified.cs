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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_provider")]
        public global::G.TelephonyProvider? PhoneProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_params")]
        public global::G.BatchCallWhatsAppParams? WhatsappParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_time_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScheduledTimeUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calls_dispatched")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCallsDispatched { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calls_scheduled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCallsScheduled { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calls_finished")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCallsFinished { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastUpdatedAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BatchCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BatchCallStatus Status { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RetryCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telephony_call_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TelephonyCallConfig TelephonyCallConfig { get; set; }

        /// <summary>
        /// Maximum number of simultaneous calls for this batch. When set, dispatch is governed by this limit rather than workspace/agent capacity percentages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_concurrency_limit")]
        public int? TargetConcurrencyLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OutboundCallRecipientResponseModel> Recipients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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