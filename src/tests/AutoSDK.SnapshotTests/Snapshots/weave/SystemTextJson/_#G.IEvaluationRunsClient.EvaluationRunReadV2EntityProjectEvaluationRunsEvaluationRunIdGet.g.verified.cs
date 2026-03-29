//HintName: G.IEvaluationRunsClient.EvaluationRunReadV2EntityProjectEvaluationRunsEvaluationRunIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationRunsClient
    {
        /// <summary>
        /// Evaluation Run Read<br/>
        /// Read an evaluation run.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluationRunId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationRunReadRes> EvaluationRunReadV2EntityProjectEvaluationRunsEvaluationRunIdGetAsync(
            string entity,
            string project,
            string evaluationRunId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}