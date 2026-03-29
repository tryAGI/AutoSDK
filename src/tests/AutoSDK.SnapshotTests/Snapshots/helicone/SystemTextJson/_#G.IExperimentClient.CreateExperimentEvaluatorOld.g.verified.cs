//HintName: G.IExperimentClient.CreateExperimentEvaluatorOld.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> CreateExperimentEvaluatorOldAsync(
            string experimentId,

            global::G.CreateExperimentEvaluatorOldRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="evaluatorId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> CreateExperimentEvaluatorOldAsync(
            string experimentId,
            string evaluatorId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}