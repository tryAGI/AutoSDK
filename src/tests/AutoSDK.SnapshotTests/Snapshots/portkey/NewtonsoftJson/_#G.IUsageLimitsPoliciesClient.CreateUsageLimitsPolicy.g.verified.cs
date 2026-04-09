//HintName: G.IUsageLimitsPoliciesClient.CreateUsageLimitsPolicy.g.cs
#nullable enable

namespace G
{
    public partial interface IUsageLimitsPoliciesClient
    {
        /// <summary>
        /// Create Usage Limits Policy<br/>
        /// Create a new usage limits policy to control total usage (cost or tokens) over a period.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePolicyResponse> CreateUsageLimitsPolicyAsync(

            global::G.CreateUsageLimitsPolicyRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Usage Limits Policy<br/>
        /// Create a new usage limits policy to control total usage (cost or tokens) over a period.
        /// </summary>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: Monthly Cost Limit
        /// </param>
        /// <param name="conditions">
        /// Array of conditions that define which requests the policy applies to
        /// </param>
        /// <param name="groupBy">
        /// Array of group by fields that define how usage is aggregated
        /// </param>
        /// <param name="type">
        /// Policy type
        /// </param>
        /// <param name="creditLimit">
        /// Maximum usage allowed
        /// </param>
        /// <param name="alertThreshold">
        /// Threshold at which to send alerts. Must be less than credit_limit.
        /// </param>
        /// <param name="periodicReset">
        /// Reset period. If not provided, limit is cumulative.
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID or slug. Required if not using API key authentication.
        /// </param>
        /// <param name="organisationId">
        /// Organization ID. Required if not using API key authentication.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePolicyResponse> CreateUsageLimitsPolicyAsync(
            global::System.Collections.Generic.IList<global::G.Condition> conditions,
            global::System.Collections.Generic.IList<global::G.GroupBy> groupBy,
            global::G.CreateUsageLimitsPolicyRequestType type,
            double creditLimit,
            string? name = default,
            double? alertThreshold = default,
            global::G.CreateUsageLimitsPolicyRequestPeriodicReset? periodicReset = default,
            string? workspaceId = default,
            global::System.Guid? organisationId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}