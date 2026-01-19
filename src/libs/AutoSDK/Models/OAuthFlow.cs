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
    public static OAuthFlow FromOpenApiSecurityScheme(
        string type,
        OpenApiOAuthFlow flow,
        Settings settings)
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
                .AsEquatableArray());
    }
}