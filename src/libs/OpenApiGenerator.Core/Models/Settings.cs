using System.Collections.Immutable;

namespace OpenApiGenerator.Core.Models;

public readonly record struct Settings(
    string TargetFramework,
    string Namespace,
    string ClassName,
    NamingConvention NamingConvention,

    ImmutableArray<string> IncludeOperationIds,
    
    bool GenerateModels,
    ModelStyle ModelStyle,
    ImmutableArray<string> IncludeModels);