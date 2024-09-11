using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.Methods;

public class SummaryGenerator : IMethodNameGenerator
{
    public string? TryGenerate(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        return operation.Operation.Summary?
            .ToPropertyName()
            .UseWordSeparator('\\', '-', '.', '_', '/', '}', '{');
    }
}