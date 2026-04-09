//HintName: G.IApiStatusClient.ApiStatusGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApiStatusClient
    {
        /// <summary>
        /// API Status and Version
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.APIInfo> ApiStatusGetAsync(
            global::G.ApiStatusGetCartesiaVersion cartesiaVersion,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}