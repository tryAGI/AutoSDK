using System.Text.Json;
using System.Text.Json.Nodes;
using AutoSDK.Models;
using AutoSDK.Models.AsyncApi;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using Microsoft.OpenApi.YamlReader;

namespace AutoSDK.Extensions;

/// <summary>
/// Parses AsyncAPI specifications into <see cref="AsyncApiDocument"/> and bridges
/// schemas to OpenAPI for reuse of existing model generation.
/// </summary>
public static class AsyncApiExtensions
{
    /// <summary>
    /// Parses an AsyncAPI specification (YAML or JSON) into an <see cref="AsyncApiDocument"/>.
    /// </summary>
    public static AsyncApiDocument GetAsyncApiDocument(
        this string yamlOrJson,
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        return yamlOrJson.GetAsyncApiDocument(settings.ToCoreSettings(), cancellationToken);
    }

    public static AsyncApiDocument GetAsyncApiDocument(
        this string yamlOrJson,
        CoreSettings settings,
        CancellationToken cancellationToken = default)
    {
        return yamlOrJson.GetAsyncApiDocument(cancellationToken);
    }

    public static AsyncApiDocument GetAsyncApiDocument(
        this string yamlOrJson,
        CancellationToken cancellationToken = default)
    {
        yamlOrJson = yamlOrJson ?? throw new ArgumentNullException(nameof(yamlOrJson));

        // Parse to JsonNode - handle both YAML and JSON
        var rootNode = ParseToJsonNode(yamlOrJson);
        if (rootNode is not JsonObject root)
        {
            throw new InvalidOperationException("AsyncAPI document must be a JSON object.");
        }

        var document = new AsyncApiDocument
        {
            Version = root["asyncapi"]?.GetValue<string>() ?? string.Empty,
        };

        // Parse info
        if (root["info"] is JsonObject info)
        {
            document.Info = new AsyncApiInfo
            {
                Title = info["title"]?.GetValue<string>() ?? string.Empty,
                Version = info["version"]?.GetValue<string>() ?? string.Empty,
                Description = info["description"]?.GetValue<string>() ?? string.Empty,
            };
        }

        // Parse servers
        if (root["servers"] is JsonObject servers)
        {
            foreach (var kvp in servers)
            {
                var name = kvp.Key;
                var node = kvp.Value;
                if (node is not JsonObject serverObj)
                {
                    continue;
                }

                document.Servers[name] = ParseServer(serverObj);
            }
        }

        // Parse channels
        if (root["channels"] is JsonObject channels)
        {
            foreach (var kvp in channels)
            {
                var name = kvp.Key;
                var node = kvp.Value;
                if (node is not JsonObject channelObj)
                {
                    continue;
                }

                document.Channels[name] = ParseChannel(channelObj, root);
            }
        }

        // Parse operations
        if (root["operations"] is JsonObject operations)
        {
            foreach (var kvp in operations)
            {
                var name = kvp.Key;
                var node = kvp.Value;
                if (node is not JsonObject opObj)
                {
                    continue;
                }

                document.Operations[name] = ParseOperation(opObj);
            }
        }

        // Parse components
        if (root["components"] is JsonObject components)
        {
            document.Components = ParseComponents(components);
        }

        return document;
    }

    /// <summary>
    /// Bridges AsyncAPI schemas to an OpenAPI document for reuse of existing model generation.
    /// Wraps <c>components.schemas</c> in a synthetic OpenAPI 3.1 document.
    /// </summary>
    public static OpenApiDocument BridgeSchemasToOpenApi(
        this AsyncApiDocument asyncApiDocument,
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        return asyncApiDocument.BridgeSchemasToOpenApi(settings.ToCoreSettings(), cancellationToken);
    }

    public static OpenApiDocument BridgeSchemasToOpenApi(
        this AsyncApiDocument asyncApiDocument,
        CoreSettings settings,
        CancellationToken cancellationToken = default)
    {
        return asyncApiDocument.BridgeSchemasToOpenApi(cancellationToken);
    }

    public static OpenApiDocument BridgeSchemasToOpenApi(
        this AsyncApiDocument asyncApiDocument,
        CancellationToken cancellationToken = default)
    {
        asyncApiDocument = asyncApiDocument ?? throw new ArgumentNullException(nameof(asyncApiDocument));

        // Build a synthetic OpenAPI document containing only the schemas
        var syntheticOpenApi = new JsonObject
        {
            ["openapi"] = "3.1.0",
            ["info"] = new JsonObject
            {
                ["title"] = asyncApiDocument.Info.Title,
                ["version"] = asyncApiDocument.Info.Version,
            },
            ["paths"] = new JsonObject(),
            ["components"] = new JsonObject
            {
                ["schemas"] = CloneSchemas(asyncApiDocument.Components.Schemas),
            },
        };

        var yaml = syntheticOpenApi.ToJsonString(new JsonSerializerOptions
        {
            WriteIndented = true,
        });

        var readerSettings = new OpenApiReaderSettings
        {
            RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
        };
        readerSettings.AddYamlReader();

        var (openApiDocument, _) = OpenApiDocument.Parse(yaml, settings: readerSettings);

        return openApiDocument ?? throw new InvalidOperationException(
            "Failed to create synthetic OpenAPI document from AsyncAPI schemas.");
    }

    private static JsonNode ParseToJsonNode(string yamlOrJson)
    {
        yamlOrJson = yamlOrJson.TrimStart();

        // Try JSON first
        if (yamlOrJson.StartsWith("{", StringComparison.Ordinal) ||
            yamlOrJson.StartsWith("[", StringComparison.Ordinal))
        {
            return JsonNode.Parse(yamlOrJson)
                   ?? throw new InvalidOperationException("Failed to parse JSON.");
        }

        return YamlJsonConverter.Parse(yamlOrJson);
    }

    private static AsyncApiServer ParseServer(JsonObject serverObj)
    {
        var server = new AsyncApiServer
        {
            Host = serverObj["host"]?.GetValue<string>() ?? string.Empty,
            Pathname = serverObj["pathname"]?.GetValue<string>() ?? string.Empty,
            Protocol = serverObj["protocol"]?.GetValue<string>() ?? string.Empty,
            Description = serverObj["description"]?.GetValue<string>() ?? string.Empty,
        };

        if (serverObj["variables"] is JsonObject variables)
        {
            foreach (var kvp in variables)
            {
                if (kvp.Value is not JsonObject variableObj)
                {
                    continue;
                }

                var variable = new AsyncApiServerVariable
                {
                    Description = variableObj["description"]?.GetValue<string>() ?? string.Empty,
                    Default = GetJsonNodeString(variableObj["default"]),
                };

                if (variableObj["enum"] is JsonArray enumValues)
                {
                    foreach (var enumValue in enumValues)
                    {
                        var value = GetJsonNodeString(enumValue);
                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            variable.Enum.Add(value);
                        }
                    }
                }

                if (variableObj["examples"] is JsonArray exampleValues)
                {
                    foreach (var exampleValue in exampleValues)
                    {
                        var value = GetJsonNodeString(exampleValue);
                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            variable.Examples.Add(value);
                        }
                    }
                }

                server.Variables[kvp.Key] = variable;
            }
        }

        return server;
    }

    private static string GetJsonNodeString(JsonNode? node)
    {
        return node is JsonValue value
            ? value.ToString()
            : string.Empty;
    }

    private static AsyncApiChannel ParseChannel(JsonObject channelObj, JsonObject root)
    {
        var channel = new AsyncApiChannel
        {
            Address = channelObj["address"]?.GetValue<string>() ?? string.Empty,
            Description = channelObj["description"]?.GetValue<string>() ?? string.Empty,
        };

        if (channelObj["messages"] is JsonObject messages)
        {
            foreach (var kvp in messages)
            {
                var name = kvp.Key;
                var node = kvp.Value;
                if (node is JsonObject msgObj)
                {
                    channel.Messages[name] = ParseMessage(msgObj, root);
                }
            }
        }

        if (channelObj["parameters"] is JsonObject parameters)
        {
            foreach (var kvp in parameters)
            {
                var name = kvp.Key;
                var node = kvp.Value;
                if (node is JsonObject paramObj)
                {
                    channel.Parameters[name] = new AsyncApiParameter
                    {
                        Description = paramObj["description"]?.GetValue<string>() ?? string.Empty,
                        Default = paramObj["default"]?.GetValue<string>() ?? string.Empty,
                    };
                }
            }
        }

        // Parse server references (e.g., servers: [{ "$ref": "#/servers/production" }])
        if (channelObj["servers"] is JsonArray serversArray)
        {
            foreach (var serverNode in serversArray)
            {
                if (serverNode is JsonObject serverRefObj)
                {
                    var refStr = serverRefObj["$ref"]?.GetValue<string>() ?? string.Empty;
                    if (refStr.StartsWith("#/servers/", StringComparison.Ordinal))
                    {
                        channel.ServerRefs.Add(refStr.Substring("#/servers/".Length));
                    }
                }
            }
        }

        // Parse channel bindings (ws.query for WebSocket query parameters)
        if (channelObj["bindings"] is JsonObject bindings &&
            bindings["ws"] is JsonObject wsBinding &&
            wsBinding["query"] is JsonObject queryBinding)
        {
            if (queryBinding["properties"] is JsonObject queryProps)
            {
                foreach (var kvp in queryProps)
                {
                    channel.BindingsQueryProperties[kvp.Key] = kvp.Value?.DeepClone();
                }
            }
            if (queryBinding["required"] is JsonArray requiredArray)
            {
                foreach (var item in requiredArray)
                {
                    if (item?.GetValue<string>() is { Length: > 0 } name)
                    {
                        channel.BindingsQueryRequired.Add(name);
                    }
                }
            }
        }

        return channel;
    }

    private static AsyncApiMessage ParseMessage(JsonObject msgObj, JsonObject root)
    {
        // Handle $ref
        if (msgObj["$ref"]?.GetValue<string>() is { Length: > 0 } refValue)
        {
            var resolved = ResolveRef(root, refValue);
            if (resolved is JsonObject resolvedObj)
            {
                var msg = ParseMessage(resolvedObj, root);
                msg.Ref = refValue;
                return msg;
            }

            return new AsyncApiMessage { Ref = refValue };
        }

        return new AsyncApiMessage
        {
            Name = msgObj["name"]?.GetValue<string>() ?? string.Empty,
            Summary = msgObj["summary"]?.GetValue<string>() ?? string.Empty,
            Description = msgObj["description"]?.GetValue<string>() ?? string.Empty,
            ContentType = msgObj["contentType"]?.GetValue<string>() ?? "application/json",
            Payload = msgObj["payload"]?.DeepClone(),
        };
    }

    private static AsyncApiOperation ParseOperation(JsonObject opObj)
    {
        var op = new AsyncApiOperation
        {
            Action = opObj["action"]?.GetValue<string>() ?? string.Empty,
            Summary = opObj["summary"]?.GetValue<string>() ?? string.Empty,
            Description = opObj["description"]?.GetValue<string>() ?? string.Empty,
        };

        // Parse channel ref
        if (opObj["channel"] is JsonObject channelRef)
        {
            var channelRefStr = channelRef["$ref"]?.GetValue<string>() ?? string.Empty;
            op.ChannelRef = channelRefStr;
            // Extract channel name from "#/channels/realtime" → "realtime"
            if (channelRefStr.StartsWith("#/channels/", StringComparison.Ordinal))
            {
                op.ChannelName = channelRefStr.Substring("#/channels/".Length);
            }
        }

        // Parse messages
        if (opObj["messages"] is JsonArray messagesArray)
        {
            foreach (var msgNode in messagesArray)
            {
                if (msgNode is JsonObject msgObj)
                {
                    var refStr = msgObj["$ref"]?.GetValue<string>() ?? string.Empty;
                    op.Messages.Add(new AsyncApiOperationMessage { Ref = refStr });
                }
            }
        }

        // Parse trait references
        if (opObj["traits"] is JsonArray traitsArray)
        {
            foreach (var traitNode in traitsArray)
            {
                if (traitNode is JsonObject traitObj)
                {
                    var refStr = traitObj["$ref"]?.GetValue<string>() ?? string.Empty;
                    if (!string.IsNullOrEmpty(refStr))
                    {
                        op.TraitRefs.Add(refStr);
                    }
                }
            }
        }

        return op;
    }

    private static AsyncApiComponents ParseComponents(JsonObject componentsObj)
    {
        var components = new AsyncApiComponents();

        if (componentsObj["schemas"] is JsonObject schemas)
        {
            foreach (var kvp in schemas)
            {
                var name = kvp.Key;
                var node = kvp.Value;
                if (node != null)
                {
                    components.Schemas[name] = node.DeepClone();
                }
            }
        }

        if (componentsObj["messages"] is JsonObject messages)
        {
            foreach (var kvp in messages)
            {
                var name = kvp.Key;
                var node = kvp.Value;
                if (node is JsonObject msgObj)
                {
                    components.Messages[name] = new AsyncApiMessage
                    {
                        Name = msgObj["name"]?.GetValue<string>() ?? name,
                        Summary = msgObj["summary"]?.GetValue<string>() ?? string.Empty,
                        Description = msgObj["description"]?.GetValue<string>() ?? string.Empty,
                        ContentType = msgObj["contentType"]?.GetValue<string>() ?? "application/json",
                        Payload = msgObj["payload"]?.DeepClone(),
                    };
                }
            }
        }

        if (componentsObj["securitySchemes"] is JsonObject securitySchemes)
        {
            foreach (var kvp in securitySchemes)
            {
                var name = kvp.Key;
                var node = kvp.Value;
                if (node is JsonObject schemeObj)
                {
                    var subProtocols = new List<string>();
                    if (string.Equals(schemeObj["in"]?.GetValue<string>(), "subprotocol", StringComparison.OrdinalIgnoreCase) &&
                        !string.IsNullOrWhiteSpace(schemeObj["name"]?.GetValue<string>()))
                    {
                        subProtocols.Add(schemeObj["name"]!.GetValue<string>());
                    }

                    AddSubProtocols(subProtocols, schemeObj["x-subprotocol-auth"]);
                    if (schemeObj["bindings"] is JsonObject bindings &&
                        bindings["ws"] is JsonObject wsBinding)
                    {
                        AddSubProtocols(subProtocols, wsBinding["subprotocols"]);
                        AddSubProtocols(subProtocols, wsBinding["x-subprotocol-auth"]);
                    }

                    components.SecuritySchemes[name] = new AsyncApiSecurityScheme
                    {
                        Type = schemeObj["type"]?.GetValue<string>() ?? string.Empty,
                        Scheme = schemeObj["scheme"]?.GetValue<string>() ?? string.Empty,
                        Name = schemeObj["name"]?.GetValue<string>() ?? string.Empty,
                        In = schemeObj["in"]?.GetValue<string>() ?? string.Empty,
                        Description = schemeObj["description"]?.GetValue<string>() ?? string.Empty,
                        SubProtocols =
                        [
                            .. subProtocols
                                .Where(static x => !string.IsNullOrWhiteSpace(x))
                                .Distinct(StringComparer.Ordinal),
                        ],
                    };
                }
            }
        }

        if (componentsObj["operationTraits"] is JsonObject operationTraits)
        {
            foreach (var kvp in operationTraits)
            {
                var name = kvp.Key;
                var node = kvp.Value;
                if (node is JsonObject traitObj)
                {
                    var trait = new AsyncApiOperationTrait
                    {
                        Description = traitObj["description"]?.GetValue<string>() ?? string.Empty,
                    };

                    if (traitObj["security"] is JsonArray secArray)
                    {
                        foreach (var secNode in secArray)
                        {
                            if (secNode is JsonObject secObj)
                            {
                                var secEntry = new Dictionary<string, List<string>>();
                                foreach (var secKvp in secObj)
                                {
                                    var scopes = new List<string>();
                                    if (secKvp.Value is JsonArray scopeArray)
                                    {
                                        foreach (var scope in scopeArray)
                                        {
                                            scopes.Add(scope?.GetValue<string>() ?? string.Empty);
                                        }
                                    }
                                    secEntry[secKvp.Key] = scopes;
                                }
                                trait.Security.Add(secEntry);
                            }
                        }
                    }

                    components.OperationTraits[name] = trait;
                }
            }
        }

        return components;
    }

    private static void AddSubProtocols(
        List<string> target,
        JsonNode? node)
    {
        if (node is null)
        {
            return;
        }

        if (node is JsonValue value &&
            value.TryGetValue<string>(out var stringValue) &&
            !string.IsNullOrWhiteSpace(stringValue))
        {
            target.Add(stringValue);
            return;
        }

        if (node is not JsonArray array)
        {
            return;
        }

        foreach (var item in array)
        {
            if (item is JsonValue itemValue &&
                itemValue.TryGetValue<string>(out var subProtocol) &&
                !string.IsNullOrWhiteSpace(subProtocol))
            {
                target.Add(subProtocol);
            }
        }
    }

    private static JsonNode? ResolveRef(JsonObject root, string refPath)
    {
        if (!refPath.StartsWith("#/", StringComparison.Ordinal))
        {
            return null;
        }

        var parts = refPath.Substring(2).Split('/');
        JsonNode? current = root;

        foreach (var part in parts)
        {
            if (current is JsonObject obj)
            {
                current = obj[part];
            }
            else
            {
                return null;
            }
        }

        return current;
    }

    private static JsonObject CloneSchemas(Dictionary<string, JsonNode> schemas)
    {
        var result = new JsonObject();
        foreach (var kvp in schemas)
        {
            result[kvp.Key] = kvp.Value.DeepClone();
        }
        return result;
    }
}
