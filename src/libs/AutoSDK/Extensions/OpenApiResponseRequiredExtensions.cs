using Microsoft.OpenApi;

namespace AutoSDK.Extensions;

/// <summary>
/// Finds and relaxes response fields a spec declares required while also giving them a default.
/// </summary>
/// <remarks>
/// The generated deserializers enforce <c>required</c>, so a response field the service omits turns
/// a successful HTTP 200 into a JSON exception. A property that declares a <c>default</c> is one the
/// producer is allowed to leave out, which makes the pair a contradiction the service resolves in
/// its own favour. Anthropic's spec marked <c>caller</c> that way on 52 response block schemas and
/// never sends it, so every response that used a server tool failed to deserialize.
///
/// Only schemas reachable from a response body are considered: in a request body the same pair is
/// harmless, because the default is what the caller omitting the field means.
/// </remarks>
public static class OpenApiResponseRequiredExtensions
{
    /// <summary>
    /// Lists the response fields that are both required and defaulted.
    /// </summary>
    /// <remarks>
    /// These are candidates rather than confirmed defects - a service may well send a field that has
    /// a documented default - so a finding means that surface needs a live test.
    /// </remarks>
    public static IReadOnlyList<(string Schema, string Property)> FindResponseRequiredWithDefault(
        this OpenApiDocument document)
    {
        document = document ?? throw new ArgumentNullException(nameof(document));

        var findings = new List<(string Schema, string Property)>();
        foreach (var entry in EnumerateResponseReachableSchemas(document))
        {
            foreach (var property in FindRequiredWithDefault(entry.Value))
            {
                findings.Add((entry.Key, property));
            }
        }

        return findings;
    }

    /// <summary>
    /// Drops those fields from their schemas' <c>required</c> lists and returns how many were
    /// relaxed. Leniency when reading a response is the same reasoning that keeps the generated enum
    /// converters from throwing on a value the spec does not declare.
    /// </summary>
    public static int RelaxResponseRequiredWithDefault(
        this OpenApiDocument document)
    {
        document = document ?? throw new ArgumentNullException(nameof(document));

        var relaxed = 0;
        foreach (var entry in EnumerateResponseReachableSchemas(document))
        {
            var schema = entry.Value;
            var offending = FindRequiredWithDefault(schema).ToArray();
            if (offending.Length == 0 || schema.Required is null)
            {
                continue;
            }

            foreach (var property in offending)
            {
                if (schema.Required.Remove(property))
                {
                    relaxed++;
                }
            }
        }

        return relaxed;
    }

    private static IEnumerable<KeyValuePair<string, IOpenApiSchema>> EnumerateResponseReachableSchemas(
        OpenApiDocument document)
    {
        var schemas = document.Components?.Schemas;
        if (schemas is null || schemas.Count == 0)
        {
            yield break;
        }

        foreach (var name in ResponseReachableSchemaNames(document, schemas))
        {
            if (schemas.TryGetValue(name, out var schema) && schema is not null)
            {
                yield return new KeyValuePair<string, IOpenApiSchema>(name, schema);
            }
        }
    }

    private static HashSet<string> ResponseReachableSchemaNames(
        OpenApiDocument document,
        IDictionary<string, IOpenApiSchema> schemas)
    {
        var queue = new Stack<string>();
        foreach (var pathItem in document.Paths)
        {
            if (pathItem.Value?.Operations is not { } operations)
            {
                continue;
            }
            foreach (var operation in operations)
            {
                if (operation.Value?.Responses is not { } responses)
                {
                    continue;
                }
                foreach (var response in responses)
                {
                    if (response.Value?.Content is not { } contents)
                    {
                        continue;
                    }
                    foreach (var content in contents)
                    {
                        CollectReferencedSchemas(content.Value?.Schema, queue);
                    }
                }
            }
        }

        var reachable = new HashSet<string>(StringComparer.Ordinal);
        while (queue.Count > 0)
        {
            var name = queue.Pop();
            if (!reachable.Add(name) ||
                !schemas.TryGetValue(name, out var schema))
            {
                continue;
            }

            var nested = new Stack<string>();
            CollectNestedSchemas(schema, nested);
            foreach (var candidate in nested)
            {
                if (!reachable.Contains(candidate))
                {
                    queue.Push(candidate);
                }
            }
        }

        return reachable;
    }

    private static void CollectReferencedSchemas(
        IOpenApiSchema? schema,
        Stack<string> output)
    {
        if (schema is null)
        {
            return;
        }

        if (schema is OpenApiSchemaReference reference &&
            reference.Reference?.Id is { Length: > 0 } id)
        {
            output.Push(id);
            return;
        }

        CollectNestedSchemas(schema, output);
    }

    private static void CollectNestedSchemas(
        IOpenApiSchema schema,
        Stack<string> output)
    {
        if (schema.Properties is { } properties)
        {
            foreach (var property in properties)
            {
                CollectReferencedSchemas(property.Value, output);
            }
        }
        CollectReferencedSchemas(schema.Items, output);
        CollectReferencedSchemas(schema.AdditionalProperties, output);
        if (schema.OneOf is { } oneofVariants)
        {
            foreach (var variant in oneofVariants)
            {
                CollectReferencedSchemas(variant, output);
            }
        }
        if (schema.AnyOf is { } anyofVariants)
        {
            foreach (var variant in anyofVariants)
            {
                CollectReferencedSchemas(variant, output);
            }
        }
        if (schema.AllOf is { } allofVariants)
        {
            foreach (var variant in allofVariants)
            {
                CollectReferencedSchemas(variant, output);
            }
        }
    }

    private static IEnumerable<string> FindRequiredWithDefault(
        IOpenApiSchema schema)
    {
        if (schema.Required is not { Count: > 0 } ||
            schema.Properties is not { Count: > 0 } properties)
        {
            yield break;
        }

        foreach (var name in schema.Required)
        {
            if (!properties.TryGetValue(name, out var property) ||
                property?.Default is null ||
                IsDiscriminator(name, property))
            {
                continue;
            }

            yield return name;
        }
    }

    /// <summary>
    /// A const or single-value enum is a discriminator: it is always sent, default or not.
    /// </summary>
    private static bool IsDiscriminator(
        string name,
        IOpenApiSchema property)
    {
        return property.Const is not null ||
               property.Enum is { Count: 1 } ||
               string.Equals(name, "type", StringComparison.Ordinal);
    }
}
