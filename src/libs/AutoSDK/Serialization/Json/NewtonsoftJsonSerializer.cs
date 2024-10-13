using AutoSDK.Models;

namespace AutoSDK.Serialization.Json;

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
    
    public string GetOptionsType()
    {
        return "global::Newtonsoft.Json.JsonSerializerSettings";
    }
    
    public string CreateDefaultSettings(IReadOnlyList<string> converters)
    {
        return "new global::Newtonsoft.Json.JsonSerializerSettings()";
    }

    public string GenerateConverterAttribute(string type)
    {
        return string.Empty;
    }
    
    public string GenerateSerializeCall(TypeData type, string jsonSerializerContext)
    {
        if (type.CSharpType.StartsWith($"global::{type.Settings.Namespace}", StringComparison.Ordinal))
        {
            return "request.ToJson(JsonSerializerOptions)";
        }

        return "global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions)";
    }
    
    public string GenerateDeserializeCall(TypeData type, string jsonSerializerContext)
    {
        if (type.CSharpType.StartsWith($"global::{type.Settings.Namespace}", StringComparison.Ordinal))
        {
            return $"{type.CSharpTypeWithoutNullability}.FromJson(__content, JsonSerializerOptions)";
        }
        
        return $"global::Newtonsoft.Json.JsonConvert.DeserializeObject<{type.CSharpTypeWithNullability}>(__content, JsonSerializerOptions)";
    }
}