//HintName: G.IDatasetStorageS3Client.ApiDatasetStoragesS3Destroy.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetStorageS3Client
    {
        /// <summary>
        /// Delete import storage<br/>
        /// Delete a specific S3 import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetStoragesS3DestroyAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}