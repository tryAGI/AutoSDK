//HintName: G.IStorageRedisClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageRedisClient
    {
        /// <summary>
        /// Create export storage<br/>
        /// Create a new Redis export storage connection to store annotations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RedisExportStorage> CreateAsync(

            global::G.ApiStoragesExportRedisCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create export storage<br/>
        /// Create a new Redis export storage connection to store annotations.
        /// </summary>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="db">
        /// Database ID of database to use
        /// </param>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="host">
        /// Server Host IP (optional)
        /// </param>
        /// <param name="password">
        /// Server Password (optional)
        /// </param>
        /// <param name="path">
        /// Storage prefix (optional)
        /// </param>
        /// <param name="port">
        /// Server Port (optional)
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="title">
        /// Storage title
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RedisExportStorage> CreateAsync(
            bool? canDeleteObjects = default,
            int? db = default,
            string? description = default,
            string? host = default,
            string? password = default,
            string? path = default,
            string? port = default,
            int? project = default,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}