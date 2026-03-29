//HintName: G.IQueryHistoryClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IQueryHistoryClient
    {
        /// <summary>
        /// List the history of previous queries<br/>
        /// The List Query Histories API allows you to retrieve, update, and manage query history for a specific corpus. This API is particularly useful for tracking query performance, debugging individual queries, and retrieving detailed information such as the call stack of a query execution.<br/>
        /// You can specify the `corpus_key`, `chat_id`, and the `limit` which is the maximum number of historical queries to list.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey"></param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="chatId"></param>
        /// <param name="historyId"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListQueryHistoriesResponse> ListAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? corpusKey = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            string? chatId = default,
            string? historyId = default,
            int? limit = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}