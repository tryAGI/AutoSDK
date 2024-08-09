using System.CommandLine;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Generation;
using OpenApiGenerator.Core.Models;
using OpenApiGenerator.Core.Naming.Methods;

namespace OpenApiGenerator.Cli.Commands;

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
            getDefaultValue: () =>  "netstandard2.0",
            description: "TargetFramework for the generated code");
        var namespaceOption = new Option<string>(
            aliases: ["--namespace", "-n"],
            getDefaultValue: () => string.Empty,
            description: "Namespace for the generated code");
        var clientClassNameOption = new Option<string>(
            aliases: ["--clientClassName", "-c"],
            getDefaultValue: () => string.Empty,
            description: "Client class name");
        var methodNamingConventionOption = new Option<MethodNamingConvention>(
            aliases: ["--methodNamingConvention", "-m"],
            getDefaultValue: () => MethodNamingConvention.MethodAndPath,
            description: "Method Naming Convention");
        var singleFileOption = new Option<bool>(
            aliases: ["--single-file", "-s"],
            getDefaultValue: () => false,
            description: "Generate all models in a single file");
        var excludeDeprecatedOption = new Option<bool>(
            aliases: ["--exclude-deprecated-operations", "-e"],
            getDefaultValue: () => false,
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
            inputOption,
            outputOption,
            targetFrameworkOption,
            namespaceOption,
            clientClassNameOption,
            singleFileOption,
            excludeDeprecatedOption,
            clsCompliantEnumPrefixOption);
    }

    private static async Task HandleAsync(
        string inputPath,
        string outputPath,
        string targetFramework,
        string @namespace,
        string clientClassName,
        bool generateAsSingleFile,
        bool excludeDeprecatedOperations,
        string clsCompliantEnumPrefix)
    {
        Console.WriteLine($"Loading {inputPath}...");
        
        using var client = new HttpClient();
        var yaml = inputPath.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? await client.GetStringAsync(new Uri(inputPath)).ConfigureAwait(false)
            : await File.ReadAllTextAsync(inputPath).ConfigureAwait(false);
        
        Console.WriteLine("Generating...");
        
        var name = Path.GetFileNameWithoutExtension(inputPath);
        
        if (string.IsNullOrWhiteSpace(@namespace))
        {
            @namespace = name.ToPropertyName();
        }
        if (string.IsNullOrWhiteSpace(clientClassName))
        {
            clientClassName = $"{name.ToPropertyName()}Api";
        }
        
        var settings = new Settings(
            TargetFramework: targetFramework,
            Namespace: @namespace,
            ClassName: clientClassName,
            ClsCompliantEnumPrefix: clsCompliantEnumPrefix,
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
            ExcludeDeprecatedOperations: excludeDeprecatedOperations,
            JsonSerializerContext: $"{@namespace}.SourceGenerationContext",
            GenerateJsonSerializerContextTypes: true,
            GenerateModels: false,
            ModelStyle: default,
            IncludeModels: [],
            ExcludeModels: [],
            GeneratePolyfills: true,
            GenerateSdk: true,
            FromCli: true
        );

        var data = Core.Generation.Data.Prepare((yaml, settings));
        var files = data.Enums
            .SelectMany(x => new [] { Sources.Enum(x), Sources.EnumJsonConverter(x), Sources.EnumNullableJsonConverter(x) })
            .Concat(data.Classes
                .Select(x => Sources.Class(x)))
            .Concat(data.Methods
                .Select(x => Sources.Method(x)))
            .Concat(data.Authorizations
                .Select(x => Sources.Authorization(x)))
            .Concat(data.AnyOfs
                .SelectMany(x => new [] { Sources.AnyOf(x), Sources.AnyOfJsonConverter(x), Sources.AnyOfJsonConverterFactory(x) }))
            .Concat([Sources.JsonSerializerContext(data.Converters, data.Types)])
            .Concat([Sources.JsonSerializerContextTypes(data.Types)])
            .Concat([Sources.Polyfills(settings)])
            .Where(x => !x.IsEmpty)
            .ToArray();
        
        Directory.CreateDirectory(outputPath);
        
        if (generateAsSingleFile)
        {
            var text = string.Join(Environment.NewLine, files.Select(x => x.Text));
            await File.WriteAllTextAsync(Path.Combine(outputPath, $"{name}.cs"), text).ConfigureAwait(false);
            return;
        }
        
        foreach (var file in files)
        {
            await File.WriteAllTextAsync(Path.Combine(outputPath, file.Name), file.Text).ConfigureAwait(false);
        }
        
        Console.WriteLine("Done.");
    }
}