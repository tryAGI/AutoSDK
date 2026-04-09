//HintName: G.IStorageRedisClient.Sync.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageRedisClient
    {
        /// <summary>
        /// Sync export storage<br/>
        /// Sync tasks from a Redis export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RedisExportStorage> SyncAsync(
            int id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}