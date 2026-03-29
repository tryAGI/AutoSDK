//HintName: G.IStatsClient.GetModelUsage.g.cs
#nullable enable

namespace G
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// Get model usage statistics for the AI Gateway.<br/>
        /// Returns time series data and a leaderboard of top models by total tokens.
        /// </summary>
        /// <param name="timeframe"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultModelUsageResponseString> GetModelUsageAsync(
            global::G.StatsTimeFrame? timeframe = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}