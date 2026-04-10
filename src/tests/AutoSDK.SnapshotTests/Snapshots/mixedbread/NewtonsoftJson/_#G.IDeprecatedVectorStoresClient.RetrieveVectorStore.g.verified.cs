//HintName: G.IDeprecatedVectorStoresClient.RetrieveVectorStore.g.cs
#nullable enable

namespace G
{
    public partial interface IDeprecatedVectorStoresClient
    {
        /// <summary>
        /// [DEPRECATED] Get a vector store<br/>
        /// DEPRECATED: Use GET /stores/{store_identifier} instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.VectorStore> RetrieveVectorStoreAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}