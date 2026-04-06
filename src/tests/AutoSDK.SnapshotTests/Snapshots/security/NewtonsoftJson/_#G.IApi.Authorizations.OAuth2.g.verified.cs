//HintName: G.IApi.Authorizations.OAuth2.g.cs

#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets or sets the OAuth2 token store.
        /// </summary>
        public global::G.Api.IOAuth2TokenStore OAuth2TokenStore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether OAuth2 tokens should be refreshed automatically.
        /// </summary>
        public bool AutoRefreshOAuth2Tokens { get; set; }

        /// <summary>
        /// Gets or sets the clock skew used when checking OAuth2 token expiration.
        /// </summary>
        public global::System.TimeSpan OAuth2RefreshClockSkew { get; set; }

        /// <summary>
        /// Configures the OAuth2 token refresh callback.
        /// </summary>
        /// <param name="refreshTokenAsync"></param>
        public void ConfigureOAuth2TokenRefresh(
            global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<global::G.Api.OAuth2Token>> refreshTokenAsync);

        /// <summary>
        /// Gets the currently stored OAuth2 token.
        /// </summary>
        /// <returns>The stored OAuth2 token, if present.</returns>
        public global::G.Api.OAuth2Token? GetOAuth2Token();

        /// <summary>
        /// Clears the stored OAuth2 token.
        /// </summary>
        public void ClearOAuth2Token();

        /// <summary>
        /// Authorize using an OAuth2 access token.
        /// </summary>
        /// <param name="accessToken"></param>
        public void AuthorizeUsingOAuth2(
            string accessToken);

        /// <summary>
        /// Authorize using an OAuth2 token.
        /// </summary>
        /// <param name="token"></param>
        public void AuthorizeUsingOAuth2(
            global::G.Api.OAuth2Token token);
        /// <summary>
        /// Creates the OAuth2 authorization URL for the authorization code flow using typed scopes.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="scopes"></param>
        /// <param name="state"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <returns>The authorization URL.</returns>
        public string GetOAuth2AuthorizationUrl(
            string clientId,
            string redirectUri,
            global::System.Collections.Generic.IEnumerable<global::G.Api.OAuth2Scope>? scopes,
            string? state = null,
            string? codeChallenge = null,
            string codeChallengeMethod = "S256");

        /// <summary>
        /// Creates the OAuth2 authorization URL for the authorization code flow.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="scopes"></param>
        /// <param name="state"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <returns>The authorization URL.</returns>
        public string GetOAuth2AuthorizationUrl(
            string clientId,
            string redirectUri,
            global::System.Collections.Generic.IEnumerable<string>? scopes = null,
            string? state = null,
            string? codeChallenge = null,
            string codeChallengeMethod = "S256");

        /// <summary>
        /// Exchanges an OAuth2 authorization code for a token.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="code"></param>
        /// <param name="redirectUri"></param>
        /// <param name="clientSecret"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>The OAuth2 token.</returns>
        public global::System.Threading.Tasks.Task<global::G.Api.OAuth2Token> ExchangeOAuth2CodeForTokenAsync(
            string clientId,
            string code,
            string redirectUri,
            string? clientSecret = null,
            string? codeVerifier = null,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Refreshes the current OAuth2 token using the refresh token flow.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>The refreshed OAuth2 token.</returns>
        public global::System.Threading.Tasks.Task<global::G.Api.OAuth2Token> RefreshOAuth2TokenAsync(
            string clientId,
            string? clientSecret = null,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Authorize using OAuth2 authentication with the authorization code flow.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="code"></param>
        /// <param name="redirectUri"></param>
        /// <param name="clientSecret"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="cancellationToken"></param>
        public global::System.Threading.Tasks.Task AuthorizeUsingOAuth2WithAuthorizationCodeAsync(
            string clientId,
            string code,
            string redirectUri,
            string? clientSecret = null,
            string? codeVerifier = null,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}