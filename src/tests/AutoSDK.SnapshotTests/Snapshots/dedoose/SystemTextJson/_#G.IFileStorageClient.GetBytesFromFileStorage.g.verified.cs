//HintName: G.IFileStorageClient.GetBytesFromFileStorage.g.cs
#nullable enable

namespace G
{
    public partial interface IFileStorageClient
    {
        /// <summary>
        /// Get File Bytes<br/>
        /// Retrieves file data from the storage system based on the specified data path.
        /// </summary>
        /// <param name="dataPath"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetBytesFromFileStorageAsync(
            string dataPath,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}