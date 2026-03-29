//HintName: G.IStorageRedisClient.Sync2.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageRedisClient
    {
        /// <summary>
        /// Sync import storage<br/>
        /// Sync tasks from a Redis import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RedisImportStorage> Sync2Async(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}