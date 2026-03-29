//HintName: G.IDataSourcesClient.Oauth2Callback.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// OAuth2 callback for data source authorization<br/>
        /// OAuth2 callback endpoint for completing data source authorization.<br/>
        /// This endpoint is called by OAuth2 providers after user authorization.<br/>
        /// It exchanges the authorization code for access tokens and stores them<br/>
        /// securely for the data source.<br/>
        /// Args:<br/>
        ///     state: OAuth2 state parameter used for CSRF protection<br/>
        ///     code: Authorization code from the OAuth2 provider<br/>
        ///     error: OAuth2 error code if authorization was denied or failed<br/>
        ///     error_description: Human-readable description of the error<br/>
        /// Returns:<br/>
        ///     Redirect to the data source details page on success<br/>
        /// Raises:<br/>
        ///     OAuth2TokenExchangeError: When OAuth2 provider returns an error<br/>
        ///     InvalidStateError: When state parameter is invalid or expired
        /// </summary>
        /// <param name="state">
        /// OAuth2 state parameter for CSRF protection
        /// </param>
        /// <param name="code">
        /// Authorization code from OAuth2 provider
        /// </param>
        /// <param name="error">
        /// OAuth2 error code if authorization failed
        /// </param>
        /// <param name="errorDescription">
        /// Human-readable error description
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task Oauth2CallbackAsync(
            string state,
            string code,
            string? error = default,
            string? errorDescription = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}