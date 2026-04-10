//HintName: G.IUsageLimitsPoliciesClient.UpdateUsageLimitsPolicy.g.cs
#nullable enable

namespace G
{
    public partial interface IUsageLimitsPoliciesClient
    {
        /// <summary>
        /// Update Usage Limits Policy<br/>
        /// Update an existing usage limits policy.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUsageLimitsPolicyAsync(
            global::System.Guid policyUsageLimitsId,

            global::G.UpdateUsageLimitsPolicyRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Usage Limits Policy<br/>
        /// Update an existing usage limits policy.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<string>> UpdateUsageLimitsPolicyAsResponseAsync(
            global::System.Guid policyUsageLimitsId,

            global::G.UpdateUsageLimitsPolicyRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Usage Limits Policy<br/>
        /// Update an existing usage limits policy.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="name">
        /// Policy name
        /// </param>
        /// <param name="creditLimit">
        /// Maximum usage allowed
        /// </param>
        /// <param name="alertThreshold">
        /// Threshold at which to send alerts. Must be less than credit_limit.
        /// </param>
        /// <param name="periodicReset">
        /// Reset period. Set to null to remove periodic reset.
        /// </param>
        /// <param name="resetUsageForValue">
        /// Reset usage for a specific value key (e.g., API key). This will reset the usage counter for that key to 0.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUsageLimitsPolicyAsync(
            global::System.Guid policyUsageLimitsId,
            string? name = default,
            double? creditLimit = default,
            double? alertThreshold = default,
            global::G.UpdateUsageLimitsPolicyRequestPeriodicReset? periodicReset = default,
            string? resetUsageForValue = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}