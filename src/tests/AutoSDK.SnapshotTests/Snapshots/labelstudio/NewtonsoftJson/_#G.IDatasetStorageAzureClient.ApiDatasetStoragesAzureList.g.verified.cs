//HintName: G.IDatasetStorageAzureClient.ApiDatasetStoragesAzureList.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetStorageAzureClient
    {
        /// <summary>
        /// Get all import storage<br/>
        /// Get a list of all Azure import storage connections.
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AzureDatasetStorage>> ApiDatasetStoragesAzureListAsync(
            int? dataset = default,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}