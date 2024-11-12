using System.CommandLine;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;

namespace AutoSDK.CLI.Commands;

public class GenerateCommand : Command
{
    public GenerateCommand() : base(name: "generate", description: "Generates client sdk using a OpenAPI spec.")
    {
        var inputOption = new Argument<string>(
            name: "input",
            getDefaultValue: () => string.Empty,
            description: "Input file path");
        var outputOption = new Option<string>(
            aliases: ["--output", "-o"],
            getDefaultValue: () => "Generated",
            description: "Output file path");
        var targetFrameworkOption = new Option<string>(
            aliases: ["--targetFramework", "-t"],
            getDefaultValue: () => Settings.Default.TargetFramework,
            description: "TargetFramework for the generated code");
        var namespaceOption = new Option<string>(
            aliases: ["--namespace", "-n"],
            getDefaultValue: () => Settings.Default.Namespace,
            description: "Namespace for the generated code");
        var clientClassNameOption = new Option<string>(
            aliases: ["--clientClassName", "-c"],
            getDefaultValue: () => string.Empty,
            description: "Client class name");
        var methodNamingConventionOption = new Option<MethodNamingConvention>(
            aliases: ["--methodNamingConvention", "-m"],
            getDefaultValue: () => Settings.Default.MethodNamingConvention,
            description: "Method Naming Convention");
        var singleFileOption = new Option<bool>(
            aliases: ["--single-file", "-s"],
            getDefaultValue: () => false,
            description: "Generate all models in a single file");
        var excludeDeprecatedOption = new Option<bool>(
            aliases: ["--exclude-deprecated-operations", "-e"],
            getDefaultValue: () => Settings.Default.ExcludeDeprecatedOperations,
            description: "Exclude deprecated operations");
        var clsCompliantEnumPrefixOption = new Option<string>(
            aliases: ["--clsCompliantEnumPrefix"],
            getDefaultValue: () => "x",
            description: "Prefix for enums which start with a number to make them CLS compliant. Pass empty string to disable prefixing(it will be non-CLS compliant '_')");
        var ignoreOpenApiErrorsOption = new Option<bool>(
            aliases: ["--ignore-openapi-errors"],
            getDefaultValue: () => Settings.Default.IgnoreOpenApiErrors,
            description: "Ignore OpenAPI errors");
        var ignoreOpenApiWarningsOption = new Option<bool>(
            aliases: ["--ignore-openapi-warnings"],
            getDefaultValue: () => Settings.Default.IgnoreOpenApiWarnings,
            description: "Ignore OpenAPI warnings");
        var validationOption = new Option<bool>(
            aliases: ["--validation"],
            getDefaultValue: () => Settings.Default.GenerateModelValidationMethods,
            description: "Generate validation methods for models");
        AddArgument(inputOption);
        AddOption(outputOption);
        AddOption(targetFrameworkOption);
        AddOption(namespaceOption);
        AddOption(clientClassNameOption);
        AddOption(methodNamingConventionOption);
        AddOption(singleFileOption);
        AddOption(excludeDeprecatedOption);
        AddOption(clsCompliantEnumPrefixOption);
        AddOption(ignoreOpenApiErrorsOption);
        AddOption(ignoreOpenApiWarningsOption);
        AddOption(validationOption);

        this.SetHandler(
            HandleAsync,
            inputOption,
            outputOption,
            singleFileOption,
            new SettingsBinder(
                targetFrameworkOption,
                namespaceOption,
                clientClassNameOption,
                methodNamingConventionOption,
                excludeDeprecatedOption,
                clsCompliantEnumPrefixOption,
                ignoreOpenApiErrorsOption,
                ignoreOpenApiWarningsOption,
                validationOption));
    }

    private static async Task HandleAsync(
        string input,
        string output,
        bool singleFile,
        Settings settings)
    {
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
                    .UseWordSeparator('\\', '-', '.', '_', '/')}Api",
            };
        }

        var data = Generation.Data.Prepare((yaml, settings));
        var files = data.Enums
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
                .Select(x => Sources.Authorization(x)))
            .Concat([Sources.MainAuthorizationConstructor(data.Authorizations)])
            .Concat(data.AnyOfs
                .SelectMany(x => new []
                {
                    Sources.AnyOf(x),
                    Sources.AnyOfJsonExtensions(x),
                    Sources.AnyOfJsonConverter(x),
                    Sources.AnyOfJsonConverterFactory(x),
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