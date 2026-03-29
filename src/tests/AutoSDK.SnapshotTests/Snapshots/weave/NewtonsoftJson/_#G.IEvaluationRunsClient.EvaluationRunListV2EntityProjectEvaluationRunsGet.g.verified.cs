//HintName: G.IEvaluationRunsClient.EvaluationRunListV2EntityProjectEvaluationRunsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationRunsClient
    {
        /// <summary>
        /// Evaluation Run List<br/>
        /// List evaluation runs.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluations">
        /// Filter by evaluation references
        /// </param>
        /// <param name="models">
        /// Filter by model references
        /// </param>
        /// <param name="evaluationRunIds">
        /// Filter by evaluation run IDs
        /// </param>
        /// <param name="limit">
        /// Maximum number of evaluation runs to return
        /// </param>
        /// <param name="offset">
        /// Number of evaluation runs to skip
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.EvaluationRunReadRes>> EvaluationRunListV2EntityProjectEvaluationRunsGetAsync(
            string entity,
            string project,
            global::System.Collections.Generic.IList<string>? evaluations = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<string>? evaluationRunIds = default,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}