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
    public async Task SdkGenerator_MethodsProject_EmitsRequiredSupportSources()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: TwoProjectSupportRepro
                              version: 1.0.0
                            paths:
                              /pets/{petId}:
                                post:
                                  operationId: createPet
                                  parameters:
                                    - in: path
                                      name: petId
                                      required: true
                                      schema:
                                        type: string
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          $ref: '#/components/schemas/Pet'
                                  responses:
                                    '204':
                                      description: No content
                            components:
                              schemas:
                                Pet:
                                  type: object
                                  properties:
                                    name:
                                      type: string
                            """;

        var globalOptions = new Dictionary<string, string>
        {
            ["build_property.AutoSDK_Namespace"] = "G",
            ["build_property.AutoSDK_ClassName"] = "Api",
            ["build_property.AutoSDK_JsonSerializerType"] = "SystemTextJson",
            ["build_property.AutoSDK_GenerateSdk"] = "false",
            ["build_property.AutoSDK_GenerateModels"] = "false",
            ["build_property.AutoSDK_GenerateMethods"] = "true",
            ["build_property.AutoSDK_GenerateConstructors"] = "true",
            ["build_property.AutoSDK_GenerateJsonSerializerContextTypes"] = "false",
            ["build_property.AutoSDK_GenerateMethodsUsingSystemNetHttpJson"] = "true",
            ["build_property.AutoSDK_UseExperimentalAttributes"] = "InSupportedTargetFrameworks",
            ["build_property.AutoSDK_UseSetsRequiredMembersAttributes"] = "InSupportedTargetFrameworks",
            ["build_property.TargetFramework"] = "net8.0",
        };
        var additionalText = new CustomAdditionalText(
            path: "two-project-support.yaml",
            text: yaml);
        var additionalTextOptions = new Dictionary<string, Dictionary<string, string>>
        {
            [additionalText.Path] = new()
            {
                ["build_metadata.AdditionalFiles.AutoSDK_OpenApiSpecification"] = "true",
            },
        };

        var referenceAssemblies = LatestReferenceAssemblies.Net80.AddPackages([
            new PackageIdentity("System.Net.ServerSentEvents", "9.0.0"),
        ]);
        var references = await referenceAssemblies.ResolveAsync(null, CancellationToken.None);
        Compilation compilation = CSharpCompilation.Create(
            assemblyName: "Tests",
            syntaxTrees:
            [
                SyntaxFactory.ParseSyntaxTree("[assembly: System.CLSCompliantAttribute(true)]"),
                SyntaxFactory.ParseSyntaxTree(
                    """
                    #nullable enable

                    namespace G
                    {
                        public sealed partial class Pet
                        {
                            public string? Name { get; set; }
                        }
                    }
                    """),
            ],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        var driver = CSharpGeneratorDriver.Create(
                generators:
                [
                    GeneratorExtensions.AsSourceGenerator(new SdkGenerator()),
                ])
            .AddAdditionalTexts([additionalText])
            .WithUpdatedAnalyzerConfigOptions(
                new DictionaryAnalyzerConfigOptionsProvider(
                    globalOptions,
                    additionalTextOptions: additionalTextOptions))
            .RunGeneratorsAndUpdateCompilation(
                compilation,
                out compilation,
                out _,
                CancellationToken.None);

        var diagnostics = compilation.GetDiagnostics(CancellationToken.None)
            .Where(x => x.Id != "CS0618")
            .ToArray();
        var generatedSources = driver.GetRunResult()
            .Results
            .SelectMany(x => x.GeneratedSources)
            .Select(x => x.HintName)
            .ToArray();

        diagnostics.Should().BeEmpty(
            "methods-only generation should compile cleanly. Found:{0}{1}",
            Environment.NewLine,
            string.Join(Environment.NewLine + Environment.NewLine, diagnostics.Select(x => x.ToString())));
        generatedSources.Should().Contain("G.Polyfills.g.cs");
        generatedSources.Should().Contain("G.Exceptions.g.cs");
        generatedSources.Should().Contain("G.PathBuilder.g.cs");
        generatedSources.Should().Contain("G.OptionsSupport.g.cs");
        generatedSources.Should().Contain("G.JsonConverters.UnixTimestamp.g.cs");
    }
}
