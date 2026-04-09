//HintName: G.IApiKeyClient.CreateAPIKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.CreateAPIKeyResponseVariant1, global::G.CreateAPIKeyResponseVariant2>> CreateAPIKeyAsync(

            global::G.CreateAPIKeyRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyPermissions"></param>
        /// <param name="apiKeyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.CreateAPIKeyResponseVariant1, global::G.CreateAPIKeyResponseVariant2>> CreateAPIKeyAsync(
            string apiKeyName,
            global::G.CreateAPIKeyRequestKeyPermissions? keyPermissions = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}