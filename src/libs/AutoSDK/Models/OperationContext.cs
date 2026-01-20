using AutoSDK.Naming.Methods;
using Microsoft.OpenApi;

namespace AutoSDK.Models;

public class OperationContext(
    Settings settings,
    Settings globalSettings,
    OpenApiOperation operation,
    string operationPath,
    System.Net.Http.HttpMethod operationType)
{
    public Settings Settings { get; set; } = settings;
    public Settings GlobalSettings { get; set; } = globalSettings;
    public OpenApiOperation Operation { get; set; } = operation;
    public string OperationPath { get; set; } = operationPath;
    public System.Net.Http.HttpMethod OperationType { get; set; } = operationType;
    
    public IReadOnlyCollection<SchemaContext> Schemas { get; set; } = [];
    public IList<OpenApiSecurityRequirement> GlobalSecurityRequirements { get; set; } = [];
    
    public HashSet<string> Tags { get; set; } = [];

    public string MethodName { get; set; } = string.Empty;
    
    public static OperationContext FromOperation(
        Settings settings,
        Settings globalSettings,
        OpenApiOperation operation,
        string operationPath,
        System.Net.Http.HttpMethod operationType,
        IReadOnlyCollection<SchemaContext> filteredSchemas,
        IList<OpenApiSecurityRequirement> globalSecurityRequirements)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var context = new OperationContext(settings, globalSettings, operation, operationPath, operationType)
        {
            Schemas = filteredSchemas
                .Where(schema => schema.Operation == operation)
                .ToArray(),
            Tags = [..(operation.Tags ?? new HashSet<OpenApiTagReference>()).Select(tag => tag.Name).Where(name => name != null).Cast<string>()],
            GlobalSecurityRequirements = globalSecurityRequirements,
        };
        context.MethodName = context.GetMethodName();
        
        return context;
    }
}