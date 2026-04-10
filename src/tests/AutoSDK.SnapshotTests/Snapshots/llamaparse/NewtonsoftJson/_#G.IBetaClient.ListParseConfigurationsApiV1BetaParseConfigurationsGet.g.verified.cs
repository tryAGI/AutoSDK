//HintName: G.IBetaClient.ListParseConfigurationsApiV1BetaParseConfigurationsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Parse Configurations<br/>
        /// List parse configurations for the current project.<br/>
        /// Args:<br/>
        ///     project: Validated project from dependency<br/>
        ///     user: Current user<br/>
        ///     db: Database session<br/>
        ///     page_size: Number of items per page<br/>
        ///     page_token: Token for pagination<br/>
        ///     name: Filter by configuration name<br/>
        ///     creator: Filter by creator<br/>
        ///     version: Filter by version<br/>
        /// Returns:<br/>
        ///     Paginated response with parse configurations
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="name"></param>
        /// <param name="creator"></param>
        /// <param name="version"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParseConfigurationQueryResponse> ListParseConfigurationsApiV1BetaParseConfigurationsGetAsync(
            int? pageSize = default,
            string? pageToken = default,
            string? name = default,
            string? creator = default,
            string? version = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}