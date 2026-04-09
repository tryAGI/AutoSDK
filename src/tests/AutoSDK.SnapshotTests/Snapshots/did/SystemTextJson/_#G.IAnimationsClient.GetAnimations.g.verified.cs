//HintName: G.IAnimationsClient.GetAnimations.g.cs
#nullable enable

namespace G
{
    public partial interface IAnimationsClient
    {
        /// <summary>
        /// Get animations
        /// </summary>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.GetAnimationsResponse> GetAnimationsAsync(
            double? limit = default,
            string? token = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}