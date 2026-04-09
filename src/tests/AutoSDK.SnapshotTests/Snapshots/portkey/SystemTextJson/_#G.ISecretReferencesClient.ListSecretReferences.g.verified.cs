//HintName: G.ISecretReferencesClient.ListSecretReferences.g.cs
#nullable enable

namespace G
{
    public partial interface ISecretReferencesClient
    {
        /// <summary>
        /// List All Secret References
        /// </summary>
        /// <param name="managerType"></param>
        /// <param name="tags"></param>
        /// <param name="search"></param>
        /// <param name="currentPage">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListSecretReferencesResponse> ListSecretReferencesAsync(
            global::G.ListSecretReferencesManagerType? managerType = default,
            string? tags = default,
            string? search = default,
            int? currentPage = default,
            int? pageSize = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}