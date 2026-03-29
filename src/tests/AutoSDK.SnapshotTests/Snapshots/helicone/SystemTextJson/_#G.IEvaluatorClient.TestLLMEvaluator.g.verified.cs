//HintName: G.IEvaluatorClient.TestLLMEvaluator.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluatorClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultEvaluatorScoreString> TestLLMEvaluatorAsync(

            global::G.TestLLMEvaluatorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="evaluatorName"></param>
        /// <param name="testInput"></param>
        /// <param name="evaluatorConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultEvaluatorScoreString> TestLLMEvaluatorAsync(
            string evaluatorName,
            global::G.TestInput testInput,
            global::G.EvaluatorConfig evaluatorConfig,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}