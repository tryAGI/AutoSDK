using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using AutoSDK.Helpers;
using Microsoft.OpenApi;
using AutoSDK.Models;
using Microsoft.OpenApi.Reader;
using Microsoft.OpenApi.YamlReader;

namespace AutoSDK.Extensions;

public static class OpenApiExtensions
{
    public static OpenApiDocument GetOpenApiDocument(
        this string yamlOrJson,
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        return yamlOrJson.GetOpenApiDocument(settings.ToCoreSettings(), cancellationToken);
    }

    public static OpenApiDocument GetOpenApiDocument(
        this string yamlOrJson,
        CoreSettings settings,
        CancellationToken cancellationToken = default)
    {
        yamlOrJson = yamlOrJson ?? throw new ArgumentNullException(nameof(yamlOrJson));

        var readerSettings = new OpenApiReaderSettings
        {
            RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
        };
        // Add YAML reader support via extension method from Microsoft.OpenApi.YamlReader
        readerSettings.AddYamlReader();

        var (openApiDocument, diagnostics) = OpenApiDocument.Parse(yamlOrJson, settings: readerSettings);
        if (openApiDocument == null &&
            TryPromoteOpenApiFragment(yamlOrJson, out var promotedText))
        {
            Console.WriteLine("Detected OpenAPI fragment without header. Retrying with synthesized metadata.");
            (openApiDocument, diagnostics) = OpenApiDocument.Parse(promotedText, settings: readerSettings);
        }
        if (openApiDocument == null)
        {
            throw new InvalidOperationException("Document is null");
        }
        if (!settings.IgnoreOpenApiErrors && diagnostics?.Errors.Any() == true)
        {
            throw new AggregateException(diagnostics.Errors.Select(x => new InvalidOperationException(x.Message)));
        }
        if (!settings.IgnoreOpenApiWarnings && diagnostics?.Warnings.Any() == true)
        {
            throw new AggregateException(diagnostics.Warnings.Select(x => new InvalidOperationException(x.Message)));
        }

        openApiDocument.Components ??= new OpenApiComponents();
        openApiDocument.Components.Schemas ??= new Dictionary<string, IOpenApiSchema>();
        openApiDocument.Paths ??= new OpenApiPaths();
        openApiDocument.Tags ??= new HashSet<OpenApiTag>();
        openApiDocument.Security ??= new List<OpenApiSecurityRequirement>();
        openApiDocument.Servers ??= new List<OpenApiServer>();

        if (!string.IsNullOrEmpty(settings.BaseUrl))
        {
            openApiDocument.InjectBaseUrl(settings);
        }
        if (settings.SecuritySchemes.Length > 0)
        {
            openApiDocument.InjectSecuritySchemes(settings);
        }
        if (settings.ComputeDiscriminators)
        {
            openApiDocument = openApiDocument.ComputeDiscriminators();
        }
        if (settings.AddMissingPathParameters)
        {
            openApiDocument = openApiDocument.AddMissingPathParameters();
        }
        if (settings.OpenApiOverrides.Length > 0)
        {
            openApiDocument.ApplyOpenApiOverrides(settings);
        }

        openApiDocument.SanitizeNumericConstraints();
        openApiDocument.InferLargeIntegerFormats();
        openApiDocument.SanitizeDiscriminators();

        return openApiDocument;
    }

    private static bool TryPromoteOpenApiFragment(
        string text,
        out string promotedText)
    {
        promotedText = string.Empty;

        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        return TryPromoteJsonOpenApiFragment(text, out promotedText) ||
               TryPromoteYamlOpenApiFragment(text, out promotedText);
    }

    private static bool TryPromoteJsonOpenApiFragment(
        string text,
        out string promotedText)
    {
        promotedText = string.Empty;

        JsonNode? node;
        try
        {
            node = JsonNode.Parse(text);
        }
        catch
        {
            return false;
        }

        if (node is not JsonObject jsonObject ||
            jsonObject.ContainsKey("openapi") ||
            jsonObject.ContainsKey("swagger") ||
            !LooksLikeOpenApiFragment(jsonObject))
        {
            return false;
        }

        var promotedObject = new JsonObject
        {
            ["openapi"] = "3.0.1",
            ["info"] = new JsonObject
            {
                ["title"] = "AutoSDK Generated Fragment",
                ["version"] = "1.0.0",
            },
        };

        foreach (var property in jsonObject)
        {
            promotedObject[property.Key] = property.Value?.DeepClone();
        }

        promotedText = promotedObject.ToJsonString();
        return true;
    }

    private static bool TryPromoteYamlOpenApiFragment(
        string text,
        out string promotedText)
    {
        promotedText = string.Empty;

        if (Regex.IsMatch(text, @"(?m)^\s*(openapi|swagger)\s*:") ||
            !Regex.IsMatch(text, @"(?m)^\s*(paths|components|tags|servers|security)\s*:"))
        {
            return false;
        }

        promotedText = """
openapi: 3.0.1
info:
  title: AutoSDK Generated Fragment
  version: 1.0.0

""" + text;
        return true;
    }

    private static bool LooksLikeOpenApiFragment(JsonObject jsonObject)
    {
        return jsonObject.ContainsKey("paths") ||
               jsonObject.ContainsKey("components") ||
               jsonObject.ContainsKey("tags") ||
               jsonObject.ContainsKey("servers") ||
               jsonObject.ContainsKey("security");
    }

    /// <summary>
    /// Walks all schemas in the document and removes minimum/maximum values
    /// that exceed the representable range of their target C# type.
    /// This prevents issues with values like minimum: -9223372036854776000
    /// which exceed long.MinValue and can cause problems in spec processing.
    /// </summary>
    public static void SanitizeNumericConstraints(this OpenApiDocument document)
    {
        document = document ?? throw new ArgumentNullException(nameof(document));

        foreach (var schema in (document.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal).Select(x => x.Value))
        {
            SanitizeSchemaNumericConstraints(schema);
        }
    }

    public static void InferLargeIntegerFormats(this OpenApiDocument document)
    {
        document = document ?? throw new ArgumentNullException(nameof(document));

        foreach (var schema in (document.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal).Select(x => x.Value))
        {
            InferSchemaLargeIntegerFormats(
                schema,
                propertyName: null,
                inheritedTitle: null,
                inheritedDescription: null);
        }
    }

    public static void ApplyOpenApiOverrides(
        this OpenApiDocument document,
        Settings settings)
    {
        document.ApplyOpenApiOverrides(settings.ToCoreSettings());
    }

    public static void ApplyOpenApiOverrides(
        this OpenApiDocument document,
        CoreSettings settings)
    {
        document = document ?? throw new ArgumentNullException(nameof(document));

        foreach (var rawOverride in settings.OpenApiOverrides)
        {
            if (!TryParseOpenApiOverride(rawOverride, out var path, out var action))
            {
                Console.WriteLine($"Invalid OpenAPI override '{rawOverride}'. Expected 'path=action'.");
                continue;
            }

            if (!TryResolveOverrideTarget(document, path, out var target))
            {
                Console.WriteLine($"OpenAPI override target '{path}' was not found.");
                continue;
            }

            switch (action)
            {
                case OpenApiOverrideAction.Object:
                    target.Replace(CreateOverrideSchema(target.Schema, action));
                    break;
                case OpenApiOverrideAction.Dictionary:
                    target.Replace(CreateOverrideSchema(target.Schema, action));
                    break;
                case OpenApiOverrideAction.Remove:
                    if (target.Remove == null)
                    {
                        Console.WriteLine($"OpenAPI override target '{path}' cannot be removed.");
                        continue;
                    }

                    target.Remove();
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported OpenAPI override action '{action}'.");
            }
        }
    }

    private static bool TryParseOpenApiOverride(
        string rawOverride,
        out string path,
        out OpenApiOverrideAction action)
    {
        path = string.Empty;
        action = default;

        if (string.IsNullOrWhiteSpace(rawOverride))
        {
            return false;
        }

        var index = rawOverride.LastIndexOf('=');
        if (index <= 0 || index == rawOverride.Length - 1)
        {
            return false;
        }

        path = rawOverride.Substring(0, index).Trim();
        var actionText = rawOverride.Substring(index + 1).Trim();

        return !string.IsNullOrWhiteSpace(path) &&
               Enum.TryParse(actionText, ignoreCase: true, out action);
    }

    private static bool TryResolveOverrideTarget(
        OpenApiDocument document,
        string path,
        out OpenApiOverrideTarget target)
    {
        target = null!;

        const string prefix = "#/components/schemas/";
        if (!path.StartsWith(prefix, StringComparison.Ordinal))
        {
            return false;
        }

        var segments = path.Substring(prefix.Length)
            .Split('/')
            .Where(static x => x.Length > 0)
            .Select(DecodePointerSegment)
            .ToArray();
        if (segments.Length == 0)
        {
            return false;
        }

        var componentId = segments[0];
        if (!(document.Components?.Schemas?.TryGetValue(componentId, out var rootSchema) ?? false))
        {
            return false;
        }

        target = new OpenApiOverrideTarget(
            rootSchema,
            schema => document.Components!.Schemas![componentId] = schema,
            () => document.Components!.Schemas!.Remove(componentId));

        var index = 1;
        while (index < segments.Length)
        {
            if (target.Schema is not OpenApiSchema concreteSchema)
            {
                return false;
            }

            var token = segments[index++];
            switch (token)
            {
                case "properties":
                {
                    if (index >= segments.Length)
                    {
                        return false;
                    }

                    var propertyName = segments[index++];
                    if (!(concreteSchema.Properties?.TryGetValue(propertyName, out var propertySchema) ?? false))
                    {
                        return false;
                    }

                    target = new OpenApiOverrideTarget(
                        propertySchema,
                        schema => concreteSchema.Properties![propertyName] = schema,
                        () =>
                        {
                            concreteSchema.Properties!.Remove(propertyName);
                            if (concreteSchema.Required?.Contains(propertyName) == true)
                            {
                                concreteSchema.Required = new HashSet<string>(
                                    concreteSchema.Required.Where(x => x != propertyName),
                                    StringComparer.Ordinal);
                            }
                        });
                    break;
                }
                case "items":
                {
                    if (concreteSchema.Items == null)
                    {
                        return false;
                    }

                    target = new OpenApiOverrideTarget(
                        concreteSchema.Items,
                        schema => concreteSchema.Items = schema,
                        () => concreteSchema.Items = null);
                    break;
                }
                case "additionalProperties":
                {
                    if (concreteSchema.AdditionalProperties == null)
                    {
                        return false;
                    }

                    target = new OpenApiOverrideTarget(
                        concreteSchema.AdditionalProperties,
                        schema => concreteSchema.AdditionalProperties = schema,
                        () => concreteSchema.AdditionalProperties = null);
                    break;
                }
                case "anyOf":
                case "oneOf":
                case "allOf":
                {
                    if (index >= segments.Length ||
                        !int.TryParse(segments[index++], NumberStyles.Integer, CultureInfo.InvariantCulture, out var itemIndex))
                    {
                        return false;
                    }

                    IList<IOpenApiSchema>? collection = token switch
                    {
                        "anyOf" => concreteSchema.AnyOf,
                        "oneOf" => concreteSchema.OneOf,
                        "allOf" => concreteSchema.AllOf,
                        _ => null,
                    };
                    if (collection == null || itemIndex < 0 || itemIndex >= collection.Count)
                    {
                        return false;
                    }

                    target = new OpenApiOverrideTarget(
                        collection[itemIndex],
                        schema => collection[itemIndex] = schema,
                        () => collection.RemoveAt(itemIndex));
                    break;
                }
                default:
                    return false;
            }
        }

        return true;
    }

    private static string DecodePointerSegment(string segment)
    {
        return segment
            .Replace("~1", "/")
            .Replace("~0", "~");
    }

    private static OpenApiSchema CreateOverrideSchema(
        IOpenApiSchema source,
        OpenApiOverrideAction action)
    {
        if (source is OpenApiSchema schema)
        {
            return action switch
            {
                OpenApiOverrideAction.Object => new OpenApiSchema
                {
                    Type = JsonSchemaType.Object,
                    Title = schema.Title,
                    Description = schema.Description,
                    Default = schema.Default,
                    Example = schema.Example,
                },
                OpenApiOverrideAction.Dictionary => new OpenApiSchema
                {
                    Type = JsonSchemaType.Object,
                    Title = schema.Title,
                    Description = schema.Description,
                    Default = schema.Default,
                    Example = schema.Example,
                    AdditionalProperties = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                    },
                },
                _ => throw new InvalidOperationException($"Unsupported OpenAPI override action '{action}'."),
            };
        }

        return action switch
        {
            OpenApiOverrideAction.Object => new OpenApiSchema
            {
                Type = JsonSchemaType.Object,
            },
            OpenApiOverrideAction.Dictionary => new OpenApiSchema
            {
                Type = JsonSchemaType.Object,
                AdditionalProperties = new OpenApiSchema
                {
                    Type = JsonSchemaType.Object,
                },
            },
            _ => throw new InvalidOperationException($"Unsupported OpenAPI override action '{action}'."),
        };
    }

    private sealed class OpenApiOverrideTarget
    {
        public OpenApiOverrideTarget(
            IOpenApiSchema schema,
            Action<IOpenApiSchema> replace,
            Action? remove)
        {
            Schema = schema;
            Replace = replace;
            Remove = remove;
        }

        public IOpenApiSchema Schema { get; }
        public Action<IOpenApiSchema> Replace { get; }
        public Action? Remove { get; }
    }

    private enum OpenApiOverrideAction
    {
        Object,
        Dictionary,
        Remove,
    }

    private static void SanitizeSchemaNumericConstraints(IOpenApiSchema? schema)
    {
        if (schema is not OpenApiSchema concreteSchema)
        {
            return;
        }

        if (!string.IsNullOrEmpty(concreteSchema.Minimum) || !string.IsNullOrEmpty(concreteSchema.Maximum) ||
            !string.IsNullOrEmpty(concreteSchema.ExclusiveMinimum) || !string.IsNullOrEmpty(concreteSchema.ExclusiveMaximum))
        {
            var (min, max) = GetTypeRange(concreteSchema);
            if (IsOutOfRange(concreteSchema.Minimum, min, isMin: true))
            {
                concreteSchema.Minimum = null;
            }
            if (IsOutOfRange(concreteSchema.Maximum, max, isMin: false))
            {
                concreteSchema.Maximum = null;
            }
            if (IsOutOfRange(concreteSchema.ExclusiveMinimum, min, isMin: true))
            {
                concreteSchema.ExclusiveMinimum = null;
            }
            if (IsOutOfRange(concreteSchema.ExclusiveMaximum, max, isMin: false))
            {
                concreteSchema.ExclusiveMaximum = null;
            }
        }

        foreach (var property in (concreteSchema.Properties ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal).Select(x => x.Value))
        {
            SanitizeSchemaNumericConstraints(property);
        }
        foreach (var child in concreteSchema.AnyOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            SanitizeSchemaNumericConstraints(child);
        }
        foreach (var child in concreteSchema.OneOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            SanitizeSchemaNumericConstraints(child);
        }
        foreach (var child in concreteSchema.AllOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            SanitizeSchemaNumericConstraints(child);
        }
        SanitizeSchemaNumericConstraints(concreteSchema.Items);
        SanitizeSchemaNumericConstraints(concreteSchema.AdditionalProperties);
    }

    private static void InferSchemaLargeIntegerFormats(
        IOpenApiSchema? schema,
        string? propertyName,
        string? inheritedTitle,
        string? inheritedDescription)
    {
        if (schema is not OpenApiSchema concreteSchema)
        {
            return;
        }

        if (ShouldInferInt64(
                concreteSchema,
                propertyName,
                inheritedTitle,
                inheritedDescription))
        {
            concreteSchema.Format = "int64";
        }

        foreach (var property in (concreteSchema.Properties ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal))
        {
            InferSchemaLargeIntegerFormats(
                property.Value,
                property.Key,
                concreteSchema.Title,
                concreteSchema.Description);
        }
        foreach (var child in concreteSchema.AnyOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            InferSchemaLargeIntegerFormats(
                child,
                propertyName,
                concreteSchema.Title ?? inheritedTitle,
                concreteSchema.Description ?? inheritedDescription);
        }
        foreach (var child in concreteSchema.OneOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            InferSchemaLargeIntegerFormats(
                child,
                propertyName,
                concreteSchema.Title ?? inheritedTitle,
                concreteSchema.Description ?? inheritedDescription);
        }
        foreach (var child in concreteSchema.AllOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            InferSchemaLargeIntegerFormats(
                child,
                propertyName,
                concreteSchema.Title ?? inheritedTitle,
                concreteSchema.Description ?? inheritedDescription);
        }
        InferSchemaLargeIntegerFormats(
            concreteSchema.Items,
            propertyName,
            concreteSchema.Title ?? inheritedTitle,
            concreteSchema.Description ?? inheritedDescription);
        InferSchemaLargeIntegerFormats(
            concreteSchema.AdditionalProperties,
            propertyName,
            concreteSchema.Title ?? inheritedTitle,
            concreteSchema.Description ?? inheritedDescription);
    }

    private static bool ShouldInferInt64(
        OpenApiSchema schema,
        string? propertyName,
        string? inheritedTitle,
        string? inheritedDescription)
    {
        var isInteger = (schema.Type & JsonSchemaType.Integer) == JsonSchemaType.Integer;
        if (!isInteger || !string.IsNullOrWhiteSpace(schema.Format))
        {
            return false;
        }

        return ExceedsInt32Range(schema.Minimum) ||
               ExceedsInt32Range(schema.Maximum) ||
               ExceedsInt32Range(schema.ExclusiveMinimum) ||
               ExceedsInt32Range(schema.ExclusiveMaximum) ||
               ExceedsInt32Range(schema.Default) ||
               ExceedsInt32Range(schema.Example) ||
               HasLargeIntegerHint(
                   propertyName,
                   schema.Title ?? inheritedTitle,
                   schema.Description ?? inheritedDescription);
    }

    private static bool ExceedsInt32Range(string? value)
    {
        if (string.IsNullOrWhiteSpace(value) ||
            !decimal.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
        {
            return false;
        }

        return parsed < int.MinValue || parsed > int.MaxValue;
    }

    private static bool ExceedsInt32Range(JsonNode? value)
    {
        if (!TryGetIntegerValue(value, out var parsed))
        {
            return false;
        }

        return parsed < int.MinValue || parsed > int.MaxValue;
    }

    private static bool TryGetIntegerValue(
        JsonNode? value,
        out long parsed)
    {
        parsed = 0;

        if (value is not JsonValue jsonValue)
        {
            return false;
        }

        if (jsonValue.TryGetValue<long>(out parsed))
        {
            return true;
        }

        if (jsonValue.TryGetValue<int>(out var intValue))
        {
            parsed = intValue;
            return true;
        }

        if (jsonValue.TryGetValue<decimal>(out var decimalValue) &&
            decimal.Truncate(decimalValue) == decimalValue &&
            decimalValue >= long.MinValue &&
            decimalValue <= long.MaxValue)
        {
            parsed = (long)decimalValue;
            return true;
        }

        if (jsonValue.TryGetValue<string>(out var stringValue) &&
            long.TryParse(stringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out parsed))
        {
            return true;
        }

        return false;
    }

    private static bool HasLargeIntegerHint(
        string? propertyName,
        string? title,
        string? description)
    {
        return HasLargeIntegerHintInAny(propertyName) ||
               HasLargeIntegerHintInAny(title) ||
               HasLargeIntegerHintInAny(description);
    }

    [SuppressMessage("Usage", "CA2249:Consider using 'string.Contains' instead of 'string.IndexOf'", Justification = "StringComparison overloads must remain compatible with older target frameworks.")]
    private static bool HasLargeIntegerHintInAny(string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        if (text!.IndexOf("nanosecond", StringComparison.OrdinalIgnoreCase) >= 0 ||
            text.IndexOf(" byte", StringComparison.OrdinalIgnoreCase) >= 0 ||
            text.IndexOf("bytes", StringComparison.OrdinalIgnoreCase) >= 0)
        {
            return true;
        }

        if ((text.IndexOf("unix", StringComparison.OrdinalIgnoreCase) >= 0 ||
             text.IndexOf("epoch", StringComparison.OrdinalIgnoreCase) >= 0) &&
            (text.IndexOf("millisecond", StringComparison.OrdinalIgnoreCase) >= 0 ||
             text.IndexOf("unix_ms", StringComparison.OrdinalIgnoreCase) >= 0 ||
             text.IndexOf("unix ms", StringComparison.OrdinalIgnoreCase) >= 0))
        {
            return true;
        }

        return false;
    }

    public static void SanitizeDiscriminators(this OpenApiDocument document)
    {
        document = document ?? throw new ArgumentNullException(nameof(document));

        var componentIds = new HashSet<string>(
            document.Components?.Schemas?.Keys ?? Enumerable.Empty<string>(),
            StringComparer.Ordinal);

        foreach (var schema in (document.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal).Select(x => x.Value))
        {
            SanitizeSchemaDiscriminators(schema, componentIds);
        }
    }

    private static void SanitizeSchemaDiscriminators(
        IOpenApiSchema? schema,
        ISet<string> componentIds)
    {
        if (schema is not OpenApiSchema concreteSchema)
        {
            return;
        }

        if (concreteSchema.Discriminator?.Mapping is { Count: > 0 } mapping)
        {
            var validMappings = mapping
                .Where(x => x.Value.Reference?.Id is { } id && componentIds.Contains(id))
                .ToDictionary(x => x.Key, x => x.Value, StringComparer.Ordinal);
            var hasCompositionChildren =
                (concreteSchema.OneOf?.Count ?? 0) > 0 ||
                (concreteSchema.AnyOf?.Count ?? 0) > 0 ||
                (concreteSchema.AllOf?.Count ?? 0) > 0;

            if (validMappings.Count == 0 && !hasCompositionChildren)
            {
                concreteSchema.Discriminator = null;
            }
            else if (validMappings.Count > 0 && validMappings.Count != mapping.Count)
            {
                concreteSchema.Discriminator = new OpenApiDiscriminator
                {
                    PropertyName = concreteSchema.Discriminator.PropertyName,
                    Mapping = validMappings,
                };
            }
        }

        foreach (var property in (concreteSchema.Properties ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal).Select(x => x.Value))
        {
            SanitizeSchemaDiscriminators(property, componentIds);
        }
        foreach (var child in concreteSchema.AnyOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            SanitizeSchemaDiscriminators(child, componentIds);
        }
        foreach (var child in concreteSchema.OneOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            SanitizeSchemaDiscriminators(child, componentIds);
        }
        foreach (var child in concreteSchema.AllOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            SanitizeSchemaDiscriminators(child, componentIds);
        }
        SanitizeSchemaDiscriminators(concreteSchema.Items, componentIds);
        SanitizeSchemaDiscriminators(concreteSchema.AdditionalProperties, componentIds);
    }

    private static bool IsOutOfRange(string? value, decimal bound, bool isMin)
    {
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }

        return decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var parsed) &&
               (isMin ? parsed < bound : parsed > bound);
    }

    private static (decimal Min, decimal Max) GetTypeRange(OpenApiSchema schema)
    {
        var isInteger = (schema.Type & JsonSchemaType.Integer) == JsonSchemaType.Integer;
        if (!isInteger)
        {
            return (decimal.MinValue, decimal.MaxValue);
        }

        return string.Equals(schema.Format, "int32", StringComparison.OrdinalIgnoreCase)
            ? (int.MinValue, int.MaxValue)
            : (long.MinValue, long.MaxValue);
    }
    
    public static void InjectBaseUrl(
        this OpenApiDocument openApiDocument,
        Settings settings)
    {
        openApiDocument.InjectBaseUrl(settings.ToCoreSettings());
    }

    public static void InjectBaseUrl(
        this OpenApiDocument openApiDocument,
        CoreSettings settings)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));

        if (!Uri.TryCreate(settings.BaseUrl, UriKind.Absolute, out _))
        {
            Console.WriteLine($"Invalid base URL '{settings.BaseUrl}'. Expected an absolute URL (e.g., 'https://api.example.com'). Skipping base URL injection.");
            return;
        }

        openApiDocument.Servers!.Insert(0, new OpenApiServer
        {
            Url = settings.BaseUrl,
        });
    }

    public static void InjectSecuritySchemes(
        this OpenApiDocument openApiDocument,
        Settings settings)
    {
        openApiDocument.InjectSecuritySchemes(settings.ToCoreSettings());
    }

    public static void InjectSecuritySchemes(
        this OpenApiDocument openApiDocument,
        CoreSettings settings)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));

        openApiDocument.Components!.SecuritySchemes ??= new Dictionary<string, IOpenApiSecurityScheme>();

        foreach (var scheme in settings.SecuritySchemes)
        {
            var parts = scheme.Split(':');
            if (parts.Length != 3)
            {
                Console.WriteLine($"Invalid security scheme format '{scheme}'. Expected 'Type:Location:Name' (e.g., 'ApiKey:Header:x-api-key').");
                continue;
            }

            var typePart = parts[0];
            var locationPart = parts[1];
            var namePart = parts[2];

            if (!Enum.TryParse<SecuritySchemeType>(typePart, ignoreCase: true, out var schemeType))
            {
                Console.WriteLine($"Invalid security scheme type '{typePart}'. Expected: ApiKey, Http, OAuth2, OpenIdConnect.");
                continue;
            }

            if (!Enum.TryParse<ParameterLocation>(locationPart, ignoreCase: true, out var location))
            {
                Console.WriteLine($"Invalid parameter location '{locationPart}'. Expected: Header, Query, Cookie.");
                continue;
            }

            string schemeName;
            var securityScheme = new OpenApiSecurityScheme();

            if (schemeType == SecuritySchemeType.Http)
            {
                schemeName = $"http_{ToInvariantLowercase(namePart)}";
                securityScheme.Type = SecuritySchemeType.Http;
                securityScheme.Scheme = namePart;
                securityScheme.In = location;
            }
            else
            {
                schemeName = $"apikey_{ToInvariantLowercase(namePart)}";
                securityScheme.Type = schemeType;
                securityScheme.In = location;
                securityScheme.Name = namePart;
            }

            openApiDocument.AddComponent(schemeName, securityScheme);

            var schemeRef = new OpenApiSecuritySchemeReference(schemeName, openApiDocument);
            openApiDocument.Security!.Add(new OpenApiSecurityRequirement
            {
                [schemeRef] = new List<string>(),
            });
        }
    }

    public static OpenApiDocument Simplify(
        this OpenApiDocument openApiDocument)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        var schemasToRemove = new List<KeyValuePair<string, IOpenApiSchema>>();
        var schemasToAdd = new List<KeyValuePair<string, IOpenApiSchema>>();
        foreach (var schema in (openApiDocument.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal))
        {
            // If schema is OneOf and all children have only one enum value, combine them into one schema.
            if (schema.Value.IsOneOf() &&
                (schema.Value.OneOf ?? []).All(child =>
                    (child.Properties ?? new Dictionary<string, IOpenApiSchema>()).Any(subChild =>
                        subChild.Value.IsEnum() &&
                        (subChild.Value.Enum?.Count ?? 0) == 1)))
            {
                var subChildren = (schema.Value.OneOf ?? [])
                    .Select(child =>
                        (child.Properties ?? new Dictionary<string, IOpenApiSchema>()).First(subChild =>
                            subChild.Value.IsEnum() &&
                            (subChild.Value.Enum?.Count ?? 0) == 1))
                    .ToList();
                var newEnum = new OpenApiSchema
                {
                    Enum = subChildren
                        .Where(x => x.Value.Enum != null)
                        .Select(x => x.Value.Enum!.First())
                        .ToArray(),
                    Type = JsonSchemaType.String,
                }.WithKey(schema.Key.ToPropertyName() + subChildren.First().Key.ToPropertyName());
                schemasToAdd.Add(newEnum);

                foreach (var child in schema.Value.OneOf ?? [])
                {
                    var subChild = (child.Properties ?? new Dictionary<string, IOpenApiSchema>()).First(subChild =>
                        subChild.Value.IsEnum() &&
                        (subChild.Value.Enum?.Count ?? 0) == 1);
                    child.Properties?.Remove(subChild.Key);
                    // In OpenApi 3.0+, create a reference using OpenApiSchemaReference
                    var newSubChild = new KeyValuePair<string, IOpenApiSchema>(
                        subChild.Key,
                        new OpenApiSchemaReference(newEnum.Key, openApiDocument, string.Empty));
                    child.Properties?.Add(newSubChild.Key, newSubChild.Value);

                    // Old Code for Microsoft.OpenApi 1.x
                    //newSubChild.Value.Extensions["x-original-schema"] = new OpenApiString(
                    //    subChild.Value.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0));
                    // Note: SerializeAsYaml extension method was removed in Microsoft.OpenApi 3.0
                    // The x-original-schema extension is optional metadata, skipping for now
                }

                // Remove duplicated schemas from OneOf.
                // Skip schemas with references.
                var oneOfCollection = schema.Value.OneOf ?? [];
                if (oneOfCollection.Any(x => !x.IsSchemaReference()))
                {
                    var duplicatedSchemas = new List<IOpenApiSchema>();
                    foreach (var group in oneOfCollection
                                 .GroupBy(x => (x.Properties ?? new Dictionary<string, IOpenApiSchema>())
                                     .Select(y => (y.Key, y.Value.Type, y.Value.Format, y.Value.GetReferenceId()))
                                     .ToImmutableArray().AsEquatableArray())
                                 .Where(x => x.Count() > 1))
                    {
                        var first = group.First();
                        foreach (var schemaToRemove in group.Skip(1))
                        {
                            if (first.ResolveSchema() is { } firstResolved &&
                                schemaToRemove.ResolveSchema() is { } toRemoveResolved)
                            {
                                firstResolved.Description += $"\n{toRemoveResolved.Description}";
                            }
                            duplicatedSchemas.Add(schemaToRemove);
                        }
                    }

                    foreach (var duplicatedSchema in duplicatedSchemas)
                    {
                        schema.Value.OneOf?.Remove(duplicatedSchema);
                    }
                }

                // Simplify OneOf with only one schema.
                if ((schema.Value.OneOf?.Count ?? 0) == 1)
                {
                    schemasToRemove.Add(schema);
                    schemasToAdd.Add(new KeyValuePair<string, IOpenApiSchema>(
                        schema.Key,
                        schema.Value.OneOf!.First()));
                }
            }
        }
        foreach (var schema in schemasToRemove)
        {
            openApiDocument.Components?.Schemas?.Remove(schema.Key);
        }
        foreach (var schema in schemasToAdd)
        {
            openApiDocument.Components?.Schemas?.Add(schema.Key, schema.Value);
        }

        return openApiDocument;
    }

    public static OpenApiDocument SimplifyAllOf(
        this OpenApiDocument openApiDocument)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));

        foreach (var schema in (openApiDocument.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal))
        {
            var propertiesToAdd = new List<KeyValuePair<string, IOpenApiSchema>>();
            var propertiesToRemove = new List<string>();
            foreach (var property in (schema.Value.Properties ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal))
            {
                if ((property.Value.AllOf?.Count ?? 0) == 1)
                {
                    var firstAllOfSchema = property.Value.AllOf!.First();
                    propertiesToAdd.Add(new KeyValuePair<string, IOpenApiSchema>(property.Key, firstAllOfSchema));
                    propertiesToRemove.Add(property.Key);
                }
            }

            foreach (var propertyKey in propertiesToRemove)
            {
                schema.Value.Properties?.Remove(propertyKey);
            }
            foreach (var property in propertiesToAdd)
            {
                schema.Value.Properties?.Add(property.Key, property.Value);
            }
        }

        return openApiDocument;
    }
    
    public static OpenApiDocument ComputeDiscriminators(
        this OpenApiDocument openApiDocument)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        foreach (var schema in (openApiDocument.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal))
        {
            ProcessSchema(schema.Value, path: $"#/components/schemas/{schema.Key}", depth: 0);
        }
        
        return openApiDocument;
    }
    
    public static OpenApiDocument AddMissingPathParameters(
        this OpenApiDocument openApiDocument)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        foreach (var path in openApiDocument.Paths ?? new OpenApiPaths())
        {
            foreach (var operation in path.Value.Operations ?? new Dictionary<System.Net.Http.HttpMethod, OpenApiOperation>())
            {
                var parametersFromPath = PathHelper.ExtractParameters(path.Key.AsSpan());
                var parametersFromSpec = (operation.Value.Parameters ?? new List<IOpenApiParameter>())
                    .Where(x => x.In == ParameterLocation.Path)
                    .Select(x => x.Name)
                    .ToImmutableHashSet();
                foreach (var parameter in parametersFromPath)
                {
                    if (!parametersFromSpec.Contains(parameter))
                    {
                        (operation.Value.Parameters ??= new List<IOpenApiParameter>()).Add(new OpenApiParameter
                        {
                            Name = parameter,
                            In = ParameterLocation.Path,
                            Required = true,
                            Description = "This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
                            Schema = new OpenApiSchema
                            {
                                Type = JsonSchemaType.String,
                            },
                        });
                        
                        Console.WriteLine($"Missing path parameter '{parameter}' was added to operation '{operation.Key}' in path '{path.Key}'.");
                    }
                }
            }
        }
        
        return openApiDocument;
    }

    private static void ProcessSchema(IOpenApiSchema schema, string path, int depth)
    {
        if (depth > 10)
        {
            return;
        }

        var refId = schema.GetReferenceId();
        if (refId != null)
        {
            path = $"#/components/schemas/{refId}";
        }

        foreach (var property in (schema.Properties ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal))
        {
            ProcessSchema(property.Value, path: path + "/properties/" + property.Key, depth: depth + 1);
        }

        // Remove any nested OneOfs
        var schemasToRemove = new List<IOpenApiSchema>();
        var schemasToAdd = new List<IOpenApiSchema>();
        foreach (var value in (schema.OneOf ?? []).Where(x => (x.OneOf?.Count ?? 0) > 0))
        {
            foreach (var child in value.OneOf ?? [])
            {
                schemasToAdd.Add(child);
            }
            schemasToRemove.Add(value);
        }
        schemasToRemove.ForEach(x =>
        {
            schema.OneOf?.Remove(x);

            // Old Code for Microsoft.OpenApi 1.x
            // if (x.Reference?.Id != null)
            // {
            //     x.Reference?.HostDocument?.Components.Schemas.Remove(x.Reference.Id);
            // }

            // For reference cleanup, we need to handle differently in new API
            if (x is OpenApiSchemaReference schemaRef && schemaRef.Reference?.Id != null)
            {
                // Note: Direct document manipulation is different in new API
            }
        });
        schemasToAdd.ForEach(x => schema.OneOf?.Add(x));

        foreach (var value in schema.OneOf ?? [])
        {
            ProcessSchema(value, path: path + "/oneOf", depth: depth + 1);
        }
        foreach (var value in schema.AllOf ?? [])
        {
            ProcessSchema(value, path: path + "/allOf", depth: depth + 1);
        }
        foreach (var value in schema.AnyOf ?? [])
        {
            ProcessSchema(value, path: path + "/anyOf", depth: depth + 1);
        }
        if (schema.Items != null)
        {
            ProcessSchema(schema.Items, path: path + "/items", depth: depth + 1);
        }

        // Auto-detection in OpenAI-like specs
        if (schema.Discriminator == null &&
            (schema.OneOf?.Count ?? 0) > 1 &&
            schema.OneOf!.All(y => (y.ResolveIfRequired().Properties ?? new Dictionary<string, IOpenApiSchema>()).Any(z => z.Value.Enum is { Count: 1 })))
        {
            var oneOfSchemas = schema.OneOf!;
            var discriminatorPropertyName = (oneOfSchemas.First().Properties ?? new Dictionary<string, IOpenApiSchema>())
                .FirstOrDefault(y => y.Value.Enum is { Count: 1 }).Key;
            var uniqueKeys = new HashSet<string>(oneOfSchemas
                .Where(x => (x.Properties ?? new Dictionary<string, IOpenApiSchema>()).ContainsKey(discriminatorPropertyName ?? string.Empty))
                .Select(x => (x.Properties ?? new Dictionary<string, IOpenApiSchema>())[discriminatorPropertyName!].Enum?.FirstOrDefault()?.GetString() ?? string.Empty));
            if (discriminatorPropertyName != null && uniqueKeys.Count == oneOfSchemas.Count)
            {
                // Old Code for Microsoft.OpenApi 1.x
                // schema.Discriminator = new OpenApiDiscriminator
                // {
                //     PropertyName = discriminatorPropertyName,
                //     Mapping = new HashSet<(string Key, string Path)>(schema.OneOf
                //             .Select((x, i) => (
                //                 x.Properties[discriminatorPropertyName].Enum.First().GetString() ?? string.Empty,
                //                 x.Reference?.Id != null ? $"#/components/schemas/{x.Reference?.Id}" : path + "/oneOf/" + i))
                //             .Where(x => !string.IsNullOrWhiteSpace(x.Item1)))
                //         .ToDictionary(x => x.Key, x => x.Path),
                // };

                if (schema.ResolveSchema() is { } resolvedSchema)
                {
                    // Note: In OpenAPI 3.0+, Mapping is IDictionary<string, OpenApiSchemaReference>
                    // Creating proper references requires document context which we don't have here
                    // The discriminator property name is still set, which is the most important part
                    resolvedSchema.Discriminator = new OpenApiDiscriminator
                    {
                        PropertyName = discriminatorPropertyName,
                        // Mapping would require OpenApiSchemaReference objects with document context
                    };
                }
            }
        }
    }

    /// <summary>
    /// OpenAPI doesn't allow metadata for references so sometimes allOf with single item is used to add metadata.
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static bool HasAllOfTypeForMetadata(
        this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        return context.Schema.HasAllOfTypeForMetadata(propertyName: context.PropertyName);
    }

    /// <summary>
    /// OpenAPI doesn't allow metadata for references so sometimes allOf with single item is used to add metadata.
    /// </summary>
    /// <param name="schema"></param>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static bool HasAllOfTypeForMetadata(
        this IOpenApiSchema schema,
        string? propertyName)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));
        
        return propertyName is not null &&
               (schema.AnyOf?.Count == 1 ||
               schema.AllOf?.Count == 1 ||
               schema.OneOf?.Count == 1) &&
               (schema.Properties?.Count ?? 0) == 0;
    }
    
    public static string GetSummary(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Use x-label as fallback when description is missing
        var description = schema.Description;
        if (string.IsNullOrWhiteSpace(description) &&
            TryGetExtensionStringValue(schema.Extensions, "x-label", out var label) &&
            !string.IsNullOrWhiteSpace(label))
        {
            description = label;
        }

        // Remove any XML tags from the description
        var summary = description?.ClearForXml() ?? string.Empty;
        var @default = schema.Default.GetString()?.ClearForXml();
        if (!string.IsNullOrWhiteSpace(@default))
        {
            if (!string.IsNullOrWhiteSpace(summary))
            {
                summary += "\n";
            }

            summary += $"Default Value: {@default}";
        }
        
        if (schema.ReadOnly)
        {
            if (!string.IsNullOrWhiteSpace(summary))
            {
                summary += "\n";
            }

            summary += "Included only in responses";
        }
        if (schema.WriteOnly)
        {
            if (!string.IsNullOrWhiteSpace(summary))
            {
                summary += "\n";
            }

            summary += "Included only in requests";
        }

        var example = schema.Example.GetString()?.ClearForXml();
        if (!string.IsNullOrWhiteSpace(example))
        {
            if (!string.IsNullOrWhiteSpace(summary))
            {
                summary += "\n";
            }

            summary += $"Example: {example}";
        }

        return summary;
    }

    public static string GetXmlDocumentationSummary(this OpenApiOperation operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        // Remove any XML tags from the description
        var summary = operation.Summary?.ClearForXml() ?? string.Empty;
        var description = operation.Description?.ClearForXml();
        if (!string.IsNullOrWhiteSpace(description))
        {
            if (!string.IsNullOrWhiteSpace(summary))
            {
                summary += "\n";
            }
            
            summary += $"{description}";
        }

        return summary;
    }

    public static string GetExperimentalStage(this OpenApiOperation operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (TryGetExtensionString(operation.Extensions, "x-stage", out var stageString))
        {
            return NormalizeExperimentalStage(stageString);
        }

        if (TryGetExtensionBoolean(operation.Extensions, "x-alpha"))
        {
            return "Alpha";
        }

        if (TryGetExtensionBoolean(operation.Extensions, "x-beta"))
        {
            return "Beta";
        }

        if (TryGetAvailability(operation.Extensions, out var availability))
        {
            return NormalizeExperimentalStage(availability);
        }

        return GetExperimentalStageFromSummary(operation.Summary);
    }

    public static bool IsDeprecated(this OpenApiOperation operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        return operation.Deprecated ||
               TryGetAvailability(operation.Extensions, out var availability) &&
               string.Equals(availability, "Deprecated", StringComparison.Ordinal);
    }

    public static bool IsDeprecated(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Deprecated ||
               TryGetAvailability(schema.Extensions, out var availability) &&
               string.Equals(availability, "Deprecated", StringComparison.Ordinal);
    }

    /// <summary>
    /// Gets a custom deprecation message from x-stainless-deprecation-message extension.
    /// </summary>
    public static string GetDeprecationMessage(this OpenApiOperation operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (TryGetExtensionString(operation.Extensions, "x-stainless-deprecation-message", out var message))
        {
            return message;
        }

        return string.Empty;
    }

    /// <summary>
    /// Gets a custom deprecation message from x-stainless-deprecation-message extension on a schema.
    /// </summary>
    public static string GetDeprecationMessage(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        if (TryGetExtensionString(schema.Extensions, "x-stainless-deprecation-message", out var message))
        {
            return message;
        }

        return string.Empty;
    }

    public static string GetExperimentalStageFromSummary(this string? summary)
    {
        if (string.IsNullOrWhiteSpace(summary))
        {
            return string.Empty;
        }

        var trimmed = summary!.TrimStart();

        foreach (var (prefix, stage) in ExperimentalStagePrefixes)
        {
            if (trimmed.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                return stage;
            }
        }

        return string.Empty;
    }

    public static string StripExperimentalStagePrefix(this string? summary)
    {
        if (string.IsNullOrWhiteSpace(summary))
        {
            return string.Empty;
        }

        var trimmed = summary!.Trim();

        foreach (var (prefix, _) in ExperimentalStagePrefixes)
        {
            if (!trimmed.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var remainder = trimmed.Substring(prefix.Length).TrimStart(' ', '\t', ':', '-', '_');
            return string.IsNullOrWhiteSpace(remainder) ? trimmed : remainder;
        }

        return trimmed;
    }

    public static string ClearForXml(this string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));

        return text
            .Replace("\r\n", "\n")
            .Replace("<br>", string.Empty)
            .Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;");
    }

    public static string ClearForCSharp(this string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));

        return text
            .Replace("\"", "\"\"")
            .Trim();
    }

    public static string? GetString(this JsonNode? any)
    {
        if (any == null)
        {
            return null;
        }

        return any switch
        {
            // Old Code for Microsoft.OpenApi 1.x
            //OpenApiObject @object => $"{{{string.Join(", ", @object.Select(x => $"{x.Key}: {GetString(x.Value)}"))}}}",


            JsonValue value when value.TryGetValue<string>(out var s) => string.IsNullOrWhiteSpace(s) ? null : s,
            JsonValue value when value.TryGetValue<int>(out var i) => i.ToString(CultureInfo.InvariantCulture),
            JsonValue value when value.TryGetValue<long>(out var l) => l.ToString(CultureInfo.InvariantCulture) + "L",
            JsonValue value when value.TryGetValue<float>(out var f) => f.ToString(CultureInfo.InvariantCulture) + "F",
            JsonValue value when value.TryGetValue<double>(out var d) => d.ToString(CultureInfo.InvariantCulture),
            JsonValue value when value.TryGetValue<bool>(out var b) => b ? "true" : "false",
            JsonArray array => $"[{string.Join(", ", array.Select(GetString))}]",
            _ => any.ToJsonString(),
        };
    }

    public static KeyValuePair<string, IOpenApiSchema> WithKey(
        this IOpenApiSchema schema,
        string key)
    {
        return new KeyValuePair<string, IOpenApiSchema>(key, schema);
    }

    public static string ReplacePlusAndMinusOnStart(
        this string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));
        
        text = text.StartsWith("-", StringComparison.Ordinal)
            ? "Minus" + text.TrimStart('-')
            : text;
        text = text.StartsWith("+", StringComparison.Ordinal)
            ? "Plus" + text.TrimStart('+')
            : text;

        return text;
    }
    
    private static readonly (string Prefix, string Stage)[] ExperimentalStagePrefixes =
    [
        ("[Alpha]", "Alpha"),
        ("[Beta]", "Beta"),
        ("[Experimental]", "Experimental"),
        ("Alpha", "Alpha"),
        ("Beta", "Beta"),
        ("Experimental", "Experimental"),
    ];

    private static string NormalizeExperimentalStage(string? stage)
    {
        var normalized = stage?.Trim() ?? string.Empty;
        if (normalized.Length == 0)
        {
            return string.Empty;
        }

        if (normalized.Equals("Alpha", StringComparison.OrdinalIgnoreCase)) return "Alpha";
        if (normalized.Equals("Beta", StringComparison.OrdinalIgnoreCase)) return "Beta";
        if (normalized.Equals("Experimental", StringComparison.OrdinalIgnoreCase)) return "Experimental";
        if (normalized.Equals("Generally-Available", StringComparison.OrdinalIgnoreCase)) return string.Empty;
        if (normalized.Equals("Deprecated", StringComparison.OrdinalIgnoreCase)) return string.Empty;
        return normalized;
    }

    private static string NormalizeAvailability(string? availability)
    {
        var normalized = availability?.Trim() ?? string.Empty;
        if (normalized.Length == 0)
        {
            return string.Empty;
        }

        if (normalized.Equals("Alpha", StringComparison.OrdinalIgnoreCase)) return "Alpha";
        if (normalized.Equals("Beta", StringComparison.OrdinalIgnoreCase)) return "Beta";
        if (normalized.Equals("Deprecated", StringComparison.OrdinalIgnoreCase)) return "Deprecated";
        if (normalized.Equals("Generally-Available", StringComparison.OrdinalIgnoreCase)) return "GenerallyAvailable";
        return normalized;
    }

    private static bool TryGetAvailability(IDictionary<string, IOpenApiExtension>? extensions, out string availability)
    {
        availability = string.Empty;

        if (!TryGetExtensionString(extensions, "x-fern-availability", out var rawAvailability))
        {
            return false;
        }

        availability = NormalizeAvailability(rawAvailability);
        return !string.IsNullOrWhiteSpace(availability);
    }

    private static bool TryGetExtensionString(
        IDictionary<string, IOpenApiExtension>? extensions,
        string name,
        out string value)
    {
        value = string.Empty;

        if (!(extensions?.TryGetValue(name, out var extension) ?? false))
        {
            return false;
        }

        if (TryGetJsonString(extension, out var stringValue))
        {
            value = stringValue;
            return true;
        }

        return false;
    }

    private static bool TryGetExtensionBoolean(
        IDictionary<string, IOpenApiExtension>? extensions,
        string name)
    {
        if (!(extensions?.TryGetValue(name, out var extension) ?? false))
        {
            return false;
        }

        return TryGetJsonBoolean(extension, out var booleanValue) && booleanValue;
    }

    private static bool TryGetJsonString(IOpenApiExtension extension, out string value)
    {
        value = string.Empty;

        var node = extension switch
        {
            JsonValue jsonValue => jsonValue,
            JsonNodeExtension jsonNodeExtension => jsonNodeExtension.Node,
            _ => null,
        };

        if (node is JsonValue stringNode &&
            stringNode.TryGetValue<string>(out var stringValue) &&
            !string.IsNullOrWhiteSpace(stringValue))
        {
            value = stringValue;
            return true;
        }

        return false;
    }

    private static bool TryGetJsonBoolean(IOpenApiExtension extension, out bool value)
    {
        value = false;

        var node = extension switch
        {
            JsonValue jsonValue => jsonValue,
            JsonNodeExtension jsonNodeExtension => jsonNodeExtension.Node,
            _ => null,
        };

        if (node is JsonValue booleanNode &&
            booleanNode.TryGetValue<bool>(out var booleanValue))
        {
            value = booleanValue;
            return true;
        }

        return false;
    }

    /// <summary>
    /// Public helper to extract a string value from an OpenAPI extension.
    /// Used by naming generators and other extension-processing code.
    /// </summary>
    public static bool TryGetExtensionStringValue(IOpenApiExtension extension, out string value)
    {
        return TryGetJsonString(extension, out value);
    }

    /// <summary>
    /// Public helper to extract a JsonNode from an OpenAPI extension.
    /// </summary>
    public static JsonNode? TryGetExtensionJsonNode(IOpenApiExtension extension)
    {
        return extension switch
        {
            JsonNode jsonNode => jsonNode,
            JsonNodeExtension jsonNodeExtension => jsonNodeExtension.Node,
            _ => null,
        };
    }

    /// <summary>
    /// Public helper to extract a string value from an OpenAPI extensions dictionary by key.
    /// </summary>
    public static bool TryGetExtensionStringValue(
        IDictionary<string, IOpenApiExtension>? extensions,
        string name,
        out string value)
    {
        return TryGetExtensionString(extensions, name, out value);
    }

    /// <summary>
    /// Public helper to check a boolean OpenAPI extension value.
    /// </summary>
    public static bool GetExtensionBooleanValue(
        IDictionary<string, IOpenApiExtension>? extensions,
        string name)
    {
        return TryGetExtensionBoolean(extensions, name);
    }

    public static string[] FindAllOperationIdsForTag(
        this OpenApiDocument openApiDocument,
        string tag)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        return (openApiDocument.Paths ?? new OpenApiPaths())
            .SelectMany(path => path.Value.Operations ?? new Dictionary<System.Net.Http.HttpMethod, OpenApiOperation>())
            .Where(x => x.Value.Tags?.Any(y => y.Name == tag) != false)
            .Where(x => x.Value.OperationId != null)
            .Select(x => x.Value.OperationId!)
            .ToArray();
    }

    private static string ToInvariantLowercase(string value)
    {
        value = value ?? throw new ArgumentNullException(nameof(value));
        var chars = value.ToCharArray();
        for (var i = 0; i < chars.Length; i++)
        {
            chars[i] = char.ToLowerInvariant(chars[i]);
        }

        return new string(chars);
    }
}
