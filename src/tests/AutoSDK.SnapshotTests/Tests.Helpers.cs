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
        if (additionalTexts.Count != 0 &&
            jsonSerializerType is JsonSerializerType.SystemTextJson)
        {
            trees.Add(SyntaxFactory.ParseSyntaxTree(@"#nullable enable

namespace G
{
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::G.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        public static global::G.SourceGenerationContext Default { get; } = new global::G.SourceGenerationContext(new global::System.Text.Json.JsonSerializerOptions());
        
        /// <summary>
        /// The source-generated options associated with this context.
        /// </summary>
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions { get; }
        
        /// <inheritdoc/>
        public SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options)
        {
        }

        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return null;
        }
    }
}
"));
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
            .WithUpdatedAnalyzerConfigOptions(new DictionaryAnalyzerConfigOptionsProvider(globalOptions))
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
}