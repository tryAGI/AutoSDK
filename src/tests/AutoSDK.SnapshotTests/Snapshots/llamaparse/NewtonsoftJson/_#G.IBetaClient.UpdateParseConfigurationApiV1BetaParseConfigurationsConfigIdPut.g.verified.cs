//HintName: G.IBetaClient.UpdateParseConfigurationApiV1BetaParseConfigurationsConfigIdPut.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Update Parse Configuration<br/>
        /// Update a parse configuration.<br/>
        /// Args:<br/>
        ///     config_id: The ID of the parse configuration to update<br/>
        ///     config_update: Update data<br/>
        ///     project: Validated project from dependency<br/>
        ///     user: Current user<br/>
        ///     db: Database session<br/>
        /// Returns:<br/>
        ///     The updated parse configuration
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParseConfiguration> UpdateParseConfigurationApiV1BetaParseConfigurationsConfigIdPutAsync(
            string configId,

            global::G.ParseConfigurationUpdate request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Parse Configuration<br/>
        /// Update a parse configuration.<br/>
        /// Args:<br/>
        ///     config_id: The ID of the parse configuration to update<br/>
        ///     config_update: Update data<br/>
        ///     project: Validated project from dependency<br/>
        ///     user: Current user<br/>
        ///     db: Database session<br/>
        /// Returns:<br/>
        ///     The updated parse configuration
        /// </summary>
        /// <param name="configId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="parameters">
        /// Updated LlamaParseParameters configuration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParseConfiguration> UpdateParseConfigurationApiV1BetaParseConfigurationsConfigIdPutAsync(
            string configId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.LlamaParseParameters? parameters = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}