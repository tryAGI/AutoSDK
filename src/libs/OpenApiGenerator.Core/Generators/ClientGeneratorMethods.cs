using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Generation;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generators;

public static class ClientGeneratorMethods
{
    public static ImmutableArray<EndPoint> PrepareData(
        (string text, Settings settings) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, settings) = tuple;
        if (settings is { GenerateSdk: false, GenerateMethods: false })
        {
            return ImmutableArray<EndPoint>.Empty;
        }
        
        var openApiDocument = text.GetOpenApiDocument(cancellationToken);
        
        var includedOperationIds = new HashSet<string>(settings.IncludeOperationIds);
        var excludedOperationIds = new HashSet<string>(settings.ExcludeOperationIds);
        foreach (var tag in settings.IncludeTags)
        {
            includedOperationIds.UnionWith(openApiDocument.FindAllOperationIdsForTag(tag));
        }
        foreach (var tag in settings.ExcludeTags)
        {
            excludedOperationIds.UnionWith(openApiDocument.FindAllOperationIdsForTag(tag));
        }
        
        var operations = openApiDocument.Paths.SelectMany(path =>
            path.Value.Operations
                .Where(x =>
                {
                    if (includedOperationIds.Count == 0 && excludedOperationIds.Count == 0)
                    {
                        return true;
                    }
                    
                    var methodName = x.Value.GetMethodName(path: path.Key, operationType: x.Key,
                        settings.MethodNamingConvention, settings.MethodNamingConventionFallback);
                    
                    return (includedOperationIds.Count == 0 ||
                            includedOperationIds.Contains(methodName)) &&
                           !excludedOperationIds.Contains(methodName);
                })
                .Select(operation => EndPoint.FromSchema(operation, settings, path.Key)))
                .ToArray();
        var authorizations = openApiDocument.SecurityRequirements
            .SelectMany(requirement => requirement)
            .Select(x => EndPoint.FromAuthorization(x.Key.Scheme, settings))
            .ToArray();
            
        EndPoint[] constructors = settings.GenerateSdk || settings.GenerateConstructors ? [new EndPoint(
                Id: "Constructors",
                Namespace: settings.Namespace,
                ClassName: settings.ClassName.Replace(".", string.Empty),
                BaseUrl: openApiDocument.Servers.FirstOrDefault()?.Url ?? string.Empty,
                Stream: false,
                Path: string.Empty,
                AuthorizationScheme: string.Empty,
                Properties: ImmutableArray<PropertyData>.Empty,
                TargetFramework: settings.TargetFramework,
                JsonSerializerType: settings.JsonSerializerType,
                JsonSerializerContext: settings.JsonSerializerContext,
                HttpMethod: OperationType.Get,
                Summary: string.Empty,
                RequestType: string.Empty,
                ResponseType: string.Empty)] : [];
            
        return [
            ..operations,
            ..authorizations,
            ..constructors,
        ];
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
