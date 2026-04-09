//HintName: G.IHeliconeSqlClient.UpdateSavedQuery.g.cs
#nullable enable

namespace G
{
    public partial interface IHeliconeSqlClient
    {
        /// <summary>
        /// Update saved query<br/>
        /// Update an existing saved query
        /// </summary>
        /// <param name="queryId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultHqlSavedQueryString> UpdateSavedQueryAsync(
            string queryId,

            global::G.CreateSavedQueryRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update saved query<br/>
        /// Update an existing saved query
        /// </summary>
        /// <param name="queryId"></param>
        /// <param name="name"></param>
        /// <param name="sql"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultHqlSavedQueryString> UpdateSavedQueryAsync(
            string queryId,
            string name,
            string sql,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}