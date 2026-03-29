//HintName: G.IStorageAzureClient.Sync.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageAzureClient
    {
        /// <summary>
        /// Sync import storage<br/>
        /// Sync tasks from an Azure import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AzureBlobImportStorage> SyncAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}