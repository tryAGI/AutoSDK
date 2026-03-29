//HintName: G.IEvalsClient.AddEval.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> AddEvalAsync(
            string requestId,

            global::G.AddEvalRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="score"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> AddEvalAsync(
            string requestId,
            double score,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}