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
                    out var modelStyle) ? modelStyle : default
                
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
        string? parent = null)
    {
        return (schema.Value.Type, schema.Value.Format) switch
        {
            ("object", _) when schema.Value.Reference == null => $"{schema.Key.ToModelName(parent)}?",
            
            ("boolean", _) => "bool",
            ("integer", "int32") => "int",
            ("integer", "int64") => "long",
            ("number", "float") => "float",
            ("number", "double") => "double",
            ("string", "byte") => "byte",
            ("string", "binary") => "byte[]?",
            ("string", "date") => "global::System.DateTime",
            ("string", "date-time") => "global::System.DateTime",
            ("string", "password") => "string?",
            
            ("integer", _) => "int",
            ("number", _) => "double",
            ("string", _) => "string?",
            ("object", _) => "object?",
            ("array", _) => "object[]?",
            _ => throw new NotSupportedException($"Type {schema.Value.Type} is not supported."),
        };
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
            summary += $"\nDefault Value: {schema.Default.GetString()}";
        }
        if (schema.Example != null)
        {
            summary += $"\nExample: {schema.Example.GetString()}";
        }
        
        return summary;
    }
    
    public static string GetString(this IOpenApiAny any)
    {
        return any switch
        {
            OpenApiString @string => @string.Value,
            OpenApiInteger integer => integer.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiLong @long => @long.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiFloat @float => @float.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiDouble @double => @double.Value.ToString(CultureInfo.InvariantCulture),
            OpenApiBoolean boolean => boolean.Value.ToString(),
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
    
    public static string FixClassName(
        this string propertyName,
        string className)
    {
        return propertyName == className
            ? $"{propertyName}1"
            : propertyName;
    }
    
    public static string FixParentClassName(
        this string className,
        string parent)
    {
        return parent == className
            ? $"{className}_"
            : className;
    }
    
    public static string FixUnderscore(
        this string propertyName)
    {
        if (!propertyName.Contains('_'))
        {
            return propertyName;
        }
        
        return string.Join(
            string.Empty,
            propertyName
                .Split('_')
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

    public static string ToModelName(
        this string text,
        string? parent)
    {
        return text.ToPropertyName()
            .FixParentClassName(parent ?? string.Empty);
    }
    
    public static Model ToModel(
        this KeyValuePair<string, OpenApiSchema> schema,
        Settings settings,
        string? parent = null)
    {
        return new Model(
            Name: schema.Key.ToModelName(parent),
            Parent: parent,
            Namespace: settings.Namespace,
            Style: settings.ModelStyle,
            Properties: schema.Value.Properties
                .Select(x => new Property(
                    Id: x.Key,
                    Name: x.Key.ToPropertyName()
                        .FixClassName(schema.Key.ToPropertyName())
                        .FixUnderscore(),
                    Type: x.GetCSharpType(schema.Key),
                    IsRequired: x.Value.Required.Contains(x.Key),
                    DefaultValue: x.Value.GetDefaultValue(),
                    Summary: x.Value.GetSummary()))
                .ToImmutableArray(),
            Summary: schema.Value.GetSummary(),
            AdditionalModels: schema.Value.Properties
                .Where(static x =>
                    x.Value.Type == "object" && x.Value.Reference == null)
                .Select(x => x.ToModel(settings, parent:
                    parent != null 
                        ? $"{parent}.{schema.Key.ToPropertyName()}"
                        : schema.Key.ToPropertyName()))
                .ToImmutableArray());
    }

    public static IEnumerable<Model> WithAdditionalModels(
        this Model model)
    {
        return new []{ model }
            .Concat(model.AdditionalModels.SelectMany(WithAdditionalModels));
    }
}