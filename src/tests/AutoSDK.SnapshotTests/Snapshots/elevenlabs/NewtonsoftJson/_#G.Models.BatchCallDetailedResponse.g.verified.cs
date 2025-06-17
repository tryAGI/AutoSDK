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
        [global::Newtonsoft.Json.JsonProperty("phone_number_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumberId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_provider")]
        public global::G.TelephonyProvider? PhoneProvider { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("total_calls_dispatched", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCallsDispatched { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_calls_scheduled", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCallsScheduled { get; set; } = default!;

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
        /// <param name="phoneNumberId"></param>
        /// <param name="phoneProvider"></param>
        /// <param name="name"></param>
        /// <param name="agentId"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="scheduledTimeUnix"></param>
        /// <param name="totalCallsDispatched"></param>
        /// <param name="totalCallsScheduled"></param>
        /// <param name="lastUpdatedAtUnix"></param>
        /// <param name="status"></param>
        /// <param name="agentName"></param>
        /// <param name="recipients"></param>
        public BatchCallDetailedResponse(
            string id,
            string phoneNumberId,
            string name,
            string agentId,
            int createdAtUnix,
            int scheduledTimeUnix,
            int totalCallsDispatched,
            int totalCallsScheduled,
            int lastUpdatedAtUnix,
            global::G.BatchCallStatus status,
            string agentName,
            global::System.Collections.Generic.IList<global::G.OutboundCallRecipientResponseModel> recipients,
            global::G.TelephonyProvider? phoneProvider)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.CreatedAtUnix = createdAtUnix;
            this.ScheduledTimeUnix = scheduledTimeUnix;
            this.TotalCallsDispatched = totalCallsDispatched;
            this.TotalCallsScheduled = totalCallsScheduled;
            this.LastUpdatedAtUnix = lastUpdatedAtUnix;
            this.Status = status;
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
            this.PhoneProvider = phoneProvider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallDetailedResponse" /> class.
        /// </summary>
        public BatchCallDetailedResponse()
        {
        }
    }
}