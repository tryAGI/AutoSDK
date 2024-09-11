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
        AddArgument(inputOption);
        AddOption(outputOption);
        AddOption(targetFrameworkOption);
        AddOption(namespaceOption);
        AddOption(clientClassNameOption);
        AddOption(methodNamingConventionOption);
        AddOption(singleFileOption);
        AddOption(excludeDeprecatedOption);
        AddOption(clsCompliantEnumPrefixOption);

        this.SetHandler(
            HandleAsync,
            new GenerateSettingsBinder(
                inputOption,
                outputOption,
                targetFrameworkOption,
                namespaceOption,
                clientClassNameOption,
                methodNamingConventionOption,
                singleFileOption,
                excludeDeprecatedOption,
                clsCompliantEnumPrefixOption));
    }

    private static async Task HandleAsync(
        GenerateSettings arguments)
    {
        Console.WriteLine($"Loading {arguments.Input}...");
        
        using var client = new HttpClient();
        var yaml = arguments.Input.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? await client.GetStringAsync(new Uri(arguments.Input)).ConfigureAwait(false)
            : await File.ReadAllTextAsync(arguments.Input).ConfigureAwait(false);
        
        Console.WriteLine("Generating...");
        
        var name = Path.GetFileNameWithoutExtension(arguments.Input);
        
        if (string.IsNullOrWhiteSpace(arguments.Namespace))
        {
            arguments.Namespace = name.ToPropertyName()
                .UseWordSeparator('\\', '-', '.', '_', '/');
        }
        if (string.IsNullOrWhiteSpace(arguments.ClientClassName))
        {
            arguments.ClientClassName = $"{name.ToPropertyName()
                .UseWordSeparator('\\', '-', '.', '_', '/')}Api";
        }
        
        var settings = new Settings(
            TargetFramework: arguments.TargetFramework,
            Namespace: arguments.Namespace,
            ClassName: arguments.ClientClassName,
            ClsCompliantEnumPrefix: arguments.ClsCompliantEnumPrefix,
            NamingConvention: default,
            JsonSerializerType: default,
            UseRequiredKeyword: default,
            GenerateConstructors: false,
            GroupByTags: true,
            GenerateMethods: false,
            MethodNamingConvention: default,
            MethodNamingConventionFallback: MethodNamingConvention.MethodAndPath,
            GenerateMethodsAsHttpClientExtensions: false,
            GenerateMethodsUsingSystemNetHttpJson: false,
            IncludeOperationIds: [],
            ExcludeOperationIds: [],
            IncludeTags: [],
            ExcludeTags: [],
            ExcludeDeprecatedOperations: arguments.ExcludeDeprecatedOperations,
            JsonSerializerContext: $"{arguments.Namespace}.SourceGenerationContext",
            GenerateJsonSerializerContextTypes: true,
            GenerateModels: false,
            ValidateAnyOfs: false,
            ModelStyle: default,
            IncludeModels: [],
            ExcludeModels: [],
            GeneratePolyfills: true,
            GenerateSdk: true,
            FromCli: true
        );

        var data = Generation.Data.Prepare((yaml, settings));
        var files = data.Enums
            .SelectMany(x => new [] { Sources.Enum(x), Sources.EnumJsonConverter(x), Sources.EnumNullableJsonConverter(x) })
            .Concat(data.Classes
                .Select(x => Sources.Class(x)))
            .Concat(data.Methods
                .Select(x => Sources.Method(x)))
            .Concat(data.Authorizations
                .Select(x => Sources.Authorization(x)))
            .Concat([Sources.MainAuthorizationConstructor(data.Authorizations)])
            .Concat(data.AnyOfs
                .SelectMany(x => new [] { Sources.AnyOf(x), Sources.AnyOfJsonConverter(x), Sources.AnyOfJsonConverterFactory(x) }))
            .Concat([Sources.JsonSerializerContext(data.Converters, data.Types)])
            .Concat([Sources.JsonSerializerContextTypes(data.Types)])
            .Concat([Sources.Polyfills(settings)])
            .Concat([Sources.UnixTimestampJsonConverter(settings)])
            .Where(x => !x.IsEmpty)
            .ToArray();
        
        Directory.CreateDirectory(arguments.Output);
        
        if (arguments.SingleFile)
        {
            var text = string.Join(Environment.NewLine, files.Select(x => x.Text));
            await File.WriteAllTextAsync(Path.Combine(arguments.Output, $"{name}.cs"), text).ConfigureAwait(false);
            return;
        }
        
        foreach (var file in files)
        {
            await File.WriteAllTextAsync(Path.Combine(arguments.Output, file.Name), file.Text).ConfigureAwait(false);
        }
        
        Console.WriteLine("Done.");
    }
}