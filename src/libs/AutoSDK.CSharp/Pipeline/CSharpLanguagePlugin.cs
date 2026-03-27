using System.Collections.Generic;
using AutoSDK.Abstractions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public sealed class CSharpLanguagePlugin : ILanguagePlugin
{
    public static CSharpLanguagePlugin Instance { get; } = new();

    public string Language => "csharp";

    public AutoSDK.Models.Data Enrich(
        CorePipelineResult coreResult,
        CancellationToken cancellationToken = default)
    {
        return CSharpPipeline.Enrich(coreResult, cancellationToken);
    }

    public IReadOnlyList<FileWithName> GenerateFiles(
        AutoSDK.Models.Data data,
        CancellationToken cancellationToken = default)
    {
        return CSharpPipeline.GenerateFiles(data, cancellationToken);
    }
}
