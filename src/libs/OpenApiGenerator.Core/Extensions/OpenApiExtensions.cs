using System.Collections.Immutable;
using System.Globalization;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using OpenApiGenerator.Core.Helpers;
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

    public static string? GetDefaultValue(this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        context.TypeData = context.TypeData ?? throw new InvalidOperationException("Invalid state: TypeData is null");
        
        if (context.TypeData.Value.CSharpType == "object?" || context.Schema.Default is OpenApiArray)
        {
            return string.Empty;
        }
        if (context.Schema.Enum.Any() && context.Schema.Default is OpenApiString enumString && !string.IsNullOrWhiteSpace(enumString.Value))
        {
            return context.TypeData.Value.CSharpTypeWithoutNullability + "." + context.Schema.Default.ToEnumValue(context.Settings).Name;
        }
        if (context.Schema.AnyOf.Any(x => x.Enum.Any()) && context.Schema.Default != null)
        {
            var enumChildContext = context.Children
                .Where(x => x.Hint is Hint.AnyOf)
                .First(x => x.Schema.Enum.Any());
            
            return enumChildContext.TypeData?.CSharpTypeWithoutNullability + "." + context.Schema.Default.ToEnumValue(context.Settings).Name;
        }
        if (context.Schema.OneOf.Any(x => x.Enum.Any()) && context.Schema.Default != null)
        {
            var enumChildContext = context.Children
                .Where(x => x.Hint is Hint.OneOf)
                .First(x => x.Schema.Enum.Any());
            
            return enumChildContext.TypeData?.CSharpTypeWithoutNullability + "." + context.Schema.Default.ToEnumValue(context.Settings).Name;
        }
        if (context.Schema.AllOf.Any(x => x.Enum.Any()) && context.Schema.Default != null)
        {
            var enumChildContext = context.Children
                .Where(x => x.Hint is Hint.AllOf)
                .First(x => x.Schema.Enum.Any());
            
            return enumChildContext.TypeData?.CSharpTypeWithoutNullability + "." + context.Schema.Default.ToEnumValue(context.Settings).Name;
        }
        if (context.Schema.Default is OpenApiString @string && !string.IsNullOrWhiteSpace(@string.Value))
        {
            return $"\"{@string.Value}\"";
        }
        
        return context.Schema.Default?.GetString();
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
            .Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;");
    }

    public static string? GetString(this IOpenApiAny any)
    {
        return any switch
        {
            OpenApiNull => null,
            OpenApiString @string => string.IsNullOrWhiteSpace(@string.Value) ? null : @string.Value,
            OpenApiInteger integer => integer.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiLong @long => @long.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiFloat @float => @float.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiDouble @double => @double.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiBoolean boolean => boolean.Value ? "true" : "false",
            OpenApiArray array => $"[{string.Join(", ", array.Select(GetString))}]",
            //OpenApiObject @object => $"{{{string.Join(", ", @object.Select(x => $"{x.Key}: {GetString(x.Value)}"))}}}",
            _ => null,
        };
    }

    public static ImmutableArray<PropertyData> ToAnyOfProperties(
        this IList<SchemaContext> schemas,
        string key)
    {
        var useSmartNames = schemas.All(x => x.Schema.Reference != null);
        var className = key.ToClassName();
        
        return schemas.Select((x, i) => PropertyData.Default with
        {
            Type = x.TypeData ?? TypeData.Default,
            Name = useSmartNames
                ? SmartNamedAnyOfNames.ComputeSmartName(
                    (x.TypeData ?? TypeData.Default).ShortCSharpTypeWithoutNullability,
                    className)
                : $"Value{i + 1}",
        }).ToImmutableArray();
    }

    internal static string ToCSharpName(this string text, Settings settings, SchemaContext? parent)
    {
        var name = text.ToPropertyName();
        
        name = PropertyData.HandleWordSeparators(name);

        if (parent != null)
        {
            name = name.FixPropertyName(parent.Id);
        }

        return PropertyData.SanitizeName(name, settings.ClsCompliantEnumPrefix, true);
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
        this IOpenApiAny any,
        Settings settings)
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
            name = (string.IsNullOrWhiteSpace(settings.ClsCompliantEnumPrefix)
                ? "_"
                : settings.ClsCompliantEnumPrefix) + name;
        }

        return PropertyData.Default with
        {
            Id = id,
            Name = PropertyData.SanitizeName(name, settings.ClsCompliantEnumPrefix),
        };
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