//HintName: G.IStorageRedisClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageRedisClient
    {
        /// <summary>
        /// Get export storage<br/>
        /// Get a specific Redis export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RedisExportStorage> GetAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}