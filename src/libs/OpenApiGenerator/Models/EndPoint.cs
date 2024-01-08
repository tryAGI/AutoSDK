using H.Generators.Extensions;

namespace OpenApiGenerator.Models;

public readonly record struct EndPoint(
    string Id,
    string Namespace,
    string ClassName
)
{
    public string MethodName => Id.ToPropertyName();
    
    public string FileNameWithoutExtension => $"{Namespace}.{ClassName}.EndPoints.{MethodName}";
}