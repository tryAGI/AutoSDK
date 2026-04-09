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

                results.Add(CSharpOperationContextFactory.CreateOperationContext(
                    settings: settings,
                    globalSettings: globalSettings,
                    operation: op.Value,
                    operationPath: path.Key,
                    operationType: op.Key,
                    operationSchemas: operationSchemas,
                    globalSecurityRequirements: globalSecurity,
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

                results.Add(CSharpOperationContextFactory.CreateOperationContext(
                    settings: settings,
                    globalSettings: globalSettings,
                    operation: op.Value,
                    operationPath: webhook.Key,
                    operationType: op.Key,
                    operationSchemas: operationSchemas,
                    globalSecurityRequirements: globalSecurity,
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
               (OpenApiExtensions.GetExtensionBooleanValue(operation.Extensions, "x-fern-ignore") ||
                OpenApiExtensions.GetExtensionBooleanValue(operation.Extensions, "x-hidden"));
    }
}
