using Microsoft.OpenApi.Models;
using AutoSDK.Naming.Methods;

namespace AutoSDK.Models;

public class OperationContext
{
    public required Settings Settings { get; init; }
    public required OpenApiOperation Operation { get; init; }
    public required string OperationPath { get; init; }
    public required OperationType OperationType { get; init; }
    
    public IReadOnlyCollection<SchemaContext> Schemas { get; set; } = [];
    
    public HashSet<string> Tags { get; set; } = [];

    public string MethodName { get; set; } = string.Empty;
    
    public static OperationContext FromOperation(
        Settings settings,
        OpenApiOperation operation,
        string operationPath,
        OperationType operationType,
        IReadOnlyCollection<SchemaContext> filteredSchemas)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var context = new OperationContext
        {
            Settings = settings,
            Operation = operation,
            OperationPath = operationPath,
            OperationType = operationType,
            Schemas = filteredSchemas
                .Where(schema => schema.Operation == operation)
                .ToArray(),
            Tags = [..operation.Tags.Select(tag => tag.Name)]
        };
        context.MethodName = context.GetMethodName();
        
        return context;
    }
}