//HintName: G.IDatasetStorageS3Client.ApiDatasetStoragesS3ColumnsRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetStorageS3Client
    {
        /// <summary>
        /// Get data column names from storage<br/>
        /// Retrieves column names from users JSON/blob data in bucket
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetStoragesS3ColumnsRetrieveAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}