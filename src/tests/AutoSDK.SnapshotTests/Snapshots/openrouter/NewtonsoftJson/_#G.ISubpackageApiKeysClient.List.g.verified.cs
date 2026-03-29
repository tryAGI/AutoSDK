//HintName: G.ISubpackageApiKeysClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageApiKeysClient
    {
        /// <summary>
        /// List API keys<br/>
        /// List all API keys for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="includeDisabled"></param>
        /// <param name="offset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeysListResponse200> ListAsync(
            string? includeDisabled = default,
            string? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}