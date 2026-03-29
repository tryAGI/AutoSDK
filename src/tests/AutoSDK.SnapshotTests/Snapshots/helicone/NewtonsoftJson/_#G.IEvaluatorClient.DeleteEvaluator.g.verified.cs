//HintName: G.IEvaluatorClient.DeleteEvaluator.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultNullString> DeleteEvaluatorAsync(
            string evaluatorId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}