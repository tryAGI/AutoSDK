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

        // For YAML, use the OpenAPI YAML reader to convert to JSON
        // Parse YAML through a synthetic wrapper to get a JsonNode
        var readerSettings = new OpenApiReaderSettings
        {
            RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
        };
        readerSettings.AddYamlReader();

        // Wrap YAML content in a minimal OpenAPI document to leverage the reader,
        // then extract the raw content. Instead, let's use a simpler approach:
        // parse the YAML manually for the asyncapi-specific structure.

        // Use the YamlDotNet-based approach through Microsoft.OpenApi.YamlReader
        // Since the YAML reader is internal, we use a different approach:
        // Convert YAML to JSON using a lightweight parser
        return ParseYamlToJsonNode(yamlOrJson);
    }

    private static JsonNode ParseYamlToJsonNode(string yaml)
    {
        // Use Microsoft.OpenApi's YAML reader indirectly:
        // Parse the AsyncAPI YAML as if it were an OpenAPI document,
        // but since it won't parse correctly, we need a different approach.

        // Simple approach: Use System.Text.Json for JSON, and for YAML,
        // wrap in a synthetic OpenAPI document and extract.
        //
        // Better approach: Use the YamlDotNet library which Microsoft.OpenApi.YamlReader
        // depends on. Since it's already an indirect dependency, we can use it.

        // For now, use the simplest approach that works:
        // Convert YAML to JSON using basic line-by-line parsing for the structure
        // we need. This handles the common AsyncAPI YAML format.

        // Actually, the cleanest approach is to use SharpYaml or similar
        // that's already transitively available. Let's try System.Text.Json
        // round-trip through OpenAPI reader with a trick.

        // The most robust approach: Read the YAML using the OpenAPI infrastructure
        // We can parse it as a "fragment" - just the raw YAML - using the OpenApiDocument reader
        // but that won't work because AsyncAPI is not OpenAPI.

        // Let's use a pragmatic approach: Microsoft.OpenApi internally uses
        // a YAML parser. We can leverage it by creating a temporary file.
        //
        // Actually, the simplest and most maintainable approach:
        // require AsyncAPI specs to be in JSON format, or use the
        // built-in YAML deserialization from the OpenAPI reader as a
        // generic YAML-to-JSON converter.

        // Use Microsoft.OpenApi's internal YAML stream reader to convert to JSON node
        // Since Microsoft.OpenApi.YamlReader adds YAML support, we can use it through
        // the reader infrastructure.

        // For robustness, let's try parsing through a synthetic OpenAPI wrapper
        // where we embed the AsyncAPI content inside components.
        // This won't work because the structure is different.

        // Most pragmatic: Use the SharpYaml deserializer that's available
        // as a transitive dependency through Microsoft.OpenApi.YamlReader.
        try
        {
            // Try using SharpYaml via reflection (transitive dep of Microsoft.OpenApi.YamlReader)
            var sharpYamlAssembly = AppDomain.CurrentDomain.GetAssemblies()
                .FirstOrDefault(a => a.GetName().Name == "SharpYaml");

            if (sharpYamlAssembly != null)
            {
                var serializerType = sharpYamlAssembly.GetType("SharpYaml.Serialization.Serializer");
                if (serializerType != null)
                {
                    var serializer = Activator.CreateInstance(serializerType);
                    var deserializeMethod = serializerType.GetMethod("Deserialize", new[] { typeof(string) });
                    var result = deserializeMethod?.Invoke(serializer, new object[] { yaml });
                    if (result != null)
                    {
                        var json = JsonSerializer.Serialize(result);
                        return JsonNode.Parse(json) ??
                               throw new InvalidOperationException("Failed to parse YAML-converted JSON.");
                    }
                }
            }
        }
        catch
        {
            // Fall through to alternative approach
        }

        // Fallback: simple YAML-to-JSON converter for common patterns
        return SimpleYamlToJson(yaml);
    }

    /// <summary>
    /// Simple YAML to JSON converter for well-formed AsyncAPI documents.
    /// Handles indentation-based structure, strings, numbers, booleans, and arrays.
    /// </summary>
    private static JsonObject SimpleYamlToJson(string yaml)
    {
        var lines = yaml.Split('\n')
            .Select(l => l.TrimEnd('\r'))
            .Where(l => !string.IsNullOrWhiteSpace(l) && !l.TrimStart().StartsWith("#", StringComparison.Ordinal))
            .ToList();

        var root = new JsonObject();
        ParseYamlBlock(lines, 0, 0, root);
        return root;
    }

    private static int ParseYamlBlock(List<string> lines, int startIndex, int baseIndent, JsonObject target)
    {
        var i = startIndex;
        while (i < lines.Count)
        {
            var line = lines[i];
            var indent = GetIndent(line);

            if (indent < baseIndent)
            {
                break;
            }

            if (indent > baseIndent)
            {
                i++;
                continue;
            }

            var trimmed = line.TrimStart();

            // Skip array items at this level (handled by parent)
            if (trimmed.StartsWith("- ", StringComparison.Ordinal))
            {
                i++;
                continue;
            }

            var colonIndex = trimmed.IndexOf(':');
            if (colonIndex < 0)
            {
                i++;
                continue;
            }

            var key = trimmed.Substring(0, colonIndex).Trim().Trim('"', '\'');
            var value = colonIndex + 1 < trimmed.Length ? trimmed.Substring(colonIndex + 1).Trim() : string.Empty;

            if (string.IsNullOrEmpty(value))
            {
                // Check if next line is indented (sub-object or array)
                if (i + 1 < lines.Count)
                {
                    var nextLine = lines[i + 1];
                    var nextIndent = GetIndent(nextLine);

                    if (nextIndent > indent)
                    {
                        if (nextLine.TrimStart().StartsWith("- ", StringComparison.Ordinal))
                        {
                            // Array
                            var array = new JsonArray();
                            i = ParseYamlArray(lines, i + 1, nextIndent, array);
                            target[key] = array;
                        }
                        else
                        {
                            // Sub-object
                            var subObj = new JsonObject();
                            i = ParseYamlBlock(lines, i + 1, nextIndent, subObj);
                            target[key] = subObj;
                        }
                        continue;
                    }
                }
                target[key] = JsonValue.Create(string.Empty);
            }
            else if (value.StartsWith("[", StringComparison.Ordinal))
            {
                // Inline array
                try
                {
                    target[key] = JsonNode.Parse(value);
                }
                catch
                {
                    target[key] = JsonValue.Create(value);
                }
            }
            else if (value.StartsWith("{", StringComparison.Ordinal))
            {
                // Inline object
                try
                {
                    target[key] = JsonNode.Parse(value);
                }
                catch
                {
                    target[key] = JsonValue.Create(value);
                }
            }
            else
            {
                target[key] = ParseYamlScalar(value);
            }

            i++;
        }

        return i;
    }

    private static int ParseYamlArray(List<string> lines, int startIndex, int baseIndent, JsonArray target)
    {
        var i = startIndex;
        while (i < lines.Count)
        {
            var indent = GetIndent(lines[i]);
            if (indent < baseIndent)
            {
                break;
            }

            var trimmed = lines[i].TrimStart();
            if (!trimmed.StartsWith("- ", StringComparison.Ordinal))
            {
                break;
            }

            var itemValue = trimmed.Substring(2).Trim();

            if (string.IsNullOrEmpty(itemValue))
            {
                // Array item is an object
                if (i + 1 < lines.Count && GetIndent(lines[i + 1]) > indent)
                {
                    var subObj = new JsonObject();
                    i = ParseYamlBlock(lines, i + 1, GetIndent(lines[i + 1]), subObj);
                    target.Add(subObj);
                }
                else
                {
                    i++;
                }
            }
            else if (itemValue.Contains(':'))
            {
                // Array item starts an inline object
                var subObj = new JsonObject();
                var colonIdx = itemValue.IndexOf(':');
                var k = itemValue.Substring(0, colonIdx).Trim().Trim('"', '\'');
                var v = itemValue.Substring(colonIdx + 1).Trim();

                if (string.IsNullOrEmpty(v) && i + 1 < lines.Count && GetIndent(lines[i + 1]) > indent)
                {
                    var innerObj = new JsonObject();
                    i = ParseYamlBlock(lines, i + 1, GetIndent(lines[i + 1]), innerObj);
                    subObj[k] = innerObj;
                }
                else
                {
                    subObj[k] = ParseYamlScalar(v);
                    // Check for continuation
                    if (i + 1 < lines.Count && GetIndent(lines[i + 1]) > indent &&
                        !lines[i + 1].TrimStart().StartsWith("- ", StringComparison.Ordinal))
                    {
                        i = ParseYamlBlock(lines, i + 1, GetIndent(lines[i + 1]), subObj);
                    }
                    else
                    {
                        i++;
                    }
                }
                target.Add(subObj);
            }
            else
            {
                target.Add(ParseYamlScalar(itemValue));
                i++;
            }
        }

        return i;
    }

    private static JsonValue ParseYamlScalar(string value)
    {
        // Remove quotes
        if ((value.StartsWith("'", StringComparison.Ordinal) && value.EndsWith("'", StringComparison.Ordinal)) ||
            (value.StartsWith("\"", StringComparison.Ordinal) && value.EndsWith("\"", StringComparison.Ordinal)))
        {
            return JsonValue.Create(value.Substring(1, value.Length - 2));
        }

        // Boolean
        if (string.Equals(value, "true", StringComparison.OrdinalIgnoreCase))
        {
            return JsonValue.Create(true);
        }

        if (string.Equals(value, "false", StringComparison.OrdinalIgnoreCase))
        {
            return JsonValue.Create(false);
        }

        // Null
        if (string.Equals(value, "null", StringComparison.OrdinalIgnoreCase) ||
            value == "~")
        {
            return JsonValue.Create(string.Empty);
        }

        // Integer
        if (long.TryParse(value, out var longVal))
        {
            return JsonValue.Create(longVal);
        }

        // Float
        if (double.TryParse(value, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out var doubleVal))
        {
            return JsonValue.Create(doubleVal);
        }

        return JsonValue.Create(value);
    }

    private static int GetIndent(string line)
    {
        var count = 0;
        foreach (var c in line)
        {
            if (c == ' ')
            {
                count++;
            }
            else if (c == '\t')
            {
                count += 2;
            }
            else
            {
                break;
            }
        }
        return count;
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
