//HintName: G.IDatasetStorageGcsClient.ApiDatasetStoragesGcsColumnsRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetStorageGcsClient
    {
        /// <summary>
        /// Get data column names from storage<br/>
        /// Retrieves column names from users JSON/blob data in bucket
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetStoragesGcsColumnsRetrieveAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}