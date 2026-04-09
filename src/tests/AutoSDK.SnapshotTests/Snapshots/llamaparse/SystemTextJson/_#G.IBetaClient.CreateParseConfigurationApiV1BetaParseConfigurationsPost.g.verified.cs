//HintName: G.IBetaClient.CreateParseConfigurationApiV1BetaParseConfigurationsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Create Parse Configuration<br/>
        /// Create a new parse configuration.<br/>
        /// Args:<br/>
        ///     config_create: Parse configuration creation data<br/>
        ///     project: Validated project from dependency<br/>
        ///     user: Current user<br/>
        ///     db: Database session<br/>
        /// Returns:<br/>
        ///     The created parse configuration
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParseConfiguration> CreateParseConfigurationApiV1BetaParseConfigurationsPostAsync(

            global::G.ParseConfigurationCreate request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Parse Configuration<br/>
        /// Create a new parse configuration.<br/>
        /// Args:<br/>
        ///     config_create: Parse configuration creation data<br/>
        ///     project: Validated project from dependency<br/>
        ///     user: Current user<br/>
        ///     db: Database session<br/>
        /// Returns:<br/>
        ///     The created parse configuration
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// Name of the parse configuration
        /// </param>
        /// <param name="sourceType">
        /// Type of the source (e.g., 'project')
        /// </param>
        /// <param name="sourceId">
        /// ID of the source
        /// </param>
        /// <param name="creator">
        /// Creator of the configuration
        /// </param>
        /// <param name="version">
        /// Version of the configuration
        /// </param>
        /// <param name="parameters">
        /// LlamaParseParameters configuration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParseConfiguration> CreateParseConfigurationApiV1BetaParseConfigurationsPostAsync(
            string name,
            string version,
            global::G.LlamaParseParameters parameters,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? sourceType = default,
            string? sourceId = default,
            string? creator = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}