using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Generation;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generators;

public static class ClientGeneratorMethods
{
    public static ImmutableArray<EndPoint> PrepareData(
        (string yaml, Settings settings) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, settings) = tuple;
        var openApiDocument = text.GetOpenApiDocument(cancellationToken);
        
        var includedOperationIds = new HashSet<string>(settings.IncludeOperationIds);
        
        return openApiDocument.Paths.SelectMany(path =>
            path.Value.Operations
                .Where(x =>
                    settings.GenerateMethods &&
                    (includedOperationIds.Count == 0 ||
                    includedOperationIds.Contains(x.Value.OperationId) ||
                    includedOperationIds.Contains(x.Value.OperationId.ToPropertyName())))
                .Select(operation => new EndPoint(
                    Id: operation.Value.OperationId,
                    Namespace: settings.Namespace,
                    ClassName: settings.ClassName,
                    BaseUrl: string.Empty,
                    Stream: operation.Value.Responses.Values.FirstOrDefault()?.Content.Keys.Any(x => x.Contains("application/x-ndjson")) ?? false,
                    Path: path.Key,
                    JsonSerializerType: settings.JsonSerializerType,
                    HttpMethod: operation.Key,
                    Summary: operation.Value.Summary,
                    RequestType: operation.Value.RequestBody?.Content.Values.FirstOrDefault()?.Schema?.Reference?.Id ?? string.Empty,
                    ResponseType: operation.Value.Responses.Values.FirstOrDefault()?
                        .Content.Values.FirstOrDefault()?.Schema?.Reference?.Id ?? string.Empty)))
            // Constructor
            .Concat(settings.GenerateConstructors ? [new EndPoint(
                Id: "Constructors",
                Namespace: settings.Namespace,
                ClassName: settings.ClassName,
                BaseUrl: openApiDocument.Servers.FirstOrDefault()?.Url ?? string.Empty,
                Stream: false,
                Path: string.Empty,
                JsonSerializerType: settings.JsonSerializerType,
                HttpMethod: OperationType.Get,
                Summary: string.Empty,
                RequestType: string.Empty,
                ResponseType: string.Empty)] : [])
            .ToImmutableArray();
    }
    
    public static FileWithName GetSourceCode(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{endPoint.FileNameWithoutExtension}.g.cs",
            Text: Sources.GenerateEndPoint(endPoint, cancellationToken: cancellationToken));
    }
}
