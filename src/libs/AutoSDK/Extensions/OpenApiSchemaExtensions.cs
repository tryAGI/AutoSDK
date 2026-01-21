using System.Text.Json.Nodes;
using Microsoft.OpenApi;

namespace AutoSDK.Extensions;

#pragma warning disable CA1308 // Normalize strings to uppercase - we need lowercase for type matching

public static class OpenApiSchemaExtensions
{
    /// <summary>
    /// Converts JsonSchemaType? to a lowercase string representation for pattern matching.
    /// In OpenAPI 3.1+, Type can be a flags enum (e.g., Object | Null for nullable object).
    /// This method extracts the primary type, ignoring the Null flag.
    /// </summary>
    public static string? ToTypeString(this JsonSchemaType? type)
    {
        if (type == null)
        {
            return null;
        }

        // Remove Null flag to get the primary type
        // In OpenAPI 3.1, nullable is expressed as type: ["string", "null"]
        var nonNullType = type.Value & ~JsonSchemaType.Null;

        return nonNullType switch
        {
            JsonSchemaType.String => "string",
            JsonSchemaType.Integer => "integer",
            JsonSchemaType.Number => "number",
            JsonSchemaType.Boolean => "boolean",
            JsonSchemaType.Array => "array",
            JsonSchemaType.Object => "object",
            0 when (type.Value & JsonSchemaType.Null) == JsonSchemaType.Null => "null", // Only null type
            0 => null, // No type specified (e.g., for anyOf/oneOf)
            _ => nonNullType.ToString()?.ToLowerInvariant(),
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

        // Don't treat anyOf: [X, {type: null}] as a true AnyOf - it's just nullable X
        if (schema.IsNullableAnyOf())
        {
            return false;
        }

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

        // Check if Array flag is set (handles nullable types like ["array", "null"])
        return (schema.Type == null || (schema.Type & JsonSchemaType.Array) == JsonSchemaType.Array) &&
               schema.Items is not null;
    }

    public static bool IsEnum(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Don't treat schemas with nullable anyOf pattern as enums
        // Even if they have enum values, they're being used as nullable strings
        if (schema.IsNullableAnyOf())
        {
            return false;
        }

        // Check if String flag is set (handles nullable types like ["string", "null"])
        return (schema.Enum?.Any() ?? false) &&
               (schema.Type == null || (schema.Type & JsonSchemaType.String) == JsonSchemaType.String);
    }

    /// <summary>
    /// Checks if the schema has a const value (a single constant string value).
    /// In OpenAPI 3.1+, const is used to define a single allowed value.
    /// </summary>
    public static bool IsConst(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return !string.IsNullOrEmpty(schema.Const);
    }

    /// <summary>
    /// Checks if the schema is a null-only type (type: "null" with no other content).
    /// In OpenAPI 3.1+, this is used in anyOf/oneOf to express nullability.
    /// </summary>
    public static bool IsNullType(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Check if type is exactly "null" (only the Null flag is set)
        return schema.Type == JsonSchemaType.Null;
    }

    /// <summary>
    /// Checks if the anyOf is just expressing nullability (anyOf: [X, {type: null}]).
    /// This pattern should be simplified to nullable X rather than AnyOf.
    /// </summary>
    public static bool IsNullableAnyOf(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        var anyOfItems = schema.AnyOf?.ToList();
        if (anyOfItems == null || anyOfItems.Count != 2)
        {
            return false;
        }

        // Check if exactly one item is null-type and one is not
        var hasNullType = anyOfItems.Any(x => x.IsNullType());
        var hasNonNullType = anyOfItems.Any(x => !x.IsNullType());

        return hasNullType && hasNonNullType;
    }

    /// <summary>
    /// Checks if the schema is a string type or has a string const value.
    /// This handles schemas with const values that don't have an explicit type.
    /// </summary>
    public static bool IsStringOrConst(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Explicit string type
        if (schema.Type != null && (schema.Type & JsonSchemaType.String) == JsonSchemaType.String)
        {
            return true;
        }

        // Has a const value (which is always a string in OpenAPI)
        if (!string.IsNullOrEmpty(schema.Const))
        {
            return true;
        }

        return false;
    }

    public static bool IsBoolean(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Check if Boolean flag is set (handles nullable types like ["boolean", "null"])
        return (schema.Type != null && (schema.Type & JsonSchemaType.Boolean) == JsonSchemaType.Boolean) ||
               (schema.Default is JsonValue defaultValue && defaultValue.TryGetValue<bool>(out _));
    }

    public static bool IsBase64(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Check if String flag is set (handles nullable types like ["string", "null"])
        return (schema.Type != null && (schema.Type & JsonSchemaType.String) == JsonSchemaType.String) &&
               schema.Format == "byte";
    }

    public static bool IsDate(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Check if String flag is set (handles nullable types like ["string", "null"])
        return (schema.Type != null && (schema.Type & JsonSchemaType.String) == JsonSchemaType.String) &&
               schema.Format == "date";
    }

    public static bool IsDateTime(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Check if String flag is set (handles nullable types like ["string", "null"])
        return (schema.Type != null && (schema.Type & JsonSchemaType.String) == JsonSchemaType.String) &&
               schema.Format == "date-time";
    }

    public static bool IsBinary(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Check if String flag is set (handles nullable types like ["string", "null"])
        return (schema.Type != null && (schema.Type & JsonSchemaType.String) == JsonSchemaType.String) &&
               schema.Format == "binary";
    }

    public static bool IsUnixTimestamp(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Example from OpenAI spec:
        // created_at:
        //  type: integer
        //  description: The Unix timestamp (in seconds) for when the batch was created.

        // Check if Integer flag is set (handles nullable types like ["integer", "null"])
        var isInteger = schema.Type != null && (schema.Type & JsonSchemaType.Integer) == JsonSchemaType.Integer;

        return (isInteger &&
               schema.Format is
                    // https://github.com/OAI/OpenAPI-Specification/issues/2565
                    "timestamp" or
                    "unix-timestamp" or
                    "unix-time" or
                    "unix-epoch" or
                    "epoch") ||
               (isInteger &&
               schema.Format is
                   null or
                   "int64" or
                   "int32" &&
               schema.Description?.ToUpperInvariant().Contains("UNIX TIMESTAMP") == true);
    }
}