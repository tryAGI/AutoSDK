using Microsoft.OpenApi.Models;

namespace OpenApiGenerator.Core.Models;

public readonly record struct Authorization(
    SecuritySchemeType Type,
    ParameterLocation In,
    string Name,
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
            In: scheme.In,
            Name: scheme.Name ?? string.Empty,
            Scheme: scheme.Scheme ?? string.Empty,
            Settings: settings);
    }
}