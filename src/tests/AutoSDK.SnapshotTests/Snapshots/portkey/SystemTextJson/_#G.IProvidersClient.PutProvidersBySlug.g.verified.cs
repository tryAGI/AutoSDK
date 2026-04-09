//HintName: G.IProvidersClient.PutProvidersBySlug.g.cs
#nullable enable

namespace G
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Update a Provider
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PutProvidersResponse> PutProvidersBySlugAsync(
            string slug,

            global::G.PutProvidersRequest request,
            string? workspaceId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Provider
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="note"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="expiresAt"></param>
        /// <param name="resetUsage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PutProvidersResponse> PutProvidersBySlugAsync(
            string slug,
            string? workspaceId = default,
            string? name = default,
            string? note = default,
            global::G.UsageLimits? usageLimits = default,
            global::G.RateLimits? rateLimits = default,
            global::System.DateTime? expiresAt = default,
            bool? resetUsage = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}