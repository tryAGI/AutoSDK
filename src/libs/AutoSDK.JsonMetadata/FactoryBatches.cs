using AutoSDK.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Globalization;
using System.Text;

namespace AutoSDK.JsonMetadata;

/// <summary>Compile-time layout only; never emits an aggregate runtime dispatcher.</summary>
internal sealed class FactoryBatches
{
    // Allow ample room for compiler-generated closure methods below the CLR's 65,535 limit.
    internal const int MethodWeightBudget = 8192;
    private readonly Dictionary<string, Dictionary<string, string>> plans = new(StringComparer.Ordinal);
    private readonly Dictionary<string, SortedSet<string>> discovered = new(StringComparer.Ordinal);
    private readonly HashSet<string> holders = new(StringComparer.Ordinal);

    internal void AddManifest(SyntaxTree tree, CancellationToken token)
    {
        var root = tree.GetRoot(token);
        foreach (var declaration in root.DescendantNodes().OfType<ClassDeclarationSyntax>())
        {
            var identity = Namespace(declaration) + "." + declaration.Identifier.ValueText;
            if (plans.ContainsKey(identity))
            {
                throw new InvalidOperationException("Duplicate batch context '" + identity + "'.");
            }
            plans.Add(identity, new Dictionary<string, string>(StringComparer.Ordinal));
            discovered.Add(identity, new SortedSet<string>(StringComparer.Ordinal));
        }
        foreach (var line in tree.GetText(token).Lines)
        {
            var text = line.ToString().Trim();
            if (!text.StartsWith(SharedJsonMetadataProtocol.BatchPrefix, StringComparison.Ordinal))
            {
                continue;
            }
            var parts = text.Substring(SharedJsonMetadataProtocol.BatchPrefix.Length).Split('|');
            if (parts.Length != 3 || !plans.TryGetValue(parts[0], out var plan) ||
                !int.TryParse(parts[1], NumberStyles.None, CultureInfo.InvariantCulture, out var index) || index < 0)
            {
                throw new InvalidOperationException("Invalid factory batch plan: " + text);
            }
            var names = parts[2].Split(',');
            if (names.Length is < 1 or > SharedJsonMetadataProtocol.FactoryBatchSize ||
                names.Any(static name => !SyntaxFacts.IsValidIdentifier(name)) ||
                names.Distinct(StringComparer.Ordinal).Count() != names.Length)
            {
                throw new InvalidOperationException("Invalid or oversized factory batch: " + text);
            }
            var holder = SharedJsonMetadataProtocol.FactoryBatchHolderName(
                parts[0].Substring(parts[0].LastIndexOf('.') + 1), index);
            if (!holders.Add(parts[0].Substring(0, parts[0].LastIndexOf('.') + 1) + holder))
            {
                throw new InvalidOperationException("Duplicate factory batch: " + text);
            }
            foreach (var name in names)
            {
                if (plan.ContainsKey(name))
                {
                    throw new InvalidOperationException("Duplicate factory registration '" + name + "'.");
                }
                plan.Add(name, holder);
            }
        }
        // Guarded registrations remain in the comment plan even when their attributes are
        // disabled. Never recompute canonical indices from the active attribute subset.
        foreach (var declaration in root.DescendantNodes().OfType<ClassDeclarationSyntax>())
        {
            var plan = plans[Namespace(declaration) + "." + declaration.Identifier.ValueText];
            foreach (var attribute in declaration.AttributeLists.SelectMany(static list => list.Attributes)
                         .Where(static attribute => attribute.Name.ToString().EndsWith("JsonSerializable", StringComparison.Ordinal) ||
                             attribute.Name.ToString().EndsWith("JsonSerializableAttribute", StringComparison.Ordinal)))
            {
                var value = attribute.ArgumentList?.Arguments.FirstOrDefault(static argument =>
                    argument.NameEquals?.Name.Identifier.ValueText == "TypeInfoPropertyName")?.Expression
                    as LiteralExpressionSyntax;
                if (value is null || !plan.ContainsKey(value.Token.ValueText))
                {
                    throw new InvalidOperationException("Protocol 3 registrations require an explicit planned TypeInfoPropertyName.");
                }
            }
        }
    }

    internal void Discover(string context, string name)
    {
        if (discovered.TryGetValue(context, out var names))
        {
            names.Add(name);
        }
    }

    internal void Complete()
    {
        foreach (var pair in discovered)
        {
            var plan = plans[pair.Key];
            var context = pair.Key.Substring(pair.Key.LastIndexOf('.') + 1);
            var prefix = pair.Key.Substring(0, pair.Key.LastIndexOf('.') + 1);
            var index = 0;
            foreach (var name in pair.Value.Where(name => !plan.ContainsKey(name)).ToArray())
            {
                var holder = SharedJsonMetadataProtocol.ImplicitFactoryBatchHolderName(context,
                    index++ / SharedJsonMetadataProtocol.FactoryBatchSize);
                plan.Add(name, holder);
                holders.Add(prefix + holder);
            }
        }
    }

    internal string? Holder(string context, string? name) =>
        name is not null && plans.TryGetValue(context, out var plan) && plan.TryGetValue(name, out var holder)
            ? holder : null;

    internal void Emit(SourceProductionContext output, List<(string Hint, SyntaxNode Root)> factories)
    {
        var groups = new Dictionary<string, List<(string Hint, SyntaxNode Root)>>(StringComparer.Ordinal);
        foreach (var source in factories)
        {
            var declaration = Declaration(source.Root);
            var identity = Namespace(declaration) + "." + declaration.Identifier.ValueText;
            if (!holders.Contains(identity))
            {
                AddSource(output, source.Hint, source.Root);
                continue;
            }
            if (!groups.TryGetValue(identity, out var group))
            {
                group = [];
                groups.Add(identity, group);
            }
            group.Add(source);
        }
        foreach (var group in groups.Values)
        {
            var ordered = group.OrderBy(static item => CreateMethod(Declaration(item.Root)).Identifier.ValueText,
                StringComparer.Ordinal).ToArray();
            var parts = new List<List<(string Hint, SyntaxNode Root)>> { new() };
            var weight = 0;
            foreach (var item in ordered)
            {
                var itemWeight = MethodWeight(item.Root);
                if (parts[parts.Count - 1].Count != 0 && weight + itemWeight > MethodWeightBudget)
                {
                    parts.Add([]);
                    weight = 0;
                }
                parts[parts.Count - 1].Add(item);
                weight += itemWeight;
            }
            var first = Declaration(ordered[0].Root);
            var name = first.Identifier.ValueText;
            if (parts.Count == 1)
            {
                AddSource(output, ordered[0].Hint + ".batch.g.cs", Merge(ordered, name));
                continue;
            }
            // Heavy batches keep <=16 stable entry methods; bodies/closure types are split.
            // A single huge factory stays isolated, preserving the existing compatibility path.
            var forwarders = new List<MemberDeclarationSyntax>();
            for (var index = 0; index < parts.Count; index++)
            {
                var partName = name + "Part" + index.ToString("D4", CultureInfo.InvariantCulture);
                AddSource(output, ordered[0].Hint + ".part" + index.ToString(CultureInfo.InvariantCulture) + ".g.cs",
                    Merge(parts[index], partName));
                foreach (var item in parts[index])
                {
                    var method = CreateMethod(Declaration(item.Root));
                    forwarders.Add(method.WithBody(null).WithExpressionBody(SyntaxFactory.ArrowExpressionClause(
                            SyntaxFactory.ParseExpression(partName + "." + method.Identifier.ValueText + "(options)")))
                        .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)));
                }
            }
            forwarders.Insert(0, first.Members.OfType<ConstructorDeclarationSyntax>().Single());
            var wrapper = first.WithMembers(SyntaxFactory.List(forwarders));
            AddSource(output, ordered[0].Hint + ".batch.g.cs", ordered[0].Root.ReplaceNode(first, wrapper));
        }
    }

    internal static int MethodWeight(SyntaxNode root) => root.DescendantNodes().Count(static node =>
        node is MethodDeclarationSyntax or ConstructorDeclarationSyntax) +
        4 * root.DescendantNodes().Count(static node => node is AnonymousFunctionExpressionSyntax or LocalFunctionStatementSyntax);

    private static SyntaxNode Merge(IEnumerable<(string Hint, SyntaxNode Root)> sources, string name)
    {
        var array = sources.ToArray();
        var first = Declaration(array[0].Root);
        var members = array.SelectMany(static source => Declaration(source.Root).Members)
            .Where(static member => member is not ConstructorDeclarationSyntax).ToList();
        members.Insert(0, SyntaxFactory.ConstructorDeclaration(name).WithModifiers(SyntaxFactory.TokenList(
            SyntaxFactory.Token(SyntaxKind.PrivateKeyword).WithTrailingTrivia(SyntaxFactory.Space)))
            .WithBody(SyntaxFactory.Block()));
        return array[0].Root.ReplaceNode(first, first.WithIdentifier(SyntaxFactory.Identifier(name)
            .WithTriviaFrom(first.Identifier)).WithMembers(SyntaxFactory.List(members)));
    }

    private static MethodDeclarationSyntax CreateMethod(ClassDeclarationSyntax declaration) =>
        declaration.Members.OfType<MethodDeclarationSyntax>().First(static method =>
            method.Identifier.ValueText.StartsWith("Create_", StringComparison.Ordinal));

    private static ClassDeclarationSyntax Declaration(SyntaxNode root) =>
        root.DescendantNodes().OfType<ClassDeclarationSyntax>().First();

    private static string Namespace(SyntaxNode declaration) => string.Join(".", declaration.Ancestors()
        .OfType<BaseNamespaceDeclarationSyntax>().Reverse().Select(static item => item.Name.ToString()));

    private static void AddSource(SourceProductionContext output, string hint, SyntaxNode root) =>
        output.AddSource("AutoSDK.SharedMetadata." + hint, SourceText.From(root.ToFullString(), Encoding.UTF8));
}
