//HintName: G.IDatasetStorageGcsClient.ApiDatasetStoragesGcsRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetStorageGcsClient
    {
        /// <summary>
        /// Get import storage<br/>
        /// Get a specific GCS import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GCSDatasetStorage> ApiDatasetStoragesGcsRetrieveAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}