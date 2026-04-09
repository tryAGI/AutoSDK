//HintName: G.IApiKeyClient.UpdateAPIKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.UpdateAPIKeyResponseVariant1, global::G.UpdateAPIKeyResponseVariant2>> UpdateAPIKeyAsync(
            double apiKeyId,

            global::G.UpdateAPIKeyRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="apiKeyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.UpdateAPIKeyResponseVariant1, global::G.UpdateAPIKeyResponseVariant2>> UpdateAPIKeyAsync(
            double apiKeyId,
            string apiKeyName,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}