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
                UseNSwag: bool.Parse(options.GetGlobalOption("UseNSwag", prefix) ?? bool.FalseString)
                ));
    }
}