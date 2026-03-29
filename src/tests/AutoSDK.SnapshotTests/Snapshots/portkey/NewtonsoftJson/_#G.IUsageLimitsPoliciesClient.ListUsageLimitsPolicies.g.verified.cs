//HintName: G.IUsageLimitsPoliciesClient.ListUsageLimitsPolicies.g.cs
#nullable enable

namespace G
{
    public partial interface IUsageLimitsPoliciesClient
    {
        /// <summary>
        /// List Usage Limits Policies<br/>
        /// List all usage limits policies with optional filtering.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UsageLimitsPolicyListResponse> ListUsageLimitsPoliciesAsync(
            string? workspaceId = default,
            global::G.ListUsageLimitsPoliciesStatus? status = default,
            global::G.ListUsageLimitsPoliciesType? type = default,
            int? pageSize = default,
            int? currentPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}