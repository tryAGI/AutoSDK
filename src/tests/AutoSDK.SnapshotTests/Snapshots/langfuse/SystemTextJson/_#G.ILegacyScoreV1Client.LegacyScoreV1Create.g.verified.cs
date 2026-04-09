//HintName: G.ILegacyScoreV1Client.LegacyScoreV1Create.g.cs
#nullable enable

namespace G
{
    public partial interface ILegacyScoreV1Client
    {
        /// <summary>
        /// Create a score (supports both trace and session scores)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LegacyCreateScoreResponse> LegacyScoreV1CreateAsync(

            global::G.LegacyCreateScoreRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a score (supports both trace and session scores)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="traceId"></param>
        /// <param name="sessionId"></param>
        /// <param name="observationId"></param>
        /// <param name="datasetRunId"></param>
        /// <param name="name">
        /// Example: novelty
        /// </param>
        /// <param name="value">
        /// The value of the score. Must be passed as string for categorical scores, and numeric for boolean and numeric scores
        /// </param>
        /// <param name="comment"></param>
        /// <param name="metadata"></param>
        /// <param name="environment">
        /// The environment of the score. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
        /// </param>
        /// <param name="queueId">
        /// The annotation queue referenced by the score. Indicates if score was initially created while processing annotation queue.
        /// </param>
        /// <param name="dataType"></param>
        /// <param name="configId">
        /// Reference a score config on a score. The unique langfuse identifier of a score config. When passing this field, the dataType and stringValue fields are automatically populated.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LegacyCreateScoreResponse> LegacyScoreV1CreateAsync(
            string name,
            global::G.CreateScoreValue value,
            string? id = default,
            string? traceId = default,
            string? sessionId = default,
            string? observationId = default,
            string? datasetRunId = default,
            string? comment = default,
            object? metadata = default,
            string? environment = default,
            string? queueId = default,
            global::G.ScoreDataType? dataType = default,
            string? configId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}