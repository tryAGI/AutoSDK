//HintName: G.IAuthClient.GetTeamsByTeamIDMetrics.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get metrics for the team
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="start"></param>
        /// <param name="end">
        /// Unix timestamp for the end of the interval, in seconds, for which the metrics
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TeamMetric>> GetTeamsByTeamIDMetricsAsync(
            string teamID,
            long? start = default,
            global::System.DateTimeOffset? end = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}