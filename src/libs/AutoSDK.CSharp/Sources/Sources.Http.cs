using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static readonly JsonSerializerOptions HttpJsonOptions = new()
    {
        WriteIndented = true,
    };

    public static string GenerateHttpFile(
        string tag,
        IReadOnlyList<OperationContext> operations)
    {
        operations = operations ?? throw new ArgumentNullException(nameof(operations));

        var sb = new StringBuilder();

        foreach (var operation in operations)
        {
            sb.Append(GenerateHttpRequest(operation));
        }

        return sb.ToString().TrimStart('\n', '\r');
    }

    public static string GenerateWebhookHttpFile(
        IReadOnlyList<OperationContext> operations)
    {
        operations = operations ?? throw new ArgumentNullException(nameof(operations));

        if (operations.Count == 0)
        {
            return string.Empty;
        }

        var sb = new StringBuilder();

        foreach (var operation in operations
                     .OrderBy(x => x.OperationPath, StringComparer.Ordinal)
                     .ThenBy(x => x.OperationType.Method, StringComparer.Ordinal))
        {
            AppendAsyncInteractionDocumentation(
                sb,
                label: "WEBHOOK",
                name: operation.OperationPath,
                target: null,
                method: operation.OperationType.Method.ToUpperInvariant(),
                operation: operation.Operation);
        }

        return sb.ToString().TrimStart('\n', '\r');
    }

    public static string GenerateHttpRequest(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var sb = new StringBuilder();
        var method = operation.OperationType.Method.ToUpperInvariant();
        var path = ConvertPathToHttpVariables(operation.OperationPath);
        var op = operation.Operation;

        // Title line
        var summary = !string.IsNullOrWhiteSpace(op.Summary)
            ? op.Summary
            : op.Description;
        var deprecated = op.IsDeprecated() ? "[DEPRECATED] " : "";
        var title = !string.IsNullOrWhiteSpace(summary)
            ? string.Concat(deprecated, summary)
            : string.Concat(deprecated, method, " ", operation.OperationPath);

        sb.Append("### ").AppendLine(title);

        // @name tag
        if (!string.IsNullOrWhiteSpace(op.OperationId))
        {
            sb.Append("# @name ").AppendLine(op.OperationId);
        }

        // Build query params
        var parameters = op.Parameters ?? [];
        var queryParams = parameters
            .Where(p => p.In == ParameterLocation.Query)
            .ToList();
        var queryString = queryParams.Count > 0
            ? "?" + string.Join("&", queryParams.Select(p =>
                string.Format(CultureInfo.InvariantCulture, "{0}={1}", p.Name, GetHttpParameterValue(p))))
            : "";

        // Also check for ApiKey-in-query auth params
        var securityRequirements = GetEffectiveSecurityRequirements(operation);
        var apiKeyQueryParams = GetApiKeyQueryParams(securityRequirements);
        if (apiKeyQueryParams.Count > 0)
        {
            var separator = queryParams.Count > 0 ? "&" : "?";
            queryString += separator + string.Join("&", apiKeyQueryParams);
        }

        sb.Append(method).Append(" {{host}}").Append(path).AppendLine(queryString);

        // Auth headers
        foreach (var authHeader in GetHttpAuthHeaders(securityRequirements))
        {
            sb.AppendLine(authHeader);
        }

        // Custom header parameters
        var headerParams = parameters
            .Where(p => p.In == ParameterLocation.Header)
            .ToList();
        foreach (var header in headerParams)
        {
            sb.Append(header.Name).Append(": ").AppendLine(GetHttpParameterValue(header));
        }

        // Request body handling
        if (GetPreferredRequestContent(op) is { } preferredContent)
        {
            sb.Append("Content-Type: ").AppendLine(preferredContent.ContentType);
        }

        // Accept header
        var acceptTypes = GetHttpAcceptTypes(op);
        if (!string.IsNullOrEmpty(acceptTypes))
        {
            sb.Append("Accept: ").AppendLine(acceptTypes);
        }

        // Blank line before body
        sb.AppendLine();

        // JSON body
        if (GetPreferredRequestContent(op) is { ContentType: "application/json", Schema: { } bodySchema })
        {
            var body = GenerateJsonBody(bodySchema);
            if (!string.IsNullOrWhiteSpace(body))
            {
                sb.AppendLine(body);
                sb.AppendLine();
            }
        }

        AppendLinkDocumentation(sb, op);
        AppendCallbackDocumentation(sb, op);

        return sb.ToString();
    }

    public static string GenerateHttpEnvironmentFile(
        IReadOnlyList<OpenApiServer> servers,
        IReadOnlyList<OpenApiSecuritySchemeReference> securitySchemes)
    {
        servers = servers ?? throw new ArgumentNullException(nameof(servers));
        securitySchemes = securitySchemes ?? throw new ArgumentNullException(nameof(securitySchemes));

        var envObj = new JsonObject();

        if (servers.Count == 0)
        {
            var devEnv = new JsonObject
            {
                ["host"] = "http://localhost",
            };
            AddAuthVariables(devEnv, securitySchemes);
            envObj["dev"] = devEnv;
        }
        else
        {
            for (var i = 0; i < servers.Count; i++)
            {
                var server = servers[i];
                var envName = !string.IsNullOrWhiteSpace(server.Description)
                    ? SanitizeEnvName(server.Description!)
                    : GetEnvNameFromIndex(i, servers.Count);

                var env = new JsonObject
                {
                    ["host"] = server.ExpandServerTemplate().TrimEnd('/') is { Length: > 0 } host
                        ? host
                        : "http://localhost",
                };
                AddAuthVariables(env, securitySchemes);
                envObj[envName] = env;
            }
        }

        return envObj.ToJsonString(HttpJsonOptions);
    }

    #region Http Helpers

    private static string ConvertPathToHttpVariables(string path)
    {
        // Replace {param} with {{param}} for .http file format
        return Regex.Replace(path, @"\{([^}]+)\}", "{{$1}}");
    }

    private static string GetHttpParameterValue(IOpenApiParameter parameter)
    {
        // Use example if available
        if (parameter.Example != null)
        {
            return parameter.Example.ToString();
        }

        // Use schema default if available
        if (parameter.Schema?.Default != null)
        {
            return parameter.Schema.Default.ToString();
        }

        // Use first enum value if available
        if (parameter.Schema?.Enum is { Count: > 0 })
        {
            return parameter.Schema.Enum[0].ToString();
        }

        // Fall back to variable placeholder
        return "{{" + parameter.Name + "}}";
    }

    private static (string ContentType, IOpenApiSchema? Schema)? GetPreferredRequestContent(OpenApiOperation operation)
    {
        var content = operation.RequestBody?.Content;
        if (content is not { Count: > 0 })
        {
            return null;
        }

        if (content.TryGetValue("application/json", out var jsonMedia))
        {
            return ("application/json", jsonMedia.Schema);
        }

        var first = content.First();
        return (first.Key, first.Value.Schema);
    }

    private static void AppendLinkDocumentation(StringBuilder sb, OpenApiOperation operation)
    {
        var responseLinks = (operation.Responses ?? [])
            .Where(static x => x.Value.Links is { Count: > 0 })
            .SelectMany(x => x.Value.Links!
                .OrderBy(link => link.Key, StringComparer.Ordinal)
                .Select(link => (StatusCode: x.Key, Name: link.Key, Link: link.Value)))
            .ToArray();
        if (responseLinks.Length == 0)
        {
            return;
        }

        sb.AppendLine("## Links");
        foreach (var responseLink in responseLinks)
        {
            sb.Append("# ")
                .Append(responseLink.StatusCode)
                .Append('.')
                .AppendLine(responseLink.Name);

            if (!string.IsNullOrWhiteSpace(responseLink.Link.Description))
            {
                sb.Append("# Description: ").AppendLine(responseLink.Link.Description);
            }

            if (!string.IsNullOrWhiteSpace(responseLink.Link.OperationId))
            {
                sb.Append("# OperationId: ").AppendLine(responseLink.Link.OperationId);
            }

            if (responseLink.Link.OperationRef != null)
            {
                sb.Append("# OperationRef: ").AppendLine(responseLink.Link.OperationRef.ToString());
            }

            if (responseLink.Link.Parameters != null)
            {
                foreach (var parameter in responseLink.Link.Parameters.OrderBy(x => x.Key, StringComparer.Ordinal))
                {
                    sb.Append("# Parameters.")
                        .Append(parameter.Key)
                        .Append(": ")
                        .AppendLine(FormatRuntimeExpression(parameter.Value));
                }
            }

            if (responseLink.Link.RequestBody != null)
            {
                sb.Append("# RequestBody: ").AppendLine(FormatRuntimeExpression(responseLink.Link.RequestBody));
            }

            if (!string.IsNullOrWhiteSpace(responseLink.Link.Server?.Url))
            {
                sb.Append("# Server: ").AppendLine(responseLink.Link.Server.Url);
            }
        }

        sb.AppendLine();
    }

    private static void AppendCallbackDocumentation(StringBuilder sb, OpenApiOperation operation)
    {
        var callbacks = operation.Callbacks;
        if (callbacks == null || callbacks.Count == 0)
        {
            return;
        }

        sb.AppendLine("## Callbacks");
        foreach (var callback in callbacks.OrderBy(x => x.Key, StringComparer.Ordinal))
        {
            var pathItems = callback.Value.PathItems;
            if (pathItems == null)
            {
                continue;
            }

            foreach (var pathItem in pathItems.OrderBy(x => x.Key.ToString(), StringComparer.Ordinal))
            {
                var callbackOperations = pathItem.Value.Operations;
                if (callbackOperations == null)
                {
                    continue;
                }

                foreach (var callbackOperation in callbackOperations.OrderBy(x => x.Key.Method, StringComparer.Ordinal))
                {
                    AppendAsyncInteractionDocumentation(
                        sb,
                        label: "CALLBACK",
                        name: callback.Key,
                        target: pathItem.Key.ToString(),
                        method: callbackOperation.Key.Method.ToUpperInvariant(),
                        operation: callbackOperation.Value);
                }
            }
        }
    }

    private static void AppendAsyncInteractionDocumentation(
        StringBuilder sb,
        string label,
        string? name,
        string? target,
        string method,
        OpenApiOperation operation)
    {
        var summary = !string.IsNullOrWhiteSpace(operation.Summary)
            ? operation.Summary
            : operation.Description;
        var title = !string.IsNullOrWhiteSpace(summary)
            ? summary
            : !string.IsNullOrWhiteSpace(target)
                ? string.Concat(method, " ", target)
                : method;

        sb.Append("### [")
            .Append(label)
            .Append("] ")
            .AppendLine(title);

        if (!string.IsNullOrWhiteSpace(name))
        {
            sb.Append("# Name: ").AppendLine(name);
        }

        if (!string.IsNullOrWhiteSpace(target))
        {
            sb.Append("# Target: ").AppendLine(target);
        }

        if (!string.IsNullOrWhiteSpace(operation.OperationId))
        {
            sb.Append("# OperationId: ").AppendLine(operation.OperationId);
        }

        sb.Append("# Method: ").AppendLine(method);

        if (GetPreferredRequestContent(operation) is { } preferredContent)
        {
            sb.Append("# Content-Type: ").AppendLine(preferredContent.ContentType);
        }

        var acceptTypes = GetHttpAcceptTypes(operation);
        if (!string.IsNullOrEmpty(acceptTypes))
        {
            sb.Append("# Accept: ").AppendLine(acceptTypes);
        }

        if (GetPreferredRequestContent(operation) is { ContentType: "application/json", Schema: { } bodySchema })
        {
            var body = GenerateJsonBody(bodySchema);
            if (!string.IsNullOrWhiteSpace(body))
            {
                sb.AppendLine();
                sb.AppendLine(body);
            }
        }

        sb.AppendLine();
        sb.AppendLine();
    }

    private static string FormatRuntimeExpression(RuntimeExpressionAnyWrapper? value)
    {
        if (value?.Expression != null)
        {
            return value.Expression.ToString();
        }

        if (value?.Any != null)
        {
            return value.Any.ToJsonString();
        }

        return string.Empty;
    }

    private static IList<OpenApiSecurityRequirement> GetEffectiveSecurityRequirements(
        OperationContext operation)
    {
        var opSecurity = operation.Operation.Security;
        if (opSecurity is { Count: > 0 })
        {
            return opSecurity;
        }

        return operation.GlobalSecurityRequirements;
    }

    private static List<string> GetHttpAuthHeaders(
        IList<OpenApiSecurityRequirement> securityRequirements)
    {
        var headers = new List<string>();
        var seen = new HashSet<string>();

        foreach (var requirement in securityRequirements)
        {
            foreach (var kvp in requirement)
            {
                var header = GetAuthHeaderForScheme(kvp.Key);
                if (header != null && seen.Add(header))
                {
                    headers.Add(header);
                }
            }
        }

        return headers;
    }

    private static string? GetAuthHeaderForScheme(OpenApiSecuritySchemeReference scheme)
    {
        return (scheme.Type, scheme.Scheme?.ToUpperInvariant(), scheme.In) switch
        {
            (SecuritySchemeType.Http, "BEARER", _) => "Authorization: Bearer {{token}}",
            (SecuritySchemeType.Http, "BASIC", _) => "Authorization: Basic {{credentials}}",
            (SecuritySchemeType.Http, _, _) => $"Authorization: {scheme.Scheme} {{api_key}}",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Header) =>
                scheme.Name + ": {{api_key}}",
            (SecuritySchemeType.ApiKey, _, ParameterLocation.Query) => null, // handled in query string
            (SecuritySchemeType.OAuth2, _, _) => "Authorization: Bearer {{token}}",
            (SecuritySchemeType.OpenIdConnect, _, _) => "Authorization: Bearer {{token}}",
            _ => null,
        };
    }

    private static List<string> GetApiKeyQueryParams(
        IList<OpenApiSecurityRequirement> securityRequirements)
    {
        var result = new List<string>();

        foreach (var requirement in securityRequirements)
        {
            foreach (var kvp in requirement)
            {
                if (kvp.Key.Type == SecuritySchemeType.ApiKey &&
                    kvp.Key.In == ParameterLocation.Query &&
                    !string.IsNullOrWhiteSpace(kvp.Key.Name))
                {
                    result.Add(kvp.Key.Name + "={{api_key}}");
                }
            }
        }

        return result;
    }

    private static string? GetHttpAcceptTypes(OpenApiOperation operation)
    {
        if (operation.Responses == null)
        {
            return "application/json";
        }

        var contentTypes = new HashSet<string>();
        foreach (var kvp in operation.Responses)
        {
            if (kvp.Value.Content != null)
            {
                foreach (var key in kvp.Value.Content.Keys)
                {
                    contentTypes.Add(key);
                }
            }
        }

        if (contentTypes.Count == 0)
        {
            return null;
        }

        return string.Join(", ", contentTypes.OrderBy(x => x, StringComparer.Ordinal));
    }

    private static string GenerateJsonBody(IOpenApiSchema schema, int depth = 0, HashSet<IOpenApiSchema>? visited = null)
    {
        visited ??= [];
        if (depth > 3 || !visited.Add(schema))
        {
            return "{}";
        }

        var resolved = schema.ResolveIfRequired();
        if (resolved != schema)
        {
            if (!visited.Add(resolved))
            {
                return "{}";
            }

            schema = resolved;
        }

        var jsonNode = SchemaToJsonNode(schema, depth, visited);
        return jsonNode?.ToJsonString(HttpJsonOptions) ?? "{}";
    }

    private static JsonNode? SchemaToJsonNode(IOpenApiSchema schema, int depth, HashSet<IOpenApiSchema> visited)
    {
        if (depth > 3)
        {
            return null;
        }

        // Use example if available
        if (schema.Example != null)
        {
            return JsonNode.Parse(schema.Example.ToJsonString());
        }

        // Use default if available
        if (schema.Default != null)
        {
            return JsonNode.Parse(schema.Default.ToJsonString());
        }

        // Handle allOf/oneOf/anyOf - use first schema that has properties
        if (schema.AllOf is { Count: > 0 })
        {
            var merged = new JsonObject();
            foreach (var sub in schema.AllOf)
            {
                var resolved = sub.ResolveIfRequired();
                if (resolved.Properties is { Count: > 0 })
                {
                    foreach (var prop in resolved.Properties)
                    {
                        if (!merged.ContainsKey(prop.Key))
                        {
                            var val = SchemaToJsonNode(prop.Value, depth + 1, visited);
                            if (val != null)
                            {
                                merged[prop.Key] = val;
                            }
                        }
                    }
                }
            }

            return merged;
        }

        if (schema.OneOf is { Count: > 0 } || schema.AnyOf is { Count: > 0 })
        {
            var variants = schema.OneOf is { Count: > 0 } ? schema.OneOf : schema.AnyOf!;
            var first = variants[0].ResolveIfRequired();
            return SchemaToJsonNode(first, depth, visited);
        }

        var schemaType = schema.Type ?? 0;

        // Object
        if ((schemaType & JsonSchemaType.Object) == JsonSchemaType.Object ||
            schema.Properties is { Count: > 0 })
        {
            var obj = new JsonObject();
            if (schema.Properties != null)
            {
                foreach (var prop in schema.Properties)
                {
                    var val = SchemaToJsonNode(prop.Value.ResolveIfRequired(), depth + 1, visited);
                    if (val != null)
                    {
                        obj[prop.Key] = val;
                    }
                }
            }

            return obj;
        }

        // Array
        if ((schemaType & JsonSchemaType.Array) == JsonSchemaType.Array)
        {
            var arr = new JsonArray();
            if (schema.Items != null)
            {
                var item = SchemaToJsonNode(schema.Items.ResolveIfRequired(), depth + 1, visited);
                if (item != null)
                {
                    arr.Add(item);
                }
            }

            return arr;
        }

        // Enum - use first value
        if (schema.Enum is { Count: > 0 })
        {
            return JsonNode.Parse(schema.Enum[0].ToJsonString());
        }

        // String
        if ((schemaType & JsonSchemaType.String) == JsonSchemaType.String)
        {
            return schema.Format switch
            {
                "date" => JsonValue.Create("2025-01-01"),
                "date-time" => JsonValue.Create("2025-01-01T00:00:00Z"),
                "email" => JsonValue.Create("user@example.com"),
                "uri" or "url" => JsonValue.Create("https://example.com"),
                "uuid" => JsonValue.Create("00000000-0000-0000-0000-000000000000"),
                "binary" or "byte" => JsonValue.Create(""),
                _ => JsonValue.Create("string"),
            };
        }

        // Integer
        if ((schemaType & JsonSchemaType.Integer) == JsonSchemaType.Integer)
        {
            return JsonValue.Create(0);
        }

        // Number
        if ((schemaType & JsonSchemaType.Number) == JsonSchemaType.Number)
        {
            return JsonValue.Create(0.0);
        }

        // Boolean
        if ((schemaType & JsonSchemaType.Boolean) == JsonSchemaType.Boolean)
        {
            return JsonValue.Create(true);
        }

        return JsonValue.Create("string");
    }

    private static void AddAuthVariables(
        JsonObject env,
        IReadOnlyList<OpenApiSecuritySchemeReference> securitySchemes)
    {
        var added = new HashSet<string>();

        foreach (var scheme in securitySchemes)
        {
            switch (scheme.Type)
            {
                case SecuritySchemeType.Http when
                    string.Equals(scheme.Scheme, "bearer", StringComparison.OrdinalIgnoreCase):
                case SecuritySchemeType.OAuth2:
                case SecuritySchemeType.OpenIdConnect:
                    if (added.Add("token"))
                    {
                        env["token"] = "";
                    }

                    break;
                case SecuritySchemeType.Http when
                    string.Equals(scheme.Scheme, "basic", StringComparison.OrdinalIgnoreCase):
                    if (added.Add("credentials"))
                    {
                        env["credentials"] = "";
                    }

                    break;
                case SecuritySchemeType.Http:
                    if (added.Add("api_key"))
                    {
                        env["api_key"] = "";
                    }

                    break;
                case SecuritySchemeType.ApiKey:
                    if (added.Add("api_key"))
                    {
                        env["api_key"] = "";
                    }

                    break;
            }
        }
    }

    private static string SanitizeEnvName(string description)
    {
        // Replace non-alphanumeric with dash, case-fold via ToUpperInvariant for consistency
        var name = Regex.Replace(description, @"[^a-zA-Z0-9]+", "-", RegexOptions.None, TimeSpan.FromSeconds(1)).Trim('-');
        if (string.IsNullOrWhiteSpace(name))
        {
            return "dev";
        }

        // Use char-by-char lowercase to avoid CA1308 (ToLowerInvariant)
        var sb = new StringBuilder(name.Length);
        foreach (var c in name)
        {
            sb.Append(char.IsUpper(c) ? (char)(c + 32) : c);
        }

        return sb.ToString();
    }

    private static string GetEnvNameFromIndex(int index, int total)
    {
        if (total == 1)
        {
            return "dev";
        }

        return index switch
        {
            0 => "dev",
            1 => "staging",
            2 => "production",
            _ => "server-" + (index + 1).ToString(CultureInfo.InvariantCulture),
        };
    }

    #endregion
}
