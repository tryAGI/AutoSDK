//HintName: G.IApiKeyClient.DeleteAPIKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.DeleteAPIKeyResponseVariant1, global::G.DeleteAPIKeyResponseVariant2>> DeleteAPIKeyAsync(
            double apiKeyId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}