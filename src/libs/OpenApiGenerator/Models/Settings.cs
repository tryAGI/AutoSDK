using H.Generators.Extensions;

namespace OpenApiGenerator.Models;

internal readonly record struct Settings(
    string TargetFramework,
    string Namespace,
    bool UseNSwag,
    
    bool GenerateModels,
    ModelStyle ModelStyle,
    EquatableArray<string> IncludeModels);