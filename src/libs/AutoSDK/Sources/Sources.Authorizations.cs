using Microsoft.OpenApi.Models;
using AutoSDK.Extensions;
using AutoSDK.Models;

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
{authorization.Flows.Select(x => x.Type switch {
    nameof(OpenApiOAuthFlows.ClientCredentials) => $@"
        /// <summary>
        /// Authorize using OAuth2 authentication with client credentials.
        /// </summary>
        /// <param name=""clientId""></param>
        /// <param name=""clientSecret""></param>
        /// <param name=""scope""></param>
        /// <param name=""cancellationToken""></param>
        public async global::System.Threading.Tasks.Task {authorization.MethodName}WithCredentialsAsync(
            string clientId,
            string clientSecret,
            string scope,
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            clientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            clientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));

            var response = await HttpClient.PostAsync(new global::System.Uri(""{authorization.Flows}""), new global::System.Net.Http.FormUrlEncodedContent(new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
            {{
                new global::System.Collections.Generic.KeyValuePair<string, string>(""client_id"", clientId),
                new global::System.Collections.Generic.KeyValuePair<string, string>(""client_secret"", clientSecret),
                new global::System.Collections.Generic.KeyValuePair<string, string>(""grant_type"", ""client_credentials""),
                new global::System.Collections.Generic.KeyValuePair<string, string>(""scope"", scope),
            }})).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            var dictionary = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.Dictionary<string, string>>(json{(!string.IsNullOrWhiteSpace(authorization.Settings.JsonSerializerContext)
                            ? $", global::{authorization.Settings.JsonSerializerContext}.Default.DictionaryStringString"
                            : string.Empty)}) ??
                             throw new global::System.InvalidOperationException(""Deserialization failed."");

            var accessToken = dictionary[""access_token""];

            Authorizations.Clear();
            Authorizations.Add(new global::{authorization.Settings.Namespace}.EndPointAuthorization
            {{
                Type = ""{SecuritySchemeType.OAuth2:G}"",
                Location = ""{ParameterLocation.Header:G}"",
                Name = ""Bearer"",
                Value = accessToken,
            }});
        }}
",
    _ => string.Empty,
}).Inject()}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
        }
        
        return $@"
#nullable enable

namespace {authorization.Settings.Namespace}
{{
    public sealed partial class {authorization.Settings.ClassName}
    {{
        /// <summary>
        /// {(authorization.Type, authorization.Scheme.ToUpperInvariant(), authorization.In) switch
        {
            (SecuritySchemeType.Http, "BEARER", _) => "Authorize using bearer authentication.",
            (SecuritySchemeType.Http, "BASIC", _) => "Authorize using basic authentication.",
            (SecuritySchemeType.ApiKey, _, _) => "Authorize using ApiKey authentication.",
            _ => string.Empty,
        }}
        /// </summary>
{authorization.Parameters.Select(x => $@"
        /// <param name=""{x}""></param>").Inject()}
        public void {authorization.MethodName}(
{authorization.Parameters.Select(x => $@"
            string {x},").Inject().TrimEnd(',')})
        {{
{authorization.Parameters.Select(x => $@"
            {x} = {x} ?? throw new global::System.ArgumentNullException(nameof({x}));").Inject()}

            Authorizations.Clear();
            Authorizations.Add(new global::{authorization.Settings.Namespace}.EndPointAuthorization
            {{
                Type = ""{authorization.Type:G}"",
                Location = ""{authorization.In:G}"",
                Name = ""{(authorization.Type, authorization.Scheme.ToUpperInvariant(), authorization.In) switch
                {
                    (SecuritySchemeType.Http, "BEARER", _) => "Bearer",
                    (SecuritySchemeType.Http, "BASIC", _) => "Basic",
                    (SecuritySchemeType.ApiKey, _, _) => authorization.Name,
                    _ => string.Empty,
                }}"",
                Value = {(authorization.Type, authorization.Scheme.ToUpperInvariant(), authorization.In) switch
                {
                    (SecuritySchemeType.Http, "BEARER", _) => "apiKey",
                    (SecuritySchemeType.Http, "BASIC", _) => @"global::System.Convert.ToBase64String(
                    global::System.Text.Encoding.UTF8.GetBytes($""{username}:{password}""))",
                    (SecuritySchemeType.ApiKey, _, _) => "apiKey",
                    _ => "\"\"",
                }},
            }});
        }}
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
        /// <inheritdoc cref=""{authorization.Settings.ClassName}(global::System.Net.Http.HttpClient?, global::System.Uri?, global::System.Collections.Generic.List{{global::{authorization.Settings.Namespace}.EndPointAuthorization}}?, bool)""/>
        public {authorization.Settings.ClassName}(
{string.Join("\n", authorization.Parameters.Select(x => $@" 
            string {x},"))}
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::{authorization.Settings.Namespace}.EndPointAuthorization>? authorizations = null,
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
}