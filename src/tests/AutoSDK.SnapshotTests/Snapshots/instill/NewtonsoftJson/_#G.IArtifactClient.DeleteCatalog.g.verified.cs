//HintName: G.IArtifactClient.DeleteCatalog.g.cs
#nullable enable

namespace G
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Delete a catalog<br/>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteCatalogResponse> DeleteCatalogAsync(
            string namespaceId,
            string catalogId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}