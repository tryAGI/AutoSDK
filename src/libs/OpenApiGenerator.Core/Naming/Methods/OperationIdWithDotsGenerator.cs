using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;

namespace OpenApiGenerator.Core.Naming.Methods;

public class OperationIdWithDotsGenerator : IMethodNameGenerator
{
    public string? TryGenerate(OpenApiOperation operation, string path, OperationType operationType)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (operation.OperationId is null ||
            !operation.OperationId.Contains('.'))
        {
            return null;
        }
        
        return string.Concat(operation.OperationId
            .Split('.')
            .Reverse()
            .Select(x => x.ToPropertyName()));
    }
}