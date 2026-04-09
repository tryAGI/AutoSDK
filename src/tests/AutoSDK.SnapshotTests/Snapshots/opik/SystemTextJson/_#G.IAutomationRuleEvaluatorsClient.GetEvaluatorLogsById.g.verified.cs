//HintName: G.IAutomationRuleEvaluatorsClient.GetEvaluatorLogsById.g.cs
#nullable enable

namespace G
{
    public partial interface IAutomationRuleEvaluatorsClient
    {
        /// <summary>
        /// Get automation rule evaluator logs by id<br/>
        /// Get automation rule evaluator logs by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="size">
        /// Default Value: 1000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LogPage> GetEvaluatorLogsByIdAsync(
            global::System.Guid id,
            int? size = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}