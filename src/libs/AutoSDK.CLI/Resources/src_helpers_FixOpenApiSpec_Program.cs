using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using Microsoft.OpenApi.YamlReader;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

if (OpenApi31Support.IsOpenApi31(yamlOrJson))
{
    yamlOrJson = OpenApi31Support.ConvertToOpenApi30(yamlOrJson);
}

var readerSettings = new OpenApiReaderSettings
{
    RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
};
readerSettings.AddYamlReader();

var (openApiDocument, diagnostics) = OpenApiDocument.Parse(yamlOrJson, settings: readerSettings);

//openApiDocument.Components.Schemas["GenerateCompletionRequest"]!.Properties["stream"]!.Default = new OpenApiBoolean(true);

yamlOrJson = await openApiDocument!.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_0);
(_, diagnostics) = OpenApiDocument.Parse(yamlOrJson, settings: readerSettings);

if (diagnostics?.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, yamlOrJson);
