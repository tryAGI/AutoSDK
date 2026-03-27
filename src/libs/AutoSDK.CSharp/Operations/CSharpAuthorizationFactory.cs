using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static class CSharpAuthorizationFactory
{
    public static Authorization FromOpenApiSecurityScheme(
        OpenApiSecuritySchemeReference scheme,
        CSharpSettings settings,
        CSharpSettings globalSettings)
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

        return Create(
            friendlyName: friendlyName,
            type: scheme.Type,
            parameterLocation: (scheme.Type, scheme.Scheme?.ToUpperInvariant()) switch
            {
                (SecuritySchemeType.Http, "BEARER") => ParameterLocation.Header,
                (SecuritySchemeType.OAuth2, _) => ParameterLocation.Header,
                _ => scheme.In,
            },
            parameters: parameters.ToImmutableArray().AsEquatableArray(),
            name: scheme.Name ?? string.Empty,
            scheme: scheme.Scheme ?? string.Empty,
            settings: settings,
            globalSettings: globalSettings,
            flows: new[]
                {
                    scheme.Flows?.Implicit != null
                        ? OAuthFlow.FromOpenApiSecurityScheme(nameof(OpenApiOAuthFlows.Implicit), scheme.Flows.Implicit!)
                        : (OAuthFlow?)null,
                    scheme.Flows?.Password != null
                        ? OAuthFlow.FromOpenApiSecurityScheme(nameof(OpenApiOAuthFlows.Password), scheme.Flows.Password!)
                        : null,
                    scheme.Flows?.ClientCredentials != null
                        ? OAuthFlow.FromOpenApiSecurityScheme(nameof(OpenApiOAuthFlows.ClientCredentials), scheme.Flows.ClientCredentials!)
                        : null,
                    scheme.Flows?.AuthorizationCode != null
                        ? OAuthFlow.FromOpenApiSecurityScheme(nameof(OpenApiOAuthFlows.AuthorizationCode), scheme.Flows.AuthorizationCode!)
                        : null,
                }
                .Where(x => x != null)
                .Select(x => x!.Value)
                .ToImmutableArray()
                .AsEquatableArray(),
            openIdConnectUrl: scheme.OpenIdConnectUrl?.ToString() ?? string.Empty);
    }

    public static Authorization Create(
        string friendlyName,
        SecuritySchemeType? type,
        ParameterLocation? parameterLocation,
        EquatableArray<string> parameters,
        string name,
        string scheme,
        CSharpSettings settings,
        CSharpSettings globalSettings,
        EquatableArray<OAuthFlow> flows,
        string openIdConnectUrl)
    {
        return new Authorization(
            FriendlyName: friendlyName,
            MethodName: $"AuthorizeUsing{friendlyName}",
            Type: type,
            In: parameterLocation,
            Parameters: parameters,
            Name: name,
            Scheme: scheme,
            Settings: settings,
            GlobalSettings: globalSettings,
            Flows: flows,
            OpenIdConnectUrl: openIdConnectUrl);
    }
}
