using System.Collections.Immutable;
using Microsoft.OpenApi;

namespace AutoSDK.Models;

public record struct Authorization(
    string FriendlyName,
    string MethodName,
    string SchemeId,
    SecuritySchemeType? Type,
    ParameterLocation? In,
    EquatableArray<string> Parameters,
    string Name,
    string Scheme,
    Settings Settings,
    Settings GlobalSettings,
    EquatableArray<OAuthFlow> Flows,
    string OpenIdConnectUrl
)
{
    public string OAuth2MetadataUrl { get; set; } = string.Empty;

    public bool IsDeprecated { get; set; }

    public EquatableArray<string> WebSocketSubProtocols { get; set; } =
        ImmutableArray<string>.Empty.AsEquatableArray();
}
