//HintName: G.IEvaluationsClient.CreateEvaluation.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Create Evaluation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationResponse> CreateEvaluationAsync(

            global::G.EvaluationRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Evaluation
        /// </summary>
        /// <param name="fileId">
        /// ID of the File to evaluate.
        /// </param>
        /// <param name="name">
        /// Name of the Evaluation.
        /// </param>
        /// <param name="evaluatorIds">
        /// IDs of Evaluators to use.
        /// </param>
        /// <param name="datasetId">
        /// ID of the Dataset to use.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationResponse> CreateEvaluationAsync(
            string? fileId = default,
            string? name = default,
            global::System.Collections.Generic.IList<string>? evaluatorIds = default,
            string? datasetId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}