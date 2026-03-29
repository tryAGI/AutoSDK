//HintName: G.IStorageS3Client.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageS3Client
    {
        /// <summary>
        /// Get export storage<br/>
        /// Get a specific S3 export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.S3ExportStorage> GetAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}