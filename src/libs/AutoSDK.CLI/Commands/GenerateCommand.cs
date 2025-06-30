using System.Collections.Immutable;
using System.CommandLine;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;

namespace AutoSDK.CLI.Commands;

internal sealed class GenerateCommand : Command
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
        DefaultValueFactory = _ => "Generated",
        Description = "Output file path",
    };
    
    private Option<string> TargetFramework { get; } = new(
        name: "--targetFramework",
        aliases: ["-t"])
    {
        DefaultValueFactory = _ => Settings.Default.TargetFramework,
        Description = "TargetFramework for the generated code",
    };
    
    private Option<string> Namespace { get; } = new(
        name: "--namespace",
        aliases: ["-n"])
    {
        DefaultValueFactory = _ => Settings.Default.Namespace,
        Description = "Namespace for the generated code",
    };
    
    private Option<string> ClientClassName { get; } = new(
        name: "--clientClassName",
        aliases: ["-c"])
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Client class name",
    };
    
    private Option<MethodNamingConvention> MethodNamingConvention { get; } = new(
        name: "--methodNamingConvention",
        aliases: ["-m"])
    {
        DefaultValueFactory = _ => Settings.Default.MethodNamingConvention,
        Description = "Method Naming Convention",
    };
    
    private Option<bool> SingleFile { get; } = new(
        name: "--single-file",
        aliases: ["-s"])
    {
        DefaultValueFactory = _ => false,
        Description = "Generate all models in a single file",
    };
    
    private Option<bool> ExcludeDeprecatedOperations { get; } = new(
        name: "--exclude-deprecated-operations",
        aliases: ["-e"])
    {
        DefaultValueFactory = _ => Settings.Default.ExcludeDeprecatedOperations,
        Description = "Exclude deprecated operations",
    };
    
    private Option<string> ClsCompliantEnumPrefix { get; } = new(
        name: "--clsCompliantEnumPrefix",
        aliases: ["-e"])
    {
        DefaultValueFactory = _ => "x",
        Description = "Prefix for enums which start with a number to make them CLS compliant. Pass empty string to disable prefixing(it will be non-CLS compliant '_')",
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
    
    private Option<bool> GenerateModelValidationMethods { get; } = new(
        name: "--validation")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateModelValidationMethods,
        Description = "Generate validation methods for models",
    };
    
    private Option<bool> ComputeDiscriminators { get; } = new(
        name: "--compute-discriminators")
    {
        DefaultValueFactory = _ => Settings.Default.ComputeDiscriminators,
        Description = "Compute discriminators for polymorphic models",
    };
    
    private Option<bool> GenerateCli { get; } = new(
        name: "--generate-cli")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateCli,
        Description = "Generate CLI for the client",
    };
    
    public GenerateCommand() : base(name: "generate", description: "Generates client sdk using a OpenAPI spec.")
    {
        Arguments.Add(Input);
        Options.Add(Output);
        Options.Add(TargetFramework);
        Options.Add(Namespace);
        Options.Add(ClientClassName);
        Options.Add(MethodNamingConvention);
        Options.Add(SingleFile);
        Options.Add(ExcludeDeprecatedOperations);
        Options.Add(ClsCompliantEnumPrefix);
        Options.Add(IgnoreOpenApiErrors);
        Options.Add(IgnoreOpenApiWarnings);
        Options.Add(GenerateModelValidationMethods);
        Options.Add(ComputeDiscriminators);
        Options.Add(GenerateCli);

        SetAction(HandleAsync);
    }

    private async Task HandleAsync(ParseResult parseResult)
    {
        string input = parseResult.GetRequiredValue(Input);
        string output = parseResult.GetRequiredValue(Output);
        bool singleFile = parseResult.GetRequiredValue(SingleFile);
        
        var namespaceValue = parseResult.GetRequiredValue(Namespace);
        
        Settings settings = Settings.Default with
        {
            TargetFramework = parseResult.GetRequiredValue(TargetFramework),
            Namespace = namespaceValue,
            ClassName = parseResult.GetRequiredValue(ClientClassName),
            ClsCompliantEnumPrefix = parseResult.GetRequiredValue(ClsCompliantEnumPrefix),
            MethodNamingConvention = parseResult.GetRequiredValue(MethodNamingConvention),
            ExcludeDeprecatedOperations = parseResult.GetRequiredValue(ExcludeDeprecatedOperations),
            JsonSerializerContext = $"{namespaceValue}.SourceGenerationContext",
            GenerateJsonSerializerContextTypes = true,
            ComputeDiscriminators = parseResult.GetRequiredValue(ComputeDiscriminators),
            GenerateModelValidationMethods = parseResult.GetRequiredValue(GenerateModelValidationMethods),
            IgnoreOpenApiErrors = parseResult.GetRequiredValue(IgnoreOpenApiErrors),
            IgnoreOpenApiWarnings = parseResult.GetRequiredValue(IgnoreOpenApiWarnings),
            FromCli = true,
            GenerateCli = parseResult.GetRequiredValue(GenerateCli),
        };
            
        Console.WriteLine($"Loading {input}...");
        
        using var client = new HttpClient();
        var yaml = input.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? await client.GetStringAsync(new Uri(input)).ConfigureAwait(false)
            : await File.ReadAllTextAsync(input).ConfigureAwait(false);
        
        Console.WriteLine("Generating...");
        
        var name = Path.GetFileNameWithoutExtension(input);
        
        if (string.IsNullOrWhiteSpace(settings.Namespace))
        {
            settings = settings with
            {
                Namespace = name.ToPropertyName()
                    .UseWordSeparator('\\', '-', '.', '_', '/'),
            };
        }
        if (string.IsNullOrWhiteSpace(settings.ClassName))
        {
            settings = settings with
            {
                ClassName = $"{name.ToPropertyName()
                    .UseWordSeparator('\\', '-', '.', '_', '/')}Client",
            };
        }

        var data = Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
        var files = settings.GenerateCli
            ? data.Methods
                .SelectMany(x => new []
                {
                    Sources.Command(x),
                }).Concat(data.Methods.GroupBy(x => x.Tag)
                    .SelectMany(x => new []
                    {
                        Sources.GroupCommand(x.Key, x.ToImmutableArray()),
                    }))
                .Concat([Sources.MainCommand(data.Tags)])
                .Concat([Sources.AddCommands(data.Methods, data.Tags)])
                .Where(x => !x.IsEmpty)
                .ToArray()
            : data.Enums
            .SelectMany(x => new []
            {
                Sources.Enum(x),
                Sources.EnumJsonConverter(x),
                Sources.EnumNullableJsonConverter(x),
            })
            .Concat(data.Classes
                .SelectMany(x => new []
                {
                    Sources.Class(x),
                    Sources.ClassJsonExtensions(x),
                    Sources.ClassValidation(x),
                }))
            .Concat(data.Methods
                .SelectMany(x => new []
                {
                    Sources.Method(x),
                    Sources.MethodInterface(x),
                }))
            .Concat(data.Clients
                .SelectMany(x => new []
                {
                    Sources.Client(x),
                    Sources.ClientInterface(x),
                }))
            .Concat(data.Authorizations
                .SelectMany(x => new []
                {
                    Sources.Authorization(x),
                    Sources.AuthorizationInterface(x),
                }))
            .Concat([Sources.MainAuthorizationConstructor(data.Authorizations)])
            .Concat(data.AnyOfs
                .SelectMany(x => new []
                {
                    Sources.AnyOf(x),
                    Sources.AnyOfJsonExtensions(x),
                    Sources.AnyOfJsonConverter(x),
                    //Sources.AnyOfJsonConverterFactory(x),
                    Sources.AnyOfValidation(x),
                }))
            .Concat([Sources.JsonSerializerContext(data.Converters, data.Types)])
            .Concat([Sources.JsonSerializerContextTypes(data.Types)])
            .Concat([Sources.Polyfills(settings)])
            .Concat([Sources.Exceptions(settings)])
            .Concat([Sources.PathBuilder(settings)])
            .Concat([Sources.UnixTimestampJsonConverter(settings)])
            .Where(x => !x.IsEmpty)
            .ToArray();
        
        Directory.CreateDirectory(output);
        
        if (singleFile)
        {
            var text = string.Join(Environment.NewLine, files.Select(x => x.Text));
            await File.WriteAllTextAsync(Path.Combine(output, $"{name}.cs"), text).ConfigureAwait(false);
            return;
        }
        
        foreach (var file in files)
        {
            await File.WriteAllTextAsync(Path.Combine(output, file.Name), file.Text).ConfigureAwait(false);
        }
        
        Console.WriteLine("Done.");
    }
}