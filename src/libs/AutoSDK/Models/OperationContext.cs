using AutoSDK.Extensions;
using AutoSDK.Naming.Methods;
using Microsoft.OpenApi;

namespace AutoSDK.Models;

public class OperationContext(
    Settings settings,
    Settings globalSettings,
    OpenApiOperation operation,
    string operationPath,
    System.Net.Http.HttpMethod operationType)
{
    public Settings Settings { get; set; } = settings;
    public Settings GlobalSettings { get; set; } = globalSettings;
    public OpenApiOperation Operation { get; set; } = operation;
    public string OperationPath { get; set; } = operationPath;
    public System.Net.Http.HttpMethod OperationType { get; set; } = operationType;
    
    public IReadOnlyCollection<SchemaContext> Schemas { get; set; } = [];
    public IList<OpenApiSecurityRequirement> GlobalSecurityRequirements { get; set; } = [];
    
    public HashSet<string> Tags { get; set; } = [];
    public Tag Tag { get; set; } = Tag.Empty;

    public string MethodName { get; set; } = string.Empty;
    
    public static OperationContext FromOperation(
        Settings settings,
        Settings globalSettings,
        OpenApiOperation operation,
        string operationPath,
        System.Net.Http.HttpMethod operationType,
        List<SchemaContext>? operationSchemas,
        IList<OpenApiSecurityRequirement> globalSecurityRequirements,
        IReadOnlyDictionary<string, Tag>? resolvedTags = null)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var operationTags = operation.Tags;
        OpenApiTagReference? firstTag = null;
        if (operationTags != null)
        {
            foreach (var t in operationTags)
            {
                firstTag = t;
                break;
            }
        }

        // Build tags set without LINQ
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
            Tag = GetOperationTag(operation, settings, firstTag, resolvedTags),
        };
        context.MethodName = context.GetMethodName();

        return context;
    }

    private static Tag GetOperationTag(
        OpenApiOperation operation,
        Settings settings,
        OpenApiTagReference? firstTag,
        IReadOnlyDictionary<string, Tag>? resolvedTags)
    {
        // x-fern-sdk-group-name overrides the tag/group for this operation (opt-in via UseExtensionNaming)
        if (settings.UseExtensionNaming &&
            OpenApiExtensions.TryGetExtensionStringValue(
                operation.Extensions, "x-fern-sdk-group-name", out var groupName) &&
            !string.IsNullOrWhiteSpace(groupName))
        {
            // Check if there's already a resolved tag with this name
            if (resolvedTags?.TryGetValue(groupName, out var existingTag) == true)
            {
                return existingTag;
            }

            // Create a new tag from the group name
            return Tag.Create(groupName, settings);
        }

        // Default: use the first OpenAPI tag
        if (firstTag != null &&
            firstTag.Name != null &&
            resolvedTags?.TryGetValue(firstTag.Name, out var resolvedTag) == true)
        {
            return resolvedTag;
        }

        return firstTag != null
            ? Tag.FromTag(firstTag, settings)
            : Tag.Empty;
    }
}
