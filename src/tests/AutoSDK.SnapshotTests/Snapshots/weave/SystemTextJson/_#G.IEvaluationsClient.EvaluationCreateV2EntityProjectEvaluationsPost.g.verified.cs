//HintName: G.IEvaluationsClient.EvaluationCreateV2EntityProjectEvaluationsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Evaluation Create<br/>
        /// Create an evaluation object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationCreateRes> EvaluationCreateV2EntityProjectEvaluationsPostAsync(
            string entity,
            string project,

            global::G.EvaluationCreateBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluation Create<br/>
        /// Create an evaluation object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="name">
        /// The name of this evaluation.  Evaluations with the same name will be versioned together.
        /// </param>
        /// <param name="description">
        /// A description of this evaluation
        /// </param>
        /// <param name="dataset">
        /// Reference to the dataset (weave:// URI)
        /// </param>
        /// <param name="scorers">
        /// List of scorer references (weave:// URIs)
        /// </param>
        /// <param name="trials">
        /// Number of trials to run<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="evaluationName">
        /// Name for the evaluation run
        /// </param>
        /// <param name="evalAttributes">
        /// Optional attributes for the evaluation
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationCreateRes> EvaluationCreateV2EntityProjectEvaluationsPostAsync(
            string entity,
            string project,
            string name,
            string dataset,
            string? description = default,
            global::System.Collections.Generic.IList<string>? scorers = default,
            int? trials = default,
            string? evaluationName = default,
            object? evalAttributes = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}