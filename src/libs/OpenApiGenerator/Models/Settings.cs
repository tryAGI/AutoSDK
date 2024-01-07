using System.Collections.Immutable;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis.Diagnostics;

namespace OpenApiGenerator.Models;

internal readonly record struct Settings(
    string TargetFramework,
    string Namespace,
    string ClassName,
    NamingConvention NamingConvention,
    bool UseNSwag,

    EquatableArray<string> IncludeOperationIds,
    
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
            Namespace: options.GetGlobalOption(nameof(Namespace), prefix) ??
                       options.GetGlobalOption("PackageId") ??
                       options.GetGlobalOption("AssemblyName") ??
                       prefix,
            ClassName: options.GetGlobalOption(nameof(ClassName), prefix) ??
                       options.GetGlobalOption("PackageId")?.WithPostfix("Api") ??
                       options.GetGlobalOption("AssemblyName")?.WithPostfix("Api") ??
                       "Api",
            NamingConvention: Enum.TryParse<NamingConvention>(
                options.GetGlobalOption(nameof(NamingConvention), prefix) ??
                $"{default(NamingConvention):G}",
                ignoreCase: true,
                out var namingConvention) ? namingConvention : default,
            UseNSwag: bool.TryParse(
                options.GetGlobalOption(nameof(UseNSwag), prefix),
                out var useNSwag) && useNSwag,
            
            IncludeOperationIds: (options.GetGlobalOption(nameof(IncludeOperationIds), prefix)?.Split(';') ??
                                   Array.Empty<string>()).ToImmutableArray(),
            
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