using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;

namespace OpenApiGenerator.Core.Naming.Methods;

public class SimpleOperationIdGenerator : IMethodNameGenerator
{
    public string? TryGenerate(OpenApiOperation operation, string path, OperationType operationType)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        return operation.OperationId?
            .ToPropertyName()
            .UseWordSeparator('\\', '-', '.', '_', '/');
    }
}