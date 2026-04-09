//HintName: G.IStatesClient.StateHistory.g.cs
#nullable enable

namespace G
{
    public partial interface IStatesClient
    {
        /// <summary>
        /// ✨ Get entity state history<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Get the state history of an entity
        /// </summary>
        /// <param name="createdAtFrom"></param>
        /// <param name="createdAtTo"></param>
        /// <param name="entityId"></param>
        /// <param name="entityName"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="previousState"></param>
        /// <param name="state"></param>
        /// <param name="transitionName"></param>
        /// <param name="triggeredBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedStateModelList> StateHistoryAsync(
            int entityId,
            string entityName,
            string? createdAtFrom = default,
            string? createdAtTo = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? previousState = default,
            string? state = default,
            string? transitionName = default,
            double? triggeredBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}