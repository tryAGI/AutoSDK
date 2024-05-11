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
}