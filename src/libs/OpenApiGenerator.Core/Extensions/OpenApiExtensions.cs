using System.Globalization;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Extensions;

public static class OpenApiExtensions
{
    public static OpenApiDocument GetOpenApiDocument(
        this string yaml,
        CancellationToken cancellationToken = default)
    {
        var openApiDocument = new OpenApiStringReader().Read(yaml, out _);

        openApiDocument.Components ??= new OpenApiComponents();
        openApiDocument.Components.Schemas ??= new Dictionary<string, OpenApiSchema>();

        return openApiDocument;
    }

    public static string GetCSharpType(
        this KeyValuePair<string, OpenApiSchema> schema,
        Settings settings,
        params ModelData[] parents)
    {
        var model = ModelData.FromSchema(schema, settings, parents);
        var (type, reference) = (schema.Value.Type, schema.Value.Format) switch
        {
            ("object", _) or (null, _) when schema.Value.Reference != null =>
                ($"{ModelData.FromKey(schema.Value.Reference.Id, settings).ClassName}", true),
            ("object", _) when schema.Value.Reference == null =>
                ($"{model.ExternalClassName}", true),

            (null, _) when schema.Value.AnyOf.Any() => ("object", true),
            (null, _) when schema.Value.OneOf.Any() => ("object", true),
            (null, _) when schema.Value.AllOf.Any() => ("object", true),

            // Only Newtonsoft.Json supports EnumMemberAttribute
            ("string", _) when schema.Value.Enum.Any() && settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson =>
                ($"{(model with { Style = ModelStyle.Enumeration }).ExternalClassName}", true),
            ("string", _) when schema.Value.Enum.Any() && settings.JsonSerializerType != JsonSerializerType.NewtonsoftJson =>
                ("string", true),

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
                .GetCSharpType(settings, parents.ToArray()).AsArray(), true),
            _ => throw new NotSupportedException($"Type {schema.Value.Type} is not supported."),
        };

        return schema.Value.Nullable ||
               reference && !parents.Last().Schema.Value.Required.Contains(schema.Key)
            ? type + "?"
            : type;
    }

    public static string? GetDefaultValue(this OpenApiSchema schema, string type)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));
        type = type ?? throw new ArgumentNullException(nameof(type));

        if (type == "object?")
        {
            return string.Empty;
        }
        if (schema.Enum.Any() && schema.Default != null)
        {
            return type.TrimEnd('?') + "." + schema.Default.ToEnumValue().Name;
        }
        if (schema.Default is OpenApiString @string)
        {
            return $"\"{@string.Value}\"";
        }
        
        return schema.Default?.GetString();
    }

    public static string GetSummary(this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Remove any XML tags from the description
        var summary = schema.Description?.ClearForXml() ?? string.Empty;
        if (schema.Default != null)
        {
            summary += $"\n<br/>Default Value: {schema.Default.GetString()?.ClearForXml()}";
        }

        if (schema.Example != null)
        {
            summary += $"\n<br/>Example: {schema.Example.GetString()?.ClearForXml()}";
        }

        return summary;
    }

    public static string? ClearForXml(this string text)
    {
        return text?
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
            OpenApiObject @object => $"{{{string.Join(", ", @object.Select(x => $"{x.Key}: {GetString(x.Value)}"))}}}",
            _ => string.Empty,
        };
    }

    public static bool IsObjectWithoutReference(
        this OpenApiSchema schema)
    {
        return schema is { Type: "object", Reference: null };
    }

    public static bool IsEnum(
        this OpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Type == "string" && schema.Enum.Any();
    }

    public static string[] Append(
        this string[] parents,
        KeyValuePair<string, OpenApiSchema> schema)
    {
        return parents.Concat([schema.Key.ToPropertyName()]).ToArray();
    }

    public static KeyValuePair<string, OpenApiSchema> WithKey(
        this OpenApiSchema schema,
        string key)
    {
        return new KeyValuePair<string, OpenApiSchema>(key, schema);
    }


    public static PropertyData ToEnumValue(
        this IOpenApiAny any)
    {
        var id = any.GetString() ?? string.Empty;
        var name = id
            .ToPropertyName()
            .UseWordSeparator('_', '-', ' ')
            .Replace(".", string.Empty);
        if (name.Length > 0 &&
            char.IsDigit(name[0]))
        {
            name = "_" + name;
        }

        return PropertyData.Default with
        {
            Id = id,
            Name = name,
        };
    }

    public static PropertyData ToProperty(
        this KeyValuePair<string, OpenApiSchema> schema,
        HashSet<string> requiredProperties,
        Settings settings,
        params ModelData[] parents)
    {
        requiredProperties = requiredProperties ?? throw new ArgumentNullException(nameof(requiredProperties));

        return new PropertyData(
            Id: schema.Key,
            Name: schema.Key.ToPropertyName()
                .FixPropertyName(parents.Last().ClassName)
                .UseWordSeparator('_', '-', '/'),
            Type: schema.GetCSharpType(settings, parents),
            IsRequired: requiredProperties.Contains(schema.Key),
            DefaultValue: schema.Value.GetDefaultValue(type: schema.GetCSharpType(settings with
            {
                JsonSerializerType = JsonSerializerType.NewtonsoftJson
            }, parents)),
            Summary: schema.Value.GetSummary());
    }

    public static IEnumerable<ModelData> WithAdditionalModels(
        this ModelData modelData)
    {
        return new[]
            {
                modelData with
                {
                    AdditionalModels = [],
                    Enumerations = [],
                }
            }
            .Concat(modelData.AdditionalModels.SelectMany(WithAdditionalModels))
            .Concat(modelData.Enumerations.SelectMany(WithAdditionalModels));
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