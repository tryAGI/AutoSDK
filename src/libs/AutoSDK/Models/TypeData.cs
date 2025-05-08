using System.Collections.Immutable;
using AutoSDK.Extensions;

namespace AutoSDK.Models;

public record struct TypeData(
    string CSharpTypeRaw,
    bool CSharpTypeNullability,
    bool IsBaseClass,
    bool IsDerivedClass,
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
    bool HasDiscriminator,
    EquatableArray<string> Properties,
    EquatableArray<string> EnumValues,
    EquatableArray<TypeData> SubTypes,
    string Namespace,
    bool IsDeprecated,
    Settings Settings)
{
    public static TypeData Default => new(
        CSharpTypeRaw: string.Empty,
        CSharpTypeNullability: false,
        IsBaseClass: false,
        IsDerivedClass: false,
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
        HasDiscriminator: false,
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
    public string CSharpTypeWithNullabilityForNonValueTypes => IsValueType
        ? CSharpTypeWithoutNullability
        : CSharpTypeWithNullability;
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
            : IsEnum || (IsAnyOfLike && (IsComponent || HasDiscriminator))
                ? $"global::{Settings.Namespace}.JsonConverters.{ShortCSharpTypeWithoutNullability}JsonConverter"
                : AnyOfCount > 0
                    ? $"global::{Settings.Namespace}.JsonConverters.AnyOfJsonConverter<{string.Join(", ", SubTypes.Select(y => y.CSharpTypeWithNullabilityForValueTypes))}>"
                    : OneOfCount > 0
                        ? $"global::{Settings.Namespace}.JsonConverters.OneOfJsonConverter<{string.Join(", ", SubTypes.Select(y => y.CSharpTypeWithNullabilityForValueTypes))}>"
                        : AllOfCount > 0
                            ? $"global::{Settings.Namespace}.JsonConverters.AllOfJsonConverter<{string.Join(", ", SubTypes.Select(y => y.CSharpTypeWithNullabilityForValueTypes))}>"
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
                .Where(x => x is { Hint: Hint.AnyOf } && x.TypeData != Default)
                .Select(x => x.TypeData)
                .ToImmutableArray();
        }
        else if (context.Schema.IsOneOf())
        {
            subTypes = context.Children
                .Where(x => x is { Hint: Hint.OneOf } && x.TypeData != Default)
                .Select(x => x.TypeData)
                .ToImmutableArray();
        }
        else if (context.Schema.IsAllOf())
        {
            subTypes = context.Children
                .Where(x => x is { Hint: Hint.AllOf } && x.TypeData != Default)
                .Select(x => x.TypeData)
                .ToImmutableArray();
        }
        if (context.Schema.IsArray())
        {
            subTypes = [
                context.Children
                    .FirstOrDefault(x => x is { Hint: Hint.ArrayItem } && x.TypeData != Default)
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
            IsBaseClass: context.IsBaseClass,
            IsDerivedClass: context.IsDerivedClass,
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
            HasDiscriminator: context.Schema.Discriminator != null,
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
            
            // AssemblyAI format
            (null, "float") => true,
            (null, "double") => true,
            (null, "boolean") => true,
            
            _ => false,
        };
    }
    
    public static string GetCSharpType(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        var type = (context.Schema.Type, context.Schema.Format) switch
        {
            (_, _) when context.Schema.IsUnixTimestamp() => "global::System.DateTimeOffset",
            
            (_, _) when context.Schema.IsArray() =>
                $"{context.Children.FirstOrDefault(x => x.Hint == Hint.ArrayItem)?.TypeData.CSharpTypeWithoutNullability}".AsArray(),
            // Fallback if `items` property is missing (openai specification)
            ("array", _) => "byte[]",
                
            (_, _) when context.IsNamedAnyOfLike => $"global::{context.Settings.Namespace}.{context.Id}",
            (_, _) when context.IsDerivedClass => $"global::{context.Settings.Namespace}.{context.Id}",
            
            (_, _) when context.Schema.IsAnyOf() => $"global::{context.Settings.Namespace}.AnyOf<{string.Join(", ", context.Children.Where(x => x.Hint == Hint.AnyOf).Select(x => x.TypeData.CSharpTypeWithNullabilityForValueTypes))}>",
            (_, _) when context.Schema.IsOneOf() => $"global::{context.Settings.Namespace}.OneOf<{string.Join(", ", context.Children.Where(x => x.Hint == Hint.OneOf).Select(x => x.TypeData.CSharpTypeWithNullabilityForValueTypes))}>",
            (_, _) when context.Schema.IsAllOf() => $"global::{context.Settings.Namespace}.AllOf<{string.Join(", ", context.Children.Where(x => x.Hint == Hint.AllOf).Select(x => x.TypeData.CSharpTypeWithNullabilityForValueTypes))}>",

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
                $"global::System.Collections.Generic.Dictionary<string, {context.Children.FirstOrDefault(x => x.Hint == Hint.AdditionalProperties)?.TypeData.CSharpType}>",
            
            ("string", _) when context.Schema.Enum.Any() =>
                $"global::{context.Settings.Namespace}.{context.Id}",

            (null, "boolean") => "bool",
            (null, "float") => "float",
            (null, "double") => "double",
            
            // https://learn.microsoft.com/en-us/aspnet/core/fundamentals/openapi/include-metadata?view=aspnetcore-9.0&tabs=minimal-apis#type-and-format
            ("boolean", _) => "bool",
            ("integer", "int64") => "long",
            ("integer", "int32") => "int",
            ("integer", "int16") => "short",
            ("integer", "uint8") => "byte",
            ("number", "float") => "float",
            ("number", "double") => "double",
            ("number", "decimal") => "decimal",
            ("string", "char") => "char",
            ("string", "byte") => "byte[]",
            ("string", "binary") => "byte[]",
            ("string", "date") => "global::System.DateTime",
            ("string", "date-time") => "global::System.DateTime",
            ("string", "password") => "string",
            
            // Possible future types - not supported yet
            // ("string", "time") => "global::System.TimeOnly",
            // ("string", "date") => "global::System.DateOnly",
            // ("string", "date-time") => "global::System.DateTimeOffset",
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
            
            (null, null) when (context.IsClass && context.ClassData?.Properties.Length > 0) || context.IsEnum =>
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