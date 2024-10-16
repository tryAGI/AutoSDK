using Microsoft.OpenApi.Models;
using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.Methods;

public class MethodAndPathGenerator : IMethodNameGenerator
{
    public string? TryGenerate(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));
        
        var prefix = operation.OperationType switch
        {
            OperationType.Get => "get",
            OperationType.Post => "create",
            OperationType.Put => "put",
            OperationType.Delete => "delete",
            OperationType.Patch => "edit",
            OperationType.Head => "head",
            OperationType.Options => "options",
            OperationType.Trace => "trace",
            _ => throw new NotSupportedException($"OperationType {operation.OperationType} is not supported."),
        };
        
        var path = operation.OperationPath;
        path = path.StartsWith("/api", StringComparison.OrdinalIgnoreCase) ? path[4..] : path;
        path = path.StartsWith("/v1", StringComparison.OrdinalIgnoreCase) ? path[3..] : path;
        path = path.StartsWith("/api", StringComparison.OrdinalIgnoreCase) ? path[4..] : path;
        
        //path = path.Replace("{", "{By{");
        
        return $"{prefix}{path.TrimStart('/').ToPropertyName().UseWordSeparator('/', '\\', '-', '.', '_', '/', '}', '{')}";
    }
}