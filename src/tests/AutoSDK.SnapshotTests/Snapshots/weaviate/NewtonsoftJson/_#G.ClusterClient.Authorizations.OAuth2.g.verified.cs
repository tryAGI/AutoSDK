//HintName: G.ClusterClient.Authorizations.OAuth2.g.cs

#nullable enable

namespace G
{
    using OAuth2DeviceAuthorizationResponse = global::G.Api.OAuth2DeviceAuthorizationResponse;
    using OAuth2Token = global::G.Api.OAuth2Token;
    using IOAuth2TokenStore = global::G.Api.IOAuth2TokenStore;
    using AutoSDKOAuth2Helpers = global::G.Api.AutoSDKOAuth2Helpers;

    public sealed partial class ClusterClient
    {

        /// <summary>
        /// Gets the OAuth2 metadata URL declared by the security scheme, if any.
        /// </summary>
        public string? OAuth2MetadataUrl => string.IsNullOrWhiteSpace("")
            ? null
            : "";

        /// <summary>
        /// Gets a value indicating whether the OAuth2 security scheme is deprecated.
        /// </summary>
        public bool IsOAuth2Deprecated => false;
        /// <summary>
        /// Gets or sets the OAuth2 token store.
        /// </summary>
        public IOAuth2TokenStore OAuth2TokenStore
        {
            get => AutoSDKOAuth2State.TokenStore;
            set
            {
                value = value ?? throw new global::System.ArgumentNullException(nameof(value));

                var token = AutoSDKOAuth2State.GetToken();
                AutoSDKOAuth2State.TokenStore = value;
                if (token is not null)
                {
                    AutoSDKOAuth2State.SetToken(token);
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether OAuth2 tokens should be refreshed automatically.
        /// </summary>
        public bool AutoRefreshOAuth2Tokens
        {
            get => AutoSDKOAuth2State.AutoRefreshTokens;
            set => AutoSDKOAuth2State.AutoRefreshTokens = value;
        }

        /// <summary>
        /// Gets or sets the clock skew used when checking OAuth2 token expiration.
        /// </summary>
        public global::System.TimeSpan OAuth2RefreshClockSkew
        {
            get => AutoSDKOAuth2State.RefreshClockSkew;
            set
            {
                if (value < global::System.TimeSpan.Zero)
                {
                    throw new global::System.ArgumentOutOfRangeException(nameof(value));
                }

                AutoSDKOAuth2State.RefreshClockSkew = value;
            }
        }

        /// <summary>
        /// Configures the OAuth2 token refresh callback.
        /// </summary>
        /// <param name="refreshTokenAsync"></param>
        public void ConfigureOAuth2TokenRefresh(
            global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<OAuth2Token>> refreshTokenAsync)
        {
            AutoSDKOAuth2State.ConfigureRefresh(refreshTokenAsync);
        }

        /// <summary>
        /// Gets the currently stored OAuth2 token.
        /// </summary>
        /// <returns>The stored OAuth2 token, if present.</returns>
        public OAuth2Token? GetOAuth2Token()
        {
            return AutoSDKOAuth2State.GetToken();
        }

        /// <summary>
        /// Clears the stored OAuth2 token.
        /// </summary>
        public void ClearOAuth2Token()
        {
            AutoSDKOAuth2State.SetToken(null);
            AutoSDKOAuth2Helpers.SetAuthorization(Authorizations, null);
        }

        /// <summary>
        /// Authorize using an OAuth2 access token.
        /// </summary>
        /// <param name="accessToken"></param>

        public void AuthorizeUsingOAuth2(
            string accessToken)
        {
            accessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));

            AuthorizeUsingOAuth2(new OAuth2Token
            {
                AccessToken = accessToken,
                TokenType = "Bearer",
            });
        }

        /// <summary>
        /// Authorize using an OAuth2 token.
        /// </summary>
        /// <param name="token"></param>

        public void AuthorizeUsingOAuth2(
            OAuth2Token token)
        {
            token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            if (string.IsNullOrWhiteSpace(token.AccessToken))
            {
                throw new global::System.ArgumentException("Access token cannot be empty.", nameof(token));
            }
            if (string.IsNullOrWhiteSpace(token.TokenType))
            {
                token.TokenType = "Bearer";
            }

            var storedToken = token.Clone();
            AutoSDKOAuth2State.SetToken(storedToken);
            AutoSDKOAuth2Helpers.SetAuthorization(Authorizations, storedToken);
        }


        private async global::System.Threading.Tasks.Task<OAuth2Token> ExchangeOAuth2TokenAsync(
            global::System.Uri tokenUrl,
            global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>> body,
            string? requestedScope = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            tokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            body = body ?? throw new global::System.ArgumentNullException(nameof(body));

            using var response = await HttpClient.PostAsync(
                requestUri: tokenUrl,
                content: new global::System.Net.Http.FormUrlEncodedContent(body),
                cancellationToken: cancellationToken).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            var payload = global::Newtonsoft.Json.Linq.JObject.Parse(json);
            var accessToken = payload.Value<string>("access_token");
            if (string.IsNullOrWhiteSpace(accessToken))
            {
                throw new global::System.InvalidOperationException("access_token was not present in the token response.");
            }

            var tokenType = payload.Value<string>("token_type");
            var refreshToken = payload.Value<string>("refresh_token");
            var scope = payload.Value<string>("scope");
            var expiresIn = payload.Value<long?>("expires_in");
            var token = new OAuth2Token
            {
                AccessToken = accessToken,
                TokenType = string.IsNullOrWhiteSpace(tokenType) ? "Bearer" : tokenType,
                RefreshToken = refreshToken,
                Scope = string.IsNullOrWhiteSpace(scope) ? requestedScope : scope,
                ExpiresAt = expiresIn.HasValue
                    ? global::System.DateTimeOffset.UtcNow.AddSeconds(expiresIn.Value)
                    : (global::System.DateTimeOffset?)null,
            };

            return token;
        }
    }
}