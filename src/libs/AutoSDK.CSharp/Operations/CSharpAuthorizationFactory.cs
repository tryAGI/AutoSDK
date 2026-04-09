using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Properties;
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
            (SecuritySchemeType.Http, _, _) => scheme.Scheme?.ToPropertyName() ?? "Http",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Header) => "ApiKeyInHeader",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Query) => "ApiKeyInQuery",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Cookie) => "ApiKeyInCookie",
            (SecuritySchemeType.OAuth2, _, _) => "OAuth2",
            (SecuritySchemeType.OpenIdConnect, _, _) => "OpenIdConnect",
            (SecuritySchemeType.MutualTLS, _, _) => "MutualTls",
            _ => scheme.Name?.ToPropertyName() ?? scheme.Scheme?.ToPropertyName() ?? "Authorization",
        };
        string[] parameters = (scheme.Type, scheme.Scheme?.ToUpperInvariant(), scheme.In) switch
        {
            (SecuritySchemeType.Http, "BEARER", _) => ["apiKey"],
            (SecuritySchemeType.Http, "BASIC", _) => ["username", "password"],
            (SecuritySchemeType.Http, _, _) => ["apiKey"],
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Header) => ["apiKey"],
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Query) => ["apiKey"],
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Cookie) => ["apiKey"],
            (SecuritySchemeType.OpenIdConnect, _, _) => ["accessToken"],
            _ => [],
        };

        return Create(
            friendlyName: friendlyName,
            schemeId: scheme.Reference?.Id ??
                      scheme.Name ??
                      scheme.Scheme ??
                      friendlyName,
            type: scheme.Type,
            parameterLocation: (scheme.Type, scheme.Scheme?.ToUpperInvariant()) switch
            {
                (SecuritySchemeType.Http, _) => ParameterLocation.Header,
                (SecuritySchemeType.OAuth2, _) => ParameterLocation.Header,
                (SecuritySchemeType.OpenIdConnect, _) => ParameterLocation.Header,
                (SecuritySchemeType.MutualTLS, _) => null,
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
        string schemeId,
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
        friendlyName = NormalizeFriendlyName(friendlyName, settings);
        schemeId = NormalizeFriendlyName(schemeId, settings);

        return new Authorization(
            FriendlyName: friendlyName,
            MethodName: $"AuthorizeUsing{friendlyName}",
            SchemeId: schemeId,
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

    internal static string NormalizeFriendlyName(
        string friendlyName,
        CSharpSettings settings)
    {
        if (string.IsNullOrWhiteSpace(friendlyName))
        {
            return "Authorization";
        }

        var normalizedName = friendlyName.ToClassName();
        normalizedName = CSharpPropertyNameGenerator.SanitizeName(
            normalizedName,
            settings.ClsCompliantEnumPrefix,
            skipHandlingWordSeparators: true,
            identifierCharacterSet: settings.IdentifierCharacterSet);
        normalizedName = CSharpPropertyNameGenerator.AvoidObjectMemberNameCollision(normalizedName);

        return string.IsNullOrWhiteSpace(normalizedName)
            ? "Authorization"
            : normalizedName;
    }
}
