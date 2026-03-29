//HintName: G.IEvaluatorsClient.UpsertEvaluator.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Upsert Evaluator
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluatorResponse> UpsertEvaluatorAsync(

            global::G.EvaluatorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Evaluator
        /// </summary>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="spec">
        /// The evaluator specification.
        /// </param>
        /// <param name="attributes"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="readme"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluatorResponse> UpsertEvaluatorAsync(
            string? path = default,
            string? id = default,
            object? spec = default,
            object? attributes = default,
            string? versionName = default,
            string? versionDescription = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? readme = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}