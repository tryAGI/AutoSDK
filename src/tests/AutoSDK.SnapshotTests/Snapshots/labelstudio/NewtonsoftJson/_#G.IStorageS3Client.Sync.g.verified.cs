//HintName: G.IStorageS3Client.Sync.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageS3Client
    {
        /// <summary>
        /// Sync export storage<br/>
        /// Sync tasks from an S3 export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.S3ExportStorage> SyncAsync(
            int id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}