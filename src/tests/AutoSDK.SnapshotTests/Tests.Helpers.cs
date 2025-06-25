using System.Collections.Immutable;
using H.Generators.Tests.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Testing;
using AutoSDK.Serialization.Json;

namespace AutoSDK.SnapshotTests;

[TestClass]
public partial class Tests : VerifyBase
{
    private async Task CheckSourceAsync<T>(
        JsonSerializerType jsonSerializerType,
        IList<AdditionalText> additionalTexts,
        string callerName,
        Dictionary<string, string>? globalOptions = null,
        Dictionary<string, Dictionary<string, string>>? additionalTextOptions = null,
        CancellationToken cancellationToken = default,
        params IIncrementalGenerator[] additionalGenerators)
        where T : IIncrementalGenerator, new()
    {
        globalOptions ??= new Dictionary<string, string>();
        globalOptions.TryAdd("build_property.AutoSDK_Namespace", "G");
        globalOptions.TryAdd("build_property.AutoSDK_JsonSerializerType", $"{jsonSerializerType:G}");
        globalOptions.TryAdd("build_property.AutoSDK_GenerateJsonSerializerContextTypes", "true");
        globalOptions.TryAdd("build_property.TargetFramework", jsonSerializerType switch
        {
            JsonSerializerType.SystemTextJson => "net8.0",
            JsonSerializerType.NewtonsoftJson => "net6.0",
            _ => throw new ArgumentOutOfRangeException(nameof(jsonSerializerType), jsonSerializerType, null)
        });
        globalOptions.TryAdd("build_property.AutoSDK_UseExperimentalAttributes", jsonSerializerType switch
        {
            JsonSerializerType.SystemTextJson => "InSupportedTargetFrameworks",
            JsonSerializerType.NewtonsoftJson => "Never",
            _ => throw new ArgumentOutOfRangeException(nameof(jsonSerializerType), jsonSerializerType, null)
        });
        globalOptions.TryAdd("build_property.AutoSDK_UseSetsRequiredMembersAttributes", jsonSerializerType switch
        {
            JsonSerializerType.SystemTextJson => "InSupportedTargetFrameworks",
            JsonSerializerType.NewtonsoftJson => "Never",
            _ => throw new ArgumentOutOfRangeException(nameof(jsonSerializerType), jsonSerializerType, null)
        });

        var referenceAssemblies = jsonSerializerType switch
        {
            JsonSerializerType.SystemTextJson => LatestReferenceAssemblies.Net80,
            JsonSerializerType.NewtonsoftJson => ReferenceAssemblies.Net.Net60.AddPackages([
                new PackageIdentity("Newtonsoft.Json", "13.0.3")
            ]),
            _ => throw new ArgumentOutOfRangeException(nameof(jsonSerializerType), jsonSerializerType, null)
        };
        var references = await referenceAssemblies.ResolveAsync(null, cancellationToken);
        var trees = new List<SyntaxTree>
        {
            SyntaxFactory.ParseSyntaxTree("[assembly: System.CLSCompliantAttribute(true)]"),
        };
        if (jsonSerializerType is JsonSerializerType.SystemTextJson)
        {
            foreach (var additionalText in additionalTexts)
            {
                var options =
                    additionalTextOptions != null &&
                    additionalTextOptions.TryGetValue(additionalText.Path, out var existingOptions)
                    ? existingOptions
                    : new Dictionary<string, string>();
                var @namespace = options.TryGetValue("build_metadata.AdditionalFiles.AutoSDK_Namespace", out var namespaceValue)
                    ? namespaceValue
                    : "G";
                trees.Add(SyntaxFactory.ParseSyntaxTree($@"#nullable enable

namespace {@namespace}
{{
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::{@namespace}.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {{
        public static global::{@namespace}.SourceGenerationContext Default {{ get; }} = new global::{@namespace}.SourceGenerationContext(new global::System.Text.Json.JsonSerializerOptions());
        
        /// <summary>
        /// The source-generated options associated with this context.
        /// </summary>
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions {{ get; }}
        
        /// <inheritdoc/>
        public SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options)
        {{
        }}

        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {{
            return null;
        }}
    }}
}}
"));
            }
        }

        additionalTextOptions ??= new Dictionary<string, Dictionary<string, string>>();
        foreach (var additionalText in additionalTexts)
        {
            var options = additionalTextOptions.TryGetValue(additionalText.Path, out var existingOptions)
                ? existingOptions
                : new Dictionary<string, string>();
            options.TryAdd("build_metadata.AdditionalFiles.AutoSDK_OpenApiSpecification", "true");
            additionalTextOptions[additionalText.Path] = options;
        }
        
        var compilation = (Compilation)CSharpCompilation.Create(
            assemblyName: "Tests",
            syntaxTrees: [..trees],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        var generator = new T();
        var driver = CSharpGeneratorDriver.Create(
            generators: new IIncrementalGenerator[] { generator }
                .Concat(additionalGenerators)
                .Select(GeneratorExtensions.AsSourceGenerator)
                .ToArray())
            .AddAdditionalTexts([..additionalTexts])
            .WithUpdatedAnalyzerConfigOptions(new DictionaryAnalyzerConfigOptionsProvider(globalOptions, additionalTextOptions: additionalTextOptions))
            .RunGeneratorsAndUpdateCompilation(compilation, out compilation, out _, cancellationToken);
        var diagnostics = compilation.GetDiagnostics(cancellationToken)
            .Where(x => x.Id != "CS0618")
            .ToImmutableArray();

        await Task.WhenAll(
            Verify(diagnostics.NormalizeLocations())
                .UseDirectory($"Snapshots/{callerName}/{jsonSerializerType:G}")
                //.AutoVerify()
                .UseTextForParameters("Diagnostics"),
            Verify(driver)
                .UseDirectory($"Snapshots/{callerName}/{jsonSerializerType:G}")
                .UseFileName("_")
                .AutoVerify()
                );
    }
    
    private async Task CheckCliSourceAsync<T>(
        IList<AdditionalText> additionalTexts,
        string callerName,
        Dictionary<string, string>? globalOptions = null,
        Dictionary<string, Dictionary<string, string>>? additionalTextOptions = null,
        CancellationToken cancellationToken = default,
        params IIncrementalGenerator[] additionalGenerators)
        where T : IIncrementalGenerator, new()
    {
        globalOptions ??= new Dictionary<string, string>();
        globalOptions.TryAdd("build_property.AutoSDK_Namespace", "G");
        globalOptions.TryAdd("build_property.AutoSDK_JsonSerializerType", "SystemTextJson");
        globalOptions.TryAdd("build_property.AutoSDK_GenerateJsonSerializerContextTypes", "true");
        globalOptions.TryAdd("build_property.TargetFramework",  "net8.0");
        globalOptions.TryAdd("build_property.AutoSDK_UseExperimentalAttributes", "InSupportedTargetFrameworks");
        globalOptions.TryAdd("build_property.AutoSDK_UseSetsRequiredMembersAttributes", "InSupportedTargetFrameworks");
        globalOptions.TryAdd("build_property.AutoSDK_GenerateModels", "true");
        globalOptions.TryAdd("build_property.AutoSDK_GenerateCli", "true");

        var referenceAssemblies = LatestReferenceAssemblies.Net80.AddPackages([
            new PackageIdentity("System.CommandLine", "2.0.0-beta5.25306.1"),
            new PackageIdentity("Microsoft.Extensions.DependencyInjection", "9.0.6")
        ]);
        var references = await referenceAssemblies.ResolveAsync(null, cancellationToken);
        var trees = new List<SyntaxTree>
        {
            SyntaxFactory.ParseSyntaxTree("[assembly: System.CLSCompliantAttribute(true)]"),
        };

        additionalTextOptions ??= new Dictionary<string, Dictionary<string, string>>();
        foreach (var additionalText in additionalTexts)
        {
            var options = additionalTextOptions.TryGetValue(additionalText.Path, out var existingOptions)
                ? existingOptions
                : new Dictionary<string, string>();
            options.TryAdd("build_metadata.AdditionalFiles.AutoSDK_OpenApiSpecification", "true");
            additionalTextOptions[additionalText.Path] = options;
        }
        
        var compilation = (Compilation)CSharpCompilation.Create(
            assemblyName: "Tests",
            syntaxTrees: [..trees],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        var generator = new T();
        var driver = CSharpGeneratorDriver.Create(
            generators: new IIncrementalGenerator[] { generator }
                .Concat(additionalGenerators)
                .Select(GeneratorExtensions.AsSourceGenerator)
                .ToArray())
            .AddAdditionalTexts([..additionalTexts])
            .WithUpdatedAnalyzerConfigOptions(new DictionaryAnalyzerConfigOptionsProvider(globalOptions, additionalTextOptions: additionalTextOptions))
            .RunGeneratorsAndUpdateCompilation(compilation, out compilation, out _, cancellationToken);
        var diagnostics = compilation.GetDiagnostics(cancellationToken)
            .Where(x => x.Id != "CS0618")
            .ToImmutableArray();

        await Task.WhenAll(
            Verify(diagnostics.NormalizeLocations())
                .UseDirectory($"Snapshots/CLI/{callerName}")
                //.AutoVerify()
                .UseTextForParameters("Diagnostics"),
            Verify(driver)
                .UseDirectory($"Snapshots/CLI/{callerName}")
                .UseFileName("_")
                .AutoVerify()
                );
    }
}