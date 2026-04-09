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
    private static readonly JsonSerializerOptions SnippetManifestJsonOptions = new()
    {
        WriteIndented = true,
    };

    public static FileWithName SnippetManifest(
        IReadOnlyList<OperationContext> operations,
        IReadOnlyList<EndPoint> endPoints,
        CancellationToken cancellationToken = default)
    {
        var text = GenerateSnippetManifest(operations, endPoints, cancellationToken);
        return string.IsNullOrWhiteSpace(text)
            ? FileWithName.Empty
            : new FileWithName(
                Name: "autosdk.generated-examples.json",
                Text: text);
    }

    public static string GenerateSnippetManifest(
        IReadOnlyList<OperationContext> operations,
        IReadOnlyList<EndPoint> endPoints,
        CancellationToken cancellationToken = default)
    {
        operations = operations ?? throw new ArgumentNullException(nameof(operations));
        endPoints = endPoints ?? throw new ArgumentNullException(nameof(endPoints));

        var primaryEndPoints = endPoints
            .Where(static x => !string.IsNullOrWhiteSpace(x.Id))
            .GroupBy(static x => x.Id, StringComparer.Ordinal)
            .ToDictionary(
                static x => x.Key,
                static x => x
                    .OrderBy(static y => y.Stream)
                    .First(),
                StringComparer.Ordinal);

        var snippets = new List<GeneratedSdkSnippetDocument>();
        foreach (var operation in operations
                     .Where(static x => HasSnippetSource(x.Operation))
                     .OrderBy(static x => x.Tag.SafeName, StringComparer.Ordinal)
                     .ThenBy(static x => x.MethodName, StringComparer.Ordinal))
        {
            cancellationToken.ThrowIfCancellationRequested();

            primaryEndPoints.TryGetValue(operation.MethodName, out var endPoint);
            var snippet = CreateSnippetDocument(operation, endPoint, snippets.Count + 1);
            if (snippet is not null)
            {
                snippets.Add(snippet);
            }
        }

        if (snippets.Count == 0)
        {
            return string.Empty;
        }

        return JsonSerializer.Serialize(
            new GeneratedSdkSnippetManifest(snippets),
            SnippetManifestJsonOptions);
    }

    private static GeneratedSdkSnippetDocument? CreateSnippetDocument(
        OperationContext operation,
        EndPoint? endPoint,
        int order)
    {
        var title = GetSnippetTitle(operation);
        var description = string.IsNullOrWhiteSpace(operation.Operation.Description)
            ? "Generated from OpenAPI examples."
            : operation.Operation.Description.Trim();
        var slug = Slugify(operation.Operation.OperationId ?? title);
        var operationId = operation.Operation.OperationId ?? operation.MethodName;

        if (endPoint is EndPoint method &&
            TryCreateGeneratedCSharpSnippet(operation, method, out var csharpCode, out var setup))
        {
            return new GeneratedSdkSnippetDocument(
                Order: order,
                Title: title,
                Slug: slug,
                Description: description,
                Language: "csharp",
                Code: csharpCode,
                Format: "sdk",
                OperationId: operationId,
                Setup: setup);
        }

        if (TryGetPreferredCodeSample(operation.Operation, out var codeSample))
        {
            return new GeneratedSdkSnippetDocument(
                Order: order,
                Title: title,
                Slug: slug,
                Description: description,
                Language: "csharp",
                Code: codeSample,
                Format: "sdk",
                OperationId: operationId);
        }

        return new GeneratedSdkSnippetDocument(
            Order: order,
            Title: title,
            Slug: slug,
            Description: description,
            Language: "http",
            Code: GenerateHttpRequest(operation).TrimEnd(),
            Format: "http",
            OperationId: operationId);
    }

    private static bool TryCreateGeneratedCSharpSnippet(
        OperationContext operation,
        EndPoint endPoint,
        out string code,
        out string? setup)
    {
        code = string.Empty;
        setup = null;

        if (!TryCreateClientInstantiation(endPoint, out var clientInstantiation, out setup))
        {
            return false;
        }

        var requiredArgumentLines = new List<string>();
        var optionalArgumentLines = new List<string>();
        var requestPreludeLines = new List<string>();
        IEnumerable<IOpenApiParameter> parameters = operation.Operation.Parameters ?? [];
        IReadOnlyList<string> requestPrelude = Array.Empty<string>();
        var requestArgumentLine = string.Empty;

        foreach (var parameter in endPoint.Parameters.Where(static x => x.Location != null && x.IsRequired && !x.HasSchemaDefault))
        {
            if (!TryCreateParameterArgumentLine(parameter, parameters, allowSchemaFallback: true, out var line, out _))
            {
                return false;
            }

            requiredArgumentLines.Add(line);
        }

        if (!string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) &&
            !TryCreateRequestSnippet(operation.Operation, endPoint, out requestPrelude, out requestArgumentLine))
        {
            return false;
        }

        if (!string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType))
        {
            requestPreludeLines.AddRange(requestPrelude);
            requiredArgumentLines.Add(requestArgumentLine);
        }

        foreach (var parameter in endPoint.Parameters.Where(static x => x.Location != null && (!x.IsRequired || x.HasSchemaDefault)))
        {
            if (TryCreateParameterArgumentLine(parameter, parameters, allowSchemaFallback: false, out var line, out var hasExplicitExample) &&
                hasExplicitExample)
            {
                optionalArgumentLines.Add(line);
            }
        }

        var clientAccessor = endPoint.Settings.GroupByTags && endPoint.Tag != Tag.Empty
            ? $"client.{endPoint.Tag.SafeName}"
            : "client";
        var callArguments = requiredArgumentLines
            .Concat(optionalArgumentLines)
            .ToArray();

        var builder = new StringBuilder();
        builder.AppendLine(clientInstantiation);

        if (requestPreludeLines.Count > 0)
        {
            builder.AppendLine();
            foreach (var line in requestPreludeLines)
            {
                builder.AppendLine(line);
            }
        }

        if (requestPreludeLines.Count > 0 || callArguments.Length > 0)
        {
            builder.AppendLine();
        }

        if (string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType))
        {
            builder.Append("await ");
        }
        else
        {
            builder.Append("var response = await ");
        }

        builder.Append(clientAccessor)
            .Append('.')
            .Append(endPoint.MethodName);

        if (callArguments.Length == 0)
        {
            builder.AppendLine("();");
        }
        else
        {
            builder.AppendLine("(");
            for (var i = 0; i < callArguments.Length; i++)
            {
                builder.Append("    ")
                    .Append(callArguments[i]);

                if (i < callArguments.Length - 1)
                {
                    builder.Append(',');
                }

                builder.AppendLine();
            }

            builder.AppendLine(");");
        }

        var responseExample = TryGetFirstSuccessResponseExample(operation.Operation);
        if (!string.IsNullOrWhiteSpace(responseExample))
        {
            builder.AppendLine();
            builder.AppendLine("// Example response:");
            foreach (var line in NormalizeSnippetNewlines(responseExample).Split('\n'))
            {
                builder.Append("// ");
                builder.AppendLine(line);
            }
        }

        code = builder
            .ToString()
            .TrimEnd();
        return true;
    }

    private static bool TryCreateClientInstantiation(
        EndPoint endPoint,
        out string clientInstantiation,
        out string setup)
    {
        var rootClientClassName = endPoint.Settings.ClassName.Replace(".", string.Empty);
        if (endPoint.Authorizations.IsEmpty)
        {
            clientInstantiation = $"using var client = new {rootClientClassName}();";
            setup = $"This example assumes `using {endPoint.Settings.Namespace};` is in scope.";
            return true;
        }

        if (endPoint.Authorizations.Length != 1 ||
            endPoint.Authorizations[0].Parameters.IsEmpty)
        {
            clientInstantiation = string.Empty;
            setup = string.Empty;
            return false;
        }

        var authorization = endPoint.Authorizations[0];
        var parameters = authorization.Parameters.ToArray();
        clientInstantiation = $"using var client = new {rootClientClassName}({string.Join(", ", parameters)});";
        setup = parameters.Length == 1
            ? $"This example assumes `using {endPoint.Settings.Namespace};` is in scope and `{parameters[0]}` contains the required credential."
            : $"This example assumes `using {endPoint.Settings.Namespace};` is in scope and `{string.Join("` / `", parameters)}` contain the required credentials.";
        return true;
    }

    private static bool TryCreateParameterArgumentLine(
        MethodParameter parameter,
        IEnumerable<IOpenApiParameter> sourceParameters,
        bool allowSchemaFallback,
        out string line,
        out bool hasExplicitExample)
    {
        line = string.Empty;
        hasExplicitExample = false;

        var sourceParameter = sourceParameters.FirstOrDefault(x =>
            x.In == parameter.Location &&
            string.Equals(x.Name, parameter.Id, StringComparison.OrdinalIgnoreCase));
        if (sourceParameter == null ||
            !TryGetParameterJsonText(sourceParameter, parameter.Type, allowSchemaFallback, out var jsonText, out hasExplicitExample) ||
            !TryCreateCSharpExpression(parameter.Type, jsonText, out var expression))
        {
            return false;
        }

        line = $"{parameter.ParameterName}: {expression}";
        return true;
    }

    private static bool TryCreateRequestSnippet(
        OpenApiOperation operation,
        EndPoint endPoint,
        out IReadOnlyList<string> preludeLines,
        out string requestArgumentLine)
    {
        preludeLines = Array.Empty<string>();
        requestArgumentLine = string.Empty;

        var preferredContent = GetPreferredRequestContent(operation);
        if (preferredContent is not { } requestContent ||
            !IsJsonContentType(requestContent.ContentType) ||
            !TryGetMediaTypeExampleText(requestContent.MediaType, requestContent.ContentType, out var requestExample))
        {
            return false;
        }

        preludeLines = new[]
        {
            $"var request = global::System.Text.Json.JsonSerializer.Deserialize<{endPoint.RequestType.CSharpTypeWithoutNullability}>(",
            $"    {ToVerbatimStringLiteral(requestExample)})!;",
        };
        requestArgumentLine = "request: request";
        return true;
    }

    private static bool TryGetParameterJsonText(
        IOpenApiParameter parameter,
        TypeData type,
        bool allowSchemaFallback,
        out string jsonText,
        out bool hasExplicitExample)
    {
        jsonText = string.Empty;
        hasExplicitExample = false;

        foreach (var example in (parameter.Examples ?? new Dictionary<string, IOpenApiExample>())
                     .OrderBy(static x => x.Key, StringComparer.Ordinal)
                     .Select(static x => x.Value))
        {
            if (TryGetExampleJsonText(example, type, out jsonText))
            {
                hasExplicitExample = true;
                return true;
            }
        }

        if (parameter.Example != null)
        {
            jsonText = parameter.Example.ToJsonString(HttpJsonOptions);
            hasExplicitExample = true;
            return true;
        }

        if (!allowSchemaFallback)
        {
            return false;
        }

        if (parameter.Schema?.Default != null)
        {
            jsonText = parameter.Schema.Default.ToJsonString(HttpJsonOptions);
            return true;
        }

        if (parameter.Schema?.Enum is { Count: > 0 })
        {
            jsonText = parameter.Schema.Enum[0].ToJsonString(HttpJsonOptions);
            return true;
        }

        return false;
    }

    private static bool TryGetExampleJsonText(
        IOpenApiExample? example,
        TypeData type,
        out string jsonText)
    {
        jsonText = string.Empty;
        if (example == null)
        {
            return false;
        }

        if (example.DataValue != null)
        {
            jsonText = example.DataValue.ToJsonString(HttpJsonOptions);
            return true;
        }

        if (example.Value != null)
        {
            jsonText = example.Value.ToJsonString(HttpJsonOptions);
            return true;
        }

        return example.SerializedValue != null &&
               TryNormalizeScalarToJson(example.SerializedValue, type, out jsonText);
    }

    private static bool TryGetMediaTypeExampleText(
        IOpenApiMediaType mediaType,
        string contentType,
        out string exampleText)
    {
        var text =
            GetExampleText(mediaType.Examples, contentType, rawScalars: false) ??
            (mediaType.Example != null
                ? FormatExampleNode(mediaType.Example, contentType, rawScalars: false)
                : null);

        if (!string.IsNullOrWhiteSpace(text))
        {
            exampleText = text;
            return true;
        }

        if (mediaType.Schema?.Example != null)
        {
            exampleText = mediaType.Schema.Example.ToJsonString(HttpJsonOptions);
            return true;
        }

        exampleText = string.Empty;
        return false;
    }

    private static string? TryGetFirstSuccessResponseExample(OpenApiOperation operation)
    {
        foreach (var response in (operation.Responses ?? new Dictionary<string, IOpenApiResponse>())
                     .Where(static x => x.Key.StartsWith("2", StringComparison.OrdinalIgnoreCase))
                     .OrderBy(static x => x.Key, StringComparer.Ordinal))
        {
            foreach (var content in (response.Value.Content ?? new Dictionary<string, IOpenApiMediaType>())
                         .OrderBy(static x => x.Key, StringComparer.Ordinal))
            {
                if (TryGetMediaTypeExampleText(content.Value, content.Key, out var exampleText))
                {
                    return exampleText;
                }
            }
        }

        return null;
    }

    private static bool TryCreateCSharpExpression(
        TypeData type,
        string jsonText,
        out string expression)
    {
        expression = string.Empty;
        if (!TryParseJsonNode(jsonText, out var node))
        {
            return false;
        }

        if (type.CSharpTypeWithoutNullability == "string" &&
            node is JsonValue stringNode &&
            stringNode.TryGetValue<string>(out var stringValue))
        {
            expression = ToCSharpStringLiteral(stringValue);
            return true;
        }

        if (type.CSharpTypeWithoutNullability == "bool" &&
            node is JsonValue boolNode &&
            boolNode.TryGetValue<bool>(out var boolValue))
        {
            expression = boolValue ? "true" : "false";
            return true;
        }

        if (IsIntegralType(type.CSharpTypeWithoutNullability) &&
            node is JsonValue)
        {
            expression = node.ToJsonString();
            return true;
        }

        if (type.IsEnum &&
            !type.IsAnyOfLike &&
            node is JsonValue enumNode &&
            enumNode.TryGetValue<string>(out var enumValue))
        {
            var enumIndex = Array.FindIndex(type.EnumValues.ToArray(), x => string.Equals(x, enumValue, StringComparison.Ordinal));
            if (enumIndex >= 0 &&
                enumIndex < type.Properties.Length)
            {
                expression = $"{type.CSharpTypeWithoutNullability}.{type.Properties[enumIndex]}";
                return true;
            }
        }

        expression = $@"global::System.Text.Json.JsonSerializer.Deserialize<{type.CSharpTypeWithoutNullability}>(
    {ToVerbatimStringLiteral(jsonText)})!";
        return true;
    }

    private static bool TryNormalizeScalarToJson(
        string rawValue,
        TypeData type,
        out string jsonText)
    {
        rawValue = rawValue.Trim();
        if (string.IsNullOrWhiteSpace(rawValue))
        {
            jsonText = string.Empty;
            return false;
        }

        if (TryParseJsonNode(rawValue, out _))
        {
            jsonText = rawValue;
            return true;
        }

        if (type.CSharpTypeWithoutNullability == "bool" &&
            bool.TryParse(rawValue, out var boolValue))
        {
            jsonText = boolValue ? "true" : "false";
            return true;
        }

        if (IsIntegralType(type.CSharpTypeWithoutNullability) &&
            long.TryParse(rawValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out _))
        {
            jsonText = rawValue;
            return true;
        }

        if ((type.CSharpTypeWithoutNullability == "double" ||
             type.CSharpTypeWithoutNullability == "float") &&
            double.TryParse(rawValue, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out _))
        {
            jsonText = rawValue;
            return true;
        }

        jsonText = JsonSerializer.Serialize(rawValue);
        return true;
    }

    private static bool TryParseJsonNode(string text, out JsonNode? node)
    {
        try
        {
            node = JsonNode.Parse(text);
            return node != null;
        }
        catch (JsonException)
        {
            node = null;
            return false;
        }
    }

    private static bool IsIntegralType(string typeName)
    {
        return typeName is "byte" or "sbyte" or "short" or "ushort" or "int" or "uint" or "long" or "ulong";
    }

    private static bool HasSnippetSource(OpenApiOperation operation)
    {
        if (TryGetPreferredCodeSample(operation, out _))
        {
            return true;
        }

        if ((operation.Parameters ?? []).Any(static x =>
                (x.Examples?.Count ?? 0) > 0 ||
                x.Example != null))
        {
            return true;
        }

        if ((operation.RequestBody?.Content ?? new Dictionary<string, IOpenApiMediaType>()).Any(static x =>
                (x.Value.Examples?.Count ?? 0) > 0 ||
                x.Value.Example != null ||
                x.Value.Schema?.Example != null))
        {
            return true;
        }

        return (operation.Responses ?? new Dictionary<string, IOpenApiResponse>()).Any(static x =>
            (x.Value.Content ?? new Dictionary<string, IOpenApiMediaType>()).Any(static y =>
                (y.Value.Examples?.Count ?? 0) > 0 ||
                y.Value.Example != null ||
                y.Value.Schema?.Example != null));
    }

    private static bool TryGetPreferredCodeSample(
        OpenApiOperation operation,
        out string codeSample)
    {
        codeSample = string.Empty;
        if (!(operation.Extensions ?? new Dictionary<string, IOpenApiExtension>())
                .TryGetValue("x-codeSamples", out var extension))
        {
            return false;
        }

        var jsonNode = OpenApiExtensions.TryGetExtensionJsonNode(extension);
        if (jsonNode is not JsonArray samplesArray || samplesArray.Count == 0)
        {
            return false;
        }

        var source = samplesArray
            .OfType<JsonObject>()
            .FirstOrDefault(static sample => HasSnippetLang(sample, "csharp") || HasSnippetLang(sample, "c#"));
        if (source == null ||
            !source.TryGetPropertyValue("source", out var sourceNode) ||
            sourceNode is not JsonValue sourceValue ||
            !sourceValue.TryGetValue<string>(out var codeSampleValue) ||
            string.IsNullOrWhiteSpace(codeSampleValue))
        {
            codeSample = string.Empty;
            return false;
        }

        codeSample = codeSampleValue;
        return true;
    }

    private static bool HasSnippetLang(JsonObject sample, string expectedLang)
    {
        if (sample.TryGetPropertyValue("lang", out var langNode) &&
            langNode is JsonValue langValue &&
            langValue.TryGetValue<string>(out var langStr))
        {
            return string.Equals(langStr, expectedLang, StringComparison.OrdinalIgnoreCase);
        }

        return false;
    }

    private static string GetSnippetTitle(OperationContext operation)
    {
        var summary = !string.IsNullOrWhiteSpace(operation.Operation.Summary)
            ? operation.Operation.Summary
            : operation.Operation.Description;
        return !string.IsNullOrWhiteSpace(summary)
            ? summary.Trim()
            : $"{operation.OperationType.Method.ToUpperInvariant()} {operation.OperationPath}";
    }

    private static string Slugify(string value)
    {
        var slug = string.Concat(value.Select(char.ToLowerInvariant));
        slug = Regex.Replace(slug, @"[^a-z0-9]+", "-");
        return slug.Trim('-');
    }

    private static string ToCSharpStringLiteral(string value)
    {
        return JsonSerializer.Serialize(value);
    }

    private static string ToVerbatimStringLiteral(string value)
    {
        return "@\"" + NormalizeSnippetNewlines(value).Replace("\"", "\"\"", StringComparison.Ordinal) + "\"";
    }

    private static string NormalizeSnippetNewlines(string value)
    {
        return value.Replace("\r\n", "\n", StringComparison.Ordinal);
    }
}
