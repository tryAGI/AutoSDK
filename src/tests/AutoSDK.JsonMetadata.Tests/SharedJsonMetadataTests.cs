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
public sealed partial class Used
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
    public void Generate_CoexistsWithOrdinaryContextsWithoutTransformingThem()
    {
        var (compilation, result) = Generate("Metadata", ordinaryContext: true);
        result.Diagnostics.Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        compilation.GetDiagnostics().Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        var shared = result.Results[0].GeneratedSources;
        shared.Should().NotContain(static source => source.HintName.Contains("OrdinaryContext"));
        shared.Should().Contain(static source => source.HintName.Contains("SharedMetadata"));
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

    [TestMethod]
    public void Generate_CompletesPartialMemberGraphsWithoutAddingIgnoredOrUnrelatedTypes()
    {
        var (compilation, result) = Generate("Metadata", extraSource: """
namespace Fixture;
public sealed partial class Used
{
    public byte[]? Bytes { get; set; }
    public PartialDetails? Details { get; set; }
    [System.Text.Json.Serialization.JsonIgnore]
    public Unused? Ignored { get; set; }
}
public sealed class PartialDetails
{
    public System.Collections.Generic.IList<byte[]>? Blobs { get; set; }
    public Used? Parent { get; set; }
}
public partial class Scope
{
    private sealed partial class SharedMetadataResolver : System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
    {
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
            System.Type type, System.Text.Json.JsonSerializerOptions options)
        {
            if (type == typeof(Used)) return global::Fixture.SharedMetadata.Create_Used(options);
            System.Text.Json.Serialization.Metadata.JsonTypeInfo? result = null;
            ResolveAdditionalTypeInfo(type, options, ref result);
            return result;
        }
        static partial void ResolveAdditionalTypeInfo(System.Type type, System.Text.Json.JsonSerializerOptions options,
            ref System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
    }
    public static string Run()
    {
        var options = new System.Text.Json.JsonSerializerOptions { TypeInfoResolver = new SharedMetadataResolver() };
        var value = System.Text.Json.JsonSerializer.Deserialize<Used>(
            "{\"Value\":\"partial\",\"Bytes\":\"AQID\",\"Child\":{\"Count\":2},\"Details\":{\"Blobs\":[\"BAU=\"],\"Parent\":null}}", options)!;
        return System.Text.Json.JsonSerializer.Serialize(value, options);
    }
}
""");
        result.Diagnostics.Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        compilation.GetDiagnostics().Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        var resolver = result.Results[0].GeneratedSources.Single(static source =>
            source.HintName.StartsWith("AutoSDK.SharedDependencies.", StringComparison.Ordinal)).SourceText.ToString();
        resolver.Should().Contain("Create_ByteArray").And.Contain("Create_PartialDetails");
        resolver.Should().NotContain("Create_Unused");
        using var stream = new MemoryStream();
        var emitted = compilation.Emit(stream);
        emitted.Success.Should().BeTrue(string.Join("\n", emitted.Diagnostics));
        var assembly = System.Reflection.Assembly.Load(stream.ToArray());
        var json = (string)assembly.GetType("Fixture.Scope")!.GetMethod("Run")!.Invoke(null, null)!;
        using var document = System.Text.Json.JsonDocument.Parse(json);
        document.RootElement.GetProperty("Bytes").GetString().Should().Be("AQID");
        document.RootElement.GetProperty("Details").GetProperty("Blobs")[0].GetString().Should().Be("BAU=");
        document.RootElement.TryGetProperty("Ignored", out _).Should().BeFalse();
    }

    private static (Compilation Compilation, GeneratorDriverRunResult Result) Generate(string mode, bool ordinaryContext = false, string? extraSource = null)
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
        if (extraSource is not null)
        {
            compilation = compilation.AddSyntaxTrees(CSharpSyntaxTree.ParseText(extraSource));
        }
        if (ordinaryContext)
        {
            compilation = compilation.AddSyntaxTrees(CSharpSyntaxTree.ParseText("""
namespace Fixture;
[System.Text.Json.Serialization.JsonSerializable(typeof(Used))]
internal sealed partial class OrdinaryContext : System.Text.Json.Serialization.JsonSerializerContext { }
"""));
        }
        GeneratorDriver driver = CSharpGeneratorDriver.Create(
            generators: [new SharedJsonMetadataGenerator().AsSourceGenerator(),
                new System.Text.Json.SourceGeneration.JsonSourceGenerator().AsSourceGenerator()],
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
