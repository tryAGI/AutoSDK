namespace OpenApiGenerator.Core.Json;

public class NewtonsoftJsonSerializer : IJsonSerializer
{
    public static IJsonSerializer Instance { get; } = new NewtonsoftJsonSerializer();

    public string GeneratePropertyAttribute(string id, bool isRequired)
    {
        var required = isRequired ? ", Required = global::Newtonsoft.Json.Required.Always" : string.Empty;
        return $"[global::Newtonsoft.Json.JsonProperty(\"{id}\"{required})]";
    }
    
    public string GenerateExtensionDataAttribute()
    {
        return "[global::Newtonsoft.Json.JsonExtensionData]";
    }
    
    public string GenerateRequiredAttribute()
    {
        return string.Empty;
    }
}