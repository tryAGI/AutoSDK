using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using AutoSDK.Extensions;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Models;

public readonly record struct TypeData(
    string CSharpType,
    bool IsArray,
    bool IsEnum,
    bool IsBase64,
    bool IsDate,
    bool IsDateTime,
    bool IsBinary,
    bool IsValueType,
    bool IsUnixTimestamp,
    int AnyOfCount,
    int OneOfCount,
    int AllOfCount,
    bool IsComponent,
    ImmutableArray<string> Properties,
    ImmutableArray<string> EnumValues,
    ImmutableArray<TypeData> SubTypes,
    string Namespace,
    bool IsDeprecated,
    Settings Settings)
{
    public static TypeData Default => new(
        CSharpType: string.Empty,
        IsArray: false,
        IsEnum: false,
        IsBase64: false,
        IsDate: false,
        IsDateTime: false,
        IsBinary: false,
        IsValueType: false,
        IsUnixTimestamp: false,
        AnyOfCount: 0,
        OneOfCount: 0,
        AllOfCount: 0,
        IsComponent: false,
        Properties: [],
        EnumValues: [],
        SubTypes: [],
        Namespace: string.Empty,
        IsDeprecated: false,
        Settings: Settings.Default);
    
    public string CSharpTypeWithoutNullability => CSharpType.TrimEnd('?');
    public string CSharpTypeWithNullability => CSharpTypeWithoutNullability + "?";
    public string ShortCSharpTypeWithoutNullability => CSharpTypeWithoutNullability.Replace($"global::{Namespace}.", string.Empty);
    public string ShortCSharpTypeWithNullability => ShortCSharpTypeWithoutNullability + "?";
    public bool IsAnyOf => AnyOfCount > 0 || OneOfCount > 0 || AllOfCount > 0;
    public string CSharpTypeWithNullabilityForValueTypes => IsValueType
        ? CSharpTypeWithNullability
        : CSharpTypeWithoutNullability;

    public bool IsReferenceable =>
        IsValueType ||
        CSharpTypeWithoutNullability is "string" ||
        IsAnyOf ||
        IsEnum;
    
    public string ConverterType =>
        IsUnixTimestamp
            ? $"global::{Settings.Namespace}.JsonConverters.UnixTimestampJsonConverter"
            : IsEnum || ((AnyOfCount > 0 || OneOfCount > 0 || AllOfCount > 0) && IsComponent)
                ? $"global::{Settings.Namespace}.JsonConverters.{ShortCSharpTypeWithoutNullability}JsonConverter"
                : AnyOfCount > 0
                    ? $"global::{Settings.Namespace}.JsonConverters.AnyOfJsonConverterFactory{AnyOfCount}"
                    : OneOfCount > 0
                        ? $"global::{Settings.Namespace}.JsonConverters.OneOfJsonConverterFactory{OneOfCount}"
                        : AllOfCount > 0
                            ? $"global::{Settings.Namespace}.JsonConverters.AllOfJsonConverterFactory{AllOfCount}"
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
        if (context.Schema.IsAnyOf())
        {
            subTypes = context.Children
                .Where(x => x is { Hint: Hint.AnyOf, TypeData: not null })
                .Select(x => x.TypeData!.Value)
                .ToImmutableArray();
        }
        else if (context.Schema.IsOneOf())
        {
            subTypes = context.Children
                .Where(x => x is { Hint: Hint.OneOf, TypeData: not null })
                .Select(x => x.TypeData!.Value)
                .ToImmutableArray();
        }
        else if (context.Schema.IsAllOf())
        {
            subTypes = context.Children
                .Where(x => x is { Hint: Hint.AllOf, TypeData: not null })
                .Select(x => x.TypeData!.Value)
                .ToImmutableArray();
        }
        if (context.Schema.IsArray())
        {
            subTypes = [
                context.Children
                    .FirstOrDefault(x => x is { Hint: Hint.ArrayItem, TypeData: not null })
                    ?.TypeData ??
                Default with
                {
                    IsEnum = context.Schema.Items.IsEnum(),
                },
            ];
        }
        if (context.Schema.IsBinary() || context.Schema.IsBase64())
        {
            subTypes = [
                Default with
                {
                    CSharpType = "byte",
                },
            ];
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
        
        var type = GetCSharpType(context);
        
        return new TypeData(
            CSharpType: type,
            IsValueType: ContextIsValueType(context),
            IsArray: context.Schema.IsArray(),
            IsEnum: context.Schema.IsEnum(),
            IsBase64: context.Schema.IsBase64(),
            IsDate: context.Schema.IsDate(),
            IsDateTime: context.Schema.IsDateTime(),
            IsBinary: context.Schema.IsBinary(),
            IsUnixTimestamp: context.Schema.IsUnixTimestamp(),
            AnyOfCount: context.Schema.IsAnyOf() // Sometimes here AnyOf with only required properties
                ? context.Schema.AnyOf?.Count ?? 0
                : 0,
            OneOfCount: context.Schema.IsOneOf() // Sometimes here OneOf with only required properties
                ? context.Schema.OneOf?.Count ?? 0
                : 0,
            AllOfCount: context.Schema.IsAllOf() // Sometimes here AllOf with only required properties
                ? context.Schema.AllOf?.Count ?? 0
                : 0,
            IsComponent: context.IsComponent,
            Properties: properties,
            EnumValues: enumValues,
            SubTypes: subTypes,
            Namespace: type.StartsWith("global::System.", StringComparison.Ordinal)
                ? "System"
                : context.Settings.Namespace,
            IsDeprecated: context.Schema.Deprecated,
            Settings: context.Settings);
    }
    
    public static bool ContextIsValueType(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        return (context.Schema.Type, context.Schema.Format) switch
        {
            (_, _) when context.IsAnyOfLikeStructure => true,
            (_, _) when context.IsEnum => true,

            ("boolean", _) => true,
            ("integer", _) => true,
            ("number", _) => true,
            ("string", "date") => true,
            ("string", "date-time") => true,
            ("string", "password") => true,
            ("string", "uuid") => true,
            
            _ => false,
        };
    }
    
    public static string GetCSharpType(SchemaContext context, SchemaContext? additionalContext = null)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        var (type, reference) = (context.Schema.Type, context.Schema.Format) switch
        {
            (_, _) when context.Schema.IsUnixTimestamp() => ("global::System.DateTimeOffset", false),
            
            (_, _) when context.Schema.IsAnyOf() && context.IsComponent => ($"global::{context.Settings.Namespace}.{context.Id}", true),
            (_, _) when context.Schema.IsOneOf() && context.IsComponent => ($"global::{context.Settings.Namespace}.{context.Id}", true),
            (_, _) when context.Schema.IsAllOf() && context.IsComponent => ($"global::{context.Settings.Namespace}.{context.Id}", true),
            
            (_, _) when context.Schema.IsAnyOf() => ($"global::{context.Settings.Namespace}.AnyOf<{string.Join(", ", context.Children.Where(x => x.Hint == Hint.AnyOf).Select(x => x.TypeData?.CSharpTypeWithNullabilityForValueTypes))}>", true),
            (_, _) when context.Schema.IsOneOf() => ($"global::{context.Settings.Namespace}.OneOf<{string.Join(", ", context.Children.Where(x => x.Hint == Hint.OneOf).Select(x => x.TypeData?.CSharpTypeWithNullabilityForValueTypes))}>", true),
            (_, _) when context.Schema.IsAllOf() => ($"global::{context.Settings.Namespace}.AllOf<{string.Join(", ", context.Children.Where(x => x.Hint == Hint.AllOf).Select(x => x.TypeData?.CSharpTypeWithNullabilityForValueTypes))}>", true),

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
            (null, "float") => ("float", false),
            ("number", "double") => ("double", false),
            (null, "double") => ("double", false),
            ("string", "byte") => ("byte[]", true),
            ("string", "binary") => ("byte[]", true),
            ("string", "date") => ("global::System.DateTime", false),
            ("string", "date-time") => ("global::System.DateTime", false),
            ("string", "password") => ("string", true),
            
            // Possible future types - not supported yet
            // ("string", "time") => ("global::System.TimeOnly", false),
            // ("string", "date") => ("global::System.DateOnly", false),
            // ("string", "period") => ("global::System.TimeSpan", false),
            // ("string", "duration") => ("global::System.TimeSpan", false),
            // ("string", "uri") => ("global::System.Uri", true),
            ("string", "uuid") => ("global::System.Guid", false),
            
            (null, "url") => ("string", true),

            ("integer", _) => ("int", false),
            ("number", _) => ("double", false),
            ("string", _) => ("string", true),
            ("object", _) => ("object", true),
            ("array", _) =>
                ($"{context.Children.FirstOrDefault(x => x.Hint == Hint.ArrayItem)?.TypeData?.CSharpTypeWithoutNullability}".AsArray(), true),
            
            (null, null) when context.IsClass || context.IsEnum =>
                ($"global::{context.Settings.Namespace}.{context.Id}", true),
            (null, null)  => ("object", true),
            ("null", _)  => ("object", true),
            _ => throw new NotSupportedException($"Type {context.Schema.Type} is not supported."),
        };

        return context.Schema.Nullable ||
               reference && !context.IsRequired && additionalContext?.IsRequired != true
            ? type + "?"
            : type;
    }
}