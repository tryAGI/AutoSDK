using System.Collections.Immutable;
using Microsoft.OpenApi;

namespace AutoSDK.Models;

public record struct OAuthFlow(
    string Type,
    string AuthorizationUrl,
    string TokenUrl,
    string RefreshUrl,
    EquatableArray<string> Scopes
)
{
    public string DeviceAuthorizationUrl { get; set; } = string.Empty;

    public static OAuthFlow FromOpenApiSecurityScheme(
        string type,
        OpenApiOAuthFlow flow,
        Settings settings)
    {
        return FromOpenApiSecurityScheme(type, flow, settings.ToCoreSettings());
    }

    public static OAuthFlow FromOpenApiSecurityScheme(
        string type,
        OpenApiOAuthFlow flow,
        CoreSettings settings)
    {
        return FromOpenApiSecurityScheme(type, flow);
    }

    public static OAuthFlow FromOpenApiSecurityScheme(
        string type,
        OpenApiOAuthFlow flow)
    {
        type = type ?? throw new ArgumentNullException(nameof(type));
        flow = flow ?? throw new ArgumentNullException(nameof(flow));

        return new OAuthFlow(
            Type: type,
            AuthorizationUrl: flow.AuthorizationUrl?.ToString() ?? string.Empty,
            TokenUrl: flow.TokenUrl?.ToString() ?? string.Empty,
            RefreshUrl: flow.RefreshUrl?.ToString() ?? string.Empty,
            Scopes: (flow.Scopes?.Select(x => x.Key).ToArray() ?? [])
                .ToImmutableArray()
                .AsEquatableArray())
        {
            DeviceAuthorizationUrl = flow.DeviceAuthorizationUrl?.ToString() ?? string.Empty,
        };
    }
}
