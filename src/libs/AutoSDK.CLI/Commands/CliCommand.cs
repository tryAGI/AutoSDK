using System.CommandLine;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.CLI.Commands;

internal sealed class CliCommand : Command
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
        DefaultValueFactory = _ => "Testing",
        Description = "Output file path",
    };
    
    private Option<bool> ExcludeDeprecated { get; } = new(
        name: "--exclude-deprecated-operations",
        aliases: ["-e"])
    {
        DefaultValueFactory = _ => Settings.Default.ExcludeDeprecatedOperations,
        Description = "Exclude deprecated operations",
    };
    
    private Option<bool> IgnoreOpenApiErrors { get; } = new(
        name: "--ignore-openapi-errors")
    {
        DefaultValueFactory = _ => Settings.Default.IgnoreOpenApiErrors,
        Description = "Ignore OpenAPI errors",
    };
    
    private Option<bool> IgnoreOpenApiWarnings { get; } = new(
        name: "--ignore-openapi-warnings")
    {
        DefaultValueFactory = _ => Settings.Default.IgnoreOpenApiWarnings,
        Description = "Ignore OpenAPI warnings",
    };
    
    public CliCommand() : base(name: "cli", description: "Creates CLI .cs files for a OpenAPI spec.")
    {
        Arguments.Add(Input);
        Options.Add(Output);
        Options.Add(ExcludeDeprecated);
        Options.Add(IgnoreOpenApiErrors);
        Options.Add(IgnoreOpenApiWarnings);

        SetAction(HandleAsync);
    }

    private async Task HandleAsync(ParseResult parseResult)
    {
        string input = parseResult.GetRequiredValue(Input);
        string output = parseResult.GetRequiredValue(Output);
        bool excludeDeprecatedOperations = parseResult.GetRequiredValue(ExcludeDeprecated);
        bool ignoreOpenApiErrors = parseResult.GetRequiredValue(IgnoreOpenApiErrors);
        bool ignoreOpenApiWarnings = parseResult.GetRequiredValue(IgnoreOpenApiWarnings);
            
        Console.WriteLine($"Loading {input}...");
        
        using var client = new HttpClient();
        var yaml = input.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? await client.GetStringAsync(new Uri(input)).ConfigureAwait(false)
            : await File.ReadAllTextAsync(input).ConfigureAwait(false);

        var specFormat = SpecFormatDetector.DetectFormat(yaml);
        if (specFormat == SpecFormat.GrpcProto)
        {
            await Console.Error.WriteLineAsync(SpecFormatDetector.GrpcProtoCommandNotSupportedMessage).ConfigureAwait(false);
            await Console.Error.FlushAsync().ConfigureAwait(false);
            Environment.Exit(1);
            return;
        }
        
        Console.WriteLine("Creating...");
        
        var settings = Settings.Default with
        {
            ExcludeDeprecatedOperations = excludeDeprecatedOperations,
            IgnoreOpenApiErrors = ignoreOpenApiErrors,
            IgnoreOpenApiWarnings = ignoreOpenApiWarnings,
        };
        var openApiDocument = yaml.GetOpenApiDocument(settings);
        var schemas = openApiDocument.GetSchemas(settings);
        var operations = openApiDocument.GetOperations(settings, globalSettings: settings, schemas);
        
        var securitySchemes = (openApiDocument.Security ?? [])
            .SelectMany(static requirement => requirement.Keys)
            .GroupBy(static scheme => scheme.Reference?.Id ?? scheme.Name ?? scheme.Scheme ?? string.Empty)
            .Select(static group => group.First())
            .ToList();
        var files = new List<FileWithName>
        {
            new(
                "http-client.env.json",
                Sources.GenerateHttpEnvironmentFile(
                    (openApiDocument.Servers ?? []).ToList(),
                    securitySchemes)),
        };

        foreach (var group in operations
                     .SelectMany(x => x.Tags.Select(y => (Tag: y, x)))
                     .GroupBy(x => x.Tag))
        {
            files.Add(new FileWithName(
                group.Key + ".http",
                Sources.GenerateHttpFile(
                    group.Key.ToString(),
                    group.Select(static item => item.x).ToList())));
        }
        
        Directory.CreateDirectory(output);
        
        foreach (var file in files)
        {
            await File.WriteAllTextAsync(Path.Combine(output, file.Name), file.Text).ConfigureAwait(false);
        }
        
        Console.WriteLine("Done.");
    }
}
