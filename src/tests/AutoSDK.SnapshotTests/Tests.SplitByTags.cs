using System.Collections.Immutable;
using AutoSDK.SourceGenerators;
using H.Generators.Extensions;
using H.Generators.Tests.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Testing;

namespace AutoSDK.SnapshotTests;

public partial class Tests
{
    [TestMethod]
    public void GetSettings_ParsesSplitByTagsOptions()
    {
        var settings = new DictionaryAnalyzerConfigOptionsProvider(new Dictionary<string, string>
        {
            ["build_property.AutoSDK_SplitByTags"] = "true",
            ["build_property.AutoSDK_BasePackageId"] = "tryAGI.Catalogue",
            ["build_property.AutoSDK_PackageMapPath"] = "package-map.json",
            ["build_property.AutoSDK_StrongNamePublicKey"] = "0024",
        }).GetSettings(prefix: "AutoSDK");

        settings.SplitByTags.Should().BeTrue();
        settings.BasePackageId.Should().Be("tryAGI.Catalogue");
        settings.PackageMapPath.Should().Be("package-map.json");
        settings.StrongNamePublicKey.Should().Be("0024");
    }

    [TestMethod]
    public async Task SplitByTagsInSourceGenerator_ReportsDiagnosticAndGeneratesSingleProjectOutput()
    {
        var referenceAssemblies = LatestReferenceAssemblies.Net80.AddPackages([
            new PackageIdentity("System.Net.ServerSentEvents", "9.0.0")
        ]);
        var references = await referenceAssemblies.ResolveAsync(null, CancellationToken.None);
        var compilation = (Compilation)CSharpCompilation.Create(
            assemblyName: "SplitByTagsDiagnostics",
            syntaxTrees: [SyntaxFactory.ParseSyntaxTree("[assembly: System.CLSCompliantAttribute(true)]")],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        var additionalTexts = CreateDependencyInjectionAdditionalTexts();
        var additionalTextOptions = additionalTexts.ToDictionary(
            static text => text.Path,
            static _ => new Dictionary<string, string>
            {
                ["build_metadata.AdditionalFiles.AutoSDK_OpenApiSpecification"] = "true",
            });
        var driver = CSharpGeneratorDriver.Create(new SdkGenerator().AsSourceGenerator())
            .AddAdditionalTexts(additionalTexts.ToImmutableArray())
            .WithUpdatedAnalyzerConfigOptions(new DictionaryAnalyzerConfigOptionsProvider(
                globalOptions: CreateDependencyInjectionGlobalOptions(
                    ("build_property.AutoSDK_SplitByTags", "true")),
                additionalTextOptions: additionalTextOptions))
            .RunGeneratorsAndUpdateCompilation(compilation, out _, out _);

        var runResult = driver.GetRunResult();

        // A Roslyn generator cannot create the projects the mode needs, so it says so rather than
        // emitting half a package family.
        runResult.Diagnostics.Select(static x => x.Id).Should().Contain("OAG004");

        // And the code it does emit must be exactly the single-project shape: no widened runtime
        // members and no hoisted OAuth2 file.
        var generated = string.Join(
            "\n\n",
            runResult.Results.SelectMany(static x => x.GeneratedSources).Select(static x => x.SourceText.ToString()));
        generated.Should().NotContain("EditorBrowsableState.Never");

        runResult.Results
            .SelectMany(static x => x.GeneratedSources)
            .Select(static x => x.HintName)
            .Should()
            .NotContain(static x => x.Contains("AutoSDKOAuth2", StringComparison.Ordinal));
    }
}
