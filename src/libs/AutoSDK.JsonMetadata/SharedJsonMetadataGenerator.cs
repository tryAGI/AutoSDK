using System.Collections.Immutable;
using System.Text;
using AutoSDK.Internal;
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

    private static readonly DiagnosticDescriptor UpstreamWarning = new(
        "AMETA002", "System.Text.Json source generation warning",
        "{0}", "AutoSDK.JsonMetadata", DiagnosticSeverity.Warning, isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor IncompatibleManifest = new(
        "AMETA003", "Shared JSON metadata manifest protocol is unsupported",
        "{0}", "AutoSDK.JsonMetadata", DiagnosticSeverity.Error, isEnabledByDefault: true);

    /// <inheritdoc />
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var manifests = context.AdditionalTextsProvider
            .Where(static file => file.Path.EndsWith(".autosdk-json-metadata", StringComparison.Ordinal))
            .Select(static (file, token) => (Path: file.Path, Text: file.GetText(token)))
            .Collect();
        context.RegisterSourceOutput(context.CompilationProvider.Combine(manifests),
            static (output, input) => Generate(output, input.Left, input.Right));
    }

    private static void Generate(SourceProductionContext output, Compilation compilation,
        ImmutableArray<(string Path, SourceText? Text)> manifests)
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
        var isolatedContexts = new HashSet<string>(StringComparer.Ordinal);
        var batches = new FactoryBatches();
        for (var index = 0; index < manifests.Length; index++)
        {
            if (manifests[index].Text is not { } text)
            {
                output.ReportDiagnostic(Diagnostic.Create(IncompatibleOutput, Location.None,
                    "A shared JSON metadata manifest could not be read."));
                return;
            }
            var version = ReadManifestVersion(text);
            if (version is < 0 or > SharedJsonMetadataProtocol.CurrentVersion)
            {
                output.ReportDiagnostic(Diagnostic.Create(IncompatibleManifest, Location.None,
                    "Unsupported shared JSON metadata format " + version.ToString(System.Globalization.CultureInfo.InvariantCulture) +
                    " in '" + manifests[index].Path + "'. Update the CLI and AutoSDK.JsonMetadata package together."));
                return;
            }
            var tree = CSharpSyntaxTree.ParseText(text, parseOptions, path: manifests[index].Path,
                cancellationToken: output.CancellationToken);
            sources.Add(tree);
            if (version >= 3)
            {
                try
                {
                    batches.AddManifest(tree, output.CancellationToken);
                }
                catch (InvalidOperationException exception)
                {
                    output.ReportDiagnostic(Diagnostic.Create(IncompatibleManifest, Location.None,
                        exception.Message + " [" + manifests[index].Path + "]"));
                    return;
                }
            }
            if (version >= 1)
            {
                foreach (var declaration in tree.GetRoot(output.CancellationToken).DescendantNodes().OfType<ClassDeclarationSyntax>())
                {
                    isolatedContexts.Add(Namespace(declaration) + "." + declaration.Identifier.ValueText);
                }
            }
        }

        var originalContextNames = IsolateContextNames(sources, csharp, parseOptions, output.CancellationToken);
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
            if (diagnostic.Severity == DiagnosticSeverity.Error && diagnostic.DefaultSeverity != DiagnosticSeverity.Warning)
            {
                output.ReportDiagnostic(Diagnostic.Create(IncompatibleOutput, Location.None,
                    diagnostic.ToString()));
                return;
            }
        }

        var warnings = result.Diagnostics.Where(static diagnostic =>
            diagnostic.DefaultSeverity == DiagnosticSeverity.Warning).ToArray();
        if (warnings.Length > 0)
        {
            // The framework generator reports ordinary-context warnings itself. Only run the
            // comparison on a warning path; supported SDKs pay no second generation cost.
            var ordinary = driver.RunGenerators(csharp, output.CancellationToken).GetRunResult();
            var alreadyReported = new HashSet<string>(ordinary.Diagnostics
                .Where(static diagnostic => diagnostic.DefaultSeverity == DiagnosticSeverity.Warning)
                .Select(DiagnosticIdentity), StringComparer.Ordinal);
            foreach (var warning in warnings)
            {
                if (alreadyReported.Contains(DiagnosticIdentity(warning)))
                {
                    continue;
                }
                var location = warning.Location.SourceTree is { } tree && csharp.SyntaxTrees.Contains(tree)
                    ? warning.Location : Location.None;
                var message = warning.Id + ": " + warning.GetMessage(System.Globalization.CultureInfo.InvariantCulture);
                if (location == Location.None && warning.Location != Location.None)
                {
                    message += " [" + warning.Location.GetLineSpan() + "]";
                }
                output.ReportDiagnostic(Diagnostic.Create(UpstreamWarning, location, warning.Severity,
                    additionalLocations: null, properties: null, messageArgs: [message]));
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
        // Discover implicit STJ dependencies before choosing bounded holder names. Canonical
        // registrations keep the CLI's complete plan, including disabled guarded attributes.
        foreach (var source in result.Results.SelectMany(static generator => generator.GeneratedSources))
        {
            var declaration = source.SyntaxTree.GetRoot(output.CancellationToken).DescendantNodes()
                .OfType<ClassDeclarationSyntax>().FirstOrDefault();
            var create = declaration?.Members.OfType<MethodDeclarationSyntax>().FirstOrDefault(static method =>
                method.Identifier.ValueText.StartsWith("Create_", StringComparison.Ordinal));
            if (declaration is null || create is null)
            {
                continue;
            }
            var identity = Namespace(declaration) + "." + declaration.Identifier.ValueText;
            var contextName = originalContextNames.TryGetValue(identity, out var original)
                ? original : declaration.Identifier.ValueText;
            batches.Discover(Namespace(declaration) + "." + contextName,
                create.Identifier.ValueText.Substring("Create_".Length));
        }
        batches.ResolveAliases(augmented, sources, originalContextNames, output.CancellationToken);
        batches.Complete();
        var factorySources = new List<(string Hint, SyntaxNode Root)>();
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
                var declaration = root.DescendantNodes().OfType<ClassDeclarationSyntax>().FirstOrDefault();
                var contextName = declaration?.Identifier.ValueText;
                if (declaration is not null && originalContextNames.TryGetValue(
                        Namespace(declaration) + "." + contextName, out var originalContextName))
                {
                    contextName = originalContextName;
                }
                var isolated = declaration is not null &&
                    isolatedContexts.Contains(Namespace(declaration) + "." + contextName);
                var create = declaration?.Members.OfType<MethodDeclarationSyntax>().FirstOrDefault(static method =>
                    method.Identifier.ValueText.StartsWith("Create_", StringComparison.Ordinal));
                var holder = declaration is null ? null : batches.Holder(Namespace(declaration) + "." + contextName,
                    create?.Identifier.ValueText.Substring("Create_".Length));
                var transformed = new FactoryRewriter(isolated, contextName, declaration?.Identifier.ValueText, holder).Visit(root);
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
                factorySources.Add((source.HintName, transformed));
                // Keep each original factory body separate for precise dependency analysis.
                // Merging before this analysis would root sibling factories in the same batch.
            }
        }
        if (isolatedContexts.Count != 0)
        {
            output.AddSource("AutoSDK.JsonMetadata.Protocol.g.cs", SourceText.From(
                "// <auto-generated/>\nnamespace AutoSDK.JsonMetadata.Generated\n{\n" +
                "internal static class ManifestProtocol { internal const int Version1 = 1; internal const int Version2 = 2; internal const int Version3 = 3; }\n}\n", Encoding.UTF8));
        }
        MetadataDependencyResolvers.Generate(output, csharp, batches.WithAliases(factorySources, forwarding: false));
        batches.Emit(output, batches.WithAliases(factorySources, forwarding: true));
    }

    private static Dictionary<string, string> IsolateContextNames(List<SyntaxTree> sources,
        CSharpCompilation compilation, CSharpParseOptions parseOptions, CancellationToken cancellationToken)
    {
        var declarations = sources.SelectMany(tree => tree.GetRoot(cancellationToken)
            .DescendantNodes().OfType<ClassDeclarationSyntax>()).ToArray();
        var names = new HashSet<string>(declarations.Select(static declaration => declaration.Identifier.ValueText),
            StringComparer.Ordinal);
        var collisions = new HashSet<string>(declarations.GroupBy(static declaration => declaration.Identifier.ValueText,
                StringComparer.Ordinal).Where(group => group.Select(declaration =>
                Namespace(declaration) + "." + declaration.Identifier.ValueText).Distinct(StringComparer.Ordinal).Skip(1).Any())
            .Select(static group => group.Key), StringComparer.Ordinal);
        // Ordinary contexts are emitted by the framework generator as usual. Their names must
        // not collide with a manifest context in this private generator invocation either.
        foreach (var tree in compilation.SyntaxTrees)
        {
            foreach (var declaration in tree.GetRoot(cancellationToken).DescendantNodes(static node =>
                         node is CompilationUnitSyntax or BaseNamespaceDeclarationSyntax or TypeDeclarationSyntax)
                         .OfType<ClassDeclarationSyntax>())
            {
                if (names.Contains(declaration.Identifier.ValueText) && declaration.BaseList?.Types.Any(static type =>
                        type.Type.ToString().EndsWith("JsonSerializerContext", StringComparison.Ordinal)) == true)
                {
                    collisions.Add(declaration.Identifier.ValueText);
                }
            }
        }
        var originals = new Dictionary<string, string>(StringComparer.Ordinal);
        if (collisions.Count == 0)
        {
            return originals;
        }
        var aliases = new Dictionary<string, string>(StringComparer.Ordinal);
        foreach (var declaration in declarations.Where(declaration => collisions.Contains(declaration.Identifier.ValueText)))
        {
            var identity = Namespace(declaration) + "." + declaration.Identifier.ValueText;
            if (aliases.ContainsKey(identity))
            {
                continue;
            }
            using var hash = System.Security.Cryptography.SHA256.Create();
            var suffix = BitConverter.ToString(hash.ComputeHash(Encoding.UTF8.GetBytes(identity)))
                .Replace("-", string.Empty).Substring(0, 16);
            var alias = declaration.Identifier.ValueText + "_AutoSDK_" + suffix;
            while (!names.Add(alias))
            {
                alias += "_";
            }
            aliases.Add(identity, alias);
            originals.Add(Namespace(declaration) + "." + alias, declaration.Identifier.ValueText);
        }
        for (var index = 0; index < sources.Count; index++)
        {
            var root = sources[index].GetRoot(cancellationToken);
            var replacements = root.DescendantNodes().OfType<ClassDeclarationSyntax>()
                .Where(declaration => aliases.ContainsKey(Namespace(declaration) + "." + declaration.Identifier.ValueText));
            var renamed = root.ReplaceNodes(replacements, (original, rewritten) =>
                rewritten.WithIdentifier(SyntaxFactory.Identifier(aliases[
                    Namespace(original) + "." + original.Identifier.ValueText]).WithTriviaFrom(rewritten.Identifier)));
            sources[index] = sources[index].WithRootAndOptions(renamed, parseOptions);
        }
        return originals;
    }

    private static string DiagnosticIdentity(Diagnostic diagnostic) => diagnostic.Id + "\n" +
        diagnostic.GetMessage(System.Globalization.CultureInfo.InvariantCulture) + "\n" +
        diagnostic.Location.GetLineSpan() + "\n" + diagnostic.Location.SourceSpan;

    private static int ReadManifestVersion(SourceText text)
    {
        // Legacy manifests have no header and keep their validated chunk/factory layout.
        foreach (var line in text.Lines.Take(10))
        {
            var value = line.ToString().TrimStart('\uFEFF').Trim();
            if (value.StartsWith(SharedJsonMetadataProtocol.HeaderPrefix, StringComparison.Ordinal))
            {
                return int.TryParse(value.Substring(SharedJsonMetadataProtocol.HeaderPrefix.Length),
                    System.Globalization.NumberStyles.None, System.Globalization.CultureInfo.InvariantCulture,
                    out var version) ? version : -1;
            }
        }
        return 0;
    }

    private static string Namespace(SyntaxNode declaration) => string.Join(".", declaration.Ancestors()
        .OfType<BaseNamespaceDeclarationSyntax>().Reverse().Select(static item => item.Name.ToString()));

    private sealed class FactoryRewriter(bool isolatedFactories, string? originalContextName,
        string? generatedContextName, string? batchHolderName) : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var create = node.Members.OfType<MethodDeclarationSyntax>()
                .FirstOrDefault(static method => method.Identifier.ValueText.StartsWith("Create_", StringComparison.Ordinal));
            var contextName = originalContextName ?? node.Identifier.ValueText;
            var holderName = isolatedFactories && create is not null
                ? batchHolderName ?? SharedJsonMetadataProtocol.FactoryHolderName(contextName,
                    create.Identifier.ValueText.Substring("Create_".Length))
                : contextName;
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
                        members.Add(isolatedFactories ? field.WithModifiers(SyntaxFactory.TokenList(
                            SyntaxFactory.Token(SyntaxKind.ProtectedKeyword).WithTrailingTrivia(SyntaxFactory.Space),
                            SyntaxFactory.Token(SyntaxKind.ConstKeyword).WithTrailingTrivia(SyntaxFactory.Space))) : field);
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
                if (isolatedFactories && create is null)
                {
                    method = method.WithModifiers(SyntaxFactory.TokenList(
                        SyntaxFactory.Token(SyntaxKind.ProtectedKeyword).WithTrailingTrivia(SyntaxFactory.Space),
                        SyntaxFactory.Token(SyntaxKind.StaticKeyword).WithTrailingTrivia(SyntaxFactory.Space)));
                }
                members.Add((MemberDeclarationSyntax)Visit(method));
            }
            // Keep support methods in a field-free abstract base. Each metadata factory has
            // its own compiler closure holder; no aggregate dispatcher or instance is retained.
            if (isolatedFactories && create is not null)
            {
                members.Insert(0, SyntaxFactory.ConstructorDeclaration(holderName)
                    .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PrivateKeyword)
                        .WithTrailingTrivia(SyntaxFactory.Space))).WithBody(SyntaxFactory.Block()));
            }
            return node.WithIdentifier(SyntaxFactory.Identifier(holderName).WithTriviaFrom(node.Identifier))
                .WithAttributeLists(default)
                .WithBaseList(isolatedFactories && create is not null
                    ? SyntaxFactory.BaseList(SyntaxFactory.SingletonSeparatedList<BaseTypeSyntax>(
                        SyntaxFactory.SimpleBaseType(SyntaxFactory.IdentifierName(contextName))))
                    : null)
                .WithModifiers(SyntaxFactory.TokenList(
                    SyntaxFactory.Token(SyntaxKind.InternalKeyword).WithTrailingTrivia(SyntaxFactory.Space),
                    SyntaxFactory.Token(isolatedFactories
                        ? create is null ? SyntaxKind.AbstractKeyword : SyntaxKind.SealedKeyword
                        : SyntaxKind.StaticKeyword).WithTrailingTrivia(SyntaxFactory.Space),
                    SyntaxFactory.Token(SyntaxKind.PartialKeyword).WithTrailingTrivia(SyntaxFactory.Space)))
                .WithMembers(SyntaxFactory.List(members))
                .WithLeadingTrivia(node.GetLeadingTrivia());
        }

        public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node) =>
            originalContextName is not null && node.Identifier.ValueText == generatedContextName
                ? node.WithIdentifier(SyntaxFactory.Identifier(originalContextName).WithTriviaFrom(node.Identifier))
                : base.VisitIdentifierName(node);

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
