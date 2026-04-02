//HintName: G.IRateLimitsPoliciesClient.UpdateRateLimitsPolicy.g.cs
#nullable enable

namespace G
{
    public partial interface IRateLimitsPoliciesClient
    {
        /// <summary>
        /// Update Rate Limits Policy<br/>
        /// Update an existing rate limits policy.
        /// </summary>
        /// <param name="rateLimitsPolicyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateRateLimitsPolicyAsync(
            global::System.Guid rateLimitsPolicyId,

            global::G.UpdateRateLimitsPolicyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Rate Limits Policy<br/>
        /// Update an existing rate limits policy.
        /// </summary>
        /// <param name="rateLimitsPolicyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<string>> UpdateRateLimitsPolicyAsResponseAsync(
            global::System.Guid rateLimitsPolicyId,

            global::G.UpdateRateLimitsPolicyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Rate Limits Policy<br/>
        /// Update an existing rate limits policy.
        /// </summary>
        /// <param name="rateLimitsPolicyId"></param>
        /// <param name="name">
        /// Policy name
        /// </param>
        /// <param name="unit">
        /// Rate unit
        /// </param>
        /// <param name="value">
        /// Rate limit value
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateRateLimitsPolicyAsync(
            global::System.Guid rateLimitsPolicyId,
            string? name = default,
            global::G.UpdateRateLimitsPolicyRequestUnit? unit = default,
            double? value = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}