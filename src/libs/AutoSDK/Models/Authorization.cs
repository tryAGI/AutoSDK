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
    Settings Settings
)
{
    public string MethodName => $"AuthorizeUsing{FriendlyName}";
    
    public static Authorization FromOpenApiSecurityScheme(
        OpenApiSecurityScheme scheme,
        Settings settings)
    {
        scheme = scheme ?? throw new ArgumentNullException(nameof(scheme));

        var friendlyName = (scheme.Type, scheme.Scheme, scheme.In) switch
        {
            (SecuritySchemeType.Http, "bearer", _) => "Bearer",
            (SecuritySchemeType.Http, "basic", _) => "Basic",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Header) => "ApiKeyInHeader",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Query) => "ApiKeyInQuery",
            (SecuritySchemeType.OAuth2, _, _) => "OAuth2",
            _ => scheme.Scheme?.ToPropertyName() ?? string.Empty,
        };
        string[] parameters = (scheme.Type, scheme.Scheme, scheme.In) switch
        {
            (SecuritySchemeType.Http, "bearer", _) => ["apiKey"],
            (SecuritySchemeType.Http, "basic", _) => ["username", "password"],
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Header) => ["apiKey"],
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Query) => ["apiKey"],
            _ => [],
        };
        
        return new Authorization(
            FriendlyName: friendlyName,
            Type: scheme.Type,
            In: (scheme.Type, scheme.Scheme) switch
            {
                (SecuritySchemeType.Http, "bearer") => ParameterLocation.Header,
                (SecuritySchemeType.OAuth2, _) => ParameterLocation.Header,
                _ => scheme.In,
            },
            Parameters: parameters.ToImmutableArray().AsEquatableArray(),
            Name: scheme.Name ?? string.Empty,
            Scheme: scheme.Scheme ?? string.Empty,
            Settings: settings);
    }
}