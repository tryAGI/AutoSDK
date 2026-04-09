//HintName: G.IDashboardsClient.DeleteDashboard.g.cs
#nullable enable

namespace G
{
    public partial interface IDashboardsClient
    {
        /// <summary>
        /// Delete dashboard<br/>
        /// Delete dashboard by id
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDashboardAsync(
            global::System.Guid dashboardId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}