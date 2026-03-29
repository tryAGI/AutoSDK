//HintName: G.ICampaignsClient.CampaignControllerCreate.g.cs
#nullable enable

namespace G
{
    public partial interface ICampaignsClient
    {
        /// <summary>
        /// Create Campaign
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Campaign> CampaignControllerCreateAsync(

            global::G.CreateCampaignDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Campaign
        /// </summary>
        /// <param name="name">
        /// This is the name of the campaign. This is just for your own reference.<br/>
        /// Example: Q2 Sales Campaign
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Campaign> CampaignControllerCreateAsync(
            string name,
            string? assistantId = default,
            string? workflowId = default,
            string? squadId = default,
            string? phoneNumberId = default,
            global::System.Collections.Generic.IList<global::G.DialPlanEntry>? dialPlan = default,
            global::G.SchedulePlan? schedulePlan = default,
            global::System.Collections.Generic.IList<global::G.CreateCustomerDTO>? customers = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}