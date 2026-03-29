//HintName: G.IStatesClient.GetBackfillStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IStatesClient
    {
        /// <summary>
        /// ✨ Get state backfill status<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Retrieve the status of a state backfill job for the authenticated user's active organization. By default returns the aggregated org status, or specify job_id or project_id to get explicit job statuses. Shows progress, completion time, and any errors. Requires administrator or owner role and both FSM feature flags (fflag_feat_fit_568_finite_state_management and fflag_feat_fit_710_fsm_state_fields).
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StateBackfillStatusResponse> GetBackfillStatusAsync(
            int? jobId = default,
            int? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}