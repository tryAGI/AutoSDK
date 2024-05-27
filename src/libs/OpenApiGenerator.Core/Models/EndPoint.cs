using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct EndPoint(
    string Id,
    string Namespace,
    string ClassName,
    string BaseUrl,
    bool Stream,
    string Path,
    string AuthorizationScheme,
    ImmutableArray<PropertyData> Properties,
    string TargetFramework,
    JsonSerializerType JsonSerializerType,
    string JsonSerializerContext,
    OperationType HttpMethod,
    string Summary,
    string RequestType,
    string ResponseType,
    ImmutableArray<ModelData> AdditionalModels
)
{
    public string MethodName => $"{NotAsyncMethodName}Async";
    public string NotAsyncMethodName => Id.ToPropertyName();
    
    public string FileNameWithoutExtension => !string.IsNullOrWhiteSpace(AuthorizationScheme)
        ? $"{Namespace}.{ClassName}.Authorization"
        : string.IsNullOrWhiteSpace(Path)
            ? $"{Namespace}.{ClassName}"
            : $"{Namespace}.{ClassName}.{Id.ToPropertyName()}";
    
    public static EndPoint FromSchema(
        KeyValuePair<OperationType, OpenApiOperation> operation,
        Settings settings,
        string path)
    {
        path = path ?? throw new ArgumentNullException(nameof(path));
        
        var requiredParameters = new HashSet<string>(operation.Value.Parameters
            .Where(x => x.Required || x.In == ParameterLocation.Path)
            .Select(x => x.Name));
        var parameters = operation.Value.Parameters
            .Select(x => PropertyData.FromSchema(
                schema: x.Schema.WithKey(x.Name),
                requiredProperties: requiredParameters,
                parameterLocation: x.In,
                parameterStyle: x.Style,
                parameterExplode: x.Explode,
                operationId: operation.Value.OperationId,
                settings: settings,
                parents: []))
            .ToArray();
        
        // Ensure that parameters with the same name are unique
        var duplicateParameters = parameters
            .GroupBy(x => x.Name)
            .Where(x => x.Count() > 1)
            .Select(x => x.Key)
            .ToArray();
        foreach (var duplicateParameter in duplicateParameters)
        {
            var index = 1;
            for (var i = 0; i < parameters.Length; i++)
            {
                if (parameters[i].Name == duplicateParameter)
                {
                    parameters[i] = parameters[i] with
                    {
                        Name = $"{parameters[i].Name}{index++}",
                    };
                }
            }
        }
        
        var preparedPath = path.PreparePath(parameters);

        var id = operation.Value.GetMethodName(
            path: path,
            operationType: operation.Key,
            settings.MethodNamingConvention,
            settings.MethodNamingConventionFallback);
        var objectParameters = operation.Value.Parameters
            .Where(x => x.Schema.Type == "object")
            .Select(x => ModelData.FromSchema(
                    x.Schema.WithKey(id + x.Name.ToPropertyName()),
                    settings) with
                {
                    Schema = default,
                })
            .ToArray();
        var enumParameters = operation.Value.Parameters
            .Where(x => x.Schema.Enum?.Any() == true || x.Schema.Items?.Enum?.Any() == true)
            .Select(x => ModelData.FromSchema(
                    x.Schema.WithKey(operation.Value.OperationId + x.Name.ToPropertyName()),
                    settings) with
                {
                    Style = ModelStyle.Enumeration,
                    Properties = (x.Schema.Enum?.Any() == true
                        ? x.Schema.Enum
                        : x.Schema.Items.Enum)
                    .Select(value => value.ToEnumValue())
                    .Where(value => !string.IsNullOrWhiteSpace(value.Name))
                    .ToImmutableArray(),
                    Schema = default,
                })
            .ToArray();
        var bodies = (((operation.Value.RequestBody?.Reference?.HostDocument?.ResolveReference(operation.Value.RequestBody?.Reference) as OpenApiRequestBody)?.Content ??
                      operation.Value.RequestBody?.Content)
                ?.Values ?? [])
            .Where(x => x.Schema.Type == "object" || x.Schema.Type == "array") //&& x.Parameter.Schema.Items?.Type == "object"
            .Select(x => ModelData.FromSchema(
                x.Schema.Reference?.Id != null
                    ? x.Schema.WithKey(x.Schema.Reference.Id)
                    : x.Schema.Type == "object"
                        ? x.Schema.WithKey(id + "Request")
                        : x.Schema.Items.WithKey(id + "Request"),
                    settings) with
                {
                    Schema = default,
                })
            .SelectMany(model => model.WithAdditionalModels())
            .ToArray();
        
        ModelData? requestModel = bodies.Length == 0
            ? null
            : bodies.First();
        var response = operation.Value.Responses.Values.FirstOrDefault();
        var endPoint = new EndPoint(
            Id: id,
            Namespace: settings.Namespace,
            ClassName: settings.GroupByTags
                ? operation.Value.Tags.FirstOrDefault()?.Name.ToClassName() + "Client" ?? settings.ClassName.Replace(".", string.Empty)
                : settings.ClassName.Replace(".", string.Empty),
            BaseUrl: string.Empty,
            Stream: response?.Content.Keys
                .Any(x => x.Contains("application/x-ndjson")) ?? false,
            Path: preparedPath,
            AuthorizationScheme: string.Empty,
            Properties: [..parameters.Concat(requestModel?.Properties ?? [])],
            TargetFramework: settings.TargetFramework,
            JsonSerializerType: settings.JsonSerializerType,
            JsonSerializerContext: settings.JsonSerializerContext,
            HttpMethod: operation.Key,
            Summary: operation.Value.Summary?.Replace("\n", string.Empty) ?? string.Empty,
            RequestType: requestModel?.Name ?? string.Empty,
            ResponseType: response?
                .Content.Values.FirstOrDefault()?.Schema?.Reference?.Id?.ToClassName() ?? string.Empty,
            AdditionalModels: [
                ..objectParameters,
                ..enumParameters,
                ..bodies,
            ]);
        
        return endPoint;
    }
    
    public static EndPoint FromAuthorization(
        string scheme,
        Settings settings)
    {
        var endPoint = new EndPoint(
            Id: $"AuthorizeUsing{scheme.ToPropertyName()}",
            Namespace: settings.Namespace,
            ClassName: settings.ClassName.Replace(".", string.Empty),
            BaseUrl: string.Empty,
            Stream: false,
            Path: string.Empty,
            AuthorizationScheme: scheme,
            Properties: [],
            TargetFramework: settings.TargetFramework,
            JsonSerializerType: settings.JsonSerializerType,
            JsonSerializerContext: settings.JsonSerializerContext,
            HttpMethod: default,
            Summary: string.Empty,
            RequestType: string.Empty,
            ResponseType: string.Empty,
            AdditionalModels: []);
        
        return endPoint;
    }
}