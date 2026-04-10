//HintName: G.IDatabaseClient.CreateDatabase.g.cs
#nullable enable

namespace G
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Create database<br/>
        /// Creates a new database for a tenant.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// chroma db create my-new-db
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.CreateDatabaseResponse> CreateDatabaseAsync(
            string tenant,

            global::G.CreateDatabasePayload request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create database<br/>
        /// Creates a new database for a tenant.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDatabaseResponse> CreateDatabaseAsync(
            string tenant,
            string name,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}