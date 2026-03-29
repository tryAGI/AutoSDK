//HintName: G.IMetricsClient.GetTotalThreats.g.cs
#nullable enable

namespace G
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNumberString> GetTotalThreatsAsync(

            global::G.MetricsFilterBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="timeFilter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNumberString> GetTotalThreatsAsync(
            global::G.FilterNode filter,
            global::G.MetricsFilterBodyTimeFilter timeFilter,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}