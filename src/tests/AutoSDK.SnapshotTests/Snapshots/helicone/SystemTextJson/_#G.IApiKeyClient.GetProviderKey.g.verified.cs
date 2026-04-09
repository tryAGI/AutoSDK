//HintName: G.IApiKeyClient.GetProviderKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="providerKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.DecryptedProviderKey, global::G.GetProviderKeyResponse2>> GetProviderKeyAsync(
            string providerKeyId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}