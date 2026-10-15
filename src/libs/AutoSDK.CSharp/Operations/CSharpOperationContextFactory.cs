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
        IList<OpenApiServer> effectiveServers,
        bool hasServerOverride,
        IList<OpenApiSecurityRequirement> globalSecurityRequirements,
        IReadOnlyList<IdempotencyHeader>? documentIdempotencyHeaders = null,
        IReadOnlyDictionary<string, Tag>? resolvedTags = null)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));
        operationPath = operationPath ?? throw new ArgumentNullException(nameof(operationPath));

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

        var (requestPath, overloadSuffix) = NormalizeOperationPath(operationPath);
        var context = new OperationContext(settings, globalSettings, operation, requestPath, operationType)
        {
            Schemas = operationSchemas ?? (IReadOnlyCollection<SchemaContext>)[],
            Servers = effectiveServers,
            HasServerOverride = hasServerOverride,
            Tags = tags,
            GlobalSecurityRequirements = globalSecurityRequirements,
            DocumentIdempotencyHeaders = documentIdempotencyHeaders ?? [],
            Tag = GetOperationTag(operation, settings, firstTag, resolvedTags),
        };
        context.MethodName = context.GetMethodName() + overloadSuffix;

        return context;
    }

    private static (string RequestPath, string OverloadSuffix) NormalizeOperationPath(string operationPath)
    {
        var queryIndex = operationPath.IndexOf('?');
        if (queryIndex < 0)
        {
            return (operationPath, string.Empty);
        }

        const string marker = "?stainless_overload=";
        var overload = operationPath.Substring(queryIndex);
        if (!overload.StartsWith(marker, StringComparison.Ordinal))
        {
            return (operationPath, string.Empty);
        }

        if (overload.Length == marker.Length ||
            overload.Substring(marker.Length).Any(character =>
                !char.IsLetterOrDigit(character) && character is not ('_' or '-')))
        {
            throw new NotSupportedException(
                $"OpenAPI path '{operationPath}' contains an invalid Stainless overload name. " +
                "Expected ?stainless_overload=<name>.");
        }

        // Stainless uses this suffix to distinguish operations sharing the same HTTP route.
        // It is metadata, not a query parameter sent to the provider.
        return (
            operationPath.Substring(0, queryIndex),
            overload.Substring(marker.Length).ToPropertyName());
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
