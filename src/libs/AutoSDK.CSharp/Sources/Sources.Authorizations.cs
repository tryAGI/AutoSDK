using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateAuthorization(
        Authorization authorization)
    {
        if (authorization.Type is SecuritySchemeType.OpenIdConnect)
        {
            return string.Empty;
        }
        if (authorization.Type is SecuritySchemeType.OAuth2)
        {
            return $@"
#nullable enable

namespace {authorization.Settings.Namespace}
{{
    public sealed partial class {authorization.Settings.ClassName}
    {{
{GenerateOAuth2AuthorizationMembers(authorization)}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
        }
        
        return $@"
#nullable enable

namespace {authorization.Settings.Namespace}
{{
    public sealed partial class {authorization.Settings.ClassName}
    {{
        /// <inheritdoc/>
        public void {authorization.MethodName}(
{authorization.Parameters.Select(x => $@"
            string {x},").Inject().TrimEnd(',')})
        {{
{authorization.Parameters.Select(x => $@"
            {x} = {x} ?? throw new global::System.ArgumentNullException(nameof({x}));").Inject()}

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {{
                var __authorization = Authorizations[i];
                if ({GetMatchingAuthorizationCondition(authorization, "__authorization")})
                {{
                    Authorizations.RemoveAt(i);
                }}
            }}

            Authorizations.Add(new global::{authorization.GlobalSettings.Namespace}.EndPointAuthorization
            {{
                Type = ""{authorization.Type:G}"",
                Location = ""{authorization.In:G}"",
                Name = ""{(authorization.Type, authorization.Scheme.ToUpperInvariant(), authorization.In) switch
                {
                    (SecuritySchemeType.Http, "BEARER", _) => "Bearer",
                    (SecuritySchemeType.Http, "BASIC", _) => "Basic",
                    (SecuritySchemeType.Http, _, _) => authorization.Scheme,
                    (SecuritySchemeType.ApiKey, _, _) => authorization.Name,
                    _ => string.Empty,
                }}"",
                Value = {(authorization.Type, authorization.Scheme.ToUpperInvariant(), authorization.In) switch
                {
                    (SecuritySchemeType.Http, "BEARER", _) => "apiKey",
                    (SecuritySchemeType.Http, "BASIC", _) => @"global::System.Convert.ToBase64String(
                    global::System.Text.Encoding.UTF8.GetBytes($""{username}:{password}""))",
                    (SecuritySchemeType.Http, _, _) => "apiKey",
                    (SecuritySchemeType.ApiKey, _, _) => "apiKey",
                    _ => "\"\"",
                }},
            }});
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GenerateAuthorizationInterface(
        Authorization authorization)
    {
        if (authorization.Type is SecuritySchemeType.OpenIdConnect)
        {
            return string.Empty;
        }
        if (authorization.Type is SecuritySchemeType.OAuth2)
        {
            return $@"
#nullable enable

namespace {authorization.Settings.Namespace}
{{
    public partial interface I{authorization.Settings.ClassName}
    {{
{GenerateOAuth2AuthorizationInterfaceMembers(authorization)}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
        }
        
        return $@"
#nullable enable

namespace {authorization.Settings.Namespace}
{{
    public partial interface I{authorization.Settings.ClassName}
    {{
        /// <summary>
        /// {(authorization.Type, authorization.Scheme.ToUpperInvariant(), authorization.In) switch
        {
            (SecuritySchemeType.Http, "BEARER", _) => "Authorize using bearer authentication.",
            (SecuritySchemeType.Http, "BASIC", _) => "Authorize using basic authentication.",
            (SecuritySchemeType.Http, _, _) => $"Authorize using {authorization.Scheme} authentication.",
            (SecuritySchemeType.ApiKey, _, _) => "Authorize using ApiKey authentication.",
            _ => string.Empty,
        }}
        /// </summary>
{authorization.Parameters.Select(x => $@"
        /// <param name=""{x}""></param>").Inject()}
        public void {authorization.MethodName}(
{authorization.Parameters.Select(x => $@"
            string {x},").Inject().TrimEnd(',')});
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GenerateMainAuthorizationConstructor(
        Authorization authorization)
    {
        if (authorization.Parameters.IsEmpty)
        {
            return string.Empty;
        }
        
        return $@"
#nullable enable

namespace {authorization.Settings.Namespace}
{{
    public sealed partial class {authorization.Settings.ClassName}
    {{
        /// <inheritdoc cref=""{authorization.Settings.ClassName}(global::System.Net.Http.HttpClient?, global::System.Uri?, global::System.Collections.Generic.List{{global::{authorization.GlobalSettings.Namespace}.EndPointAuthorization}}?, bool)""/>
        public {authorization.Settings.ClassName}(
{string.Join("\n", authorization.Parameters.Select(x => $@" 
            string {x},"))}
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::{authorization.GlobalSettings.Namespace}.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(httpClient, baseUri, authorizations, disposeHttpClient)
        {{
            Authorizing(HttpClient, {string.Join(", ", authorization.Parameters.Select(x => $"ref {x}"))});

            {authorization.MethodName}({string.Join(", ", authorization.Parameters.Select(x => $"{x}"))});

            Authorized(HttpClient);
        }}

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
{string.Join("\n", authorization.Parameters.Select(x => $@" 
            ref string {x},")).TrimEnd(',')});
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GetMatchingAuthorizationCondition(
        Authorization authorization,
        string variableName)
    {
        var typeCondition = $@"{variableName}.Type == ""{authorization.Type:G}""";

        return authorization.Type switch
        {
            SecuritySchemeType.Http => $@"{typeCondition} &&
                    {variableName}.Name == ""{GetAuthorizationRuntimeName(authorization)}""",
            SecuritySchemeType.ApiKey => $@"{typeCondition} &&
                    {variableName}.Location == ""{authorization.In:G}"" &&
                    {variableName}.Name == ""{authorization.Name}""",
            _ => typeCondition,
        };
    }

    private static string GetAuthorizationRuntimeName(Authorization authorization)
    {
        return (authorization.Type, authorization.Scheme.ToUpperInvariant(), authorization.In) switch
        {
            (SecuritySchemeType.Http, "BEARER", _) => "Bearer",
            (SecuritySchemeType.Http, "BASIC", _) => "Basic",
            (SecuritySchemeType.Http, _, _) => authorization.Scheme,
            (SecuritySchemeType.ApiKey, _, _) => authorization.Name,
            _ => string.Empty,
        };
    }

    private static string GenerateOAuth2AuthorizationMembers(Authorization authorization)
    {
        var hasAuthorizationCodeFlow = authorization.Flows.Any(static x => x.Type == nameof(OpenApiOAuthFlows.AuthorizationCode));
        var hasScopeEnum = GetDistinctOAuth2Scopes(authorization).Length != 0;

        return $@"
{GenerateOAuth2SupportTypes(authorization)}
{GenerateOAuth2ScopeEnum(authorization)}
        /// <summary>
        /// Gets or sets the OAuth2 token store.
        /// </summary>
        public IOAuth2TokenStore OAuth2TokenStore
        {{
            get => AutoSDKOAuth2State.TokenStore;
            set
            {{
                value = value ?? throw new global::System.ArgumentNullException(nameof(value));

                var token = AutoSDKOAuth2State.GetToken();
                AutoSDKOAuth2State.TokenStore = value;
                if (token is not null)
                {{
                    AutoSDKOAuth2State.SetToken(token);
                }}
            }}
        }}

        /// <summary>
        /// Gets or sets a value indicating whether OAuth2 tokens should be refreshed automatically.
        /// </summary>
        public bool AutoRefreshOAuth2Tokens
        {{
            get => AutoSDKOAuth2State.AutoRefreshTokens;
            set => AutoSDKOAuth2State.AutoRefreshTokens = value;
        }}

        /// <summary>
        /// Gets or sets the clock skew used when checking OAuth2 token expiration.
        /// </summary>
        public global::System.TimeSpan OAuth2RefreshClockSkew
        {{
            get => AutoSDKOAuth2State.RefreshClockSkew;
            set
            {{
                if (value < global::System.TimeSpan.Zero)
                {{
                    throw new global::System.ArgumentOutOfRangeException(nameof(value));
                }}

                AutoSDKOAuth2State.RefreshClockSkew = value;
            }}
        }}

        /// <summary>
        /// Configures the OAuth2 token refresh callback.
        /// </summary>
        /// <param name=""refreshTokenAsync""></param>
        public void ConfigureOAuth2TokenRefresh(
            global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<OAuth2Token>> refreshTokenAsync)
        {{
            AutoSDKOAuth2State.ConfigureRefresh(refreshTokenAsync);
        }}

        /// <summary>
        /// Gets the currently stored OAuth2 token.
        /// </summary>
        /// <returns>The stored OAuth2 token, if present.</returns>
        public OAuth2Token? GetOAuth2Token()
        {{
            return AutoSDKOAuth2State.GetToken();
        }}

        /// <summary>
        /// Clears the stored OAuth2 token.
        /// </summary>
        public void ClearOAuth2Token()
        {{
            AutoSDKOAuth2State.SetToken(null);
            AutoSDKOAuth2Helpers.SetAuthorization(Authorizations, null);
        }}

        /// <summary>
        /// Authorize using an OAuth2 access token.
        /// </summary>
        /// <param name=""accessToken""></param>
        public void {authorization.MethodName}(
            string accessToken)
        {{
            accessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));

            {authorization.MethodName}(new OAuth2Token
            {{
                AccessToken = accessToken,
                TokenType = ""Bearer"",
            }});
        }}

        /// <summary>
        /// Authorize using an OAuth2 token.
        /// </summary>
        /// <param name=""token""></param>
        public void {authorization.MethodName}(
            OAuth2Token token)
        {{
            token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            if (string.IsNullOrWhiteSpace(token.AccessToken))
            {{
                throw new global::System.ArgumentException(""Access token cannot be empty."", nameof(token));
            }}
            if (string.IsNullOrWhiteSpace(token.TokenType))
            {{
                token.TokenType = ""Bearer"";
            }}

            var storedToken = token.Clone();
            AutoSDKOAuth2State.SetToken(storedToken);
            AutoSDKOAuth2Helpers.SetAuthorization(Authorizations, storedToken);
        }}
{(!authorization.Flows.IsEmpty ? $@"

        private async global::System.Threading.Tasks.Task<OAuth2Token> ExchangeOAuth2TokenAsync(
            global::System.Uri tokenUrl,
            global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>> body,
            string? requestedScope = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            tokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
            body = body ?? throw new global::System.ArgumentNullException(nameof(body));

            using var response = await HttpClient.PostAsync(
                requestUri: tokenUrl,
                content: new global::System.Net.Http.FormUrlEncodedContent(body),
                cancellationToken: cancellationToken).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
{GenerateOAuth2TokenRead(authorization, "json", "requestedScope")}

            return token;
        }}" : TrimmedLine)}
{authorization.Flows.Select(x => GenerateOAuth2AuthorizationFlowMember(authorization, x)).Inject()}
{(hasAuthorizationCodeFlow ? GenerateOAuth2PkceMembers() : TrimmedLine)}
{(hasScopeEnum ? GenerateOAuth2ScopeHelpers(authorization) : TrimmedLine)}
".Trim('\r', '\n');
    }

    private static string GenerateOAuth2AuthorizationInterfaceMembers(Authorization authorization)
    {
        var rootClassName = authorization.Settings.ClassName.Replace(".", string.Empty);

        return $@"
        /// <summary>
        /// Gets or sets the OAuth2 token store.
        /// </summary>
        public global::{authorization.Settings.Namespace}.{rootClassName}.IOAuth2TokenStore OAuth2TokenStore {{ get; set; }}

        /// <summary>
        /// Gets or sets a value indicating whether OAuth2 tokens should be refreshed automatically.
        /// </summary>
        public bool AutoRefreshOAuth2Tokens {{ get; set; }}

        /// <summary>
        /// Gets or sets the clock skew used when checking OAuth2 token expiration.
        /// </summary>
        public global::System.TimeSpan OAuth2RefreshClockSkew {{ get; set; }}

        /// <summary>
        /// Configures the OAuth2 token refresh callback.
        /// </summary>
        /// <param name=""refreshTokenAsync""></param>
        public void ConfigureOAuth2TokenRefresh(
            global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<global::{authorization.Settings.Namespace}.{rootClassName}.OAuth2Token>> refreshTokenAsync);

        /// <summary>
        /// Gets the currently stored OAuth2 token.
        /// </summary>
        /// <returns>The stored OAuth2 token, if present.</returns>
        public global::{authorization.Settings.Namespace}.{rootClassName}.OAuth2Token? GetOAuth2Token();

        /// <summary>
        /// Clears the stored OAuth2 token.
        /// </summary>
        public void ClearOAuth2Token();

        /// <summary>
        /// Authorize using an OAuth2 access token.
        /// </summary>
        /// <param name=""accessToken""></param>
        public void {authorization.MethodName}(
            string accessToken);

        /// <summary>
        /// Authorize using an OAuth2 token.
        /// </summary>
        /// <param name=""token""></param>
        public void {authorization.MethodName}(
            global::{authorization.Settings.Namespace}.{rootClassName}.OAuth2Token token);
{authorization.Flows.Select(x => GenerateOAuth2AuthorizationFlowInterfaceMember(authorization, x)).Inject()}
".Trim('\r', '\n');
    }

    private static string GenerateOAuth2AuthorizationFlowMember(
        Authorization authorization,
        OAuthFlow flow)
    {
        var hasScopeEnum = GetDistinctOAuth2Scopes(authorization).Length != 0;
        var refreshUrl = string.IsNullOrWhiteSpace(flow.RefreshUrl)
            ? flow.TokenUrl
            : flow.RefreshUrl;

        return flow.Type switch
        {
            nameof(OpenApiOAuthFlows.ClientCredentials) => $@"

{(hasScopeEnum ? $@"        /// <summary>
        /// Authorize using OAuth2 authentication with client credentials and typed scopes.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""clientSecret""></param>
        /// <param name=""scopes""></param>
        /// <param name=""cancellationToken""></param>
        public global::System.Threading.Tasks.Task {authorization.MethodName}WithCredentialsAsync(
            string clientId,
            string clientSecret,
            global::System.Collections.Generic.IEnumerable<OAuth2Scope>? scopes = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            return {authorization.MethodName}WithCredentialsAsync(
                clientId: clientId,
                clientSecret: clientSecret,
                scope: JoinOAuth2Scopes(scopes),
                cancellationToken: cancellationToken);
        }}
" : TrimmedLine)}
        /// <inheritdoc/>
        public async global::System.Threading.Tasks.Task {authorization.MethodName}WithCredentialsAsync(
            string clientId,
            string clientSecret,
            string? scope = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            clientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            clientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));

            var body = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
            {{
                new global::System.Collections.Generic.KeyValuePair<string, string>(""client_id"", clientId),
                new global::System.Collections.Generic.KeyValuePair<string, string>(""client_secret"", clientSecret),
                new global::System.Collections.Generic.KeyValuePair<string, string>(""grant_type"", ""client_credentials""),
            }};
            if (!string.IsNullOrWhiteSpace(scope))
            {{
                body.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(""scope"", scope));
            }}

            var token = await ExchangeOAuth2TokenAsync(
                tokenUrl: new global::System.Uri(""{flow.TokenUrl}""),
                body: body,
                requestedScope: scope,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ConfigureOAuth2TokenRefresh(
                refreshTokenAsync: async cancellationToken =>
                {{
                    var refreshBody = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
                    {{
                        new global::System.Collections.Generic.KeyValuePair<string, string>(""client_id"", clientId),
                        new global::System.Collections.Generic.KeyValuePair<string, string>(""client_secret"", clientSecret),
                        new global::System.Collections.Generic.KeyValuePair<string, string>(""grant_type"", ""client_credentials""),
                    }};
                    if (!string.IsNullOrWhiteSpace(scope))
                    {{
                        refreshBody.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(""scope"", scope));
                    }}

                    return await ExchangeOAuth2TokenAsync(
                        tokenUrl: new global::System.Uri(""{flow.TokenUrl}""),
                        body: refreshBody,
                        requestedScope: scope,
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                }});

            {authorization.MethodName}(token);
        }}",
            nameof(OpenApiOAuthFlows.AuthorizationCode) => $@"

{(hasScopeEnum ? $@"        /// <summary>
        /// Creates the OAuth2 authorization URL for the authorization code flow using typed scopes.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""redirectUri""></param>
        /// <param name=""scopes""></param>
        /// <param name=""state""></param>
        /// <param name=""codeChallenge""></param>
        /// <param name=""codeChallengeMethod""></param>
        /// <returns>The authorization URL.</returns>
        public string GetOAuth2AuthorizationUrl(
            string clientId,
            string redirectUri,
            global::System.Collections.Generic.IEnumerable<OAuth2Scope>? scopes,
            string? state = null,
            string? codeChallenge = null,
            string codeChallengeMethod = ""S256"")
        {{
            return GetOAuth2AuthorizationUrl(
                clientId: clientId,
                redirectUri: redirectUri,
                scopes: scopes is null
                    ? null
                    : global::System.Linq.Enumerable.Select(scopes, static x => ToOAuth2ScopeValue(x)),
                state: state,
                codeChallenge: codeChallenge,
                codeChallengeMethod: codeChallengeMethod);
        }}
" : TrimmedLine)}
        /// <summary>
        /// Creates the OAuth2 authorization URL for the authorization code flow.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""redirectUri""></param>
        /// <param name=""scopes""></param>
        /// <param name=""state""></param>
        /// <param name=""codeChallenge""></param>
        /// <param name=""codeChallengeMethod""></param>
        /// <returns>The authorization URL.</returns>
        public string GetOAuth2AuthorizationUrl(
            string clientId,
            string redirectUri,
            global::System.Collections.Generic.IEnumerable<string>? scopes = null,
            string? state = null,
            string? codeChallenge = null,
            string codeChallengeMethod = ""S256"")
        {{
            clientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            redirectUri = redirectUri ?? throw new global::System.ArgumentNullException(nameof(redirectUri));
            codeChallengeMethod = codeChallengeMethod ?? throw new global::System.ArgumentNullException(nameof(codeChallengeMethod));

            var parameters = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
            {{
                new global::System.Collections.Generic.KeyValuePair<string, string>(""response_type"", ""code""),
                new global::System.Collections.Generic.KeyValuePair<string, string>(""client_id"", clientId),
                new global::System.Collections.Generic.KeyValuePair<string, string>(""redirect_uri"", redirectUri),
            }};
            var scopeValue = scopes is null
                ? string.Empty
                : string.Join("" "", global::System.Linq.Enumerable.Where(scopes, static x => !string.IsNullOrWhiteSpace(x)));
            if (!string.IsNullOrWhiteSpace(scopeValue))
            {{
                parameters.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(""scope"", scopeValue));
            }}
            if (!string.IsNullOrWhiteSpace(state))
            {{
                parameters.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(""state"", state));
            }}
            if (!string.IsNullOrWhiteSpace(codeChallenge))
            {{
                parameters.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(""code_challenge"", codeChallenge));
                parameters.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                    ""code_challenge_method"",
                    string.IsNullOrWhiteSpace(codeChallengeMethod) ? ""S256"" : codeChallengeMethod));
            }}

            var query = string.Join(
                ""&"",
                global::System.Linq.Enumerable.Select(
                    parameters,
                    static x => global::System.Uri.EscapeDataString(x.Key) + ""="" + global::System.Uri.EscapeDataString(x.Value) ));
            var separator = ""{flow.AuthorizationUrl}"".Contains(""?"", global::System.StringComparison.Ordinal) ? ""&"" : ""?"";
            return $""{flow.AuthorizationUrl}{{separator}}{{query}}"";
        }}

        /// <summary>
        /// Exchanges an OAuth2 authorization code for a token.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""code""></param>
        /// <param name=""redirectUri""></param>
        /// <param name=""clientSecret""></param>
        /// <param name=""codeVerifier""></param>
        /// <param name=""cancellationToken""></param>
        /// <returns>The OAuth2 token.</returns>
        public async global::System.Threading.Tasks.Task<OAuth2Token> ExchangeOAuth2CodeForTokenAsync(
            string clientId,
            string code,
            string redirectUri,
            string? clientSecret = null,
            string? codeVerifier = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            clientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            redirectUri = redirectUri ?? throw new global::System.ArgumentNullException(nameof(redirectUri));

            var body = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
            {{
                new global::System.Collections.Generic.KeyValuePair<string, string>(""grant_type"", ""authorization_code""),
                new global::System.Collections.Generic.KeyValuePair<string, string>(""client_id"", clientId),
                new global::System.Collections.Generic.KeyValuePair<string, string>(""code"", code),
                new global::System.Collections.Generic.KeyValuePair<string, string>(""redirect_uri"", redirectUri),
            }};
            if (!string.IsNullOrWhiteSpace(clientSecret))
            {{
                body.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(""client_secret"", clientSecret));
            }}
            if (!string.IsNullOrWhiteSpace(codeVerifier))
            {{
                body.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(""code_verifier"", codeVerifier));
            }}

            return await ExchangeOAuth2TokenAsync(
                tokenUrl: new global::System.Uri(""{flow.TokenUrl}""),
                body: body,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }}

        /// <summary>
        /// Refreshes the current OAuth2 token using the refresh token flow.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""clientSecret""></param>
        /// <param name=""cancellationToken""></param>
        /// <returns>The refreshed OAuth2 token.</returns>
        public async global::System.Threading.Tasks.Task<OAuth2Token> RefreshOAuth2TokenAsync(
            string clientId,
            string? clientSecret = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            clientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));

            var currentToken = GetOAuth2Token() ??
                throw new global::System.InvalidOperationException(""OAuth2 token was not available."");
            if (string.IsNullOrWhiteSpace(currentToken.RefreshToken))
            {{
                throw new global::System.InvalidOperationException(""refresh_token was not present in the stored OAuth2 token."");
            }}

            var body = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
            {{
                new global::System.Collections.Generic.KeyValuePair<string, string>(""grant_type"", ""refresh_token""),
                new global::System.Collections.Generic.KeyValuePair<string, string>(""client_id"", clientId),
                new global::System.Collections.Generic.KeyValuePair<string, string>(""refresh_token"", currentToken.RefreshToken),
            }};
            if (!string.IsNullOrWhiteSpace(clientSecret))
            {{
                body.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(""client_secret"", clientSecret));
            }}

            var refreshedToken = await ExchangeOAuth2TokenAsync(
                tokenUrl: new global::System.Uri(""{refreshUrl}""),
                body: body,
                requestedScope: currentToken.Scope,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            refreshedToken.RefreshToken ??= currentToken.RefreshToken;
            refreshedToken.Scope ??= currentToken.Scope;
            {authorization.MethodName}(refreshedToken);

            return refreshedToken;
        }}

        /// <inheritdoc/>
        public async global::System.Threading.Tasks.Task {authorization.MethodName}WithAuthorizationCodeAsync(
            string clientId,
            string code,
            string redirectUri,
            string? clientSecret = null,
            string? codeVerifier = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
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

            {authorization.MethodName}(token);
        }}",
            _ => string.Empty,
        };
    }

    private static string GenerateOAuth2AuthorizationFlowInterfaceMember(
        Authorization authorization,
        OAuthFlow flow)
    {
        var rootClassName = authorization.Settings.ClassName.Replace(".", string.Empty);
        var hasScopeEnum = GetDistinctOAuth2Scopes(authorization).Length != 0;
        var scopeEnumType = $"global::{authorization.Settings.Namespace}.{rootClassName}.OAuth2Scope";
        var tokenType = $"global::{authorization.Settings.Namespace}.{rootClassName}.OAuth2Token";

        return flow.Type switch
        {
            nameof(OpenApiOAuthFlows.ClientCredentials) => $@"

{(hasScopeEnum ? $@"        /// <summary>
        /// Authorize using OAuth2 authentication with client credentials and typed scopes.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""clientSecret""></param>
        /// <param name=""scopes""></param>
        /// <param name=""cancellationToken""></param>
        public global::System.Threading.Tasks.Task {authorization.MethodName}WithCredentialsAsync(
            string clientId,
            string clientSecret,
            global::System.Collections.Generic.IEnumerable<{scopeEnumType}>? scopes = null,
            global::System.Threading.CancellationToken cancellationToken = default);
" : TrimmedLine)}
        /// <summary>
        /// Authorize using OAuth2 authentication with client credentials.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""clientSecret""></param>
        /// <param name=""scope""></param>
        /// <param name=""cancellationToken""></param>
        public global::System.Threading.Tasks.Task {authorization.MethodName}WithCredentialsAsync(
            string clientId,
            string clientSecret,
            string? scope = null,
            global::System.Threading.CancellationToken cancellationToken = default);",
            nameof(OpenApiOAuthFlows.AuthorizationCode) => $@"

{(hasScopeEnum ? $@"        /// <summary>
        /// Creates the OAuth2 authorization URL for the authorization code flow using typed scopes.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""redirectUri""></param>
        /// <param name=""scopes""></param>
        /// <param name=""state""></param>
        /// <param name=""codeChallenge""></param>
        /// <param name=""codeChallengeMethod""></param>
        /// <returns>The authorization URL.</returns>
        public string GetOAuth2AuthorizationUrl(
            string clientId,
            string redirectUri,
            global::System.Collections.Generic.IEnumerable<{scopeEnumType}>? scopes,
            string? state = null,
            string? codeChallenge = null,
            string codeChallengeMethod = ""S256"");
" : TrimmedLine)}
        /// <summary>
        /// Creates the OAuth2 authorization URL for the authorization code flow.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""redirectUri""></param>
        /// <param name=""scopes""></param>
        /// <param name=""state""></param>
        /// <param name=""codeChallenge""></param>
        /// <param name=""codeChallengeMethod""></param>
        /// <returns>The authorization URL.</returns>
        public string GetOAuth2AuthorizationUrl(
            string clientId,
            string redirectUri,
            global::System.Collections.Generic.IEnumerable<string>? scopes = null,
            string? state = null,
            string? codeChallenge = null,
            string codeChallengeMethod = ""S256"");

        /// <summary>
        /// Exchanges an OAuth2 authorization code for a token.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""code""></param>
        /// <param name=""redirectUri""></param>
        /// <param name=""clientSecret""></param>
        /// <param name=""codeVerifier""></param>
        /// <param name=""cancellationToken""></param>
        /// <returns>The OAuth2 token.</returns>
        public global::System.Threading.Tasks.Task<{tokenType}> ExchangeOAuth2CodeForTokenAsync(
            string clientId,
            string code,
            string redirectUri,
            string? clientSecret = null,
            string? codeVerifier = null,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Refreshes the current OAuth2 token using the refresh token flow.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""clientSecret""></param>
        /// <param name=""cancellationToken""></param>
        /// <returns>The refreshed OAuth2 token.</returns>
        public global::System.Threading.Tasks.Task<{tokenType}> RefreshOAuth2TokenAsync(
            string clientId,
            string? clientSecret = null,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Authorize using OAuth2 authentication with the authorization code flow.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""code""></param>
        /// <param name=""redirectUri""></param>
        /// <param name=""clientSecret""></param>
        /// <param name=""codeVerifier""></param>
        /// <param name=""cancellationToken""></param>
        public global::System.Threading.Tasks.Task AuthorizeUsingOAuth2WithAuthorizationCodeAsync(
            string clientId,
            string code,
            string redirectUri,
            string? clientSecret = null,
            string? codeVerifier = null,
            global::System.Threading.CancellationToken cancellationToken = default);",
            _ => string.Empty,
        };
    }

    private static string GenerateOAuth2PkceMembers()
    {
        return @"

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
        /// <param name=""codeVerifier""></param>
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
        }";
    }

    private static string GenerateOAuth2SupportTypes(Authorization authorization)
    {
        return $@"
        /// <summary>
        /// Represents an OAuth2 token.
        /// </summary>
        public sealed class OAuth2Token
        {{
            /// <summary>
            /// Gets or sets the access token.
            /// </summary>
            public string AccessToken {{ get; set; }} = string.Empty;

            /// <summary>
            /// Gets or sets the token type.
            /// </summary>
            public string TokenType {{ get; set; }} = ""Bearer"";

            /// <summary>
            /// Gets or sets the refresh token.
            /// </summary>
            public string? RefreshToken {{ get; set; }}

            /// <summary>
            /// Gets or sets the scope.
            /// </summary>
            public string? Scope {{ get; set; }}

            /// <summary>
            /// Gets or sets the expiration time.
            /// </summary>
            public global::System.DateTimeOffset? ExpiresAt {{ get; set; }}

            /// <summary>
            /// Determines whether the token should be refreshed.
            /// </summary>
            /// <param name=""clockSkew""></param>
            /// <returns></returns>
            public bool ShouldRefresh(
                global::System.TimeSpan clockSkew)
            {{
                if (clockSkew < global::System.TimeSpan.Zero)
                {{
                    throw new global::System.ArgumentOutOfRangeException(nameof(clockSkew));
                }}

                return ExpiresAt.HasValue &&
                    global::System.DateTimeOffset.UtcNow >= ExpiresAt.Value - clockSkew;
            }}

            /// <summary>
            /// Creates a clone of the token.
            /// </summary>
            /// <returns></returns>
            public OAuth2Token Clone()
            {{
                return new OAuth2Token
                {{
                    AccessToken = AccessToken,
                    TokenType = TokenType,
                    RefreshToken = RefreshToken,
                    Scope = Scope,
                    ExpiresAt = ExpiresAt,
                }};
            }}
        }}

        /// <summary>
        /// Stores OAuth2 tokens.
        /// </summary>
        public interface IOAuth2TokenStore
        {{
            /// <summary>
            /// Gets the currently stored OAuth2 token.
            /// </summary>
            /// <returns></returns>
            OAuth2Token? GetToken();

            /// <summary>
            /// Stores the specified OAuth2 token.
            /// </summary>
            /// <param name=""token""></param>
            void SetToken(
                OAuth2Token? token);
        }}

        /// <summary>
        /// Stores OAuth2 tokens in memory.
        /// </summary>
        public sealed class InMemoryOAuth2TokenStore : IOAuth2TokenStore
        {{
            private readonly object _syncRoot = new object();
            private OAuth2Token? _token;

            /// <inheritdoc/>
            public OAuth2Token? GetToken()
            {{
                lock (_syncRoot)
                {{
                    return _token?.Clone();
                }}
            }}

            /// <inheritdoc/>
            public void SetToken(
                OAuth2Token? token)
            {{
                lock (_syncRoot)
                {{
                    _token = token?.Clone();
                }}
            }}
        }}

        /// <summary>
        /// Coordinates OAuth2 token storage and refresh.
        /// </summary>
        public sealed class AutoSDKOAuth2Coordinator
        {{
            private readonly global::System.Threading.SemaphoreSlim _refreshSemaphore = new global::System.Threading.SemaphoreSlim(1, 1);
            private global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<OAuth2Token>>? _refreshTokenAsync;

            /// <summary>
            /// Gets or sets the OAuth2 token store.
            /// </summary>
            public IOAuth2TokenStore TokenStore {{ get; set; }} = new InMemoryOAuth2TokenStore();

            /// <summary>
            /// Gets or sets a value indicating whether OAuth2 tokens should be refreshed automatically.
            /// </summary>
            public bool AutoRefreshTokens {{ get; set; }} = true;

            /// <summary>
            /// Gets or sets the clock skew used when checking token expiration.
            /// </summary>
            public global::System.TimeSpan RefreshClockSkew {{ get; set; }} = global::System.TimeSpan.FromMinutes(1);

            /// <summary>
            /// Gets a value indicating whether OAuth2 tokens can be refreshed automatically.
            /// </summary>
            public bool CanAutoRefresh => AutoRefreshTokens && _refreshTokenAsync is not null;

            /// <summary>
            /// Gets the currently stored OAuth2 token.
            /// </summary>
            /// <returns></returns>
            public OAuth2Token? GetToken()
            {{
                return TokenStore.GetToken();
            }}

            /// <summary>
            /// Stores the specified OAuth2 token.
            /// </summary>
            /// <param name=""token""></param>
            public void SetToken(
                OAuth2Token? token)
            {{
                TokenStore.SetToken(token);
            }}

            /// <summary>
            /// Configures the OAuth2 token refresh callback.
            /// </summary>
            /// <param name=""refreshTokenAsync""></param>
            public void ConfigureRefresh(
                global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<OAuth2Token>> refreshTokenAsync)
            {{
                _refreshTokenAsync = refreshTokenAsync ?? throw new global::System.ArgumentNullException(nameof(refreshTokenAsync));
            }}

            /// <summary>
            /// Ensures the current OAuth2 token is applied and refreshed if needed.
            /// </summary>
            /// <param name=""applyToken""></param>
            /// <param name=""cancellationToken""></param>
            /// <returns></returns>
            public async global::System.Threading.Tasks.Task<bool> TryEnsureFreshTokenAsync(
                global::System.Action<OAuth2Token> applyToken,
                global::System.Threading.CancellationToken cancellationToken = default)
            {{
                applyToken = applyToken ?? throw new global::System.ArgumentNullException(nameof(applyToken));

                var token = GetToken();
                if (token is null)
                {{
                    return false;
                }}

                applyToken(token);
                if (!CanAutoRefresh || !token.ShouldRefresh(RefreshClockSkew))
                {{
                    return false;
                }}

                return await TryRefreshAsync(
                    currentAccessToken: token.AccessToken,
                    requireChangedToken: false,
                    applyToken: applyToken,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
            }}

            /// <summary>
            /// Attempts to refresh the OAuth2 token after an unauthorized response.
            /// </summary>
            /// <param name=""currentAccessToken""></param>
            /// <param name=""applyToken""></param>
            /// <param name=""cancellationToken""></param>
            /// <returns></returns>
            public async global::System.Threading.Tasks.Task<bool> TryRefreshAfterUnauthorizedAsync(
                string? currentAccessToken,
                global::System.Action<OAuth2Token> applyToken,
                global::System.Threading.CancellationToken cancellationToken = default)
            {{
                applyToken = applyToken ?? throw new global::System.ArgumentNullException(nameof(applyToken));
                if (!CanAutoRefresh)
                {{
                    return false;
                }}

                return await TryRefreshAsync(
                    currentAccessToken: currentAccessToken,
                    requireChangedToken: true,
                    applyToken: applyToken,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
            }}

            private async global::System.Threading.Tasks.Task<bool> TryRefreshAsync(
                string? currentAccessToken,
                bool requireChangedToken,
                global::System.Action<OAuth2Token> applyToken,
                global::System.Threading.CancellationToken cancellationToken)
            {{
                var refreshTokenAsync = _refreshTokenAsync;
                if (refreshTokenAsync is null)
                {{
                    return false;
                }}

                await _refreshSemaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
                try
                {{
                    var token = GetToken();
                    if (token is not null)
                    {{
                        if (!string.IsNullOrWhiteSpace(currentAccessToken) &&
                            !string.Equals(token.AccessToken, currentAccessToken, global::System.StringComparison.Ordinal))
                        {{
                            applyToken(token);
                            return true;
                        }}
                        if (!requireChangedToken && !token.ShouldRefresh(RefreshClockSkew))
                        {{
                            applyToken(token);
                            return true;
                        }}
                    }}

                    OAuth2Token refreshedToken;
                    try
                    {{
                        refreshedToken = await refreshTokenAsync(cancellationToken).ConfigureAwait(false);
                    }}
                    catch
                    {{
                        return false;
                    }}

                    if (string.IsNullOrWhiteSpace(refreshedToken.AccessToken))
                    {{
                        return false;
                    }}

                    SetToken(refreshedToken);
                    applyToken(refreshedToken);
                    return true;
                }}
                finally
                {{
                    _refreshSemaphore.Release();
                }}
            }}
        }}

        internal static class AutoSDKOAuth2Helpers
        {{
            internal static void SetAuthorization(
                global::System.Collections.Generic.List<global::{authorization.GlobalSettings.Namespace}.EndPointAuthorization> authorizations,
                OAuth2Token? token)
            {{
                authorizations = authorizations ?? throw new global::System.ArgumentNullException(nameof(authorizations));

                for (var i = authorizations.Count - 1; i >= 0; i--)
                {{
                    if (authorizations[i].Type == ""{SecuritySchemeType.OAuth2:G}"")
                    {{
                        authorizations.RemoveAt(i);
                    }}
                }}

                if (token is null)
                {{
                    return;
                }}

                authorizations.Add(new global::{authorization.GlobalSettings.Namespace}.EndPointAuthorization
                {{
                    Type = ""{SecuritySchemeType.OAuth2:G}"",
                    Location = ""{ParameterLocation.Header:G}"",
                    Name = string.IsNullOrWhiteSpace(token.TokenType) ? ""Bearer"" : token.TokenType,
                    Value = token.AccessToken,
                }});
            }}

            internal static async global::System.Threading.Tasks.Task<global::System.Net.Http.HttpResponseMessage> SendAsync(
                global::System.Net.Http.HttpClient httpClient,
                global::System.Net.Http.HttpRequestMessage request,
                global::System.Net.Http.HttpCompletionOption completionOption,
                global::System.Collections.Generic.List<global::{authorization.GlobalSettings.Namespace}.EndPointAuthorization> authorizations,
                AutoSDKOAuth2Coordinator oAuth2Coordinator,
                global::System.Threading.CancellationToken cancellationToken = default)
            {{
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
                {{
                    return response;
                }}

                var refreshed = await oAuth2Coordinator.TryRefreshAfterUnauthorizedAsync(
                    currentAccessToken: currentAccessToken,
                    applyToken: token => SetAuthorization(authorizations, token),
                    cancellationToken: cancellationToken).ConfigureAwait(false);
                if (!refreshed)
                {{
                    return response;
                }}

                response.Dispose();
                ApplyAuthorizationHeader(retryRequest, authorizations);
                return await httpClient.SendAsync(
                    request: retryRequest,
                    completionOption: completionOption,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
            }}

            private static string? GetCurrentAccessToken(
                global::System.Collections.Generic.List<global::{authorization.GlobalSettings.Namespace}.EndPointAuthorization> authorizations)
            {{
                foreach (var authorization in authorizations)
                {{
                    if (authorization.Type == ""{SecuritySchemeType.OAuth2:G}"")
                    {{
                        return authorization.Value;
                    }}
                }}

                return null;
            }}

            private static void ApplyAuthorizationHeader(
                global::System.Net.Http.HttpRequestMessage request,
                global::System.Collections.Generic.List<global::{authorization.GlobalSettings.Namespace}.EndPointAuthorization> authorizations)
            {{
                foreach (var authorization in authorizations)
                {{
                    if (authorization.Type == ""{SecuritySchemeType.OAuth2:G}"")
                    {{
                        request.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                            scheme: authorization.Name,
                            parameter: authorization.Value);
                        return;
                    }}
                }}
            }}

            private static async global::System.Threading.Tasks.Task<global::System.Net.Http.HttpRequestMessage> CloneRequestAsync(
                global::System.Net.Http.HttpRequestMessage request,
                global::System.Threading.CancellationToken cancellationToken)
            {{
                var clone = new global::System.Net.Http.HttpRequestMessage(
                    method: request.Method,
                    requestUri: request.RequestUri);
                clone.Version = request.Version;
#if NET6_0_OR_GREATER
                clone.VersionPolicy = request.VersionPolicy;
#endif
                foreach (var header in request.Headers)
                {{
                    clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }}
                if (request.Content is not null)
                {{
                    byte[] bytes;
#if NET5_0_OR_GREATER
                    bytes = await request.Content.ReadAsByteArrayAsync(cancellationToken).ConfigureAwait(false);
#else
                    bytes = await request.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
#endif
                    var content = new global::System.Net.Http.ByteArrayContent(bytes);
                    foreach (var header in request.Content.Headers)
                    {{
                        content.Headers.TryAddWithoutValidation(header.Key, header.Value);
                    }}

                    clone.Content = content;
                }}

                return clone;
            }}
        }}".Trim('\r', '\n');
    }

    private static string GenerateOAuth2ScopeEnum(Authorization authorization)
    {
        var scopes = GetDistinctOAuth2Scopes(authorization);
        if (scopes.Length == 0)
        {
            return string.Empty;
        }

        return $@"
        /// <summary>
        /// Known OAuth2 scopes.
        /// </summary>
        public enum OAuth2Scope
        {{
{scopes.Select(scope => $"            {scope.ToEnumValue(string.Empty, authorization.Settings).Name},").Inject()}
        }}".Trim('\r', '\n');
    }

    private static string GenerateOAuth2ScopeHelpers(Authorization authorization)
    {
        var scopes = GetDistinctOAuth2Scopes(authorization);
        if (scopes.Length == 0)
        {
            return string.Empty;
        }

        return $@"

        private static string ToOAuth2ScopeValue(
            OAuth2Scope scope)
        {{
            return scope switch
            {{
{scopes.Select(scope => $"                OAuth2Scope.{scope.ToEnumValue(string.Empty, authorization.Settings).Name} => \"{scope}\",").Inject()}
                _ => throw new global::System.NotImplementedException(""OAuth2 scope not implemented.""),
            }};
        }}

        private static string? JoinOAuth2Scopes(
            global::System.Collections.Generic.IEnumerable<OAuth2Scope>? scopes)
        {{
            if (scopes is null)
            {{
                return null;
            }}

            return string.Join("" "", global::System.Linq.Enumerable.Select(scopes, static x => ToOAuth2ScopeValue(x)));
        }}".Trim('\r', '\n');
    }

    private static string GenerateOAuth2TokenRead(
        Authorization authorization,
        string jsonVariableName,
        string requestedScopeVariableName)
    {
        return authorization.Settings.UsesNewtonsoftJson()
            ? $@"
            var payload = global::Newtonsoft.Json.Linq.JObject.Parse({jsonVariableName});
            var accessToken = payload.Value<string>(""access_token"");
            if (string.IsNullOrWhiteSpace(accessToken))
            {{
                throw new global::System.InvalidOperationException(""access_token was not present in the token response."");
            }}

            var tokenType = payload.Value<string>(""token_type"");
            var refreshToken = payload.Value<string>(""refresh_token"");
            var scope = payload.Value<string>(""scope"");
            var expiresIn = payload.Value<long?>(""expires_in"");
            var token = new OAuth2Token
            {{
                AccessToken = accessToken,
                TokenType = string.IsNullOrWhiteSpace(tokenType) ? ""Bearer"" : tokenType,
                RefreshToken = refreshToken,
                Scope = string.IsNullOrWhiteSpace(scope) ? {requestedScopeVariableName} : scope,
                ExpiresAt = expiresIn.HasValue
                    ? global::System.DateTimeOffset.UtcNow.AddSeconds(expiresIn.Value)
                    : (global::System.DateTimeOffset?)null,
            }};"
            : $@"
            using var jsonDocument = global::System.Text.Json.JsonDocument.Parse({jsonVariableName});
            if (!jsonDocument.RootElement.TryGetProperty(""access_token"", out var accessTokenElement))
            {{
                throw new global::System.InvalidOperationException(""access_token was not present in the token response."");
            }}

            var accessToken = accessTokenElement.GetString();
            if (string.IsNullOrWhiteSpace(accessToken))
            {{
                throw new global::System.InvalidOperationException(""access_token was empty in the token response."");
            }}

            string? tokenType = null;
            if (jsonDocument.RootElement.TryGetProperty(""token_type"", out var tokenTypeElement))
            {{
                tokenType = tokenTypeElement.GetString();
            }}

            string? refreshToken = null;
            if (jsonDocument.RootElement.TryGetProperty(""refresh_token"", out var refreshTokenElement))
            {{
                refreshToken = refreshTokenElement.GetString();
            }}

            string? scope = null;
            if (jsonDocument.RootElement.TryGetProperty(""scope"", out var scopeElement))
            {{
                scope = scopeElement.GetString();
            }}

            long? expiresIn = null;
            if (jsonDocument.RootElement.TryGetProperty(""expires_in"", out var expiresInElement))
            {{
                if (expiresInElement.ValueKind == global::System.Text.Json.JsonValueKind.Number &&
                    expiresInElement.TryGetInt64(out var expiresInValue))
                {{
                    expiresIn = expiresInValue;
                }}
                else if (expiresInElement.ValueKind == global::System.Text.Json.JsonValueKind.String &&
                         long.TryParse(expiresInElement.GetString(), out expiresInValue))
                {{
                    expiresIn = expiresInValue;
                }}
            }}

            var token = new OAuth2Token
            {{
                AccessToken = accessToken,
                TokenType = string.IsNullOrWhiteSpace(tokenType) ? ""Bearer"" : tokenType,
                RefreshToken = refreshToken,
                Scope = string.IsNullOrWhiteSpace(scope) ? {requestedScopeVariableName} : scope,
                ExpiresAt = expiresIn.HasValue
                    ? global::System.DateTimeOffset.UtcNow.AddSeconds(expiresIn.Value)
                    : (global::System.DateTimeOffset?)null,
            }};";
    }

    private static string[] GetDistinctOAuth2Scopes(Authorization authorization)
    {
        return authorization.Flows
            .SelectMany(static x => x.Scopes)
            .Where(static x => !string.IsNullOrWhiteSpace(x))
            .Distinct(StringComparer.Ordinal)
            .ToArray();
    }
}
