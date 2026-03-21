using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Helpers;

public static class TraversalTreeHelper
{
    public static IReadOnlyList<SchemaContext> GetSchemas(
        this OpenApiDocument openApiDocument,
        Settings settings)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));

        var result = new List<SchemaContext>();

        // Component schemas
        if (openApiDocument.Components?.Schemas != null)
        {
            foreach (var schema in openApiDocument.Components.Schemas)
            {
                result.AddRange(SchemaContext.FromSchema(
                    schema: schema.Value,
                    settings: settings,
                    componentId: schema.Key,
                    hint: Hint.Component));
            }
        }

        // Collect filtered operations once to avoid repeated path/extension checks
        var paths = openApiDocument.Paths;
        if (paths == null)
        {
            return result;
        }

        var operations = new List<(string OperationPath, System.Net.Http.HttpMethod OperationType, OpenApiOperation Operation)>();
        foreach (var path in paths)
        {
            var pathOps = path.Value.Operations;
            if (pathOps == null) continue;
            foreach (var op in pathOps)
            {
                if (settings.UseExtensionNaming &&
                    (OpenApiExtensions.GetExtensionBooleanValue(op.Value.Extensions, "x-fern-ignore") ||
                     OpenApiExtensions.GetExtensionBooleanValue(op.Value.Extensions, "x-hidden")))
                {
                    continue;
                }
                operations.Add((path.Key, op.Key, op.Value));
            }
        }

        // Process in same order as original: all request bodies, then all parameters,
        // then all parameter content, then all responses — preserving schema ordering
        // that name collision resolution depends on.

        // Request bodies
        foreach (var (operationPath, operationType, operation) in operations)
        {
            var requestContent = operation.RequestBody?.Content;
            if (requestContent == null) continue;
            foreach (var content in requestContent)
            {
                if (content.Value.Schema != null)
                {
                    result.AddRange(SchemaContext.FromSchema(
                        schema: content.Value.Schema,
                        settings: settings,
                        operationPath: operationPath,
                        operationType: operationType,
                        operation: operation,
                        contentType: content.Key,
                        mediaType: content.Value,
                        hint: Hint.Request));
                }
            }
        }

        // Parameters (schema)
        foreach (var (operationPath, operationType, operation) in operations)
        {
            var parameters = operation.Parameters;
            if (parameters == null) continue;
            foreach (var param in parameters)
            {
                if (param.Schema != null)
                {
                    result.AddRange(SchemaContext.FromSchema(
                        schema: param.Schema,
                        settings: settings,
                        operationPath: operationPath,
                        operationType: operationType,
                        operation: operation,
                        contentType: null,
                        mediaType: null,
                        parameter: param,
                        hint: Hint.Parameter));
                }
            }
        }

        // Parameters (content)
        foreach (var (operationPath, operationType, operation) in operations)
        {
            var parameters = operation.Parameters;
            if (parameters == null) continue;
            foreach (var param in parameters)
            {
                var paramContent = param.Content;
                if (paramContent == null) continue;
                foreach (var content in paramContent)
                {
                    if (content.Value.Schema != null)
                    {
                        result.AddRange(SchemaContext.FromSchema(
                            schema: content.Value.Schema,
                            settings: settings,
                            operationPath: operationPath,
                            operationType: operationType,
                            operation: operation,
                            contentType: content.Key,
                            mediaType: content.Value,
                            parameter: param,
                            hint: Hint.Parameter));
                    }
                }
            }
        }

        // Responses
        foreach (var (operationPath, operationType, operation) in operations)
        {
            var responses = operation.Responses;
            if (responses == null) continue;
            foreach (var response in responses)
            {
                var responseContent = response.Value.Content;
                if (responseContent == null) continue;
                foreach (var content in responseContent)
                {
                    if (content.Value.Schema != null)
                    {
                        result.AddRange(SchemaContext.FromSchema(
                            schema: content.Value.Schema,
                            settings: settings,
                            operationPath: operationPath,
                            operationType: operationType,
                            operation: operation,
                            contentType: content.Key,
                            mediaType: content.Value,
                            responseStatusCode: response.Key,
                            response: response.Value,
                            hint: Hint.Response));
                    }
                }
            }
        }

        return result;
    }

    public static IReadOnlyList<OperationContext> GetOperations(
        this OpenApiDocument openApiDocument,
        Settings settings,
        Settings globalSettings,
        IReadOnlyCollection<SchemaContext> filteredSchemas,
        IReadOnlyDictionary<string, Tag>? resolvedTags = null)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));

        var pathItems = openApiDocument.Paths;
        if (pathItems == null) return [];

        // Pre-build operation → schemas lookup to avoid O(ops × schemas) scan
        var schemasByOperation = new Dictionary<OpenApiOperation, List<SchemaContext>>();
        foreach (var schema in filteredSchemas)
        {
            if (schema.Operation != null)
            {
                if (!schemasByOperation.TryGetValue(schema.Operation, out var list))
                {
                    list = new List<SchemaContext>(8);
                    schemasByOperation[schema.Operation] = list;
                }
                list.Add(schema);
            }
        }

        var globalSecurity = openApiDocument.Security ?? [];
        var results = new List<OperationContext>();
        foreach (var path in pathItems)
        {
            var pathOps = path.Value.Operations;
            if (pathOps == null) continue;
            foreach (var op in pathOps)
            {
                // Skip operations marked with x-fern-ignore: true or x-hidden: true (opt-in via UseExtensionNaming)
                if (settings.UseExtensionNaming &&
                    (OpenApiExtensions.GetExtensionBooleanValue(op.Value.Extensions, "x-fern-ignore") ||
                     OpenApiExtensions.GetExtensionBooleanValue(op.Value.Extensions, "x-hidden")))
                {
                    continue;
                }

                schemasByOperation.TryGetValue(op.Value, out var operationSchemas);

                results.Add(OperationContext.FromOperation(
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
}
