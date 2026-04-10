//HintName: G.IEvaluatorClient.UpdateEvaluator.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluatorClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultEvaluatorResultString> UpdateEvaluatorAsync(
            string evaluatorId,

            global::G.UpdateEvaluatorParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="scoringType"></param>
        /// <param name="llmTemplate"></param>
        /// <param name="codeTemplate"></param>
        /// <param name="name"></param>
        /// <param name="lastMileConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultEvaluatorResultString> UpdateEvaluatorAsync(
            string evaluatorId,
            string? scoringType = default,
            object? llmTemplate = default,
            object? codeTemplate = default,
            string? name = default,
            object? lastMileConfig = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}