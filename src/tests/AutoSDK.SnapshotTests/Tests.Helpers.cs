using System.Collections.Immutable;
using H.Generators.Tests.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Testing;
using AutoSDK.Serialization.Json;

namespace AutoSDK.SnapshotTests;

[TestClass]
public partial class Tests : VerifyBase
{
    private async Task CheckSourceAsync<T>(
        JsonSerializerType jsonSerializerType,
        AdditionalText[] additionalTexts,
        string callerName,
        Dictionary<string, string>? globalOptions = null,
        CancellationToken cancellationToken = default,
        params IIncrementalGenerator[] additionalGenerators)
        where T : IIncrementalGenerator, new()
    {
        globalOptions ??= new Dictionary<string, string>();
        globalOptions.TryAdd("build_property.AutoSDK_Namespace", "G");
        globalOptions.TryAdd("build_property.AutoSDK_JsonSerializerType", $"{jsonSerializerType:G}");
        globalOptions.TryAdd("build_property.TargetFramework", jsonSerializerType switch
        {
            JsonSerializerType.SystemTextJson => "net8.0",
            JsonSerializerType.NewtonsoftJson => "net6.0",
            _ => throw new ArgumentOutOfRangeException(nameof(jsonSerializerType), jsonSerializerType, null)
        });

        var referenceAssemblies = jsonSerializerType switch
        {
            JsonSerializerType.SystemTextJson => LatestReferenceAssemblies.Net80,
            JsonSerializerType.NewtonsoftJson => ReferenceAssemblies.Net.Net60.AddPackages([
                new PackageIdentity("Newtonsoft.Json", "13.0.3")
            ]),
            _ => throw new ArgumentOutOfRangeException(nameof(jsonSerializerType), jsonSerializerType, null)
        };
        var references = await referenceAssemblies.ResolveAsync(null, cancellationToken);
        var compilation = (Compilation)CSharpCompilation.Create(
            assemblyName: "Tests",
            syntaxTrees: ImmutableArray.Create(SyntaxFactory.ParseSyntaxTree(@"
[assembly: System.CLSCompliantAttribute(true)]
")),
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
        var diagnostics = compilation.GetDiagnostics(cancellationToken)
            .Where(x => x.Id != "CS0618")
            .ToImmutableArray();

        await Task.WhenAll(
            Verify(diagnostics.NormalizeLocations())
                .UseDirectory($"Snapshots/{callerName}/{jsonSerializerType:G}")
                //.AutoVerify()
                .UseTextForParameters("Diagnostics"),
            Verify(driver)
                .UseDirectory($"Snapshots/{callerName}/{jsonSerializerType:G}")
                .UseFileName("_")
                //.AutoVerify()
                );
    }
}