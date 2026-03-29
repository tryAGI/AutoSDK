//HintName: G.ICampaignsClient.CampaignControllerUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface ICampaignsClient
    {
        /// <summary>
        /// Update Campaign
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Campaign> CampaignControllerUpdateAsync(
            string id,

            global::G.UpdateCampaignDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Campaign
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Campaign> CampaignControllerUpdateAsync(
            string id,
            string? name = default,
            string? assistantId = default,
            string? workflowId = default,
            string? squadId = default,
            string? phoneNumberId = default,
            global::System.Collections.Generic.IList<global::G.DialPlanEntry>? dialPlan = default,
            global::G.SchedulePlan? schedulePlan = default,
            global::G.UpdateCampaignDTOStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}