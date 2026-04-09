//HintName: G.IClipsPremiumAvatarsClient.GetPresenters.g.cs
#nullable enable

namespace G
{
    public partial interface IClipsPremiumAvatarsClient
    {
        /// <summary>
        /// Get a list of the presenters
        /// </summary>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPresentersResponse> GetPresentersAsync(
            double? limit = default,
            string? token = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}