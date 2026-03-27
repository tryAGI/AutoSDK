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
    public Tag Tag { get; set; } = Tag.Empty;

    public string MethodName { get; set; } = string.Empty;
}
