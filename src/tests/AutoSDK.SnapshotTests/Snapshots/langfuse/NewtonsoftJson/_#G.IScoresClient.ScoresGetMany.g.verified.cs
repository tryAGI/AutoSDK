//HintName: G.IScoresClient.ScoresGetMany.g.cs
#nullable enable

namespace G
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// Get a list of scores (supports both trace and session scores)
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="name"></param>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="environment"></param>
        /// <param name="source"></param>
        /// <param name="operator"></param>
        /// <param name="value"></param>
        /// <param name="scoreIds"></param>
        /// <param name="configId"></param>
        /// <param name="sessionId"></param>
        /// <param name="datasetRunId"></param>
        /// <param name="traceId"></param>
        /// <param name="observationId"></param>
        /// <param name="queueId"></param>
        /// <param name="dataType"></param>
        /// <param name="traceTags"></param>
        /// <param name="fields"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetScoresResponse> ScoresGetManyAsync(
            int? page = default,
            int? limit = default,
            string? userId = default,
            string? name = default,
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            global::System.Collections.Generic.IList<string>? environment = default,
            global::G.ScoreSource? source = default,
            string? @operator = default,
            double? value = default,
            string? scoreIds = default,
            string? configId = default,
            string? sessionId = default,
            string? datasetRunId = default,
            string? traceId = default,
            string? observationId = default,
            string? queueId = default,
            global::G.ScoreDataType? dataType = default,
            global::System.Collections.Generic.IList<string>? traceTags = default,
            string? fields = default,
            string? filter = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}