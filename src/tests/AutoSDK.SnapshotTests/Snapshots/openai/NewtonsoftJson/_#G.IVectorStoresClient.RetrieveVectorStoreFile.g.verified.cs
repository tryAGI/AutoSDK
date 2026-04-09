//HintName: G.IVectorStoresClient.RetrieveVectorStoreFile.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Retrieves a vector store file.
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="fileId">
        /// Example: file-abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorStoreFileObject> RetrieveVectorStoreFileAsync(
            string vectorStoreId,
            string fileId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}