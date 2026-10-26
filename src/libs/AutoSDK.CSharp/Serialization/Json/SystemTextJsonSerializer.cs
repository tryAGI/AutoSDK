using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.TypeMapping;

namespace AutoSDK.Serialization.Json;

public class SystemTextJsonSerializer : IJsonSerializer
{
    private readonly bool _useCachedMetadata;

    public SystemTextJsonSerializer() : this(false) { }

    internal SystemTextJsonSerializer(bool useCachedMetadata) => _useCachedMetadata = useCachedMetadata;

    public static IJsonSerializer Instance { get; } = new SystemTextJsonSerializer();

    internal static IJsonSerializer CachedInstance { get; } = new SystemTextJsonSerializer(true);

    public string GeneratePropertyAttribute(string id, bool isRequired)
    {
        return $"[global::System.Text.Json.Serialization.JsonPropertyName(\"{id}\")]";
    }

    public string GenerateExtensionDataAttribute()
    {
        return "[global::System.Text.Json.Serialization.JsonExtensionData]";
    }

    public string GenerateIgnoreAttribute()
    {
        return "[global::System.Text.Json.Serialization.JsonIgnore]";
    }

    public string GenerateRequiredAttribute()
    {
        return "[global::System.Text.Json.Serialization.JsonRequired]";
    }

    public string GetOptionsType()
    {
        return "global::System.Text.Json.JsonSerializerOptions";
    }

    public string CreateDefaultSettings(IReadOnlyList<string> converters)
    {
        return @$"new global::System.Text.Json.JsonSerializerOptions
            {{
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {{
{converters.Select(x => $@" 
                    new {x}(),
").Inject()}
                }}
            }}";
    }

    public string GenerateConverterAttribute(string type)
    {
        if (string.IsNullOrWhiteSpace(type))
        {
            return string.Empty;
        }

        return $"[global::System.Text.Json.Serialization.JsonConverter(typeof({type}))]";
    }

    public static string GetContextType(TypeData typeData, bool makeNullableRootIfValueType)
    {
        var index = typeData.ShortCSharpTypeWithoutNullability.IndexOf('<');
        var shortTypeWithoutSubTypes = index >= 0
            ? typeData.ShortCSharpTypeWithoutNullability.Substring(0, index)
            : typeData.ShortCSharpTypeWithoutNullability;

        return (typeData.IsRuntimeValueType() &&
                (typeData.CSharpType.EndsWith("?", StringComparison.Ordinal) ||
                 makeNullableRootIfValueType) ? "Nullable" : string.Empty) + typeData switch
                 {
                     _ when typeData.IsBase64 || typeData.IsBinary => string.Empty,
                     { IsArray: true, SubTypes.Length: 1 } => "IList",
                     { AnyOfCount: > 0, IsComponent: false } => "AnyOf",
                     { OneOfCount: > 0, IsComponent: false } => "OneOf",
                     { AllOfCount: > 0, IsComponent: false } => "AllOf",
                     { ShortCSharpTypeWithoutNullability: "bool" } => "Boolean",
                     { ShortCSharpTypeWithoutNullability: "string" } => "String",
                     { ShortCSharpTypeWithoutNullability: "short" } => "Int16",
                     { ShortCSharpTypeWithoutNullability: "int" } => "Int32",
                     { ShortCSharpTypeWithoutNullability: "long" } => "Int64",
                     { ShortCSharpTypeWithoutNullability: "sbyte" } => "SByte",
                     { ShortCSharpTypeWithoutNullability: "ushort" } => "UInt16",
                     { ShortCSharpTypeWithoutNullability: "uint" } => "UInt32",
                     { ShortCSharpTypeWithoutNullability: "ulong" } => "UInt64",
                     { ShortCSharpTypeWithoutNullability: "float" } => "Single",
                     { ShortCSharpTypeWithoutNullability: "double" } => "Double",
                     { ShortCSharpTypeWithoutNullability: "decimal" } => "Decimal",
                     { ShortCSharpTypeWithoutNullability: "char" } => "Char",
                     { ShortCSharpTypeWithoutNullability: "byte" } => "Byte",
                     { ShortCSharpTypeWithoutNullability: "object" } => "Object",
                     _ => shortTypeWithoutSubTypes,
                 } + (typeData is { IsComponent: true, IsAnyOfLike: true }
                   ? string.Empty
                   : string.Concat(typeData.SubTypes.Select(x => GetContextType(x.Unbox<TypeData>(), makeNullableRootIfValueType: false))))
            + (typeData.IsBase64 || typeData.IsBinary
                ? "Array"
                : string.Empty);
    }

    public string GenerateSerializeCall(TypeData type, string jsonSerializerContext)
    {
        if (type.UsesGeneratedJsonHelpers)
        {
            return string.IsNullOrWhiteSpace(jsonSerializerContext)
                ? "request.ToJson(JsonSerializerOptions)"
                : "request.ToJson(JsonSerializerContext)";
        }

        return string.IsNullOrWhiteSpace(jsonSerializerContext)
            ? "global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions)"
            : _useCachedMetadata
                ? "global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerContext.Options.GetTypeInfo(request.GetType()))"
                : "global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext)";
    }

    public string GenerateDeserializeCall(string variableName, TypeData type, string jsonSerializerContext)
    {
        var typeToDeserializeIfRequired = (type.IsDerivedClass || type.IsBaseClass) && !type.IsAnyOfLike ? $"<{type.CSharpTypeWithoutNullability}>" : "";
        if (type.UsesGeneratedJsonHelpers)
        {
            return string.IsNullOrWhiteSpace(jsonSerializerContext)
                ? $"{type.CSharpTypeWithoutNullability}.FromJson{typeToDeserializeIfRequired}({variableName}, JsonSerializerOptions)"
                : $"{type.CSharpTypeWithoutNullability}.FromJson{typeToDeserializeIfRequired}({variableName}, JsonSerializerContext)";
        }

        return string.IsNullOrWhiteSpace(jsonSerializerContext)
            ? $"global::System.Text.Json.JsonSerializer.Deserialize<{type.CSharpTypeWithNullability}>({variableName}, JsonSerializerOptions)"
            : _useCachedMetadata
                ? $"({type.CSharpTypeWithNullability})global::System.Text.Json.JsonSerializer.Deserialize({variableName}, JsonSerializerContext.Options.GetTypeInfo(typeof({type.CSharpTypeWithNullabilityForValueTypes})))"
                : $"({type.CSharpTypeWithNullability})global::System.Text.Json.JsonSerializer.Deserialize({variableName}, typeof({type.CSharpTypeWithNullabilityForValueTypes}), JsonSerializerContext)";
    }

    public string GenerateDeserializeFromStreamCall(string variableName, TypeData type, string jsonSerializerContext)
    {
        var typeToDeserializeIfRequired = (type.IsDerivedClass || type.IsBaseClass) && !type.IsAnyOfLike ? $"<{type.CSharpTypeWithoutNullability}>" : "";
        if (type.UsesGeneratedJsonHelpers)
        {
            return string.IsNullOrWhiteSpace(jsonSerializerContext)
                ? $"await {type.CSharpTypeWithoutNullability}.FromJsonStreamAsync{typeToDeserializeIfRequired}({variableName}, JsonSerializerOptions).ConfigureAwait(false)"
                : $"await {type.CSharpTypeWithoutNullability}.FromJsonStreamAsync{typeToDeserializeIfRequired}({variableName}, JsonSerializerContext).ConfigureAwait(false)";
        }

        return string.IsNullOrWhiteSpace(jsonSerializerContext)
            ? $"await global::System.Text.Json.JsonSerializer.DeserializeAsync<{type.CSharpTypeWithNullability}>({variableName}, JsonSerializerOptions).ConfigureAwait(false)"
            : _useCachedMetadata
                ? $"({type.CSharpTypeWithNullability})await global::System.Text.Json.JsonSerializer.DeserializeAsync({variableName}, JsonSerializerContext.Options.GetTypeInfo(typeof({type.CSharpTypeWithNullabilityForValueTypes}))).ConfigureAwait(false)"
                : $"({type.CSharpTypeWithNullability})await global::System.Text.Json.JsonSerializer.DeserializeAsync({variableName}, typeof({type.CSharpTypeWithNullabilityForValueTypes}), JsonSerializerContext).ConfigureAwait(false)";
    }
}
