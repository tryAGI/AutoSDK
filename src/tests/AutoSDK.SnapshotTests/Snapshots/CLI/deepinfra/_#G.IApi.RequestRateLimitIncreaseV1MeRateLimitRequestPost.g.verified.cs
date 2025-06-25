//HintName: G.IApi.RequestRateLimitIncreaseV1MeRateLimitRequestPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Request Rate Limit Increase
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RequestRateLimitIncreaseV1MeRateLimitRequestPostAsync(
            global::G.RateLimitRequestIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Request Rate Limit Increase
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="rateLimit"></param>
        /// <param name="reason"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RequestRateLimitIncreaseV1MeRateLimitRequestPostAsync(
            int rateLimit,
            string reason,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}