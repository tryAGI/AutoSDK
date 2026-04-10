//HintName: G.IAnalyticsClient.ApiAnalyticsViewsDestroy.g.cs
#nullable enable

namespace G
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// CRUD endpoints for per-user analytics saved views.<br/>
        /// All routes are gated behind the ``fflag_feat_fit_1424_analytics_saved_views``<br/>
        /// feature flag AND the same ``should_check_analytics_permission`` helper used<br/>
        /// by the KPI endpoints, so a user who cannot access the analytics dashboard<br/>
        /// cannot read view metadata even via a shared link.<br/>
        /// Lookup uses ``uuid`` (not PK) so the primary key is never exposed.<br/>
        /// Access rules<br/>
        /// ------------<br/>
        /// * list / create   — scoped to requesting user + active org<br/>
        /// * retrieve        — any org member who passes the analytics permission check<br/>
        ///                     (enables shared-link UX: ``?view=&lt;uuid&gt;`` in the URL)<br/>
        /// * update / destroy — owner-only
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiAnalyticsViewsDestroyAsync(
            global::System.Guid uuid,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}