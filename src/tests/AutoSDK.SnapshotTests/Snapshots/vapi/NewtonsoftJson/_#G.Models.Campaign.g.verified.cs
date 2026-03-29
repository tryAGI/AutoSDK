//HintName: G.Models.Campaign.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Campaign
    {
        /// <summary>
        /// This is the status of the campaign.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CampaignStatus Status { get; set; } = default!;

        /// <summary>
        /// This is the explanation for how the campaign ended.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endedReason")]
        public global::G.CampaignEndedReason? EndedReason { get; set; }

        /// <summary>
        /// This is the name of the campaign. This is just for your own reference.<br/>
        /// Example: Q2 Sales Campaign
        /// </summary>
        /// <example>Q2 Sales Campaign</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// This is the assistant ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the workflow ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// This is the squad ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is the phone number ID that will be used for the campaign calls. Required if dialPlan is not provided. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumberId")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// This is a list of dial entries, each specifying a phone number and the customers to call using that number. Use this when you want different phone numbers to call different sets of customers. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dialPlan")]
        public global::System.Collections.Generic.IList<global::G.DialPlanEntry>? DialPlan { get; set; }

        /// <summary>
        /// This is the schedule plan for the campaign. Calls will start at startedAt and continue until your organization’s concurrency limit is reached. Any remaining calls will be retried for up to one hour as capacity becomes available. After that hour or after latestAt, whichever comes first, any calls that couldn’t be placed won’t be retried.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schedulePlan")]
        public global::G.SchedulePlan? SchedulePlan { get; set; }

        /// <summary>
        /// These are the customers that will be called in the campaign. Required if dialPlan is not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customers")]
        public global::System.Collections.Generic.IList<global::G.CreateCustomerDTO>? Customers { get; set; }

        /// <summary>
        /// This is the unique identifier for the campaign.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the org that this campaign belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the campaign was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the campaign was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is a map of call IDs to campaign call details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("calls", Required = global::Newtonsoft.Json.Required.Always)]
        public object Calls { get; set; } = default!;

        /// <summary>
        /// This is the number of calls that have been scheduled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callsCounterScheduled", Required = global::Newtonsoft.Json.Required.Always)]
        public double CallsCounterScheduled { get; set; } = default!;

        /// <summary>
        /// This is the number of calls that have been queued.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callsCounterQueued", Required = global::Newtonsoft.Json.Required.Always)]
        public double CallsCounterQueued { get; set; } = default!;

        /// <summary>
        /// This is the number of calls that have been in progress.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callsCounterInProgress", Required = global::Newtonsoft.Json.Required.Always)]
        public double CallsCounterInProgress { get; set; } = default!;

        /// <summary>
        /// This is the number of calls whose ended reason is 'voicemail'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callsCounterEndedVoicemail", Required = global::Newtonsoft.Json.Required.Always)]
        public double CallsCounterEndedVoicemail { get; set; } = default!;

        /// <summary>
        /// This is the number of calls that have ended.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callsCounterEnded", Required = global::Newtonsoft.Json.Required.Always)]
        public double CallsCounterEnded { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" /> class.
        /// </summary>
        /// <param name="status">
        /// This is the status of the campaign.
        /// </param>
        /// <param name="name">
        /// This is the name of the campaign. This is just for your own reference.<br/>
        /// Example: Q2 Sales Campaign
        /// </param>
        /// <param name="id">
        /// This is the unique identifier for the campaign.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this campaign belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the campaign was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the campaign was last updated.
        /// </param>
        /// <param name="calls">
        /// This is a map of call IDs to campaign call details.
        /// </param>
        /// <param name="callsCounterScheduled">
        /// This is the number of calls that have been scheduled.
        /// </param>
        /// <param name="callsCounterQueued">
        /// This is the number of calls that have been queued.
        /// </param>
        /// <param name="callsCounterInProgress">
        /// This is the number of calls that have been in progress.
        /// </param>
        /// <param name="callsCounterEndedVoicemail">
        /// This is the number of calls whose ended reason is 'voicemail'.
        /// </param>
        /// <param name="callsCounterEnded">
        /// This is the number of calls that have ended.
        /// </param>
        /// <param name="endedReason">
        /// This is the explanation for how the campaign ended.
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </param>
        /// <param name="workflowId">
        /// This is the workflow ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </param>
        /// <param name="squadId">
        /// This is the squad ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </param>
        /// <param name="phoneNumberId">
        /// This is the phone number ID that will be used for the campaign calls. Required if dialPlan is not provided. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </param>
        /// <param name="dialPlan">
        /// This is a list of dial entries, each specifying a phone number and the customers to call using that number. Use this when you want different phone numbers to call different sets of customers. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </param>
        /// <param name="schedulePlan">
        /// This is the schedule plan for the campaign. Calls will start at startedAt and continue until your organization’s concurrency limit is reached. Any remaining calls will be retried for up to one hour as capacity becomes available. After that hour or after latestAt, whichever comes first, any calls that couldn’t be placed won’t be retried.
        /// </param>
        /// <param name="customers">
        /// These are the customers that will be called in the campaign. Required if dialPlan is not provided.
        /// </param>
        public Campaign(
            global::G.CampaignStatus status,
            string name,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object calls,
            double callsCounterScheduled,
            double callsCounterQueued,
            double callsCounterInProgress,
            double callsCounterEndedVoicemail,
            double callsCounterEnded,
            global::G.CampaignEndedReason? endedReason,
            string? assistantId,
            string? workflowId,
            string? squadId,
            string? phoneNumberId,
            global::System.Collections.Generic.IList<global::G.DialPlanEntry>? dialPlan,
            global::G.SchedulePlan? schedulePlan,
            global::System.Collections.Generic.IList<global::G.CreateCustomerDTO>? customers)
        {
            this.Status = status;
            this.EndedReason = endedReason;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AssistantId = assistantId;
            this.WorkflowId = workflowId;
            this.SquadId = squadId;
            this.PhoneNumberId = phoneNumberId;
            this.DialPlan = dialPlan;
            this.SchedulePlan = schedulePlan;
            this.Customers = customers;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Calls = calls ?? throw new global::System.ArgumentNullException(nameof(calls));
            this.CallsCounterScheduled = callsCounterScheduled;
            this.CallsCounterQueued = callsCounterQueued;
            this.CallsCounterInProgress = callsCounterInProgress;
            this.CallsCounterEndedVoicemail = callsCounterEndedVoicemail;
            this.CallsCounterEnded = callsCounterEnded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" /> class.
        /// </summary>
        public Campaign()
        {
        }
    }
}