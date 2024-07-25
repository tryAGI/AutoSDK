using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;

namespace OpenApiGenerator.Core.Naming.Methods;

public class OperationIdSplitGenerator : IMethodNameGenerator
{
    public string? TryGenerate(OpenApiOperation operation, string path, OperationType operationType)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (operation.OperationId is null ||
            !operation.OperationId.Contains("api_v1"))
        {
            return null;
        }
        
        var value = operation.OperationId[..operation.OperationId.IndexOf("api_v1", StringComparison.OrdinalIgnoreCase)];
        return value.ToClassName();
    }
}