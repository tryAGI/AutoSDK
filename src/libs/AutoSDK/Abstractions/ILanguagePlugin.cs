using System.Collections.Generic;
using AutoSDK.Models;

namespace AutoSDK.Abstractions;

public interface ILanguagePlugin
{
    string Language { get; }

    AutoSDK.Models.Data Enrich(
        CorePipelineResult coreResult,
        CancellationToken cancellationToken = default);

    IReadOnlyList<FileWithName> GenerateFiles(
        AutoSDK.Models.Data data,
        CancellationToken cancellationToken = default);
}
