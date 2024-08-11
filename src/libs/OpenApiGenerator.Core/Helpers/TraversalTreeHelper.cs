using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Helpers;

public static class TraversalTreeHelper
{
    public static IReadOnlyList<SchemaContext> GetSchemaContexts(
        this OpenApiDocument openApiDocument,
        Settings settings)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));

        var allOperations = openApiDocument.Paths!
            .SelectMany(x => x.Value.Operations.Select(y => (OperationPath: x.Key, OperationType: y.Key, Operation: y.Value)))
            .ToArray();
        return openApiDocument.Components!.Schemas!
            .SelectMany(schema => SchemaContext.FromSchema(
                schema: schema.Value,
                settings: settings,
                componentId: schema.Key,
                hint: Hint.Component))
            .Concat(allOperations
                .Where(x => x.Operation.RequestBody != null)
                .SelectMany(x => x.Operation.RequestBody!.Content.Select(y => (x.OperationPath, x.OperationType, x.Operation, ContentType: y.Key, MediaType: y.Value)))
                .Where(x => x.MediaType.Schema != null)
                .SelectMany(x => SchemaContext.FromSchema(
                    schema: x.MediaType.Schema!,
                    settings: settings,
                    operationPath: x.OperationPath,
                    operationType: x.OperationType,
                    operation: x.Operation,
                    contentType: x.ContentType,
                    mediaType: x.MediaType,
                    hint: Hint.Request)))
            .Concat(allOperations
                .SelectMany(x => (x.Operation.Parameters ?? []).Select(y => (x.OperationPath, x.OperationType, x.Operation, Parameter: y)))
                .Where(x => x.Parameter.Schema != null)
                .SelectMany(x => SchemaContext.FromSchema(
                    schema: x.Parameter.Schema!,
                    settings: settings,
                    operationPath: x.OperationPath,
                    operationType: x.OperationType,
                    operation: x.Operation,
                    contentType: null,
                    mediaType: null,
                    parameter: x.Parameter,
                    hint: Hint.Parameter)))
            .Concat(allOperations
                .SelectMany(x => (x.Operation.Parameters ?? []).Select(y => (x.OperationPath, x.OperationType, x.Operation, Parameter: y)))
                .SelectMany(x => x.Parameter.Content.Select(y => (x.OperationPath, x.OperationType, x.Operation, x.Parameter, ContentType: y.Key, MediaType: y.Value)))
                .Where(x => x.MediaType.Schema != null)
                .SelectMany(x => SchemaContext.FromSchema(
                    schema: x.MediaType.Schema!,
                    settings: settings,
                    operationPath: x.OperationPath,
                    operationType: x.OperationType,
                    operation: x.Operation,
                    contentType: x.ContentType,
                    mediaType: x.MediaType,
                    parameter: x.Parameter,
                    hint: Hint.Parameter)))
            .Concat(allOperations
                .SelectMany(x => (x.Operation.Responses ?? []).Select(y => (x.OperationPath, x.OperationType, x.Operation, ResponseStatusCode: y.Key, Response: y.Value)))
                .SelectMany(x => x.Response.Content.Select(y => (x.OperationPath, x.OperationType, x.Operation, x.ResponseStatusCode, x.Response, ContentType: y.Key, MediaType: y.Value)))
                .Where(x => x.MediaType.Schema != null)
                .SelectMany(x => SchemaContext.FromSchema(
                    schema: x.MediaType.Schema!,
                    settings: settings,
                    operationPath: x.OperationPath,
                    operationType: x.OperationType,
                    operation: x.Operation,
                    contentType: x.ContentType,
                    mediaType: x.MediaType,
                    responseStatusCode: x.ResponseStatusCode,
                    response: x.Response,
                    hint: Hint.Response)))
            .ToArray();
    }
}