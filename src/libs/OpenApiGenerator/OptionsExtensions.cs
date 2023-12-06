using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using OpenApiGenerator.Models;

namespace OpenApiGenerator;

internal static class OptionsExtensions
{
    public static IncrementalValueProvider<Settings> DetectSettings(
        this IncrementalGeneratorInitializationContext context)
    {
        const string prefix = "OpenApiGenerator";

        return context.AnalyzerConfigOptionsProvider
            .Select((options, _) => new Settings(
                TargetFramework: options.GetGlobalOption("TargetFramework", prefix) ??
                                 options.GetGlobalOption("TargetFramework") ??
                                 "netstandard2.0",
                Namespace: options.GetGlobalOption("Namespace", prefix) ??
                           options.GetGlobalOption("PackageId") ??
                           options.GetGlobalOption("AssemblyName") ??
                           prefix,
                UseNSwag: bool.TryParse(
                    options.GetGlobalOption("UseNSwag", prefix),
                    out var useNSwag) && useNSwag,
                
                GenerateModels: bool.TryParse(
                    options.GetGlobalOption(nameof(Settings.GenerateModels), prefix),
                    out var generateModels) && generateModels,
                ModelStyle: Enum.TryParse<ModelStyle>(
                    options.GetGlobalOption(nameof(Settings.ModelStyle), prefix) ??
                        $"{default(ModelStyle):G}",
                    ignoreCase: true,
                    out var modelStyle) ? modelStyle : default
                
                ));
    }
}