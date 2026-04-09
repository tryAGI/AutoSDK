//HintName: G.IInsightsViewsClient.GetInsightsViewById.g.cs
#nullable enable

namespace G
{
    public partial interface IInsightsViewsClient
    {
        /// <summary>
        /// Get insights view by id<br/>
        /// Get insights view by id
        /// </summary>
        /// <param name="insightsViewId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DashboardPublic> GetInsightsViewByIdAsync(
            global::System.Guid insightsViewId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}