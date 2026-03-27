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

        return type with
        {
            CSharpTypeWithoutNullability = csharpTypeWithoutNullability,
            CSharpTypeWithNullability = csharpTypeWithNullability,
            ShortCSharpTypeWithoutNullability = shortCSharpTypeWithoutNullability,
            ShortCSharpTypeWithNullability = shortCSharpTypeWithNullability,
            IsAnyOfLike = isAnyOfLike,
            CSharpTypeWithNullabilityForValueTypes = csharpTypeWithNullabilityForValueTypes,
            CSharpTypeWithNullabilityForNonValueTypes = csharpTypeWithNullabilityForNonValueTypes,
            CSharpType = type.CSharpTypeNullability
                ? csharpTypeWithNullability
                : csharpTypeWithoutNullability,
            IsReferenceable =
                type.IsValueType ||
                csharpTypeWithoutNullability is "string" ||
                isAnyOfLike ||
                type.IsEnum,
            ConverterType = GetConverterType(type, shortCSharpTypeWithoutNullability, isAnyOfLike),
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
            type.SubTypes.Select(x => x.Unbox<TypeData>().WithCSharpComputedValues().CSharpTypeWithNullabilityForValueTypes));
    }
}
