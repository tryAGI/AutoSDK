//HintName: G.IApi.CreateNamespacesByNamespaceQuery.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Query, filter, full-text search and vector search documents.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueryResult> CreateNamespacesByNamespaceQueryAsync(
            string @namespace,

            global::G.AllOf<global::G.QueryConfig, global::G.Query> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query, filter, full-text search and vector search documents.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueryResult> CreateNamespacesByNamespaceQueryAsync(
            string @namespace,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}