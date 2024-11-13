using System.CommandLine;
using AutoSDK.Helpers;

namespace AutoSDK.CLI.Commands;

internal sealed class ConvertCommand : Command
{
    public ConvertCommand() : base(name: "convert-to-openapi30", description: "Converts OpenAPI 3.1 spec to OpenAPI 3.0.")
    {
        var inputOption = new Argument<string>(
            name: "input",
            getDefaultValue: () => string.Empty,
            description: "Input file path");
        var outputOption = new Option<string>(
            aliases: ["--output", "-o"],
            getDefaultValue: () => "openapi30.yaml",
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

        if (OpenApi31Support.IsOpenApi31(yamlOrJson))
        {
            Console.WriteLine("Converting...");
        
            yamlOrJson = OpenApi31Support.ConvertToOpenApi30(yamlOrJson);
        }
        else
        {
            Console.WriteLine("No conversion needed.");
        }
        
        await File.WriteAllTextAsync(outputPath, yamlOrJson).ConfigureAwait(false);
        
        Console.WriteLine("Done.");
    }
}