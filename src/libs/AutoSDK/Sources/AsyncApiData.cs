#pragma warning disable CA1308

using System.Collections.Immutable;
using System.Diagnostics;
using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Models.AsyncApi;
using AutoSDK.Naming.Models;
using AutoSDK.Serialization.Json;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

/// <summary>
/// Prepares <see cref="Models.Data"/> from an AsyncAPI specification.
/// Parallel to <see cref="Data"/> but for WebSocket/event-driven APIs.
/// </summary>
public static class AsyncApiData
{
    public static Models.Data Prepare(
        ((string Text, Settings Settings) Context, Settings GlobalSettings) tuple,
        CancellationToken cancellationToken = default)
    {
        var totalTime = Stopwatch.StartNew();
        var traversalTreeTime = Stopwatch.StartNew();

        var ((text, settings), globalSettings) = tuple;

        // When TypesNamespace is set, use it for schema/type resolution so that
        // generated type references point to the external namespace (e.g., global::MyApi.TypeName)
        // while the WebSocket client class itself remains in the main Namespace.
        var typesNamespace = !string.IsNullOrEmpty(settings.TypesNamespace)
            ? settings.TypesNamespace
            : settings.Namespace;
        var typesSettings = settings with { Namespace = typesNamespace };
        var skipModels = !string.IsNullOrEmpty(settings.TypesNamespace) && !settings.GenerateModels;

        // Parse AsyncAPI document
        var asyncApiDoc = text.GetAsyncApiDocument(settings, cancellationToken);

        // If multiple receive message types exist, inject a synthetic oneOf wrapper schema
        // for discriminated union deserialization (before bridging to OpenAPI)
        var syntheticEventSchemaName = InjectSyntheticServerEventSchema(asyncApiDoc);

        // Bridge schemas to OpenAPI for reuse of model generation
        var openApiDocument = asyncApiDoc.BridgeSchemasToOpenApi(settings, cancellationToken);

        // Use existing schema traversal on the bridged OpenAPI document.
        // Pass typesSettings so that all schema contexts (and their TypeData) use the types namespace.
        var schemas = openApiDocument.GetSchemas(typesSettings);

        traversalTreeTime.Stop();

        var namingTime = Stopwatch.StartNew();

        foreach (var schema in schemas.Where(x => x.IsModel))
        {
            _ = ModelNameGenerator.ComputeId(schema);
        }

        ModelNameGenerator.ResolveCollisions(schemas);

        namingTime.Stop();

        var resolveReferencesTime = Stopwatch.StartNew();

        var componentSchemas = schemas
            .Where(x => x.IsComponent)
            .ToDictionary(x => x.ComponentId!, x => x);

        var unresolvedReferences = new HashSet<SchemaContext>();
        foreach (var context in schemas.Where(x => x.IsReference).ToArray())
        {
            if (componentSchemas.TryGetValue(context.ReferenceId!, out var resolvedReference))
            {
                context.ResolvedReference = resolvedReference;
                context.Id = context.ResolvedReference.Id;
                context.TypeData = context.ResolvedReference.TypeData;
                context.ResolvedReference.Links.Add(context);
            }
            else if (!settings.IgnoreOpenApiErrors)
            {
                throw new KeyNotFoundException(
                    $"Schema reference '{context.ReferenceId}' could not be resolved.");
            }
            else
            {
                unresolvedReferences.Add(context);
            }
        }

        if (unresolvedReferences.Count > 0)
        {
            schemas = schemas.Where(x => !unresolvedReferences.Contains(x)).ToArray();
        }

        resolveReferencesTime.Stop();

        var filteringTime = Stopwatch.StartNew();

        // For AsyncAPI, include all schemas (no tag-based filtering)
        var filteredSchemas = schemas
            .Where(x => !x.IsAllOfForMetadata)
            .ToArray();

        filteringTime.Stop();

        var computeDataTime = Stopwatch.StartNew();

        var sharedVisited = new HashSet<SchemaContext>();
        foreach (var schema in filteredSchemas)
        {
            sharedVisited.Clear();
            schema.ComputeData(visited: sharedVisited);
        }

        computeDataTime.Stop();

        var computeDataClassesTime = Stopwatch.StartNew();

        // When skipModels is true (TypesNamespace set + GenerateModels false),
        // return empty model collections since models live in the external namespace.
        var classes = skipModels
            ? ImmutableArray<ModelData>.Empty
            : filteredSchemas
                .Where(x => x is { IsReference: false, IsAnyOfLikeStructure: false })
                .Select(x => x.ClassData)
                .Where(x => x is not null)
                .Select(x => x!.Value)
                .ToImmutableArray();
        var enums = skipModels
            ? ImmutableArray<ModelData>.Empty
            : filteredSchemas
                .Where(x => x is { IsReference: false, IsAnyOfLikeStructure: false })
                .Select(x => x.EnumData)
                .Where(x => x is not null)
                .Select(x => x!.Value)
                .ToImmutableArray();
        var anyOfDatas = skipModels
            ? ImmutableArray<AnyOfData>.Empty
            : filteredSchemas
                .Where(x => x is { IsReference: false, IsAnyOfLikeStructure: true })
                .Select(x => x.AnyOfData)
                .Where(x => x is not null)
                .Select(x => x!.Value)
                .Distinct()
                .ToImmutableArray();

        // Build WebSocket endpoints from AsyncAPI operations
        var (webSocketClients, webSocketOperations) = BuildWebSocketData(
            asyncApiDoc, settings, globalSettings, componentSchemas, syntheticEventSchemaName);

        // Build authorization from AsyncAPI security schemes
        var authorizations = BuildAuthorizations(asyncApiDoc, settings, globalSettings);

        // Build converters list (use typesSettings for namespace references)
        var converters = skipModels
            ? ImmutableArray<string>.Empty
            : BuildConverters(enums, anyOfDatas, filteredSchemas, typesSettings, globalSettings);

        // Build the "client" entry for JSON converter references
        var converterClient = new Client(
            Id: "Converters",
            ClassName: string.Empty,
            BaseUrl: string.Empty,
            Summary: string.Empty,
            Clients: [],
            BaseUrlSummary: string.Empty,
            Settings: settings,
            GlobalSettings: globalSettings,
            Converters: converters);

        var types = skipModels
            ? ImmutableArray<TypeData>.Empty
            : settings.GenerateJsonSerializerContextTypes
                ? filteredSchemas
                    .Where(x =>
                        x.TypeData != TypeData.Default &&
                        !string.IsNullOrWhiteSpace(x.TypeData.CSharpType))
                    .Select(x => x.TypeData)
                    .GroupBy(x => x.CSharpTypeWithNullability)
                    .Select(x => x.First())
                    .ToImmutableArray()
                : ImmutableArray<TypeData>.Empty;

        classes = classes
            .Select(x => x with { SchemaContext = default! })
            .ToImmutableArray();
        enums = enums
            .Select(x => x with { SchemaContext = default! })
            .ToImmutableArray();

        return new Models.Data(
            Classes: classes,
            Enums: enums,
            Methods: ImmutableArray<EndPoint>.Empty, // No HTTP methods for AsyncAPI
            Clients: ImmutableArray<Client>.Empty, // No HTTP clients for AsyncAPI
            AnyOfs: anyOfDatas,
            Types: types,
            Authorizations: ImmutableArray<Authorization>.Empty, // Auth handled via WebSocketClient.Authorizations
            Tags: ImmutableArray<Tag>.Empty,
            Converters: converterClient,
            Schemas: schemas,
            FilteredSchemas: filteredSchemas,
            Times: new Times(
                Parsing: TimeSpan.Zero,
                TraversalTree: traversalTreeTime.Elapsed,
                Naming: namingTime.Elapsed,
                ResolveReferences: resolveReferencesTime.Elapsed,
                Filtering: filteringTime.Elapsed,
                ComputeData: computeDataTime.Elapsed,
                ComputeDataClasses: computeDataClassesTime.Elapsed,
                Total: totalTime.Elapsed),
            WebSocketClients: webSocketClients.ToImmutableArray(),
            WebSocketOperations: webSocketOperations.ToImmutableArray());
    }

    private static (List<WebSocketClient>, List<WebSocketEndPoint>) BuildWebSocketData(
        AsyncApiDocument asyncApiDoc,
        Settings settings,
        Settings globalSettings,
        Dictionary<string, SchemaContext> componentSchemas,
        string? syntheticEventSchemaName)
    {
        var wsClients = new List<WebSocketClient>();
        var wsOperations = new List<WebSocketEndPoint>();

        // Determine WebSocket client class name
        var className = !string.IsNullOrWhiteSpace(settings.WebSocketClientClassName)
            ? settings.WebSocketClientClassName
            : !string.IsNullOrWhiteSpace(asyncApiDoc.Info.Title)
                ? asyncApiDoc.Info.Title.ToClassName() + "RealtimeClient"
                : settings.ClassName.Replace(".", string.Empty) + "RealtimeClient";

        // Get base URL from first server
        var baseUrl = asyncApiDoc.Servers.Values.FirstOrDefault()?.GetUrl() ?? string.Empty;
        var protocol = asyncApiDoc.Servers.Values.FirstOrDefault()?.Protocol ?? "wss";

        var sendOps = new List<WebSocketEndPoint>();
        var receiveOps = new List<WebSocketEndPoint>();

        foreach (var kvp in asyncApiDoc.Operations)
        {
            var operation = kvp.Value;
            var direction = operation.IsSend ? WebSocketDirection.Send : WebSocketDirection.Receive;
            var channelAddress = string.Empty;

            // Resolve channel address
            if (!string.IsNullOrEmpty(operation.ChannelName) &&
                asyncApiDoc.Channels.TryGetValue(operation.ChannelName, out var channel))
            {
                channelAddress = channel.Address;
            }

            // Process each message in the operation
            foreach (var msgRef in operation.Messages)
            {
                var messageName = ExtractMessageName(msgRef.Ref);
                var messageType = ResolveMessageType(
                    msgRef.Ref, asyncApiDoc, componentSchemas, settings);

                var wsOp = new WebSocketEndPoint(
                    Id: messageName,
                    ClassName: className,
                    ChannelAddress: channelAddress,
                    Direction: direction,
                    MessageType: messageType,
                    MessageName: messageName,
                    Summary: operation.Summary,
                    Settings: settings,
                    GlobalSettings: globalSettings);

                wsOperations.Add(wsOp);

                if (direction == WebSocketDirection.Send)
                {
                    sendOps.Add(wsOp);
                }
                else
                {
                    receiveOps.Add(wsOp);
                }
            }
        }

        // Determine the base receive event type
        TypeData baseReceiveEventType = default;
        var isReceiveEventValueType = false;
        if (!string.IsNullOrEmpty(syntheticEventSchemaName) &&
            receiveOps.Count > 1 &&
            componentSchemas.TryGetValue(syntheticEventSchemaName, out var eventSchema))
        {
            // Use the synthetic oneOf wrapper type for discriminated union deserialization
            baseReceiveEventType = eventSchema.TypeData;
            isReceiveEventValueType = true; // anyOf/oneOf types are generated as structs
        }
        else if (receiveOps.Count == 1)
        {
            baseReceiveEventType = receiveOps[0].MessageType;
        }
        else if (receiveOps.Count > 1)
        {
            // Fallback: use the first receive type if synthetic schema wasn't created
            baseReceiveEventType = receiveOps[0].MessageType;
        }

        // Build authorizations from AsyncAPI security schemes
        var authorizations = BuildAuthorizations(asyncApiDoc, settings, globalSettings);

        var wsClient = new WebSocketClient(
            Id: "WebSocketClient",
            ClassName: className,
            BaseUrl: baseUrl,
            Protocol: protocol,
            SendOperations: sendOps.ToImmutableArray(),
            ReceiveOperations: receiveOps.ToImmutableArray(),
            Authorizations: authorizations.ToImmutableArray(),
            Summary: asyncApiDoc.Info.Description?.ClearForXml() ?? string.Empty,
            Settings: settings,
            GlobalSettings: globalSettings,
            Converters: ImmutableArray<string>.Empty)
        {
            BaseReceiveEventType = baseReceiveEventType,
            IsReceiveEventValueType = isReceiveEventValueType,
        };

        wsClients.Add(wsClient);

        return (wsClients, wsOperations);
    }

    private static string ExtractMessageName(string refPath)
    {
        // Extract name from refs like "#/channels/realtime/messages/input_audio_chunk"
        // or "#/components/messages/InputAudioChunk"
        if (string.IsNullOrEmpty(refPath))
        {
            return string.Empty;
        }

        var lastSlash = refPath.LastIndexOf('/');
        return lastSlash >= 0 ? refPath.Substring(lastSlash + 1) : refPath;
    }

    private static TypeData ResolveMessageType(
        string messageRef,
        AsyncApiDocument asyncApiDoc,
        Dictionary<string, SchemaContext> componentSchemas,
        Settings settings)
    {
        // Try to resolve the message's payload schema to a TypeData
        AsyncApiMessage? message = null;

        // Try to find the message by reference path
        if (!string.IsNullOrEmpty(messageRef))
        {
            var parts = messageRef.TrimStart('#', '/').Split('/');
            if (parts.Length >= 2)
            {
                // Handle "#/channels/{channelName}/messages/{messageName}"
                if (parts[0] == "channels" && parts.Length >= 4 &&
                    parts[2] == "messages" &&
                    asyncApiDoc.Channels.TryGetValue(parts[1], out var channel))
                {
                    channel.Messages.TryGetValue(parts[3], out message);
                }
                // Handle "#/components/messages/{messageName}"
                else if (parts[0] == "components" && parts[1] == "messages" &&
                         parts.Length >= 3)
                {
                    asyncApiDoc.Components.Messages.TryGetValue(parts[2], out message);
                }
            }
        }

        if (message?.Payload == null)
        {
            return TypeData.Default;
        }

        // Check if the payload is a $ref to a component schema
        var payloadRef = message.Payload["$ref"]?.GetValue<string>();
        if (!string.IsNullOrEmpty(payloadRef))
        {
            // Extract schema name from "#/components/schemas/SchemaName"
            var schemaName = payloadRef.Split('/').LastOrDefault() ?? string.Empty;
            if (componentSchemas.TryGetValue(schemaName, out var schema))
            {
                return schema.TypeData;
            }
        }

        // If payload has a direct schema name, try to resolve
        var payloadType = message.Payload["type"]?.GetValue<string>();
        if (payloadType == "object")
        {
            // For inline objects, the schema should have been bridged already
            var messageName = ExtractMessageName(messageRef);
            if (componentSchemas.TryGetValue(messageName, out var inlineSchema))
            {
                return inlineSchema.TypeData;
            }
        }

        return TypeData.Default;
    }

    private static Authorization[] BuildAuthorizations(
        AsyncApiDocument asyncApiDoc,
        Settings settings,
        Settings globalSettings)
    {
        var authorizations = new List<Authorization>();

        foreach (var kvp in asyncApiDoc.Components.SecuritySchemes)
        {
            var secScheme = kvp.Value;
            var (friendlyName, parameters, paramLocation, securitySchemeType) =
                MapSecurityScheme(secScheme);

            authorizations.Add(new Authorization(
                FriendlyName: friendlyName,
                Type: securitySchemeType,
                In: paramLocation,
                Parameters: parameters.ToImmutableArray().AsEquatableArray(),
                Name: secScheme.Name,
                Scheme: secScheme.Scheme,
                Settings: settings,
                GlobalSettings: globalSettings,
                Flows: ImmutableArray<OAuthFlow>.Empty.AsEquatableArray(),
                OpenIdConnectUrl: string.Empty));
        }

        return authorizations.ToArray();
    }

    private static (string FriendlyName, string[] Parameters, ParameterLocation? Location,
        SecuritySchemeType? SchemeType) MapSecurityScheme(AsyncApiSecurityScheme scheme)
    {
        return (scheme.Type.ToLowerInvariant(), scheme.Scheme?.ToUpperInvariant(), scheme.In?.ToLowerInvariant()) switch
        {
            ("http", "BEARER", _) =>
                ("Bearer", new[] { "apiKey" }, ParameterLocation.Header, SecuritySchemeType.Http),
            ("http", "BASIC", _) =>
                ("Basic", new[] { "username", "password" }, ParameterLocation.Header, SecuritySchemeType.Http),
            ("httpApiKey" or "apikey", _, "header") =>
                ("ApiKeyInHeader", new[] { "apiKey" }, ParameterLocation.Header, SecuritySchemeType.ApiKey),
            ("httpApiKey" or "apikey", _, "query") =>
                ("ApiKeyInQuery", new[] { "apiKey" }, ParameterLocation.Query, SecuritySchemeType.ApiKey),
            _ =>
                ("Bearer", new[] { "apiKey" }, ParameterLocation.Header, SecuritySchemeType.Http),
        };
    }

    /// <summary>
    /// When multiple receive message types exist, injects a synthetic oneOf wrapper schema
    /// (named "ServerEvent") into the AsyncAPI components for discriminated union deserialization.
    /// Returns the synthetic schema name, or null if not needed.
    /// </summary>
    private static string? InjectSyntheticServerEventSchema(AsyncApiDocument asyncApiDoc)
    {
        // Collect all unique receive payload schema names with their discriminator values
        var receiveSchemas = new List<(string SchemaName, string DiscriminatorValue)>();
        var seenSchemas = new HashSet<string>(StringComparer.Ordinal);

        foreach (var kvp in asyncApiDoc.Operations)
        {
            var operation = kvp.Value;
            if (operation.IsSend)
            {
                continue;
            }

            foreach (var msgRef in operation.Messages)
            {
                var schemaName = ResolvePayloadSchemaName(msgRef.Ref, asyncApiDoc);
                if (string.IsNullOrEmpty(schemaName) || !seenSchemas.Add(schemaName))
                {
                    continue;
                }

                var discriminatorValue = GetDiscriminatorValue(asyncApiDoc, schemaName);
                receiveSchemas.Add((schemaName, discriminatorValue));
            }
        }

        // Only synthesize if there are multiple receive types
        if (receiveSchemas.Count <= 1)
        {
            return null;
        }

        // Find the common discriminator property name
        var discriminatorProperty = FindDiscriminatorProperty(asyncApiDoc, receiveSchemas);

        // Build the oneOf array and discriminator mapping
        var oneOfArray = new JsonArray();
        var mapping = new JsonObject();

        foreach (var (schemaName, discriminatorValue) in receiveSchemas)
        {
            oneOfArray.Add(new JsonObject
            {
                ["$ref"] = $"#/components/schemas/{schemaName}",
            });

            if (!string.IsNullOrEmpty(discriminatorValue))
            {
                mapping[discriminatorValue] = $"#/components/schemas/{schemaName}";
            }
        }

        var syntheticSchema = new JsonObject
        {
            ["oneOf"] = oneOfArray,
        };

        // Only add discriminator if we have mapping values
        if (mapping.Count > 0)
        {
            syntheticSchema["discriminator"] = new JsonObject
            {
                ["propertyName"] = discriminatorProperty,
                ["mapping"] = mapping,
            };
        }

        const string schemaName2 = "ServerEvent";
        asyncApiDoc.Components.Schemas[schemaName2] = syntheticSchema;

        return schemaName2;
    }

    /// <summary>
    /// Resolves a message reference to the payload schema name.
    /// </summary>
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

        var payloadRef = message.Payload["$ref"]?.GetValue<string>();
        if (!string.IsNullOrEmpty(payloadRef))
        {
            var lastSlash = payloadRef.LastIndexOf('/');
            return lastSlash >= 0 ? payloadRef.Substring(lastSlash + 1) : payloadRef;
        }

        return string.Empty;
    }

    /// <summary>
    /// Gets the discriminator enum value from a schema's discriminator property.
    /// For example, a "message_type" property with enum: ["session_started"] returns "session_started".
    /// </summary>
    private static string GetDiscriminatorValue(
        AsyncApiDocument doc, string schemaName)
    {
        if (doc.Components.Schemas.TryGetValue(schemaName, out var schema) &&
            schema is JsonObject schemaObj &&
            schemaObj["properties"] is JsonObject props)
        {
            // Look for any property with a single-value enum
            foreach (var kvp in props)
            {
                if (kvp.Value is JsonObject propObj &&
                    propObj["enum"] is JsonArray enumValues &&
                    enumValues.Count == 1)
                {
                    return enumValues[0]?.GetValue<string>() ?? string.Empty;
                }
            }
        }

        return string.Empty;
    }

    /// <summary>
    /// Finds the common discriminator property name across all receive schemas.
    /// Returns the property name that exists on all schemas with single-value enums.
    /// </summary>
    private static string FindDiscriminatorProperty(
        AsyncApiDocument doc,
        List<(string SchemaName, string DiscriminatorValue)> receiveSchemas)
    {
        var propertyCounts = new Dictionary<string, int>(StringComparer.Ordinal);

        foreach (var (schemaName, _) in receiveSchemas)
        {
            if (doc.Components.Schemas.TryGetValue(schemaName, out var schema) &&
                schema is JsonObject schemaObj &&
                schemaObj["properties"] is JsonObject props)
            {
                foreach (var kvp in props)
                {
                    if (kvp.Value is JsonObject propObj &&
                        propObj["enum"] is JsonArray enumArray &&
                        enumArray.Count == 1)
                    {
                        if (!propertyCounts.ContainsKey(kvp.Key))
                        {
                            propertyCounts[kvp.Key] = 0;
                        }

                        propertyCounts[kvp.Key]++;
                    }
                }
            }
        }

        // Return the property that exists on all schemas with single-value enum
        foreach (var kvp in propertyCounts)
        {
            if (kvp.Value == receiveSchemas.Count)
            {
                return kvp.Key;
            }
        }

        // Default fallback
        return "message_type";
    }

    private static ImmutableArray<string> BuildConverters(
        ImmutableArray<ModelData> enums,
        ImmutableArray<AnyOfData> anyOfDatas,
        IReadOnlyCollection<SchemaContext> filteredSchemas,
        Settings settings,
        Settings globalSettings)
    {
        return enums
            .Where(x =>
                x.Style == ModelStyle.Enumeration &&
                x.Settings.JsonSerializerType != JsonSerializerType.NewtonsoftJson)
            .SelectMany(x => new[]
            {
                $"global::{settings.Namespace}.JsonConverters.{x.ClassName}JsonConverter",
                $"global::{settings.Namespace}.JsonConverters.{x.ClassName}NullableJsonConverter"
            })
            .Concat(anyOfDatas
                .Where(x =>
                    x.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson &&
                    !string.IsNullOrWhiteSpace(x.Name))
                .Select(x => $"global::{settings.Namespace}.JsonConverters.{x.Name}JsonConverter"))
            .Concat(filteredSchemas
                .Where(x =>
                    x.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson &&
                    x.AnyOfData.HasValue &&
                    string.IsNullOrWhiteSpace(x.AnyOfData.Value.Name))
                .Select(x =>
                    $"global::{settings.Namespace}.JsonConverters.{x.AnyOfData?.SubType}JsonConverter<{string.Join(", ", x.Children
                        .Where(y => y.Hint == (x.IsAnyOf ? Hint.AnyOf : x.IsOneOf ? Hint.OneOf : Hint.AllOf))
                        .Select(y => y.TypeData.CSharpTypeWithNullabilityForValueTypes))}>"))
            .ToImmutableArray();
    }
}
