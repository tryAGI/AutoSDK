//HintName: G.IUsageLimitsPoliciesClient.ListUsageLimitsPolicyEntities.g.cs
#nullable enable

namespace G
{
    public partial interface IUsageLimitsPoliciesClient
    {
        /// <summary>
        /// List Usage Limits Policy Entities<br/>
        /// List entities tracked by a usage limits policy with their current usage.
        /// </summary>
        /// <param name="policyUsageLimitsId"></param>
        /// <param name="status"></param>
        /// <param name="search"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UsageLimitsPolicyEntityListResponse> ListUsageLimitsPolicyEntitiesAsync(
            global::System.Guid policyUsageLimitsId,
            global::G.ListUsageLimitsPolicyEntitiesStatus? status = default,
            string? search = default,
            int? pageSize = default,
            int? currentPage = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}