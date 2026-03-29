//HintName: G.IDataSourcesClient.AuthorizeDataSource.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Authorize a data source<br/>
        /// Start OAuth2 authorization flow for a data source.<br/>
        /// Initiates the OAuth2 authorization process by redirecting the user<br/>
        /// to the external service's authorization page. After authorization,<br/>
        /// the user will be redirected back to the oauth2_callback endpoint.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to authorize<br/>
        /// Returns:<br/>
        ///     Redirect to the OAuth2 provider's authorization page<br/>
        /// Raises:<br/>
        ///     DataSourceNotFoundError: When data source doesn't exist<br/>
        ///     DataSourceAuthTypeNotSupportedError: When OAuth2 is not supported for this data source type
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to authorize
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AuthorizeDataSourceAsync(
            global::System.Guid dataSourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}