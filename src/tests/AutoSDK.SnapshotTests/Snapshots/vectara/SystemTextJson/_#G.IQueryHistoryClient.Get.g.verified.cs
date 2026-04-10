//HintName: G.IQueryHistoryClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IQueryHistoryClient
    {
        /// <summary>
        /// Get a query history<br/>
        /// The Get Query History API allows you to retrieve detailed history about a specific query that was made against a corpus. The response includes detailed information about the query, such as latency, the time it was executed, and the various stages in the query pipeline.<br/>
        /// You specify the `query_id` and the response includes the `id` of the query, the `query` object, the `chat_id`, the time information about the query, and the `spans` object.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="queryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueryHistory> GetAsync(
            string queryId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}