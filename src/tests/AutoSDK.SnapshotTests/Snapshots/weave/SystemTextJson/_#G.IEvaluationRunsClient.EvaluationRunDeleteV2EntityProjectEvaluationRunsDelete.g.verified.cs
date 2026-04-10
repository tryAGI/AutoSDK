//HintName: G.IEvaluationRunsClient.EvaluationRunDeleteV2EntityProjectEvaluationRunsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationRunsClient
    {
        /// <summary>
        /// Evaluation Run Delete<br/>
        /// Delete evaluation runs.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluationRunIds">
        /// List of evaluation run IDs to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationRunDeleteRes> EvaluationRunDeleteV2EntityProjectEvaluationRunsDeleteAsync(
            string entity,
            string project,
            global::System.Collections.Generic.IList<string> evaluationRunIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}