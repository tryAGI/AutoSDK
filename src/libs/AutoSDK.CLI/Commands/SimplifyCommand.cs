using System.CommandLine;

namespace AutoSDK.CLI.Commands;

internal sealed class SimplifyCommand : Command
{
    private Option<string> OutputOption { get; } = new(
        name: "--output",
        aliases: ["-o"])
    {
        DefaultValueFactory = _ => "simplified.yaml",
        Description = "Output file path",
    };

    private Argument<string> InputOption { get; } = new(
        name: "input")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Input file path",
    };

    public SimplifyCommand() : base(name: "simplify", description: "Simplifies OpenAPI spec.")
    {
        Arguments.Add(InputOption);
        Options.Add(OutputOption);

        SetAction(HandleAsync);
    }

    private static Task HandleAsync(ParseResult parseResult)
    {
        // var inputPath = parseResult.GetRequiredValue(InputOption);
        // var outputPath = parseResult.GetRequiredValue(OutputOption);

        // Console.WriteLine($"Loading {inputPath}...");
        
        // using var client = new HttpClient();
        // var yamlOrJson = inputPath.StartsWith("http", StringComparison.OrdinalIgnoreCase)
        //     ? await client.GetStringAsync(new Uri(inputPath)).ConfigureAwait(false)
        //     : await File.ReadAllTextAsync(inputPath).ConfigureAwait(false);
        // var openApiDocument = yamlOrJson.GetOpenApiDocument(settings: Settings.Default);
        
        // Console.WriteLine("Simplifying...");
        
        // openApiDocument = openApiDocument.Simplify();
        
        // var text = Path.GetExtension(outputPath).ToUpperInvariant() switch
        // {
        //     ".JSON" => openApiDocument.SerializeAsJson(OpenApiSpecVersion.OpenApi3_0),
        //     _ => openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0),
        // };
        
        // await File.WriteAllTextAsync(outputPath, text).ConfigureAwait(false);
        
        // Console.WriteLine("Done.");
        Console.WriteLine("This command is currently disabled.");
        Console.WriteLine("The OpenAPI serialization API has changed in Microsoft.OpenApi 3.x.");
        Console.WriteLine("If you need this functionality, please open an issue on GitHub.");

        return Task.CompletedTask;
    }
}