//HintName: G.ITraceClient.TraceList.g.cs
#nullable enable

namespace G
{
    public partial interface ITraceClient
    {
        /// <summary>
        /// Get list of traces
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="name"></param>
        /// <param name="sessionId"></param>
        /// <param name="fromTimestamp"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="orderBy"></param>
        /// <param name="tags"></param>
        /// <param name="version"></param>
        /// <param name="release"></param>
        /// <param name="environment"></param>
        /// <param name="fields"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Traces> TraceListAsync(
            int? page = default,
            int? limit = default,
            string? userId = default,
            string? name = default,
            string? sessionId = default,
            global::System.DateTime? fromTimestamp = default,
            global::System.DateTime? toTimestamp = default,
            string? orderBy = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? version = default,
            string? release = default,
            global::System.Collections.Generic.IList<string>? environment = default,
            string? fields = default,
            string? filter = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}