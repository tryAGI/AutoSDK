using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct TypeData(
    string CSharpType,
    bool IsArray,
    bool IsEnum,
    int AnyOfCount,
    int OneOfCount,
    int AllOfCount,
    ImmutableArray<string> Properties,
    ImmutableArray<string> EnumValues,
    string Namespace,
    bool IsDeprecated,
    JsonSerializerType JsonSerializerType,
    bool GenerateJsonSerializerContextTypes)
{
    public static TypeData Default => new(
        CSharpType: string.Empty,
        IsArray: false,
        IsEnum: false,
        AnyOfCount: 0,
        OneOfCount: 0,
        AllOfCount: 0,
        Properties: [],
        EnumValues: [],
        Namespace: string.Empty,
        IsDeprecated: false,
        JsonSerializerType: JsonSerializerType.SystemTextJson,
        GenerateJsonSerializerContextTypes: false);
    
    public string CSharpTypeWithoutNullability => CSharpType.TrimEnd('?');
    public string CSharpTypeWithNullability => CSharpTypeWithoutNullability + "?";
    public string ShortCSharpTypeWithoutNullability => CSharpTypeWithoutNullability.Replace($"global::{Namespace}.", string.Empty);
    public string ShortCSharpTypeWithNullability => ShortCSharpTypeWithoutNullability + "?";
    public bool IsAnyOf => AnyOfCount > 0 || OneOfCount > 0 || AllOfCount > 0;
    
    public string ConverterType => IsEnum
        ? $"global::OpenApiGenerator.JsonConverters.{ShortCSharpTypeWithoutNullability}JsonConverter"
        : AnyOfCount > 0
            ? $"global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory{AnyOfCount}"
            : OneOfCount > 0
                ? $"global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory{OneOfCount}"
                : AllOfCount > 0
                    ? $"global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory{AllOfCount}"
                    : string.Empty;

    public static TypeData FromSchema(
        KeyValuePair<string, OpenApiSchema> schema,
        Settings settings,
        params ModelData[] parents)
    {
        parents = parents ?? throw new ArgumentNullException(nameof(parents));

        var properties = ImmutableArray<string>.Empty;
        if (schema.Value.Reference?.HostDocument?.ResolveReference(schema.Value.Reference) is OpenApiSchema referenceSchema)
        {
            properties = referenceSchema.Properties
                .Select(x => x.Key)
                .ToImmutableArray();
        }
        
        var enumValues = ImmutableArray<string>.Empty;
        if (schema.Value.IsEnum())
        {
            var values = schema.Value.Enum
                .Select(value => value.ToEnumValue()).ToArray();
            properties = values
                .Select(x => x.Name)
                .ToImmutableArray();
            enumValues = values
                .Select(x => x.Id)
                .ToImmutableArray();
        }
        
        return new TypeData(
            CSharpType: GetCSharpType(schema, settings, parents),
            IsArray: schema.Value.Type == "array",
            IsEnum: schema.Value.IsEnum(),
            AnyOfCount: schema.Value.AnyOf?.Count ?? 0,
            OneOfCount: schema.Value.OneOf?.Count ?? 0,
            AllOfCount: schema.Value.AllOf?.Count ?? 0,
            Properties: properties,
            EnumValues: enumValues,
            Namespace: settings.Namespace,
            IsDeprecated: schema.Value.Deprecated,
            JsonSerializerType: settings.JsonSerializerType,
            GenerateJsonSerializerContextTypes: settings.GenerateJsonSerializerContextTypes);
    }
    
    public static TypeData FromSchemaContext(SchemaContext context, IReadOnlyCollection<SchemaContext> children)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        var properties = ImmutableArray<string>.Empty;
        if (context.Schema.Reference?.HostDocument?.ResolveReference(context.Schema.Reference) is OpenApiSchema referenceSchema)
        {
            properties = referenceSchema.Properties
                .Select(x => x.Key)
                .ToImmutableArray();
        }
        
        var enumValues = ImmutableArray<string>.Empty;
        if (context.Schema.IsEnum())
        {
            var values = context.Schema.Enum
                .Select(value => value.ToEnumValue()).ToArray();
            properties = values
                .Select(x => x.Name)
                .ToImmutableArray();
            enumValues = values
                .Select(x => x.Id)
                .ToImmutableArray();
        }
        
        return new TypeData(
            CSharpType: GetCSharpType(context, children),
            IsArray: context.Schema.Type == "array",
            IsEnum: context.Schema.IsEnum(),
            AnyOfCount: context.Schema.AnyOf?.Count ?? 0,
            OneOfCount: context.Schema.OneOf?.Count ?? 0,
            AllOfCount: context.Schema.AllOf?.Count ?? 0,
            Properties: properties,
            EnumValues: enumValues,
            Namespace: context.Settings.Namespace,
            IsDeprecated: context.Schema.Deprecated,
            JsonSerializerType: context.Settings.JsonSerializerType,
            GenerateJsonSerializerContextTypes: context.Settings.GenerateJsonSerializerContextTypes);
    }
    
    public static string GetCSharpType(SchemaContext context, IReadOnlyCollection<SchemaContext> children)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        children = children ?? throw new ArgumentNullException(nameof(children));
        
        var (type, reference) = (context.Schema.Type, context.Schema.Format) switch
        {
            (null, _) when context.Schema.AnyOf.Any() && context.IsComponent => ($"global::{context.Settings.Namespace}.{context.Id}", true),
            (null, _) when context.Schema.OneOf.Any() && context.IsComponent => ($"global::{context.Settings.Namespace}.{context.Id}", true),
            (null, _) when context.Schema.AllOf.Any() && context.IsComponent => ($"global::{context.Settings.Namespace}.{context.Id}", true),
            
            (null, _) when context.Schema.AnyOf.Any() => ($"global::System.AnyOf<{string.Join(", ", children.Where(x => x.Hint == Hint.AnyOf).Select(x => x.TypeData?.CSharpType))}>", true),
            (null, _) when context.Schema.OneOf.Any() => ($"global::System.OneOf<{string.Join(", ", children.Where(x => x.Hint == Hint.OneOf).Select(x => x.TypeData?.CSharpType))}>", true),
            (null, _) when context.Schema.AllOf.Any() => ($"global::System.AllOf<{string.Join(", ", children.Where(x => x.Hint == Hint.AllOf).Select(x => x.TypeData?.CSharpType))}>", true),

            ("object", _) or (null, _) when context.Schema.Reference != null =>
                ($"global::{context.Settings.Namespace}.{context.Id}", true),
            ("object", _) when context.Schema.Reference == null &&
                               children.Count == 1 =>
                ("object", true),
            ("object", _) when context.Schema.Reference == null =>
                ($"global::{context.Settings.Namespace}.{context.Id}", true),

            ("string", _) when context.Schema.Enum.Any() =>
                ($"global::{context.Settings.Namespace}.{context.Id}", true),

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
            //("string", "uri") => ("global::System.Uri", true),

            ("integer", _) => ("int", false),
            ("number", _) => ("double", false),
            ("string", _) => ("string", true),
            ("object", _) => ("object", true),
            ("array", _) =>
                ($"{children.FirstOrDefault(x => x.Hint == Hint.ArrayItem)?.TypeData?.CSharpType}".AsArray(), true),
            
            (null, null)  => ("object", true),
            _ => throw new NotSupportedException($"Type {context.Schema.Type} is not supported."),
        };

        return context.Schema.Nullable ||
               reference && !context.IsRequired
            ? type + "?"
            : type;
    }
    
    public static string GetCSharpType(
        KeyValuePair<string, OpenApiSchema> schema,
        Settings settings,
        params ModelData[] parents)
    {
        parents = parents ?? throw new ArgumentNullException(nameof(parents));
        
        var model = ModelData.FromSchema(schema, settings, parents);
        var (type, reference) = (schema.Value.Type, schema.Value.Format) switch
        {
            (null, _) when schema.Value.AnyOf.Any() && schema.IsComponent() => ($"global::{settings.Namespace}.{schema.Key}", true),
            (null, _) when schema.Value.OneOf.Any() && schema.IsComponent() => ($"global::{settings.Namespace}.{schema.Key}", true),
            (null, _) when schema.Value.AllOf.Any() && schema.IsComponent() => ($"global::{settings.Namespace}.{schema.Key}", true),
            
            (null, _) when schema.Value.AnyOf.Any() => ($"global::System.AnyOf<{string.Join(", ", schema.Value.AnyOf.Select(x => GetCSharpType(x.UseReferenceIdOrKey(schema.Key), settings, parents)))}>", true),
            (null, _) when schema.Value.OneOf.Any() => ($"global::System.OneOf<{string.Join(", ", schema.Value.OneOf.Select(x => GetCSharpType(x.UseReferenceIdOrKey(schema.Key), settings, parents)))}>", true),
            (null, _) when schema.Value.AllOf.Any() => ($"global::System.AllOf<{string.Join(", ", schema.Value.AllOf.Select(x => GetCSharpType(x.UseReferenceIdOrKey(schema.Key), settings, parents)))}>", true),

            ("object", _) or (null, _) when schema.Value.Reference != null =>
                ($"global::{settings.Namespace}.{ModelData.FromKey(schema.Value.Reference.Id, settings).ClassName}", true),
            ("object", _) when schema.Value.Reference == null &&
                               model.Properties.IsEmpty =>
                ("object", true),
            ("object", _) when schema.Value.Reference == null =>
                ($"global::{settings.Namespace}.{model.ExternalClassName}", true),

            ("string", _) when schema.Value.Enum.Any() =>
                ($"global::{settings.Namespace}.{(schema.Value is { Reference: not null } ? ModelData.FromKey(schema.Value.Reference.Id, settings).ClassName : (model with { Style = ModelStyle.Enumeration }).ExternalClassName)}", true),
            // ("string", _) when schema.Value.Enum.Any() && settings.JsonSerializerType != JsonSerializerType.NewtonsoftJson =>
            //     ("string", true),

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
            //("string", "uri") => ("global::System.Uri", true),

            ("integer", _) => ("int", false),
            ("number", _) => ("double", false),
            ("string", _) => ("string", true),
            ("object", _) => ("object", true),
            ("array", _) when schema.Value.Items.Reference != null =>
                ($"global::{settings.Namespace}.{ModelData.FromKey(schema.Value.Items.Reference.Id, settings).ClassName}".AsArray(), true),
            ("array", _) when schema.Value.Items.Reference == null => (GetCSharpType(schema.Value.Items.WithKey(schema.Key), settings, parents.ToArray()).AsArray(), true),
            
            (null, null)  => ("object", true),
            _ => throw new NotSupportedException($"Type {schema.Value.Type} is not supported."),
        };

        return schema.Value.Nullable ||
               reference && parents.Length > 0 && parents.Last().Schema.Value?.Required.Contains(schema.Key) == false
            ? type + "?"
            : type;
    }
}