//HintName: G.IApiKeyClient.CreateProxyKey.g.cs
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
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.CreateProxyKeyResponseVariant1, global::G.CreateProxyKeyResponseVariant2>> CreateProxyKeyAsync(

            global::G.CreateProxyKeyRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="proxyKeyName"></param>
        /// <param name="providerKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.CreateProxyKeyResponseVariant1, global::G.CreateProxyKeyResponseVariant2>> CreateProxyKeyAsync(
            string proxyKeyName,
            string providerKeyId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}