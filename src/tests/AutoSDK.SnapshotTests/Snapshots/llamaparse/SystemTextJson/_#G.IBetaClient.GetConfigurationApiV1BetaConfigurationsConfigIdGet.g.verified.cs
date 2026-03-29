//HintName: G.IBetaClient.GetConfigurationApiV1BetaConfigurationsConfigIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Get Configuration<br/>
        /// Get a single product configuration by ID.
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConfigurationResponse> GetConfigurationApiV1BetaConfigurationsConfigIdGetAsync(
            string configId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}