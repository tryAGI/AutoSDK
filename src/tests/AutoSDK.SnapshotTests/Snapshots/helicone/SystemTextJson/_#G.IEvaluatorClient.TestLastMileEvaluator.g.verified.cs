//HintName: G.IEvaluatorClient.TestLastMileEvaluator.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultScoreNumberInputStringOutputStringGroundTruth63StringString> TestLastMileEvaluatorAsync(

            global::G.TestLastMileEvaluatorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="testInput"></param>
        /// <param name="config"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultScoreNumberInputStringOutputStringGroundTruth63StringString> TestLastMileEvaluatorAsync(
            global::G.TestInput testInput,
            global::G.LastMileConfigForm config,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}