using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;

namespace OpenApiGenerator.Core.Models;

public readonly record struct TypeData(
    string CSharpType,
    bool IsArray,
    bool IsEnum,
    bool IsBase64,
    bool IsDate,
    bool IsDateTime,
    bool IsBinary,
    int AnyOfCount,
    int OneOfCount,
    int AllOfCount,
    bool IsComponent,
    ImmutableArray<string> Properties,
    ImmutableArray<string> EnumValues,
    ImmutableArray<TypeData> SubTypes,
    string Namespace,
    bool IsDeprecated,
    JsonSerializerType JsonSerializerType,
    bool GenerateJsonSerializerContextTypes)
{
    public static TypeData Default => new(
        CSharpType: string.Empty,
        IsArray: false,
        IsEnum: false,
        IsBase64: false,
        IsDate: false,
        IsDateTime: false,
        IsBinary: false,
        AnyOfCount: 0,
        OneOfCount: 0,
        AllOfCount: 0,
        IsComponent: false,
        Properties: [],
        EnumValues: [],
        SubTypes: [],
        Namespace: string.Empty,
        IsDeprecated: false,
        JsonSerializerType: JsonSerializerType.SystemTextJson,
        GenerateJsonSerializerContextTypes: false);
    
    public string CSharpTypeWithoutNullability => CSharpType.TrimEnd('?');
    public string CSharpTypeWithNullability => CSharpTypeWithoutNullability + "?";
    public string ShortCSharpTypeWithoutNullability => CSharpTypeWithoutNullability.Replace($"global::{Namespace}.", string.Empty);
    public string ShortCSharpTypeWithNullability => ShortCSharpTypeWithoutNullability + "?";
    public bool IsAnyOf => AnyOfCount > 0 || OneOfCount > 0 || AllOfCount > 0;

    public bool IsReferenceable =>
        CSharpTypeWithoutNullability is "string" or "int" or "long" or "float" or "double" or "bool" ||
        IsAnyOf ||
        IsEnum;
    
    public string ConverterType => IsEnum || ((AnyOfCount > 0 || OneOfCount > 0 || AllOfCount > 0) && IsComponent)
        ? $"global::OpenApiGenerator.JsonConverters.{ShortCSharpTypeWithoutNullability}JsonConverter"
        : AnyOfCount > 0
            ? $"global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory{AnyOfCount}"
            : OneOfCount > 0
                ? $"global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory{OneOfCount}"
                : AllOfCount > 0
                    ? $"global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory{AllOfCount}"
                    : string.Empty;
    
    public static TypeData FromSchemaContext(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        var properties = ImmutableArray<string>.Empty;
        if (context.Schema.Reference?.HostDocument?.ResolveReference(context.Schema.Reference) is OpenApiSchema referenceSchema)
        {
            properties = referenceSchema.Properties
                .Select(x => x.Key)
                .ToImmutableArray();
        }
        
        var subTypes = ImmutableArray<TypeData>.Empty;
        if (context.Schema.AnyOf.Any())
        {
            subTypes = context.Children
                .Where(x => x is { Hint: Hint.AnyOf, TypeData: not null })
                .Select(x => x.TypeData!.Value)
                .ToImmutableArray();
        }
        else if (context.Schema.OneOf.Any())
        {
            subTypes = context.Children
                .Where(x => x is { Hint: Hint.OneOf, TypeData: not null })
                .Select(x => x.TypeData!.Value)
                .ToImmutableArray();
        }
        else if (context.Schema.AllOf.Any())
        {
            subTypes = context.Children
                .Where(x => x is { Hint: Hint.AllOf, TypeData: not null })
                .Select(x => x.TypeData!.Value)
                .ToImmutableArray();
        }
        if (context.Schema.IsArray())
        {
            subTypes = [Default with
            {
                IsEnum = context.Schema.Items.IsEnum(),
            }];
        }
        
        var enumValues = ImmutableArray<string>.Empty;
        if (context.Schema.IsEnum())
        {
            var values = context.Schema.Enum
                .Select(value => value.ToEnumValue(context.Settings)).ToArray();
            properties = values
                .Select(x => x.Name)
                .ToImmutableArray();
            enumValues = values
                .Select(x => x.Id)
                .ToImmutableArray();
        }
        
        return new TypeData(
            CSharpType: GetCSharpType(context),
            IsArray: context.Schema.Type == "array",
            IsEnum: context.Schema.IsEnum(),
            IsBase64: context.Schema.IsBase64(),
            IsDate: context.Schema.IsDate(),
            IsDateTime: context.Schema.IsDateTime(),
            IsBinary: context.Schema.IsBinary(),
            AnyOfCount: context.Schema.AnyOf?.Count ?? 0,
            OneOfCount: context.Schema.OneOf?.Count ?? 0,
            AllOfCount: context.Schema.AllOf?.Count ?? 0,
            IsComponent: context.IsComponent,
            Properties: properties,
            EnumValues: enumValues,
            SubTypes: subTypes,
            Namespace: context.Settings.Namespace,
            IsDeprecated: context.Schema.Deprecated,
            JsonSerializerType: context.Settings.JsonSerializerType,
            GenerateJsonSerializerContextTypes: context.Settings.GenerateJsonSerializerContextTypes);
    }
    
    public static string GetCSharpType(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        var (type, reference) = (context.Schema.Type, context.Schema.Format) switch
        {
            (_, _) when context.Schema.AnyOf.Any() && context.IsComponent => ($"global::{context.Settings.Namespace}.{context.Id}", true),
            (_, _) when context.Schema.OneOf.Any() && context.IsComponent => ($"global::{context.Settings.Namespace}.{context.Id}", true),
            (_, _) when context.Schema.AllOf.Any() && context.IsComponent => ($"global::{context.Settings.Namespace}.{context.Id}", true),
            
            (_, _) when context.Schema.AnyOf.Any() => ($"global::System.AnyOf<{string.Join(", ", context.Children.Where(x => x.Hint == Hint.AnyOf).Select(x => x.TypeData?.CSharpType))}>", true),
            (_, _) when context.Schema.OneOf.Any() => ($"global::System.OneOf<{string.Join(", ", context.Children.Where(x => x.Hint == Hint.OneOf).Select(x => x.TypeData?.CSharpType))}>", true),
            (_, _) when context.Schema.AllOf.Any() => ($"global::System.AllOf<{string.Join(", ", context.Children.Where(x => x.Hint == Hint.AllOf).Select(x => x.TypeData?.CSharpType))}>", true),

            ("object", _) or (null, _) when context.Schema.Reference != null =>
                ($"global::{context.Settings.Namespace}.{context.Id}", true),
            // ("object", _) when context.Schema.Reference == null &&
            //                    context.Children.Count == 1 =>
            //     ("object", true),
            ("object", _) when context.Schema.Reference == null =>
                ($"global::{context.Settings.Namespace}.{context.Id}", true),

            ("string", _) when context.Schema.Enum.Any() =>
                ($"global::{context.Settings.Namespace}.{context.Id}", true),

            ("boolean", _) => ("bool", false),
            ("integer", "int32") => ("int", false),
            ("integer", "int64") => ("long", false),
            ("number", "float") => ("float", false),
            ("number", "double") => ("double", false),
            ("string", "byte") => ("byte[]", false),
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
                ($"{context.Children.FirstOrDefault(x => x.Hint == Hint.ArrayItem)?.TypeData?.CSharpTypeWithoutNullability}".AsArray(), true),
            
            (null, null)  => ("object", true),
            ("null", _)  => ("object", true),
            _ => throw new NotSupportedException($"Type {context.Schema.Type} is not supported."),
        };

        return context.Schema.Nullable ||
               reference && !context.IsRequired
            ? type + "?"
            : type;
    }
}