//HintName: G.IRateLimitsPoliciesClient.DeleteRateLimitsPolicy.g.cs
#nullable enable

namespace G
{
    public partial interface IRateLimitsPoliciesClient
    {
        /// <summary>
        /// Delete Rate Limits Policy<br/>
        /// Delete a rate limits policy.
        /// </summary>
        /// <param name="rateLimitsPolicyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRateLimitsPolicyAsync(
            global::System.Guid rateLimitsPolicyId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Rate Limits Policy<br/>
        /// Delete a rate limits policy.
        /// </summary>
        /// <param name="rateLimitsPolicyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<string>> DeleteRateLimitsPolicyAsResponseAsync(
            global::System.Guid rateLimitsPolicyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}