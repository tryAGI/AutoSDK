using AutoSDK.GeneratorTests.Helpers;
using AutoSDK.Models;
using AutoSDK.SourceGenerators;
using FluentAssertions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;

namespace AutoSDK.GeneratorTests;

[TestClass]
public partial class GenerationTests
{
    [TestMethod]
    public async Task ExcludeModelsAsync()
    {
        var compilation = CSharpCompilation.Create(
            "compilation",
            [
                    SyntaxFactory.ParseSyntaxTree("[assembly: System.CLSCompliantAttribute(true)]"),
                ],
                await H.Generators.Tests.Extensions.LatestReferenceAssemblies.Net90.ResolveAsync(null, CancellationToken.None),
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        var openApiSpec = new CustomAdditionalText(
        "petstore.yaml",
        new H.Resource("petstore.yaml").AsString());
        openApiSpec.Options.Add("OpenApiSpecification", "true");
        var additionalFiles = new[] { openApiSpec }.ToImmutableArray<AdditionalText>();
        var optionsProvider = new AdditionalTextOptionsProvider(new()
        {
            [nameof(Settings.ExcludeModels)] = "Pet;",
            [nameof(Settings.Namespace)] = "TestNamespace",
            [nameof(Settings.ClassName)] = "PetClient",
        });

        var driver = CSharpGeneratorDriver.Create(
             new IIncrementalGenerator[] { new SdkGenerator() }
                .Select(GeneratorExtensions.AsSourceGenerator)
                .ToArray())
            .AddAdditionalTexts(additionalFiles);
        driver = driver.WithUpdatedAnalyzerConfigOptions(optionsProvider);

        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics);
        var generatedClasses = outputCompilation.SyntaxTrees
            .SelectMany(x => x.GetRoot().DescendantNodes())
            .OfType<NamespaceDeclarationSyntax>()
            .SelectMany(x => x.Members.OfType<ClassDeclarationSyntax>())
            .ToArray();
        generatedClasses.Where(c => c.Identifier.Text == "Pet").Should().BeEmpty();
    }
}
