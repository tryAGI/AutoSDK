using System.Collections.Immutable;
using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using Microsoft.OpenApi;

namespace AutoSDK.Models;

#pragma warning disable CA1308

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
    EquatableArray<Box> SubTypes,
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
                    ? $"global::{Settings.Namespace}.JsonConverters.AnyOfJsonConverter<{string.Join(", ", SubTypes.Select(y => y.Unbox<TypeData>().CSharpTypeWithNullabilityForValueTypes))}>"
                    : OneOfCount > 0
                        ? $"global::{Settings.Namespace}.JsonConverters.OneOfJsonConverter<{string.Join(", ", SubTypes.Select(y => y.Unbox<TypeData>().CSharpTypeWithNullabilityForValueTypes))}>"
                        : AllOfCount > 0
                            ? $"global::{Settings.Namespace}.JsonConverters.AllOfJsonConverter<{string.Join(", ", SubTypes.Select(y => y.Unbox<TypeData>().CSharpTypeWithNullabilityForValueTypes))}>"
                            : string.Empty;

    public static TypeData FromSchemaContext(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        // Fast path for simple primitive types — skip all LINQ/builder machinery
        if (!context.Schema.IsEnum() &&
            !context.Schema.IsAnyOf() && !context.Schema.IsOneOf() && !context.Schema.IsAllOf() &&
            !context.Schema.IsArray() && !context.Schema.IsBinary() && !context.Schema.IsBase64() &&
            context.Schema.ResolveIfRequired() is not { Properties.Count: > 0 })
        {
            var primitiveType = GetCSharpType(context);
            if (primitiveType is "bool" or "int" or "long" or "short" or "byte" or "float" or "double"
                or "decimal" or "char" or "string" or "object" or "byte[]"
                or "global::System.DateTime" or "global::System.DateTimeOffset" or "global::System.Guid")
            {
                return new TypeData(
                    CSharpTypeRaw: primitiveType,
                    CSharpTypeNullability: GetCSharpNullability(context),
                    IsBaseClass: false,
                    IsDerivedClass: false,
                    IsValueType: ContextIsValueType(context),
                    IsNullable: context.Schema.IsNullable() || context.Schema.IsNullableAnyOf(),
                    IsArray: false,
                    IsEnum: false,
                    IsBase64: false,
                    IsDate: context.Schema.IsDate(),
                    IsDateTime: context.Schema.IsDateTime(),
                    IsBinary: false,
                    IsUnixTimestamp: context.Schema.IsUnixTimestamp(),
                    AnyOfCount: 0,
                    OneOfCount: 0,
                    AllOfCount: 0,
                    IsComponent: context.IsComponent,
                    HasDiscriminator: context.Schema.Discriminator != null,
                    Properties: ImmutableArray<string>.Empty,
                    EnumValues: ImmutableArray<string>.Empty,
                    SubTypes: ImmutableArray<Box>.Empty,
                    Namespace: primitiveType.StartsWith("global::System.", StringComparison.Ordinal)
                        ? "System"
                        : context.Settings.Namespace,
                    IsDeprecated: context.Schema.IsDeprecated(),
                    Settings: context.Settings);
            }
        }

        var properties = ImmutableArray<string>.Empty;
        if (context.Schema.ResolveIfRequired() is { Properties: { Count: > 0 } props })
        {
            var builder = ImmutableArray.CreateBuilder<string>(props.Count);
            foreach (var kvp in props)
            {
                builder.Add(kvp.Key);
            }
            properties = builder.MoveToImmutable();
        }

        // Collect child type data directly as boxed values in a single pass
        var boxedSubTypes = ImmutableArray<Box>.Empty;
        if (context.Schema.IsAnyOf())
        {
            boxedSubTypes = CollectChildBoxedTypeData(context.Children, Hint.AnyOf);
        }
        else if (context.Schema.IsOneOf())
        {
            boxedSubTypes = CollectChildBoxedTypeData(context.Children, Hint.OneOf);
        }
        else if (context.Schema.IsAllOf())
        {
            boxedSubTypes = CollectChildBoxedTypeData(context.Children, Hint.AllOf);
        }
        if (context.Schema.IsArray())
        {
            TypeData arrayItemType = Default;
            for (var ci = 0; ci < context.Children.Count; ci++)
            {
                var child = context.Children[ci];
                if (child is { Hint: Hint.ArrayItem } && child.TypeData != Default)
                {
                    arrayItemType = child.TypeData;
                    break;
                }
            }
            if (arrayItemType == Default)
            {
                arrayItemType = Default with
                {
                    IsEnum = context.Schema.Items != null && context.Schema.Items.IsEnum(),
                };
            }
            boxedSubTypes = [arrayItemType.Box()];
        }
        if (context.Schema.IsBinary() || context.Schema.IsBase64())
        {
            boxedSubTypes = [(Default with { CSharpTypeRaw = "byte" }).Box()];
        }

        var enumValues = ImmutableArray<string>.Empty;
        if (context.Schema.IsEnum())
        {
            var enumSource = context.Schema.Enum;
            if (enumSource != null && enumSource.Count > 0)
            {
                var description = context.Parameter?.Description ?? context.Schema.Description ?? string.Empty;
                var nameBuilder = ImmutableArray.CreateBuilder<string>(enumSource.Count);
                var idBuilder = ImmutableArray.CreateBuilder<string>(enumSource.Count);
                foreach (var value in enumSource)
                {
                    var ev = ((JsonNode?)value).ToEnumValue(description, context.Settings);
                    nameBuilder.Add(ev.Name);
                    idBuilder.Add(ev.Id);
                }
                properties = nameBuilder.MoveToImmutable();
                enumValues = idBuilder.MoveToImmutable();
            }
        }

        var type = GetCSharpType(context);

        return new TypeData(
            CSharpTypeRaw: type,
            CSharpTypeNullability: GetCSharpNullability(context),
            IsBaseClass: context.IsBaseClass,
            IsDerivedClass: context.IsDerivedClass,
            IsValueType: ContextIsValueType(context),
            IsNullable: context.Schema.IsNullable() || context.Schema.IsNullableAnyOf(),
            IsArray: context.Schema.IsArray(),
            IsEnum: context.Schema.IsEnum(),
            IsBase64: context.Schema.IsBase64(),
            IsDate: context.Schema.IsDate(),
            IsDateTime: context.Schema.IsDateTime(),
            IsBinary: context.Schema.IsBinary(),
            IsUnixTimestamp: context.Schema.IsUnixTimestamp(),
            AnyOfCount: context.Schema.IsAnyOf() && !IsCollapsedAnyOfLike(context)
                ? context.Schema.AnyOf?.Count ?? 0
                : 0,
            OneOfCount: context.Schema.IsOneOf() && !IsCollapsedAnyOfLike(context)
                ? context.Schema.OneOf?.Count ?? 0
                : 0,
            AllOfCount: context.Schema.IsAllOf() && !IsCollapsedAnyOfLike(context)
                ? context.Schema.AllOf?.Count ?? 0
                : 0,
            IsComponent: context.IsComponent,
            HasDiscriminator: context.Schema.Discriminator != null,
            Properties: properties,
            EnumValues: enumValues,
            SubTypes: boxedSubTypes,
            Namespace: type.StartsWith("global::System.", StringComparison.Ordinal)
                ? "System"
                : context.Settings.Namespace,
            IsDeprecated: context.Schema.IsDeprecated(),
            Settings: context.Settings);
    }

    /// <summary>
    /// Collects TypeData from children matching a specific hint directly as boxed values,
    /// avoiding the intermediate ImmutableArray&lt;TypeData&gt; allocation.
    /// </summary>
    private static ImmutableArray<Box> CollectChildBoxedTypeData(IList<SchemaContext> children, Hint hint)
    {
        // Count matching children first to pre-allocate exactly
        var count = 0;
        for (var i = 0; i < children.Count; i++)
        {
            var child = children[i];
            if (child.Hint == hint && child.TypeData != Default)
            {
                count++;
            }
        }

        if (count == 0)
        {
            return ImmutableArray<Box>.Empty;
        }

        var builder = ImmutableArray.CreateBuilder<Box>(count);
        for (var i = 0; i < children.Count; i++)
        {
            var child = children[i];
            if (child.Hint == hint && child.TypeData != Default)
            {
                builder.Add(child.TypeData.Box());
            }
        }
        return builder.MoveToImmutable();
    }

    public static bool ContextIsValueType(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        return (context.Schema.Type.ToTypeString(), context.Schema.Format) switch
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

        var type = (context.Schema.Type.ToTypeString(), context.Schema.Format) switch
        {
            (_, _) when context.Schema.IsUnixTimestamp() => "global::System.DateTimeOffset",

            (_, _) when context.Schema.IsArray() =>
                $"{context.Children.FirstOrDefault(x => x.Hint == Hint.ArrayItem)?.TypeData.CSharpTypeWithoutNullability}".AsArray(),
            // Fallback if `items` property is missing (openai specification)
            ("array", _) => "byte[]",
                
            (_, _) when context.IsNamedAnyOfLike => $"global::{context.Settings.Namespace}.{context.Id}",
            (_, _) when context.IsDerivedClass => $"global::{context.Settings.Namespace}.{context.Id}",

            // Handle nullable anyOf pattern: anyOf: [X, {type: null}] -> nullable X
            (_, _) when context.Schema.IsNullableAnyOf() =>
                context.Children.FirstOrDefault(x => x.Hint == Hint.AnyOf && !x.Schema.IsNullType())?.TypeData.CSharpTypeWithoutNullability ?? "object",

            (_, _) when context.Schema.IsAnyOf() && !context.IsNamedAnyOfLike && GetDistinctChildTypes(context, Hint.AnyOf) is { Length: 1 } distinctAnyOf => distinctAnyOf[0],
            (_, _) when context.Schema.IsOneOf() && !context.IsNamedAnyOfLike && GetDistinctChildTypes(context, Hint.OneOf) is { Length: 1 } distinctOneOf => distinctOneOf[0],
            (_, _) when context.Schema.IsAllOf() && !context.IsNamedAnyOfLike && GetDistinctChildTypes(context, Hint.AllOf) is { Length: 1 } distinctAllOf => distinctAllOf[0],

            (_, _) when context.Schema.IsAnyOf() => $"global::{context.Settings.Namespace}.AnyOf<{JoinChildTypes(context, Hint.AnyOf)}>",
            (_, _) when context.Schema.IsOneOf() => $"global::{context.Settings.Namespace}.OneOf<{JoinChildTypes(context, Hint.OneOf)}>",
            (_, _) when context.Schema.IsAllOf() => $"global::{context.Settings.Namespace}.AllOf<{JoinChildTypes(context, Hint.AllOf)}>",

            ("object", _) or (null, _) when
                context.Schema.IsSchemaReference() &&
                ((context.Schema.ResolveIfRequired().Properties?.Count ?? 0) > 0 ||
                 !context.Schema.ResolveIfRequired().AdditionalPropertiesAllowed) =>
                $"global::{context.Settings.Namespace}.{context.Id}",

            // ("object", _) or (null, "object") when !context.Schema.IsSchemaReference() =>
            //     $"global::{context.Settings.Namespace}.{context.Id}",

            ("object", _) or (null, "object") when
                !context.Schema.IsSchemaReference() &&
                ((context.Schema.Properties?.Count ?? 0) > 0 ||
                !context.Schema.AdditionalPropertiesAllowed) =>
                $"global::{context.Settings.Namespace}.{context.Id}",

            ("object", _) when
                context.Schema.AdditionalProperties?.Type is not null =>
                $"global::System.Collections.Generic.Dictionary<string, {context.Children.FirstOrDefault(x => x.Hint == Hint.AdditionalProperties)?.TypeData.CSharpType}>",

            ("string", _) when (context.Schema.Enum?.Any() ?? false) =>
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
            
            // multipart/form-data
            ("file", "binary") => "byte[]",
            (_, "binary") => "byte[]",

            (null, "url") => "string",

            ("integer", _) => "int",
            ("number", _) => "double",
            ("string", _) => "string",
            (null, "string") => "string",
            ("object", _) => "object",

            (null, null) when HasDeclaredClassProperties(context) || context.IsEnum =>
                $"global::{context.Settings.Namespace}.{context.Id}",
            // Schema with const value should be treated as string
            (null, null) when context.Schema.IsConst() => "string",
            (null, null) => "object",
            ("null", _) => "object",
            ("any", _) => "object",
            _ => throw new NotSupportedException($"Type {context.Schema.Type} is not supported."),
        };

        return type;
    }

    /// <summary>
    /// Returns distinct C# types from children of a union hint, or empty if no children.
    /// Used to collapse identical anyOf/oneOf/allOf types.
    /// Reuses a thread-static HashSet to avoid per-call allocation.
    /// </summary>
    [ThreadStatic] private static HashSet<string>? s_distinctSeen;
    private static string[] GetDistinctChildTypes(SchemaContext context, Hint hint)
    {
        var seen = s_distinctSeen ??= new HashSet<string>(StringComparer.Ordinal);
        seen.Clear();
        var count = 0;
        for (var i = 0; i < context.Children.Count; i++)
        {
            var child = context.Children[i];
            if (child.Hint == hint && seen.Add(child.TypeData.CSharpTypeWithoutNullability))
            {
                count++;
            }
        }
        if (count == 0) return [];

        var result = new string[count];
        var idx = 0;
        seen.Clear();
        for (var i = 0; i < context.Children.Count; i++)
        {
            var child = context.Children[i];
            if (child.Hint == hint && seen.Add(child.TypeData.CSharpTypeWithoutNullability))
            {
                result[idx++] = child.TypeData.CSharpTypeWithoutNullability;
            }
        }
        return result;
    }

    /// <summary>
    /// Joins child type names for a given hint, avoiding LINQ .Where().Select() allocations.
    /// Reuses a thread-static StringBuilder to avoid per-call allocation.
    /// </summary>
    [ThreadStatic] private static System.Text.StringBuilder? s_joinBuilder;
    private static string JoinChildTypes(SchemaContext context, Hint hint)
    {
        var sb = s_joinBuilder ??= new System.Text.StringBuilder();
        sb.Clear();
        for (var i = 0; i < context.Children.Count; i++)
        {
            var child = context.Children[i];
            if (child.Hint == hint)
            {
                if (sb.Length > 0) sb.Append(", ");
                sb.Append(child.TypeData.CSharpTypeWithNullabilityForValueTypes);
            }
        }
        return sb.ToString();
    }

    /// <summary>
    /// Returns true if all children of a union resolve to the same C# type
    /// and the type is not a named/component anyOf-like (which needs its own class).
    /// </summary>
    public static bool IsCollapsedAnyOfLike(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        if (context.IsNamedAnyOfLike)
        {
            return false;
        }

        var hint = context.IsAnyOf ? Hint.AnyOf : context.IsOneOf ? Hint.OneOf : Hint.AllOf;
        var types = GetDistinctChildTypes(context, hint);
        return types.Length == 1;
    }

    private static bool HasDeclaredClassProperties(SchemaContext context)
    {
        if (!context.IsClass)
        {
            return false;
        }

        var propertyContexts = context.IsDerivedClass
            ? context.DerivedClassContext.Children
            : context.Children;

        return propertyContexts.Any(static x => x.IsProperty);
    }

    public static bool GetCSharpNullability(
        SchemaContext context,
        SchemaContext? additionalContext = null)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        return context.Schema.IsNullable() ||
               context.Schema.IsNullableAnyOf() || // anyOf: [X, {type: null}] is nullable
               !context.IsRequired && additionalContext?.IsRequired != true;
    }
}
