using System.Collections.Immutable;
using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Models;
using Microsoft.OpenApi;

namespace AutoSDK.TypeMapping;

#pragma warning disable CA1308

public static class CSharpTypeMapper
{
    public static TypeData CreateTypeData(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        if (context.IsReference && context.ResolvedReference != null)
        {
            return CreateReferenceTypeData(context);
        }

        var schema = context.Schema;
        var isEnum = schema.IsEnum();
        var isOpenEnum = isEnum && schema.IsOpenEnum();
        var isAnyOf = schema.IsAnyOf();
        var isOneOf = schema.IsOneOf();
        var isAllOf = schema.IsAllOf();
        var isArray = schema.IsArray();
        var isBinary = schema.IsBinary();
        var isBase64 = schema.IsBase64();
        var generatedNamespace = context.GetGeneratedNamespace();

        var resolvedSchema = schema.ResolveIfRequired();

        string? cachedType = null;
        if (!isEnum && !isAnyOf && !isOneOf && !isAllOf &&
            !isArray && !isBinary && !isBase64 &&
            resolvedSchema is not { Properties.Count: > 0 })
        {
            cachedType = GetCSharpTypeCore(context, isArray, isAnyOf, isOneOf, isAllOf);
            if (cachedType is "bool" or "int" or "long" or "short" or "byte" or "float" or "double"
                or "decimal" or "char" or "string" or "object" or "byte[]"
                or "global::System.DateTime" or "global::System.DateTimeOffset" or "global::System.Guid")
            {
                return new TypeData(
                    CSharpTypeRaw: cachedType,
                    CSharpTypeNullability: GetCSharpNullability(context),
                    IsBaseClass: false,
                    IsDerivedClass: false,
                    IsValueType: IsValueType(context),
                    IsNullable: schema.IsNullable() || schema.IsNullableAnyOf(),
                    IsArray: false,
                    IsEnum: false,
                    IsOpenEnum: false,
                    IsBase64: false,
                    IsDate: schema.IsDate(),
                    IsDateTime: schema.IsDateTime(),
                    IsBinary: false,
                    IsUnixTimestamp: schema.IsUnixTimestamp(),
                    AnyOfCount: 0,
                    OneOfCount: 0,
                    AllOfCount: 0,
                    IsComponent: context.IsComponent,
                    HasDiscriminator: schema.Discriminator != null,
                    Properties: ImmutableArray<string>.Empty,
                    EnumValues: ImmutableArray<string>.Empty,
                    SubTypes: ImmutableArray<Box>.Empty,
                    Namespace: cachedType.StartsWith("global::System.", StringComparison.Ordinal)
                        ? "System"
                        : generatedNamespace,
                    GeneratedNamespace: generatedNamespace,
                    IsDeprecated: schema.IsDeprecated(),
                    CSharpTypeWithoutNullability: string.Empty,
                    CSharpTypeWithNullability: "?",
                    ShortCSharpTypeWithoutNullability: string.Empty,
                    ShortCSharpTypeWithNullability: "?",
                    IsAnyOfLike: false,
                    CSharpTypeWithNullabilityForValueTypes: string.Empty,
                    CSharpTypeWithNullabilityForNonValueTypes: "?",
                    CSharpType: string.Empty,
                    IsReferenceable: false,
                    ConverterType: string.Empty)
                    .WithCSharpComputedValues();
            }
        }

        var properties = ImmutableArray<string>.Empty;
        if (resolvedSchema is { Properties: { Count: > 0 } props })
        {
            var builder = ImmutableArray.CreateBuilder<string>(props.Count);
            foreach (var kvp in props)
            {
                builder.Add(kvp.Key);
            }

            properties = builder.MoveToImmutable();
        }

        var boxedSubTypes = ImmutableArray<Box>.Empty;
        if (isAnyOf)
        {
            boxedSubTypes = CollectChildBoxedTypeData(context.Children, Hint.AnyOf);
        }
        else if (isOneOf)
        {
            boxedSubTypes = CollectChildBoxedTypeData(context.Children, Hint.OneOf);
        }
        else if (isAllOf)
        {
            boxedSubTypes = CollectChildBoxedTypeData(context.Children, Hint.AllOf);
        }

        if (isArray)
        {
            TypeData arrayItemType = TypeData.Default;
            for (var ci = 0; ci < context.Children.Count; ci++)
            {
                var child = context.Children[ci];
                if (child is { Hint: Hint.ArrayItem } && child.TypeData != TypeData.Default)
                {
                    arrayItemType = child.TypeData;
                    break;
                }
            }

            if (arrayItemType == TypeData.Default)
            {
                arrayItemType = (TypeData.Default with
                {
                    IsEnum = schema.Items != null && schema.Items.IsEnum(),
                    IsOpenEnum = schema.Items != null && schema.Items.IsOpenEnum(),
                }).WithCSharpComputedValues();
            }

            boxedSubTypes = [arrayItemType.Box()];
        }

        if (isBinary || isBase64)
        {
            boxedSubTypes = [(TypeData.Default with { CSharpTypeRaw = "byte" }).WithCSharpComputedValues().Box()];
        }

        var enumValues = ImmutableArray<string>.Empty;
        if (isEnum)
        {
            var computedEnum = context.ComputeEnum();
            if (computedEnum.Count > 0)
            {
                var nameBuilder = ImmutableArray.CreateBuilder<string>(computedEnum.Count);
                var idBuilder = ImmutableArray.CreateBuilder<string>(computedEnum.Count);
                foreach (var kvp in computedEnum)
                {
                    nameBuilder.Add(kvp.Value.Name);
                    idBuilder.Add(kvp.Key);
                }

                properties = nameBuilder.MoveToImmutable();
                enumValues = idBuilder.MoveToImmutable();
            }
        }

        var type = cachedType ?? GetCSharpTypeCore(context, isArray, isAnyOf, isOneOf, isAllOf);
        var isNullable = schema.IsNullable() || schema.IsNullableAnyOf();
        var collapsed = (isAnyOf || isOneOf || isAllOf) && IsCollapsedAnyOfLike(context);
        var usesGeneratedJsonHelpers = ShouldUseGeneratedJsonHelpers(context, type, generatedNamespace);

        return (new TypeData(
            CSharpTypeRaw: type,
            CSharpTypeNullability: GetCSharpNullability(context),
            IsBaseClass: context.IsBaseClass,
            IsDerivedClass: context.IsDerivedClass,
            IsValueType: IsValueType(context),
            IsNullable: isNullable,
            IsArray: isArray,
            IsEnum: isEnum,
            IsOpenEnum: isOpenEnum,
            IsBase64: isBase64,
            IsDate: schema.IsDate(),
            IsDateTime: schema.IsDateTime(),
            IsBinary: isBinary,
            IsUnixTimestamp: schema.IsUnixTimestamp(),
            AnyOfCount: isAnyOf && !collapsed
                ? schema.AnyOf?.Count ?? 0
                : 0,
            OneOfCount: isOneOf && !collapsed
                ? schema.OneOf?.Count ?? 0
                : 0,
            AllOfCount: isAllOf && !collapsed
                ? schema.AllOf?.Count ?? 0
                : 0,
            IsComponent: context.IsComponent,
            HasDiscriminator: schema.Discriminator != null,
            Properties: properties,
            EnumValues: enumValues,
            SubTypes: boxedSubTypes,
            Namespace: type.StartsWith("global::System.", StringComparison.Ordinal)
                ? "System"
                : generatedNamespace,
            GeneratedNamespace: generatedNamespace,
            IsDeprecated: schema.IsDeprecated(),
            CSharpTypeWithoutNullability: string.Empty,
            CSharpTypeWithNullability: "?",
            ShortCSharpTypeWithoutNullability: string.Empty,
            ShortCSharpTypeWithNullability: "?",
            IsAnyOfLike: false,
            CSharpTypeWithNullabilityForValueTypes: string.Empty,
            CSharpTypeWithNullabilityForNonValueTypes: "?",
            CSharpType: string.Empty,
            IsReferenceable: false,
            ConverterType: string.Empty)
        {
            UsesGeneratedJsonHelpers = usesGeneratedJsonHelpers,
        })
            .WithCSharpComputedValues();
    }

    private static bool ShouldUseGeneratedJsonHelpers(SchemaContext context, string type, string generatedNamespace)
    {
        if (!type.StartsWith($"global::{generatedNamespace}.", StringComparison.Ordinal))
        {
            return false;
        }

        return context.IsClass || context.IsAnyOfLikeStructure;
    }

    private static TypeData CreateReferenceTypeData(SchemaContext context)
    {
        var resolvedReference = context.ResolvedReference
            ?? throw new InvalidOperationException("Resolved reference is required.");
        var resolvedType = resolvedReference.TypeData != TypeData.Default
            ? resolvedReference.TypeData
            : CreateTypeData(resolvedReference);
        var nullability = GetCSharpNullability(resolvedReference, context);

        if (!resolvedReference.IsFilteredOutModel ||
            !CSharpNamespacedTypeNameResolver.TryResolve(
                context.ReferenceId ?? resolvedReference.ComponentId ?? string.Empty,
                context.Settings,
                out var namespaced))
        {
            return (resolvedType with
            {
                CSharpTypeNullability = nullability,
            }).WithCSharpComputedValues();
        }

        var namespaceValue = context.Settings.ExcludedModelNamespaceMode switch
        {
            ExcludedModelNamespaceMode.SdkRoot => namespaced!.GeneratedNamespace,
            _ => namespaced!.NamespaceSuffix,
        };

        return (resolvedType with
        {
            CSharpTypeRaw = $"global::{namespaced.GetQualifiedName(context.Settings.ExcludedModelNamespaceMode)}",
            CSharpTypeNullability = nullability,
            IsComponent = false,
            IsEnum = false,
            IsOpenEnum = false,
            AnyOfCount = 0,
            OneOfCount = 0,
            AllOfCount = 0,
            HasDiscriminator = false,
            Properties = ImmutableArray<string>.Empty,
            EnumValues = ImmutableArray<string>.Empty,
            SubTypes = ImmutableArray<Box>.Empty,
            Namespace = namespaceValue,
            GeneratedNamespace = namespaceValue,
            UsesGeneratedJsonHelpers = false,
        }).WithCSharpComputedValues();
    }

    public static bool IsValueType(SchemaContext context)
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

            (null, "float") => true,
            (null, "double") => true,
            (null, "boolean") => true,

            _ => false,
        };
    }

    public static string GetCSharpType(SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        return GetCSharpTypeCore(
            context,
            isArray: context.Schema.IsArray(),
            isAnyOf: context.Schema.IsAnyOf(),
            isOneOf: context.Schema.IsOneOf(),
            isAllOf: context.Schema.IsAllOf());
    }

    public static bool GetCSharpNullability(
        SchemaContext context,
        SchemaContext? additionalContext = null)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));

        return context.Schema.IsNullable() ||
               context.Schema.IsNullableAnyOf() ||
               !context.IsRequired && additionalContext?.IsRequired != true;
    }

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

    private static ImmutableArray<Box> CollectChildBoxedTypeData(IList<SchemaContext> children, Hint hint)
    {
        var count = 0;
        for (var i = 0; i < children.Count; i++)
        {
            var child = children[i];
            if (child.Hint == hint && child.TypeData != TypeData.Default)
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
            if (child.Hint == hint && child.TypeData != TypeData.Default)
            {
                builder.Add(child.TypeData.Box());
            }
        }

        return builder.MoveToImmutable();
    }

    private static string GetCSharpTypeCore(
        SchemaContext context,
        bool isArray,
        bool isAnyOf,
        bool isOneOf,
        bool isAllOf)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        var resolvedSchema = context.Schema.ResolveIfRequired();
        var generatedNamespace = context.GetGeneratedNamespace();

        return (context.Schema.Type.ToTypeString(), context.Schema.Format) switch
        {
            (_, _) when context.Schema.IsUnixTimestamp() => "global::System.DateTimeOffset",

            (_, _) when isArray =>
                $"{FindChildType(context.Children, Hint.ArrayItem)}".AsArray(),
            ("array", _) => "byte[]",

            (_, _) when context.IsNamedAnyOfLike => $"global::{generatedNamespace}.{context.Id}",
            (_, _) when context.IsDerivedClass => $"global::{generatedNamespace}.{context.Id}",

            (_, _) when context.Schema.IsNullableAnyOf() =>
                FindNonNullAnyOfChildType(context.Children) ?? "object",

            (_, _) when isAnyOf && !context.IsNamedAnyOfLike && GetDistinctChildTypes(context, Hint.AnyOf) is { Length: 1 } distinctAnyOf => distinctAnyOf[0],
            (_, _) when isOneOf && !context.IsNamedAnyOfLike && GetDistinctChildTypes(context, Hint.OneOf) is { Length: 1 } distinctOneOf => distinctOneOf[0],
            (_, _) when isAllOf && !context.IsNamedAnyOfLike && GetDistinctChildTypes(context, Hint.AllOf) is { Length: 1 } distinctAllOf => distinctAllOf[0],

            (_, _) when isAnyOf => $"global::{generatedNamespace}.AnyOf<{JoinChildTypes(context, Hint.AnyOf)}>",
            (_, _) when isOneOf => $"global::{generatedNamespace}.OneOf<{JoinChildTypes(context, Hint.OneOf)}>",
            (_, _) when isAllOf => $"global::{generatedNamespace}.AllOf<{JoinChildTypes(context, Hint.AllOf)}>",

            ("object", _) or (null, _) when
                context.Schema.IsSchemaReference() &&
                ((context.Schema.ResolveIfRequired().Properties?.Count ?? 0) > 0 ||
                 !context.Schema.ResolveIfRequired().AdditionalPropertiesAllowed) =>
                $"global::{generatedNamespace}.{context.Id}",

            ("object", _) or (null, "object") when
                !context.Schema.IsSchemaReference() &&
                ((context.Schema.Properties?.Count ?? 0) > 0 ||
                 !context.Schema.AdditionalPropertiesAllowed) =>
                $"global::{generatedNamespace}.{context.Id}",

            ("object", _) when context.Schema.AdditionalProperties?.Type is not null =>
                $"global::System.Collections.Generic.Dictionary<string, {FindChildCSharpType(context.Children, Hint.AdditionalProperties)}>",

            ("object", _) or (null, _) when
                (context.IsComponent || context.Schema.IsSchemaReference()) &&
                (resolvedSchema.Properties?.Count ?? 0) == 0 &&
                resolvedSchema.AdditionalPropertiesAllowed &&
                resolvedSchema.AdditionalProperties?.Type is null =>
                $"global::{generatedNamespace}.{context.Id}",

            ("string", _) when (context.Schema.Enum?.Count ?? 0) > 0 =>
                $"global::{generatedNamespace}.{context.Id}",

            (null, "boolean") => "bool",
            (null, "float") => "float",
            (null, "double") => "double",

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
            ("string", "uuid") => "global::System.Guid",

            ("file", "binary") => "byte[]",
            (_, "binary") => "byte[]",

            (null, "url") => "string",

            ("integer", _) => "int",
            ("number", _) => "double",
            ("string", _) => "string",
            (null, "string") => "string",
            ("object", _) => "object",

            (null, null) when HasDeclaredClassProperties(context) || context.IsEnum =>
                $"global::{generatedNamespace}.{context.Id}",
            (null, null) when context.Schema.IsConst() => "string",
            (null, null) => "object",
            ("null", _) => "object",
            ("any", _) => "object",
            _ => throw new NotSupportedException($"Type {context.Schema.Type} is not supported."),
        };
    }

    private static string? FindChildType(IList<SchemaContext> children, Hint hint)
    {
        for (var i = 0; i < children.Count; i++)
        {
            var child = children[i];
            if (child.Hint == hint && child.TypeData != TypeData.Default)
            {
                return child.TypeData.CSharpTypeWithoutNullability;
            }
        }

        return null;
    }

    private static string? FindChildCSharpType(IList<SchemaContext> children, Hint hint)
    {
        for (var i = 0; i < children.Count; i++)
        {
            if (children[i].Hint == hint)
            {
                return children[i].TypeData.CSharpType;
            }
        }

        return null;
    }

    private static string? FindNonNullAnyOfChildType(IList<SchemaContext> children)
    {
        for (var i = 0; i < children.Count; i++)
        {
            var child = children[i];
            if (child.Hint == Hint.AnyOf && !child.Schema.IsNullType())
            {
                return child.TypeData.CSharpTypeWithoutNullability;
            }
        }

        return null;
    }

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

        if (count == 0)
        {
            return [];
        }

        var result = new string[count];
        var index = 0;
        seen.Clear();
        for (var i = 0; i < context.Children.Count; i++)
        {
            var child = context.Children[i];
            if (child.Hint == hint && seen.Add(child.TypeData.CSharpTypeWithoutNullability))
            {
                result[index++] = child.TypeData.CSharpTypeWithoutNullability;
            }
        }

        return result;
    }

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
                if (sb.Length > 0)
                {
                    sb.Append(", ");
                }

                sb.Append(child.TypeData.CSharpTypeWithNullabilityForValueTypes);
            }
        }

        return sb.ToString();
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

        for (var i = 0; i < propertyContexts.Count; i++)
        {
            if (propertyContexts[i].IsProperty)
            {
                return true;
            }
        }

        return false;
    }
}
