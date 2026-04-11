//HintName: G.IApiKeysClient.RevokeApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Revoke API key<br/>
        /// Revoke a specific API key by its ID.<br/>
        /// Args:<br/>
        ///     api_key_id: The ID of the API key to revoke.<br/>
        /// Returns:<br/>
        ///     ApiKey: The response containing the details of the revoked API key.
        /// </summary>
        /// <param name="apiKeyId">
        /// The ID of the API key to revoke
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> RevokeApiKeyAsync(
            global::System.Guid apiKeyId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}