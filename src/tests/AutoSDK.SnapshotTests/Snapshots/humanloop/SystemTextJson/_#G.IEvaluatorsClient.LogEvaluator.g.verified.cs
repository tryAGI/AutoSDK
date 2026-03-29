//HintName: G.IEvaluatorsClient.LogEvaluator.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Log Evaluator
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateLogResponse> LogEvaluatorAsync(

            global::G.LogEvaluatorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Log Evaluator
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="parentId">
        /// The ID of the Log being evaluated.
        /// </param>
        /// <param name="source"></param>
        /// <param name="metadata"></param>
        /// <param name="save"></param>
        /// <param name="logId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateLogResponse> LogEvaluatorAsync(
            string? versionId = default,
            string? environment = default,
            string? path = default,
            string? id = default,
            string? parentId = default,
            string? source = default,
            object? metadata = default,
            bool? save = default,
            string? logId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}