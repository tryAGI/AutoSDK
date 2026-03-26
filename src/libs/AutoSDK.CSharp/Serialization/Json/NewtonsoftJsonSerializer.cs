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
    
    public string GenerateDeserializeCall(string variableName, TypeData type, string jsonSerializerContext)
    {
        if (type.CSharpType.StartsWith($"global::{type.Settings.Namespace}", StringComparison.Ordinal))
        {
            return $"{type.CSharpTypeWithoutNullability}.FromJson({variableName}, JsonSerializerOptions)";
        }
        
        return $"global::Newtonsoft.Json.JsonConvert.DeserializeObject<{type.CSharpTypeWithNullability}>({variableName}, JsonSerializerOptions)";
    }

    public string GenerateDeserializeFromStreamCall(string variableName, TypeData type, string jsonSerializerContext)
    {
        if (type.CSharpType.StartsWith($"global::{type.Settings.Namespace}", StringComparison.Ordinal))
        {
            return $"await {type.CSharpTypeWithoutNullability}.FromJsonStreamAsync({variableName}, JsonSerializerOptions).ConfigureAwait(false)";
        }

        return $"global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<{type.CSharpTypeWithNullability}>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader({variableName})))";
    }
}