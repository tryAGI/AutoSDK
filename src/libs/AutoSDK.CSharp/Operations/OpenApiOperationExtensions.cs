using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static class OpenApiOperationExtensions
{
    public static IReadOnlyList<OperationContext> GetOperations(
        this OpenApiDocument openApiDocument,
        CSharpSettings settings,
        CSharpSettings globalSettings,
        IReadOnlyCollection<SchemaContext> filteredSchemas,
        IReadOnlyDictionary<string, Tag>? resolvedTags = null)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        filteredSchemas = filteredSchemas ?? throw new ArgumentNullException(nameof(filteredSchemas));

        var pathItems = openApiDocument.Paths;
        if (pathItems == null)
        {
            return [];
        }

        var schemasByOperation = BuildSchemasByOperation(filteredSchemas);

        var globalSecurity = openApiDocument.Security ?? [];
        var documentServers = openApiDocument.Servers ?? [];
        var documentIdempotencyHeaders = OpenApiExtensions.GetDocumentIdempotencyHeaders(openApiDocument.Extensions);
        var results = new List<OperationContext>();
        foreach (var path in pathItems)
        {
            var pathOps = path.Value.Operations;
            if (pathOps == null)
            {
                continue;
            }

            foreach (var op in pathOps)
            {
                if (ShouldIgnoreOperation(settings, op.Value))
                {
                    continue;
                }

                schemasByOperation.TryGetValue(op.Value, out var operationSchemas);

                var effectiveServers = GetEffectiveServers(
                    documentServers,
                    path.Value.Servers,
                    op.Value.Servers);
                var hasServerOverride = HasServerOverride(
                    documentServers,
                    path.Value.Servers,
                    op.Value.Servers);

                results.Add(CSharpOperationContextFactory.CreateOperationContext(
                    settings: settings,
                    globalSettings: globalSettings,
                    operation: op.Value,
                    operationPath: path.Key,
                    operationType: op.Key,
                    operationSchemas: operationSchemas,
                    effectiveServers: effectiveServers,
                    hasServerOverride: hasServerOverride,
                    globalSecurityRequirements: globalSecurity,
                    documentIdempotencyHeaders: documentIdempotencyHeaders,
                    resolvedTags: resolvedTags));
            }
        }

        return results;
    }

    public static IReadOnlyList<OperationContext> GetWebhookOperations(
        this OpenApiDocument openApiDocument,
        CSharpSettings settings,
        CSharpSettings globalSettings,
        IReadOnlyCollection<SchemaContext> filteredSchemas,
        IReadOnlyDictionary<string, Tag>? resolvedTags = null)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        filteredSchemas = filteredSchemas ?? throw new ArgumentNullException(nameof(filteredSchemas));

        var webhooks = openApiDocument.Webhooks;
        if (webhooks == null)
        {
            return [];
        }

        var schemasByOperation = BuildSchemasByOperation(filteredSchemas);
        var globalSecurity = openApiDocument.Security ?? [];
        var documentServers = openApiDocument.Servers ?? [];
        var documentIdempotencyHeaders = OpenApiExtensions.GetDocumentIdempotencyHeaders(openApiDocument.Extensions);
        var results = new List<OperationContext>();

        foreach (var webhook in webhooks)
        {
            var webhookOperations = webhook.Value.Operations;
            if (webhookOperations == null)
            {
                continue;
            }

            foreach (var op in webhookOperations)
            {
                if (ShouldIgnoreOperation(settings, op.Value))
                {
                    continue;
                }

                schemasByOperation.TryGetValue(op.Value, out var operationSchemas);

                var effectiveServers = GetEffectiveServers(
                    documentServers,
                    webhook.Value.Servers,
                    op.Value.Servers);
                var hasServerOverride = HasServerOverride(
                    documentServers,
                    webhook.Value.Servers,
                    op.Value.Servers);

                results.Add(CSharpOperationContextFactory.CreateOperationContext(
                    settings: settings,
                    globalSettings: globalSettings,
                    operation: op.Value,
                    operationPath: webhook.Key,
                    operationType: op.Key,
                    operationSchemas: operationSchemas,
                    effectiveServers: effectiveServers,
                    hasServerOverride: hasServerOverride,
                    globalSecurityRequirements: globalSecurity,
                    documentIdempotencyHeaders: documentIdempotencyHeaders,
                    resolvedTags: resolvedTags));
            }
        }

        return results;
    }

    private static Dictionary<OpenApiOperation, List<SchemaContext>> BuildSchemasByOperation(
        IReadOnlyCollection<SchemaContext> filteredSchemas)
    {
        var schemasByOperation = new Dictionary<OpenApiOperation, List<SchemaContext>>();
        foreach (var schema in filteredSchemas)
        {
            if (schema.Operation == null)
            {
                continue;
            }

            if (!schemasByOperation.TryGetValue(schema.Operation, out var list))
            {
                list = new List<SchemaContext>(8);
                schemasByOperation[schema.Operation] = list;
            }

            list.Add(schema);
        }

        return schemasByOperation;
    }

    private static bool ShouldIgnoreOperation(
        CSharpSettings settings,
        OpenApiOperation operation)
    {
        return settings.UseExtensionNaming &&
               OpenApiExtensions.ShouldIgnoreOperationForDotNet(operation.Extensions);
    }

    private static IList<OpenApiServer> GetEffectiveServers(
        IList<OpenApiServer> documentServers,
        IList<OpenApiServer>? pathServers,
        IList<OpenApiServer>? operationServers)
    {
        if (operationServers is { Count: > 0 })
        {
            return operationServers;
        }

        if (pathServers is { Count: > 0 })
        {
            return pathServers;
        }

        return documentServers;
    }

    private static bool HasServerOverride(
        IList<OpenApiServer> documentServers,
        IList<OpenApiServer>? pathServers,
        IList<OpenApiServer>? operationServers)
    {
        if (operationServers is { Count: > 0 })
        {
            var inheritedServers = pathServers is { Count: > 0 }
                ? pathServers
                : documentServers;
            return !AreEquivalent(operationServers, inheritedServers);
        }

        return pathServers is { Count: > 0 } &&
               !AreEquivalent(pathServers, documentServers);
    }

    private static bool AreEquivalent(
        IList<OpenApiServer> left,
        IList<OpenApiServer> right)
    {
        if (ReferenceEquals(left, right))
        {
            return true;
        }

        if (left.Count != right.Count)
        {
            return false;
        }

        for (var i = 0; i < left.Count; i++)
        {
            var leftUrl = left[i].ExpandServerTemplate();
            var rightUrl = right[i].ExpandServerTemplate();
            if (!string.Equals(leftUrl, rightUrl, StringComparison.Ordinal))
            {
                return false;
            }
        }

        return true;
    }
}
