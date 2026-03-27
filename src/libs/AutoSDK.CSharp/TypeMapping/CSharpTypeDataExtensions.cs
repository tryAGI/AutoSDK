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

        if (type.IsEnum || (isAnyOfLike && (type.IsComponent || type.HasDiscriminator)))
        {
            return $"global::{type.GeneratedNamespace}.JsonConverters.{shortCSharpTypeWithoutNullability}JsonConverter";
        }

        if (type.AnyOfCount > 0)
        {
            return $"global::{type.GeneratedNamespace}.JsonConverters.AnyOfJsonConverter<{GetSubtypeList(type)}>";
        }

        if (type.OneOfCount > 0)
        {
            return $"global::{type.GeneratedNamespace}.JsonConverters.OneOfJsonConverter<{GetSubtypeList(type)}>";
        }

        if (type.AllOfCount > 0)
        {
            return $"global::{type.GeneratedNamespace}.JsonConverters.AllOfJsonConverter<{GetSubtypeList(type)}>";
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
        HashCode hashCode = default;
        AddOrdinal(ref hashCode, type.CSharpTypeRaw);
        hashCode.Add(type.CSharpTypeNullability);
        hashCode.Add(type.IsBaseClass);
        hashCode.Add(type.IsDerivedClass);
        hashCode.Add(type.IsArray);
        hashCode.Add(type.IsNullable);
        hashCode.Add(type.IsEnum);
        hashCode.Add(type.IsBase64);
        hashCode.Add(type.IsDate);
        hashCode.Add(type.IsDateTime);
        hashCode.Add(type.IsBinary);
        hashCode.Add(type.IsValueType);
        hashCode.Add(type.IsUnixTimestamp);
        hashCode.Add(type.AnyOfCount);
        hashCode.Add(type.OneOfCount);
        hashCode.Add(type.AllOfCount);
        hashCode.Add(type.IsComponent);
        hashCode.Add(type.HasDiscriminator);
        AddOrdinal(ref hashCode, type.Namespace);
        AddOrdinal(ref hashCode, type.GeneratedNamespace);
        hashCode.Add(type.IsDeprecated);
        hashCode.Add(isAnyOfLike);
        AddOrdinal(ref hashCode, converterType);

        foreach (var property in type.Properties)
        {
            AddOrdinal(ref hashCode, property);
        }

        foreach (var enumValue in type.EnumValues)
        {
            AddOrdinal(ref hashCode, enumValue);
        }

        foreach (var subType in type.SubTypes)
        {
            hashCode.Add(subType.Unbox<TypeData>().DependencyHash);
        }

        return hashCode.ToHashCode();
    }

    private static void AddOrdinal(ref HashCode hashCode, string? value)
    {
        hashCode.Add(value is null ? 0 : StringComparer.Ordinal.GetHashCode(value));
    }
}
