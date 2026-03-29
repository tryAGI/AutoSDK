//HintName: G.IDimensions2Client.ListBackfills.g.cs
#nullable enable

namespace G
{
    public partial interface IDimensions2Client
    {
        /// <summary>
        /// ✨ List Agreement V2 backfill jobs<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Retrieve Agreement V2 backfill jobs for the authenticated user's active organization, ordered by most-recently created first. Supports page / page_size query params (default 50 per page, max 500). Requires administrator or owner role and the Agreement V2 feature flag.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AgreementV2BackfillJob>> ListBackfillsAsync(
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}