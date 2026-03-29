//HintName: G.IRateLimitsPoliciesClient.CreateRateLimitsPolicy.g.cs
#nullable enable

namespace G
{
    public partial interface IRateLimitsPoliciesClient
    {
        /// <summary>
        /// Create Rate Limits Policy<br/>
        /// Create a new rate limits policy to control the rate of requests or tokens consumed per minute, hour, or day.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePolicyResponse> CreateRateLimitsPolicyAsync(

            global::G.CreateRateLimitsPolicyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Rate Limits Policy<br/>
        /// Create a new rate limits policy to control the rate of requests or tokens consumed per minute, hour, or day.
        /// </summary>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: 100 Requests per Minute
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
        /// <param name="unit">
        /// Rate unit:<br/>
        /// - `rpm` - Requests/Tokens per minute<br/>
        /// - `rph` - Requests/Tokens per hour<br/>
        /// - `rpd` - Requests/Tokens per day
        /// </param>
        /// <param name="value">
        /// Rate limit value
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID or slug. Required if not using API key authentication.
        /// </param>
        /// <param name="organisationId">
        /// Organization ID. Required if not using API key authentication.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePolicyResponse> CreateRateLimitsPolicyAsync(
            global::System.Collections.Generic.IList<global::G.Condition> conditions,
            global::System.Collections.Generic.IList<global::G.GroupBy> groupBy,
            global::G.CreateRateLimitsPolicyRequestType type,
            global::G.CreateRateLimitsPolicyRequestUnit unit,
            double value,
            string? name = default,
            string? workspaceId = default,
            global::System.Guid? organisationId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}