using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using H.Generators.Tests.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Testing;

namespace H.Generators.IntegrationTests;

[TestClass]
public partial class Tests : VerifyBase
{
    private async Task CheckSourceAsync(
        AdditionalText[] additionalTexts,
        [CallerMemberName] string? callerName = null,
        CancellationToken cancellationToken = default)
    {
        var referenceAssemblies = ReferenceAssemblies.Net.Net60
            .WithPackages(ImmutableArray.Create(new PackageIdentity("Newtonsoft.Json", "13.0.1")));
        var references = await referenceAssemblies.ResolveAsync(null, cancellationToken);
        var compilation = (Compilation)CSharpCompilation.Create(
            assemblyName: "Tests",
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        var generator = new NSwagGenerator();
        var driver = CSharpGeneratorDriver
            .Create(generator)
            .AddAdditionalTexts(ImmutableArray.Create(additionalTexts))
            .RunGeneratorsAndUpdateCompilation(compilation, out compilation, out _, cancellationToken);
        var diagnostics = compilation.GetDiagnostics(cancellationToken);

        await Task.WhenAll(
            Verify(diagnostics.NormalizeLocations())
                .UseDirectory($"Snapshots/{callerName}")
                .AutoVerify()
                .UseTextForParameters($"Diagnostics"),
            Verify(driver)
                .UseDirectory($"Snapshots/{callerName}")
                .AutoVerify()
                );
    }
}