//HintName: G.IApiKeysClient.DeleteKeysByApiKeyID.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Delete a team API key
        /// </summary>
        /// <param name="apiKeyID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteKeysByApiKeyIDAsync(
            string apiKeyID,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}