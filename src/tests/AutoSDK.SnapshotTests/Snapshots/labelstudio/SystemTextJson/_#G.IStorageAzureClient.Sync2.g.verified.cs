//HintName: G.IStorageAzureClient.Sync2.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageAzureClient
    {
        /// <summary>
        /// Sync export storage<br/>
        /// Sync tasks from an Azure export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AzureBlobExportStorage> Sync2Async(
            int id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}