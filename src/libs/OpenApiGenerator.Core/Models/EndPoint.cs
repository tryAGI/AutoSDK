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
    JsonSerializerType JsonSerializerType,
    OperationType HttpMethod,
    string Summary,
    string RequestType,
    string ResponseType
)
{
    public string MethodName => $"{Id.ToPropertyName()}Async";
    
    public string FileNameWithoutExtension => $"{Namespace}.{ClassName}.EndPoints.{Id.ToPropertyName()}";
}