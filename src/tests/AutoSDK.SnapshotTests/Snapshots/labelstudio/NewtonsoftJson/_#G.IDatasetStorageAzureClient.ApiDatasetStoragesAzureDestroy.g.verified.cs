//HintName: G.IDatasetStorageAzureClient.ApiDatasetStoragesAzureDestroy.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetStorageAzureClient
    {
        /// <summary>
        /// Delete import storage<br/>
        /// Delete a specific Azure import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetStoragesAzureDestroyAsync(
            int id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}