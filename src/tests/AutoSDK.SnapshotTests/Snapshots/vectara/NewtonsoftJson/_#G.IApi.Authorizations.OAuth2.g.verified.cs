//HintName: G.IApi.Authorizations.OAuth2.g.cs

#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets the OAuth2 metadata URL declared by the security scheme, if any.
        /// </summary>
        public string? OAuth2MetadataUrl { get; }

        /// <summary>
        /// Gets a value indicating whether the OAuth2 security scheme is deprecated.
        /// </summary>
        public bool IsOAuth2Deprecated { get; }

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
        /// Authorize using OAuth2 authentication with client credentials.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="scope"></param>
        /// <param name="cancellationToken"></param>

        public global::System.Threading.Tasks.Task AuthorizeUsingOAuth2WithCredentialsAsync(
            string clientId,
            string clientSecret,
            string? scope = null,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}