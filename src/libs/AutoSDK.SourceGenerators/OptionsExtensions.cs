using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;
using AutoSDK.Serialization.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace AutoSDK.SourceGenerators;

public static class OptionsExtensions
{
    public static Settings GetSettings(
        this AnalyzerConfigOptionsProvider options,
        string prefix,
        AdditionalText? additionalText = null)
    {
        return new Settings(
            TargetFramework: options.GetGlobalOption("TargetFramework", prefix) ??
                             options.GetGlobalOption("TargetFramework") ??
                             "netstandard2.0",
            Namespace: GetOptionFromAdditionalText(nameof(Settings.Namespace)) ??
                       options.GetGlobalOption(nameof(Settings.Namespace), prefix) ??
                       options.GetGlobalOption("PackageId") ??
                       options.GetGlobalOption("AssemblyName") ??
                       prefix,
            ClassName: GetOptionFromAdditionalText(nameof(Settings.ClassName)) ??
                       options.GetGlobalOption(nameof(Settings.ClassName), prefix) ??
                       options.GetGlobalOption("PackageId")?.WithPostfix("Api") ??
                       options.GetGlobalOption("AssemblyName")?.WithPostfix("Api") ??
                       "Api",
            ClsCompliantEnumPrefix: options.GetGlobalOption(nameof(Settings.ClsCompliantEnumPrefix), prefix) ??
                                    "x",
            NamingConvention: options.GetEnumGlobalOption<NamingConvention>(nameof(Settings.NamingConvention), prefix),
            JsonSerializerType: options.GetEnumGlobalOption<JsonSerializerType>(nameof(Settings.JsonSerializerType), prefix),
            UseRequiredKeyword: options.GetEnumGlobalOption<SdkFeatureUsage>(nameof(Settings.UseRequiredKeyword), prefix),
            UseExperimentalAttributes: options.GetEnumGlobalOption<SdkFeatureUsage>(nameof(Settings.UseExperimentalAttributes), prefix),
            UseSetsRequiredMembersAttributes: options.GetEnumGlobalOption<SdkFeatureUsage>(nameof(Settings.UseSetsRequiredMembersAttributes), prefix),
            
            GenerateConstructors: options.GetBoolGlobalOption(nameof(Settings.GenerateConstructors), prefix, defaultValue: Settings.Default.GenerateConstructors),
            GroupByTags: options.GetBoolGlobalOption(nameof(Settings.GroupByTags), prefix, defaultValue: Settings.Default.GroupByTags),
            GenerateMethods: options.GetBoolGlobalOption(nameof(Settings.GenerateMethods), prefix, defaultValue: Settings.Default.GenerateMethods),
            MethodNamingConvention: options.GetEnumGlobalOption<MethodNamingConvention>(nameof(Settings.MethodNamingConvention), prefix),
            MethodNamingConventionFallback: options.GetEnumGlobalOption(nameof(Settings.MethodNamingConventionFallback), prefix, defaultValue: MethodNamingConvention.MethodAndPath),
            GenerateMethodsAsHttpClientExtensions: options.GetBoolGlobalOption(nameof(Settings.GenerateMethodsAsHttpClientExtensions), prefix, defaultValue: Settings.Default.GenerateMethodsAsHttpClientExtensions),
            GenerateMethodsUsingSystemNetHttpJson: options.GetBoolGlobalOption(nameof(Settings.GenerateMethodsUsingSystemNetHttpJson), prefix, defaultValue: Settings.Default.GenerateMethodsUsingSystemNetHttpJson),
            IncludeOperationIds: (options.GetGlobalOption(nameof(Settings.IncludeOperationIds), prefix)?.Split(';') ??
                                   []).ToImmutableArray(),
            ExcludeOperationIds: (options.GetGlobalOption(nameof(Settings.ExcludeOperationIds), prefix)?.Split(';') ??
                                  []).ToImmutableArray(),
            IncludeTags: (options.GetGlobalOption(nameof(Settings.IncludeTags), prefix)?.Split(';') ??
                                  []).ToImmutableArray(),
            ExcludeTags: (options.GetGlobalOption(nameof(Settings.ExcludeTags), prefix)?.Split(';') ??
                                  []).ToImmutableArray(),
            ExcludeDeprecatedOperations: options.GetBoolGlobalOption(nameof(Settings.ExcludeDeprecatedOperations), prefix, defaultValue: Settings.Default.ExcludeDeprecatedOperations),
            JsonSerializerContext: options.GetGlobalOption(nameof(Settings.JsonSerializerContext), prefix) ?? string.Empty,
            GenerateJsonSerializerContextTypes: options.GetBoolGlobalOption(nameof(Settings.GenerateJsonSerializerContextTypes), prefix, defaultValue: Settings.Default.GenerateJsonSerializerContextTypes),
            ComputeDiscriminators: options.GetBoolGlobalOption(nameof(Settings.ComputeDiscriminators), prefix, defaultValue: Settings.Default.ComputeDiscriminators),
            AddMissingPathParameters: options.GetBoolGlobalOption(nameof(Settings.AddMissingPathParameters), prefix, defaultValue: Settings.Default.AddMissingPathParameters),
            
            GenerateModels: options.GetBoolGlobalOption(nameof(Settings.GenerateModels), prefix, defaultValue: Settings.Default.GenerateModels),
            GenerateModelValidationMethods: options.GetBoolGlobalOption(nameof(Settings.GenerateModelValidationMethods), prefix, defaultValue: Settings.Default.GenerateModelValidationMethods),
            ValidateAnyOfs: options.GetBoolGlobalOption(nameof(Settings.ValidateAnyOfs), prefix, defaultValue: Settings.Default.ValidateAnyOfs),
            ModelStyle: options.GetEnumGlobalOption<ModelStyle>(nameof(Settings.ModelStyle), prefix),
            IncludeModels: (options.GetGlobalOption(nameof(Settings.IncludeModels), prefix)?.Split(';') ??
                            []).ToImmutableArray(),
            ExcludeModels: (options.GetGlobalOption(nameof(Settings.ExcludeModels), prefix)?.Split(';') ??
                            []).ToImmutableArray(),
            
            GeneratePolyfills: options.GetBoolGlobalOption(nameof(Settings.GeneratePolyfills), prefix, defaultValue: Settings.Default.GeneratePolyfills),
            GenerateExceptions: options.GetBoolGlobalOption(nameof(Settings.GenerateExceptions), prefix, defaultValue: Settings.Default.GenerateExceptions),
            
            IgnoreOpenApiErrors: options.GetBoolGlobalOption(nameof(Settings.IgnoreOpenApiErrors), prefix, defaultValue: Settings.Default.IgnoreOpenApiErrors),
            IgnoreOpenApiWarnings: options.GetBoolGlobalOption(nameof(Settings.IgnoreOpenApiWarnings), prefix, defaultValue: Settings.Default.IgnoreOpenApiWarnings),
            
            GenerateSdk: options.GetBoolGlobalOption(nameof(Settings.GenerateSdk), prefix, defaultValue: Settings.Default.GenerateSdk),
            FromCli: false);
        
        string? GetOptionFromAdditionalText(string name)
        {
            if (additionalText == null)
            {
                return null;
            }
            
            return options.GetOption(additionalText, name, prefix: prefix);
        }
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