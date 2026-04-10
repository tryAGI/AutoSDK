//HintName: G.IAutomationRuleEvaluatorsClient.DeleteAutomationRuleEvaluatorBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IAutomationRuleEvaluatorsClient
    {
        /// <summary>
        /// Delete automation rule evaluators<br/>
        /// Delete automation rule evaluators batch
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAutomationRuleEvaluatorBatchAsync(

            global::G.BatchDelete request,
            global::System.Guid? projectId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete automation rule evaluators<br/>
        /// Delete automation rule evaluators batch
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="ids"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteAutomationRuleEvaluatorBatchAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Guid? projectId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}