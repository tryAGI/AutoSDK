using System.Text.Json.Nodes;
using Microsoft.OpenApi;

namespace AutoSDK.Extensions;

#pragma warning disable CA1308 // Normalize strings to uppercase - we need lowercase for type matching

public static class OpenApiSchemaExtensions
{
    /// <summary>
    /// Converts JsonSchemaType? to a lowercase string representation for pattern matching.
    /// </summary>
    public static string? ToTypeString(this JsonSchemaType? type)
    {
        return type switch
        {
            JsonSchemaType.String => "string",
            JsonSchemaType.Integer => "integer",
            JsonSchemaType.Number => "number",
            JsonSchemaType.Boolean => "boolean",
            JsonSchemaType.Array => "array",
            JsonSchemaType.Object => "object",
            JsonSchemaType.Null => "null",
            null => null,
            _ => type.ToString()?.ToLowerInvariant(),
        };
    }

    /// <summary>
    /// Checks if the schema is a reference (OpenApiSchemaReference).
    /// </summary>
    public static bool IsSchemaReference(this IOpenApiSchema schema)
    {
        return schema is OpenApiSchemaReference;
    }

    /// <summary>
    /// Gets the reference ID if this is a schema reference, or null otherwise.
    /// </summary>
    public static string? GetReferenceId(this IOpenApiSchema schema)
    {
        return schema is OpenApiSchemaReference schemaRef ? schemaRef.Reference?.Id : null;
    }

    /// <summary>
    /// Gets the underlying OpenApiSchema, resolving references if needed.
    /// Returns null if the schema cannot be resolved.
    /// </summary>
    public static OpenApiSchema? ResolveSchema(this IOpenApiSchema? schema)
    {
        return schema switch
        {
            null => null,
            OpenApiSchema concreteSchema => concreteSchema,
            OpenApiSchemaReference schemaRef => (schemaRef.Target ?? schemaRef.RecursiveTarget) as OpenApiSchema,
            _ => null,
        };
    }

    /// <summary>
    /// Checks if the schema is nullable.
    /// In OpenAPI 3.1+, nullable is expressed via type array including "null".
    /// </summary>
    public static bool IsNullable(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // In OpenAPI 3.1+, nullable is expressed as type: ["string", "null"]
        // The Type property may include Null flag
        return (schema.Type & JsonSchemaType.Null) == JsonSchemaType.Null;
    }

    /// <summary>
    /// Gets the target schema from a reference, or returns the schema itself if not a reference.
    /// </summary>
    public static IOpenApiSchema ResolveIfRequired(this IOpenApiSchema? schema)
    {
        if (schema is OpenApiSchemaReference schemaRef)
        {
            return schemaRef.Target ?? schemaRef.RecursiveTarget ?? (IOpenApiSchema)schemaRef;
        }
        return schema ?? throw new InvalidOperationException("Schema cannot be null");
    }

    public static bool IsOneOf(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return
            (schema.OneOf?.Any() ?? false) &&
            (schema.Properties?.Count ?? 0) == 0; // OneOf with properties is not supported
    }

    public static bool IsAnyOf(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return
            (schema.AnyOf?.Any() ?? false) &&
            (schema.Properties?.Count ?? 0) == 0; // AnyOf with properties is not supported
    }

    public static bool IsAllOf(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return
            (schema.AllOf?.Any() ?? false) &&
            (schema.Properties?.Count ?? 0) == 0; // AllOf with properties is not supported
    }
    
    public static bool IsArray(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type is JsonSchemaType.Array or null &&
               schema.Items is not null;
    }

    public static bool IsEnum(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return (schema.Enum?.Any() ?? false) && schema.Type is JsonSchemaType.String or null;
    }

    public static bool IsBoolean(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == JsonSchemaType.Boolean ||
               (schema.Default is JsonValue defaultValue && defaultValue.TryGetValue<bool>(out _));
    }

    public static bool IsBase64(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == JsonSchemaType.String && schema.Format == "byte";
    }

    public static bool IsDate(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == JsonSchemaType.String && schema.Format == "date";
    }

    public static bool IsDateTime(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == JsonSchemaType.String && schema.Format == "date-time";
    }

    public static bool IsBinary(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == JsonSchemaType.String && schema.Format == "binary";
    }

    public static bool IsUnixTimestamp(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Example from OpenAI spec:
        // created_at:
        //  type: integer
        //  description: The Unix timestamp (in seconds) for when the batch was created.

        return (schema.Type == JsonSchemaType.Integer &&
               schema.Format is
                    // https://github.com/OAI/OpenAPI-Specification/issues/2565
                    "timestamp" or
                    "unix-timestamp" or
                    "unix-time" or
                    "unix-epoch" or
                    "epoch") ||
               (schema.Type == JsonSchemaType.Integer &&
               schema.Format is
                   null or
                   "int64" or
                   "int32" &&
               schema.Description?.ToUpperInvariant().Contains("UNIX TIMESTAMP") == true);
    }
}