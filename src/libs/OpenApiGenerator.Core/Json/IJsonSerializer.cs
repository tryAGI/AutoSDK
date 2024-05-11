namespace OpenApiGenerator.Core.Json;

public interface IJsonSerializer
{
    public string GeneratePropertyAttribute(string id);
    string GenerateExtensionDataAttribute();
}