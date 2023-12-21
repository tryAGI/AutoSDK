using System.Collections.Immutable;
using System.Globalization;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using OpenApiGenerator.Models;
namespace OpenApiGenerator;

internal static class Extensions
{
    public static IncrementalValueProvider<Settings> DetectSettings(
        this IncrementalGeneratorInitializationContext context)
    {
        const string prefix = "OpenApiGenerator";

        return context.AnalyzerConfigOptionsProvider
            .Select((options, _) => new Settings(
                TargetFramework: options.GetGlobalOption("TargetFramework", prefix) ??
                                 options.GetGlobalOption("TargetFramework") ??
                                 "netstandard2.0",
                Namespace: options.GetGlobalOption("Namespace", prefix) ??
                           options.GetGlobalOption("PackageId") ??
                           options.GetGlobalOption("AssemblyName") ??
                           prefix,
                NamingConvention: Enum.TryParse<NamingConvention>(
                    options.GetGlobalOption(nameof(Settings.NamingConvention), prefix) ??
                    $"{default(NamingConvention):G}",
                    ignoreCase: true,
                    out var namingConvention) ? namingConvention : default,
                UseNSwag: bool.TryParse(
                    options.GetGlobalOption("UseNSwag", prefix),
                    out var useNSwag) && useNSwag,
                
                GenerateModels: bool.TryParse(
                    options.GetGlobalOption(nameof(Settings.GenerateModels), prefix),
                    out var generateModels) && generateModels,
                ModelStyle: Enum.TryParse<ModelStyle>(
                    options.GetGlobalOption(nameof(Settings.ModelStyle), prefix) ??
                        $"{default(ModelStyle):G}",
                    ignoreCase: true,
                    out var modelStyle) ? modelStyle : default,
                IncludeModels: (options.GetGlobalOption(nameof(Settings.IncludeModels), prefix)?.Split(';') ??
                               Array.Empty<string>()).ToImmutableArray()
                
                ));
    }
    
    public static OpenApiDocument GetOpenApiDocument(
        this AdditionalText text,
        CancellationToken cancellationToken = default)
    {
        var yaml = text.GetText(cancellationToken)?.ToString() ?? string.Empty;
        var openApiDocument = new OpenApiStringReader().Read(yaml, out _);

        openApiDocument.Components ??= new OpenApiComponents();
        openApiDocument.Components.Schemas ??= new Dictionary<string, OpenApiSchema>();

        return openApiDocument;
    }
    
    public static string GetCSharpType(
        this KeyValuePair<string, OpenApiSchema> schema,
        Settings settings,
        params Model[] parents)
    {
        var model = Model.FromSchema(schema, settings, parents);
        var (type, reference) = (schema.Value.Type, schema.Value.Format) switch
        {
            ("object", _) or (null, _) when schema.Value.Reference != null =>
                ($"{Model.FromKey(schema.Value.Reference.Id, settings).ClassName}", true),
            ("object", _) when schema.Value.Reference == null =>
                ($"{model.ExternalClassName}", true),
            
            (null, _) when schema.Value.AnyOf.Any() => ("object", true),
            (null, _) when schema.Value.OneOf.Any() => ("object", true),
            (null, _) when schema.Value.AllOf.Any() => ("object", true),
            
            ("string", _) when schema.Value.Enum.Any() =>
                ($"{(model with { Style = ModelStyle.Enumeration }).ExternalClassName}", true),
            
            ("boolean", _) => ("bool", false),
            ("integer", "int32") => ("int", false),
            ("integer", "int64") => ("long", false),
            ("number", "float") => ("float", false),
            ("number", "double") => ("double", false),
            ("string", "byte") => ("byte", false),
            ("string", "binary") => ("byte[]", true),
            ("string", "date") => ("global::System.DateTime", false),
            ("string", "date-time") => ("global::System.DateTime", false),
            ("string", "password") => ("string", true),
            
            ("integer", _) => ("int", false),
            ("number", _) => ("double", false),
            ("string", _) => ("string", true),
            ("object", _) => ("object", true),
            ("array", _) => (schema.Value.Items.WithKey(schema.Key)
                .GetCSharpType(settings, parents.ToArray()) + "[]", true),
            _ => throw new NotSupportedException($"Type {schema.Value.Type} is not supported."),
        };

        return schema.Value.Nullable ||
               reference && !parents.Last().Schema.Value.Required.Contains(schema.Key)
            ? type + "?"
            : type;
    }
    
    public static string? GetDefaultValue(this OpenApiSchema schema)
    {
        return schema.Default?.GetString();
    }

    private readonly static string[] NewLine = { "\n" };

    public static string GetSummary(this OpenApiSchema schema)
    {
        var summary = schema.Description ?? string.Empty;
        if (schema.Default != null)
        {
            summary += $"\n<br/>Default Value: {schema.Default.GetString()}";
        }
        if (schema.Example != null)
        {
            summary += $"\n<br/>Example: {schema.Example.GetString()}";
        }
        
        return summary;
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
            OpenApiObject @object => $"{{{string.Join(", ", @object.Select(x => $"{x.Key}: {GetString(x.Value)}"))}}}",
            _ => string.Empty,
        };
    }
    
    public static string ToXmlDocumentationSummary(
        this string text,
        int level = 4)
    {
        var lines = text.Split(NewLine, StringSplitOptions.RemoveEmptyEntries);
        if (lines.Length == 0)
        {
            lines = new[] { string.Empty };
        }
        
        var spaces = new string(' ', level);
        
        return $@"/// <summary>
{string.Join("\n", lines
            .Select(line => $"{spaces}/// {line}"))}
{spaces}/// </summary>";
    }
    
    public static string UseWordSeparator(
        this string propertyName,
        params char[] separator)
    {
        if (!separator.Any(propertyName.Contains))
        {
            return propertyName;
        }
        
        return string.Join(
            string.Empty,
            propertyName
                .Split(separator)
                .Select(word => word.ToPropertyName()));
    }
    
    public static string AddIndent(
        this string text,
        int level)
    {
        if (level < 1)
        {
            return text;
        }
        
        var lines = text.Split(NewLine, StringSplitOptions.None);
        var spaces = new string(' ', level * 4);
        
        return string.Join("\n", lines
    .Select(line => string.IsNullOrEmpty(line) ? line : $"{spaces}{line}"));
    }
    
    public static bool IsObjectWithoutReference(
        this OpenApiSchema schema)
    {
        return schema is { Type: "object", Reference: null };
    }
    
    public static bool IsEnum(
        this OpenApiSchema schema)
    {
        return schema.Type == "string" && schema.Enum.Any();
    }
    
    public static string[] Append(
        this string[] parents,
        KeyValuePair<string, OpenApiSchema> schema)
    {
        return parents.Append(schema.Key.ToPropertyName()).ToArray();
    }
    
    public static KeyValuePair<string, OpenApiSchema> WithKey(
        this OpenApiSchema schema,
        string key)
    {
        return new KeyValuePair<string, OpenApiSchema>(key, schema);
    }
    
    
    public static Property ToEnumValue(
        this IOpenApiAny any)
    {
        var id = any.GetString() ?? string.Empty;
        var name = id
           .ToPropertyName()
           .UseWordSeparator('_', '-')
           .Replace(".", string.Empty);
        
        return Property.Default with
        {
            Id = id,
            Name = name,
        };
    }
    
    public static string FixPropertyName(
        this string propertyName,
        string className)
    {
        return propertyName == className
            ? $"{propertyName}1"
            : propertyName;
    }
    
    public static Property ToProperty(
        this KeyValuePair<string, OpenApiSchema> schema,
        HashSet<string> requiredProperties,
        Settings settings,
        params Model[] parents)
    {
        return new Property(
            Id: schema.Key,
            Name: schema.Key.ToPropertyName()
                .FixPropertyName(parents.Last().ClassName)
                .UseWordSeparator('_', '-'),
            Type: schema.GetCSharpType(settings, parents),
            IsRequired: requiredProperties.Contains(schema.Key),
            DefaultValue: schema.Value.GetDefaultValue(),
            Summary: schema.Value.GetSummary());
    }

    public static IEnumerable<Model> WithAdditionalModels(
        this Model model)
    {
        return new []{ model }
            .Concat(model.AdditionalModels.SelectMany(WithAdditionalModels))
            .Concat(model.Enumerations.SelectMany(WithAdditionalModels));
    }

    public static IEnumerable<OpenApiReference> GetReferences(
        this KeyValuePair<string, OpenApiSchema> schema)
    {
        return schema.Value.Properties
            .Where(static x => x.Value.Reference != null)
            .Select(static x => x.Value.Reference)
            .Concat(schema.Value.Properties.SelectMany(GetReferences));
    }
}