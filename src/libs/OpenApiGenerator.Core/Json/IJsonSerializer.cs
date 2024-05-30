namespace OpenApiGenerator.Core.Json;

public interface IJsonSerializer
{
    public string GeneratePropertyAttribute(string id, bool isRequired);
    string GenerateExtensionDataAttribute();
    string GenerateRequiredAttribute();
    string GenerateDeserializeCall(string type, string jsonSerializerContext);
    string GenerateSerializeCall(string type, string jsonSerializerContext);
    string GenerateConverterAttribute(string type);
}