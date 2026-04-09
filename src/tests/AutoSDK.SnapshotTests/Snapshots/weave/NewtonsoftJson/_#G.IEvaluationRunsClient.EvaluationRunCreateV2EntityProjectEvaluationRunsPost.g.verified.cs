//HintName: G.IEvaluationRunsClient.EvaluationRunCreateV2EntityProjectEvaluationRunsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationRunsClient
    {
        /// <summary>
        /// Evaluation Run Create<br/>
        /// Create an evaluation run.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationRunCreateRes> EvaluationRunCreateV2EntityProjectEvaluationRunsPostAsync(
            string entity,
            string project,

            global::G.EvaluationRunCreateBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluation Run Create<br/>
        /// Create an evaluation run.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluation">
        /// Reference to the evaluation (weave:// URI)
        /// </param>
        /// <param name="model">
        /// Reference to the model (weave:// URI)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationRunCreateRes> EvaluationRunCreateV2EntityProjectEvaluationRunsPostAsync(
            string entity,
            string project,
            string evaluation,
            string model,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}