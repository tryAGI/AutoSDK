using System.Collections.Immutable;
using AutoSDK.Extensions;
using Microsoft.OpenApi.Models;

namespace AutoSDK.Models;

public readonly record struct Authorization(
    string FriendlyName,
    SecuritySchemeType Type,
    ParameterLocation In,
    EquatableArray<string> Parameters,
    string Name,
    string Scheme,
    Settings Settings,
    EquatableArray<OAuthFlow> Flows,
    string OpenIdConnectUrl
)
{
    public string MethodName => $"AuthorizeUsing{FriendlyName}";
    
    public static Authorization FromOpenApiSecurityScheme(
        OpenApiSecurityScheme scheme,
        Settings settings)
    {
        scheme = scheme ?? throw new ArgumentNullException(nameof(scheme));

        var friendlyName = (scheme.Type, scheme.Scheme?.ToUpperInvariant(), scheme.In) switch
        {
            (SecuritySchemeType.Http, "BEARER", _) => "Bearer",
            (SecuritySchemeType.Http, "BASIC", _) => "Basic",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Header) => "ApiKeyInHeader",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Query) => "ApiKeyInQuery",
            (SecuritySchemeType.OAuth2, _, _) => "OAuth2",
            _ => scheme.Scheme?.ToPropertyName() ?? string.Empty,
        };
        string[] parameters = (scheme.Type, scheme.Scheme?.ToUpperInvariant(), scheme.In) switch
        {
            (SecuritySchemeType.Http, "BEARER", _) => ["apiKey"],
            (SecuritySchemeType.Http, "BASIC", _) => ["username", "password"],
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Header) => ["apiKey"],
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Query) => ["apiKey"],
            _ => [],
        };
        
        return new Authorization(
            FriendlyName: friendlyName,
            Type: scheme.Type,
            In: (scheme.Type, scheme.Scheme?.ToUpperInvariant()) switch
            {
                (SecuritySchemeType.Http, "BEARER") => ParameterLocation.Header,
                (SecuritySchemeType.OAuth2, _) => ParameterLocation.Header,
                _ => scheme.In,
            },
            Parameters: parameters.ToImmutableArray().AsEquatableArray(),
            Name: scheme.Name ?? string.Empty,
            Scheme: scheme.Scheme ?? string.Empty,
            Settings: settings,
            Flows: new []
                {
                    scheme.Flows?.Implicit != null
                        ? OAuthFlow.FromOpenApiSecurityScheme(nameof(OpenApiOAuthFlows.Implicit), scheme.Flows.Implicit!, settings)
                        : (OAuthFlow?)null,
                    scheme.Flows?.Password != null
                        ? OAuthFlow.FromOpenApiSecurityScheme(nameof(OpenApiOAuthFlows.Password), scheme.Flows.Password!, settings)
                        : null,
                    scheme.Flows?.ClientCredentials != null
                        ? OAuthFlow.FromOpenApiSecurityScheme(nameof(OpenApiOAuthFlows.ClientCredentials), scheme.Flows.ClientCredentials!, settings)
                        : null,
                    scheme.Flows?.AuthorizationCode != null
                        ? OAuthFlow.FromOpenApiSecurityScheme(nameof(OpenApiOAuthFlows.AuthorizationCode), scheme.Flows.AuthorizationCode!, settings)
                        : null,
                }
                .Where(x => x != null)
                .Select(x => x!.Value)
                .ToImmutableArray()
                .AsEquatableArray(),
            OpenIdConnectUrl: scheme.OpenIdConnectUrl?.ToString() ?? string.Empty);
    }
}