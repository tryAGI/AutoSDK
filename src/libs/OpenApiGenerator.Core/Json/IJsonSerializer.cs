namespace OpenApiGenerator.Core.Json;

public interface IJsonSerializer
{
    public string GeneratePropertyAttribute(string id, bool isRequired);
    string GenerateExtensionDataAttribute();
    string GenerateRequiredAttribute();
}