using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.TypeMapping;

public static class CSharpTypeDataExtensions
{
    public static TypeData WithCSharpComputedValues(this TypeData type)
    {
        var csharpTypeWithoutNullability = type.CSharpTypeRaw.TrimEnd('?');
        var csharpTypeWithNullability = csharpTypeWithoutNullability + "?";
        var shortCSharpTypeWithoutNullability = csharpTypeWithoutNullability.Replace(
            $"global::{type.Namespace}.",
            string.Empty);
        var shortCSharpTypeWithNullability = shortCSharpTypeWithoutNullability + "?";
        var isAnyOfLike = type.AnyOfCount > 0 || type.OneOfCount > 0 || type.AllOfCount > 0;
        var csharpTypeWithNullabilityForValueTypes = type.IsValueType
            ? csharpTypeWithNullability
            : csharpTypeWithoutNullability;
        var csharpTypeWithNullabilityForNonValueTypes = type.IsValueType
            ? csharpTypeWithoutNullability
            : csharpTypeWithNullability;
        var csharpType = type.CSharpTypeNullability
            ? csharpTypeWithNullability
            : csharpTypeWithoutNullability;
        var converterType = GetConverterType(type, shortCSharpTypeWithoutNullability, isAnyOfLike);

        return type with
        {
            CSharpTypeWithoutNullability = csharpTypeWithoutNullability,
            CSharpTypeWithNullability = csharpTypeWithNullability,
            ShortCSharpTypeWithoutNullability = shortCSharpTypeWithoutNullability,
            ShortCSharpTypeWithNullability = shortCSharpTypeWithNullability,
            IsAnyOfLike = isAnyOfLike,
            CSharpTypeWithNullabilityForValueTypes = csharpTypeWithNullabilityForValueTypes,
            CSharpTypeWithNullabilityForNonValueTypes = csharpTypeWithNullabilityForNonValueTypes,
            CSharpType = csharpType,
            IsReferenceable =
                type.IsValueType ||
                csharpTypeWithoutNullability is "string" ||
                isAnyOfLike ||
                type.IsEnum,
            ConverterType = converterType,
            DependencyHash = GetDependencyHash(type, isAnyOfLike, converterType),
        };
    }

    private static string GetConverterType(TypeData type, string shortCSharpTypeWithoutNullability, bool isAnyOfLike)
    {
        if (type.IsUnixTimestamp)
        {
            return $"global::{type.GeneratedNamespace}.JsonConverters.UnixTimestampJsonConverter";
        }

        if (type.AnyOfCount > 0)
        {
            return isAnyOfLike && (type.IsComponent || type.HasDiscriminator)
                ? $"global::{type.GeneratedNamespace}.JsonConverters.{shortCSharpTypeWithoutNullability}JsonConverter"
                : $"global::{type.GeneratedNamespace}.JsonConverters.AnyOfJsonConverter<{GetSubtypeList(type)}>";
        }

        if (type.OneOfCount > 0)
        {
            return isAnyOfLike && (type.IsComponent || type.HasDiscriminator)
                ? $"global::{type.GeneratedNamespace}.JsonConverters.{shortCSharpTypeWithoutNullability}JsonConverter"
                : $"global::{type.GeneratedNamespace}.JsonConverters.OneOfJsonConverter<{GetSubtypeList(type)}>";
        }

        if (type.AllOfCount > 0)
        {
            return isAnyOfLike && (type.IsComponent || type.HasDiscriminator)
                ? $"global::{type.GeneratedNamespace}.JsonConverters.{shortCSharpTypeWithoutNullability}JsonConverter"
                : $"global::{type.GeneratedNamespace}.JsonConverters.AllOfJsonConverter<{GetSubtypeList(type)}>";
        }

        if (type.IsEnum)
        {
            return $"global::{type.GeneratedNamespace}.JsonConverters.{shortCSharpTypeWithoutNullability}JsonConverter";
        }

        return string.Empty;
    }

    private static string GetSubtypeList(TypeData type)
    {
        return string.Join(
            ", ",
            type.SubTypes.Select(x =>
            {
                var subType = x.Unbox<TypeData>();
                return string.IsNullOrEmpty(subType.CSharpTypeWithNullabilityForValueTypes)
                    ? subType.WithCSharpComputedValues().CSharpTypeWithNullabilityForValueTypes
                    : subType.CSharpTypeWithNullabilityForValueTypes;
            }));
    }

    private static int GetDependencyHash(TypeData type, bool isAnyOfLike, string converterType)
    {
        var hash = 17;
        AddOrdinal(ref hash, type.CSharpTypeRaw);
        AddHash(ref hash, type.CSharpTypeNullability);
        AddHash(ref hash, type.IsBaseClass);
        AddHash(ref hash, type.IsDerivedClass);
        AddHash(ref hash, type.IsArray);
        AddHash(ref hash, type.IsNullable);
        AddHash(ref hash, type.IsEnum);
        AddHash(ref hash, type.IsBase64);
        AddHash(ref hash, type.IsDate);
        AddHash(ref hash, type.IsDateTime);
        AddHash(ref hash, type.IsBinary);
        AddHash(ref hash, type.IsValueType);
        AddHash(ref hash, type.IsUnixTimestamp);
        AddHash(ref hash, type.AnyOfCount);
        AddHash(ref hash, type.OneOfCount);
        AddHash(ref hash, type.AllOfCount);
        AddHash(ref hash, type.IsComponent);
        AddHash(ref hash, type.HasDiscriminator);
        AddOrdinal(ref hash, type.Namespace);
        AddOrdinal(ref hash, type.GeneratedNamespace);
        AddHash(ref hash, type.IsDeprecated);
        AddHash(ref hash, isAnyOfLike);
        AddOrdinal(ref hash, converterType);

        foreach (var property in type.Properties)
        {
            AddOrdinal(ref hash, property);
        }

        foreach (var enumValue in type.EnumValues)
        {
            AddOrdinal(ref hash, enumValue);
        }

        foreach (var subType in type.SubTypes)
        {
            AddHash(ref hash, subType.Unbox<TypeData>().DependencyHash);
        }

        return hash;
    }

    private static void AddOrdinal(ref int hash, string? value)
    {
        AddHash(ref hash, value is null ? 0 : StringComparer.Ordinal.GetHashCode(value));
    }

    private static void AddHash(ref int hash, bool value)
    {
        AddHash(ref hash, value ? 1 : 0);
    }

    private static void AddHash(ref int hash, int value)
    {
        unchecked
        {
            hash = (hash * 31) + value;
        }
    }
}
