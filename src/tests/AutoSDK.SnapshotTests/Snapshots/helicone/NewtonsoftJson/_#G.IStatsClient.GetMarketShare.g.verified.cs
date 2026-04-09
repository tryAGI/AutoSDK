//HintName: G.IStatsClient.GetMarketShare.g.cs
#nullable enable

namespace G
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// Get market share statistics by model author for the AI Gateway.<br/>
        /// Returns time series data (100% stacked) and a leaderboard of top 9 authors + others.
        /// </summary>
        /// <param name="timeframe"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultMarketShareResponseString> GetMarketShareAsync(
            global::G.StatsTimeFrame? timeframe = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}