//HintName: G.IMetricsClient.GetQuantiles.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultQuantilesArrayString> GetQuantilesAsync(

            global::G.QuantilesBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="timeFilter"></param>
        /// <param name="dbIncrement"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="metric"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultQuantilesArrayString> GetQuantilesAsync(
            global::G.FilterNode filter,
            global::G.QuantilesBodyTimeFilter timeFilter,
            double timeZoneDifference,
            string metric,
            global::G.TimeIncrement? dbIncrement = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}