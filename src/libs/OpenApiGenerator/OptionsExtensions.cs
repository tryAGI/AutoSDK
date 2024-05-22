using System.Collections.Immutable;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using OpenApiGenerator.Core.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Naming.Methods;

namespace OpenApiGenerator;

public static class OptionsExtensions
{
    public static Settings GetSettings(
        this AnalyzerConfigOptionsProvider options,
        string prefix)
    {
        return new Settings(
            TargetFramework: options.GetGlobalOption("TargetFramework", prefix) ??
                             options.GetGlobalOption("TargetFramework") ??
                             "netstandard2.0",
            Namespace: options.GetGlobalOption(nameof(Settings.Namespace), prefix) ??
                       options.GetGlobalOption("PackageId") ??
                       options.GetGlobalOption("AssemblyName") ??
                       prefix,
            ClassName: options.GetGlobalOption(nameof(Settings.ClassName), prefix) ??
                       options.GetGlobalOption("PackageId")?.WithPostfix("Api") ??
                       options.GetGlobalOption("AssemblyName")?.WithPostfix("Api") ??
                       "Api",
            NamingConvention: options.GetEnumGlobalOption<NamingConvention>(nameof(Settings.NamingConvention), prefix),
            JsonSerializerType: options.GetEnumGlobalOption<JsonSerializerType>(nameof(Settings.JsonSerializerType), prefix),
            UseRequiredKeyword: options.GetEnumGlobalOption<SdkFeatureUsage>(nameof(Settings.UseRequiredKeyword), prefix),
            
            GenerateConstructors: options.GetBoolGlobalOption(nameof(Settings.GenerateConstructors), prefix),
            GenerateMethods: options.GetBoolGlobalOption(nameof(Settings.GenerateMethods), prefix),
            MethodNamingConvention: options.GetEnumGlobalOption<MethodNamingConvention>(nameof(Settings.MethodNamingConvention), prefix),
            MethodNamingConventionFallback: options.GetEnumGlobalOption(nameof(Settings.MethodNamingConventionFallback), prefix, defaultValue: MethodNamingConvention.MethodAndPath),
            GenerateMethodsAsHttpClientExtensions: options.GetBoolGlobalOption(nameof(Settings.GenerateMethodsAsHttpClientExtensions), prefix),
            GenerateMethodsUsingSystemNetHttpJson: options.GetBoolGlobalOption(nameof(Settings.GenerateMethodsUsingSystemNetHttpJson), prefix),
            IncludeOperationIds: (options.GetGlobalOption(nameof(Settings.IncludeOperationIds), prefix)?.Split(';') ??
                                   []).ToImmutableArray(),
            ExcludeOperationIds: (options.GetGlobalOption(nameof(Settings.ExcludeOperationIds), prefix)?.Split(';') ??
                                  []).ToImmutableArray(),
            IncludeTags: (options.GetGlobalOption(nameof(Settings.IncludeTags), prefix)?.Split(';') ??
                                  []).ToImmutableArray(),
            ExcludeTags: (options.GetGlobalOption(nameof(Settings.ExcludeTags), prefix)?.Split(';') ??
                                  []).ToImmutableArray(),
            JsonSerializerContext: options.GetGlobalOption(nameof(Settings.JsonSerializerContext), prefix) ?? string.Empty,
            GenerateSuperTypeForJsonSerializerContext: options.GetBoolGlobalOption(nameof(Settings.GenerateSuperTypeForJsonSerializerContext), prefix),
            
            GenerateModels: options.GetBoolGlobalOption(nameof(Settings.GenerateModels), prefix),
            ModelStyle: options.GetEnumGlobalOption<ModelStyle>(nameof(Settings.ModelStyle), prefix),
            IncludeModels: (options.GetGlobalOption(nameof(Settings.IncludeModels), prefix)?.Split(';') ??
                            []).ToImmutableArray(),
            ExcludeModels: (options.GetGlobalOption(nameof(Settings.ExcludeModels), prefix)?.Split(';') ??
                            []).ToImmutableArray(),
            
            GenerateSdk: options.GetBoolGlobalOption(nameof(Settings.GenerateSdk), prefix, defaultValue: true)
            );
    }
    
    public static bool GetBoolGlobalOption(
        this AnalyzerConfigOptionsProvider provider,
        string name,
        string? prefix = null,
        bool defaultValue = false)
    {
        provider = provider ?? throw new ArgumentNullException(nameof(provider));
        name = name ?? throw new ArgumentNullException(nameof(name));

        return bool.TryParse(
            provider.GetGlobalOption(name, prefix),
            out var value) ? value : defaultValue;
    }
    
    public static T GetEnumGlobalOption<T>(
        this AnalyzerConfigOptionsProvider provider,
        string name,
        string? prefix = null,
        T defaultValue = default) where T : struct, Enum
    {
        provider = provider ?? throw new ArgumentNullException(nameof(provider));
        name = name ?? throw new ArgumentNullException(nameof(name));

        return Enum.TryParse<T>(
            provider.GetGlobalOption(name, prefix) ??
            $"{defaultValue:G}",
            ignoreCase: true,
            out var value) ? value : default;
    }

    public static IncrementalValueProvider<Settings> DetectSettings(
        this IncrementalGeneratorInitializationContext context)
    {
        return context.AnalyzerConfigOptionsProvider
            .Select((options, _) => options.GetSettings(prefix: "OpenApiGenerator"));
    }
}