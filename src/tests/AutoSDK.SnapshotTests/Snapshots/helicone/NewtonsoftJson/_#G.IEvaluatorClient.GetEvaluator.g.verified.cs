//HintName: G.IEvaluatorClient.GetEvaluator.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluatorClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultEvaluatorResultString> GetEvaluatorAsync(
            string evaluatorId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}