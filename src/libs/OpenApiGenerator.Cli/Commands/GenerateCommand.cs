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
            getDefaultValue: () => string.Empty,
            description: "Output file path");
        var namespaceOption = new Option<string>(
            aliases: ["--namespace", "-n"],
            getDefaultValue: () => string.Empty,
            description: "Namespace for the generated code");
        var clientClassNameOption = new Option<string>(
            aliases: ["--clientClassName", "-c"],
            getDefaultValue: () => string.Empty,
            description: "Client class name");
        var singleFileOption = new Option<bool>(
            aliases: ["--single-file", "-s"],
            getDefaultValue: () => false,
            description: "Generate all models in a single file");
        AddArgument(inputOption);
        AddOption(outputOption);
        AddOption(namespaceOption);
        AddOption(clientClassNameOption);
        AddOption(singleFileOption);

        this.SetHandler(
            HandleAsync,
            inputOption,
            outputOption,
            namespaceOption,
            clientClassNameOption,
            singleFileOption);
    }

    private static async Task HandleAsync(
        string inputPath,
        string outputPath,
        string @namespace,
        string clientClassName,
        bool generateAsSingleFile)
    {
        var yaml = await File.ReadAllTextAsync(inputPath).ConfigureAwait(false);
        
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
            TargetFramework: "netstandard2.0",
            Namespace: @namespace,
            ClassName: clientClassName,
            NamingConvention: default,
            JsonSerializerType: default,
            UseRequiredKeyword: default,
            GenerateConstructors: false,
            GroupByTags: false,
            GenerateMethods: false,
            MethodNamingConvention: default,
            MethodNamingConventionFallback: MethodNamingConvention.MethodAndPath,
            GenerateMethodsAsHttpClientExtensions: false,
            GenerateMethodsUsingSystemNetHttpJson: false,
            IncludeOperationIds: [],
            ExcludeOperationIds: [],
            IncludeTags: [],
            ExcludeTags: [],
            JsonSerializerContext: $"{@namespace}.SourceGenerationContext",
            GenerateJsonSerializerContextTypes: true,
            GenerateModels: false,
            ModelStyle: default,
            IncludeModels: [],
            ExcludeModels: [],
            GenerateSdk: true,
            FromCli: true
        );

        var data = Data.Prepare((yaml, settings));
        var files = data.Models
            .SelectMany(x => new [] { Sources.Model(x), Sources.EnumJsonConverter(x), Sources.EnumNullableJsonConverter(x) })
            .Concat(data.Methods
                .Select(x => Sources.Method(x)))
            .Concat(data.AnyOfs
                .SelectMany(x => new [] { Sources.AnyOf(x), Sources.AnyOfJsonConverter(x), Sources.AnyOfJsonConverterFactory(x) }))
            .Concat([Sources.JsonSerializerContext(data.Converters, data.Types)])
            .Concat([Sources.JsonSerializerContextTypes(data.Types)])
            .Where(x => !x.IsEmpty)
            .ToArray();
        
        if (generateAsSingleFile)
        {
            var text = string.Join(Environment.NewLine, files.Select(x => x.Text));
            await File.WriteAllTextAsync(Path.Combine(outputPath, $"{name}.cs"), text).ConfigureAwait(false);
            return;
        }
        
        if (string.IsNullOrWhiteSpace(outputPath))
        {
            outputPath = name;
            Directory.CreateDirectory(outputPath);
        }
        
        foreach (var file in files)
        {
            await File.WriteAllTextAsync(Path.Combine(outputPath, file.Name), file.Text).ConfigureAwait(false);
        }
    }
}