namespace OpenApiGenerator.Core.Json;

public class NewtonsoftJsonSerializer : IJsonSerializer
{
    public static IJsonSerializer Instance { get; } = new NewtonsoftJsonSerializer();

    public string GeneratePropertyAttribute(string id)
    {
        return $"[global::Newtonsoft.Json.JsonProperty(\"{id}\")]";
    }
    
    public string GenerateExtensionDataAttribute()
    {
        return "[global::Newtonsoft.Json.JsonExtensionData]";
    }
}