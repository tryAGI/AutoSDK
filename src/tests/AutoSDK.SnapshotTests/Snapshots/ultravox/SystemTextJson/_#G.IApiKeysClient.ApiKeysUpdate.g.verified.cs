//HintName: G.IApiKeysClient.ApiKeysUpdate.g.cs
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.APIKey> ApiKeysUpdateAsync(
            string apiKeyPrefix,

            global::G.APIKey request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an API key.
        /// </summary>
        /// <param name="apiKeyPrefix"></param>
        /// <param name="revoked">
        /// If the API key is revoked, clients cannot use it anymore. (This cannot be undone.)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.APIKey> ApiKeysUpdateAsync(
            string apiKeyPrefix,
            bool? revoked = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}