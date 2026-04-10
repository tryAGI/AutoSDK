//HintName: G.IReportsClient.GetReport.g.cs
#nullable enable

namespace G
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Get Evaluation
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetReportResponse> GetReportAsync(
            int reportId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}