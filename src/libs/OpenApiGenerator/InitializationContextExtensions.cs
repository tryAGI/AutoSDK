using Microsoft.CodeAnalysis;
using OpenApiGenerator.Models;

namespace OpenApiGenerator;

internal static class InitializationContextExtensions
{
    public static IncrementalValueProvider<Settings> DetectSettings(
        this IncrementalGeneratorInitializationContext context)
    {
        return context.AnalyzerConfigOptionsProvider
            .Select((options, _) => Settings.FromOptions(options, prefix: "OpenApiGenerator"));
    }
}