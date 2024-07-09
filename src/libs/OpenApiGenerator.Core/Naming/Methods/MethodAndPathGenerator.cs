using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;

namespace OpenApiGenerator.Core.Naming.Methods;

public class MethodAndPathGenerator : IMethodNameGenerator
{
    public string TryGenerate(OpenApiOperation operation, string path, OperationType operationType)
    {
        path = path ?? throw new ArgumentNullException(nameof(path));
        
        var prefix = operationType switch
        {
            OperationType.Get => "get",
            OperationType.Post => "create",
            OperationType.Put => "put",
            OperationType.Delete => "delete",
            OperationType.Patch => "edit",
            OperationType.Head => "head",
            OperationType.Options => "options",
            OperationType.Trace => "trace",
            _ => throw new NotSupportedException($"OperationType {operationType} is not supported."),
        };
        
        path = path.StartsWith("/api", StringComparison.OrdinalIgnoreCase) ? path[4..] : path;
        path = path.StartsWith("/v1", StringComparison.OrdinalIgnoreCase) ? path[3..] : path;
        path = path.StartsWith("/api", StringComparison.OrdinalIgnoreCase) ? path[4..] : path;
        
        return $"{prefix}{path.TrimStart('/').ToPropertyName().UseWordSeparator('/')}";
    }
}