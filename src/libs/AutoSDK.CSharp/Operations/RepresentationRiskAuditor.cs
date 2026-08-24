using System.Text;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public sealed class RepresentationAuditFinding
{
    public RepresentationAuditFinding(
        string source,
        string operationId,
        string method,
        string path,
        string direction,
        string code,
        string severity,
        string selectedMediaType,
        string mediaTypes,
        string details)
    {
        Source = source;
        OperationId = operationId;
        Method = method;
        Path = path;
        Direction = direction;
        Code = code;
        Severity = severity;
        SelectedMediaType = selectedMediaType;
        MediaTypes = mediaTypes;
        Details = details;
    }

    public string Source { get; }
    public string OperationId { get; }
    public string Method { get; }
    public string Path { get; }
    public string Direction { get; }
    public string Code { get; }
    public string Severity { get; }
    public string SelectedMediaType { get; }
    public string MediaTypes { get; }
    public string Details { get; }
}

public static class RepresentationRiskAuditor
{
    public static IReadOnlyList<RepresentationAuditFinding> Audit(
        string source,
        IReadOnlyList<OperationContext> operations)
    {
        operations = operations ?? throw new ArgumentNullException(nameof(operations));
        var findings = new List<RepresentationAuditFinding>();

        foreach (var operation in operations)
        {
            AuditRequest(source, operation, findings);
            AuditResponses(source, operation, findings);
        }

        return findings
            .OrderBy(static finding => finding.Source, StringComparer.Ordinal)
            .ThenBy(static finding => finding.Path, StringComparer.Ordinal)
            .ThenBy(static finding => finding.Method, StringComparer.Ordinal)
            .ThenBy(static finding => finding.Direction, StringComparer.Ordinal)
            .ThenBy(static finding => finding.Code, StringComparer.Ordinal)
            .ThenBy(static finding => finding.MediaTypes, StringComparer.Ordinal)
            .ToArray();
    }

    private static void AuditRequest(
        string source,
        OperationContext operation,
        ICollection<RepresentationAuditFinding> findings)
    {
        var content = operation.Operation.RequestBody?.Content;
        if (content is not { Count: > 0 })
        {
            return;
        }

        var candidates = content.ToArray();
        var mediaTypes = string.Join(",", candidates.Select(static candidate => candidate.Key));
        string selectedMediaType;
        try
        {
            selectedMediaType = RequestRepresentationPlanner.Select(operation).MediaType;
        }
        catch (InvalidOperationException)
        {
            selectedMediaType = candidates[0].Key;
        }

        if (candidates.Length > 1)
        {
            Add(findings, source, operation, "request", "multiple-request-media-types", "info",
                selectedMediaType, mediaTypes,
                $"Operation declares {candidates.Length} request representations.");

            var fingerprints = candidates
                .Select(static candidate => GetSchemaFingerprint(candidate.Value.Schema))
                .Distinct(StringComparer.Ordinal)
                .Count();
            Add(findings, source, operation, "request",
                fingerprints == 1 ? "equivalent-request-shapes" : "distinct-request-shapes",
                fingerprints == 1 ? "info" : "warning",
                selectedMediaType, mediaTypes,
                fingerprints == 1
                    ? "All request media entries use an equivalent schema shape."
                    : $"Request media entries contain {fingerprints} distinct schema shapes; one generated method cannot represent every shape.");
        }

        var first = candidates[0];
        if (!MediaTypeCapabilities.CanEncodeRequest(first.Key, first.Value.Schema))
        {
            Add(findings, source, operation, "request", "unsupported-first-request-representation", "warning",
                selectedMediaType, mediaTypes,
                MediaTypeCapabilities.GetRequestLimitation(first.Key, first.Value.Schema));
        }

        if (!first.Key.IsMimeType("multipart/form-data") &&
            RequestRepresentationPlanner.ContainsBinary(first.Value.Schema) &&
            candidates.Any(static candidate =>
                candidate.Key.IsMimeType("multipart/form-data") &&
                RequestRepresentationPlanner.ContainsBinary(candidate.Value.Schema)))
        {
            Add(findings, source, operation, "request", "binary-prefers-multipart", "warning",
                selectedMediaType, mediaTypes,
                "The first representation contains binary data and a binary multipart alternative exists.");
        }

        foreach (var candidate in candidates)
        {
            if (candidate.Value.Schema != null &&
                !operation.Schemas.Any(schema =>
                    schema.Hint == Hint.Request &&
                    schema.ContentType.IsMimeType(candidate.Key)))
            {
                Add(findings, source, operation, "request", "missing-media-schema-context", "error",
                    selectedMediaType, candidate.Key,
                    "No request schema context is bound to this exact media type.");
            }

            var support = MediaTypeCapabilities.GetRequestSupport(candidate.Key);
            if (support == MediaTypeTransportSupport.Raw &&
                !MediaTypeCapabilities.CanEncodeRequest(candidate.Key, candidate.Value.Schema))
            {
                Add(findings, source, operation, "request", "typed-encoder-mismatch", "error",
                    selectedMediaType, candidate.Key,
                    "A typed schema would require JSON serialization while declaring a raw or provider-specific Content-Type.");
            }
        }
    }

    private static void AuditResponses(
        string source,
        OperationContext operation,
        ICollection<RepresentationAuditFinding> findings)
    {
        var candidates = (operation.Operation.Responses ?? new Dictionary<string, IOpenApiResponse>())
            .Where(static response => response.Key.StartsWith("2", StringComparison.OrdinalIgnoreCase))
            .SelectMany(static response => (response.Value.Content ?? new Dictionary<string, IOpenApiMediaType>())
                .Select(content => (
                    StatusCode: response.Key,
                    MediaType: content.Key,
                    Content: content.Value)))
            .ToArray();
        if (candidates.Length == 0)
        {
            return;
        }

        var distinctMediaTypes = candidates
            .Select(static candidate => candidate.MediaType)
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToArray();
        var selectedMediaType = distinctMediaTypes.FirstOrDefault(static mediaType =>
                                    mediaType.IsJsonMimeType() && !mediaType.IsSequentialJsonMimeType()) ??
                                distinctMediaTypes[0];
        var mediaTypes = string.Join(",", distinctMediaTypes);
        if (distinctMediaTypes.Length > 1)
        {
            Add(findings, source, operation, "response", "multiple-success-media-types", "info",
                selectedMediaType, mediaTypes,
                $"Operation declares {distinctMediaTypes.Length} success response representations.");
        }

        foreach (var candidate in candidates)
        {
            if (MediaTypeCapabilities.GetResponseSupport(candidate.MediaType) == MediaTypeTransportSupport.Unsupported)
            {
                Add(findings, source, operation, "response", "unsupported-response-representation", "warning",
                    selectedMediaType, candidate.MediaType,
                    "No typed, raw, or streaming response decoder is available for this media type.");
            }

            if (candidate.Content.Schema != null &&
                !operation.Schemas.Any(schema =>
                    schema.Hint == Hint.Response &&
                    string.Equals(schema.ResponseStatusCode, candidate.StatusCode, StringComparison.OrdinalIgnoreCase) &&
                    schema.ContentType.IsMimeType(candidate.MediaType)))
            {
                Add(findings, source, operation, "response", "missing-media-schema-context", "error",
                    selectedMediaType, candidate.MediaType,
                    $"No response schema context is bound to status {candidate.StatusCode} and this exact media type.");
            }
        }
    }

    private static void Add(
        ICollection<RepresentationAuditFinding> findings,
        string source,
        OperationContext operation,
        string direction,
        string code,
        string severity,
        string selectedMediaType,
        string mediaTypes,
        string details)
    {
        findings.Add(new RepresentationAuditFinding(
            source,
            operation.Operation.OperationId ?? operation.MethodName,
            operation.OperationType.Method.ToUpperInvariant(),
            operation.OperationPath,
            direction,
            code,
            severity,
            selectedMediaType,
            mediaTypes,
            details));
    }

    private static string GetSchemaFingerprint(IOpenApiSchema? schema)
    {
        var builder = new StringBuilder();
        AppendSchemaFingerprint(builder, schema, new HashSet<IOpenApiSchema>());
        return builder.ToString();
    }

    private static void AppendSchemaFingerprint(
        StringBuilder builder,
        IOpenApiSchema? schema,
        HashSet<IOpenApiSchema> visited)
    {
        if (schema == null)
        {
            builder.Append("null");
            return;
        }

        var resolved = schema.ResolveIfRequired();
        if (!visited.Add(resolved))
        {
            builder.Append("cycle");
            return;
        }

        builder.Append('(').Append(resolved.Type).Append('|').Append(resolved.Format);
        if (resolved.Properties != null)
        {
            builder.Append("|p{");
            foreach (var property in resolved.Properties.OrderBy(static property => property.Key, StringComparer.Ordinal))
            {
                builder.Append(property.Key).Append(':');
                AppendSchemaFingerprint(builder, property.Value, visited);
                builder.Append(';');
            }

            builder.Append('}');
        }

        builder.Append("|i:");
        AppendSchemaFingerprint(builder, resolved.Items, visited);
        AppendSchemaList(builder, "|a:", resolved.AnyOf, visited);
        AppendSchemaList(builder, "|o:", resolved.OneOf, visited);
        AppendSchemaList(builder, "|l:", resolved.AllOf, visited);
        builder.Append(')');
        visited.Remove(resolved);
    }

    private static void AppendSchemaList(
        StringBuilder builder,
        string prefix,
        IEnumerable<IOpenApiSchema>? schemas,
        HashSet<IOpenApiSchema> visited)
    {
        builder.Append(prefix).Append('[');
        if (schemas != null)
        {
            foreach (var schema in schemas)
            {
                AppendSchemaFingerprint(builder, schema, visited);
                builder.Append(';');
            }
        }

        builder.Append(']');
    }
}
