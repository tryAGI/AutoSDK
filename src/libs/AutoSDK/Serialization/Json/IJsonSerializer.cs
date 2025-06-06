using AutoSDK.Models;

namespace AutoSDK.Serialization.Json;

public interface IJsonSerializer
{
    public string GeneratePropertyAttribute(string id, bool isRequired);
    string GenerateExtensionDataAttribute();
    string GenerateRequiredAttribute();
    string GenerateDeserializeCall(string variableName, TypeData type, string jsonSerializerContext);
    string GenerateDeserializeFromStreamCall(string variableName, TypeData type, string jsonSerializerContext);
    string GenerateSerializeCall(TypeData type, string jsonSerializerContext);
    string GenerateConverterAttribute(string type);
    string GetOptionsType();
    string CreateDefaultSettings(IReadOnlyList<string> converters);
}