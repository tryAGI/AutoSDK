//HintName: G.Api.Authorizations.OAuth2.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <summary>
        /// Represents an OAuth2 token.
        /// </summary>
        public sealed class OAuth2Token
        {
            /// <summary>
            /// Gets or sets the access token.
            /// </summary>
            public string AccessToken { get; set; } = string.Empty;

            /// <summary>
            /// Gets or sets the token type.
            /// </summary>
            public string TokenType { get; set; } = "Bearer";

            /// <summary>
            /// Gets or sets the refresh token.
            /// </summary>
            public string? RefreshToken { get; set; }

            /// <summary>
            /// Gets or sets the scope.
            /// </summary>
            public string? Scope { get; set; }

            /// <summary>
            /// Gets or sets the expiration time.
            /// </summary>
            public global::System.DateTimeOffset? ExpiresAt { get; set; }

            /// <summary>
            /// Determines whether the token should be refreshed.
            /// </summary>
            /// <param name="clockSkew"></param>
            /// <returns></returns>
            public bool ShouldRefresh(
                global::System.TimeSpan clockSkew)
            {
                if (clockSkew < global::System.TimeSpan.Zero)
                {
                    throw new global::System.ArgumentOutOfRangeException(nameof(clockSkew));
                }

                return ExpiresAt.HasValue &&
                    global::System.DateTimeOffset.UtcNow >= ExpiresAt.Value - clockSkew;
            }

            /// <summary>
            /// Creates a clone of the token.
            /// </summary>
            /// <returns></returns>
            public OAuth2Token Clone()
            {
                return new OAuth2Token
                {
                    AccessToken = AccessToken,
                    TokenType = TokenType,
                    RefreshToken = RefreshToken,
                    Scope = Scope,
                    ExpiresAt = ExpiresAt,
                };
            }
        }

        /// <summary>
        /// Stores OAuth2 tokens.
        /// </summary>
        public interface IOAuth2TokenStore
        {
            /// <summary>
            /// Gets the currently stored OAuth2 token.
            /// </summary>
            /// <returns></returns>
            OAuth2Token? GetToken();

            /// <summary>
            /// Stores the specified OAuth2 token.
            /// </summary>
            /// <param name="token"></param>
            void SetToken(
                OAuth2Token? token);
        }

        /// <summary>
        /// Stores OAuth2 tokens in memory.
        /// </summary>
        public sealed class InMemoryOAuth2TokenStore : IOAuth2TokenStore
        {
            private readonly object _syncRoot = new object();
            private OAuth2Token? _token;

            /// <inheritdoc/>
            public OAuth2Token? GetToken()
            {
                lock (_syncRoot)
                {
                    return _token?.Clone();
                }
            }

            /// <inheritdoc/>
            public void SetToken(
                OAuth2Token? token)
            {
                lock (_syncRoot)
                {
                    _token = token?.Clone();
                }
            }
        }

        /// <summary>
        /// Coordinates OAuth2 token storage and refresh.
        /// </summary>
        public sealed class AutoSDKOAuth2Coordinator
        {
            private readonly global::System.Threading.SemaphoreSlim _refreshSemaphore = new global::System.Threading.SemaphoreSlim(1, 1);
            private global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<OAuth2Token>>? _refreshTokenAsync;

            /// <summary>
            /// Gets or sets the OAuth2 token store.
            /// </summary>
            public IOAuth2TokenStore TokenStore { get; set; } = new InMemoryOAuth2TokenStore();

            /// <summary>
            /// Gets or sets a value indicating whether OAuth2 tokens should be refreshed automatically.
            /// </summary>
            public bool AutoRefreshTokens { get; set; } = true;

            /// <summary>
            /// Gets or sets the clock skew used when checking token expiration.
            /// </summary>
            public global::System.TimeSpan RefreshClockSkew { get; set; } = global::System.TimeSpan.FromMinutes(1);

            /// <summary>
            /// Gets a value indicating whether OAuth2 tokens can be refreshed automatically.
            /// </summary>
            public bool CanAutoRefresh => AutoRefreshTokens && _refreshTokenAsync is not null;

            /// <summary>
            /// Gets the currently stored OAuth2 token.
            /// </summary>
            /// <returns></returns>
            public OAuth2Token? GetToken()
            {
                return TokenStore.GetToken();
            }

            /// <summary>
            /// Stores the specified OAuth2 token.
            /// </summary>
            /// <param name="token"></param>
            public void SetToken(
                OAuth2Token? token)
            {
                TokenStore.SetToken(token);
            }

            /// <summary>
            /// Configures the OAuth2 token refresh callback.
            /// </summary>
            /// <param name="refreshTokenAsync"></param>
            public void ConfigureRefresh(
                global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<OAuth2Token>> refreshTokenAsync)
            {
                _refreshTokenAsync = refreshTokenAsync ?? throw new global::System.ArgumentNullException(nameof(refreshTokenAsync));
            }

            /// <summary>
            /// Ensures the current OAuth2 token is applied and refreshed if needed.
            /// </summary>
            /// <param name="applyToken"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async global::System.Threading.Tasks.Task<bool> TryEnsureFreshTokenAsync(
                global::System.Action<OAuth2Token> applyToken,
                global::System.Threading.CancellationToken cancellationToken = default)
            {
                applyToken = applyToken ?? throw new global::System.ArgumentNullException(nameof(applyToken));

                var token = GetToken();
                if (token is null)
                {
                    return false;
                }

                applyToken(token);
                if (!CanAutoRefresh || !token.ShouldRefresh(RefreshClockSkew))
                {
                    return false;
                }

                return await TryRefreshAsync(
                    currentAccessToken: token.AccessToken,
                    requireChangedToken: false,
                    applyToken: applyToken,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Attempts to refresh the OAuth2 token after an unauthorized response.
            /// </summary>
            /// <param name="currentAccessToken"></param>
            /// <param name="applyToken"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async global::System.Threading.Tasks.Task<bool> TryRefreshAfterUnauthorizedAsync(
                string? currentAccessToken,
                global::System.Action<OAuth2Token> applyToken,
                global::System.Threading.CancellationToken cancellationToken = default)
            {
                applyToken = applyToken ?? throw new global::System.ArgumentNullException(nameof(applyToken));
                if (!CanAutoRefresh)
                {
                    return false;
                }

                return await TryRefreshAsync(
                    currentAccessToken: currentAccessToken,
                    requireChangedToken: true,
                    applyToken: applyToken,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            private async global::System.Threading.Tasks.Task<bool> TryRefreshAsync(
                string? currentAccessToken,
                bool requireChangedToken,
                global::System.Action<OAuth2Token> applyToken,
                global::System.Threading.CancellationToken cancellationToken)
            {
                var refreshTokenAsync = _refreshTokenAsync;
                if (refreshTokenAsync is null)
                {
                    return false;
                }

                await _refreshSemaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
                try
                {
                    var token = GetToken();
                    if (token is not null)
                    {
                        if (!string.IsNullOrWhiteSpace(currentAccessToken) &&
                            !string.Equals(token.AccessToken, currentAccessToken, global::System.StringComparison.Ordinal))
                        {
                            applyToken(token);
                            return true;
                        }
                        if (!requireChangedToken && !token.ShouldRefresh(RefreshClockSkew))
                        {
                            applyToken(token);
                            return true;
                        }
                    }

                    OAuth2Token refreshedToken;
                    try
                    {
                        refreshedToken = await refreshTokenAsync(cancellationToken).ConfigureAwait(false);
                    }
                    catch
                    {
                        return false;
                    }

                    if (string.IsNullOrWhiteSpace(refreshedToken.AccessToken))
                    {
                        return false;
                    }

                    SetToken(refreshedToken);
                    applyToken(refreshedToken);
                    return true;
                }
                finally
                {
                    _refreshSemaphore.Release();
                }
            }
        }

        internal static class AutoSDKOAuth2Helpers
        {
            internal static void SetAuthorization(
                global::System.Collections.Generic.List<global::G.EndPointAuthorization> authorizations,
                OAuth2Token? token)
            {
                authorizations = authorizations ?? throw new global::System.ArgumentNullException(nameof(authorizations));

                for (var i = authorizations.Count - 1; i >= 0; i--)
                {
                    if (authorizations[i].Type == "OAuth2")
                    {
                        authorizations.RemoveAt(i);
                    }
                }

                if (token is null)
                {
                    return;
                }

                authorizations.Add(new global::G.EndPointAuthorization
                {
                    Type = "OAuth2",
                    Location = "Header",
                    Name = string.IsNullOrWhiteSpace(token.TokenType) ? "Bearer" : token.TokenType,
                    Value = token.AccessToken,
                });
            }

            internal static async global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage> SendAsync(
                global::System.Net.Http.HttpClient httpClient,
                global::System.Net.Http.HttpRequestMessage request,
                global::System.Net.Http.HttpCompletionOption completionOption,
                global::System.Collections.Generic.List<global::G.EndPointAuthorization> authorizations,
                AutoSDKOAuth2Coordinator oAuth2Coordinator,
                global::System.Threading.CancellationToken cancellationToken = default)
            {
                httpClient = httpClient ?? throw new global::System.ArgumentNullException(nameof(httpClient));
                request = request ?? throw new global::System.ArgumentNullException(nameof(request));
                authorizations = authorizations ?? throw new global::System.ArgumentNullException(nameof(authorizations));
                oAuth2Coordinator = oAuth2Coordinator ?? throw new global::System.ArgumentNullException(nameof(oAuth2Coordinator));

                _ = await oAuth2Coordinator.TryEnsureFreshTokenAsync(
                    applyToken: token => SetAuthorization(authorizations, token),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                ApplyAuthorizationHeader(request, authorizations);
                var currentAccessToken = GetCurrentAccessToken(authorizations);
                using var retryRequest = oAuth2Coordinator.CanAutoRefresh
                    ? await CloneRequestAsync(request, cancellationToken).ConfigureAwait(false)
                    : null;

                var response = await httpClient.SendAsync(
                    request: request,
                    completionOption: completionOption,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                if ((int)response.StatusCode != 401 || retryRequest is null)
                {
                    return response;
                }

                var refreshed = await oAuth2Coordinator.TryRefreshAfterUnauthorizedAsync(
                    currentAccessToken: currentAccessToken,
                    applyToken: token => SetAuthorization(authorizations, token),
                    cancellationToken: cancellationToken).ConfigureAwait(false);
                if (!refreshed)
                {
                    return response;
                }

                response.Dispose();
                ApplyAuthorizationHeader(retryRequest, authorizations);
                return await httpClient.SendAsync(
                    request: retryRequest,
                    completionOption: completionOption,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            private static string? GetCurrentAccessToken(
                global::System.Collections.Generic.List<global::G.EndPointAuthorization> authorizations)
            {
                foreach (var authorization in authorizations)
                {
                    if (authorization.Type == "OAuth2")
                    {
                        return authorization.Value;
                    }
                }

                return null;
            }

            private static void ApplyAuthorizationHeader(
                global::System.Net.Http.HttpRequestMessage request,
                global::System.Collections.Generic.List<global::G.EndPointAuthorization> authorizations)
            {
                foreach (var authorization in authorizations)
                {
                    if (authorization.Type == "OAuth2")
                    {
                        request.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                            scheme: authorization.Name,
                            parameter: authorization.Value);
                        return;
                    }
                }
            }

            private static async global::System.Threading.Tasks.Task<global::System.Net.Http.HttpRequestMessage> CloneRequestAsync(
                global::System.Net.Http.HttpRequestMessage request,
                global::System.Threading.CancellationToken cancellationToken)
            {
                var clone = new global::System.Net.Http.HttpRequestMessage(
                    method: request.Method,
                    requestUri: request.RequestUri);
                clone.Version = request.Version;
#if NET6_0_OR_GREATER
                clone.VersionPolicy = request.VersionPolicy;
#endif
                foreach (var header in request.Headers)
                {
                    clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
                if (request.Content is not null)
                {
                    byte[] bytes;
#if NET5_0_OR_GREATER
                    bytes = await request.Content.ReadAsByteArrayAsync(cancellationToken).ConfigureAwait(false);
#else
                    bytes = await request.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
#endif
                    var content = new global::System.Net.Http.ByteArrayContent(bytes);
                    foreach (var header in request.Content.Headers)
                    {
                        content.Headers.TryAddWithoutValidation(header.Key, header.Value);
                    }

                    clone.Content = content;
                }

                return clone;
            }
        }

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

            using var jsonDocument = global::System.Text.Json.JsonDocument.Parse(json);
            if (!jsonDocument.RootElement.TryGetProperty("access_token", out var accessTokenElement))
            {
                throw new global::System.InvalidOperationException("access_token was not present in the token response.");
            }

            var accessToken = accessTokenElement.GetString();
            if (string.IsNullOrWhiteSpace(accessToken))
            {
                throw new global::System.InvalidOperationException("access_token was empty in the token response.");
            }

            string? tokenType = null;
            if (jsonDocument.RootElement.TryGetProperty("token_type", out var tokenTypeElement))
            {
                tokenType = tokenTypeElement.GetString();
            }

            string? refreshToken = null;
            if (jsonDocument.RootElement.TryGetProperty("refresh_token", out var refreshTokenElement))
            {
                refreshToken = refreshTokenElement.GetString();
            }

            string? scope = null;
            if (jsonDocument.RootElement.TryGetProperty("scope", out var scopeElement))
            {
                scope = scopeElement.GetString();
            }

            long? expiresIn = null;
            if (jsonDocument.RootElement.TryGetProperty("expires_in", out var expiresInElement))
            {
                if (expiresInElement.ValueKind == global::System.Text.Json.JsonValueKind.Number &&
                    expiresInElement.TryGetInt64(out var expiresInValue))
                {
                    expiresIn = expiresInValue;
                }
                else if (expiresInElement.ValueKind == global::System.Text.Json.JsonValueKind.String &&
                         long.TryParse(expiresInElement.GetString(), out expiresInValue))
                {
                    expiresIn = expiresInValue;
                }
            }

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