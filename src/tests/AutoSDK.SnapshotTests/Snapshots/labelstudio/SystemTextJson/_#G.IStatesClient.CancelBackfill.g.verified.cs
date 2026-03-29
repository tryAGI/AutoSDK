//HintName: G.IStatesClient.CancelBackfill.g.cs
#nullable enable

namespace G
{
    public partial interface IStatesClient
    {
        /// <summary>
        /// ✨ Cancel state backfill jobs<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Cancel state backfill jobs for the authenticated user's active organization. Can cancel a specific job by job_id, all jobs for a specific project by project_id, or all backfill jobs for the entire organization if neither is provided.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StateBackfillCancelResponse> CancelBackfillAsync(
            int? jobId = default,
            int? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}