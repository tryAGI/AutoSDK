using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.Methods;

public class MethodAndPathGenerator : IMethodNameGenerator
{
    public string TryGenerate(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));
        
        var prefix = operation.OperationType switch
        {
            "GET" => "get",
            "POST" => "create",
            "PUT" => "put",
            "DELETE" => "delete",
            "PATCH" => "edit",
            "HEAD" => "head",
            "OPTIONS" => "options",
            "TRACE" => "trace",
            _ => throw new NotSupportedException($"HttpMethod {operation.OperationType} is not supported."),
        };
        
        var path = operation.OperationPath;
        if (path.StartsWith("/api", StringComparison.OrdinalIgnoreCase))
            path = path.Substring(4);

        if (path.StartsWith("/v1", StringComparison.OrdinalIgnoreCase))
            path = path.Substring(3);

        if (path.StartsWith("/api", StringComparison.OrdinalIgnoreCase))
            path = path.Substring(4);
        
        path = path.Replace("{", "{By{");
        
        return $"{prefix}{path.TrimStart('/').ToPropertyName().UseWordSeparator('/', '\\', '-', '.', '_', '/', '}', '{')}";
    }
}