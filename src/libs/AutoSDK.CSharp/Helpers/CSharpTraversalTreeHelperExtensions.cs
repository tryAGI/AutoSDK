using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Helpers;

public static class CSharpTraversalTreeHelperExtensions
{
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

        var operations = new List<(string OperationPath, System.Net.Http.HttpMethod OperationType, OpenApiOperation Operation)>();
        foreach (var path in paths)
        {
            var pathOps = path.Value.Operations;
            if (pathOps == null)
            {
                continue;
            }

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

        foreach (var (operationPath, operationType, operation) in operations)
        {
            var requestContent = operation.RequestBody?.Content;
            if (requestContent == null)
            {
                continue;
            }

            foreach (var content in requestContent)
            {
                if (content.Value.Schema != null)
                {
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

        foreach (var (operationPath, operationType, operation) in operations)
        {
            var parameters = operation.Parameters;
            if (parameters == null)
            {
                continue;
            }

            foreach (var param in parameters)
            {
                if (param.Schema != null)
                {
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
                    if (content.Value.Schema != null)
                    {
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
                    if (content.Value.Schema != null)
                    {
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

        return result;
    }
}
