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
    [DataRow(false)]
    [DataRow(true)]
    public void Generate_CompletesPartialMemberGraphsWithoutAddingIgnoredOrUnrelatedTypes(bool isolatedFactories)
    {
        var source = """
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
""";
        if (isolatedFactories)
        {
            source = source.Replace("global::Fixture.SharedMetadata.Create_Used",
                "global::Fixture.SharedMetadataFactory_Used.Create_Used", StringComparison.Ordinal);
        }
        var (compilation, result) = Generate("Metadata", extraSource: source,
            manifestVersion: isolatedFactories ? 1 : null);
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

    [TestMethod]
    [DataRow(true, false)]
    [DataRow(false, true)]
    public void Generate_ForwardsWarningsAndHonorsWarningsAsErrors(bool warningsAsErrors, bool specificWarningsAsErrors)
    {
        var (_, result) = Generate("Metadata", warningsAsErrors: warningsAsErrors,
            specificWarningsAsErrors: specificWarningsAsErrors, extraSource: """
namespace Fixture;
public sealed partial class Used
{
    [System.Text.Json.Serialization.JsonInclude]
    private string? Hidden { get; set; }
}
""");
        result.Diagnostics.Should().Contain(static diagnostic =>
            diagnostic.Id == "AMETA002" && diagnostic.Severity == DiagnosticSeverity.Error &&
            diagnostic.GetMessage().Contains("SYSLIB1038", StringComparison.Ordinal));
    }

    [TestMethod]
    public void Generate_DoesNotRepeatOrdinaryContextWarnings()
    {
        var (_, result) = Generate("Metadata", ordinaryContext: true, extraSource: """
namespace Fixture;
public sealed partial class Used
{
    [System.Text.Json.Serialization.JsonInclude]
    private string? Hidden { get; set; }
}
""");
        result.Diagnostics.Count(static diagnostic => diagnostic.Id is "SYSLIB1038" or "AMETA002")
            .Should().Be(1, "the framework generator already reports this ordinary-context warning");
        result.Diagnostics.Should().Contain(static diagnostic => diagnostic.Id == "SYSLIB1038");
        result.Diagnostics.Should().NotContain(static diagnostic => diagnostic.Id == "AMETA002");
    }

    [TestMethod]
    public void Generate_PreservesWarningProvenanceFromAdditionalManifests()
    {
        var (_, result) = Generate("Metadata", duplicateTypeInfoNames: true);
        result.Diagnostics.Should().Contain(static diagnostic => diagnostic.Id == "AMETA002" &&
            diagnostic.GetMessage().Contains("SYSLIB1031", StringComparison.Ordinal) &&
            diagnostic.GetMessage().Contains("Fixture.autosdk-json-metadata", StringComparison.Ordinal));
        result.Diagnostics.Should().NotContain(static diagnostic => diagnostic.Id == "CS8785",
            "a manifest location outside the user compilation must not crash the generator");
    }


    [TestMethod]
    public void Generate_VersionedManifestKeepsOneIndependentFactoryPerType()
    {
        var (compilation, result) = Generate("Metadata", manifestVersion: 1);
        result.Diagnostics.Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        compilation.GetDiagnostics().Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        var sources = result.Results[0].GeneratedSources;
        var roots = sources.Select(source => CSharpSyntaxTree.ParseText(source.SourceText)
            .GetRoot()).ToArray();
        roots.SelectMany(static root => root.DescendantNodes())
            .OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>()
            .Count(static method => method.Identifier.ValueText == "Create_Child").Should().Be(1);
        roots.SelectMany(static root => root.DescendantNodes())
            .OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax>()
            .Should().Contain(static type => type.Identifier.ValueText == "SharedMetadataFactory_Child" &&
                type.BaseList != null && type.BaseList.Types[0].Type.ToString() == "SharedMetadata");
        using var stream = new MemoryStream();
        var emitted = compilation.Emit(stream);
        emitted.Success.Should().BeTrue(string.Join("\n", emitted.Diagnostics));
        var assembly = System.Reflection.Assembly.Load(stream.ToArray());
        assembly.GetTypes().Should().Contain(static type => type.Name == "SharedMetadataFactory_Child");
    }

    [TestMethod]
    [DataRow(4)]
    [DataRow(-1)]
    public void Generate_RejectsIncompatibleManifestProtocolBeforeRunningStj(int version)
    {
        var (_, result) = Generate("Metadata", manifestVersion: version);
        result.Diagnostics.Should().Contain(static diagnostic =>
            diagnostic.Id == "AMETA003" && diagnostic.Severity == DiagnosticSeverity.Error &&
            diagnostic.GetMessage().Contains("Fixture.autosdk-json-metadata", StringComparison.Ordinal));
        result.Results[0].GeneratedSources.Should().BeEmpty();
    }

    [TestMethod]
    public void Generate_ProtocolGuardRequiresAnalyzerSupportAndCompilesWithVersionOne()
    {
        const string guard = """
namespace Fixture;
internal static class MetadataGuard
{
    internal const int Version = global::AutoSDK.JsonMetadata.Generated.ManifestProtocol.Version1;
}
""";
        var withoutAnalyzer = CSharpCompilation.Create("MissingAnalyzer",
            [CSharpSyntaxTree.ParseText(guard)], References,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        withoutAnalyzer.GetDiagnostics().Should().Contain(static diagnostic =>
            diagnostic.Severity == DiagnosticSeverity.Error &&
            diagnostic.GetMessage().Contains("AutoSDK", StringComparison.Ordinal));
        var (compilation, result) = Generate("Metadata", extraSource: guard, manifestVersion: 1);
        result.Diagnostics.Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        compilation.GetDiagnostics().Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
    }


    [TestMethod]
    [DataRow(false, 2)]
    [DataRow(true, 2)]
    [DataRow(false, 3)]
    [DataRow(true, 3)]
    public void Generate_ScopedDependenciesAreCompletedOnceWithoutFlatteningParents(bool referenceChildScope, int manifestVersion)
    {
        var source = """
namespace Fixture;
public sealed partial class Used
{
    public PartialDetails? Details { get; set; }
}
public sealed class PartialDetails
{
    public byte[]? Bytes { get; set; }
}
public partial class ParentScope
{
    // The analyzer recognizes generated outgoing scope references independently of resolver code.
    internal static object MetadataScope => ChildScope.MetadataScope;
    private sealed partial class SharedMetadataResolver : System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
    {
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
            System.Type type, System.Text.Json.JsonSerializerOptions options)
        {
            if (type == typeof(Used)) return global::Fixture.SharedMetadataFactory_Used.Create_Used(options);
            System.Text.Json.Serialization.Metadata.JsonTypeInfo? result = null;
            ResolveAdditionalTypeInfo(type, options, ref result);
            return result;
        }
        static partial void ResolveAdditionalTypeInfo(System.Type type, System.Text.Json.JsonSerializerOptions options,
            ref System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
    }
}
public partial class ChildScope
{
    internal static object MetadataScope => new object();
    private sealed partial class SharedMetadataResolver : System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
    {
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
            System.Type type, System.Text.Json.JsonSerializerOptions options)
        {
            if (type == typeof(PartialDetails)) return global::Fixture.SharedMetadataFactory_PartialDetails.Create_PartialDetails(options);
            System.Text.Json.Serialization.Metadata.JsonTypeInfo? result = null;
            ResolveAdditionalTypeInfo(type, options, ref result);
            return result;
        }
        static partial void ResolveAdditionalTypeInfo(System.Type type, System.Text.Json.JsonSerializerOptions options,
            ref System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
    }
}
""";
        if (!referenceChildScope) source = source.Replace("ChildScope.MetadataScope", "new object()", StringComparison.Ordinal);
        if (manifestVersion == 3)
        {
            source = source.Replace("SharedMetadataFactory_Used", "SharedMetadataFactoryBatch0000", StringComparison.Ordinal)
                .Replace("SharedMetadataFactory_PartialDetails", "SharedMetadataFactoryBatchImplicit0000", StringComparison.Ordinal);
        }
        var (compilation, result) = Generate("Metadata", extraSource: source, manifestVersion: manifestVersion);
        compilation.GetDiagnostics().Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        var parent = result.Results[0].GeneratedSources.Single(static source =>
            source.HintName == "AutoSDK.SharedDependencies.Fixture.ParentScope.g.cs").SourceText.ToString();
        var child = result.Results[0].GeneratedSources.Single(static source =>
            source.HintName == "AutoSDK.SharedDependencies.Fixture.ChildScope.g.cs").SourceText.ToString();
        child.Should().Contain("typeof(byte[])").And.NotContain("Create_Used");
        if (referenceChildScope)
            parent.Should().NotContain("Create_PartialDetails").And.NotContain("typeof(byte[])");
        else
            parent.Should().Contain("Create_PartialDetails").And.Contain("typeof(byte[])");
        parent.Should().NotContain("Create_Unused");
    }

    [TestMethod]
    [DataRow(false, false)]
    [DataRow(true, false)]
    [DataRow(false, true)]
    [DataRow(true, true)]
    public void Generate_MultipleManifestsCompleteDependenciesUsingTheirOwnNamespaceFactories(bool identicalContextNames,
        bool ordinaryContext)
    {
        var models = new List<SyntaxTree>();
        var manifests = new List<AdditionalText>();
        foreach (var ns in new[] { "Alpha", "Beta" })
        {
            var contextName = identicalContextNames ? "Metadata" : ns + "Metadata";
            models.Add(CSharpSyntaxTree.ParseText($$"""
namespace {{ns}}
{
    public sealed class Root { public bool Flag { get; set; } }
    internal static partial class Scope
    {
        private sealed partial class SharedMetadataResolver : System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                System.Type type, System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(Root)) return global::{{ns}}.{{contextName}}Factory_Root.Create_Root(options);
                System.Text.Json.Serialization.Metadata.JsonTypeInfo? result = null;
                ResolveAdditionalTypeInfo(type, options, ref result);
                return result;
            }
            static partial void ResolveAdditionalTypeInfo(System.Type type, System.Text.Json.JsonSerializerOptions options,
                ref System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }
    }
}
"""));
            manifests.Add(new Manifest($$"""
// AutoSDK.JsonMetadata manifest-format: 2
namespace {{ns}};
[System.Text.Json.Serialization.JsonSourceGenerationOptions(GenerationMode = System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
[System.Text.Json.Serialization.JsonSerializable(typeof(Root))]
internal sealed partial class {{contextName}} : System.Text.Json.Serialization.JsonSerializerContext { }
""", ns + ".autosdk-json-metadata"));
        }
        if (ordinaryContext)
        {
            var contextName = identicalContextNames ? "Metadata" : "AlphaMetadata";
            models.Add(CSharpSyntaxTree.ParseText($$"""
namespace Gamma;
public sealed class Root { public bool Flag { get; set; } }
[System.Text.Json.Serialization.JsonSerializable(typeof(Root))]
internal sealed partial class {{contextName}} : System.Text.Json.Serialization.JsonSerializerContext { }
"""));
        }
        var compilation = CSharpCompilation.Create("MultipleManifests", models, References,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, nullableContextOptions: NullableContextOptions.Enable));
        GeneratorDriver driver = CSharpGeneratorDriver.Create(
            generators: [new SharedJsonMetadataGenerator().AsSourceGenerator(),
                new System.Text.Json.SourceGeneration.JsonSourceGenerator().AsSourceGenerator()], additionalTexts: manifests);
        driver = driver.RunGeneratorsAndUpdateCompilation(compilation, out var output, out _);
        output.GetDiagnostics().Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        driver.GetRunResult().Diagnostics.Should().NotContain(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
        var sources = driver.GetRunResult().Results[0].GeneratedSources;
        foreach (var ns in new[] { "Alpha", "Beta" })
        {
            var source = sources.Single(source => source.HintName == "AutoSDK.SharedDependencies." + ns + ".Scope.g.cs").SourceText.ToString();
            var contextName = identicalContextNames ? "Metadata" : ns + "Metadata";
            source.Should().Contain("global::" + ns + "." + contextName + "Factory_Boolean.Create_Boolean(options)")
                .And.NotContain("global::" + (ns == "Alpha" ? "Beta" : "Alpha") + ".");
        }
    }

    private static (Compilation Compilation, GeneratorDriverRunResult Result) Generate(string mode, bool ordinaryContext = false, string? extraSource = null, bool warningsAsErrors = false, bool duplicateTypeInfoNames = false, bool specificWarningsAsErrors = false, int? manifestVersion = null)
    {
        var nameOverride = duplicateTypeInfoNames ? ", TypeInfoPropertyName = \"Collision\"" : string.Empty;
        var usedName = manifestVersion == 3 ? ", TypeInfoPropertyName = \"Used\"" : nameOverride;
        var unusedName = manifestVersion == 3 ? ", TypeInfoPropertyName = \"Unused\"" : nameOverride;
        var manifest = $$"""
#nullable enable
namespace Fixture;
[global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
    GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.{{mode}})]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fixture.Used){{usedName}})]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fixture.Unused){{unusedName}})]
internal sealed partial class SharedMetadata : global::System.Text.Json.Serialization.JsonSerializerContext { }
""";
        if (manifestVersion == 3)
        {
            manifest = "// AutoSDK.JsonMetadata factory-batch: Fixture.SharedMetadata|0|Unused,Used\n" + manifest;
        }
        if (manifestVersion is { } version)
        {
            manifest = "// AutoSDK.JsonMetadata manifest-format: " +
                version.ToString(System.Globalization.CultureInfo.InvariantCulture) + "\n" + manifest;
        }
        var compilation = CSharpCompilation.Create("MetadataFixture",
            [CSharpSyntaxTree.ParseText(Models)], References,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary,
                nullableContextOptions: NullableContextOptions.Enable,
                generalDiagnosticOption: warningsAsErrors ? ReportDiagnostic.Error : ReportDiagnostic.Default,
                specificDiagnosticOptions: specificWarningsAsErrors
                    ? new Dictionary<string, ReportDiagnostic> { ["SYSLIB1038"] = ReportDiagnostic.Error }
                    : null));
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

    private sealed class Manifest(string text, string path = "Fixture.autosdk-json-metadata") : AdditionalText
    {
        public override string Path => path;
        public override SourceText GetText(CancellationToken cancellationToken = default) => SourceText.From(text);
    }
}
