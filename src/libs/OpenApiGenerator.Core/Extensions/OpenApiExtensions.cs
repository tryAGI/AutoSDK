using System.Collections.Immutable;
using System.Globalization;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using OpenApiGenerator.Core.Helpers;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;
using OpenApiGenerator.Core.Naming.Methods;
using OpenApiGenerator.Core.Serialization;

namespace OpenApiGenerator.Core.Extensions;

public static class OpenApiExtensions
{
    public static OpenApiDocument GetOpenApiDocument(
        this string yaml,
        CancellationToken cancellationToken = default)
    {
        var openApiDocument = new OpenApiStringReader().Read(yaml, out var diagnostics);
        if (diagnostics.Errors.Any())
        {
            throw new AggregateException(diagnostics.Errors.Select(x => new InvalidOperationException(x.Message)));
        }
        // if (diagnostics.Warnings.Any())
        // {
        //     throw new AggregateException(diagnostics.Warnings.Select(x => new InvalidOperationException(x.Message)));
        // }

        openApiDocument.Components ??= new OpenApiComponents();
        openApiDocument.Components.Schemas ??= new Dictionary<string, OpenApiSchema>();
        openApiDocument.Paths ??= new OpenApiPaths();
        openApiDocument.Tags ??= new List<OpenApiTag>();
        openApiDocument.SecurityRequirements ??= new List<OpenApiSecurityRequirement>();
        openApiDocument.Servers ??= new List<OpenApiServer>();

        return openApiDocument;
    }

    public static string GetMethodName(this OpenApiOperation operation, string path, OperationType operationType, MethodNamingConvention convention, MethodNamingConvention fallback)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));
        
        var mainGenerator = convention.GetGenerator();
        var fallbackGenerator = fallback.GetGenerator();
        
        return mainGenerator.TryGenerate(operation, path, operationType) ??
               fallbackGenerator.TryGenerate(operation, path, operationType) ??
               throw new InvalidOperationException("Failed to generate method name");
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
        IReadOnlyList<PropertyData> parameters)
    {
        path = path ?? throw new ArgumentNullException(nameof(path));
        parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        
        path = ParameterSerializer.SerializePathParameters(parameters, path);
        path += ParameterSerializer.SerializeQueryParameters(parameters);
        
        path = $"\"{path}\"";
        if (parameters.Any(x => x.ParameterLocation is ParameterLocation.Path or ParameterLocation.Query))
        {
            path = $"${path}";
        }
        
        return path;
    }

    public static string? GetDefaultValue(this KeyValuePair<string, OpenApiSchema> schema, Settings settings, ModelData[] parents)
    {
        var type = TypeData.FromSchema(schema, settings with
        {
            JsonSerializerType = JsonSerializerType.NewtonsoftJson
        }, parents);
        if (type.CSharpType == "object?" || schema.Value.Default is OpenApiArray)
        {
            return string.Empty;
        }
        if (schema.Value.Enum.Any() && schema.Value.Default != null)
        {
            return type.CSharpType.TrimEnd('?') + "." + schema.Value.Default.ToEnumValue().Name;
        }
        if (schema.Value.AnyOf.Any(x => x.Enum.Any()) && schema.Value.Default != null)
        {
            var typeData = TypeData.FromSchema(schema.Value.AnyOf.First(x => x.Enum.Any()).WithKey(schema.Key), settings with
            {
                JsonSerializerType = JsonSerializerType.NewtonsoftJson
            }, parents);
            return typeData.CSharpType.TrimEnd('?') + "." + schema.Value.Default.ToEnumValue().Name;
        }
        if (schema.Value.OneOf.Any(x => x.Enum.Any()) && schema.Value.Default != null)
        {
            var typeData = TypeData.FromSchema(schema.Value.OneOf.First(x => x.Enum.Any()).WithKey(schema.Key), settings with
            {
                JsonSerializerType = JsonSerializerType.NewtonsoftJson
            }, parents);
            return typeData.CSharpType.TrimEnd('?') + "." + schema.Value.Default.ToEnumValue().Name;
        }
        if (schema.Value.Default is OpenApiString @string)
        {
            return $"\"{@string.Value}\"";
        }
        
        return schema.Value.Default?.GetString();
    }

    public static string GetSummary(this OpenApiSchema schema)
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

    public static string ClearForXml(this string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));
        
        return text
            .Replace("<", "&lt;")
            .Replace(">", "&gt;");
    }

    public static string? GetString(this IOpenApiAny any)
    {
        return any switch
        {
            OpenApiNull => null,
            OpenApiString @string => @string.Value,
            OpenApiInteger integer => integer.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiLong @long => @long.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiFloat @float => @float.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiDouble @double => @double.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiBoolean boolean => boolean.Value ? "true" : "false",
            OpenApiArray array => $"[{string.Join(", ", array.Select(GetString))}]",
            //OpenApiObject @object => $"{{{string.Join(", ", @object.Select(x => $"{x.Key}: {GetString(x.Value)}"))}}}",
            _ => string.Empty,
        };
    }

    public static bool IsObjectWithoutReference(
        this OpenApiSchema schema)
    {
        return schema is { Type: "object", Reference: null } &&
            (schema.Properties.Any() ||
             schema.AllOf.Any() ||
             schema.AnyOf.Any() ||
             schema.OneOf.Any() ||
             schema.Items != null ||
             schema.Enum.Any());
    }

    public static ImmutableArray<PropertyData> ToAnyOfProperties(
        this IList<OpenApiSchema> schemas,
        Settings settings,
        string key)
    {
        var useSmartNames = schemas.All(x => x.Reference != null);
        var className = key.ToClassName();
        
        return schemas.Select((x, i) =>
        {
            var type = TypeData.FromSchema(x.UseReferenceIdOrKey(key + $"Variant{i + 1}"), settings);

            return PropertyData.Default with
            {
                Name = useSmartNames
                    ? SmartNamedAnyOfNames.ComputeSmartName(
                        type.ShortCSharpTypeWithoutNullability,
                        className)
                    : $"Value{i + 1}",
                Type = type,
            };
        }).ToImmutableArray();
    }

    internal static string ToCSharpName(this string text, SchemaContext? parent)
    {
        var name = text.ToPropertyName();
        
        name = PropertyData.HandleWordSeparators(name);

        if (parent != null)
        {
            name = name.FixPropertyName(parent.Id);
        }

        return PropertyData.SanitizeName(name, true);
    }
    
    public static bool IsEnum(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == "string" && schema.Enum.Any();
    }

    public static bool IsComponent(
        this KeyValuePair<string, OpenApiSchema> schema)
    {
        return schema.Value.Reference?.HostDocument?.Components?.Schemas?.ContainsKey(schema.Key) == true;
    }

    public static string[] Append(
        this string[] parents,
        KeyValuePair<string, OpenApiSchema> schema)
    {
        return parents.Concat([schema.Key.ToPropertyName()]).ToArray();
    }

    public static T ResolveIfRequired<T>(this T referenceable) where T : class, IOpenApiReferenceable
    {
        referenceable = referenceable ?? throw new ArgumentNullException(nameof(referenceable));
        
        return referenceable.Reference?.HostDocument?.ResolveReference(referenceable.Reference) as T ?? referenceable;
    }

    public static KeyValuePair<string, OpenApiSchema> WithKey(
        this OpenApiSchema schema,
        string key)
    {
        return new KeyValuePair<string, OpenApiSchema>(key, schema);
    }

    public static KeyValuePair<string, OpenApiSchema> UseReferenceIdOrKey(
        this OpenApiSchema schema,
        string key)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));
        
        return new KeyValuePair<string, OpenApiSchema>(
            schema.Reference?.Id ?? key,
            schema);
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
    
    public static PropertyData ToEnumValue(
        this IOpenApiAny any)
    {
        var id = any.GetString() ?? string.Empty;
        var name = id
            .ReplacePlusAndMinusOnStart()
            .ToPropertyName()
            .UseWordSeparator('_', '-', ' ', '.')
            .Replace("+", "Plus")
            .Replace("*", "Any")
            .Replace("'", string.Empty)
            .Replace(".", string.Empty)
            .Replace("[", string.Empty)
            .Replace("]", string.Empty);
        if (name.Length > 0 &&
            char.IsDigit(name[0]))
        {
            name = "_" + name;
        }

        return PropertyData.Default with
        {
            Id = id,
            Name = PropertyData.SanitizeName(name),
        };
    }

    public static IEnumerable<OpenApiReference> GetReferences(
        this KeyValuePair<string, OpenApiSchema> schema)
    {
        return schema.Value.Properties
            .Where(static x => x.Value.Reference != null)
            .Select(static x => x.Value.Reference)
            .Concat(schema.Value.Items?.Reference != null
                ? schema.Value.Items.WithKey("empty").GetReferences().Concat(new[] { schema.Value.Items.Reference })
                : [])
            .Concat(schema.Value.Properties.SelectMany(GetReferences));
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
    
    public static string[] FindAllModelsForTag(
        this OpenApiDocument openApiDocument,
        string tag)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        var operations = openApiDocument.Paths!
            .SelectMany(path => path.Value.Operations)
            .Where(x => x.Value.Tags?.Any(y => y.Name == tag) != false)
            .ToArray();
        
        var schemas = operations
            .SelectMany(x => x.Value.RequestBody?.ResolveIfRequired().Content.Values ?? [])
            .Select(x => x.Schema)
            .Concat(operations
                .SelectMany(x => x.Value.Parameters ?? [])
                .Select(x => x.ResolveIfRequired().Schema))
            .Concat(operations 
                .SelectMany(x => x.Value.Responses?.Values ?? new Dictionary<string, OpenApiResponse>().Values)
                .SelectMany(x => x.ResolveIfRequired().Content.Values)
                .Select(x => x.Schema))
            .Where(x => x != null)
            .SelectMany(x => new [] { x, x!.Items?.ResolveIfRequired() }
                .Concat(x.Properties.Values.Select(y => y.ResolveIfRequired()))
                .Concat(x.AnyOf.Select(y => y.ResolveIfRequired()))
                .Concat(x.OneOf.Select(y => y.ResolveIfRequired()))
                .Concat(x.AllOf.Select(y => y.ResolveIfRequired())))
            .Where(x => x != null)
            // .SelectMany(x => new [] { x, x!.Items?.ResolveIfRequired() }
            //     .Concat(x.Properties.Values.Select(y => y.ResolveIfRequired()))
            //     .Concat(x.AnyOf.Select(y => y.ResolveIfRequired()))
            //     .Concat(x.OneOf.Select(y => y.ResolveIfRequired()))
            //     .Concat(x.AllOf.Select(y => y.ResolveIfRequired())))
            // .Where(x => x != null)
            // .SelectMany(x => new [] { x, x!.Items?.ResolveIfRequired() }
            //     .Concat(x.Properties.Values.Select(y => y.ResolveIfRequired()))
            //     .Concat(x.AnyOf.Select(y => y.ResolveIfRequired()))
            //     .Concat(x.OneOf.Select(y => y.ResolveIfRequired()))
            //     .Concat(x.AllOf.Select(y => y.ResolveIfRequired())))
            // .Where(x => x != null)
            .ToArray();
        
        return operations
            .Select(x => x.Value.RequestBody?.Reference?.Id)
            .Concat(operations
                .SelectMany(x => x.Value.Parameters ?? [])
                .Select(x => x.Reference?.Id))
            .Concat(operations 
                .SelectMany(x => x.Value.Responses?.Values ?? new Dictionary<string, OpenApiResponse>().Values)
                .Select(x => x.Reference?.Id))
            .Concat(operations 
                .SelectMany(x => x.Value.Responses?.Values ?? new Dictionary<string, OpenApiResponse>().Values)
                .SelectMany(x => x.Content.Values)
                .Where(x => x.Schema != null)
                .Select(x => x.Schema!.Reference?.Id))
            .Concat(operations 
                .SelectMany(x => x.Value.Responses?.Values ?? new Dictionary<string, OpenApiResponse>().Values)
                .SelectMany(x => x.Content.Values)
                .Where(x => x.Schema != null)
                .Select(x => x.Schema!.Items?.Reference?.Id))
            .Concat(schemas.Select(x => x?.Reference?.Id))
            .Where(x => x != null)
            .Distinct()
            .ToArray()!;
    }
}