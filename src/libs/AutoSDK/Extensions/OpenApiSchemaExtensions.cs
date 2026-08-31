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

            // Handle combined types (OpenAPI 3.1 type arrays like ["integer", "string"])
            // If string is one of the types, use string as it can represent all primitive types
            _ when (nonNullType & JsonSchemaType.String) == JsonSchemaType.String => "string",
            // If integer and number, use number (integer is subset of number)
            JsonSchemaType.Integer | JsonSchemaType.Number => "number",
            // For other combinations (e.g., object | array), use object as catch-all
            _ => "object",
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
    /// Also supports Swagger 2.x-style x-nullable extension.
    /// </summary>
    public static bool IsNullable(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // In OpenAPI 3.1+, nullable is expressed as type: ["string", "null"]
        // The Type property may include Null flag
        if ((schema.Type & JsonSchemaType.Null) == JsonSchemaType.Null)
        {
            return true;
        }

        // Swagger 2.x-style x-nullable extension fallback
        if (OpenApiExtensions.GetExtensionBooleanValue(schema.Extensions, "x-nullable"))
        {
            return true;
        }

        return false;
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

    /// <summary>
    /// Resolves a schema reference only when it contains no JSON Schema sibling keywords.
    /// Microsoft.OpenAPI delegates every reference property getter through reference resolution;
    /// using the target directly for bare references avoids repeating that work while preserving
    /// the override semantics of OpenAPI 3.1 reference siblings.
    /// </summary>
    public static IOpenApiSchema ResolveBareReference(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        if (schema is not OpenApiSchemaReference schemaReference ||
            HasSchemaSiblingKeywords(schemaReference.Reference))
        {
            return schema;
        }

        return schemaReference.Target ?? schemaReference.RecursiveTarget ?? schema;
    }

    private static bool HasSchemaSiblingKeywords(JsonSchemaReference reference)
    {
        return reference.Description != null ||
               reference.Default != null ||
               reference.Title != null ||
               reference.Deprecated != null ||
               reference.ReadOnly != null ||
               reference.WriteOnly != null ||
               reference.Examples != null ||
               reference.Extensions != null ||
               reference.SchemaId != null ||
               reference.Schema != null ||
               reference.Comment != null ||
               reference.Vocabulary != null ||
               reference.DynamicRef != null ||
               reference.DynamicAnchor != null ||
               reference.Definitions != null ||
               reference.Anchor != null ||
               reference.ExclusiveMaximum != null ||
               reference.ExclusiveMinimum != null ||
               reference.SchemaType != null ||
               reference.Const != null ||
               reference.Format != null ||
               reference.Maximum != null ||
               reference.Minimum != null ||
               reference.MaxLength != null ||
               reference.MinLength != null ||
               reference.Pattern != null ||
               reference.MultipleOf != null ||
               reference.AllOf != null ||
               reference.OneOf != null ||
               reference.AnyOf != null ||
               reference.Not != null ||
               reference.Required != null ||
               reference.Items != null ||
               reference.MaxItems != null ||
               reference.MinItems != null ||
               reference.UniqueItems != null ||
               reference.Contains != null ||
               reference.MaxContains != null ||
               reference.MinContains != null ||
               reference.Properties != null ||
               reference.PatternProperties != null ||
               reference.MaxProperties != null ||
               reference.MinProperties != null ||
               reference.AdditionalPropertiesAllowed != null ||
               reference.AdditionalProperties != null ||
               reference.Discriminator != null ||
#pragma warning disable CS0618 // A reference-level OpenAPI 3.0 example is still observable through the object model.
               reference.Example != null ||
#pragma warning restore CS0618
               reference.Enum != null ||
               reference.UnevaluatedProperties != null ||
               reference.UnevaluatedPropertiesSchema != null ||
               reference.ExternalDocs != null ||
               reference.Xml != null ||
               reference.UnrecognizedKeywords != null ||
               reference.DependentRequired != null ||
               reference.ContentEncoding != null ||
               reference.ContentMediaType != null ||
               reference.ContentSchema != null ||
               reference.PropertyNames != null ||
               reference.DependentSchemas != null ||
               reference.If != null ||
               reference.Then != null ||
               reference.Else != null;
    }

    public static bool IsOneOf(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        if (schema.OneOf is not { Count: > 0 })
        {
            return false;
        }

        // Don't treat oneOf: [X, {type: null}] as a true OneOf - the branches
        // are disjoint and the schema is simply nullable X.
        if (schema.IsNullableOneOf())
        {
            return false;
        }

        return (schema.Properties?.Count ?? 0) == 0 ||
               HasOnlySharedBaseDiscriminatorWrapperProperty(schema);
    }

    public static bool IsAnyOf(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        if (schema.AnyOf is not { Count: > 0 } ||
            (schema.Properties?.Count ?? 0) != 0)
        {
            return false;
        }

        // Don't treat anyOf: [X, {type: null}] as a true AnyOf - it's just nullable X
        if (schema.IsNullableAnyOfLike())
        {
            return false;
        }

        return true;
    }

    public static bool IsAllOf(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return
            schema.AllOf is { Count: > 0 } &&
            (schema.Properties?.Count ?? 0) == 0; // AllOf with properties is not supported
    }

    // Some specs wrap a shared-base discriminated oneOf in a discriminator-only property bag.
    // That wrapper should still be treated as a named union instead of collapsing to a base class.
    private static bool HasOnlySharedBaseDiscriminatorWrapperProperty(IOpenApiSchema schema)
    {
        if (schema.Discriminator?.PropertyName is not { Length: > 0 } discriminatorPropertyName ||
            schema.Properties is not { Count: 1 } properties ||
            !properties.ContainsKey(discriminatorPropertyName))
        {
            return false;
        }

        string? sharedBaseReferenceId = null;
        foreach (var variant in schema.OneOf ?? [])
        {
            var candidate = GetSharedBaseReferenceId(variant);
            if (string.IsNullOrWhiteSpace(candidate))
            {
                continue;
            }

            if (sharedBaseReferenceId is null)
            {
                sharedBaseReferenceId = candidate;
            }
            else if (!string.Equals(sharedBaseReferenceId, candidate, StringComparison.Ordinal))
            {
                return false;
            }
        }

        return sharedBaseReferenceId is not null;
    }

    private static string? GetSharedBaseReferenceId(IOpenApiSchema schema)
    {
        var resolvedSchema = schema.ResolveIfRequired();
        string? baseReferenceId = null;
        foreach (var candidateSchema in resolvedSchema.AllOf ?? [])
        {
            if (!candidateSchema.IsSchemaReference())
            {
                continue;
            }

            var candidate = candidateSchema.GetReferenceId();
            if (string.IsNullOrWhiteSpace(candidate))
            {
                continue;
            }

            if (baseReferenceId is null)
            {
                baseReferenceId = candidate;
            }
            else if (!string.Equals(baseReferenceId, candidate, StringComparison.Ordinal))
            {
                return null;
            }
        }

        return baseReferenceId;
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

        if (schema.Enum is not { Count: > 0 } ||
            !(schema.Type == null || (schema.Type & JsonSchemaType.String) == JsonSchemaType.String))
        {
            return false;
        }

        // Don't treat schemas with nullable anyOf/oneOf patterns as enums
        // Even if they have enum values, they're being used as nullable strings
        if (schema.IsNullableAnyOfLike())
        {
            return false;
        }

        return true;
    }

    public static bool IsOpenEnum(
        this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        if (!schema.IsEnum())
        {
            return false;
        }

        return TryGetOpenEnumMode(schema.Extensions, out var isOpen) && isOpen;
    }

    /// <summary>
    /// Checks if the schema has a const value.
    /// In OpenAPI 3.1+, const is used to define a single allowed value.
    /// Also checks x-stainless-const extension when a default value exists (used by OpenAI).
    /// </summary>
    public static bool IsConst(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        if (schema.Const != null)
        {
            return true;
        }

        // x-stainless-const marks discriminator fields as constant.
        // Only treat as const when there's a default value to use.
        if (OpenApiExtensions.GetExtensionBooleanValue(schema.Extensions, "x-stainless-const") &&
            schema.Default != null)
        {
            return true;
        }

        return false;
    }

    private static bool TryGetOpenEnumMode(
        IDictionary<string, IOpenApiExtension>? extensions,
        out bool isOpen)
    {
        bool? mode = null;

        if (TryGetSpeakeasyOpenEnumMode(extensions, out var speakeasyMode))
        {
            mode = MergeOpenEnumMode(mode, speakeasyMode);
        }

        if (TryGetFernOpenEnumMode(extensions, out var fernMode))
        {
            mode = MergeOpenEnumMode(mode, fernMode);
        }

        if (mode.HasValue)
        {
            isOpen = mode.Value;
            return true;
        }

        isOpen = default;
        return false;
    }

    private static bool MergeOpenEnumMode(
        bool? current,
        bool candidate)
    {
        return current == false || !candidate
            ? false
            : true;
    }

    private static bool TryGetSpeakeasyOpenEnumMode(
        IDictionary<string, IOpenApiExtension>? extensions,
        out bool isOpen)
    {
        isOpen = default;

        if (extensions?.TryGetValue("x-speakeasy-unknown-values", out var extension) != true ||
            extension == null)
        {
            return false;
        }

        if (OpenApiExtensions.TryGetExtensionStringValue(extension, out var mode))
        {
            if (string.Equals(mode, "allow", StringComparison.OrdinalIgnoreCase))
            {
                isOpen = true;
                return true;
            }

            if (string.Equals(mode, "disallow", StringComparison.OrdinalIgnoreCase))
            {
                isOpen = false;
                return true;
            }
        }

        var node = OpenApiExtensions.TryGetExtensionJsonNode(extension);
        return node is JsonValue jsonValue &&
               jsonValue.TryGetValue(out isOpen);
    }

    private static bool TryGetFernOpenEnumMode(
        IDictionary<string, IOpenApiExtension>? extensions,
        out bool isOpen)
    {
        isOpen = default;

        if (extensions?.TryGetValue("x-fern-enum", out var extension) != true ||
            extension == null ||
            OpenApiExtensions.TryGetExtensionJsonNode(extension) is not JsonObject fernEnumObject ||
            fernEnumObject["forwardCompatible"] is not JsonValue forwardCompatibleValue)
        {
            return false;
        }

        return forwardCompatibleValue.TryGetValue(out isOpen);
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

        return IsNullableUnion(schema.AnyOf);
    }

    /// <summary>
    /// Checks if the oneOf is just expressing nullability (oneOf: [X, {type: null}]).
    /// Because the null and non-null branches cannot overlap, this can be simplified
    /// to nullable X rather than a OneOf containing an object placeholder.
    /// </summary>
    public static bool IsNullableOneOf(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return IsNullableUnion(schema.OneOf);
    }

    public static bool IsNullableAnyOfLike(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.IsNullableAnyOf() || schema.IsNullableOneOf();
    }

    private static bool IsNullableUnion(IList<IOpenApiSchema>? variants)
    {
        if (variants is not { Count: 2 })
        {
            return false;
        }

        // Exactly one item must be null-type and the other non-null.
        return variants[0].IsNullType() != variants[1].IsNullType();
    }

    /// <summary>
    /// Checks if the schema is a string type or has a const value.
    /// This is primarily used for schemas whose explicit type is omitted.
    /// </summary>
    public static bool IsStringOrConst(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Explicit string type
        if (schema.Type != null && (schema.Type & JsonSchemaType.String) == JsonSchemaType.String)
        {
            return true;
        }

        if (schema.Const != null)
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
        if ((schema.Type != null && (schema.Type & JsonSchemaType.String) == JsonSchemaType.String) &&
            schema.Format == "binary")
        {
            return true;
        }

        // Handle nullable anyOf/oneOf patterns whose concrete branch is binary.
        if (schema.IsNullableAnyOfLike())
        {
            var variants = schema.AnyOf is { Count: > 0 } ? schema.AnyOf : schema.OneOf;
            var nonNullSchema = variants?.FirstOrDefault(x => !x.IsNullType());
            return nonNullSchema != null && nonNullSchema.IsBinary();
        }

        return false;
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
        var description = schema.Description;
        var describesMilliseconds = description is not null &&
            description.Contains("unix timestamp", StringComparison.OrdinalIgnoreCase) &&
            description.Contains("millisecond", StringComparison.OrdinalIgnoreCase);

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
               !describesMilliseconds &&
               schema.Description?.IndexOf("unix timestamp", StringComparison.OrdinalIgnoreCase) >= 0);
    }
}
