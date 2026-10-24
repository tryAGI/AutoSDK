extern alias AutoSdkCli;
using System.Text;
using System.Text.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Text;
using AssemblyFootprint = AutoSdkCli::AutoSDK.CLI.Trimming.AssemblyFootprint;
using TrimReport = AutoSdkCli::AutoSDK.CLI.Trimming.TrimReport;
using TrimCommand = AutoSdkCli::AutoSDK.CLI.Commands.TrimCommand;

namespace AutoSDK.UnitTests;

[TestClass]
public class TrimReportTests
{
    [TestMethod]
    public void EmbeddedPdb_IsSeparateFromIdenticalMetadataAndIl()
    {
        using var embedded = new CompiledFixture(true);
        using var portable = new CompiledFixture(false);
        var first = AssemblyFootprint.Read(embedded.AssemblyPath)!;
        var second = AssemblyFootprint.Read(portable.AssemblyPath)!;
        first.EmbeddedPortablePdbBytes.Should().BeGreaterThan(0);
        second.EmbeddedPortablePdbBytes.Should().Be(0);
        first.BytesWithoutEmbeddedPdbPayload.Should().Be(first.FileBytes - first.EmbeddedPortablePdbBytes);
        first.MetadataBytes.Should().Be(second.MetadataBytes).And.BeGreaterThan(0);
        first.IlBytes.Should().Be(second.IlBytes).And.BeGreaterThan(0);
        first.TypeCount.Should().Be(second.TypeCount);
        first.MethodCount.Should().Be(second.MethodCount);
        first.FieldCount.Should().Be(1);
        first.File.Should().Be("Fixture.dll");
    }

    [TestMethod]
    public void NonManagedFiles_AreNotReportedAsManagedCode()
    {
        using var fixture = new CompiledFixture(true);
        var native = Path.Combine(fixture.DirectoryPath, "native.dll");
        File.WriteAllBytes(native, [0x7f, 0x45, 0x4c, 0x46]);
        AssemblyFootprint.Read(native).Should().BeNull();
    }

    [TestMethod]
    public async Task Report_SeparatesExternalSymbolsAndWritesSourceGeneratedJson()
    {
        using var fixture = new CompiledFixture(true);
        File.WriteAllBytes(Path.Combine(fixture.DirectoryPath, "TrimmingCheck"), [1, 2, 3]);
        File.WriteAllBytes(Path.Combine(fixture.DirectoryPath, "TrimmingCheck.dbg"), [4, 5]);
        File.WriteAllBytes(Path.Combine(fixture.DirectoryPath, "extra.pdb"), [6]);
        var report = TrimReport.Collect(fixture.DirectoryPath, "Fixture", "Fixture", "net10.0",
            "linux-arm64", true, true, 1.25, 0, 0);
        report.ExternalSymbolBytes.Should().Be(3);
        report.AppExecutableBytes.Should().Be(3);
        report.Assemblies.Should().ContainSingle();
        report.PublishDirectoryBytes.Should().Be(report.Assemblies[0].FileBytes + 6);
        report.Rooting.Should().Be("whole-target-assembly-for-compatibility");
        report.PublishMode.Should().Be("nativeaot");
        report.SymbolPolicy.Should().Be("remove-managed");
        var path = Path.Combine(fixture.DirectoryPath, "reports", "footprint.json");
        await report.WriteAsync(path);
        using var json = JsonDocument.Parse(await File.ReadAllTextAsync(path));
        json.RootElement.GetProperty("schemaVersion").GetInt32().Should().Be(1);
        json.RootElement.GetProperty("externalSymbolBytes").GetInt64().Should().Be(3);
        json.RootElement.GetProperty("assemblies")[0].GetProperty("embeddedPortablePdbBytes").GetInt64().Should().BeGreaterThan(0);
        json.RootElement.GetProperty("publishSeconds").GetDouble().Should().Be(1.25);
    }

    [TestMethod]
    public void DefaultPublication_InheritsSymbolPolicyAndUsesAtomicArguments()
    {
        var start = TrimCommand.CreatePublishStartInfo("/work/a directory", "/work/publish directory", false, false);
        start.ArgumentList.Should().ContainInOrder("publish", "TrimmingCheck.csproj", "-c", "Release", "--output", "/work/publish directory");
        start.ArgumentList.Should().NotContain("-p:TrimmerRemoveSymbols=true");
        start.ArgumentList.Should().NotContain("-p:PublishAot=true");
        start.Arguments.Should().BeEmpty();
    }

    [TestMethod]
    public void ExplicitPublication_EnablesOnlyRequestedManagedSymbolAndAotPolicies()
    {
        var start = TrimCommand.CreatePublishStartInfo("/work", "/work/publish", true, true);
        start.ArgumentList.Should().Contain("-p:TrimmerRemoveSymbols=true");
        start.ArgumentList.Should().Contain("-p:PublishAot=true");
        start.ArgumentList.Should().NotContain("-p:StripSymbols=true");
    }

    [TestMethod]
    public void FailedPublication_ReportIsHonestWithoutInventedArtifacts()
    {
        using var fixture = new CompiledFixture(true);
        var report = TrimReport.Collect(Path.Combine(fixture.DirectoryPath, "missing"), "Fixture",
            "Fixture", "net10.0", "linux-arm64", false, false, 2.0, 1, 3);
        report.PublishExitCode.Should().Be(1);
        report.TrimmingWarningCount.Should().Be(3);
        report.Assemblies.Should().BeEmpty();
        report.PublishDirectoryBytes.Should().Be(0);
        report.SymbolPolicy.Should().Be("inherit");
    }

    private sealed class CompiledFixture : IDisposable
    {
        public string DirectoryPath { get; } = Path.Combine(Path.GetTempPath(), "autosdk-pdb-test-" + Guid.NewGuid().ToString("N"));
        public string AssemblyPath => Path.Combine(DirectoryPath, "Fixture.dll");

        public CompiledFixture(bool embedded)
        {
            Directory.CreateDirectory(DirectoryPath);
            var tree = CSharpSyntaxTree.ParseText(SourceText.From(
                "public sealed class Fixture { public int Value = 41; public int Answer() => Value + 1; }",
                Encoding.UTF8), path: "Fixture.cs");
            var compilation = CSharpCompilation.Create("Fixture", [tree],
                [MetadataReference.CreateFromFile(typeof(object).Assembly.Location)],
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, optimizationLevel: OptimizationLevel.Release));
            using var assembly = File.Create(AssemblyPath);
            using var pdb = embedded ? null : new MemoryStream();
            var result = compilation.Emit(assembly, pdbStream: pdb,
                options: new EmitOptions(debugInformationFormat: embedded ? DebugInformationFormat.Embedded : DebugInformationFormat.PortablePdb));
            Assert.IsTrue(result.Success, string.Join(Environment.NewLine, result.Diagnostics));
        }

        public void Dispose() => Directory.Delete(DirectoryPath, recursive: true);
    }
}
