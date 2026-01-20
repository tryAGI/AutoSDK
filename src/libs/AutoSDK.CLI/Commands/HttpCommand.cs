using System.CommandLine;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;

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
        
        var files = new List<FileWithName>
        {
            new("http-client.env.json", @$"{{
{(openApiDocument.Servers ?? []).Select(x => @$"
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
### {operation.OperationType.Method.ToUpperInvariant()} {operation.OperationPath}
{operation.OperationType.Method.ToUpperInvariant()} {{{{host}}}}{operation.OperationPath}
{(operation.GlobalSecurityRequirements.Any() || (operation.Operation.Security ?? []).Any() ? @"
Authorization: Bearer {{token}}" : " ")}
Content-Type: application/json

{(requestSchema != null ? @$"
{{
{(requestSchema.Schema.Properties?.Select(x => @$"
  ""{x.Key}"": {x.Value.Example?.ToString() ?? "\"1\""},") ?? []).Inject()}
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