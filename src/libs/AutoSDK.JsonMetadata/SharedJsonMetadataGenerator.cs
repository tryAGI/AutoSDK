using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace AutoSDK.JsonMetadata;

/// <summary>
/// Generates metadata once with the pinned official STJ generator, exposing independent static
/// factories instead of an aggregate context whose virtual resolver roots every registered type.
/// </summary>
[Generator]
public sealed class SharedJsonMetadataGenerator : IIncrementalGenerator
{
    private static readonly DiagnosticDescriptor IncompatibleOutput = new(
        "AMETA001", "Shared JSON metadata generation failed",
        "{0}", "AutoSDK.JsonMetadata", DiagnosticSeverity.Error, isEnabledByDefault: true);

    /// <inheritdoc />
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var manifests = context.AdditionalTextsProvider
            .Where(static file => file.Path.EndsWith(".autosdk-json-metadata", StringComparison.Ordinal))
            .Select(static (file, token) => file.GetText(token))
            .Collect();
        context.RegisterSourceOutput(context.CompilationProvider.Combine(manifests),
            static (output, input) => Generate(output, input.Left, input.Right));
    }

    private static void Generate(SourceProductionContext output, Compilation compilation,
        ImmutableArray<SourceText?> manifests)
    {
        if (manifests.IsEmpty)
        {
            return;
        }
        if (compilation is not CSharpCompilation csharp)
        {
            output.ReportDiagnostic(Diagnostic.Create(IncompatibleOutput, Location.None,
                "Shared JSON metadata requires a C# compilation."));
            return;
        }
        var parseOptions = csharp.SyntaxTrees.FirstOrDefault()?.Options as CSharpParseOptions
            ?? CSharpParseOptions.Default;
        var sources = new List<SyntaxTree>(manifests.Length);
        for (var index = 0; index < manifests.Length; index++)
        {
            if (manifests[index] is not { } text)
            {
                output.ReportDiagnostic(Diagnostic.Create(IncompatibleOutput, Location.None,
                    "A shared JSON metadata manifest could not be read."));
                return;
            }
            sources.Add(CSharpSyntaxTree.ParseText(text, parseOptions,
                path: "AutoSDK.SharedMetadata.Manifest" + index.ToString(System.Globalization.CultureInfo.InvariantCulture) + ".cs",
                cancellationToken: output.CancellationToken));
        }

        var contextNames = new HashSet<string>(sources.SelectMany(tree =>
                tree.GetRoot(output.CancellationToken).DescendantNodes().OfType<ClassDeclarationSyntax>())
            .Select(static declaration => declaration.Identifier.ValueText), StringComparer.Ordinal);

        // This compiler-only dependency never becomes an SDK runtime reference. The CLI remains
        // independent of Roslyn and retains its managed/native generation paths.
        GeneratorDriver driver = CSharpGeneratorDriver.Create(
            generators: [new System.Text.Json.SourceGeneration.JsonSourceGenerator().AsSourceGenerator()],
            parseOptions: parseOptions);
        var augmented = csharp.AddSyntaxTrees(sources);
        driver = driver.RunGenerators(augmented, output.CancellationToken);
        var result = driver.GetRunResult();
        foreach (var diagnostic in result.Diagnostics)
        {
            if (diagnostic.Severity == DiagnosticSeverity.Error)
            {
                output.ReportDiagnostic(Diagnostic.Create(IncompatibleOutput, Location.None,
                    diagnostic.ToString()));
                return;
            }
        }

        if (!result.Results.SelectMany(static generator => generator.GeneratedSources).Any())
        {
            output.ReportDiagnostic(Diagnostic.Create(IncompatibleOutput, Location.None,
                "The pinned STJ generator produced no metadata for the supplied manifests. " +
                string.Join(" | ", augmented.GetDiagnostics(output.CancellationToken)
                    .Where(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
                    .Take(5).Select(static diagnostic => diagnostic.ToString()))));
            return;
        }
        foreach (var generator in result.Results)
        {
            foreach (var source in generator.GeneratedSources)
            {
                var separator = source.HintName.IndexOf('.');
                if (separator < 0 || !contextNames.Contains(source.HintName.Substring(0, separator)))
                {
                    continue;
                }
                // Aggregate dispatch, Default and bound context constructors are deliberately
                // absent. Only factories explicitly referenced by a scope survive IL linking.
                if (source.HintName.EndsWith(".GetJsonTypeInfo.g.cs", StringComparison.Ordinal))
                {
                    continue;
                }
                var root = source.SyntaxTree.GetRoot(output.CancellationToken);
                var transformed = new FactoryRewriter().Visit(root);
                if (transformed is null)
                {
                    output.ReportDiagnostic(Diagnostic.Create(IncompatibleOutput, Location.None,
                        "The pinned STJ generator emitted an unsupported source shape."));
                    return;
                }
                if (transformed.DescendantNodes().OfType<ThisExpressionSyntax>().Any())
                {
                    output.ReportDiagnostic(Diagnostic.Create(IncompatibleOutput, Location.None,
                        "The pinned STJ generator emitted an unexpected instance-dependent metadata factory: " + source.HintName));
                    return;
                }
                output.AddSource("AutoSDK.SharedMetadata." + source.HintName,
                    SourceText.From(transformed.ToFullString(), Encoding.UTF8));
            }
        }
    }

    private sealed class FactoryRewriter : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var members = new List<MemberDeclarationSyntax>();
            foreach (var member in node.Members)
            {
                if (member is FieldDeclarationSyntax field)
                {
                    // The official metadata emitter uses this constant for lazy attribute
                    // providers. Default options, per-instance caches and fast-path names do not
                    // belong to a shared factory holder.
                    if (field.Modifiers.Any(SyntaxKind.ConstKeyword))
                    {
                        members.Add(field);
                    }
                    continue;
                }
                if (member is not MethodDeclarationSyntax method)
                {
                    continue;
                }
                if (method.Identifier.ValueText.StartsWith("Create_", StringComparison.Ordinal))
                {
                    var leadingTrivia = method.GetLeadingTrivia();
                    method = method.WithModifiers(SyntaxFactory.TokenList(
                        SyntaxFactory.Token(SyntaxKind.InternalKeyword).WithTrailingTrivia(SyntaxFactory.Space),
                        SyntaxFactory.Token(SyntaxKind.StaticKeyword).WithTrailingTrivia(SyntaxFactory.Space)))
                        .WithLeadingTrivia(leadingTrivia);
                }
                else if (!method.Modifiers.Any(SyntaxKind.StaticKeyword))
                {
                    // Metadata mode has static property/constructor initializers and converter
                    // helpers. An instance writer indicates a generator/configuration change.
                    return node;
                }
                members.Add((MemberDeclarationSyntax)Visit(method));
            }
            return node.WithAttributeLists(default).WithBaseList(null)
                .WithModifiers(SyntaxFactory.TokenList(
                    SyntaxFactory.Token(SyntaxKind.InternalKeyword).WithTrailingTrivia(SyntaxFactory.Space),
                    SyntaxFactory.Token(SyntaxKind.StaticKeyword).WithTrailingTrivia(SyntaxFactory.Space),
                    SyntaxFactory.Token(SyntaxKind.PartialKeyword).WithTrailingTrivia(SyntaxFactory.Space)))
                .WithMembers(SyntaxFactory.List(members))
                .WithLeadingTrivia(node.GetLeadingTrivia());
        }

        public override SyntaxNode? VisitAssignmentExpression(AssignmentExpressionSyntax node)
        {
            if (node.Left is MemberAccessExpressionSyntax { Name.Identifier.ValueText: "OriginatingResolver" }
                && node.Right is ThisExpressionSyntax)
            {
                return node.WithRight(SyntaxFactory.ParseExpression("options.TypeInfoResolver")
                    .WithTriviaFrom(node.Right));
            }
            return base.VisitAssignmentExpression(node);
        }
    }
}
