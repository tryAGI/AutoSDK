//HintName: G.IEmbeddingsClient.GetTotalStorageSize.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Get Embeddings Total Storage Size<br/>
        /// Get the total size of all embeddings in the database for a user in the storage unit given.
        /// </summary>
        /// <param name="storageUnit">
        /// Default Value: GB
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<double> GetTotalStorageSizeAsync(
            string? storageUnit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}