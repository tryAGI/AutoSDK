//HintName: G.IStatsClient.TotalAgreement.g.cs
#nullable enable

namespace G
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// ✨ Get total agreement for project<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Overall or per-label total agreement across the project.<br/>
        /// NOTE: due to an open issue in Fern, SDK clients will raise ApiError upon handling a 204 response. As a workaround, wrap call to this function in a try-except block.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="perLabel"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OneOf<global::G.ApiProjectsStatsTotalAgreementRetrieveResponseVariant1, global::G.ApiProjectsStatsTotalAgreementRetrieveResponseVariant2>> TotalAgreementAsync(
            int id,
            bool? perLabel = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}