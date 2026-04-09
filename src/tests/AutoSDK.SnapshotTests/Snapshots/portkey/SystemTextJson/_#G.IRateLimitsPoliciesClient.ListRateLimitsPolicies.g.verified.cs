//HintName: G.IRateLimitsPoliciesClient.ListRateLimitsPolicies.g.cs
#nullable enable

namespace G
{
    public partial interface IRateLimitsPoliciesClient
    {
        /// <summary>
        /// List Rate Limits Policies<br/>
        /// List all rate limits policies with optional filtering.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="type"></param>
        /// <param name="unit"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RateLimitsPolicyListResponse> ListRateLimitsPoliciesAsync(
            string? workspaceId = default,
            global::G.ListRateLimitsPoliciesStatus? status = default,
            global::G.ListRateLimitsPoliciesType? type = default,
            global::G.ListRateLimitsPoliciesUnit? unit = default,
            int? pageSize = default,
            int? currentPage = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}