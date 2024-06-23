using Microsoft.OpenApi.Models;

namespace OpenApiGenerator.Core.Models;

public readonly record struct Authorization(
    SecuritySchemeType Type,
    string Scheme,
    Settings Settings
)
{
    public static Authorization FromOpenApiSecurityScheme(
        OpenApiSecurityScheme scheme,
        Settings settings)
    {
        scheme = scheme ?? throw new ArgumentNullException(nameof(scheme));
        
        return new Authorization(
            Type: scheme.Type,
            Scheme: scheme.Scheme,
            Settings: settings);
    }
}