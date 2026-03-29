//HintName: G.ISubpackageApiKeysClient.GetKey.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageApiKeysClient
    {
        /// <summary>
        /// Get a single API key<br/>
        /// Get a single API key by hash. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeysGetKeyResponse200> GetKeyAsync(
            string hash,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}