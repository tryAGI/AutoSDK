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
    internal sealed class BinarySchemaCache
    {
        private readonly Dictionary<IOpenApiSchema, bool> _results = new();
        private readonly HashSet<IOpenApiSchema> _visited = new();

        public bool ContainsBinary(IOpenApiSchema? schema)
        {
            if (schema == null)
            {
                return false;
            }

            if (_results.TryGetValue(schema, out var cached))
            {
                return cached;
            }

            _visited.Clear();
            var result = ContainsBinaryCore(schema);
            if (!result)
            {
                foreach (var visitedSchema in _visited)
                {
                    _results[visitedSchema] = false;
                }
            }

            _results[schema] = result;
            return result;
        }

        private bool ContainsBinaryCore(IOpenApiSchema? schema)
        {
            if (schema == null)
            {
                return false;
            }

            if (_results.TryGetValue(schema, out var cached))
            {
                return cached;
            }

            if (!_visited.Add(schema))
            {
                return false;
            }

            var resolved = schema.ResolveIfRequired();
            if (!ReferenceEquals(resolved, schema))
            {
                if (_results.TryGetValue(resolved, out cached))
                {
                    if (cached)
                    {
                        _results[schema] = true;
                    }
                    return cached;
                }

                if (!_visited.Add(resolved))
                {
                    return false;
                }
            }

            if (resolved.IsBinary() ||
                ContainsBinaryCore(resolved.Items) ||
                ContainsBinaryCore(resolved.Properties?.Values) ||
                ContainsBinaryCore(resolved.AnyOf) ||
                ContainsBinaryCore(resolved.OneOf) ||
                ContainsBinaryCore(resolved.AllOf))
            {
                _results[resolved] = true;
                _results[schema] = true;
                return true;
            }

            return false;
        }

        private bool ContainsBinaryCore(IEnumerable<IOpenApiSchema>? schemas)
        {
            if (schemas == null)
            {
                return false;
            }

            foreach (var schema in schemas)
            {
                if (ContainsBinaryCore(schema))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public static RequestRepresentationPlan Select(OperationContext operation)
    {
        return Select(operation, new BinarySchemaCache());
    }

    internal static RequestRepresentationPlan Select(
        OperationContext operation,
        BinarySchemaCache binarySchemaCache,
        string? preferredMediaType = null)
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

        if (!string.IsNullOrWhiteSpace(preferredMediaType))
        {
            var preferred = candidates.FirstOrDefault(candidate =>
                candidate.MediaType.IsMimeType(preferredMediaType!));
            if (string.IsNullOrWhiteSpace(preferred.MediaType))
            {
                throw new InvalidOperationException(
                    $"Request media type '{preferredMediaType}' is not declared by the operation.");
            }

            if (!MediaTypeCapabilities.CanEncodeRequest(
                    preferred.MediaType,
                    preferred.MediaTypeData?.Schema,
                    binarySchemaCache))
            {
                if (MediaTypeCapabilities.GetRequestSupport(preferred.MediaType) ==
                    MediaTypeTransportSupport.Raw)
                {
                    return new RequestRepresentationPlan(
                        preferred.MediaType,
                        preferred.MediaTypeData,
                        schemaContext: null,
                        itemSchemaContext: null);
                }

                throw new InvalidOperationException(MediaTypeCapabilities.GetRequestLimitation(
                    preferred.MediaType,
                    preferred.MediaTypeData?.Schema));
            }

            return preferred;
        }

        return Select(candidates, binarySchemaCache);
    }

    internal static IReadOnlyList<string> GetDistinctSupportedMediaTypes(
        OperationContext operation,
        BinarySchemaCache binarySchemaCache)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var content = operation.Operation.RequestBody?.Content;
        if (content == null || content.Count == 0)
        {
            return [RequestRepresentationPlan.Default.MediaType];
        }

        var candidates = content
            .Select(x => CreateCandidate(operation, x.Key, x.Value))
            .ToArray();
        var primary = Select(candidates, binarySchemaCache);
        var mediaTypes = new List<string> { primary.MediaType };
        var representedTransportSupports = new HashSet<MediaTypeTransportSupport>
        {
            MediaTypeCapabilities.GetRequestSupport(primary.MediaType),
        };

        foreach (var candidate in candidates)
        {
            if (candidate.MediaType.IsMimeType(primary.MediaType) ||
                !MediaTypeCapabilities.CanEncodeRequest(
                    candidate.MediaType,
                    candidate.MediaTypeData?.Schema,
                    binarySchemaCache))
            {
                continue;
            }

            // Equivalent typed representations (for example JSON plus multipart with
            // the same body shape) should not multiply methods. Emit a companion only
            // when the operation exposes a genuinely different transport contract,
            // such as typed JSON plus raw audio bytes.
            if (!representedTransportSupports.Add(
                    MediaTypeCapabilities.GetRequestSupport(candidate.MediaType)))
            {
                continue;
            }

            mediaTypes.Add(candidate.MediaType);
        }

        return mediaTypes;
    }

    public static RequestRepresentationPlan Select(OpenApiOperation operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var content = operation.RequestBody?.Content;
        if (content == null || content.Count == 0)
        {
            return RequestRepresentationPlan.Default;
        }

        var candidates = content
            .Select(static x => new RequestRepresentationPlan(
                mediaType: x.Key,
                mediaTypeData: x.Value,
                schemaContext: null,
                itemSchemaContext: null))
            .ToArray();
        return Select(candidates, new BinarySchemaCache());
    }

    private static RequestRepresentationPlan Select(
        RequestRepresentationPlan[] candidates,
        BinarySchemaCache binarySchemaCache)
    {
        var selected = candidates[0];

        // Preserve specification order unless the selected representation contains a
        // binary value that its encoder cannot faithfully carry. FastAPI commonly emits
        // the same UploadFile schema for JSON, form, and multipart representations; JSON
        // is first even though only multipart represents the declared wire shape.
        if (!selected.MediaType.IsMimeType("multipart/form-data") &&
            binarySchemaCache.ContainsBinary(selected.MediaTypeData?.Schema))
        {
            var multipart = candidates.FirstOrDefault(candidate =>
                candidate.MediaType.IsMimeType("multipart/form-data") &&
                binarySchemaCache.ContainsBinary(candidate.MediaTypeData?.Schema));
            if (!string.IsNullOrWhiteSpace(multipart.MediaType))
            {
                selected = multipart;
            }
        }

        if (!MediaTypeCapabilities.CanEncodeRequest(
                selected.MediaType,
                selected.MediaTypeData?.Schema,
                binarySchemaCache))
        {
            var supported = candidates.FirstOrDefault(candidate =>
                MediaTypeCapabilities.CanEncodeRequest(
                    candidate.MediaType,
                    candidate.MediaTypeData?.Schema,
                    binarySchemaCache));
            if (string.IsNullOrWhiteSpace(supported.MediaType))
            {
                if (MediaTypeCapabilities.GetRequestSupport(selected.MediaType) == MediaTypeTransportSupport.Raw)
                {
                    // Preserve the declared wire format without serializing its typed schema
                    // as JSON. The representation audit reports the schema/encoder mismatch,
                    // while the generated API remains usable through raw byte pass-through.
                    return new RequestRepresentationPlan(
                        selected.MediaType,
                        selected.MediaTypeData,
                        schemaContext: null,
                        itemSchemaContext: null);
                }

                throw new InvalidOperationException(MediaTypeCapabilities.GetRequestLimitation(
                    selected.MediaType,
                    selected.MediaTypeData?.Schema));
            }

            selected = supported;
        }

        return selected;
    }

    internal static bool ContainsBinary(IOpenApiSchema? schema)
    {
        return new BinarySchemaCache().ContainsBinary(schema);
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

}
