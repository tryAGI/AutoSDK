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
            foreach (var op in path.Value.Operations ?? new Dictionary<System.Net.Http.HttpMethod, OpenApiOperation>())
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
            if (operation.RequestBody == null) continue;
            foreach (var content in operation.RequestBody.Content ?? new Dictionary<string, IOpenApiMediaType>())
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
            foreach (var param in operation.Parameters ?? [])
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
            foreach (var param in operation.Parameters ?? [])
            {
                foreach (var content in param.Content ?? new Dictionary<string, IOpenApiMediaType>())
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
            foreach (var response in operation.Responses ?? new Dictionary<string, IOpenApiResponse>())
            {
                foreach (var content in response.Value.Content ?? new Dictionary<string, IOpenApiMediaType>())
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

        return openApiDocument.Paths?
            .SelectMany(x => (x.Value.Operations ?? new Dictionary<System.Net.Http.HttpMethod, OpenApiOperation>())
                // Skip operations marked with x-fern-ignore: true or x-hidden: true (opt-in via UseExtensionNaming)
                .Where(y => !settings.UseExtensionNaming ||
                            (!OpenApiExtensions.GetExtensionBooleanValue(y.Value.Extensions, "x-fern-ignore") &&
                             !OpenApiExtensions.GetExtensionBooleanValue(y.Value.Extensions, "x-hidden")))
                .Select(y => OperationContext.FromOperation(
                    settings: settings,
                    globalSettings: globalSettings,
                    operation: y.Value,
                    operationPath: x.Key,
                    operationType: y.Key,
                    filteredSchemas: filteredSchemas,
                    globalSecurityRequirements: openApiDocument.Security ?? [],
                    resolvedTags: resolvedTags)))
            .ToArray() ?? [];
    }
}
