using System.Collections.Immutable;
using AutoSDK.Models.AsyncApi;
using AutoSDK.Extensions;
using Microsoft.OpenApi;

namespace AutoSDK.Models;

public record struct CorePipelineResult(
    SpecFormat Format,
    Settings Settings,
    Settings GlobalSettings,
    Settings SchemaSettings,
    OpenApiDocument? OpenApiDocument,
    AsyncApiDocument? AsyncApiDocument,
    IReadOnlyList<SchemaContext> Schemas,
    IReadOnlyList<SchemaContext> FilteredSchemas,
    ImmutableArray<OpenApiTag> AllTags,
    ImmutableArray<OpenApiTag> IncludedTags,
    ImmutableArray<string> IncludedOperationIds,
    ImmutableArray<string> ExcludedOperationIds,
    IReadOnlyDictionary<string, SchemaContext> ComponentSchemas,
    IReadOnlyDictionary<string, string> SyntheticEventSchemaNames,
    bool SkipModels,
    Times Times)
{
    public static CorePipelineResult Empty => new(
        Format: default,
        Settings: Settings.Default,
        GlobalSettings: Settings.Default,
        SchemaSettings: Settings.Default,
        OpenApiDocument: null,
        AsyncApiDocument: null,
        Schemas: [],
        FilteredSchemas: [],
        AllTags: [],
        IncludedTags: [],
        IncludedOperationIds: [],
        ExcludedOperationIds: [],
        ComponentSchemas: new Dictionary<string, SchemaContext>(StringComparer.Ordinal),
        SyntheticEventSchemaNames: new Dictionary<string, string>(StringComparer.Ordinal),
        SkipModels: false,
        Times: default);
}
