//HintName: G.IAuthClient.GetTeamsByTeamIDMetricsMax.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get the maximum metrics for the team in the given interval
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="start"></param>
        /// <param name="end">
        /// Unix timestamp for the end of the interval, in seconds, for which the metrics
        /// </param>
        /// <param name="metric"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MaxTeamMetric> GetTeamsByTeamIDMetricsMaxAsync(
            string teamID,
            global::G.GetTeamsMetricsMaxMetric metric,
            long? start = default,
            global::System.DateTimeOffset? end = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}