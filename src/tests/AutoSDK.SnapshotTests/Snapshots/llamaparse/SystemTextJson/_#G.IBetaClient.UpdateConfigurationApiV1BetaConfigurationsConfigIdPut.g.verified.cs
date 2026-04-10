//HintName: G.IBetaClient.UpdateConfigurationApiV1BetaConfigurationsConfigIdPut.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Update Configuration<br/>
        /// Update an existing product configuration.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConfigurationResponse> UpdateConfigurationApiV1BetaConfigurationsConfigIdPutAsync(
            string configId,

            global::G.ConfigurationUpdateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Configuration<br/>
        /// Update an existing product configuration.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// Updated name (omit to leave unchanged).
        /// </param>
        /// <param name="parameters">
        /// Updated parameters (omit to leave unchanged).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConfigurationResponse> UpdateConfigurationApiV1BetaConfigurationsConfigIdPutAsync(
            string configId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? name = default,
            global::G.ParametersVariant1? parameters = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}