using System.Collections.Immutable;
using System.Globalization;
using AutoSDK.Helpers;
using Microsoft.OpenApi;
using AutoSDK.Models;
using AutoSDK.Naming.Properties;
using AutoSDK.Serialization.Form;
using Microsoft.OpenApi.Reader;

namespace AutoSDK.Extensions;

public static class OpenApiExtensions
{
    public static OpenApiDocument GetOpenApiDocument(
        this string yamlOrJson,
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        yamlOrJson = yamlOrJson ?? throw new ArgumentNullException(nameof(yamlOrJson));
        
        var (openApiDocument, diagnostics) = OpenApiDocument.Parse(yamlOrJson, settings: new OpenApiReaderSettings
        {
            RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
        });
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
        
        var schemasToRemove = new List<KeyValuePair<string, OpenApiSchema>>();
        var schemasToAdd = new List<KeyValuePair<string, OpenApiSchema>>();
        foreach (var schema in openApiDocument.Components.Schemas)
        {
            // If schema is OneOf and all children have only one enum value, combine them into one schema.
            if (schema.Value.IsOneOf() &&
                schema.Value.OneOf.All(child =>
                    child.Properties.Any(subChild =>
                        subChild.Value.IsEnum() &&
                        subChild.Value.Enum.Count == 1)))
            {
                var subChildren = schema.Value.OneOf
                    .Select(child =>
                        child.Properties.First(subChild =>
                            subChild.Value.IsEnum() &&
                            subChild.Value.Enum.Count == 1))
                    .ToList();
                var newEnum = new OpenApiSchema
                {
                    Enum = subChildren
                        .Select(x => x.Value.Enum.First())
                        .ToArray(),
                    Type = "string",
                }.WithKey(schema.Key.ToPropertyName() + subChildren.First().Key.ToPropertyName());
                schemasToAdd.Add(newEnum);

                foreach (var child in schema.Value.OneOf)
                {
                    var subChild = child.Properties.First(subChild =>
                        subChild.Value.IsEnum() &&
                        subChild.Value.Enum.Count == 1);
                    child.Properties.Remove(subChild);
                    var newSubChild = new KeyValuePair<string, OpenApiSchema>(
                        subChild.Key,
                        new OpenApiSchema
                        {
                            Reference = new OpenApiReference
                            {
                                Id = newEnum.Key,
                                Type = ReferenceType.Schema,
                            },
                        });
                    child.Properties.Add(newSubChild);
                    
                    newSubChild.Value.Extensions["x-original-schema"] = new OpenApiString(
                        subChild.Value.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0));
                }

                // Remove duplicated schemas from OneOf.
                // Skip schemas with references.
                if (schema.Value.OneOf.Any(x => x.Reference == null))
                {
                    var duplicatedSchemas = new List<OpenApiSchema>();
                    foreach (var group in schema.Value.OneOf
                                 .GroupBy(x => x.Properties
                                     .Select(y => (y.Key, y.Value.Type, y.Value.Format, y.Value.Reference?.Id))
                                     .ToImmutableArray().AsEquatableArray())
                                 .Where(x => x.Count() > 1))
                    {
                        var first = group.First();
                        foreach (var schemaToRemove in group.Skip(1))
                        {
                            first.Description += $"\n{schemaToRemove.Description}";
                            duplicatedSchemas.Add(schemaToRemove);
                        }
                    }

                    foreach (var duplicatedSchema in duplicatedSchemas)
                    {
                        schema.Value.OneOf.Remove(duplicatedSchema);
                    }
                }
                
                // Simplify OneOf with only one schema.
                if (schema.Value.OneOf.Count == 1)
                {
                    schemasToRemove.Add(schema);
                    schemasToAdd.Add(new KeyValuePair<string, OpenApiSchema>(
                        schema.Key,
                        schema.Value.OneOf.First()));
                }
            }
        }
        foreach (var schema in schemasToRemove)
        {
            openApiDocument.Components.Schemas.Remove(schema);
        }
        foreach (var schema in schemasToAdd)
        {
            openApiDocument.Components.Schemas.Add(schema);
        }
        
        return openApiDocument;
    }
    
    public static OpenApiDocument SimplifyAllOf(
        this OpenApiDocument openApiDocument)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        foreach (var schema in openApiDocument.Components.Schemas)
        {
            var propertiesToAdd = new List<KeyValuePair<string, OpenApiSchema>>();
            var propertiesToRemove = new List<KeyValuePair<string, OpenApiSchema>>();
            foreach (var property in schema.Value.Properties)
            {
                if (property.Value.AllOf.Count == 1)
                {
                    var firstAllOfSchema = property.Value.AllOf.First();
                    propertiesToAdd.Add(new KeyValuePair<string, OpenApiSchema>(property.Key, firstAllOfSchema));
                    propertiesToRemove.Add(property);
                }
            }
            
            foreach (var property in propertiesToRemove)
            {
                schema.Value.Properties.Remove(property);
            }
            foreach (var property in propertiesToAdd)
            {
                schema.Value.Properties.Add(property);
            }
        }
        
        return openApiDocument;
    }
    
    public static OpenApiDocument ComputeDiscriminators(
        this OpenApiDocument openApiDocument)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        foreach (var schema in openApiDocument.Components.Schemas)
        {
            ProcessSchema(schema.Value, path: $"#/components/schemas/{schema.Key}", depth: 0);
        }
        
        return openApiDocument;
    }
    
    public static OpenApiDocument AddMissingPathParameters(
        this OpenApiDocument openApiDocument)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        foreach (var path in openApiDocument.Paths)
        {
            foreach (var operation in path.Value.Operations)
            {
                var parametersFromPath = PathHelper.ExtractParameters(path.Key.AsSpan());
                var parametersFromSpec = operation.Value.Parameters
                    .Where(x => x.In == ParameterLocation.Path)
                    .Select(x => x.Name)
                    .ToImmutableHashSet();
                foreach (var parameter in parametersFromPath)
                {
                    if (!parametersFromSpec.Contains(parameter))
                    {
                        operation.Value.Parameters.Add(new OpenApiParameter
                        {
                            Name = parameter,
                            In = ParameterLocation.Path,
                            Required = true,
                            Description = "This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
                            Schema = new OpenApiSchema
                            {
                                Type = "string",
                            },
                        });
                        
                        Console.WriteLine($"Missing path parameter '{parameter}' was added to operation '{operation.Key}' in path '{path.Key}'.");
                    }
                }
            }
        }
        
        return openApiDocument;
    }

    private static void ProcessSchema(OpenApiSchema schema, string path, int depth)
    {
        if (depth > 10)
        {
            return;
        }
        
        if (schema.Reference?.Id != null)
        {
            path = $"#/components/schemas/{schema.Reference?.Id}";
        }
            
        foreach (var property in schema.Properties)
        {
            ProcessSchema(property.Value, path: path + "/properties/" + property.Key, depth: depth + 1);
        }

        // Remove any nested OneOfs
        var schemasToRemove = new List<OpenApiSchema>();
        var schemasToAdd = new List<OpenApiSchema>();
        foreach (var value in schema.OneOf.Where(x => x.OneOf.Count > 0))
        {
            foreach (var child in value.OneOf)
            {
                schemasToAdd.Add(child);
            }
            schemasToRemove.Add(value);
        }
        schemasToRemove.ForEach(x =>
        {
            schema.OneOf.Remove(x);
            if (x.Reference?.Id != null)
            {
                x.Reference?.HostDocument?.Components.Schemas.Remove(x.Reference.Id);
            }
        });
        schemasToAdd.ForEach(x => schema.OneOf.Add(x));
        
        foreach (var value in schema.OneOf)
        {
            ProcessSchema(value, path: path + "/oneOf", depth: depth + 1);
        }
        foreach (var value in schema.AllOf)
        {
            ProcessSchema(value, path: path + "/allOf", depth: depth + 1);
        }
        foreach (var value in schema.AnyOf)
        {
            ProcessSchema(value, path: path + "/anyOf", depth: depth + 1);
        }
        if (schema.Items != null)
        {
            ProcessSchema(schema.Items, path: path + "/items", depth: depth + 1);
        }
            
        // Auto-detection in OpenAI-like specs
        if (schema.Discriminator == null &&
            schema.OneOf.Count > 1 &&
            schema.OneOf.All(y => y.ResolveIfRequired().Properties.Any(z => z.Value.Enum is { Count: 1 })))
        {
            var discriminatorPropertyName = schema.OneOf.First().Properties
                .FirstOrDefault(y => y.Value.Enum is { Count: 1 }).Key;
            var uniqueKeys = new HashSet<string>(schema.OneOf
                .Select(x => x.Properties[discriminatorPropertyName].Enum.First().GetString() ?? string.Empty));
            if (discriminatorPropertyName != null && uniqueKeys.Count == schema.OneOf.Count)
            {
                schema.Discriminator = new OpenApiDiscriminator
                {
                    PropertyName = discriminatorPropertyName,
                    Mapping = new HashSet<(string Key, string Path)>(schema.OneOf
                            .Select((x, i) => (
                                x.Properties[discriminatorPropertyName].Enum.First().GetString() ?? string.Empty,
                                x.Reference?.Id != null ? $"#/components/schemas/{x.Reference?.Id}" : path + "/oneOf/" + i))
                            .Where(x => !string.IsNullOrWhiteSpace(x.Item1)))
                        .ToDictionary(x => x.Key, x => x.Path),
                };
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
               schema.Properties.Count == 0;
    }
    
    public static string? GetDefaultValue(this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        if (context.TypeData.CSharpType == "object?" ||
            context.Schema.Default is OpenApiArray ||
            context.TypeData.CSharpTypeNullability)
        {
            return string.Empty;
        }

        // Replace to extensions?
        // if (context.CombinedEnumOriginalSchema != null)
        // {
        //     return context.TypeData.Value.CSharpTypeWithoutNullability + "." + context.CombinedEnumOriginalSchema.Value.Value.Enum.First().ToEnumValue(context.Settings).Name;
        // }
        if (context.Schema.Enum.Any() && context.Schema.Default is OpenApiString enumString && !string.IsNullOrWhiteSpace(enumString.Value))
        {
            var @enum = context.ComputeEnum();
            if (!@enum.TryGetValue(context.Schema.Default.GetString() ?? string.Empty, out var result))
            {
                return string.Empty;
            }

            return context.TypeData.CSharpTypeWithoutNullability + "." + result.Name;
        }
        if (context.Schema.AnyOf.Any(x => x.Enum.Any()) && context.Schema.Default != null)
        {
            var enumChildContext = context.Children
                .Where(x => x.Hint is Hint.AnyOf)
                .First(x => x.Schema.Enum.Any());
            var @enum = enumChildContext.ComputeEnum();
            var value = @enum.TryGetValue(context.Schema.Default.GetString() ?? string.Empty, out var result) ? result.Name : "";

            if (string.IsNullOrWhiteSpace(value))
            {
                if (context.Children
                    .Where(x => x.Hint is Hint.AnyOf)
                    .Any(x => x.Schema.Type == "string"))
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
        if (context.Schema.OneOf.Any(x => x.Enum.Any()) && context.Schema.Default != null)
        {
            var enumChildContext = context.Children
                .Where(x => x.Hint is Hint.OneOf)
                .First(x => x.Schema.Enum.Any());
            var @enum = enumChildContext.ComputeEnum();
            if (!@enum.TryGetValue(context.Schema.Default.GetString() ?? string.Empty, out var result))
            {
                return string.Empty;
            }
            
            return enumChildContext.TypeData.CSharpTypeWithoutNullability + "." + result.Name;
        }
        if (context.Schema.AllOf.Any(x => x.Enum.Any()) && context.Schema.Default != null)
        {
            var enumChildContext = context.Children
                .Where(x => x.Hint is Hint.AllOf)
                .First(x => x.Schema.Enum.Any());
            var @enum = enumChildContext.ComputeEnum();
            if (!@enum.TryGetValue(context.Schema.Default.GetString() ?? string.Empty, out var result))
            {
                return string.Empty;
            }
            
            return enumChildContext.TypeData.CSharpTypeWithoutNullability + "." + result.Name;
        }
        if (context.Schema.Default is OpenApiString @string && !string.IsNullOrWhiteSpace(@string.Value))
        {
            if (context.Schema.Type != "string" && 
                context.Schema.AnyOf.All(x => x.Type != "string") &&
                context.Schema.AllOf.All(x => x.Type != "string") &&
                context.Schema.OneOf.All(x => x.Type != "string"))
            {
                return null;
            }
            
            return $"\"{@string.Value}\"";
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

        foreach (var @object in operation.Extensions
             .Where(x => x.Value is OpenApiObject)
             .Select(x => x.Value)
             .Cast<OpenApiObject>())
        {
            if (@object.TryGetValue("stage", out var stage2) &&
                stage2 is OpenApiString string2)
            {
                return string2.Value;
            }
            if (@object.TryGetValue("alpha", out var alpha2) &&
                alpha2 is OpenApiBoolean { Value: true })
            {
                return "Alpha";
            }
            if (@object.TryGetValue("beta", out var beta2) &&
                beta2 is OpenApiBoolean { Value: true })
            {
                return "Beta";
            }
        }

        operation.Extensions.TryGetValue("x-stage", out var stage);
        if (stage is OpenApiString @string)
        {
            return @string.Value;
        }
        
        operation.Extensions.TryGetValue("x-alpha", out var alpha);
        if (alpha is OpenApiBoolean { Value: true })
        {
            return "Alpha";
        }
        
        operation.Extensions.TryGetValue("x-beta", out var beta);
        if (beta is OpenApiBoolean { Value: true })
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

    public static string? GetString(this IOpenApiAny any)
    {
        return any switch
        {
            OpenApiNull => null,
            OpenApiString @string => string.IsNullOrWhiteSpace(@string.Value) ? null : @string.Value,
            OpenApiInteger integer => integer.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiLong @long => @long.Value.ToString(CultureInfo.InvariantCulture) + "L",
            OpenApiFloat @float => @float.Value.ToString(CultureInfo.InvariantCulture) + "F",
            OpenApiDouble @double => @double.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiBoolean boolean => boolean.Value ? "true" : "false",
            OpenApiArray array => $"[{string.Join(", ", array.Select(GetString))}]",
            //OpenApiObject @object => $"{{{string.Join(", ", @object.Select(x => $"{x.Key}: {GetString(x.Value)}"))}}}",
            _ => null,
        };
    }

    public static T ResolveIfRequired<T>(this T referenceable) where T : class, IOpenApiReferenceable
    {
        referenceable = referenceable ?? throw new ArgumentNullException(nameof(referenceable));
        
        return referenceable.Reference?.HostDocument?.ResolveReference(referenceable.Reference) as T ?? referenceable;
    }

    public static KeyValuePair<string, OpenApiSchema> WithKey(
        this IOpenApiSchema schema,
        string key)
    {
        return new KeyValuePair<string, OpenApiSchema>(key, schema);
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
        
        var @enum = context.Schema.Enum.ComputeEnum(
            enumName: context.Id,
            description: context.Parameter?.Description ?? context.Schema.Description ?? string.Empty,
            context.Settings);
        
        if (context.Schema.Extensions.TryGetValue("x-enum-descriptions", out var descriptions) &&
            descriptions is OpenApiArray descriptionsArray)
        {
            var i = 0;
            foreach (var description in descriptionsArray)
            {
                if (description is OpenApiString @string)
                {
                    @enum[@enum.Keys.ElementAt(i)] = @enum[@enum.Keys.ElementAt(i)] with
                    {
                        Summary = ClearForXml(@string.Value),
                    };
                }
                i++;
            }
        }

        return @enum;
    }
    
    public static Dictionary<string, PropertyData> ComputeEnum(
        this IList<IOpenApiAny> @enum,
        string enumName,
        string description,
        Settings settings)
    {
        var values = @enum
            .Select(value => value.ToEnumValue(
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
        this IOpenApiAny any,
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
        
        return openApiDocument.Paths!
            .SelectMany(path => path.Value.Operations)
            .Where(x => x.Value.Tags?.Any(y => y.Name == tag) != false)
            .Where(x => x.Value.OperationId != null)
            .Select(x => x.Value.OperationId!)
            .ToArray();
    }
}