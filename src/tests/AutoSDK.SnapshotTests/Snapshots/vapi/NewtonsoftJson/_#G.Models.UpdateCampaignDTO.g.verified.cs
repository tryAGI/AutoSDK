//HintName: G.Models.UpdateCampaignDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCampaignDTO
    {
        /// <summary>
        /// This is the name of the campaign. This is just for your own reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the assistant ID that will be used for the campaign calls.<br/>
        /// Can only be updated if campaign is not in progress or has ended.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the workflow ID that will be used for the campaign calls.<br/>
        /// Can only be updated if campaign is not in progress or has ended.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// This is the squad ID that will be used for the campaign calls.<br/>
        /// Can only be updated if campaign is not in progress or has ended.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is the phone number ID that will be used for the campaign calls.<br/>
        /// Can only be updated if campaign is not in progress or has ended.<br/>
        /// Note: `phoneNumberId` and `dialPlan` are mutually exclusive.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumberId")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// This is a list of dial entries, each specifying a phone number and the customers to call using that number. Can only be updated if campaign is not in progress or has ended. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dialPlan")]
        public global::System.Collections.Generic.IList<global::G.DialPlanEntry>? DialPlan { get; set; }

        /// <summary>
        /// This is the schedule plan for the campaign.<br/>
        /// Can only be updated if campaign is not in progress or has ended.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schedulePlan")]
        public global::G.SchedulePlan? SchedulePlan { get; set; }

        /// <summary>
        /// This is the status of the campaign.<br/>
        /// Can only be updated to 'ended' if you want to end the campaign.<br/>
        /// When set to 'ended', it will delete all scheduled calls. Calls in progress will be allowed to complete.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.UpdateCampaignDTOStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCampaignDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the campaign. This is just for your own reference.
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant ID that will be used for the campaign calls.<br/>
        /// Can only be updated if campaign is not in progress or has ended.
        /// </param>
        /// <param name="workflowId">
        /// This is the workflow ID that will be used for the campaign calls.<br/>
        /// Can only be updated if campaign is not in progress or has ended.
        /// </param>
        /// <param name="squadId">
        /// This is the squad ID that will be used for the campaign calls.<br/>
        /// Can only be updated if campaign is not in progress or has ended.
        /// </param>
        /// <param name="phoneNumberId">
        /// This is the phone number ID that will be used for the campaign calls.<br/>
        /// Can only be updated if campaign is not in progress or has ended.<br/>
        /// Note: `phoneNumberId` and `dialPlan` are mutually exclusive.
        /// </param>
        /// <param name="dialPlan">
        /// This is a list of dial entries, each specifying a phone number and the customers to call using that number. Can only be updated if campaign is not in progress or has ended. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </param>
        /// <param name="schedulePlan">
        /// This is the schedule plan for the campaign.<br/>
        /// Can only be updated if campaign is not in progress or has ended.
        /// </param>
        /// <param name="status">
        /// This is the status of the campaign.<br/>
        /// Can only be updated to 'ended' if you want to end the campaign.<br/>
        /// When set to 'ended', it will delete all scheduled calls. Calls in progress will be allowed to complete.
        /// </param>
        public UpdateCampaignDTO(
            string? name,
            string? assistantId,
            string? workflowId,
            string? squadId,
            string? phoneNumberId,
            global::System.Collections.Generic.IList<global::G.DialPlanEntry>? dialPlan,
            global::G.SchedulePlan? schedulePlan,
            global::G.UpdateCampaignDTOStatus? status)
        {
            this.Name = name;
            this.AssistantId = assistantId;
            this.WorkflowId = workflowId;
            this.SquadId = squadId;
            this.PhoneNumberId = phoneNumberId;
            this.DialPlan = dialPlan;
            this.SchedulePlan = schedulePlan;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCampaignDTO" /> class.
        /// </summary>
        public UpdateCampaignDTO()
        {
        }
    }
}