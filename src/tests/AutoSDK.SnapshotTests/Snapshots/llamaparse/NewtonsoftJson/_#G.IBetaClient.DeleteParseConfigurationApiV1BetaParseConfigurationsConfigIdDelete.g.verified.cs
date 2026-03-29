//HintName: G.IBetaClient.DeleteParseConfigurationApiV1BetaParseConfigurationsConfigIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Delete Parse Configuration<br/>
        /// Delete a parse configuration.<br/>
        /// Args:<br/>
        ///     config_id: The ID of the parse configuration to delete<br/>
        ///     project: Validated project from dependency<br/>
        ///     user: Current user<br/>
        ///     db: Database session
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteParseConfigurationApiV1BetaParseConfigurationsConfigIdDeleteAsync(
            string configId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}