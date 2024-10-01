using Microsoft.OpenApi.Models;
using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateAuthorization(
        Authorization authorization)
    {
        if (authorization.Type is SecuritySchemeType.OAuth2 or SecuritySchemeType.OpenIdConnect)
        {
            return string.Empty;
        }
        
        var name = (authorization.Type, authorization.Scheme, authorization.In) switch
        {
            (SecuritySchemeType.Http, "bearer", _) => "Bearer",
            (SecuritySchemeType.Http, "basic", _) => "Basic",
            (SecuritySchemeType.ApiKey, _, _) => authorization.Name,
            _ => string.Empty,
        };
        var value = (authorization.Type, authorization.Scheme, authorization.In) switch
        {
            (SecuritySchemeType.Http, "bearer", _) => "apiKey",
            (SecuritySchemeType.Http, "basic", _) => @"global::System.Convert.ToBase64String(
                    global::System.Text.Encoding.UTF8.GetBytes($""{username}:{password}""))",
            (SecuritySchemeType.ApiKey, _, _) => "apiKey",
            _ => string.Empty,
        };
        var xmlDocs = (authorization.Type, authorization.Scheme, authorization.In) switch
        {
            (SecuritySchemeType.Http, "bearer", _) => "Authorize using bearer authentication.",
            (SecuritySchemeType.Http, "basic", _) => "Authorize using basic authentication.",
            (SecuritySchemeType.ApiKey, _, _) => "Authorize using ApiKey authentication.",
            _ => string.Empty,
        };
        
        return $@"
#nullable enable

namespace {authorization.Settings.Namespace}
{{
    public sealed partial class {authorization.Settings.ClassName}
    {{
        /// <summary>
        /// {xmlDocs}
        /// </summary>
{authorization.Parameters.Select(x => $@"
        /// <param name=""{x}""></param>").Inject()}
        public void {authorization.MethodName}(
{authorization.Parameters.Select(x => $@"
            string {x},").Inject().TrimEnd(',')})
        {{
{authorization.Parameters.Select(x => $@"
            {x} = {x} ?? throw new global::System.ArgumentNullException(nameof({x}));").Inject()}

            _authorization = new global::{authorization.Settings.Namespace}.EndPointAuthorization
            {{
                Name = ""{name}"",
                Value = {value},
            }};
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
        /// <inheritdoc cref=""{authorization.Settings.ClassName}(global::System.Net.Http.HttpClient?, global::System.Uri?)""/>
        public {authorization.Settings.ClassName}(
{string.Join("\n", authorization.Parameters.Select(x => $@" 
            string {x},"))}
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null) : this(httpClient, baseUri)
        {{
            Authorizing(_httpClient, {string.Join(", ", authorization.Parameters.Select(x => $"ref {x}"))});

            {authorization.MethodName}({string.Join(", ", authorization.Parameters.Select(x => $"{x}"))});

            Authorized(_httpClient);
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