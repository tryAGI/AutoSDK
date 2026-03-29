//HintName: G.IStorageGcsClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageGcsClient
    {
        /// <summary>
        /// Get export storage<br/>
        /// Get a specific GCS export storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GCSExportStorage> GetAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}