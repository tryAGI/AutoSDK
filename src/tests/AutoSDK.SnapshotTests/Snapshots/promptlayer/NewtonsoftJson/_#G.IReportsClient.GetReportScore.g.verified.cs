//HintName: G.IReportsClient.GetReportScore.g.cs
#nullable enable

namespace G
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Get Evaluation Score
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetReportScoreResponse> GetReportScoreAsync(
            int reportId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}