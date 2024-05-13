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
    ImmutableArray<PropertyData> Properties,
    JsonSerializerType JsonSerializerType,
    OperationType HttpMethod,
    string Summary,
    string RequestType,
    string ResponseType
)
{
    public string MethodName => $"{Id.ToPropertyName()}Async";
    
    public string FileNameWithoutExtension => $"{Namespace}.{ClassName}.EndPoints.{Id.ToPropertyName()}";
    
    public static EndPoint FromSchema(
        KeyValuePair<OperationType, OpenApiOperation> operation,
        Settings settings,
        string path)
    {
        var requestSchema = operation.Value.RequestBody?.Content.Values.FirstOrDefault()?.Schema;
        var requestModel =  requestSchema != null
            ? ModelData.FromSchema(new KeyValuePair<string, OpenApiSchema>(requestSchema.Reference?.Id ?? "Test", requestSchema), settings)
            : ModelData.FromKey("test", settings) with{ Schema = default };
        var response = operation.Value.Responses.Values.FirstOrDefault();
        var endPoint = new EndPoint(
            Id: operation.Value.GetOperationIdOrCompute(path: path, operationType: operation.Key),
            Namespace: settings.Namespace,
            ClassName: settings.ClassName,
            BaseUrl: string.Empty,
            Stream: response?.Content.Keys
                .Any(x => x.Contains("application/x-ndjson")) ?? false,
            Path: path,
            Properties: requestModel.Properties,
            JsonSerializerType: settings.JsonSerializerType,
            HttpMethod: operation.Key,
            Summary: operation.Value.Summary?.Replace("\n", string.Empty) ?? string.Empty,
            RequestType: requestSchema?.Reference?.Id ?? string.Empty,
            ResponseType: response?
                .Content.Values.FirstOrDefault()?.Schema?.Reference?.Id ?? string.Empty);
        
        return endPoint;
    }
}