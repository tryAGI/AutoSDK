using System.CommandLine;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.CLI.Commands;

internal sealed class SimplifyCommand : Command
{
    public SimplifyCommand() : base(name: "simplify", description: "Simplifies OpenAPI spec.")
    {
        var inputOption = new Argument<string>(
            name: "input",
            getDefaultValue: () => string.Empty,
            description: "Input file path");
        var outputOption = new Option<string>(
            aliases: ["--output", "-o"],
            getDefaultValue: () => "simplified.yaml",
            description: "Output file path");
        AddArgument(inputOption);
        AddOption(outputOption);

        this.SetHandler(
            HandleAsync,
            inputOption,
            outputOption);
    }

    private static async Task HandleAsync(
        string inputPath,
        string outputPath)
    {
        Console.WriteLine($"Loading {inputPath}...");
        
        using var client = new HttpClient();
        var yamlOrJson = inputPath.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? await client.GetStringAsync(new Uri(inputPath)).ConfigureAwait(false)
            : await File.ReadAllTextAsync(inputPath).ConfigureAwait(false);
        var openApiDocument = yamlOrJson.GetOpenApiDocument(settings: Settings.Default);
        
        Console.WriteLine("Simplifying...");
        
        openApiDocument = openApiDocument.Simplify();
        
        var text = Path.GetExtension(outputPath).ToUpperInvariant() switch
        {
            ".JSON" => openApiDocument.SerializeAsJson(OpenApiSpecVersion.OpenApi3_0),
            _ => openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0),
        };
        
        await File.WriteAllTextAsync(outputPath, text).ConfigureAwait(false);
        
        Console.WriteLine("Done.");
    }
}