using System.Collections.Immutable;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using OpenApiGenerator.Core.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;

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
            NamingConvention: Enum.TryParse<NamingConvention>(
                options.GetGlobalOption(nameof(Settings.NamingConvention), prefix) ??
                $"{default(NamingConvention):G}",
                ignoreCase: true,
                out var namingConvention) ? namingConvention : default,
            JsonSerializerType: Enum.TryParse<JsonSerializerType>(
                options.GetGlobalOption(nameof(Settings.JsonSerializerType), prefix) ??
                $"{default(JsonSerializerType):G}",
                ignoreCase: true,
                out var jsonSerializerType) ? jsonSerializerType : default,
            UseRequiredKeyword: options.GetEnumGlobalOption<SdkFeatureUsage>(nameof(Settings.UseRequiredKeyword), prefix),
            
            IncludeOperationIds: (options.GetGlobalOption(nameof(Settings.IncludeOperationIds), prefix)?.Split(';') ??
                                   []).ToImmutableArray(),
            
            GenerateModels: bool.TryParse(
                options.GetGlobalOption(nameof(Settings.GenerateModels), prefix),
                out var generateModels) && generateModels,
            ModelStyle: Enum.TryParse<ModelStyle>(
                options.GetGlobalOption(nameof(ModelStyle), prefix) ??
                $"{default(ModelStyle):G}",
                ignoreCase: true,
                out var modelStyle) ? modelStyle : default,
            IncludeModels: (options.GetGlobalOption(nameof(Settings.IncludeModels), prefix)?.Split(';') ??
                            []).ToImmutableArray()

            );
    }
    
    public static T GetEnumGlobalOption<T>(
        this AnalyzerConfigOptionsProvider provider,
        string name,
        string? prefix = null) where T : struct, Enum
    {
        provider = provider ?? throw new ArgumentNullException(nameof(provider));
        name = name ?? throw new ArgumentNullException(nameof(name));

        return Enum.TryParse<T>(
            provider.GetGlobalOption(name, prefix) ??
            $"{default(T):G}",
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