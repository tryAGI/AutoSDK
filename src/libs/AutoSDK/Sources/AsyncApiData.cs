#pragma warning disable CA1308

using System.Collections.Immutable;
using System.Diagnostics;
using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Models.AsyncApi;
using AutoSDK.Naming.Models;
using AutoSDK.Naming.Properties;
using AutoSDK.Serialization.Form;
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

        // Extract inline payload schemas from component messages into component schemas.
        // Must run BEFORE InjectSyntheticServerEventSchemas so that extracted schemas
        // participate in discriminated union generation.
        ExtractInlinePayloadSchemas(asyncApiDoc);

        // If multiple receive message types exist, inject synthetic oneOf wrapper schemas
        // for discriminated union deserialization (before bridging to OpenAPI)
        var syntheticEventSchemaNames = InjectSyntheticServerEventSchemas(asyncApiDoc);

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
            asyncApiDoc, settings, globalSettings, componentSchemas, syntheticEventSchemaNames);

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
        Dictionary<string, string> syntheticEventSchemaNames)
    {
        var wsClients = new List<WebSocketClient>();
        var wsOperations = new List<WebSocketEndPoint>();

        var isMultiChannel = asyncApiDoc.Channels.Count > 1;

        // Determine class name prefix
        var classNamePrefix = !string.IsNullOrWhiteSpace(settings.WebSocketClientClassName)
            ? settings.WebSocketClientClassName
            : !string.IsNullOrWhiteSpace(asyncApiDoc.Info.Title)
                ? asyncApiDoc.Info.Title.ToClassName() + "RealtimeClient"
                : settings.ClassName.Replace(".", string.Empty) + "RealtimeClient";

        // Get default server info (fallback when channels don't specify servers)
        var defaultServer = asyncApiDoc.Servers.Values.FirstOrDefault();
        var protocol = defaultServer?.Protocol ?? "wss";

        // Build authorizations (shared across all channels)
        var authorizations = BuildAuthorizations(asyncApiDoc, settings, globalSettings);

        foreach (var channelKvp in asyncApiDoc.Channels)
        {
            var channelName = channelKvp.Key;
            var channel = channelKvp.Value;

            // Filter operations that belong to this channel
            var channelOperations = asyncApiDoc.Operations
                .Where(kvp => kvp.Value.ChannelName == channelName)
                .ToList();

            if (channelOperations.Count == 0)
            {
                continue;
            }

            // Resolve per-channel server (falls back to first global server)
            var channelServer = defaultServer;
            if (channel.ServerRefs.Count > 0 &&
                asyncApiDoc.Servers.TryGetValue(channel.ServerRefs[0], out var resolvedServer))
            {
                channelServer = resolvedServer;
                protocol = channelServer.Protocol;
            }

            // Determine class name for this channel
            var className = isMultiChannel
                ? classNamePrefix.Replace("RealtimeClient", string.Empty) + channelName.ToClassName() + "RealtimeClient"
                : classNamePrefix;

            // Determine base URL for this channel
            var baseUrl = isMultiChannel
                ? (channelServer?.GetHostUrl() ?? string.Empty) + (string.IsNullOrEmpty(channel.Address) ? string.Empty : "/" + channel.Address.TrimStart('/'))
                : channelServer?.GetUrl() ?? string.Empty;

            var sendOps = new List<WebSocketEndPoint>();
            var receiveOps = new List<WebSocketEndPoint>();

            foreach (var kvp in channelOperations)
            {
                var operation = kvp.Value;
                var direction = operation.IsSend ? WebSocketDirection.Send : WebSocketDirection.Receive;

                // Process each message in the operation
                foreach (var msgRef in operation.Messages)
                {
                    var messageName = ExtractMessageName(msgRef.Ref);
                    var messageType = ResolveMessageType(
                        msgRef.Ref, asyncApiDoc, componentSchemas, settings);

                    var wsOp = new WebSocketEndPoint(
                        Id: messageName,
                        ClassName: className,
                        ChannelAddress: channel.Address,
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

            // Determine the base receive event type for this channel
            TypeData baseReceiveEventType = default;
            var isReceiveEventValueType = false;

            if (syntheticEventSchemaNames.TryGetValue(channelName, out var syntheticEventSchemaName) &&
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

            // Use channel description if available, else spec description
            var summary = !string.IsNullOrWhiteSpace(channel.Description)
                ? channel.Description.ClearForXml()
                : asyncApiDoc.Info.Description?.ClearForXml() ?? string.Empty;

            // Build query parameters from channel bindings (ws.query)
            var queryParams = BuildChannelQueryParameters(
                channel, componentSchemas, settings);

            var wsClient = new WebSocketClient(
                Id: isMultiChannel ? $"WebSocketClient_{channelName}" : "WebSocketClient",
                ClassName: className,
                BaseUrl: baseUrl,
                Protocol: protocol,
                SendOperations: sendOps.ToImmutableArray(),
                ReceiveOperations: receiveOps.ToImmutableArray(),
                Authorizations: authorizations.ToImmutableArray(),
                QueryParameters: queryParams,
                Summary: summary,
                Settings: settings,
                GlobalSettings: globalSettings,
                Converters: ImmutableArray<string>.Empty)
            {
                BaseReceiveEventType = baseReceiveEventType,
                IsReceiveEventValueType = isReceiveEventValueType,
            };

            wsClients.Add(wsClient);
        }

        return (wsClients, wsOperations);
    }

    private static ImmutableArray<MethodParameter> BuildChannelQueryParameters(
        AsyncApiChannel channel,
        Dictionary<string, SchemaContext> componentSchemas,
        Settings settings)
    {
        if (channel.BindingsQueryProperties.Count == 0)
        {
            return ImmutableArray<MethodParameter>.Empty;
        }

        var result = new List<MethodParameter>();

        foreach (var kvp in channel.BindingsQueryProperties)
        {
            var paramName = kvp.Key;
            var propNode = kvp.Value;

            // Resolve $ref to component schema
            var refPath = propNode?["$ref"]?.GetValue<string>();
            if (refPath == null) continue;

            var schemaName = refPath.Split('/').Last();
            if (!componentSchemas.TryGetValue(schemaName, out var schemaContext))
            {
                continue;
            }

            var type = schemaContext.TypeData;
            var isRequired = channel.BindingsQueryRequired.Contains(paramName);

            // Make type nullable if not required
            if (!isRequired && !type.CSharpTypeNullability)
            {
                type = type with { CSharpTypeNullability = true };
            }

            var name = paramName.ToPropertyName();
            name = MethodParameter.HandleWordSeparators(name);
            name = CSharpPropertyNameGenerator.SanitizeName(
                name, settings.ClsCompliantEnumPrefix, true);

            var methodParam = new MethodParameter(
                Id: paramName,
                Name: name,
                Value: string.Empty,
                Delimiter: string.Empty,
                Selector: string.Empty,
                Type: type,
                IsRequired: isRequired,
                IsMultiPartFormDataFilename: false,
                Location: ParameterLocation.Query,
                Style: ParameterStyle.Form,
                Explode: true,
                Settings: settings,
                DefaultValue: null,
                IsDeprecated: false,
                Summary: schemaContext.Schema.GetSummary(),
                Description: schemaContext.Schema.Description ?? string.Empty,
                ConverterType: type.ConverterType,
                Properties: schemaContext.ClassData?.Properties ?? []);

            // Use existing serializer to fill in Value expression
            var serialized = ParameterSerializer.SerializeQueryParameter(methodParam);
            result.AddRange(serialized);
        }

        // Sort: required params first, then optional
        result.Sort((a, b) =>
        {
            if (a.IsRequired != b.IsRequired)
            {
                return a.IsRequired ? -1 : 1;
            }
            return string.Compare(a.Id, b.Id, StringComparison.Ordinal);
        });

        return result.ToImmutableArray();
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
    /// When multiple receive message types exist, injects synthetic oneOf wrapper schemas
    /// into the AsyncAPI components for discriminated union deserialization.
    /// For single-channel specs, produces one "ServerEvent" schema (backward compat).
    /// For multi-channel specs, produces per-channel "{ChannelName}ServerEvent" schemas.
    /// Returns a dictionary of channel name → synthetic schema name.
    /// </summary>
    private static Dictionary<string, string> InjectSyntheticServerEventSchemas(AsyncApiDocument asyncApiDoc)
    {
        var result = new Dictionary<string, string>(StringComparer.Ordinal);
        var isMultiChannel = asyncApiDoc.Channels.Count > 1;

        // Group receive operations by channel
        var channelReceiveSchemas = new Dictionary<string, List<(string SchemaName, string DiscriminatorValue)>>(StringComparer.Ordinal);

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
                schemas = new List<(string SchemaName, string DiscriminatorValue)>();
                channelReceiveSchemas[channelName] = schemas;
            }

            var seenSchemas = new HashSet<string>(schemas.Select(s => s.SchemaName), StringComparer.Ordinal);

            foreach (var msgRef in operation.Messages)
            {
                var schemaName = ResolvePayloadSchemaName(msgRef.Ref, asyncApiDoc);
                if (string.IsNullOrEmpty(schemaName) || !seenSchemas.Add(schemaName))
                {
                    continue;
                }

                var discriminatorValue = GetDiscriminatorValue(asyncApiDoc, schemaName);
                schemas.Add((schemaName, discriminatorValue));
            }
        }

        // For each channel with >1 receive types, build a synthetic schema
        foreach (var channelKvp2 in channelReceiveSchemas)
        {
            var channelName = channelKvp2.Key;
            var receiveSchemas = channelKvp2.Value;

            if (receiveSchemas.Count <= 1)
            {
                continue;
            }

            // Find the common discriminator property name
            var discriminatorProperty = FindDiscriminatorProperty(asyncApiDoc, receiveSchemas);

            // Build the oneOf array and discriminator mapping
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

            // Only add discriminator if we have mapping values
            if (mapping.Count > 0)
            {
                syntheticSchema["discriminator"] = new JsonObject
                {
                    ["propertyName"] = discriminatorProperty,
                    ["mapping"] = mapping,
                };
            }

            // Single-channel: "ServerEvent" (backward compat); multi-channel: "{ChannelName}ServerEvent"
            var syntheticName = isMultiChannel
                ? channelName.ToClassName() + "ServerEvent"
                : "ServerEvent";

            asyncApiDoc.Components.Schemas[syntheticName] = syntheticSchema;
            result[channelName] = syntheticName;
        }

        return result;
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
    /// Also supports const: "session_started" (OpenAPI 3.1+ / AsyncAPI pattern).
    /// </summary>
    private static string GetDiscriminatorValue(
        AsyncApiDocument doc, string schemaName)
    {
        if (doc.Components.Schemas.TryGetValue(schemaName, out var schema) &&
            schema is JsonObject schemaObj &&
            schemaObj["properties"] is JsonObject props)
        {
            // Look for any property with a single-value enum or const
            foreach (var kvp in props)
            {
                if (kvp.Value is JsonObject propObj)
                {
                    if (propObj["enum"] is JsonArray enumValues &&
                        enumValues.Count == 1)
                    {
                        return enumValues[0]?.GetValue<string>() ?? string.Empty;
                    }

                    if (propObj["const"] is JsonNode constNode)
                    {
                        return constNode.GetValue<string>();
                    }
                }
            }
        }

        return string.Empty;
    }

    /// <summary>
    /// Finds the common discriminator property name across all receive schemas.
    /// Returns the property name that exists on all schemas with single-value enums or const values.
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
                    if (kvp.Value is JsonObject propObj)
                    {
                        bool hasSingleEnum = propObj["enum"] is JsonArray enumArray && enumArray.Count == 1;
                        bool hasConst = propObj["const"] is not null;

                        if (hasSingleEnum || hasConst)
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
        }

        // Return the property that exists on all schemas with single-value enum or const
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

    /// <summary>
    /// Extracts inline payload schemas from component messages into component schemas.
    /// This allows upstream AsyncAPI specs (which define payloads inline in messages)
    /// to work natively without manual curation.
    /// </summary>
    private static void ExtractInlinePayloadSchemas(AsyncApiDocument asyncApiDoc)
    {
        foreach (var kvp in asyncApiDoc.Components.Messages.ToList())
        {
            var messageName = kvp.Key;
            var message = kvp.Value;

            if (message.Payload == null)
            {
                continue;
            }

            // Skip payloads that are already $ref
            if (message.Payload["$ref"] != null)
            {
                continue;
            }

            // Skip binary payloads (type: string, format: binary)
            var payloadType = message.Payload["type"]?.GetValue<string>();
            var payloadFormat = message.Payload["format"]?.GetValue<string>();
            if (payloadType == "string" && payloadFormat == "binary")
            {
                continue;
            }

            // Skip non-object payloads
            if (payloadType != "object")
            {
                continue;
            }

            // Skip if a schema with this name already exists
            if (asyncApiDoc.Components.Schemas.ContainsKey(messageName))
            {
                continue;
            }

            // Extract nested inline objects from properties recursively
            ExtractNestedInlineObjects(asyncApiDoc, message.Payload, messageName);

            // Add the payload as a named schema
            asyncApiDoc.Components.Schemas[messageName] = message.Payload.DeepClone();

            // Replace the message payload with a $ref
            message.Payload = new JsonObject
            {
                ["$ref"] = $"#/components/schemas/{messageName}",
            };
        }

        // Sync channel message copies — channel messages parsed from $ref to component
        // messages are independent copies; update their Payload to match.
        foreach (var channel in asyncApiDoc.Channels.Values)
        {
            foreach (var chMsgKvp in channel.Messages)
            {
                var chMsg = chMsgKvp.Value;

                // Only sync messages that reference component messages
                if (string.IsNullOrEmpty(chMsg.Ref))
                {
                    continue;
                }

                // Extract the component message name from the ref
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

    /// <summary>
    /// Recursively extracts nested anonymous inline object schemas from properties.
    /// For example, a message "ListenV1ResultsEvent" with an inline object property "channel"
    /// will produce a new schema "ListenV1ResultsEventChannel".
    /// </summary>
    private static void ExtractNestedInlineObjects(
        AsyncApiDocument doc, JsonNode payload, string parentName)
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
                // This is an inline object — extract it
                var nestedName = parentName + propName.ToClassName();

                // Recurse first to handle deeply nested objects
                ExtractNestedInlineObjects(doc, propObj, nestedName);

                // Add to schemas if not already present
                if (!doc.Components.Schemas.ContainsKey(nestedName))
                {
                    doc.Components.Schemas[nestedName] = propObj.DeepClone();
                }

                // Replace inline definition with $ref
                props[propName] = new JsonObject
                {
                    ["$ref"] = $"#/components/schemas/{nestedName}",
                };
            }
            else if (propType == "array" && propObj["items"] is JsonObject itemsObj)
            {
                // Check if array items are inline objects
                var itemsType = itemsObj["type"]?.GetValue<string>();
                if (itemsType == "object" && itemsObj["$ref"] == null && itemsObj["properties"] != null)
                {
                    var nestedName = parentName + propName.ToClassName();

                    ExtractNestedInlineObjects(doc, itemsObj, nestedName);

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
