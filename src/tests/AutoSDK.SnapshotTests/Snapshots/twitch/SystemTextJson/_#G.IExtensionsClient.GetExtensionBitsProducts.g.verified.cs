//HintName: G.IExtensionsClient.GetExtensionBitsProducts.g.cs
#nullable enable

namespace G
{
    public partial interface IExtensionsClient
    {
        /// <summary>
        /// Gets the list of Bits products that belongs to the extension.<br/>
        /// Gets the list of Bits products that belongs to the extension. The client ID in the app access token identifies the extension.<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens). The client ID in the app access token must be the extension’s client ID.
        /// </summary>
        /// <param name="shouldIncludeAll"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetExtensionBitsProductsResponse> GetExtensionBitsProductsAsync(
            bool? shouldIncludeAll = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}