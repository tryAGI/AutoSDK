//HintName: G.IDatasetStorageAzureClient.ApiDatasetStoragesAzureRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetStorageAzureClient
    {
        /// <summary>
        /// Get import storage<br/>
        /// Get a specific Azure import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AzureDatasetStorage> ApiDatasetStoragesAzureRetrieveAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}