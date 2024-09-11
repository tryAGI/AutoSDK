using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.Methods;

public class OperationIdGenerator : IMethodNameGenerator
{
    public string? TryGenerate(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        return operation.Operation.OperationId?
            .ToPropertyName()
            .UseWordSeparator('\\', '-', '.', '_', '/', '}', '{', '<', '>', ' ', '(', ')');
    }
}