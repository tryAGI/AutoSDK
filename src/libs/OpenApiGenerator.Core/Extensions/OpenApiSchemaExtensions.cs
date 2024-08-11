using Microsoft.OpenApi.Models;

namespace OpenApiGenerator.Core.Extensions;

public static class OpenApiSchemaExtensions
{
    public static bool IsOneOf(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return
            schema.OneOf.Any() &&
            schema.Properties.Count == 0; // OneOf with properties is not supported
    }
    
    public static bool IsAnyOf(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return
            schema.AnyOf.Any() &&
            schema.Properties.Count == 0; // AnyOf with properties is not supported
    }
    
    public static bool IsAllOf(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return
            schema.AllOf.Any() &&
            schema.Properties.Count == 0; // AllOf with properties is not supported
    }
    
    public static bool IsArray(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == "array";
    }
    
    public static bool IsEnum(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == "string" && schema.Enum.Any();
    }
    
    public static bool IsBase64(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == "string" && schema.Format == "byte";
    }
    
    public static bool IsDate(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == "string" && schema.Format == "date";
    }
    
    public static bool IsDateTime(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == "string" && schema.Format == "date-time";
    }
    
    public static bool IsBinary(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == "string" && schema.Format == "binary";
    }
}