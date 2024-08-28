using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Naming.Methods;

public class OperationIdSplitGenerator : IMethodNameGenerator
{
    public string? TryGenerate(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (operation.Operation.OperationId is null ||
            !operation.Operation.OperationId.Contains("api_v1"))
        {
            return null;
        }
        
        var value = operation.Operation.OperationId[..operation.Operation.OperationId.IndexOf("api_v1", StringComparison.OrdinalIgnoreCase)];
        return value.ToClassName();
    }
}