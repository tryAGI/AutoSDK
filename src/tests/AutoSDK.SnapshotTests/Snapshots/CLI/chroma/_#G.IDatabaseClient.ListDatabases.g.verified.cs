//HintName: G.IDatabaseClient.ListDatabases.g.cs
#nullable enable

namespace G
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// List databases<br/>
        /// Lists all databases for a tenant.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// chroma db list
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.VecItem>> ListDatabasesAsync(
            string tenant,
            int? limit = default,
            int? offset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}