using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using H.Generators.Tests.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Testing;
using OpenApiGenerator;

namespace OpenApiGenerator.SnapshotTests;

[TestClass]
public partial class Tests : VerifyBase
{
    private async Task CheckSourceAsync<T>(
        AdditionalText[] additionalTexts,
        Dictionary<string, string>? globalOptions = null,
        [CallerMemberName] string? callerName = null,
        CancellationToken cancellationToken = default,
        params IIncrementalGenerator[] additionalGenerators)
        where T : IIncrementalGenerator, new()
    {
        globalOptions ??= new Dictionary<string, string>();
        globalOptions.Add("build_property.OpenApiGenerator_Namespace", "G");
        
        var referenceAssemblies = LatestReferenceAssemblies.Net80;
        var references = await referenceAssemblies.ResolveAsync(null, cancellationToken);
        var compilation = (Compilation)CSharpCompilation.Create(
            assemblyName: "Tests",
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        var generator = new T();
        var driver = CSharpGeneratorDriver.Create(
            generators: new IIncrementalGenerator[] { generator }
                .Concat(additionalGenerators)
                .Select(GeneratorExtensions.AsSourceGenerator)
                .ToArray())
            .AddAdditionalTexts(ImmutableArray.Create(additionalTexts))
            .WithUpdatedAnalyzerConfigOptions(new DictionaryAnalyzerConfigOptionsProvider(globalOptions))
            .RunGeneratorsAndUpdateCompilation(compilation, out compilation, out _, cancellationToken);
        var diagnostics = compilation.GetDiagnostics(cancellationToken);

        await Task.WhenAll(
            Verify(diagnostics.NormalizeLocations())
                .UseDirectory($"Snapshots/{callerName}")
                //.AutoVerify()
                .UseTextForParameters("Diagnostics"),
            Verify(driver)
                .UseDirectory($"Snapshots/{callerName}")
                .UseFileName("_")
                //.AutoVerify()
                );
    }
}