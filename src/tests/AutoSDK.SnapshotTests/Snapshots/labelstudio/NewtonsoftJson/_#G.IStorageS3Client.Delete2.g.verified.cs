//HintName: G.IStorageS3Client.Delete2.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageS3Client
    {
        /// <summary>
        /// Delete import storage<br/>
        /// Delete a specific S3 import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete2Async(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}