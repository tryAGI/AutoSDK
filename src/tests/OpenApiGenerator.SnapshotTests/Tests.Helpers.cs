using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using H.Generators.Tests.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Testing;
using OpenApiGenerator;

namespace H.Generators.IntegrationTests;

[TestClass]
public partial class Tests : VerifyBase
{
    private async Task CheckSourceAsync<T>(
        AdditionalText[] additionalTexts,
        Dictionary<string, string>? globalOptions = null,
        [CallerMemberName] string? callerName = null,
        CancellationToken cancellationToken = default)
        where T : IIncrementalGenerator, new()
    {
        globalOptions ??= new Dictionary<string, string>();
        globalOptions.Add("build_property.OpenApiGenerator_Namespace", "G");
        
        var referenceAssemblies = ReferenceAssemblies.Net.Net60
            .WithPackages(ImmutableArray.Create(new PackageIdentity("Newtonsoft.Json", "13.0.1")));
        var references = await referenceAssemblies.ResolveAsync(null, cancellationToken);
        var compilation = (Compilation)CSharpCompilation.Create(
            assemblyName: "Tests",
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        var generator = new T();
        var driver = CSharpGeneratorDriver
            .Create(generator)
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