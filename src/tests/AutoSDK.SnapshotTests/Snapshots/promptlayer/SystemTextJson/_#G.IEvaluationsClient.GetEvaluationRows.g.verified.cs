//HintName: G.IEvaluationsClient.GetEvaluationRows.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Get Evaluation Rows<br/>
        /// Retrieve paginated evaluation results with dataset input variables and evaluation cell outcomes. Each row is an array of cells matching the order of the `columns` array. Dataset input cells have `{"type": "dataset", "value": ...}`. Eval result cells have `{"type": "eval", "status": ..., "value": ...}`.
        /// </summary>
        /// <param name="evaluationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetEvaluationRowsResponse> GetEvaluationRowsAsync(
            int evaluationId,
            int? workspaceId = default,
            int? page = default,
            int? perPage = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}