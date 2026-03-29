//HintName: G.IDatasetStorageS3Client.ApiDatasetStoragesS3Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetStorageS3Client
    {
        /// <summary>
        /// Get import storage<br/>
        /// Get a specific S3 import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.S3DatasetStorage> ApiDatasetStoragesS3RetrieveAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}