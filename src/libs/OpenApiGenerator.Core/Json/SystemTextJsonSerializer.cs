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

    private static readonly char[] ContextTypeSeparators = [',', '<', '>', '['];
    
    public static string GetContextType(string type)
    {
        type = type ?? throw new ArgumentNullException(nameof(type));
        
        var result = string.Concat(type
            .Replace("global::", string.Empty)
            .TrimEnd('?')
            .Replace("System.Collections.Generic.", string.Empty)
            .Replace("System.", string.Empty)
            .Split(ContextTypeSeparators, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim() switch
            {
                "]" => "Array",
                "bool" => "Boolean",
                "short" => "Int16",
                "int" => "Int32",
                "long" => "Int64",
                "sbyte" => "SByte",
                "ushort" => "UInt16",
                "uint" => "UInt32",
                "ulong" => "UInt64",
                "float" => "Single",
                "double" => "Double",
                "decimal" => "Decimal",
                "string" => "String",
                "char" => "Char",
                "byte" => "Byte",
                "object" => "Object",
                _ => x.Trim(),
            }));
        result =
            ((result.StartsWith("Boolean", StringComparison.Ordinal) ||
            result.StartsWith("Int16", StringComparison.Ordinal) ||
            result.StartsWith("Int32", StringComparison.Ordinal) ||
            result.StartsWith("Int64", StringComparison.Ordinal) ||
            result.StartsWith("SByte", StringComparison.Ordinal) ||
            result.StartsWith("UInt16", StringComparison.Ordinal) ||
            result.StartsWith("UInt32", StringComparison.Ordinal) ||
            result.StartsWith("UInt64", StringComparison.Ordinal) ||
            result.StartsWith("Single", StringComparison.Ordinal) ||
            result.StartsWith("Double", StringComparison.Ordinal) ||
            result.StartsWith("Decimal", StringComparison.Ordinal) ||
            result.StartsWith("Char", StringComparison.Ordinal) ||
            result.StartsWith("Byte", StringComparison.Ordinal)) &&
            !result.EndsWith("Array", StringComparison.Ordinal)) ||
            result.StartsWith("AnyOf", StringComparison.Ordinal) ||
            result.StartsWith("OneOf", StringComparison.Ordinal) ||
            result.StartsWith("AllOf", StringComparison.Ordinal)
                ? "Nullable" + result 
                : result;
        
        return result;
    }
    
    public string GenerateSerializeCall(TypeData type, string jsonSerializerContext)
    {
        return string.IsNullOrWhiteSpace(jsonSerializerContext)
            ? "global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions)"
            : $"global::System.Text.Json.JsonSerializer.Serialize(request, global::{jsonSerializerContext}.Default.{GetContextType(type.ShortCSharpTypeWithoutNullability)})";
    }
    
    public string GenerateDeserializeCall(TypeData type, string jsonSerializerContext)
    {
        return string.IsNullOrWhiteSpace(jsonSerializerContext)
            ? $"global::System.Text.Json.JsonSerializer.Deserialize<{type.CSharpTypeWithNullability}>(__content, _jsonSerializerOptions)"
            : $"global::System.Text.Json.JsonSerializer.Deserialize(__content, global::{jsonSerializerContext}.Default.{GetContextType(type.ShortCSharpTypeWithNullability)})";
    }
}