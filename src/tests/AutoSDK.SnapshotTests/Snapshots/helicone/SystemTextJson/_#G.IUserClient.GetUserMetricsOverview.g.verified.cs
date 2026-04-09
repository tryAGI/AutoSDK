//HintName: G.IUserClient.GetUserMetricsOverview.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString> GetUserMetricsOverviewAsync(

            global::G.GetUserMetricsOverviewRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="useInterquartile"></param>
        /// <param name="pSize"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString> GetUserMetricsOverviewAsync(
            bool useInterquartile,
            global::G.PSize pSize,
            global::G.UserFilterNode filter,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}