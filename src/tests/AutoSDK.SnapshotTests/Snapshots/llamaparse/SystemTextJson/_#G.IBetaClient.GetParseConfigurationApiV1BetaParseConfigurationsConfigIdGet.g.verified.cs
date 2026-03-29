//HintName: G.IBetaClient.GetParseConfigurationApiV1BetaParseConfigurationsConfigIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Get Parse Configuration<br/>
        /// Get a parse configuration by ID.<br/>
        /// Args:<br/>
        ///     config_id: The ID of the parse configuration<br/>
        ///     project: Validated project from dependency<br/>
        ///     user: Current user<br/>
        ///     db: Database session<br/>
        /// Returns:<br/>
        ///     The parse configuration
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParseConfiguration> GetParseConfigurationApiV1BetaParseConfigurationsConfigIdGetAsync(
            string configId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}