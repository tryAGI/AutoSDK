using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AutoSDK.JsonMetadata;

internal sealed partial class FactoryBatches
{
    private readonly List<(string Context, string Alias, string Target)> aliases = [];

    internal void ResolveAliases(CSharpCompilation compilation, IEnumerable<SyntaxTree> manifests,
        IReadOnlyDictionary<string, string> originalNames, CancellationToken token)
    {
        foreach (var tree in manifests)
        {
            var semantic = compilation.GetSemanticModel(tree);
            foreach (var declaration in tree.GetRoot(token).DescendantNodes().OfType<ClassDeclarationSyntax>())
            {
                var identity = Namespace(declaration) + "." + declaration.Identifier.ValueText;
                var context = originalNames.TryGetValue(identity, out var original)
                    ? Namespace(declaration) + "." + original : identity;
                if (!plans.ContainsKey(context)) continue;
                var groups = new Dictionary<ITypeSymbol, List<string>>(SymbolEqualityComparer.Default);
                foreach (var attribute in declaration.AttributeLists.SelectMany(static list => list.Attributes))
                {
                    if (!(attribute.Name.ToString().EndsWith("JsonSerializable", StringComparison.Ordinal) ||
                          attribute.Name.ToString().EndsWith("JsonSerializableAttribute", StringComparison.Ordinal))) continue;
                    var arguments = attribute.ArgumentList?.Arguments;
                    var typeOf = arguments?.FirstOrDefault()?.Expression as TypeOfExpressionSyntax;
                    var name = arguments?.FirstOrDefault(static argument =>
                        argument.NameEquals?.Name.Identifier.ValueText == "TypeInfoPropertyName")?.Expression as LiteralExpressionSyntax;
                    if (typeOf is null || name is null) continue;
                    var type = semantic.GetTypeInfo(typeOf.Type, token).Type;
                    if (type is null || type.TypeKind == TypeKind.Error) continue;
                    if (!groups.TryGetValue(type, out var names))
                    {
                        names = [];
                        groups.Add(type, names);
                    }
                    names.Add(name.Token.ValueText);
                }
                // STJ deduplicates reference-nullability variants by runtime symbol identity.
                // Nullable<T> remains a different symbol and must retain its own factory.
                foreach (var names in groups.Values)
                {
                    var target = names.Where(discovered[context].Contains).OrderBy(static name => name, StringComparer.Ordinal).FirstOrDefault();
                    if (target is null) continue;
                    foreach (var name in names.Where(name => !discovered[context].Contains(name)).Distinct(StringComparer.Ordinal))
                        aliases.Add((context, name, target));
                }
            }
        }
    }

    internal List<(string Hint, SyntaxNode Root)> WithAliases(List<(string Hint, SyntaxNode Root)> factories,
        bool forwarding)
    {
        if (aliases.Count == 0) return factories;
        var byIdentity = new Dictionary<string, (string Hint, SyntaxNode Root)>(StringComparer.Ordinal);
        foreach (var source in factories)
        {
            var declaration = Declaration(source.Root);
            var method = declaration.Members.OfType<MethodDeclarationSyntax>().FirstOrDefault(static method =>
                method.Identifier.ValueText.StartsWith("Create_", StringComparison.Ordinal));
            if (method is not null)
                byIdentity.Add(Namespace(declaration) + "." + declaration.Identifier.ValueText + "." + method.Identifier.ValueText, source);
        }
        var result = new List<(string Hint, SyntaxNode Root)>(factories);
        foreach (var alias in aliases)
        {
            var prefix = alias.Context.Substring(0, alias.Context.LastIndexOf('.') + 1);
            var targetHolder = Holder(alias.Context, alias.Target)!;
            var aliasHolder = Holder(alias.Context, alias.Alias)!;
            var source = byIdentity[prefix + targetHolder + ".Create_" + alias.Target];
            var declaration = Declaration(source.Root);
            var method = CreateMethod(declaration);
            var renamed = method.WithIdentifier(SyntaxFactory.Identifier("Create_" + alias.Alias));
            var constructor = declaration.Members.OfType<ConstructorDeclarationSyntax>().Single()
                .WithIdentifier(SyntaxFactory.Identifier(aliasHolder));
            IEnumerable<MemberDeclarationSyntax> members;
            if (forwarding)
            {
                renamed = renamed.WithBody(null).WithExpressionBody(SyntaxFactory.ArrowExpressionClause(
                        SyntaxFactory.ParseExpression("global::" + prefix + targetHolder + "." + method.Identifier.ValueText + "(options)")))
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));
                members = [constructor, renamed];
            }
            else
            {
                // Dependency completion sees the original body, including handwritten partial
                // members. Only the thin forwarding entry is emitted into the SDK assembly.
                members = declaration.Members.Select(member => member is ConstructorDeclarationSyntax ? constructor :
                    member is MethodDeclarationSyntax candidate && candidate.Identifier.ValueText == method.Identifier.ValueText
                        ? renamed : member);
            }
            var replacement = declaration.WithIdentifier(SyntaxFactory.Identifier(aliasHolder))
                .WithMembers(SyntaxFactory.List(members));
            result.Add(("zz_AutoSDK.Alias." + alias.Context + "." + alias.Alias + ".g.cs",
                source.Root.ReplaceNode(declaration, replacement)));
        }
        return result;
    }
}
