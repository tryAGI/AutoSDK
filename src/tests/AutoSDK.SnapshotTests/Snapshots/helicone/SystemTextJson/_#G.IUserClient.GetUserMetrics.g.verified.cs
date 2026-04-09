//HintName: G.IUserClient.GetUserMetrics.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString> GetUserMetricsAsync(

            global::G.UserMetricsQueryParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="timeFilter"></param>
        /// <param name="timeZoneDifferenceMinutes"></param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString> GetUserMetricsAsync(
            global::G.UserFilterNode filter,
            double offset,
            double limit,
            global::G.UserMetricsQueryParamsTimeFilter? timeFilter = default,
            double? timeZoneDifferenceMinutes = default,
            global::G.SortLeafUsers? sort = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}