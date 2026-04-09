//HintName: G.Api.Authorizations.OAuth2.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <summary>
        /// Represents an OAuth2 device authorization response.
        /// </summary>
        public sealed class OAuth2DeviceAuthorizationResponse
        {
            /// <summary>
            /// Gets or sets the device code.
            /// </summary>
            public string DeviceCode { get; set; } = string.Empty;

            /// <summary>
            /// Gets or sets the user code.
            /// </summary>
            public string UserCode { get; set; } = string.Empty;

            /// <summary>
            /// Gets or sets the verification URI.
            /// </summary>
            public string VerificationUri { get; set; } = string.Empty;

            /// <summary>
            /// Gets or sets the complete verification URI, if available.
            /// </summary>
            public string? VerificationUriComplete { get; set; }

            /// <summary>
            /// Gets or sets the display message for the end user, if provided.
            /// </summary>
            public string? Message { get; set; }

            /// <summary>
            /// Gets or sets the polling interval.
            /// </summary>
            public global::System.TimeSpan? Interval { get; set; }

            /// <summary>
            /// Gets or sets the expiration time.
            /// </summary>
            public global::System.DateTimeOffset? ExpiresAt { get; set; }
        }

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
                    if (authorizations[i].Type == "OAuth2" &&
                        authorizations[i].SchemeId == "OAuth2")
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
                    SchemeId = "OAuth2",
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
        /// Known OAuth2 scopes.
        /// </summary>
        public enum OAuth2Scope
        {
            Read,            Write,            Admin,
        }
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
            global::System.Collections.Generic.IEnumerable<OAuth2Scope>? scopes,
            string? state = null,
            string? codeChallenge = null,
            string codeChallengeMethod = "S256")
        {
            return GetOAuth2AuthorizationUrl(
                clientId: clientId,
                redirectUri: redirectUri,
                scopes: scopes is null
                    ? null
                    : global::System.Linq.Enumerable.Select(scopes, static x => ToOAuth2ScopeValue(x)),
                state: state,
                codeChallenge: codeChallenge,
                codeChallengeMethod: codeChallengeMethod);
        }

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
            string codeChallengeMethod = "S256")
        {
            clientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            redirectUri = redirectUri ?? throw new global::System.ArgumentNullException(nameof(redirectUri));
            codeChallengeMethod = codeChallengeMethod ?? throw new global::System.ArgumentNullException(nameof(codeChallengeMethod));

            var parameters = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
            {
                new global::System.Collections.Generic.KeyValuePair<string, string>("response_type", "code"),
                new global::System.Collections.Generic.KeyValuePair<string, string>("client_id", clientId),
                new global::System.Collections.Generic.KeyValuePair<string, string>("redirect_uri", redirectUri),
            };
            var scopeValue = scopes is null
                ? string.Empty
                : string.Join(" ", global::System.Linq.Enumerable.Where(scopes, static x => !string.IsNullOrWhiteSpace(x)));
            if (!string.IsNullOrWhiteSpace(scopeValue))
            {
                parameters.Add(new global::System.Collections.Generic.KeyValuePair<string, string>("scope", scopeValue));
            }
            if (!string.IsNullOrWhiteSpace(state))
            {
                parameters.Add(new global::System.Collections.Generic.KeyValuePair<string, string>("state", state));
            }
            if (!string.IsNullOrWhiteSpace(codeChallenge))
            {
                parameters.Add(new global::System.Collections.Generic.KeyValuePair<string, string>("code_challenge", codeChallenge));
                parameters.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                    "code_challenge_method",
                    string.IsNullOrWhiteSpace(codeChallengeMethod) ? "S256" : codeChallengeMethod));
            }

            var query = string.Join(
                "&",
                global::System.Linq.Enumerable.Select(
                    parameters,
                    static x => global::System.Uri.EscapeDataString(x.Key) + "=" + global::System.Uri.EscapeDataString(x.Value) ));
            var separator = "https://example.com/oauth/authorize".Contains("?", global::System.StringComparison.Ordinal) ? "&" : "?";
            return $"https://example.com/oauth/authorize{separator}{query}";
        }

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

        public async global::System.Threading.Tasks.Task<OAuth2Token> ExchangeOAuth2CodeForTokenAsync(
            string clientId,
            string code,
            string redirectUri,
            string? clientSecret = null,
            string? codeVerifier = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            clientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            redirectUri = redirectUri ?? throw new global::System.ArgumentNullException(nameof(redirectUri));

            var body = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
            {
                new global::System.Collections.Generic.KeyValuePair<string, string>("grant_type", "authorization_code"),
                new global::System.Collections.Generic.KeyValuePair<string, string>("client_id", clientId),
                new global::System.Collections.Generic.KeyValuePair<string, string>("code", code),
                new global::System.Collections.Generic.KeyValuePair<string, string>("redirect_uri", redirectUri),
            };
            if (!string.IsNullOrWhiteSpace(clientSecret))
            {
                body.Add(new global::System.Collections.Generic.KeyValuePair<string, string>("client_secret", clientSecret));
            }
            if (!string.IsNullOrWhiteSpace(codeVerifier))
            {
                body.Add(new global::System.Collections.Generic.KeyValuePair<string, string>("code_verifier", codeVerifier));
            }

            return await ExchangeOAuth2TokenAsync(
                tokenUrl: new global::System.Uri("https://example.com/oauth/token"),
                body: body,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Refreshes the current OAuth2 token using the refresh token flow.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>The refreshed OAuth2 token.</returns>

        public async global::System.Threading.Tasks.Task<OAuth2Token> RefreshOAuth2TokenAsync(
            string clientId,
            string? clientSecret = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            clientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));

            var currentToken = GetOAuth2Token() ??
                throw new global::System.InvalidOperationException("OAuth2 token was not available.");
            if (string.IsNullOrWhiteSpace(currentToken.RefreshToken))
            {
                throw new global::System.InvalidOperationException("refresh_token was not present in the stored OAuth2 token.");
            }

            var body = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
            {
                new global::System.Collections.Generic.KeyValuePair<string, string>("grant_type", "refresh_token"),
                new global::System.Collections.Generic.KeyValuePair<string, string>("client_id", clientId),
                new global::System.Collections.Generic.KeyValuePair<string, string>("refresh_token", currentToken.RefreshToken),
            };
            if (!string.IsNullOrWhiteSpace(clientSecret))
            {
                body.Add(new global::System.Collections.Generic.KeyValuePair<string, string>("client_secret", clientSecret));
            }

            var refreshedToken = await ExchangeOAuth2TokenAsync(
                tokenUrl: new global::System.Uri("https://example.com/oauth/token"),
                body: body,
                requestedScope: currentToken.Scope,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            refreshedToken.RefreshToken ??= currentToken.RefreshToken;
            refreshedToken.Scope ??= currentToken.Scope;
            AuthorizeUsingOAuth2(refreshedToken);

            return refreshedToken;
        }

        /// <inheritdoc/>

        public async global::System.Threading.Tasks.Task AuthorizeUsingOAuth2WithAuthorizationCodeAsync(
            string clientId,
            string code,
            string redirectUri,
            string? clientSecret = null,
            string? codeVerifier = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var token = await ExchangeOAuth2CodeForTokenAsync(
                clientId: clientId,
                code: code,
                redirectUri: redirectUri,
                clientSecret: clientSecret,
                codeVerifier: codeVerifier,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ConfigureOAuth2TokenRefresh(
                refreshTokenAsync: cancellationToken => RefreshOAuth2TokenAsync(
                    clientId: clientId,
                    clientSecret: clientSecret,
                    cancellationToken: cancellationToken));

            AuthorizeUsingOAuth2(token);
        }


        /// <summary>
        /// Creates a PKCE code verifier.
        /// </summary>
        /// <returns>The code verifier.</returns>
        public static string CreateOAuth2PkceCodeVerifier()
        {
            var bytes = new byte[32];
            using (var randomNumberGenerator = global::System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                randomNumberGenerator.GetBytes(bytes);
            }

            return ToOAuth2Base64Url(bytes);
        }

        /// <summary>
        /// Creates a PKCE code challenge from a verifier.
        /// </summary>
        /// <param name="codeVerifier"></param>
        /// <returns>The code challenge.</returns>
        public static string CreateOAuth2PkceCodeChallenge(
            string codeVerifier)
        {
            codeVerifier = codeVerifier ?? throw new global::System.ArgumentNullException(nameof(codeVerifier));

            var bytes = global::System.Text.Encoding.ASCII.GetBytes(codeVerifier);
#if NET10_0_OR_GREATER
            var hash = global::System.Security.Cryptography.SHA256.HashData(bytes);
#else
            byte[] hash;
            using (var sha256 = global::System.Security.Cryptography.SHA256.Create())
            {
                hash = sha256.ComputeHash(bytes);
            }
#endif
            return ToOAuth2Base64Url(hash);
        }

        private static string ToOAuth2Base64Url(
            byte[] bytes)
        {
            bytes = bytes ?? throw new global::System.ArgumentNullException(nameof(bytes));

            return global::System.Convert.ToBase64String(bytes)
                .TrimEnd('=')
                .Replace('+', '-')
                .Replace('/', '_');
        }
        private static string ToOAuth2ScopeValue(
            OAuth2Scope scope)
        {
            return scope switch
            {
                OAuth2Scope.Read => "read",                OAuth2Scope.Write => "write",                OAuth2Scope.Admin => "admin",
                _ => throw new global::System.NotImplementedException("OAuth2 scope not implemented."),
            };
        }

        private static string? JoinOAuth2Scopes(
            global::System.Collections.Generic.IEnumerable<OAuth2Scope>? scopes)
        {
            if (scopes is null)
            {
                return null;
            }

            return string.Join(" ", global::System.Linq.Enumerable.Select(scopes, static x => ToOAuth2ScopeValue(x)));
        }
    }
}