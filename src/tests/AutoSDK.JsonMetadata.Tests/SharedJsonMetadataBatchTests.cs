using System.Collections.Immutable;
using System.Reflection;
using AutoSDK.JsonMetadata;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace AutoSDK.JsonMetadata.Tests;

[TestClass]
public class SharedJsonMetadataBatchTests
{
    private static readonly ImmutableArray<MetadataReference> References =
        ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!).Split(Path.PathSeparator)
            .Where(static path => !Path.GetFileName(path).Equals("System.Text.Json.SourceGeneration.dll", StringComparison.OrdinalIgnoreCase))
            .Select(static path => (MetadataReference)MetadataReference.CreateFromFile(path)).ToImmutableArray();

    [TestMethod]
    [DataRow(1, 0, false)]
    [DataRow(33, 0, false)]
    [DataRow(33, 0, true)]
    [DataRow(3, 600, false)]
    public void Generate_BatchesPreserveClrTypesAndBoundCompilerClosures(int count, int properties, bool disableFirstBatch)
    {
        var (compilation, result) = Generate(count, properties, disableFirstBatch);
        result.Diagnostics.Should().NotContain(static item => item.Severity == DiagnosticSeverity.Error);
        compilation.GetDiagnostics().Should().NotContain(static item => item.Severity == DiagnosticSeverity.Error);
        var generated = result.Results[0].GeneratedSources;
        var classes = generated.SelectMany(static item => item.SyntaxTree.GetRoot().DescendantNodes()
            .OfType<ClassDeclarationSyntax>()).ToArray();
        var holders = classes.Where(static item => item.Identifier.ValueText.Contains("FactoryBatch", StringComparison.Ordinal)).ToArray();
        holders.Should().NotBeEmpty();
        foreach (var holder in holders)
        {
            holder.Members.OfType<MethodDeclarationSyntax>().Count(static method =>
                method.Identifier.ValueText.StartsWith("Create_", StringComparison.Ordinal)).Should().BeLessThanOrEqualTo(16);
            // The heavy fixture's individual factories fit below the budget; each part must too.
            var weight = holder.DescendantNodes().Count(static node =>
                node is MethodDeclarationSyntax or ConstructorDeclarationSyntax) +
                4 * holder.DescendantNodes().Count(static node =>
                    node is AnonymousFunctionExpressionSyntax or LocalFunctionStatementSyntax);
            weight.Should().BeLessThanOrEqualTo(8192);
        }
        if (properties != 0)
        {
            holders.Should().Contain(static holder => holder.Identifier.ValueText.Contains("Part", StringComparison.Ordinal));
        }
        else
        {
            holders.Length.Should().BeLessThanOrEqualTo((count + 15) / 16 + 1);
        }
        var text = string.Join("\n", generated.Select(static item => item.SourceText.ToString()));
        text.Should().NotContain("Default { get; }").And.NotContain("switch (type)");
        if (disableFirstBatch)
        {
            text.Should().Contain("SharedMetadataFactoryBatch0001").And.NotContain("Create_Model00");
        }
        using var stream = new MemoryStream();
        var emitted = compilation.Emit(stream);
        emitted.Success.Should().BeTrue(string.Join("\n", emitted.Diagnostics));
        // Loading forces CLR type validation, including compiler-generated closure classes.
        var assembly = Assembly.Load(stream.ToArray());
        assembly.GetTypes().Count(static type => type.Namespace == "Fixture" &&
            type.Name.StartsWith("Model", StringComparison.Ordinal)).Should().Be(count);
    }

    [TestMethod]
    [DataRow("missing")]
    [DataRow("duplicate")]
    [DataRow("oversized")]
    public void Generate_InvalidBatchPlansReportActionableDiagnostic(string failure)
    {
        var (_, result) = Generate(18, 0, false, failure);
        result.Diagnostics.Should().Contain(static item =>
            item.Id == "AMETA003" && item.Severity == DiagnosticSeverity.Error);
    }


    [TestMethod]
    public void Generate_NullableReferenceRegistrationAliasesPreserveRuntimeIdentity()
    {
        const string model = """
            #nullable enable
            using System.Collections.Generic;
            using System.Text.Json;
            using System.Text.Json.Serialization.Metadata;
            namespace Fixture;
            public static class Probe
            {
                public static string Run()
                {
                    var options = new JsonSerializerOptions { TypeInfoResolver = new PrimitiveResolver() };
                    options.MakeReadOnly();
                    var first = SharedMetadataFactoryBatch0000.Create_Strings(options);
                    var second = SharedMetadataFactoryBatch0001.Create_NullableStrings(options);
                    var concrete = SharedMetadataFactoryBatch0000.Create_ConcreteStrings(options);
                    var nullableConcrete = SharedMetadataFactoryBatch0001.Create_ConcreteNullableStrings(options);
                    if (first.Type != second.Type || concrete.Type != nullableConcrete.Type ||
                        SharedMetadataFactoryBatch0000.Create_Number(options).Type ==
                        SharedMetadataFactoryBatch0000.Create_NullableNumber(options).Type)
                        throw new System.InvalidOperationException("Runtime type identity");
                    return JsonSerializer.Serialize((object)new List<string?> { "fixture", null }, second);
                }
            }
            internal sealed class PrimitiveResolver : IJsonTypeInfoResolver
            {
                public JsonTypeInfo? GetTypeInfo(System.Type type, JsonSerializerOptions options) =>
                    type == typeof(string) ? JsonMetadataServices.CreateValueInfo<string>(options, JsonMetadataServices.StringConverter) :
                    type == typeof(int) ? JsonMetadataServices.CreateValueInfo<int>(options, JsonMetadataServices.Int32Converter) : null;
            }
            """;
        const string manifest = """
            // AutoSDK.JsonMetadata manifest-format: 3
            // AutoSDK.JsonMetadata factory-batch: Fixture.SharedMetadata|0|Strings,ConcreteStrings,Number,NullableNumber
            // AutoSDK.JsonMetadata factory-batch: Fixture.SharedMetadata|1|NullableStrings,ConcreteNullableStrings
            #nullable enable
            namespace Fixture;
            [System.Text.Json.Serialization.JsonSourceGenerationOptions(GenerationMode = System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
            [System.Text.Json.Serialization.JsonSerializable(typeof(System.Collections.Generic.IList<string>), TypeInfoPropertyName = "Strings")]
            [System.Text.Json.Serialization.JsonSerializable(typeof(System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "NullableStrings")]
            [System.Text.Json.Serialization.JsonSerializable(typeof(System.Collections.Generic.List<string>), TypeInfoPropertyName = "ConcreteStrings")]
            [System.Text.Json.Serialization.JsonSerializable(typeof(System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ConcreteNullableStrings")]
            [System.Text.Json.Serialization.JsonSerializable(typeof(int), TypeInfoPropertyName = "Number")]
            [System.Text.Json.Serialization.JsonSerializable(typeof(int?), TypeInfoPropertyName = "NullableNumber")]
            internal sealed partial class SharedMetadata : System.Text.Json.Serialization.JsonSerializerContext { }
            """;
        var compilation = CSharpCompilation.Create("NullableAliasFixture" + Guid.NewGuid().ToString("N"),
            [CSharpSyntaxTree.ParseText(model)], References,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, nullableContextOptions: NullableContextOptions.Enable));
        GeneratorDriver driver = CSharpGeneratorDriver.Create(
            generators: [new SharedJsonMetadataGenerator().AsSourceGenerator()],
            additionalTexts: [new Manifest(manifest)]);
        driver = driver.RunGeneratorsAndUpdateCompilation(compilation, out var output, out _);
        driver.GetRunResult().Diagnostics.Should().NotContain(static item => item.Severity == DiagnosticSeverity.Error);
        output.GetDiagnostics().Should().NotContain(static item => item.Severity == DiagnosticSeverity.Error);
        using var stream = new MemoryStream();
        var emitted = output.Emit(stream);
        emitted.Success.Should().BeTrue(string.Join("\n", emitted.Diagnostics));
        var assembly = Assembly.Load(stream.ToArray());
        assembly.GetType("Fixture.Probe")!.GetMethod("Run")!.Invoke(null, null).Should().Be("[\"fixture\",null]");
    }

    private static (Compilation Compilation, GeneratorDriverRunResult Result) Generate(
        int count, int properties, bool disableFirstBatch, string? failure = null)
    {
        var names = Enumerable.Range(0, count).Select(static index => "Model" + index.ToString("D2",
            System.Globalization.CultureInfo.InvariantCulture)).ToArray();
        var models = "namespace Fixture;\n" + string.Join("\n", names.Select(name =>
            "public sealed class " + name + " { " + (properties == 0 ? "public string? Value { get; set; }" :
                string.Join(" ", Enumerable.Range(0, properties).Select(static index =>
                    "public int Property" + index.ToString(System.Globalization.CultureInfo.InvariantCulture) + " { get; set; }"))) + " }"));
        var plan = string.Join("\n", names.Chunk(16).Select((batch, index) =>
            "// AutoSDK.JsonMetadata factory-batch: Fixture.SharedMetadata|" +
            index.ToString(System.Globalization.CultureInfo.InvariantCulture) + "|" + string.Join(",", batch)));
        var attributes = string.Join("\n", names.Select((name, index) =>
            (disableFirstBatch && index < 16 ? "#if OMITTED_BATCH\n" : string.Empty) +
            "[System.Text.Json.Serialization.JsonSerializable(typeof(" + name + "), TypeInfoPropertyName = \"" + name + "\")]" +
            (disableFirstBatch && index < 16 ? "\n#endif" : string.Empty)));
        if (failure == "missing")
        {
            plan = string.Empty;
        }
        else if (failure == "duplicate")
        {
            plan += "\n// AutoSDK.JsonMetadata factory-batch: Fixture.SharedMetadata|0|Model00";
        }
        else if (failure == "oversized")
        {
            plan = "// AutoSDK.JsonMetadata factory-batch: Fixture.SharedMetadata|0|" + string.Join(",", names);
        }
        var manifest = "// AutoSDK.JsonMetadata manifest-format: 3\n" + plan + """
            
            #nullable enable
            namespace Fixture;
            [System.Text.Json.Serialization.JsonSourceGenerationOptions(GenerationMode = System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
            """ + "\n" + attributes + """
            
            internal sealed partial class SharedMetadata : System.Text.Json.Serialization.JsonSerializerContext { }
            """;
        var compilation = CSharpCompilation.Create("BatchFixture" + Guid.NewGuid().ToString("N"),
            [CSharpSyntaxTree.ParseText(models)], References,
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
