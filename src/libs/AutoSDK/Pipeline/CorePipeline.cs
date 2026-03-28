using System.Collections.Immutable;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Models.AsyncApi;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static class CorePipeline
{
    public static CorePipelineResult Prepare(
        ((string Text, Settings Settings) Context, Settings GlobalSettings) tuple,
        Func<OpenApiDocument, Settings, IReadOnlyList<SchemaContext>> getSchemas,
        Action<IReadOnlyList<SchemaContext>> applyNaming,
        Func<string, string> toClassName,
        Func<string, string> toPropertyName,
        CancellationToken cancellationToken = default)
    {
        getSchemas = getSchemas ?? throw new ArgumentNullException(nameof(getSchemas));
        applyNaming = applyNaming ?? throw new ArgumentNullException(nameof(applyNaming));
        toClassName = toClassName ?? throw new ArgumentNullException(nameof(toClassName));
        toPropertyName = toPropertyName ?? throw new ArgumentNullException(nameof(toPropertyName));

        var ((text, settings), globalSettings) = tuple;

        return SpecFormatDetector.DetectFormat(text) switch
        {
            SpecFormat.AsyncApi => PrepareAsyncApi(
                text,
                settings,
                globalSettings,
                getSchemas,
                applyNaming,
                toClassName,
                toPropertyName,
                cancellationToken),
            _ => PrepareOpenApi(
                text,
                settings,
                globalSettings,
                getSchemas,
                applyNaming,
                cancellationToken),
        };
    }

    private static CorePipelineResult PrepareOpenApi(
        string text,
        Settings settings,
        Settings globalSettings,
        Func<OpenApiDocument, Settings, IReadOnlyList<SchemaContext>> getSchemas,
        Action<IReadOnlyList<SchemaContext>> applyNaming,
        CancellationToken cancellationToken)
    {
        var totalTime = Stopwatch.StartNew();
#if NET
        var allocBefore = GC.GetTotalAllocatedBytes(precise: true);
#endif
        var parsingTime = Stopwatch.StartNew();

        var openApiDocument = text.GetOpenApiDocument(settings.ToCoreSettings(), cancellationToken);

        parsingTime.Stop();
#if NET
        var allocAfterParsing = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var traversalTreeTime = Stopwatch.StartNew();

        var schemas = getSchemas(openApiDocument, settings);

        traversalTreeTime.Stop();
#if NET
        var allocAfterTree = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var namingTime = Stopwatch.StartNew();

        applyNaming(schemas);

        namingTime.Stop();
#if NET
        var allocAfterNaming = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var resolveReferencesTime = Stopwatch.StartNew();

        ResolveReferences(schemas, settings.IgnoreOpenApiErrors);
        DetectCycles(schemas);

        var componentSchemas = schemas
            .Where(x => x.ComponentId is not null)
            .ToDictionary(x => x.ComponentId!, x => x, StringComparer.Ordinal);
        for (var i = 0; i < schemas.Count; i++)
        {
            schemas[i].ComponentSchemas = componentSchemas;
        }

        resolveReferencesTime.Stop();
#if NET
        var allocAfterResolve = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var filteringTime = Stopwatch.StartNew();

        var includedOperationIds = new HashSet<string>(settings.IncludeOperationIds);
        var excludedOperationIds = new HashSet<string>(settings.ExcludeOperationIds);
        foreach (var tag in settings.IncludeTags)
        {
            includedOperationIds.UnionWith(openApiDocument.FindAllOperationIdsForTag(tag));
        }

        foreach (var tag in settings.ExcludeTags)
        {
            excludedOperationIds.UnionWith(openApiDocument.FindAllOperationIdsForTag(tag));
        }

        var allTags = openApiDocument.Tags!;
        var knownTagNames = new HashSet<string>();
        foreach (var tag in allTags)
        {
            if (tag.Name != null)
            {
                knownTagNames.Add(tag.Name);
            }
        }

        var paths = openApiDocument.Paths ?? new OpenApiPaths();
        foreach (var pathEntry in paths)
        {
            var pathOps = pathEntry.Value.Operations;
            if (pathOps == null)
            {
                continue;
            }

            foreach (var opEntry in pathOps)
            {
                var operation = opEntry.Value;
                if (operation.Tags != null)
                {
                    foreach (var tag in operation.Tags)
                    {
                        if (tag.Name != null && knownTagNames.Add(tag.Name))
                        {
                            allTags.Add(new OpenApiTag
                            {
                                Name = tag.Name,
                                Description = tag.Description,
                            });
                        }
                    }
                }

                if (settings.UseExtensionNaming &&
                    OpenApiExtensions.TryGetExtensionStringValue(
                        operation.Extensions,
                        "x-fern-sdk-group-name",
                        out var groupName) &&
                    !string.IsNullOrWhiteSpace(groupName) &&
                    knownTagNames.Add(groupName))
                {
                    allTags.Add(new OpenApiTag { Name = groupName });
                }
            }
        }

        if (settings.GroupByTags && allTags.Count < 2)
        {
            settings = settings with
            {
                GroupByTags = false,
            };
        }

        var maxDepth = 20;
        for (var i = 0; i < schemas.Count; i++)
        {
            if (schemas[i].Depth > maxDepth)
            {
                maxDepth = schemas[i].Depth;
            }
        }

#if NET
        var allocBeforeTags = GC.GetTotalAllocatedBytes(precise: true);
#endif
        var tagsVisited = new HashSet<SchemaContext>();
        for (var i = 0; i < schemas.Count; i++)
        {
            if (schemas[i].Operation != null)
            {
                tagsVisited.Clear();
                schemas[i].ComputeTags(maxDepth: maxDepth, visited: tagsVisited);
            }
        }

        for (var i = 0; i < schemas.Count; i++)
        {
            tagsVisited.Clear();
            schemas[i].ComputeTags(maxDepth: maxDepth, visited: tagsVisited);
        }
#if NET
        var allocAfterTags = GC.GetTotalAllocatedBytes(precise: true);
#endif

        var includedModels = new HashSet<string>(settings.IncludeModels);
        var excludedModels = new HashSet<string>(settings.ExcludeModels);

        var hasTagFilters = settings.IncludeTags.Length > 0 || settings.ExcludeTags.Length > 0;
        var hasModelFilters = includedModels.Count > 0 || excludedModels.Count > 0;
        var allSchemasPass = (settings.GenerateModels || settings.GenerateSdk) &&
                             !hasTagFilters &&
                             !hasModelFilters;

        IReadOnlyList<SchemaContext> filteredSchemas;
        if (allSchemasPass)
        {
            filteredSchemas = schemas;
        }
        else
        {
            var includeTagsArr = settings.IncludeTags.ToArray();
            var excludeTagsArr = settings.ExcludeTags.ToArray();
            var collected = new HashSet<SchemaContext>();
            bool CanExpandReference(SchemaContext resolvedReference)
            {
                if (!(hasModelFilters && resolvedReference.IsComponent))
                {
                    return true;
                }

                if (includedModels.Count > 0 && !includedModels.Contains(resolvedReference.ComponentId!))
                {
                    return false;
                }

                return !excludedModels.Contains(resolvedReference.ComponentId!);
            }
            for (var i = 0; i < schemas.Count; i++)
            {
                var schema = schemas[i];
                if (!(settings.GenerateModels ||
                      settings.GenerateSdk ||
                      (schema.Operation?.OperationId != null &&
                       includedOperationIds.Contains(schema.Operation.OperationId))))
                {
                    continue;
                }

                if (includeTagsArr.Length > 0 && !schema.HasAnyTag(includeTagsArr))
                {
                    continue;
                }

                if (excludeTagsArr.Length > 0 && schema.HasAnyTag(excludeTagsArr))
                {
                    continue;
                }

                if (hasModelFilters && schema.IsComponent)
                {
                    if (includedModels.Count > 0 && !includedModels.Contains(schema.ComponentId!))
                    {
                        schema.IsFilteredOutModel = true;
                        continue;
                    }

                    if (excludedModels.Contains(schema.ComponentId!))
                    {
                        schema.IsFilteredOutModel = true;
                        continue;
                    }
                }

                schema.CollectWithAllChildren(
                    collected,
                    hasModelFilters ? CanExpandReference : null);
            }

            filteredSchemas = new List<SchemaContext>(collected);
        }

        var hasMetadataWrappers = false;
        for (var i = 0; i < filteredSchemas.Count; i++)
        {
            if (filteredSchemas[i].IsAllOfForMetadata)
            {
                hasMetadataWrappers = true;
                break;
            }
        }

        if (hasMetadataWrappers)
        {
            var filtered = new List<SchemaContext>(filteredSchemas.Count);
            for (var i = 0; i < filteredSchemas.Count; i++)
            {
                if (!filteredSchemas[i].IsAllOfForMetadata)
                {
                    filtered.Add(filteredSchemas[i]);
                }
            }

            filteredSchemas = filtered;
        }

        var includedTags = allTags
            .Where(x =>
                x.Name != null &&
                (settings.IncludeTags.Length == 0 || settings.IncludeTags.Contains(x.Name)) &&
                !settings.ExcludeTags.Contains(x.Name))
            .ToImmutableArray();

        filteringTime.Stop();
#if NET
        var allocAfterFilter = GC.GetTotalAllocatedBytes(precise: true);
#endif

        return new CorePipelineResult(
            Format: SpecFormat.OpenApi,
            Settings: settings,
            GlobalSettings: globalSettings,
            SchemaSettings: settings,
            OpenApiDocument: openApiDocument,
            AsyncApiDocument: null,
            Schemas: schemas,
            FilteredSchemas: filteredSchemas,
            AllTags: allTags.ToImmutableArray(),
            IncludedTags: includedTags,
            IncludedOperationIds: includedOperationIds.ToImmutableArray(),
            ExcludedOperationIds: excludedOperationIds.ToImmutableArray(),
            ComponentSchemas: componentSchemas,
            SyntheticEventSchemaNames: new Dictionary<string, string>(StringComparer.Ordinal),
            SkipModels: false,
            Times: new Times(
                Parsing: parsingTime.Elapsed,
                TraversalTree: traversalTreeTime.Elapsed,
                Naming: namingTime.Elapsed,
                ResolveReferences: resolveReferencesTime.Elapsed,
                Filtering: filteringTime.Elapsed,
                ComputeData: TimeSpan.Zero,
                ComputeDataClasses: TimeSpan.Zero,
                Total: totalTime.Elapsed
#if NET
                ,
                AllocParsing: allocAfterParsing - allocBefore,
                AllocTraversalTree: allocAfterTree - allocAfterParsing,
                AllocNaming: allocAfterNaming - allocAfterTree,
                AllocResolveReferences: allocAfterResolve - allocAfterNaming,
                AllocFiltering: allocAfterFilter - allocAfterResolve,
                AllocComputeData: 0,
                AllocComputeDataClasses: 0,
                AllocFilterTags: allocAfterTags - allocBeforeTags
#endif
            ));
    }

    private static CorePipelineResult PrepareAsyncApi(
        string text,
        Settings settings,
        Settings globalSettings,
        Func<OpenApiDocument, Settings, IReadOnlyList<SchemaContext>> getSchemas,
        Action<IReadOnlyList<SchemaContext>> applyNaming,
        Func<string, string> toClassName,
        Func<string, string> toPropertyName,
        CancellationToken cancellationToken)
    {
        var totalTime = Stopwatch.StartNew();
        var parsingTime = Stopwatch.StartNew();

        var asyncApiDoc = text.GetAsyncApiDocument(settings.ToCoreSettings(), cancellationToken);

        ExtractInlinePayloadSchemas(asyncApiDoc, toClassName);
        ExtractInlineBindingEnumSchemas(asyncApiDoc, toClassName, toPropertyName);
        var syntheticEventSchemaNames = InjectSyntheticServerEventSchemas(asyncApiDoc, toClassName);

        var openApiDocument = asyncApiDoc.BridgeSchemasToOpenApi(settings.ToCoreSettings(), cancellationToken);

        parsingTime.Stop();

        var traversalTreeTime = Stopwatch.StartNew();

        var typesNamespace = !string.IsNullOrEmpty(settings.TypesNamespace)
            ? settings.TypesNamespace
            : settings.Namespace;
        var schemaSettings = settings with { Namespace = typesNamespace };
        var skipModels = !string.IsNullOrEmpty(settings.TypesNamespace) && !settings.GenerateModels;
        var schemas = getSchemas(openApiDocument, schemaSettings);

        traversalTreeTime.Stop();

        var namingTime = Stopwatch.StartNew();

        applyNaming(schemas);

        namingTime.Stop();

        var resolveReferencesTime = Stopwatch.StartNew();

        ResolveReferences(schemas, settings.IgnoreOpenApiErrors);

        var componentSchemas = schemas
            .Where(x => x.ComponentId is not null)
            .ToDictionary(x => x.ComponentId!, x => x, StringComparer.Ordinal);

        resolveReferencesTime.Stop();

        var filteringTime = Stopwatch.StartNew();

        var filteredSchemas = schemas
            .Where(x => !x.IsAllOfForMetadata)
            .ToArray();

        filteringTime.Stop();

        return new CorePipelineResult(
            Format: SpecFormat.AsyncApi,
            Settings: settings,
            GlobalSettings: globalSettings,
            SchemaSettings: schemaSettings,
            OpenApiDocument: openApiDocument,
            AsyncApiDocument: asyncApiDoc,
            Schemas: schemas,
            FilteredSchemas: filteredSchemas,
            AllTags: [],
            IncludedTags: [],
            IncludedOperationIds: [],
            ExcludedOperationIds: [],
            ComponentSchemas: componentSchemas,
            SyntheticEventSchemaNames: syntheticEventSchemaNames,
            SkipModels: skipModels,
            Times: new Times(
                Parsing: parsingTime.Elapsed,
                TraversalTree: traversalTreeTime.Elapsed,
                Naming: namingTime.Elapsed,
                ResolveReferences: resolveReferencesTime.Elapsed,
                Filtering: filteringTime.Elapsed,
                ComputeData: TimeSpan.Zero,
                ComputeDataClasses: TimeSpan.Zero,
                Total: totalTime.Elapsed));
    }

    private static void ResolveReferences(
        IReadOnlyList<SchemaContext> schemas,
        bool ignoreOpenApiErrors)
    {
        var componentSchemas = new Dictionary<string, SchemaContext>(StringComparer.Ordinal);
        for (var i = 0; i < schemas.Count; i++)
        {
            if (schemas[i].ComponentId is string componentId)
            {
                componentSchemas[componentId] = schemas[i];
            }
        }

        var unresolvedReferences = new HashSet<SchemaContext>();
        for (var i = 0; i < schemas.Count; i++)
        {
            if (!schemas[i].IsReference)
            {
                continue;
            }

            var referenceSchema = schemas[i];
            if (componentSchemas.TryGetValue(referenceSchema.ReferenceId!, out var resolvedReference))
            {
                referenceSchema.ResolvedReference = resolvedReference;
                referenceSchema.Id = resolvedReference.Id;
                referenceSchema.TypeData = resolvedReference.TypeData;
                resolvedReference.Links.Add(referenceSchema);
            }
            else if (!ignoreOpenApiErrors)
            {
                throw new KeyNotFoundException(
                    $"Schema reference '{referenceSchema.ReferenceId}' could not be resolved.");
            }
            else
            {
                unresolvedReferences.Add(referenceSchema);
            }
        }

        if (unresolvedReferences.Count > 0)
        {
            DetachUnresolvedReferences(schemas, unresolvedReferences);
            if (schemas is List<SchemaContext> list)
            {
                list.RemoveAll(unresolvedReferences.Contains);
            }
        }
    }

    private static void DetachUnresolvedReferences(
        IReadOnlyCollection<SchemaContext> schemas,
        HashSet<SchemaContext> unresolvedReferences)
    {
        foreach (var schema in schemas)
        {
            if (schema.Children.Count == 0)
            {
                continue;
            }

            schema.Children = [..schema.Children.Where(x => !unresolvedReferences.Contains(x))];
        }
    }

    private static void DetectCycles(IReadOnlyCollection<SchemaContext> schemas)
    {
        var color = new Dictionary<SchemaContext, byte>(schemas.Count);
        var cycleNodes = new HashSet<SchemaContext>();

        foreach (var schema in schemas)
        {
            if (!color.ContainsKey(schema))
            {
                DetectCyclesDfs(schema, color, cycleNodes, []);
            }
        }

        foreach (var node in cycleNodes)
        {
            node.IsInCycle = true;
        }
    }

    private static void DetectCyclesDfs(
        SchemaContext node,
        Dictionary<SchemaContext, byte> color,
        HashSet<SchemaContext> cycleNodes,
        List<SchemaContext> stack)
    {
        color[node] = 1;
        stack.Add(node);

        foreach (var neighbor in GetNeighbors(node))
        {
            if (!color.TryGetValue(neighbor, out var currentColor))
            {
                DetectCyclesDfs(neighbor, color, cycleNodes, stack);
            }
            else if (currentColor == 1)
            {
                var idx = stack.LastIndexOf(neighbor);
                if (idx >= 0)
                {
                    for (var i = idx; i < stack.Count; i++)
                    {
                        cycleNodes.Add(stack[i]);
                    }
                }
            }
        }

        stack.RemoveAt(stack.Count - 1);
        color[node] = 2;

        static IEnumerable<SchemaContext> GetNeighbors(SchemaContext context)
        {
            if (context.ResolvedReference != null)
            {
                yield return context.ResolvedReference;
            }

            foreach (var child in context.Children)
            {
                yield return child;
            }
        }
    }

    private static Dictionary<string, string> InjectSyntheticServerEventSchemas(
        AsyncApiDocument asyncApiDoc,
        Func<string, string> toClassName)
    {
        var result = new Dictionary<string, string>(StringComparer.Ordinal);
        var isMultiChannel = asyncApiDoc.Channels.Count > 1;
        var channelReceiveSchemas =
            new Dictionary<string, List<(string SchemaName, string DiscriminatorValue)>>(StringComparer.Ordinal);

        foreach (var kvp in asyncApiDoc.Operations)
        {
            var operation = kvp.Value;
            if (operation.IsSend)
            {
                continue;
            }

            var channelName = operation.ChannelName ?? string.Empty;
            if (!channelReceiveSchemas.TryGetValue(channelName, out var schemas))
            {
                schemas = [];
                channelReceiveSchemas[channelName] = schemas;
            }

            var seenSchemas = new HashSet<string>(schemas.Select(static s => s.SchemaName), StringComparer.Ordinal);
            foreach (var msgRef in operation.Messages)
            {
                var schemaName = ResolvePayloadSchemaName(msgRef.Ref, asyncApiDoc);
                if (string.IsNullOrEmpty(schemaName) || !seenSchemas.Add(schemaName))
                {
                    continue;
                }

                schemas.Add((schemaName, GetDiscriminatorValue(asyncApiDoc, schemaName)));
            }
        }

        foreach (var channelKvp in channelReceiveSchemas)
        {
            var channelName = channelKvp.Key;
            var receiveSchemas = channelKvp.Value;
            if (receiveSchemas.Count <= 1)
            {
                continue;
            }

            var discriminatorProperty = FindDiscriminatorProperty(asyncApiDoc, receiveSchemas);
            var oneOfArray = new JsonArray();
            var mapping = new JsonObject();

            foreach (var entry in receiveSchemas)
            {
                oneOfArray.Add(new JsonObject
                {
                    ["$ref"] = $"#/components/schemas/{entry.SchemaName}",
                });

                if (!string.IsNullOrEmpty(entry.DiscriminatorValue))
                {
                    mapping[entry.DiscriminatorValue] = $"#/components/schemas/{entry.SchemaName}";
                }
            }

            var syntheticSchema = new JsonObject
            {
                ["oneOf"] = oneOfArray,
            };

            if (mapping.Count > 0)
            {
                syntheticSchema["discriminator"] = new JsonObject
                {
                    ["propertyName"] = discriminatorProperty,
                    ["mapping"] = mapping,
                };
            }

            var syntheticName = isMultiChannel
                ? toClassName(channelName) + "ServerEvent"
                : "ServerEvent";

            asyncApiDoc.Components.Schemas[syntheticName] = syntheticSchema;
            result[channelName] = syntheticName;
        }

        return result;
    }

    private static string ResolvePayloadSchemaName(string messageRef, AsyncApiDocument doc)
    {
        AsyncApiMessage? message = null;
        if (!string.IsNullOrEmpty(messageRef))
        {
            var parts = messageRef.TrimStart('#', '/').Split('/');
            if (parts.Length >= 4 &&
                parts[0] == "channels" &&
                parts[2] == "messages" &&
                doc.Channels.TryGetValue(parts[1], out var channel))
            {
                channel.Messages.TryGetValue(parts[3], out message);
            }
            else if (parts.Length >= 3 &&
                     parts[0] == "components" &&
                     parts[1] == "messages")
            {
                doc.Components.Messages.TryGetValue(parts[2], out message);
            }
        }

        if (message?.Payload == null)
        {
            return string.Empty;
        }

        if (message.Payload["$ref"]?.GetValue<string>() is not { Length: > 0 } payloadRef)
        {
            return string.Empty;
        }

        var lastSlash = payloadRef.LastIndexOf('/');
        return lastSlash >= 0 ? payloadRef.Substring(lastSlash + 1) : payloadRef;
    }

    private static string GetDiscriminatorValue(AsyncApiDocument doc, string schemaName)
    {
        if (doc.Components.Schemas.TryGetValue(schemaName, out var schema) &&
            schema is JsonObject schemaObj &&
            schemaObj["properties"] is JsonObject props)
        {
            foreach (var kvp in props)
            {
                if (kvp.Value is not JsonObject propObj)
                {
                    continue;
                }

                if (propObj["enum"] is JsonArray enumValues && enumValues.Count == 1)
                {
                    return enumValues[0]?.GetValue<string>() ?? string.Empty;
                }

                if (propObj["const"] is JsonNode constNode)
                {
                    return constNode.GetValue<string>();
                }
            }
        }

        return string.Empty;
    }

    private static string FindDiscriminatorProperty(
        AsyncApiDocument doc,
        List<(string SchemaName, string DiscriminatorValue)> receiveSchemas)
    {
        var propertyCounts = new Dictionary<string, int>(StringComparer.Ordinal);

        foreach (var (schemaName, _) in receiveSchemas)
        {
            if (!doc.Components.Schemas.TryGetValue(schemaName, out var schema) ||
                schema is not JsonObject schemaObj ||
                schemaObj["properties"] is not JsonObject props)
            {
                continue;
            }

            foreach (var kvp in props)
            {
                if (kvp.Value is not JsonObject propObj)
                {
                    continue;
                }

                var hasSingleEnum = propObj["enum"] is JsonArray enumArray && enumArray.Count == 1;
                var hasConst = propObj["const"] is not null;
                if (!hasSingleEnum && !hasConst)
                {
                    continue;
                }

                propertyCounts.TryGetValue(kvp.Key, out var count);
                propertyCounts[kvp.Key] = count + 1;
            }
        }

        foreach (var kvp in propertyCounts)
        {
            if (kvp.Value == receiveSchemas.Count)
            {
                return kvp.Key;
            }
        }

        return "message_type";
    }

    private static void ExtractInlineBindingEnumSchemas(
        AsyncApiDocument asyncApiDoc,
        Func<string, string> toClassName,
        Func<string, string> toPropertyName)
    {
        foreach (var channelKvp in asyncApiDoc.Channels)
        {
            var channelName = channelKvp.Key;
            var channel = channelKvp.Value;
            if (channel.BindingsQueryProperties.Count == 0)
            {
                continue;
            }

            foreach (var propName in channel.BindingsQueryProperties.Keys.OrderBy(x => x, StringComparer.Ordinal).ToList())
            {
                var propNode = channel.BindingsQueryProperties[propName];
                if (propNode == null || propNode["$ref"] != null)
                {
                    continue;
                }

                var propType = propNode["type"]?.GetValue<string>();
                var isInlineEnum = propNode["enum"] is JsonArray { Count: > 0 };
                var isInlineObject = propType == "object" && propNode["properties"] != null;
                var isInlineArray = propType == "array" &&
                                    propNode["items"] is JsonObject itemsNode &&
                                    itemsNode["$ref"] == null &&
                                    (itemsNode["enum"] is JsonArray { Count: > 0 } ||
                                     (itemsNode["type"]?.GetValue<string>() == "object" &&
                                      itemsNode["properties"] != null));

                if (!isInlineEnum && !isInlineObject && !isInlineArray)
                {
                    continue;
                }

                var schemaName = channelName + toPropertyName(propName);
                if (asyncApiDoc.Components.Schemas.ContainsKey(schemaName))
                {
                    continue;
                }

                if (isInlineArray)
                {
                    var items = (JsonObject)propNode["items"]!;
                    var itemsSchemaName = channelName + toPropertyName(propName) + "Item";
                    if (!asyncApiDoc.Components.Schemas.ContainsKey(itemsSchemaName))
                    {
                        if (items["type"]?.GetValue<string>() == "object" && items["properties"] != null)
                        {
                            ExtractNestedInlineObjects(asyncApiDoc, items, itemsSchemaName, toClassName);
                        }

                        asyncApiDoc.Components.Schemas[itemsSchemaName] = items.DeepClone();
                    }

                    var updatedArray = propNode.DeepClone();
                    updatedArray!["items"] = new JsonObject
                    {
                        ["$ref"] = $"#/components/schemas/{itemsSchemaName}",
                    };
                    channel.BindingsQueryProperties[propName] = updatedArray;
                    continue;
                }

                if (isInlineObject)
                {
                    ExtractNestedInlineObjects(asyncApiDoc, propNode, schemaName, toClassName);
                }

                asyncApiDoc.Components.Schemas[schemaName] = propNode.DeepClone();
                channel.BindingsQueryProperties[propName] = new JsonObject
                {
                    ["$ref"] = $"#/components/schemas/{schemaName}",
                };
            }
        }
    }

    private static void ExtractInlinePayloadSchemas(
        AsyncApiDocument asyncApiDoc,
        Func<string, string> toClassName)
    {
        foreach (var kvp in asyncApiDoc.Components.Messages.ToList())
        {
            var messageName = kvp.Key;
            var message = kvp.Value;
            if (message.Payload == null || message.Payload["$ref"] != null)
            {
                continue;
            }

            var payloadType = message.Payload["type"]?.GetValue<string>();
            var payloadFormat = message.Payload["format"]?.GetValue<string>();
            if (payloadType == "string" && payloadFormat == "binary")
            {
                continue;
            }

            if (payloadType != "object" || asyncApiDoc.Components.Schemas.ContainsKey(messageName))
            {
                continue;
            }

            ExtractNestedInlineObjects(asyncApiDoc, message.Payload, messageName, toClassName);
            asyncApiDoc.Components.Schemas[messageName] = message.Payload.DeepClone();
            message.Payload = new JsonObject
            {
                ["$ref"] = $"#/components/schemas/{messageName}",
            };
        }

        foreach (var channel in asyncApiDoc.Channels.Values)
        {
            foreach (var chMsgKvp in channel.Messages)
            {
                var chMsg = chMsgKvp.Value;
                if (string.IsNullOrEmpty(chMsg.Ref))
                {
                    continue;
                }

                var refParts = chMsg.Ref.TrimStart('#', '/').Split('/');
                if (refParts.Length >= 3 &&
                    refParts[0] == "components" &&
                    refParts[1] == "messages" &&
                    asyncApiDoc.Components.Messages.TryGetValue(refParts[2], out var compMsg))
                {
                    chMsg.Payload = compMsg.Payload?.DeepClone();
                }
            }
        }
    }

    private static void ExtractNestedInlineObjects(
        AsyncApiDocument doc,
        JsonNode payload,
        string parentName,
        Func<string, string> toClassName)
    {
        if (payload is not JsonObject payloadObj ||
            payloadObj["properties"] is not JsonObject props)
        {
            return;
        }

        foreach (var propKvp in props.ToList())
        {
            var propName = propKvp.Key;
            var propValue = propKvp.Value;
            if (propValue is not JsonObject propObj)
            {
                continue;
            }

            var propType = propObj["type"]?.GetValue<string>();
            if (propType == "object" && propObj["$ref"] == null && propObj["properties"] != null)
            {
                var nestedName = parentName + toClassName(propName);
                ExtractNestedInlineObjects(doc, propObj, nestedName, toClassName);

                if (!doc.Components.Schemas.ContainsKey(nestedName))
                {
                    doc.Components.Schemas[nestedName] = propObj.DeepClone();
                }

                props[propName] = new JsonObject
                {
                    ["$ref"] = $"#/components/schemas/{nestedName}",
                };
            }
            else if (propType == "array" && propObj["items"] is JsonObject itemsObj)
            {
                var itemsType = itemsObj["type"]?.GetValue<string>();
                if (itemsType != "object" || itemsObj["$ref"] != null || itemsObj["properties"] == null)
                {
                    continue;
                }

                var nestedName = parentName + toClassName(propName);
                ExtractNestedInlineObjects(doc, itemsObj, nestedName, toClassName);
                if (!doc.Components.Schemas.ContainsKey(nestedName))
                {
                    doc.Components.Schemas[nestedName] = itemsObj.DeepClone();
                }

                propObj["items"] = new JsonObject
                {
                    ["$ref"] = $"#/components/schemas/{nestedName}",
                };
            }
        }
    }
}
