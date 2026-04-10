//HintName: G.IBetaClient.CreateConfigurationApiV1BetaConfigurationsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Create Configuration<br/>
        /// Create or update a product configuration.<br/>
        /// If a configuration with the same name already exists for this product<br/>
        /// type and project, it will be updated (upsert semantics).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConfigurationResponse> CreateConfigurationApiV1BetaConfigurationsPostAsync(

            global::G.ConfigurationCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Configuration<br/>
        /// Create or update a product configuration.<br/>
        /// If a configuration with the same name already exists for this product<br/>
        /// type and project, it will be updated (upsert semantics).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// Human-readable name for this configuration.
        /// </param>
        /// <param name="parameters">
        /// Product-specific configuration parameters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConfigurationResponse> CreateConfigurationApiV1BetaConfigurationsPostAsync(
            string name,
            global::G.Parameters parameters,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}