using OpenApiGenerator.Core.Extensions;

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
        
        return $"[global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.{type}))]";
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
            result.StartsWith("AnyOf", StringComparison.Ordinal) ||
            result.StartsWith("OneOf", StringComparison.Ordinal) ||
            result.StartsWith("AllOf", StringComparison.Ordinal)
                ? "Nullable" + result 
                : result;
        
        return result;
    }
    
    public string GenerateSerializeCall(string type, string jsonSerializerContext)
    {
        type = type ?? throw new ArgumentNullException(nameof(type));
        
        return string.IsNullOrWhiteSpace(jsonSerializerContext)
            ? "global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions)"
            : $"global::System.Text.Json.JsonSerializer.Serialize(request, global::{jsonSerializerContext}.Default.{GetContextType(type)})";
    }
    
    public string GenerateDeserializeCall(string type, string jsonSerializerContext)
    {
        type = type ?? throw new ArgumentNullException(nameof(type));

        return string.IsNullOrWhiteSpace(jsonSerializerContext)
            ? $"global::System.Text.Json.JsonSerializer.Deserialize<{type}>(__content, _jsonSerializerOptions)"
            : $"global::System.Text.Json.JsonSerializer.Deserialize(__content, global::{jsonSerializerContext}.Default.{GetContextType(type)})";
    }
}