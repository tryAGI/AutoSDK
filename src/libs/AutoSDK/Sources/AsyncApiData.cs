#pragma warning disable CA1308

using System.Collections.Immutable;
using System.Diagnostics;
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

        // Parse AsyncAPI document
        var asyncApiDoc = text.GetAsyncApiDocument(settings, cancellationToken);

        // Bridge schemas to OpenAPI for reuse of model generation
        var openApiDocument = asyncApiDoc.BridgeSchemasToOpenApi(settings, cancellationToken);

        // Use existing schema traversal on the bridged OpenAPI document
        var schemas = openApiDocument.GetSchemas(settings);

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
            .Where(x => !x.HasAllOfTypeForMetadata())
            .ToArray();

        filteringTime.Stop();

        var computeDataTime = Stopwatch.StartNew();

        foreach (var schema in filteredSchemas)
        {
            schema.ComputeData();
        }

        computeDataTime.Stop();

        var computeDataClassesTime = Stopwatch.StartNew();

        var classes = filteredSchemas
            .Where(x => x is { IsReference: false, IsAnyOfLikeStructure: false })
            .Select(x => x.ClassData)
            .Where(x => x is not null)
            .Select(x => x!.Value)
            .ToImmutableArray();
        var enums = filteredSchemas
            .Where(x => x is { IsReference: false, IsAnyOfLikeStructure: false })
            .Select(x => x.EnumData)
            .Where(x => x is not null)
            .Select(x => x!.Value)
            .ToImmutableArray();
        var anyOfDatas = filteredSchemas
            .Where(x => x is { IsReference: false, IsAnyOfLikeStructure: true })
            .Select(x => x.AnyOfData)
            .Where(x => x is not null)
            .Select(x => x!.Value)
            .Distinct()
            .ToImmutableArray();

        // Build WebSocket endpoints from AsyncAPI operations
        var (webSocketClients, webSocketOperations) = BuildWebSocketData(
            asyncApiDoc, settings, globalSettings, componentSchemas);

        // Build authorization from AsyncAPI security schemes
        var authorizations = BuildAuthorizations(asyncApiDoc, settings, globalSettings);

        // Build converters list
        var converters = BuildConverters(enums, anyOfDatas, filteredSchemas, settings, globalSettings);

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

        var types = settings.GenerateJsonSerializerContextTypes
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
        Dictionary<string, SchemaContext> componentSchemas)
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
        if (receiveOps.Count == 1)
        {
            baseReceiveEventType = receiveOps[0].MessageType;
        }
        else if (receiveOps.Count > 1)
        {
            // When there are multiple receive message types, we need a common base type.
            // For now, use the first one. In practice, AsyncAPI specs often define a
            // discriminated union (oneOf/anyOf) for server events.
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
            .Concat(new[]
            {
                $"global::{globalSettings.Namespace}.JsonConverters.UnixTimestampJsonConverter",
            })
            .ToImmutableArray();
    }
}
