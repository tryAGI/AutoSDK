//HintName: G.IEvaluationsClient.ListEvaluationRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// List Evaluation Runs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.EvaluationRunResponse>> ListEvaluationRunsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}