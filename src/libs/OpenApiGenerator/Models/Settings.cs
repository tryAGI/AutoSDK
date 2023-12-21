using System.Collections.Immutable;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis.Diagnostics;

namespace OpenApiGenerator.Models;

internal readonly record struct Settings(
    string TargetFramework,
    string Namespace,
    NamingConvention NamingConvention,
    bool UseNSwag,

    bool GenerateModels,
    ModelStyle ModelStyle,
    EquatableArray<string> IncludeModels)
{
    public static Settings FromOptions(
        AnalyzerConfigOptionsProvider options,
        string prefix)
    {
        return new Settings(
            TargetFramework: options.GetGlobalOption("TargetFramework", prefix) ??
                             options.GetGlobalOption("TargetFramework") ??
                             "netstandard2.0",
            Namespace: options.GetGlobalOption("Namespace", prefix) ??
                       options.GetGlobalOption("PackageId") ??
                       options.GetGlobalOption("AssemblyName") ??
                       prefix,
            NamingConvention: Enum.TryParse<NamingConvention>(
                options.GetGlobalOption(nameof(NamingConvention), prefix) ??
                $"{default(NamingConvention):G}",
                ignoreCase: true,
                out var namingConvention) ? namingConvention : default,
            UseNSwag: bool.TryParse(
                options.GetGlobalOption("UseNSwag", prefix),
                out var useNSwag) && useNSwag,
            
            GenerateModels: bool.TryParse(
                options.GetGlobalOption(nameof(GenerateModels), prefix),
                out var generateModels) && generateModels,
            ModelStyle: Enum.TryParse<ModelStyle>(
                options.GetGlobalOption(nameof(ModelStyle), prefix) ??
                $"{default(ModelStyle):G}",
                ignoreCase: true,
                out var modelStyle) ? modelStyle : default,
            IncludeModels: (options.GetGlobalOption(nameof(IncludeModels), prefix)?.Split(';') ??
                            Array.Empty<string>()).ToImmutableArray()

            );
    }
}