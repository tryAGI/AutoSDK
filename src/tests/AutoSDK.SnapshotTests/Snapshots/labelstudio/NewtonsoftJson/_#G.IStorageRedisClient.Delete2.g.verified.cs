//HintName: G.IStorageRedisClient.Delete2.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageRedisClient
    {
        /// <summary>
        /// Delete import storage<br/>
        /// Delete a specific Redis import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete2Async(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}