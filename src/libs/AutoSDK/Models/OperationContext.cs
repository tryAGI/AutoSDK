using Microsoft.OpenApi.Models;
using AutoSDK.Naming.Methods;

namespace AutoSDK.Models;

public class OperationContext(
    Settings settings,
    OpenApiOperation operation,
    string operationPath,
    OperationType operationType)
{
    public Settings Settings { get; set; } = settings;
    public OpenApiOperation Operation { get; set; } = operation;
    public string OperationPath { get; set; } = operationPath;
    public OperationType OperationType { get; set; } = operationType;
    
    public IReadOnlyCollection<SchemaContext> Schemas { get; set; } = [];
    public IList<OpenApiSecurityRequirement> GlobalSecurityRequirements { get; set; } = [];
    
    public HashSet<string> Tags { get; set; } = [];

    public string MethodName { get; set; } = string.Empty;
    
    public static OperationContext FromOperation(
        Settings settings,
        OpenApiOperation operation,
        string operationPath,
        OperationType operationType,
        IReadOnlyCollection<SchemaContext> filteredSchemas,
        IList<OpenApiSecurityRequirement> globalSecurityRequirements)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var context = new OperationContext(settings, operation, operationPath, operationType)
        {
            Schemas = filteredSchemas
                .Where(schema => schema.Operation == operation)
                .ToArray(),
            Tags = [..operation.Tags.Select(tag => tag.Name)],
            GlobalSecurityRequirements = globalSecurityRequirements,
        };
        context.MethodName = context.GetMethodName();
        
        return context;
    }
}