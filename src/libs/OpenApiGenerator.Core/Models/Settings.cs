using System.Collections.Immutable;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Naming.Methods;

namespace OpenApiGenerator.Core.Models;

public readonly record struct Settings(
    string TargetFramework,
    string Namespace,
    string ClassName,
    NamingConvention NamingConvention,
    JsonSerializerType JsonSerializerType,
    SdkFeatureUsage UseRequiredKeyword,

    bool GenerateConstructors,
    bool GroupByTags,
    bool GenerateMethods,
    MethodNamingConvention MethodNamingConvention,
    MethodNamingConvention MethodNamingConventionFallback,
    bool GenerateMethodsAsHttpClientExtensions,
    bool GenerateMethodsUsingSystemNetHttpJson,
    ImmutableArray<string> IncludeOperationIds,
    ImmutableArray<string> ExcludeOperationIds,
    ImmutableArray<string> IncludeTags,
    ImmutableArray<string> ExcludeTags,
    string JsonSerializerContext,
    bool GenerateJsonSerializerContextTypes,
    
    bool GenerateModels,
    ModelStyle ModelStyle,
    ImmutableArray<string> IncludeModels,
    ImmutableArray<string> ExcludeModels,
    
    bool GeneratePolyfills,
    
    bool GenerateSdk,
    bool FromCli);