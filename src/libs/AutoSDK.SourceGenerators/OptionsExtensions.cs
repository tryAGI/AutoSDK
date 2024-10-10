using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;
using AutoSDK.Serialization.Json;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace AutoSDK.SourceGenerators;

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
            ClsCompliantEnumPrefix: options.GetGlobalOption(nameof(Settings.ClsCompliantEnumPrefix), prefix) ??
                                    "x",
            NamingConvention: options.GetEnumGlobalOption<NamingConvention>(nameof(Settings.NamingConvention), prefix),
            JsonSerializerType: options.GetEnumGlobalOption<JsonSerializerType>(nameof(Settings.JsonSerializerType), prefix),
            UseRequiredKeyword: options.GetEnumGlobalOption<SdkFeatureUsage>(nameof(Settings.UseRequiredKeyword), prefix),
            
            GenerateConstructors: options.GetBoolGlobalOption(nameof(Settings.GenerateConstructors), prefix),
            GroupByTags: options.GetBoolGlobalOption(nameof(Settings.GroupByTags), prefix, defaultValue: true),
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
            ExcludeDeprecatedOperations: options.GetBoolGlobalOption(nameof(Settings.ExcludeDeprecatedOperations), prefix),
            JsonSerializerContext: options.GetGlobalOption(nameof(Settings.JsonSerializerContext), prefix) ?? string.Empty,
            GenerateJsonSerializerContextTypes: options.GetBoolGlobalOption(nameof(Settings.GenerateJsonSerializerContextTypes), prefix),
            
            GenerateModels: options.GetBoolGlobalOption(nameof(Settings.GenerateModels), prefix),
            ValidateAnyOfs: options.GetBoolGlobalOption(nameof(Settings.ValidateAnyOfs), prefix),
            ModelStyle: options.GetEnumGlobalOption<ModelStyle>(nameof(Settings.ModelStyle), prefix),
            IncludeModels: (options.GetGlobalOption(nameof(Settings.IncludeModels), prefix)?.Split(';') ??
                            []).ToImmutableArray(),
            ExcludeModels: (options.GetGlobalOption(nameof(Settings.ExcludeModels), prefix)?.Split(';') ??
                            []).ToImmutableArray(),
            
            GeneratePolyfills: options.GetBoolGlobalOption(nameof(Settings.GeneratePolyfills), prefix, defaultValue: true),
            
            IgnoreOpenApiErrors: options.GetBoolGlobalOption(nameof(Settings.IgnoreOpenApiErrors), prefix),
            IgnoreOpenApiWarnings: options.GetBoolGlobalOption(nameof(Settings.IgnoreOpenApiWarnings), prefix, defaultValue: true),
            
            GenerateSdk: options.GetBoolGlobalOption(nameof(Settings.GenerateSdk), prefix, defaultValue: true),
            FromCli: false);
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
            .Select((options, _) => options.GetSettings(prefix: "AutoSDK"));
    }
}