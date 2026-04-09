//HintName: G.IManualEvaluationClient.EvaluateSpans.g.cs
#nullable enable

namespace G
{
    public partial interface IManualEvaluationClient
    {
        /// <summary>
        /// Manually evaluate spans<br/>
        /// Manually trigger evaluation rules on selected spans. Bypasses sampling and enqueues all specified spans for evaluation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ManualEvaluationResponse> EvaluateSpansAsync(

            global::G.ManualEvaluationRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Manually evaluate spans<br/>
        /// Manually trigger evaluation rules on selected spans. Bypasses sampling and enqueues all specified spans for evaluation.
        /// </summary>
        /// <param name="projectId">
        /// Project ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="entityIds">
        /// List of entity IDs (trace IDs or thread IDs) to evaluate<br/>
        /// Example: [550e8400-e29b-41d4-a716-446655440000, 550e8400-e29b-41d4-a716-446655440001]
        /// </param>
        /// <param name="ruleIds">
        /// List of automation rule IDs to apply<br/>
        /// Example: [660e8400-e29b-41d4-a716-446655440000]
        /// </param>
        /// <param name="entityType">
        /// Type of entity to evaluate (trace or thread)<br/>
        /// Example: trace
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ManualEvaluationResponse> EvaluateSpansAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> entityIds,
            global::System.Collections.Generic.IList<global::System.Guid> ruleIds,
            global::G.ManualEvaluationRequestEntityType entityType,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}