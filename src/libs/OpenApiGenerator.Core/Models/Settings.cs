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

    bool GenerateConstructors,
    bool GenerateMethods,
    bool GenerateMethodsAsHttpClientExtensions,
    bool GenerateMethodsUsingSystemNetHttpJson,
    ImmutableArray<string> IncludeOperationIds,
    ImmutableArray<string> ExcludeOperationIds,
    string JsonSerializerContext,
    bool GenerateSuperTypeForJsonSerializerContext,
    
    bool GenerateModels,
    ModelStyle ModelStyle,
    ImmutableArray<string> IncludeModels,
    ImmutableArray<string> ExcludeModels,
    
    bool GenerateSdk);