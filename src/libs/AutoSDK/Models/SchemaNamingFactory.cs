using Microsoft.OpenApi;

namespace AutoSDK.Models;

public readonly struct ReferenceNameContext
{
    public ReferenceNameContext(SchemaNamingSettings settings, SchemaContext? parent, string referenceId)
    {
        Settings = settings;
        Parent = parent;
        ReferenceId = referenceId;
    }

    public SchemaNamingSettings Settings { get; }
    public SchemaContext? Parent { get; }
    public string ReferenceId { get; }
}

public readonly struct SchemaNameContext
{
    public SchemaNameContext(
        SchemaNamingSettings settings,
        SchemaContext? parent,
        Hint? hint,
        OpenApiOperation? operation,
        IOpenApiParameter? parameter,
        string? propertyName,
        string? componentId,
        int? index,
        string? title,
        string? operationPath,
        System.Net.Http.HttpMethod? operationType)
    {
        Settings = settings;
        Parent = parent;
        Hint = hint;
        Operation = operation;
        Parameter = parameter;
        PropertyName = propertyName;
        ComponentId = componentId;
        Index = index;
        Title = title;
        OperationPath = operationPath;
        OperationType = operationType;
    }

    public SchemaNamingSettings Settings { get; }
    public SchemaContext? Parent { get; }
    public Hint? Hint { get; }
    public OpenApiOperation? Operation { get; }
    public IOpenApiParameter? Parameter { get; }
    public string? PropertyName { get; }
    public string? ComponentId { get; }
    public int? Index { get; }
    public string? Title { get; }
    public string? OperationPath { get; }
    public System.Net.Http.HttpMethod? OperationType { get; }
}
