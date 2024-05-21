using System.Globalization;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
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

    public static string? GetDefaultValue(this OpenApiSchema schema, string type)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));
        type = type ?? throw new ArgumentNullException(nameof(type));

        if (type == "object?" || schema.Default is OpenApiArray)
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
            Name = name,
        };
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