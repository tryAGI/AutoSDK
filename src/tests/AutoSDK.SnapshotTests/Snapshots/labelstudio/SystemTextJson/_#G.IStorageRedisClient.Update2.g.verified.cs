//HintName: G.IStorageRedisClient.Update2.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageRedisClient
    {
        /// <summary>
        /// Update import storage<br/>
        /// Update a specific Redis import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RedisImportStorage> Update2Async(
            int id,

            global::G.ApiStoragesRedisPartialUpdateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update import storage<br/>
        /// Update a specific Redis import storage connection.
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="regexFilter">
        /// Cloud storage regex for filtering objects. You must specify it otherwise no objects will be imported.
        /// </param>
        /// <param name="title">
        /// Storage title
        /// </param>
        /// <param name="useBlobUrls">
        /// Interpret objects as BLOBs and generate URLs. For example, if your bucket contains images, you can use this option to generate URLs for these images. If set to False, it will read the content of the file and load it into Label Studio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RedisImportStorage> Update2Async(
            int id,
            string? description = default,
            string? host = default,
            string? password = default,
            string? path = default,
            string? port = default,
            int? project = default,
            string? regexFilter = default,
            string? title = default,
            bool? useBlobUrls = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}