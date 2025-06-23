using System.CommandLine;
using AutoSDK.Helpers;

namespace AutoSDK.CLI.Commands;

internal sealed class ConvertCommand : Command
{
    private Argument<string> Input { get; } = new(
        name: "input")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Input file path",
    };
    
    private Option<string> Output { get; } = new(
        name: "--output",
        aliases: ["-o"])
    {
        DefaultValueFactory = _ => "openapi30.yaml",
        Description = "Output file path",
    };
    
    public ConvertCommand() : base(name: "convert-to-openapi30", description: "Converts OpenAPI 3.1 spec to OpenAPI 3.0.")
    {
        Arguments.Add(Input);
        Options.Add(Output);

        SetAction(HandleAsync);
    }

    private async Task HandleAsync(ParseResult parseResult)
    {
        var inputPath = parseResult.GetRequiredValue(Input);
        var outputPath = parseResult.GetRequiredValue(Output);


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