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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString> GetUserMetricsOverviewAsync(

            global::G.GetUserMetricsOverviewRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="useInterquartile"></param>
        /// <param name="pSize"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultRequestCountHistogramRowArrayUserCostHistogramRowArrayString> GetUserMetricsOverviewAsync(
            bool useInterquartile,
            global::G.PSize pSize,
            global::G.UserFilterNode filter,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}