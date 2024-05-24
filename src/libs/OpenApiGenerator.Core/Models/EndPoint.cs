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
    string ResponseType
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
        var preparedPath = path.PreparePath(parameters);
        
        var requestSchema = operation.Value.RequestBody?.Content.Values.FirstOrDefault()?.Schema;
        var requestModel =  requestSchema != null
            ? ModelData.FromSchema(new KeyValuePair<string, OpenApiSchema>(requestSchema.Reference?.Id ?? "Test", requestSchema), settings)
            : ModelData.FromKey("test", settings) with{ Schema = default };
        var response = operation.Value.Responses.Values.FirstOrDefault();
        var endPoint = new EndPoint(
            Id: operation.Value.GetMethodName(path: path, operationType: operation.Key, settings.MethodNamingConvention, settings.MethodNamingConventionFallback),
            Namespace: settings.Namespace,
            ClassName: settings.GroupByTags
                ? operation.Value.Tags.FirstOrDefault()?.Name.ToClassName() + "Client" ?? settings.ClassName.Replace(".", string.Empty)
                : settings.ClassName.Replace(".", string.Empty),
            BaseUrl: string.Empty,
            Stream: response?.Content.Keys
                .Any(x => x.Contains("application/x-ndjson")) ?? false,
            Path: preparedPath,
            AuthorizationScheme: string.Empty,
            Properties: [..parameters.Concat(requestModel.Properties)],
            TargetFramework: settings.TargetFramework,
            JsonSerializerType: settings.JsonSerializerType,
            JsonSerializerContext: settings.JsonSerializerContext,
            HttpMethod: operation.Key,
            Summary: operation.Value.Summary?.Replace("\n", string.Empty) ?? string.Empty,
            RequestType: ModelData.FromKey(requestSchema?.Reference?.Id ?? string.Empty, settings).Name,
            ResponseType: response?
                .Content.Values.FirstOrDefault()?.Schema?.Reference?.Id ?? string.Empty);
        
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
            ResponseType: string.Empty);
        
        return endPoint;
    }
}