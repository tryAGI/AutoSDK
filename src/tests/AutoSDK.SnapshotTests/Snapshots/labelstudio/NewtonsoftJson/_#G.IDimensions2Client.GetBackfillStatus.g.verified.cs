//HintName: G.IDimensions2Client.GetBackfillStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IDimensions2Client
    {
        /// <summary>
        /// ✨ Get Agreement V2 backfill status<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Retrieve the status of an Agreement V2 backfill job for the authenticated user's active organization. By default returns the aggregated organization status. Specify job_id or project_id to get a specific job status. Requires administrator or owner role and the Agreement V2 feature flag.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgreementV2BackfillJob> GetBackfillStatusAsync(
            int? jobId = default,
            int? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}