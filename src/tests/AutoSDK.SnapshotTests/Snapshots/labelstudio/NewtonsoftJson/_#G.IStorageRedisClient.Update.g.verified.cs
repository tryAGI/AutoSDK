//HintName: G.IStorageRedisClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageRedisClient
    {
        /// <summary>
        /// Update export storage<br/>
        /// Update a specific Redis export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RedisExportStorage> UpdateAsync(
            int id,

            global::G.ApiStoragesExportRedisPartialUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update export storage<br/>
        /// Update a specific Redis export storage connection.
        /// </summary>
        /// <param name="id"></param>
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
        global::System.Threading.Tasks.Task<global::G.RedisExportStorage> UpdateAsync(
            int id,
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