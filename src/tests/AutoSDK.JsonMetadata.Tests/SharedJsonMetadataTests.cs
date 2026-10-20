using System.Collections.Immutable;
using AutoSDK.JsonMetadata;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;

namespace AutoSDK.JsonMetadata.Tests;

[TestClass]
public class SharedJsonMetadataTests
{
    private const string Models = """
using System.Text.Json.Serialization;
namespace Fixture;
public sealed class Used
{
    public string? Value { get; set; }
    public Child? Child { get; set; }
}
public sealed class Child
{
    public int Count { get; set; }
}
public sealed class Unused
{
    public string? UnusedValue { get; set; }
}
""";

    private static readonly ImmutableArray<MetadataReference> References = CreateReferences();

    private static ImmutableArray<MetadataReference> CreateReferences()
    {
        var assemblies = AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES") is string paths
            ? paths : throw new InvalidOperationException("Runtime reference assemblies are unavailable.");
        return assemblies.Split(Path.PathSeparator)
            .Append(typeof(System.Text.Json.JsonSerializer).Assembly.Location)
            .Where(static path => !string.Equals(System.IO.Path.GetFileName(path),
                "System.Text.Json.SourceGeneration.dll", StringComparison.OrdinalIgnoreCase))
            .GroupBy(static path => System.IO.Path.GetFileName(path), StringComparer.OrdinalIgnoreCase)
            .Select(static group => group.Last())
            .Select(static path => MetadataReference.CreateFromFile(path))
            .Cast<MetadataReference>().ToImmutableArray();
    }

    [TestMethod]
    public void Generate_ProducesCompilableStaticFactoriesWithoutAnAggregateContext()
    {
        var (compilation, result) = Generate("Metadata");
        result.Diagnostics.Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        compilation.GetDiagnostics().Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        var text = string.Join("\n", result.Results.SelectMany(static generator => generator.GeneratedSources)
            .Select(static source => source.SourceText.ToString()));
        text.Should().Contain("internal static partial class SharedMetadata");
        text.Should().Contain("Create_Used").And.Contain("Create_Child").And.Contain("Create_Unused");
        text.Should().Contain("options.TypeInfoResolver");
        text.Should().NotContain(" : global::System.Text.Json.Serialization.JsonSerializerContext");
        text.Should().NotContain("Default { get; }").And.NotContain("jsonTypeInfo.OriginatingResolver = this");
    }

    [TestMethod]
    public void Generate_RejectsInstanceBoundSerializationWriters()
    {
        var (_, result) = Generate("Serialization");
        result.Diagnostics.Should().Contain(static diagnostic =>
            diagnostic.Id == "AMETA001" && diagnostic.Severity == DiagnosticSeverity.Error);
    }

    [TestMethod]
    public void Generate_WithoutManifestsEmitsNothing()
    {
        var compilation = CSharpCompilation.Create("NoManifest",
            [CSharpSyntaxTree.ParseText(Models)], References,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        GeneratorDriver driver = CSharpGeneratorDriver.Create(new SharedJsonMetadataGenerator());
        driver = driver.RunGenerators(compilation);
        driver.GetRunResult().Results.SelectMany(static result => result.GeneratedSources).Should().BeEmpty();
    }

    private static (Compilation Compilation, GeneratorDriverRunResult Result) Generate(string mode)
    {
        var manifest = $$"""
#nullable enable
namespace Fixture;
[global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
    GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.{{mode}})]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fixture.Used))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fixture.Unused))]
internal sealed partial class SharedMetadata : global::System.Text.Json.Serialization.JsonSerializerContext { }
""";
        var compilation = CSharpCompilation.Create("MetadataFixture",
            [CSharpSyntaxTree.ParseText(Models)], References,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary,
                nullableContextOptions: NullableContextOptions.Enable));
        GeneratorDriver driver = CSharpGeneratorDriver.Create(
            generators: [new SharedJsonMetadataGenerator().AsSourceGenerator()],
            additionalTexts: [new Manifest(manifest)]);
        driver = driver.RunGeneratorsAndUpdateCompilation(compilation, out var output, out _);
        return (output, driver.GetRunResult());
    }

    private sealed class Manifest(string text) : AdditionalText
    {
        public override string Path => "Fixture.autosdk-json-metadata";
        public override SourceText GetText(CancellationToken cancellationToken = default) => SourceText.From(text);
    }
}
