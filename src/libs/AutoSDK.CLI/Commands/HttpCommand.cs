using System.CommandLine;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.CLI.Commands;

internal sealed class HttpCommand : Command
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

    private Option<bool> SingleFile { get; } = new(
        name: "--single-file",
        aliases: ["-s"])
    {
        DefaultValueFactory = _ => false,
        Description = "Generate a single .http file",
    };

    private Option<bool> ExcludeDeprecatedOperations { get; } = new(
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

    public HttpCommand() : base(name: "http", description: "Creates .http files for a OpenAPI spec.")
    {
        Arguments.Add(Input);
        Options.Add(Output);
        Options.Add(SingleFile);
        Options.Add(ExcludeDeprecatedOperations);
        Options.Add(IgnoreOpenApiErrors);
        Options.Add(IgnoreOpenApiWarnings);

        SetAction(HandleAsync);
    }

    private async Task HandleAsync(ParseResult parseResult)
    {
        var input = parseResult.GetRequiredValue(Input);
        var output = parseResult.GetRequiredValue(Output);
        var singleFile = parseResult.GetRequiredValue(SingleFile);
        var excludeDeprecatedOperations = parseResult.GetRequiredValue(ExcludeDeprecatedOperations);
        var ignoreOpenApiErrors = parseResult.GetRequiredValue(IgnoreOpenApiErrors);
        var ignoreOpenApiWarnings = parseResult.GetRequiredValue(IgnoreOpenApiWarnings);

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

        var name = Path.GetFileNameWithoutExtension(input);

        var settings = Settings.Default with
        {
            ExcludeDeprecatedOperations = excludeDeprecatedOperations,
            IgnoreOpenApiErrors = ignoreOpenApiErrors,
            IgnoreOpenApiWarnings = ignoreOpenApiWarnings,
        };
        var openApiDocument = yaml.GetOpenApiDocument(settings);
        var schemas = openApiDocument.GetSchemas(settings);
        var operations = openApiDocument.GetOperations(settings, globalSettings: settings, schemas);

        // Extract security schemes from document components
        var securitySchemes = (openApiDocument.Components?.SecuritySchemes?.Values ?? [])
            .OfType<OpenApiSecuritySchemeReference>()
            .ToList();
        // Fall back to extracting from global security requirements
        if (securitySchemes.Count == 0)
        {
            securitySchemes = (openApiDocument.Security ?? [])
                .SelectMany(req => req.Keys)
                .GroupBy(s => s.Name ?? s.Scheme ?? "")
                .Select(g => g.First())
                .ToList();
        }

        var servers = (openApiDocument.Servers ?? []).ToList();

        // Generate environment file
        var envFile = Sources.HttpEnvironmentFile(servers, securitySchemes);

        // Generate .http files grouped by tag
        var httpFiles = new List<FileWithName>();
        if (!envFile.IsEmpty)
        {
            httpFiles.Add(envFile);
        }

        foreach (var group in operations
                     .SelectMany(x => x.Tags.Select(y => (Tag: y, Operation: x)))
                     .GroupBy(x => x.Tag))
        {
            var groupOperations = group.Select(x => x.Operation).ToList();
            var file = Sources.HttpFile(group.Key, groupOperations);
            if (!file.IsEmpty)
            {
                httpFiles.Add(file);
            }
        }

        Directory.CreateDirectory(output);

        if (singleFile)
        {
            var text = string.Join(Environment.NewLine, httpFiles.Select(x => x.Text));
            await File.WriteAllTextAsync(Path.Combine(output, $"{name}.http"), text).ConfigureAwait(false);
            return;
        }

        foreach (var file in httpFiles)
        {
            await File.WriteAllTextAsync(Path.Combine(output, file.Name), file.Text).ConfigureAwait(false);
        }

        Console.WriteLine("Done.");
    }
}
