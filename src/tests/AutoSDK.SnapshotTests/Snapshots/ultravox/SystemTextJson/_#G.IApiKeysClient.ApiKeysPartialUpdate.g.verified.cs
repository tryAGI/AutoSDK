//HintName: G.IApiKeysClient.ApiKeysPartialUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Updates an API key.
        /// </summary>
        /// <param name="apiKeyPrefix"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.APIKey> ApiKeysPartialUpdateAsync(
            string apiKeyPrefix,
            global::G.PatchedAPIKey request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an API key.
        /// </summary>
        /// <param name="apiKeyPrefix"></param>
        /// <param name="revoked">
        /// If the API key is revoked, clients cannot use it anymore. (This cannot be undone.)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.APIKey> ApiKeysPartialUpdateAsync(
            string apiKeyPrefix,
            bool? revoked = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}