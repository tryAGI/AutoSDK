//HintName: G.IEvaluationsClient.EvaluationStatusEvaluationsStatusPost.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Evaluation Status
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationStatusRes> EvaluationStatusEvaluationsStatusPostAsync(

            global::G.EvaluationStatusReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluation Status
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="callId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationStatusRes> EvaluationStatusEvaluationsStatusPostAsync(
            string projectId,
            string callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}