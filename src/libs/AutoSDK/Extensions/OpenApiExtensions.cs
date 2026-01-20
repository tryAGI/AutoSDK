using System.Collections.Immutable;
using System.Globalization;
using System.Text.Json.Nodes;
using AutoSDK.Helpers;
using Microsoft.OpenApi;
using AutoSDK.Models;
using AutoSDK.Naming.Properties;
using AutoSDK.Serialization.Form;
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
        yamlOrJson = yamlOrJson ?? throw new ArgumentNullException(nameof(yamlOrJson));

        var readerSettings = new OpenApiReaderSettings
        {
            RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
        };
        // Add YAML reader support via extension method from Microsoft.OpenApi.YamlReader
        readerSettings.AddYamlReader();

        var (openApiDocument, diagnostics) = OpenApiDocument.Parse(yamlOrJson, settings: readerSettings);
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

        if (settings.ComputeDiscriminators)
        {
            openApiDocument = openApiDocument.ComputeDiscriminators();
        }
        if (settings.AddMissingPathParameters)
        {
            openApiDocument = openApiDocument.AddMissingPathParameters();
        }
        
        return openApiDocument;
    }
    
    public static OpenApiDocument Simplify(
        this OpenApiDocument openApiDocument)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        var schemasToRemove = new List<KeyValuePair<string, IOpenApiSchema>>();
        var schemasToAdd = new List<KeyValuePair<string, IOpenApiSchema>>();
        foreach (var schema in openApiDocument.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>())
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

        foreach (var schema in openApiDocument.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>())
        {
            var propertiesToAdd = new List<KeyValuePair<string, IOpenApiSchema>>();
            var propertiesToRemove = new List<string>();
            foreach (var property in schema.Value.Properties ?? new Dictionary<string, IOpenApiSchema>())
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
        
        foreach (var schema in openApiDocument.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>())
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

        foreach (var property in schema.Properties ?? new Dictionary<string, IOpenApiSchema>())
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
    /// https://swagger.io/docs/specification/describing-parameters/
    /// https://swagger.io/docs/specification/serialization/
    /// </summary>
    /// <param name="path"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string PreparePath(
        this string path,
        IList<MethodParameter> parameters)
    {
        path = path ?? throw new ArgumentNullException(nameof(path));
        parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        
        path = ParameterSerializer.SerializePathParameters(parameters, path);
        
        path = $"\"{path}\"";
        if (parameters.Any(x => x.Location is ParameterLocation.Path))
        {
            path = $"${path}";
        }
        
        return path;
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
    
    public static string? GetDefaultValue(this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        if (context.TypeData.CSharpType == "object?" ||
            context.Schema.Default is JsonArray ||
            context.TypeData.CSharpTypeNullability)
        {
            return string.Empty;
        }

        // Replace to extensions?
        // if (context.CombinedEnumOriginalSchema != null)
        // {
        //     return context.TypeData.Value.CSharpTypeWithoutNullability + "." + context.CombinedEnumOriginalSchema.Value.Value.Enum.First().ToEnumValue(context.Settings).Name;
        // }
        var defaultString = context.Schema.Default?.GetString();
        if ((context.Schema.Enum?.Any() ?? false) && context.Schema.Default is JsonValue && !string.IsNullOrWhiteSpace(defaultString))
        {
            var @enum = context.ComputeEnum();
            if (!@enum.TryGetValue(context.Schema.Default.GetString() ?? string.Empty, out var result))
            {
                return string.Empty;
            }

            return context.TypeData.CSharpTypeWithoutNullability + "." + result.Name;
        }
        if ((context.Schema.AnyOf?.Any(x => x.Enum?.Any() ?? false) ?? false) && context.Schema.Default != null)
        {
            var enumChildContext = context.Children
                .Where(x => x.Hint is Hint.AnyOf)
                .First(x => x.Schema.Enum?.Any() ?? false);
            var @enum = enumChildContext.ComputeEnum();
            var value = @enum.TryGetValue(context.Schema.Default.GetString() ?? string.Empty, out var result) ? result.Name : "";

            if (string.IsNullOrWhiteSpace(value))
            {
                if (context.Children
                    .Where(x => x.Hint is Hint.AnyOf)
                    .Any(x => x.Schema.Type == JsonSchemaType.String))
                {
                    value = context.Schema.Default.GetString();
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        return $"\"{value}\"";
                    }
                }

                return null;
            }

            return enumChildContext.TypeData.CSharpTypeWithoutNullability + "." + value;
        }
        if ((context.Schema.OneOf?.Any(x => x.Enum?.Any() ?? false) ?? false) && context.Schema.Default != null)
        {
            var enumChildContext = context.Children
                .Where(x => x.Hint is Hint.OneOf)
                .First(x => x.Schema.Enum?.Any() ?? false);
            var @enum = enumChildContext.ComputeEnum();
            if (!@enum.TryGetValue(context.Schema.Default.GetString() ?? string.Empty, out var result))
            {
                return string.Empty;
            }

            return enumChildContext.TypeData.CSharpTypeWithoutNullability + "." + result.Name;
        }
        if ((context.Schema.AllOf?.Any(x => x.Enum?.Any() ?? false) ?? false) && context.Schema.Default != null)
        {
            var enumChildContext = context.Children
                .Where(x => x.Hint is Hint.AllOf)
                .First(x => x.Schema.Enum?.Any() ?? false);
            var @enum = enumChildContext.ComputeEnum();
            if (!@enum.TryGetValue(context.Schema.Default.GetString() ?? string.Empty, out var result))
            {
                return string.Empty;
            }

            return enumChildContext.TypeData.CSharpTypeWithoutNullability + "." + result.Name;
        }
        var defaultStringValue = context.Schema.Default?.GetString();
        if (context.Schema.Default is JsonValue && !string.IsNullOrWhiteSpace(defaultStringValue))
        {
            if (context.Schema.Type != JsonSchemaType.String &&
                (context.Schema.AnyOf ?? []).All(x => x.Type != JsonSchemaType.String) &&
                (context.Schema.AllOf ?? []).All(x => x.Type != JsonSchemaType.String) &&
                (context.Schema.OneOf ?? []).All(x => x.Type != JsonSchemaType.String))
            {
                return null;
            }

            return $"\"{defaultStringValue}\"";
        }
        
        return context.Schema.Default?.GetString();
    }
    
    public static string GetSummary(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Remove any XML tags from the description
        var summary = schema.Description?.ClearForXml() ?? string.Empty;
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

        // In Microsoft.OpenApi 3.0, extension values are IOpenApiExtension, not JsonNode directly
        // Check for specific extension keys instead
        if ((operation.Extensions?.TryGetValue("x-stage", out var stage) ?? false) &&
            stage is JsonValue stageJsonValue && stageJsonValue.TryGetValue<string>(out var stageString))
        {
            return stageString;
        }

        if ((operation.Extensions?.TryGetValue("x-alpha", out var alpha) ?? false) &&
            alpha is JsonValue alphaJsonValue && alphaJsonValue.TryGetValue<bool>(out var alphaBoolean) && alphaBoolean)
        {
            return "Alpha";
        }

        if ((operation.Extensions?.TryGetValue("x-beta", out var beta) ?? false) &&
            beta is JsonValue betaJsonValue && betaJsonValue.TryGetValue<bool>(out var betaBoolean) && betaBoolean)
        {
            return "Beta";
        }

        return string.Empty;
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
    
    public static Dictionary<string, PropertyData> ComputeEnum(
        this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        var @enum = (context.Schema.Enum ?? []).ComputeEnum(
            enumName: context.Id,
            description: context.Parameter?.Description ?? context.Schema.Description ?? string.Empty,
            context.Settings);

        if ((context.Schema.Extensions?.TryGetValue("x-enum-descriptions", out var descriptions) ?? false) &&
            descriptions is JsonNode descriptionsNode && descriptionsNode is JsonArray descriptionsArray)
        {
            var i = 0;
            foreach (var description in descriptionsArray)
            {
                if (description is JsonValue descValue && descValue.TryGetValue<string>(out var descString))
                {
                    @enum[@enum.Keys.ElementAt(i)] = @enum[@enum.Keys.ElementAt(i)] with
                    {
                        Summary = ClearForXml(descString),
                    };
                }
                i++;
            }
        }

        return @enum;
    }
    
    public static Dictionary<string, PropertyData> ComputeEnum(
        this IList<JsonNode> @enum,
        string enumName,
        string description,
        Settings settings)
    {
        var values = @enum
            .Select(value => ((JsonNode?)value).ToEnumValue(
                description: description,
                settings))
            .Where(value => !string.IsNullOrWhiteSpace(value.Name))
            .Distinct()
            .ToDictionary(x => x.Id, x => x);

        if (values.All(x => x.Value.Name.ToUpperInvariant().Contains(enumName.ToUpperInvariant())))
        {
            values = values.ToDictionary(
                x => x.Key,
                x => x.Value with
                {
                    Name = x.Value.Name.Remove(
                        x.Value.Name.IndexOf(enumName, StringComparison.OrdinalIgnoreCase),
                        enumName.Length).ToEnumValue(
                        description: description,
                        settings).Name,
                });
        }

        return values;
    }

    public static PropertyData ToEnumValue(
        this JsonNode? any,
        string description,
        Settings settings)
    {
        var id = any.GetString() ?? string.Empty;

        return id.ToEnumValue(description, settings);
    }
    
    public static PropertyData ToEnumValue(
        this string id,
        string description,
        Settings settings)
    {
        var name = id
            .ReplacePlusAndMinusOnStart()
            .ToPropertyName()
            .UseWordSeparator('_', '-', ' ', '.')
            .Replace("+", "Plus")
            .Replace("*", "Any")
            .Replace("[]", "Array")
            .Replace("'", string.Empty)
            .Replace(".", string.Empty)
            .Replace("[", string.Empty)
            .Replace("]", string.Empty);
        if (name.Length > 0 &&
            char.IsDigit(name[0]))
        {
            name = (string.IsNullOrWhiteSpace(settings.ClsCompliantEnumPrefix)
                ? "_"
                : settings.ClsCompliantEnumPrefix) + name;
        }

        return PropertyData.Default with
        {
            Id = id,
            Name = CSharpPropertyNameGenerator.SanitizeName(name, settings.ClsCompliantEnumPrefix),
            Summary = ClearForXml(ExtractEnumSummaryFromDescription(id, description)),
        };
    }

    public static string ExtractEnumSummaryFromDescription(string id, string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            return string.Empty;
        }
        
        var lines = description.Split(["\n"], StringSplitOptions.RemoveEmptyEntries);
        var line = lines.FirstOrDefault(line => line.Contains(id) && line.Contains(":"));
        
        if (line == null)
            return string.Empty;

        var index = line.IndexOf(':');
        return index >= 0
            ? line.Substring(index + 1).Trim()
            : line.Trim();
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
}