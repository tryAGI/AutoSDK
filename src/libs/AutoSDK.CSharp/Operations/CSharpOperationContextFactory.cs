using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static class CSharpOperationContextFactory
{
    public static OperationContext CreateOperationContext(
        CSharpSettings settings,
        CSharpSettings globalSettings,
        OpenApiOperation operation,
        string operationPath,
        System.Net.Http.HttpMethod operationType,
        IReadOnlyList<SchemaContext>? operationSchemas,
        IList<OpenApiSecurityRequirement> globalSecurityRequirements,
        IReadOnlyList<IdempotencyHeader>? documentIdempotencyHeaders = null,
        IReadOnlyDictionary<string, Tag>? resolvedTags = null)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var operationTags = operation.Tags;
        OpenApiTagReference? firstTag = null;
        if (operationTags != null)
        {
            foreach (var tag in operationTags)
            {
                firstTag = tag;
                break;
            }
        }

        var tags = new HashSet<string>();
        if (operationTags != null)
        {
            foreach (var tag in operationTags)
            {
                if (tag.Name != null)
                {
                    tags.Add(tag.Name);
                }
            }
        }

        var context = new OperationContext(settings, globalSettings, operation, operationPath, operationType)
        {
            Schemas = operationSchemas ?? (IReadOnlyCollection<SchemaContext>)[],
            Tags = tags,
            GlobalSecurityRequirements = globalSecurityRequirements,
            DocumentIdempotencyHeaders = documentIdempotencyHeaders ?? [],
            Tag = GetOperationTag(operation, settings, firstTag, resolvedTags),
        };
        context.MethodName = context.GetMethodName();

        return context;
    }

    private static Tag GetOperationTag(
        OpenApiOperation operation,
        CSharpSettings settings,
        OpenApiTagReference? firstTag,
        IReadOnlyDictionary<string, Tag>? resolvedTags)
    {
        if (settings.UseExtensionNaming &&
            OpenApiExtensions.TryGetOperationGroupNameOverride(operation.Extensions, out var groupName) &&
            !string.IsNullOrWhiteSpace(groupName))
        {
            if (resolvedTags?.TryGetValue(groupName, out var existingTag) == true)
            {
                return existingTag;
            }

            return CSharpTagFactory.Create(groupName, settings);
        }

        if (firstTag != null &&
            firstTag.Name != null &&
            resolvedTags?.TryGetValue(firstTag.Name, out var resolvedTag) == true)
        {
            return resolvedTag;
        }

        return firstTag != null
            ? CSharpTagFactory.FromTag(firstTag, settings)
            : Tag.Empty;
    }
}
