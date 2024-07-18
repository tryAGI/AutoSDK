using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;

namespace OpenApiGenerator.Core.Models;

public class SchemaContext
{
    public SchemaContext? Parent { get; init; }
    
    public required Settings Settings { get; init; }
    public required OpenApiSchema Schema { get; init; }
    public required string Id { get; init; }
    public required string Type { get; init; }
    public bool IsReference { get; init; }
    
    public Hint? Hint { get; init; }
    public int? Index { get; init; }
    
    public string? PropertyName { get; init; }
    public bool IsProperty => PropertyName != null;
    
    public string? ComponentId { get; init; }
    public bool IsComponent => ComponentId != null;
    
    public string? OperationPath { get; init; }
    public OperationType? OperationType { get; init; }
    public OpenApiOperation? Operation { get; init; }
    public string? ContentType { get; init; }
    public OpenApiMediaType? MediaType { get; init; }
    public OpenApiParameter? Parameter { get; init; }
    public string? ResponseStatusCode { get; init; }
    public OpenApiResponse? Response { get; init; }
    public bool IsOperation => OperationPath != null;
    
    public TypeData? TypeData { get; set; }

    private static string ComputeId(Settings settings, SchemaContext? parent, string? helper)
    {
        var id = parent?.Id + helper?.ToCSharpName(settings, parent);
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new InvalidOperationException("Id is required. Invalid info.");
        }

        return id;
    }
    
    private static string ComputeType(OpenApiSchema schema)
    {
        if (schema.IsEnum())
        {
            return "enum";
        }
        if (schema.Type == "object")
        {
            return "class";
        }
        if (schema.Type == "boolean")
        {
            return "bool";
        }
        if (schema.Type == "number")
        {
            return schema.Format switch
            {
                "float" => "float",
                _ => "double",
            };
        }
        if (schema.Type == "integer")
        {
            return schema.Format switch
            {
                "int64" => "long",
                _ => "int",
            };
        }

        if (schema.Type == "string")
        {
            return schema.Format switch
            {
                "byte" => "byte",
                "binary" => "byte[]",
                "date" => "DateTime",
                "date-time" => "DateTime",
                "uri" => "Uri",
                _ => "string",
            };
        }
        if (schema.AnyOf.Any())
        {
            return "anyOf";
        }
        if (schema.OneOf.Any())
        {
            return "oneOf";
        }
        if (schema.AllOf.Any())
        {
            return "allOf";
        }
        
        return schema.Type;
    }

    public string ShortType
    {
        get
        {
            return TypeData?.CSharpType ?? Type;
        }
    }

    public bool IsRequired => IsProperty && Parent?.Schema.Required.Contains(PropertyName) == true;

    public static IReadOnlyList<SchemaContext> FromSchema(
        OpenApiSchema schema,
        Settings settings,
        SchemaContext? parent = null,
        string? componentId = null,
        string? propertyName = null,
        string? operationPath = null,
        OperationType? operationType = null,
        OpenApiOperation? operation = null,
        string? contentType = null,
        OpenApiMediaType? mediaType = null,
        OpenApiParameter? parameter = null,
        string? responseStatusCode = null,
        OpenApiResponse? response = null,
        Hint? hint = null,
        int? index = null)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));
        var helper = hint switch
        {
            Models.Hint.ArrayItem => "Item",
            Models.Hint.Request => operation?.OperationId + "Request",
            Models.Hint.Response => operation?.OperationId + "Response",
            Models.Hint.Parameter => operation?.OperationId + "_" + parameter?.Name,
            Models.Hint.AnyOf or Models.Hint.OneOf or Models.Hint.AllOf => $"Variant{(index != null ? $"{index + 1}" : "")}",
            _ when propertyName != null => propertyName,
            _ => null,
        };

        if (schema.Reference?.Id != null &&
            componentId != schema.Reference.Id)
        {
            return [new SchemaContext
            {
                Parent = parent,
                Settings = settings,
                Schema = schema,
                Id = schema.Reference.Id.ToCSharpName(settings, parent),
                Type = "ref",
                IsReference = true,
                ComponentId = componentId,
                PropertyName = propertyName,
                Hint = hint,
                Index = index,
                OperationPath = operationPath,
                OperationType = operationType,
                Operation = operation,
                ContentType = contentType,
                MediaType = mediaType,
                Parameter = parameter,
                ResponseStatusCode = responseStatusCode,
                Response = response,
            }];
        }
        
        var schemas = new List<SchemaContext>();
        var context = new SchemaContext
        {
            Parent = parent,
            Settings = settings,
            Schema = schema,
            Id = propertyName?.ToCSharpName(settings, parent) ?? componentId?.ToCSharpName(settings, parent) ?? ComputeId(settings, parent, helper),
            Type = ComputeType(schema),
            ComponentId = componentId,
            PropertyName = propertyName,
            Hint = hint,
            Index = index,
            OperationPath = operationPath,
            OperationType = operationType,
            Operation = operation,
            ContentType = contentType,
            MediaType = mediaType,
            Parameter = parameter,
            ResponseStatusCode = responseStatusCode,
            Response = response,
        };
        schemas.Add(context);
        
        if (schema.Items != null)
        {
            schemas.AddRange(FromSchema(
                schema: schema.Items,
                settings: settings,
                parent: context,
                hint: Models.Hint.ArrayItem));
        }
        
        var i = 0;
        foreach (var property in schema.Properties)
        {
            schemas.AddRange(FromSchema(
                schema: property.Value,
                settings: settings,
                parent: context,
                hint: Models.Hint.Property,
                propertyName: property.Key,
                index: i++));
        }

        i = 0;
        foreach (var item in schema.AnyOf)
        {
            schemas.AddRange(FromSchema(
                schema: item,
                settings: settings,
                parent: context,
                hint: Models.Hint.AnyOf,
                index: i++));
        }
        i = 0;
        foreach (var item in schema.OneOf)
        {
            schemas.AddRange(FromSchema(
                schema: item,
                settings: settings,
                parent: context,
                hint: Models.Hint.OneOf,
                index: i++));
        }
        i = 0;
        foreach (var item in schema.AllOf)
        {
            schemas.AddRange(FromSchema(
                schema: item,
                settings: settings,
                parent: context,
                hint: Models.Hint.AllOf,
                index: i++));
        }
        
        context.TypeData = Models.TypeData.FromSchemaContext(context, settings, schemas);
        
        return schemas;
    }
}