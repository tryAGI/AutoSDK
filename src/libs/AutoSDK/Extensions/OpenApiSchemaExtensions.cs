using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;

namespace AutoSDK.Extensions;

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

        return schema.Enum.Any() && schema.Type is "string" or null;
    }
    
    public static bool IsBoolean(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == "boolean" ||
               schema.Default is OpenApiBoolean;
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
    
    public static bool IsUnixTimestamp(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Example from OpenAI spec:
        // created_at:
        //  type: integer
        //  description: The Unix timestamp (in seconds) for when the batch was created.
        
        return (schema.Type == "integer" &&
               schema.Format is
                    // https://github.com/OAI/OpenAPI-Specification/issues/2565
                    "timestamp" or 
                    "unix-timestamp" or 
                    "unix-time" or 
                    "unix-epoch" or 
                    "epoch") ||
               (schema.Type == "integer" &&
               schema.Format is
                   null or
                   "int64" or
                   "int32" &&
               schema.Description?.ToUpperInvariant().Contains("UNIX TIMESTAMP") == true);
    }
}