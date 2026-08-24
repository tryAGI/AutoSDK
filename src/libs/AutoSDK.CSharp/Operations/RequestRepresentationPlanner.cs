using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

internal readonly struct RequestRepresentationPlan
{
    public RequestRepresentationPlan(
        string mediaType,
        IOpenApiMediaType? mediaTypeData,
        SchemaContext? schemaContext,
        SchemaContext? itemSchemaContext)
    {
        MediaType = mediaType;
        MediaTypeData = mediaTypeData;
        SchemaContext = schemaContext;
        ItemSchemaContext = itemSchemaContext;
    }

    public string MediaType { get; }
    public IOpenApiMediaType? MediaTypeData { get; }
    public SchemaContext? SchemaContext { get; }
    public SchemaContext? ItemSchemaContext { get; }

    public static RequestRepresentationPlan Default => new(
        mediaType: "application/json",
        mediaTypeData: null,
        schemaContext: null,
        itemSchemaContext: null);
}

internal static class RequestRepresentationPlanner
{
    public static RequestRepresentationPlan Select(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var content = operation.Operation.RequestBody?.Content;
        if (content == null || content.Count == 0)
        {
            return RequestRepresentationPlan.Default;
        }

        var candidates = content
            .Select(x => CreateCandidate(operation, x.Key, x.Value))
            .ToArray();
        var selected = candidates[0];

        // Preserve specification order unless the selected representation contains a
        // binary value that its encoder cannot faithfully carry. FastAPI commonly emits
        // the same UploadFile schema for JSON, form, and multipart representations; JSON
        // is first even though only multipart represents the declared wire shape.
        if (!selected.MediaType.IsMimeType("multipart/form-data") &&
            ContainsBinary(selected.MediaTypeData?.Schema))
        {
            var multipart = candidates.FirstOrDefault(static candidate =>
                candidate.MediaType.IsMimeType("multipart/form-data") &&
                ContainsBinary(candidate.MediaTypeData?.Schema));
            if (!string.IsNullOrWhiteSpace(multipart.MediaType))
            {
                selected = multipart;
            }
        }

        return selected;
    }

    internal static bool ContainsBinary(IOpenApiSchema? schema)
    {
        return ContainsBinary(schema, new HashSet<IOpenApiSchema>());
    }

    private static RequestRepresentationPlan CreateCandidate(
        OperationContext operation,
        string mediaType,
        IOpenApiMediaType mediaTypeData)
    {
        return new RequestRepresentationPlan(
            mediaType: mediaType,
            mediaTypeData: mediaTypeData,
            schemaContext: operation.Schemas.FirstOrDefault(x =>
                x.Hint == Hint.Request &&
                x.ContentType.IsMimeType(mediaType) &&
                !x.IsMediaTypeItemSchema),
            itemSchemaContext: operation.Schemas.FirstOrDefault(x =>
                x.Hint == Hint.Request &&
                x.ContentType.IsMimeType(mediaType) &&
                x.IsMediaTypeItemSchema));
    }

    private static bool ContainsBinary(
        IOpenApiSchema? schema,
        HashSet<IOpenApiSchema> visited)
    {
        if (schema == null || !visited.Add(schema))
        {
            return false;
        }

        var resolved = schema.ResolveIfRequired();
        if (!ReferenceEquals(resolved, schema) && !visited.Add(resolved))
        {
            return false;
        }

        if (resolved.IsBinary())
        {
            return true;
        }

        if (ContainsBinary(resolved.Items, visited))
        {
            return true;
        }

        if (resolved.Properties != null &&
            resolved.Properties.Values.Any(property => ContainsBinary(property, visited)))
        {
            return true;
        }

        return ContainsBinary(resolved.AnyOf, visited) ||
               ContainsBinary(resolved.OneOf, visited) ||
               ContainsBinary(resolved.AllOf, visited);
    }

    private static bool ContainsBinary(
        IEnumerable<IOpenApiSchema>? schemas,
        HashSet<IOpenApiSchema> visited)
    {
        return schemas != null && schemas.Any(schema => ContainsBinary(schema, visited));
    }
}
