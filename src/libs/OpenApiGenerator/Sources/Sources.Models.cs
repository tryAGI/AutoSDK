using System.Collections.Immutable;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.OpenApi.Readers;
using OpenApiGenerator.Models;
using OpenApiSchema = Microsoft.OpenApi.Models.OpenApiSchema;
using NSwag;

namespace OpenApiGenerator;

internal static partial class Sources
{
    public static EquatableArray<FileWithName> GenerateModel(
        AdditionalText text,
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        var yaml = text.GetText(cancellationToken)?.ToString() ?? string.Empty;
        var openApi = Task.Run(() =>
            OpenApiYamlDocument.FromYamlAsync(yaml, cancellationToken), cancellationToken).Result;
        var openApiDocument = new OpenApiStringReader().Read(yaml, out _);
        var schemas = openApiDocument.Components?.Schemas ?? new Dictionary<string, OpenApiSchema>();
        var prefix = Path.GetFileName(text.Path);
        var allAdditionalExcludedTypeNames = schemas.Keys
            .Select(schemaKey => GetAdditionalExcludedTypeNames(schemaKey, schemas))
            .SelectMany(x => x)
            .ToArray();
        
        var files = new List<FileWithName>();
        files.AddRange(schemas.Keys.Select(schemaKey =>
        {
            var excludedTypeNames = schemas.Keys
                .Where(x => x != schemaKey)
                .Concat(allAdditionalExcludedTypeNames.Except(GetAdditionalExcludedTypeNames(schemaKey, schemas)))
                .ToArray();
            
            return new FileWithName(
                Name: $"{prefix}.Models.{schemaKey}.cs",
                Text: Generate(openApi, settings, excludedTypeNames));
        }));
        
        return files.ToImmutableArray();
    }
}