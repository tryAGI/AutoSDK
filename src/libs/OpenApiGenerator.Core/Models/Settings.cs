using System.Collections.Immutable;
using OpenApiGenerator.Core.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct Settings(
    string TargetFramework,
    string Namespace,
    string ClassName,
    NamingConvention NamingConvention,
    JsonSerializerType JsonSerializerType,
    SdkFeatureUsage UseRequiredKeyword,

    ImmutableArray<string> IncludeOperationIds,
    
    bool GenerateModels,
    ModelStyle ModelStyle,
    ImmutableArray<string> IncludeModels);