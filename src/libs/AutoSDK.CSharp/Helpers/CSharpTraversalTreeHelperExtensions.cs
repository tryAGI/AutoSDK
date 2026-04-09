using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Helpers;

public static class CSharpTraversalTreeHelperExtensions
{
    private readonly record struct OperationSchemaDescriptor(
        string OperationPath,
        System.Net.Http.HttpMethod OperationType,
        OpenApiOperation Operation);

    public static IReadOnlyList<SchemaContext> GetSchemas(
        this OpenApiDocument openApiDocument,
        CSharpSettings settings)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        var schemaSettings = settings.ToSchemaContextSettings();

        var result = new List<SchemaContext>();

        if (openApiDocument.Components?.Schemas != null)
        {
            foreach (var schema in openApiDocument.Components.Schemas)
            {
                result.AddRange(SchemaContext.FromSchema(
                    schema.Value, schemaSettings,
                    CSharpSchemaNamingFactory.CreateReferenceId,
                    CSharpSchemaNamingFactory.CreateSchemaId,
                    parent: null, componentId: schema.Key,
                    propertyName: null, operationPath: null, operationType: null,
                    operation: null, contentType: null, mediaType: null,
                    parameter: null, responseStatusCode: null, response: null,
                    hint: Hint.Component, index: null, depth: 0));
            }
        }

        var paths = openApiDocument.Paths;
        if (paths == null)
        {
            return result;
        }

        var operations = GetPathOperationDescriptors(paths, settings);
        AddRequestSchemas(result, schemaSettings, operations);
        AddParameterSchemas(result, schemaSettings, operations);
        AddParameterContentSchemas(result, schemaSettings, operations);
        AddResponseSchemas(result, schemaSettings, operations);

        var callbackOperations = GetCallbackOperationDescriptors(operations, settings).ToArray();
        AddRequestSchemas(result, schemaSettings, callbackOperations);
        AddParameterSchemas(result, schemaSettings, callbackOperations);
        AddParameterContentSchemas(result, schemaSettings, callbackOperations);
        AddResponseSchemas(result, schemaSettings, callbackOperations);

        var webhookOperations = GetWebhookOperationDescriptors(openApiDocument, settings).ToArray();
        AddRequestSchemas(result, schemaSettings, webhookOperations);
        AddParameterSchemas(result, schemaSettings, webhookOperations);
        AddParameterContentSchemas(result, schemaSettings, webhookOperations);
        AddResponseSchemas(result, schemaSettings, webhookOperations);

        return result;
    }

    private static List<OperationSchemaDescriptor> GetPathOperationDescriptors(
        OpenApiPaths paths,
        CSharpSettings settings)
    {
        var operations = new List<OperationSchemaDescriptor>();
        foreach (var path in paths)
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

                operations.Add(new OperationSchemaDescriptor(path.Key, op.Key, op.Value));
            }
        }

        return operations;
    }

    private static IEnumerable<OperationSchemaDescriptor> GetCallbackOperationDescriptors(
        IEnumerable<OperationSchemaDescriptor> operations,
        CSharpSettings settings)
    {
        foreach (var (_, _, operation) in operations)
        {
            var callbacks = operation.Callbacks;
            if (callbacks == null)
            {
                continue;
            }

            foreach (var callback in callbacks)
            {
                var pathItems = callback.Value.PathItems;
                if (pathItems == null)
                {
                    continue;
                }

                foreach (var pathItem in pathItems)
                {
                    var callbackOperations = pathItem.Value.Operations;
                    if (callbackOperations == null)
                    {
                        continue;
                    }

                    foreach (var callbackOperation in callbackOperations)
                    {
                        if (ShouldIgnoreOperation(settings, callbackOperation.Value))
                        {
                            continue;
                        }

                        yield return new OperationSchemaDescriptor(
                            pathItem.Key.ToString(),
                            callbackOperation.Key,
                            callbackOperation.Value);
                    }
                }
            }
        }
    }

    private static IEnumerable<OperationSchemaDescriptor> GetWebhookOperationDescriptors(
        OpenApiDocument openApiDocument,
        CSharpSettings settings)
    {
        var webhooks = openApiDocument.Webhooks;
        if (webhooks == null)
        {
            yield break;
        }

        foreach (var webhook in webhooks)
        {
            var webhookOperations = webhook.Value.Operations;
            if (webhookOperations == null)
            {
                continue;
            }

            foreach (var webhookOperation in webhookOperations)
            {
                if (ShouldIgnoreOperation(settings, webhookOperation.Value))
                {
                    continue;
                }

                yield return new OperationSchemaDescriptor(
                    webhook.Key,
                    webhookOperation.Key,
                    webhookOperation.Value);
            }
        }
    }

    private static void AddRequestSchemas(
        List<SchemaContext> result,
        SchemaContextSettings schemaSettings,
        IEnumerable<OperationSchemaDescriptor> operations)
    {
        foreach (var (operationPath, operationType, operation) in operations)
        {
            var requestContent = operation.RequestBody?.Content;
            if (requestContent == null)
            {
                continue;
            }

            foreach (var content in requestContent)
            {
                if (content.Value.Schema == null)
                {
                    continue;
                }

                result.AddRange(SchemaContext.FromSchema(
                    content.Value.Schema, schemaSettings,
                    CSharpSchemaNamingFactory.CreateReferenceId,
                    CSharpSchemaNamingFactory.CreateSchemaId,
                    parent: null, componentId: null,
                    propertyName: null, operationPath: operationPath, operationType: operationType,
                    operation: operation, contentType: content.Key, mediaType: content.Value,
                    parameter: null, responseStatusCode: null, response: null,
                    hint: Hint.Request, index: null, depth: 0));
            }
        }
    }

    private static void AddParameterSchemas(
        List<SchemaContext> result,
        SchemaContextSettings schemaSettings,
        IEnumerable<OperationSchemaDescriptor> operations)
    {
        foreach (var (operationPath, operationType, operation) in operations)
        {
            var parameters = operation.Parameters;
            if (parameters == null)
            {
                continue;
            }

            foreach (var param in parameters)
            {
                if (param.Schema == null)
                {
                    continue;
                }

                result.AddRange(SchemaContext.FromSchema(
                    param.Schema, schemaSettings,
                    CSharpSchemaNamingFactory.CreateReferenceId,
                    CSharpSchemaNamingFactory.CreateSchemaId,
                    parent: null, componentId: null,
                    propertyName: null, operationPath: operationPath, operationType: operationType,
                    operation: operation, contentType: null, mediaType: null,
                    parameter: param, responseStatusCode: null, response: null,
                    hint: Hint.Parameter, index: null, depth: 0));
            }
        }
    }

    private static void AddParameterContentSchemas(
        List<SchemaContext> result,
        SchemaContextSettings schemaSettings,
        IEnumerable<OperationSchemaDescriptor> operations)
    {
        foreach (var (operationPath, operationType, operation) in operations)
        {
            var parameters = operation.Parameters;
            if (parameters == null)
            {
                continue;
            }

            foreach (var param in parameters)
            {
                var paramContent = param.Content;
                if (paramContent == null)
                {
                    continue;
                }

                foreach (var content in paramContent)
                {
                    if (content.Value.Schema == null)
                    {
                        continue;
                    }

                    result.AddRange(SchemaContext.FromSchema(
                        content.Value.Schema, schemaSettings,
                        CSharpSchemaNamingFactory.CreateReferenceId,
                        CSharpSchemaNamingFactory.CreateSchemaId,
                        parent: null, componentId: null,
                        propertyName: null, operationPath: operationPath, operationType: operationType,
                        operation: operation, contentType: content.Key, mediaType: content.Value,
                        parameter: param, responseStatusCode: null, response: null,
                        hint: Hint.Parameter, index: null, depth: 0));
                }
            }
        }
    }

    private static void AddResponseSchemas(
        List<SchemaContext> result,
        SchemaContextSettings schemaSettings,
        IEnumerable<OperationSchemaDescriptor> operations)
    {
        foreach (var (operationPath, operationType, operation) in operations)
        {
            var responses = operation.Responses;
            if (responses == null)
            {
                continue;
            }

            foreach (var response in responses)
            {
                var responseContent = response.Value.Content;
                if (responseContent == null)
                {
                    continue;
                }

                foreach (var content in responseContent)
                {
                    if (content.Value.Schema == null)
                    {
                        continue;
                    }

                    result.AddRange(SchemaContext.FromSchema(
                        content.Value.Schema, schemaSettings,
                        CSharpSchemaNamingFactory.CreateReferenceId,
                        CSharpSchemaNamingFactory.CreateSchemaId,
                        parent: null, componentId: null,
                        propertyName: null, operationPath: operationPath, operationType: operationType,
                        operation: operation, contentType: content.Key, mediaType: content.Value,
                        parameter: null, responseStatusCode: response.Key, response: response.Value,
                        hint: Hint.Response, index: null, depth: 0));
                }
            }
        }
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
