using System.CommandLine;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.CLI.Commands;

internal sealed class HttpCommand : Command
{
    public HttpCommand() : base(name: "http", description: "Creates .http files for a OpenAPI spec.")
    {
        var inputOption = new Argument<string>(
            name: "input",
            getDefaultValue: () => string.Empty,
            description: "Input file path");
        var outputOption = new Option<string>(
            aliases: ["--output", "-o"],
            getDefaultValue: () => "Testing",
            description: "Output file path");
        var singleFileOption = new Option<bool>(
            aliases: ["--single-file", "-s"],
            getDefaultValue: () => false,
            description: "Generate a single .http file");
        var excludeDeprecatedOption = new Option<bool>(
            aliases: ["--exclude-deprecated-operations", "-e"],
            getDefaultValue: () => Settings.Default.ExcludeDeprecatedOperations,
            description: "Exclude deprecated operations");
        var ignoreOpenApiErrorsOption = new Option<bool>(
            aliases: ["--ignore-openapi-errors"],
            getDefaultValue: () => Settings.Default.IgnoreOpenApiErrors,
            description: "Ignore OpenAPI errors");
        var ignoreOpenApiWarningsOption = new Option<bool>(
            aliases: ["--ignore-openapi-warnings"],
            getDefaultValue: () => Settings.Default.IgnoreOpenApiWarnings,
            description: "Ignore OpenAPI warnings");
        AddArgument(inputOption);
        AddOption(outputOption);
        AddOption(singleFileOption);
        AddOption(excludeDeprecatedOption);
        AddOption(ignoreOpenApiErrorsOption);
        AddOption(ignoreOpenApiWarningsOption);

        this.SetHandler(
            HandleAsync,
            inputOption,
            outputOption,
            singleFileOption,
            excludeDeprecatedOption,
            ignoreOpenApiErrorsOption,
            ignoreOpenApiWarningsOption);
    }

    private static async Task HandleAsync(
        string input,
        string output,
        bool singleFile,
        bool excludeDeprecatedOperations,
        bool ignoreOpenApiErrors,
        bool ignoreOpenApiWarnings)
    {
        Console.WriteLine($"Loading {input}...");
        
        using var client = new HttpClient();
        var yaml = input.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? await client.GetStringAsync(new Uri(input)).ConfigureAwait(false)
            : await File.ReadAllTextAsync(input).ConfigureAwait(false);
        
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
        var operations = openApiDocument.GetOperations(settings, schemas);
        
        var files = new List<FileWithName>
        {
            new("http-client.env.json", @$"{{
{openApiDocument.Servers.Select(x => @$"
  ""{x.Description}"": {{
    ""host"": ""{x.Url}"",
    ""token"": """"
  }},").Inject().TrimEnd(',')}
}}")
        };

        foreach (var group in operations
                     .SelectMany(x => x.Tags.Select(y => (Tag: y, x)))
                     .GroupBy(x => x.Tag))
        {
            var content = string.Empty;

            foreach (var (_, operation) in group)
            {
                //  "initialAmount": 1000.0,
                // "numberOfMonths": 36,
                // "startDate": "2025-02-25"
                
                var requestSchema = operation.Schemas.FirstOrDefault(y => y.Hint == Hint.Request);
                content += $@"
### {operation.OperationType.ToString("G").ToUpperInvariant()} {operation.OperationPath}
{operation.OperationType.ToString("G").ToUpperInvariant()} {{{{host}}}}{operation.OperationPath}
{(operation.GlobalSecurityRequirements.Any() || operation.Operation.Security.Any() ? @"
Authorization: Bearer {{token}}" : " ")}
Content-Type: application/json

{(requestSchema != null ? @$"
{{
{requestSchema.Schema.Properties.Select(x => @$"
  ""{x.Key}"": {x.Value.Example?.ToString() ?? "\"1\""},").Inject()}
}}
" : " ")}

".RemoveBlankLinesWhereOnlyWhitespaces();
            }

            files.Add(new FileWithName(group.Key + ".http", content));
        }
        
        Directory.CreateDirectory(output);
        
        if (singleFile)
        {
            var text = string.Join(Environment.NewLine, files.Select(x => x.Text));
            await File.WriteAllTextAsync(Path.Combine(output, $"{name}.http"), text).ConfigureAwait(false);
            return;
        }
        
        foreach (var file in files)
        {
            await File.WriteAllTextAsync(Path.Combine(output, file.Name), file.Text).ConfigureAwait(false);
        }
        
        Console.WriteLine("Done.");
    }
}