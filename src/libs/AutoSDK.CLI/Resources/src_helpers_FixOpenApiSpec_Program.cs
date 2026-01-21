using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using Microsoft.OpenApi.YamlReader;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

var readerSettings = new OpenApiReaderSettings
{
    RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
};
readerSettings.AddYamlReader();

var (openApiDocument, diagnostics) = OpenApiDocument.Parse(yamlOrJson, settings: readerSettings);

if (diagnostics?.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine($"Parse error: {error.Message}");
    }
    Environment.Exit(1);
}

// Serialize to OpenAPI 3.0 format (converts 3.1 features to 3.0 equivalents)
yamlOrJson = await openApiDocument!.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_0);

// Validate the output
(_, diagnostics) = OpenApiDocument.Parse(yamlOrJson, settings: readerSettings);

if (diagnostics?.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine($"Validation error: {error.Message}");
    }
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, yamlOrJson);
