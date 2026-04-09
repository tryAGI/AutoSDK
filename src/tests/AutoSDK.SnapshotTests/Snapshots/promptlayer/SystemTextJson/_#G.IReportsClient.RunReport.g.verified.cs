//HintName: G.IReportsClient.RunReport.g.cs
#nullable enable

namespace G
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Run Full Evaluation
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunReportResponse> RunReportAsync(
            int reportId,

            global::G.RunReportRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Full Evaluation
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="name">
        /// The name of the final report to be created. Must be between 1 and 255 characters in length.
        /// </param>
        /// <param name="datasetId">
        /// The ID of the dataset to use for the report. If not provided, uses the evaluation pipeline's default dataset.
        /// </param>
        /// <param name="refreshDataset">
        /// Whether to refresh the dataset before running the report. Only applicable for dynamic datasets.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunReportResponse> RunReportAsync(
            int reportId,
            string name,
            int? datasetId = default,
            bool? refreshDataset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}