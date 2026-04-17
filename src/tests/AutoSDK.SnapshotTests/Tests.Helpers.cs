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
        IList<AdditionalText> additionalTexts,
        string callerName,
        Dictionary<string, string>? globalOptions = null,
        Dictionary<string, Dictionary<string, string>>? additionalTextOptions = null,
        IEnumerable<string>? supportSources = null,
        ReferenceAssemblies? referenceAssemblies = null,
        IEnumerable<PackageIdentity>? additionalPackages = null,
        CancellationToken cancellationToken = default,
        params IIncrementalGenerator[] additionalGenerators)
        where T : IIncrementalGenerator, new()
    {
        globalOptions ??= new Dictionary<string, string>();
        globalOptions.TryAdd("build_property.AutoSDK_Namespace", "G");
        globalOptions.TryAdd("build_property.AutoSDK_JsonSerializerType", $"{jsonSerializerType:G}");
        globalOptions.TryAdd("build_property.AutoSDK_GenerateJsonSerializerContextTypes", "true");
        globalOptions.TryAdd("build_property.TargetFramework", jsonSerializerType switch
        {
            JsonSerializerType.SystemTextJson => "net8.0",
            JsonSerializerType.NewtonsoftJson => "net6.0",
            _ => throw new ArgumentOutOfRangeException(nameof(jsonSerializerType), jsonSerializerType, null)
        });
        globalOptions.TryAdd("build_property.AutoSDK_UseExperimentalAttributes", jsonSerializerType switch
        {
            JsonSerializerType.SystemTextJson => "InSupportedTargetFrameworks",
            JsonSerializerType.NewtonsoftJson => "Never",
            _ => throw new ArgumentOutOfRangeException(nameof(jsonSerializerType), jsonSerializerType, null)
        });
        globalOptions.TryAdd("build_property.AutoSDK_UseSetsRequiredMembersAttributes", jsonSerializerType switch
        {
            JsonSerializerType.SystemTextJson => "InSupportedTargetFrameworks",
            JsonSerializerType.NewtonsoftJson => "Never",
            _ => throw new ArgumentOutOfRangeException(nameof(jsonSerializerType), jsonSerializerType, null)
        });

        referenceAssemblies ??= jsonSerializerType switch
        {
            JsonSerializerType.SystemTextJson => LatestReferenceAssemblies.Net80.AddPackages([
                new PackageIdentity("System.Net.ServerSentEvents", "9.0.0")
            ]),
            JsonSerializerType.NewtonsoftJson => ReferenceAssemblies.Net.Net60.AddPackages([
                new PackageIdentity("Newtonsoft.Json", "13.0.3"),
                new PackageIdentity("System.Net.ServerSentEvents", "9.0.0")
            ]),
            _ => throw new ArgumentOutOfRangeException(nameof(jsonSerializerType), jsonSerializerType, null)
        };
        if (additionalPackages is not null)
        {
            referenceAssemblies = referenceAssemblies.AddPackages([.. additionalPackages]);
        }
        var references = await referenceAssemblies.ResolveAsync(null, cancellationToken);
        var trees = new List<SyntaxTree>
        {
            SyntaxFactory.ParseSyntaxTree("[assembly: System.CLSCompliantAttribute(true)]"),
        };
        if (supportSources is not null)
        {
            trees.AddRange(supportSources.Select(x => SyntaxFactory.ParseSyntaxTree(x)));
        }
        if (jsonSerializerType is JsonSerializerType.SystemTextJson)
        {
            foreach (var additionalText in additionalTexts)
            {
                var options =
                    additionalTextOptions != null &&
                    additionalTextOptions.TryGetValue(additionalText.Path, out var existingOptions)
                    ? existingOptions
                    : new Dictionary<string, string>();
                var @namespace = options.TryGetValue("build_metadata.AdditionalFiles.AutoSDK_Namespace", out var namespaceValue)
                    ? namespaceValue
                    : "G";
                var contextInfo = GetJsonSerializerContextInfo(@namespace, globalOptions);
                trees.Add(CreateJsonSerializerContextTree(
                    contextNamespace: contextInfo.ContextNamespace,
                    contextClassName: contextInfo.ContextClassName,
                    typesNamespace: contextInfo.TypesNamespace));
            }
        }

        additionalTextOptions ??= new Dictionary<string, Dictionary<string, string>>();
        foreach (var additionalText in additionalTexts)
        {
            var options = additionalTextOptions.TryGetValue(additionalText.Path, out var existingOptions)
                ? existingOptions
                : new Dictionary<string, string>();
            options.TryAdd("build_metadata.AdditionalFiles.AutoSDK_OpenApiSpecification", "true");
            additionalTextOptions[additionalText.Path] = options;
        }
        
        var compilation = (Compilation)CSharpCompilation.Create(
            assemblyName: "Tests",
            syntaxTrees: [..trees],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        var generator = new T();
        var driver = CSharpGeneratorDriver.Create(
            generators: new IIncrementalGenerator[] { generator }
                .Concat(additionalGenerators)
                .Select(GeneratorExtensions.AsSourceGenerator)
                .ToArray())
            .AddAdditionalTexts([..additionalTexts])
            .WithUpdatedAnalyzerConfigOptions(new DictionaryAnalyzerConfigOptionsProvider(globalOptions, additionalTextOptions: additionalTextOptions))
            .RunGeneratorsAndUpdateCompilation(compilation, out compilation, out _, cancellationToken);
        var diagnostics = compilation.GetDiagnostics(cancellationToken)
            .Where(x => x.Id is not ("CS0618" or "CS1701" or "CS1702"))
            .Where(x => x.Severity != DiagnosticSeverity.Hidden)
            .OrderBy(x => x.Location.GetLineSpan().Path)
            .ThenBy(x => x.Location.GetLineSpan().StartLinePosition.Line)
            .ThenBy(x => x.Id)
            .ToImmutableArray();

        await Task.WhenAll(
            VerifyNoDiagnosticsAsync(
                diagnostics: diagnostics,
                directory: $"Snapshots/{callerName}/{jsonSerializerType:G}"),
            Verify(driver)
                .UseDirectory($"Snapshots/{callerName}/{jsonSerializerType:G}")
                .UseFileName("_")
                .AutoVerify()
                );
    }
    
    private async Task CheckCliSourceAsync<T>(
        IList<AdditionalText> additionalTexts,
        string callerName,
        Dictionary<string, string>? globalOptions = null,
        Dictionary<string, Dictionary<string, string>>? additionalTextOptions = null,
        IEnumerable<string>? supportSources = null,
        CancellationToken cancellationToken = default,
        params IIncrementalGenerator[] additionalGenerators)
        where T : IIncrementalGenerator, new()
    {
        globalOptions ??= new Dictionary<string, string>();
        globalOptions.TryAdd("build_property.AutoSDK_Namespace", "G");
        globalOptions.TryAdd("build_property.AutoSDK_JsonSerializerType", "SystemTextJson");
        globalOptions.TryAdd("build_property.AutoSDK_GenerateJsonSerializerContextTypes", "true");
        globalOptions.TryAdd("build_property.TargetFramework",  "net8.0");
        globalOptions.TryAdd("build_property.AutoSDK_UseExperimentalAttributes", "InSupportedTargetFrameworks");
        globalOptions.TryAdd("build_property.AutoSDK_UseSetsRequiredMembersAttributes", "InSupportedTargetFrameworks");
        globalOptions.TryAdd("build_property.AutoSDK_GenerateModels", "true");
        globalOptions.TryAdd("build_property.AutoSDK_GenerateCli", "true");

        var referenceAssemblies = LatestReferenceAssemblies.Net80.AddPackages([
            new PackageIdentity("System.CommandLine", "2.0.0-beta5.25306.1"),
            new PackageIdentity("Microsoft.Extensions.DependencyInjection", "9.0.6"),
            new PackageIdentity("System.Net.ServerSentEvents", "9.0.0")
        ]);
        var references = await referenceAssemblies.ResolveAsync(null, cancellationToken);
        var trees = new List<SyntaxTree>
        {
            SyntaxFactory.ParseSyntaxTree("[assembly: System.CLSCompliantAttribute(true)]"),
        };
        if (supportSources is not null)
        {
            trees.AddRange(supportSources.Select(x => SyntaxFactory.ParseSyntaxTree(x)));
        }

        additionalTextOptions ??= new Dictionary<string, Dictionary<string, string>>();
        foreach (var additionalText in additionalTexts)
        {
            var options = additionalTextOptions.TryGetValue(additionalText.Path, out var existingOptions)
                ? existingOptions
                : new Dictionary<string, string>();
            options.TryAdd("build_metadata.AdditionalFiles.AutoSDK_OpenApiSpecification", "true");
            additionalTextOptions[additionalText.Path] = options;
        }
        
        var compilation = (Compilation)CSharpCompilation.Create(
            assemblyName: "Tests",
            syntaxTrees: [..trees],
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        var generator = new T();
        var driver = CSharpGeneratorDriver.Create(
            generators: new IIncrementalGenerator[] { generator }
                .Concat(additionalGenerators)
                .Select(GeneratorExtensions.AsSourceGenerator)
                .ToArray())
            .AddAdditionalTexts([..additionalTexts])
            .WithUpdatedAnalyzerConfigOptions(new DictionaryAnalyzerConfigOptionsProvider(globalOptions, additionalTextOptions: additionalTextOptions))
            .RunGeneratorsAndUpdateCompilation(compilation, out compilation, out _, cancellationToken);
        var diagnostics = compilation.GetDiagnostics(cancellationToken)
            .Where(x => x.Id is not ("CS0618" or "CS1701" or "CS1702"))
            .Where(x => x.Severity != DiagnosticSeverity.Hidden)
            .OrderBy(x => x.Location.GetLineSpan().Path)
            .ThenBy(x => x.Location.GetLineSpan().StartLinePosition.Line)
            .ThenBy(x => x.Id)
            .ToImmutableArray();

        await Task.WhenAll(
            VerifyNoDiagnosticsAsync(
                diagnostics: diagnostics,
                directory: $"Snapshots/CLI/{callerName}"),
            Verify(driver)
                .UseDirectory($"Snapshots/CLI/{callerName}")
                .UseFileName("_")
                .AutoVerify()
                );
    }

    private Task VerifyNoDiagnosticsAsync(
        ImmutableArray<Diagnostic> diagnostics,
        string directory)
    {
        diagnostics.Should().BeEmpty(
            "generated code must compile without diagnostics. Found:{0}{1}",
            Environment.NewLine,
            string.Join(
                Environment.NewLine + Environment.NewLine,
                diagnostics.NormalizeLocations().Select(x => x.ToString())));

        return Verify("[]")
            .UseDirectory(directory)
            .UseTextForParameters("Diagnostics");
    }

    private static (string ContextNamespace, string ContextClassName, string TypesNamespace) GetJsonSerializerContextInfo(
        string defaultNamespace,
        IReadOnlyDictionary<string, string> globalOptions)
    {
        globalOptions.TryGetValue("build_property.AutoSDK_TypesNamespace", out var typesNamespace);
        typesNamespace = string.IsNullOrWhiteSpace(typesNamespace) ? defaultNamespace : typesNamespace;

        globalOptions.TryGetValue("build_property.AutoSDK_JsonSerializerContext", out var jsonSerializerContext);
        if (string.IsNullOrWhiteSpace(jsonSerializerContext))
        {
            return (defaultNamespace, "SourceGenerationContext", typesNamespace);
        }

        var lastDotIndex = jsonSerializerContext.LastIndexOf('.');
        return lastDotIndex > 0
            ? (
                ContextNamespace: jsonSerializerContext[..lastDotIndex],
                ContextClassName: jsonSerializerContext[(lastDotIndex + 1)..],
                TypesNamespace: typesNamespace)
            : (
                ContextNamespace: defaultNamespace,
                ContextClassName: jsonSerializerContext,
                TypesNamespace: typesNamespace);
    }

    private static SyntaxTree CreateJsonSerializerContextTree(
        string contextNamespace,
        string contextClassName,
        string typesNamespace)
    {
        return SyntaxFactory.ParseSyntaxTree($@"#nullable enable

namespace {contextNamespace}
{{
    public sealed partial class {contextClassName} : global::System.Text.Json.Serialization.JsonSerializerContext
    {{
        public static global::{contextNamespace}.{contextClassName} Default {{ get; }} = new global::{contextNamespace}.{contextClassName}(new global::System.Text.Json.JsonSerializerOptions());
        
        /// <summary>
        /// The source-generated options associated with this context.
        /// </summary>
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions {{ get; }}
        
        /// <inheritdoc/>
        public {contextClassName}(global::System.Text.Json.JsonSerializerOptions options) : base(options)
        {{
        }}

        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {{
            return null;
        }}
    }}
}}
");
    }
}
