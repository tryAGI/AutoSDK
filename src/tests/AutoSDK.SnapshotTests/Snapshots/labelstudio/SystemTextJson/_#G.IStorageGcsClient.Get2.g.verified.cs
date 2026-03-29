//HintName: G.IStorageGcsClient.Get2.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageGcsClient
    {
        /// <summary>
        /// Get import storage<br/>
        /// Get a specific GCS import storage connection.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GCSImportStorage> Get2Async(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}