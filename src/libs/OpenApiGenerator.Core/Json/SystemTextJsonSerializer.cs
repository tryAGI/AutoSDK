using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Json;

public class SystemTextJsonSerializer : IJsonSerializer
{
    public static IJsonSerializer Instance { get; } = new SystemTextJsonSerializer();

    public string GeneratePropertyAttribute(string id, bool isRequired)
    {
        return $"[global::System.Text.Json.Serialization.JsonPropertyName(\"{id}\")]";
    }

    public string GenerateExtensionDataAttribute()
    {
        return "[global::System.Text.Json.Serialization.JsonExtensionData]";
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
        var shortTypeWithoutSubTypes = typeData.ShortCSharpTypeWithoutNullability.Contains("<") ?
            typeData.ShortCSharpTypeWithoutNullability[..typeData.ShortCSharpTypeWithoutNullability.IndexOf('<')] :
            typeData.ShortCSharpTypeWithoutNullability;
        
        return (typeData.IsValueType &&
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
        } + (typeData is { IsComponent: true, IsAnyOf: true }
                   ? string.Empty
                   : string.Concat(typeData.SubTypes.Select(x => GetContextType(x, makeNullableRootIfValueType: false)))) 
            + (typeData.IsBase64 || typeData.IsBinary
                ? "Array"
                : string.Empty);
    }
    
    public string GenerateSerializeCall(TypeData type, string jsonSerializerContext)
    {
        return string.IsNullOrWhiteSpace(jsonSerializerContext)
            ? "global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions)"
            : $"global::System.Text.Json.JsonSerializer.Serialize(request, global::{jsonSerializerContext}.Default.{GetContextType(type, makeNullableRootIfValueType: true)})";
    }
    
    public string GenerateDeserializeCall(TypeData type, string jsonSerializerContext)
    {
        return string.IsNullOrWhiteSpace(jsonSerializerContext)
            ? $"global::System.Text.Json.JsonSerializer.Deserialize<{type.CSharpTypeWithNullability}>(__content, _jsonSerializerOptions)"
            : $"global::System.Text.Json.JsonSerializer.Deserialize(__content, global::{jsonSerializerContext}.Default.{GetContextType(type, makeNullableRootIfValueType: true)})";
    }
}