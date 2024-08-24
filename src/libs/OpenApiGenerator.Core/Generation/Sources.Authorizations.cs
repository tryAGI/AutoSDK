using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateAuthorization(
        Authorization authorization)
    {
        var body = (authorization.Type, authorization.Scheme, authorization.In) switch
        {
            (SecuritySchemeType.Http, "bearer", _) => $@" 
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name=""apiKey""></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {{
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _httpClient.DefaultRequestHeaders.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                scheme: ""Bearer"",
                parameter: apiKey);
        }}",
            (SecuritySchemeType.Http, "basic", _) => $@" 
        /// <summary>
        /// Authorize using basic authentication.
        /// </summary>
        /// <param name=""username""></param>
        /// <param name=""password""></param>
        public void AuthorizeUsingBasic(
            string username,
            string password)
        {{
            username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            password = password ?? throw new global::System.ArgumentNullException(nameof(password));

            _httpClient.DefaultRequestHeaders.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                scheme: ""Basic"",
                parameter: global::System.Convert.ToBase64String(
                    global::System.Text.Encoding.UTF8.GetBytes($""{{username}}:{{password}}"")));
        }}",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Header) => $@" 
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name=""apiKey""></param>
        public void AuthorizeUsingApiKey(
            string apiKey)
        {{
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _httpClient.DefaultRequestHeaders.Add(""{authorization.Name}"", apiKey);
        }}",
            _ => " ",
        };
        
        return $@"
#nullable enable

namespace {authorization.Settings.Namespace}
{{
    public sealed partial class {authorization.Settings.ClassName}
    {{
{body}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    public static string GenerateMainAuthorizationConstructor(
        Authorization authorization)
    {
        var methodName = (authorization.Type, authorization.Scheme, authorization.In) switch
        {
            (SecuritySchemeType.Http, "bearer", _) => "AuthorizeUsingBearer",
            (SecuritySchemeType.Http, "basic", _) => "AuthorizeUsingBasic",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Header) => "AuthorizeUsingApiKey",
            _ => string.Empty,
        };
        string[] parameters = (authorization.Type, authorization.Scheme, authorization.In) switch
        {
            (SecuritySchemeType.Http, "bearer", _) => ["apiKey"],
            (SecuritySchemeType.Http, "basic", _) => ["username", "password"],
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Header) => ["apiKey"],
            _ => [],
        };
        if (parameters.Length == 0)
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
{string.Join("\n", parameters.Select(x => $@" 
            string {x},"))}
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null) : this(httpClient, baseUri)
        {{
            {methodName}({string.Join(", ", parameters.Select(x => $"{x}"))});
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}