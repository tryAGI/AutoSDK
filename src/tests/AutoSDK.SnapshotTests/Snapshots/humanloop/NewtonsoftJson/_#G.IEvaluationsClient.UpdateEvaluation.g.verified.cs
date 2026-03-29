//HintName: G.IEvaluationsClient.UpdateEvaluation.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Update Evaluation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationResponse> UpdateEvaluationAsync(
            string id,

            global::G.UpdateEvaluationStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Evaluation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationResponse> UpdateEvaluationAsync(
            string id,
            global::G.UpdateEvaluationStatusRequestStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}