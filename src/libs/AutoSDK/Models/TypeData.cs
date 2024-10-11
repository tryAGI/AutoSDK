using System.Collections.Immutable;
using AutoSDK.Extensions;

namespace AutoSDK.Models;

public readonly record struct TypeData(
    string CSharpTypeRaw,
    bool CSharpTypeNullability,
    bool IsArray,
    bool IsNullable,
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
        CSharpTypeRaw: string.Empty,
        CSharpTypeNullability: false,
        IsArray: false,
        IsNullable: false,
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
    
    public string CSharpTypeWithoutNullability => CSharpTypeRaw.TrimEnd('?');
    public string CSharpTypeWithNullability => CSharpTypeWithoutNullability + "?";
    public string ShortCSharpTypeWithoutNullability => CSharpTypeWithoutNullability.Replace($"global::{Namespace}.", string.Empty);
    public string ShortCSharpTypeWithNullability => ShortCSharpTypeWithoutNullability + "?";
    public bool IsAnyOfLike => AnyOfCount > 0 || OneOfCount > 0 || AllOfCount > 0;
    public string CSharpTypeWithNullabilityForValueTypes => IsValueType
        ? CSharpTypeWithNullability
        : CSharpTypeWithoutNullability;
    public string CSharpType => CSharpTypeNullability
        ? CSharpTypeWithNullability
        : CSharpTypeWithoutNullability;

    public bool IsReferenceable =>
        IsValueType ||
        CSharpTypeWithoutNullability is "string" ||
        IsAnyOfLike ||
        IsEnum;
    
    public string ConverterType =>
        IsUnixTimestamp
            ? $"global::{Settings.Namespace}.JsonConverters.UnixTimestampJsonConverter"
            : IsEnum || (IsAnyOfLike && IsComponent)
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
        if (context.Schema.ResolveIfRequired() is { } referenceSchema)
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
                    CSharpTypeRaw = "byte",
                },
            ];
        }
        
        var enumValues = ImmutableArray<string>.Empty;
        if (context.Schema.IsEnum())
        {
            var values = context.Schema.Enum
                .Select(value => value.ToEnumValue(
                    description: context.Parameter?.Description ?? context.Schema.Description ?? string.Empty,
                    context.Settings)).ToArray();
            properties = values
                .Select(x => x.Name)
                .ToImmutableArray();
            enumValues = values
                .Select(x => x.Id)
                .ToImmutableArray();
        }
        
        var type = GetCSharpType(context);
        
        return new TypeData(
            CSharpTypeRaw: type,
            CSharpTypeNullability: GetCSharpNullability(context),
            IsValueType: ContextIsValueType(context),
            IsNullable: context.Schema.Nullable,
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
    
    public static string GetCSharpType(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        var type = (context.Schema.Type, context.Schema.Format) switch
        {
            (_, _) when context.Schema.IsUnixTimestamp() => "global::System.DateTimeOffset",
            
            (_, _) when context.Schema.IsAnyOf() && context.IsComponent => $"global::{context.Settings.Namespace}.{context.Id}",
            (_, _) when context.Schema.IsOneOf() && context.IsComponent => $"global::{context.Settings.Namespace}.{context.Id}",
            (_, _) when context.Schema.IsAllOf() && context.IsComponent => $"global::{context.Settings.Namespace}.{context.Id}",
            
            (_, _) when context.Schema.IsAnyOf() => $"global::{context.Settings.Namespace}.AnyOf<{string.Join(", ", context.Children.Where(x => x.Hint == Hint.AnyOf).Select(x => x.TypeData?.CSharpTypeWithNullabilityForValueTypes))}>",
            (_, _) when context.Schema.IsOneOf() => $"global::{context.Settings.Namespace}.OneOf<{string.Join(", ", context.Children.Where(x => x.Hint == Hint.OneOf).Select(x => x.TypeData?.CSharpTypeWithNullabilityForValueTypes))}>",
            (_, _) when context.Schema.IsAllOf() => $"global::{context.Settings.Namespace}.AllOf<{string.Join(", ", context.Children.Where(x => x.Hint == Hint.AllOf).Select(x => x.TypeData?.CSharpTypeWithNullabilityForValueTypes))}>",

            ("object", _) or (null, _) when
                context.Schema.Reference != null &&
                (context.Schema.ResolveIfRequired().Properties.Count > 0 ||
                 !context.Schema.ResolveIfRequired().AdditionalPropertiesAllowed) =>
                $"global::{context.Settings.Namespace}.{context.Id}",
            
            // ("object", _) or (null, "object") when context.Schema.Reference == null =>
            //     $"global::{context.Settings.Namespace}.{context.Id}",
            
            ("object", _) or (null, "object") when
                context.Schema.Reference == null &&
                (context.Schema.Properties.Count > 0 ||
                !context.Schema.AdditionalPropertiesAllowed) =>
                $"global::{context.Settings.Namespace}.{context.Id}",
            
            ("object", _) when
                context.Schema.AdditionalProperties?.Type is not null =>
                $"global::System.Collections.Generic.Dictionary<string, {context.Children.FirstOrDefault(x => x.Hint == Hint.AdditionalProperties)?.TypeData?.CSharpType}>",
            
            ("string", _) when context.Schema.Enum.Any() =>
                $"global::{context.Settings.Namespace}.{context.Id}",

            ("boolean", _) => "bool",
            (null, "boolean") => "bool",
            ("integer", "int32") => "int",
            ("integer", "int64") => "long",
            ("number", "float") => "float",
            (null, "float") => "float",
            ("number", "double") => "double",
            (null, "double") => "double",
            ("string", "byte") => "byte[]",
            ("string", "binary") => "byte[]",
            ("string", "date") => "global::System.DateTime",
            ("string", "date-time") => "global::System.DateTime",
            ("string", "password") => "string",
            
            // Possible future types - not supported yet
            // ("string", "time") => "global::System.TimeOnly",
            // ("string", "date") => "global::System.DateOnly",
            // ("string", "period") => "global::System.TimeSpan",
            // ("string", "duration") => "global::System.TimeSpan",
            // ("string", "uri") => "global::System.Uri",
            ("string", "uuid") => "global::System.Guid",
            
            (null, "url") => "string",

            ("integer", _) => "int",
            ("number", _) => "double",
            ("string", _) => "string",
            (null, "string") => "string",
            ("object", _) => "object",
            ("array", _) =>
                $"{context.Children.FirstOrDefault(x => x.Hint == Hint.ArrayItem)?.TypeData?.CSharpTypeWithoutNullability}".AsArray(),
            
            (null, null) when context.IsClass || context.IsEnum =>
                $"global::{context.Settings.Namespace}.{context.Id}",
            (null, null)  => "object",
            ("null", _)  => "object",
            ("any", _)  => "object",
            _ => throw new NotSupportedException($"Type {context.Schema.Type} is not supported."),
        };

        return type;
    }

    public static bool GetCSharpNullability(
        SchemaContext context,
        SchemaContext? additionalContext = null)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        return context.Schema.Nullable ||
               !context.IsRequired && additionalContext?.IsRequired != true;
    }
}