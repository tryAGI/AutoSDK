//HintName: G.IDimensions2Client.TriggerBackfill.g.cs
#nullable enable

namespace G
{
    public partial interface IDimensions2Client
    {
        /// <summary>
        /// ✨ Trigger Agreement V2 backfill<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Trigger an Agreement V2 backfill for the authenticated user's active organization. Recomputes agreement score matrices for all tasks that are missing them. Exactly one of three body fields must be provided:<br/>
        /// - **project_id**: backfill a single specific project.<br/>
        /// - **num_projects**: batched org backfill — queue the next N not-yet-started projects (in ascending project ID order), leaving any currently in-flight jobs untouched. Repeat calls until `projects_remaining` in the response reaches 0.<br/>
        /// - **all_projects**: full org backfill — cancel all in-flight jobs and queue every remaining non-completed project at once.<br/>
        /// Requires administrator or owner role and the Agreement V2 feature flag.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgreementV2BackfillTriggerResponse> TriggerBackfillAsync(

            global::G.AgreementV2BackfillTriggerRequestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Trigger Agreement V2 backfill<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Trigger an Agreement V2 backfill for the authenticated user's active organization. Recomputes agreement score matrices for all tasks that are missing them. Exactly one of three body fields must be provided:<br/>
        /// - **project_id**: backfill a single specific project.<br/>
        /// - **num_projects**: batched org backfill — queue the next N not-yet-started projects (in ascending project ID order), leaving any currently in-flight jobs untouched. Repeat calls until `projects_remaining` in the response reaches 0.<br/>
        /// - **all_projects**: full org backfill — cancel all in-flight jobs and queue every remaining non-completed project at once.<br/>
        /// Requires administrator or owner role and the Agreement V2 feature flag.
        /// </summary>
        /// <param name="allProjects">
        /// Set to true to trigger a full org backfill (cancels in-flight jobs and queues all remaining projects).
        /// </param>
        /// <param name="numProjects">
        /// Queue at most this many projects per call (batched mode).
        /// </param>
        /// <param name="projectId">
        /// Backfill a single specific project.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgreementV2BackfillTriggerResponse> TriggerBackfillAsync(
            bool? allProjects = default,
            int? numProjects = default,
            int? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}