using Microsoft.CodeAnalysis;

namespace H.Generators.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public Task Empty()
    {
        return this.CheckSourceAsync(
            Array.Empty<AdditionalText>());
    }

    [TestMethod]
    public Task InsideYaml()
    {
        var path = Path.Combine(Path.GetTempPath(), $"{nameof(InsideYaml)}.nswag");
        var text = Resources.openapi_from_yaml_nswag.AsString();
        File.WriteAllText(path, text);
        
        return this.CheckSourceAsync(
            new AdditionalText[] { new CustomAdditionalText(path, text) });
    }

    [TestMethod]
    public Task YamlWithLocalFile()
    {
        var path = Path.Combine(Path.GetTempPath(), $"{nameof(YamlWithLocalFile)}.nswag");
        var text = Resources.openapi_from_yaml_nswag.AsString();
        File.WriteAllText(path, text);

        File.WriteAllBytes(Path.Combine(Path.GetTempPath(), "openapi.yaml"), Resources.openapi_yaml.AsBytes());

        return this.CheckSourceAsync(
            new AdditionalText[] { new CustomAdditionalText(path, text) });
    }

    [TestMethod]
    public Task YamlWithUrl()
    {
        var path = Path.Combine(Path.GetTempPath(), $"{nameof(YamlWithUrl)}.nswag");
        var text = Resources.openapi_from_url_nswag.AsString();
        File.WriteAllText(path, text);

        return this.CheckSourceAsync(
            new AdditionalText[] { new CustomAdditionalText(path, text) });
    }
}