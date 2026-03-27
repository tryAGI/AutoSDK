using System.Collections.Immutable;

namespace AutoSDK.Models;

public record struct CoreSettings(
    bool IgnoreOpenApiErrors,
    bool IgnoreOpenApiWarnings,
    string BaseUrl,
    ImmutableArray<string> SecuritySchemes,
    bool ComputeDiscriminators,
    bool AddMissingPathParameters,
    ImmutableArray<string> OpenApiOverrides)
{
    public static CoreSettings Default => new(
        IgnoreOpenApiErrors: true,
        IgnoreOpenApiWarnings: true,
        BaseUrl: string.Empty,
        SecuritySchemes: ImmutableArray<string>.Empty,
        ComputeDiscriminators: false,
        AddMissingPathParameters: true,
        OpenApiOverrides: ImmutableArray<string>.Empty);
}
