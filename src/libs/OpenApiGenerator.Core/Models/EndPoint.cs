using OpenApiGenerator.Core.Extensions;

namespace OpenApiGenerator.Core.Models;

public readonly record struct EndPoint(
    string Id,
    string Namespace,
    string ClassName
)
{
    public string MethodName => Id.ToPropertyName();
    
    public string FileNameWithoutExtension => $"{Namespace}.{ClassName}.EndPoints.{MethodName}";
}