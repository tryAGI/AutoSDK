//HintName: G.IProvidersClient.CreateProviders.g.cs
#nullable enable

namespace G
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Create a Provider
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateProvidersResponse> CreateProvidersAsync(

            global::G.CreateProvidersRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Provider
        /// </summary>
        /// <param name="name"></param>
        /// <param name="integrationId">
        /// Integration slug used for the provider creation.
        /// </param>
        /// <param name="workspaceId">
        /// optional, needed when using organisation admin API keys
        /// </param>
        /// <param name="slug">
        /// Slug for the provider. If not passed, slug will be created by adding a random suffix to the name.
        /// </param>
        /// <param name="note"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="expiresAt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateProvidersResponse> CreateProvidersAsync(
            string name,
            string integrationId,
            global::System.Guid? workspaceId = default,
            string? slug = default,
            string? note = default,
            global::G.UsageLimits? usageLimits = default,
            global::G.RateLimits? rateLimits = default,
            global::System.DateTime? expiresAt = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}