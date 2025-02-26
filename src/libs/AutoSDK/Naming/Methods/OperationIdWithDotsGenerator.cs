using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.Methods;

public class OperationIdWithDotsGenerator : IMethodNameGenerator
{
    public string? TryGenerate(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (operation.Operation.OperationId is null ||
            !operation.Operation.OperationId.Contains('.'))
        {
            return null;
        }

        var parts = operation.Operation.OperationId.Split('.');
        var invertedParts = InvertedParts(parts);
        
        return string.Concat(invertedParts.Select(x => x.ToPropertyName()));
    }
    
    private static string[] InvertedParts(string[] parts)
    {
        var newParts = new string[parts.Length];
        for (var i = 0; i < parts.Length; i++)
        {
            newParts[i] = parts[parts.Length - i - 1];
        }
        
        return newParts;
    }
}