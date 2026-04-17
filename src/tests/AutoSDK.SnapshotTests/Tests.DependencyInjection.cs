using System.Collections.Immutable;
using AutoSDK.SourceGenerators;
using AutoSDK.Serialization.Json;
using H.Generators.Extensions;
using H.Generators.Tests.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Testing;

namespace AutoSDK.SnapshotTests;

public partial class Tests
{
    private static readonly PackageIdentity MicrosoftExtensionsHttpPackage = new("Microsoft.Extensions.Http", "10.0.6");
    private static readonly PackageIdentity MicrosoftExtensionsOptionsConfigurationPackage = new("Microsoft.Extensions.Options.ConfigurationExtensions", "10.0.6");
    private static readonly PackageIdentity MicrosoftExtensionsHttpResiliencePackage = new("Microsoft.Extensions.Http.Resilience", "10.5.0");
    private static readonly PackageIdentity SystemTextJsonPackage = new("System.Text.Json", "10.0.0");

    [TestMethod]
    public Task DependencyInjectionBaseline()
    {
        return CheckDependencyInjectionSnapshotAsync(
            callerName: nameof(DependencyInjectionBaseline),
            globalOptions: CreateDependencyInjectionGlobalOptions());
    }

    [TestMethod]
    public Task DependencyInjectionOnly()
    {
        return CheckDependencyInjectionSnapshotAsync(
            callerName: nameof(DependencyInjectionOnly),
            globalOptions: CreateDependencyInjectionGlobalOptions(
                ("build_property.AutoSDK_GenerateDependencyInjection", "true")),
            additionalPackages: [MicrosoftExtensionsHttpPackage]);
    }

    [TestMethod]
    public Task DependencyInjectionWithConfigurationBinding_Net80()
    {
        return CheckDependencyInjectionSnapshotAsync(
            callerName: nameof(DependencyInjectionWithConfigurationBinding_Net80),
            globalOptions: CreateDependencyInjectionGlobalOptions(
                ("build_property.AutoSDK_GenerateDependencyInjection", "true"),
                ("build_property.AutoSDK_GenerateConfigurationBinding", "true")),
            additionalPackages:
            [
                MicrosoftExtensionsHttpPackage,
                MicrosoftExtensionsOptionsConfigurationPackage,
            ]);
    }

    [TestMethod]
    public Task HttpResilienceOnly()
    {
        return CheckDependencyInjectionSnapshotAsync(
            callerName: nameof(HttpResilienceOnly),
            globalOptions: CreateDependencyInjectionGlobalOptions(
                ("build_property.AutoSDK_GenerateHttpResilienceExtensions", "true")),
            additionalPackages: [MicrosoftExtensionsHttpResiliencePackage]);
    }

    [TestMethod]
    public Task DependencyInjectionWithConfigurationBindingAndResilience_Net80()
    {
        return CheckDependencyInjectionSnapshotAsync(
            callerName: nameof(DependencyInjectionWithConfigurationBindingAndResilience_Net80),
            globalOptions: CreateDependencyInjectionGlobalOptions(
                ("build_property.AutoSDK_GenerateDependencyInjection", "true"),
                ("build_property.AutoSDK_GenerateConfigurationBinding", "true"),
                ("build_property.AutoSDK_GenerateHttpResilienceExtensions", "true")),
            additionalPackages:
            [
                MicrosoftExtensionsHttpPackage,
                MicrosoftExtensionsOptionsConfigurationPackage,
                MicrosoftExtensionsHttpResiliencePackage,
            ]);
    }

    [TestMethod]
    public Task DependencyInjectionWithConfigurationBinding_Netstandard20()
    {
        return CheckDependencyInjectionSnapshotAsync(
            callerName: nameof(DependencyInjectionWithConfigurationBinding_Netstandard20),
            globalOptions: CreateDependencyInjectionGlobalOptions(
                ("build_property.TargetFramework", "netstandard2.0"),
                ("build_property.AutoSDK_GenerateDependencyInjection", "true"),
                ("build_property.AutoSDK_GenerateConfigurationBinding", "true")),
            referenceAssemblies: ReferenceAssemblies.NetStandard.NetStandard20,
            additionalPackages:
            [
                SystemTextJsonPackage,
                MicrosoftExtensionsHttpPackage,
                MicrosoftExtensionsOptionsConfigurationPackage,
            ]);
    }

    [TestMethod]
    public void GetSettings_ParsesMicrosoftExtensionsFlags()
    {
        var settings = new DictionaryAnalyzerConfigOptionsProvider(new Dictionary<string, string>
        {
            ["build_property.AutoSDK_GenerateDependencyInjection"] = "true",
            ["build_property.AutoSDK_GenerateConfigurationBinding"] = "true",
            ["build_property.AutoSDK_GenerateHttpResilienceExtensions"] = "true",
        }).GetSettings(prefix: "AutoSDK");

        settings.GenerateDependencyInjection.Should().BeTrue();
        settings.GenerateConfigurationBinding.Should().BeTrue();
        settings.GenerateHttpResilienceExtensions.Should().BeTrue();
    }

    [TestMethod]
    public async Task GenerateConfigurationBindingWithoutDependencyInjection_ReportsDiagnostic()
    {
        var referenceAssemblies = LatestReferenceAssemblies.Net80.AddPackages([
            new PackageIdentity("System.Net.ServerSentEvents", "9.0.0")
        ]);
        var references = await referenceAssemblies.ResolveAsync(null, CancellationToken.None);
        var compilation = (Compilation)CSharpCompilation.Create(
            assemblyName: "DependencyInjectionDiagnostics",
            syntaxTrees: [SyntaxFactory.ParseSyntaxTree("[assembly: System.CLSCompliantAttribute(true)]")],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        var generator = new SdkGenerator();
        var additionalTexts = CreateDependencyInjectionAdditionalTexts();
        var additionalTextOptions = additionalTexts.ToDictionary(
            static text => text.Path,
            static _ => new Dictionary<string, string>
            {
                ["build_metadata.AdditionalFiles.AutoSDK_OpenApiSpecification"] = "true",
            });
        var driver = CSharpGeneratorDriver.Create(generator.AsSourceGenerator())
            .AddAdditionalTexts(additionalTexts.ToImmutableArray())
            .WithUpdatedAnalyzerConfigOptions(new DictionaryAnalyzerConfigOptionsProvider(
                globalOptions: CreateDependencyInjectionGlobalOptions(
                    ("build_property.AutoSDK_GenerateConfigurationBinding", "true")),
                additionalTextOptions: additionalTextOptions))
            .RunGeneratorsAndUpdateCompilation(compilation, out _, out _);

        driver.GetRunResult()
            .Diagnostics
            .Select(static x => x.Id)
            .Should()
            .Contain("OAG002");
    }

    private Task CheckDependencyInjectionSnapshotAsync(
        string callerName,
        Dictionary<string, string> globalOptions,
        ReferenceAssemblies? referenceAssemblies = null,
        IEnumerable<PackageIdentity>? additionalPackages = null)
    {
        return CheckSourceAsync<SdkGenerator>(
            jsonSerializerType: JsonSerializerType.SystemTextJson,
            additionalTexts: CreateDependencyInjectionAdditionalTexts(),
            callerName: callerName,
            globalOptions: globalOptions,
            referenceAssemblies: referenceAssemblies,
            additionalPackages: additionalPackages);
    }

    private static List<AdditionalText> CreateDependencyInjectionAdditionalTexts()
    {
        return
        [
            new CustomAdditionalText(
                path: "dependency-injection.yaml",
                text: """
                      openapi: 3.0.3
                      info:
                        title: DependencyInjection
                        version: 1.0.0
                      servers:
                        - url: https://api.example.com
                      paths:
                        /charges:
                          get:
                            operationId: listCharges
                            responses:
                              '200':
                                description: OK
                                content:
                                  application/json:
                                    schema:
                                      type: object
                                      properties:
                                        id:
                                          type: string
                      """)
        ];
    }

    private static Dictionary<string, string> CreateDependencyInjectionGlobalOptions(
        params (string Key, string Value)[] overrides)
    {
        var options = new Dictionary<string, string>
        {
            ["build_property.AutoSDK_Namespace"] = "IXSocial",
            ["build_property.AutoSDK_ClassName"] = "IXSocialClient",
        };

        foreach (var (key, value) in overrides)
        {
            options[key] = value;
        }

        return options;
    }
}
