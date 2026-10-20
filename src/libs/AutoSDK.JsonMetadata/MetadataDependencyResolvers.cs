using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace AutoSDK.JsonMetadata;

/// <summary>Completes schema-planned scopes with dependencies discovered by the official STJ compiler.</summary>
internal static class MetadataDependencyResolvers
{
    private sealed class Factory(string identity, TypeSyntax type, HashSet<string> dependencies)
    {
        internal string Identity { get; } = identity;
        internal TypeSyntax Type { get; } = type;
        internal string TypeKey { get; } = MetadataDependencyResolvers.TypeKey(type);
        internal HashSet<string> Dependencies { get; } = dependencies;
    }

    internal static void Generate(SourceProductionContext output, Compilation compilation,
        IReadOnlyList<(string Hint, SyntaxNode Root)> sources)
    {
        var byIdentity = new Dictionary<string, Factory>(StringComparer.Ordinal);
        var byType = new Dictionary<string, Factory>(StringComparer.Ordinal);
        foreach (var source in sources.OrderBy(static source => source.Hint, StringComparer.Ordinal))
        {
            var declaration = source.Root.DescendantNodes().OfType<ClassDeclarationSyntax>().FirstOrDefault();
            if (declaration is null)
            {
                continue;
            }
            var method = declaration.Members.OfType<MethodDeclarationSyntax>()
                .FirstOrDefault(static method => method.Identifier.ValueText.StartsWith("Create_", StringComparison.Ordinal));
            var type = method?.ReturnType.DescendantNodesAndSelf().OfType<GenericNameSyntax>()
                .FirstOrDefault(static name => name.Identifier.ValueText == "JsonTypeInfo")?.TypeArgumentList.Arguments.FirstOrDefault();
            if (method is null || type is null)
            {
                continue;
            }
            // STJ's typed property/collection initializers and polymorphic typeof registrations
            // describe the actual compiled model, including handwritten partial/inherited members.
            var dependencyTypes = new List<TypeSyntax> { type };
            foreach (var creation in source.Root.DescendantNodes().OfType<ObjectCreationExpressionSyntax>())
            {
                var property = creation.Type.DescendantNodesAndSelf().OfType<GenericNameSyntax>()
                    .FirstOrDefault(static name => name.Identifier.ValueText == "JsonPropertyInfoValues");
                if (property is not null && !(creation.Initializer?.Expressions.OfType<AssignmentExpressionSyntax>()
                    .Any(static assignment => assignment.Left.ToString() == "IgnoreCondition" &&
                        assignment.Right.ToString().EndsWith("JsonIgnoreCondition.Always", StringComparison.Ordinal)) ?? false))
                {
                    dependencyTypes.AddRange(property.TypeArgumentList.Arguments);
                }
            }
            foreach (var invocation in method.DescendantNodes().OfType<InvocationExpressionSyntax>())
            {
                dependencyTypes.AddRange(invocation.Expression.DescendantNodesAndSelf().OfType<GenericNameSyntax>()
                    .SelectMany(static name => name.TypeArgumentList.Arguments));
            }
            dependencyTypes.AddRange(method.DescendantNodes().OfType<TypeOfExpressionSyntax>()
                .Select(static expression => expression.Type));
            dependencyTypes.AddRange(source.Root.DescendantNodes().OfType<AssignmentExpressionSyntax>()
                .Where(static assignment => assignment.Left.ToString() == "ParameterType")
                .SelectMany(static assignment => assignment.Right.DescendantNodesAndSelf().OfType<TypeOfExpressionSyntax>())
                .Select(static expression => expression.Type));
            var dependencies = new HashSet<string>(dependencyTypes.SelectMany(static dependency =>
                    dependency.DescendantNodesAndSelf().OfType<TypeSyntax>()).Select(TypeKey), StringComparer.Ordinal);
            var identity = Namespace(declaration) + "." + declaration.Identifier.ValueText + "." + method.Identifier.ValueText;
            var factory = new Factory(identity, type, dependencies);
            byIdentity[identity] = factory;
            if (!byType.ContainsKey(factory.TypeKey))
            {
                byType.Add(factory.TypeKey, factory);
            }
        }
        var scopes = new List<Scope>();
        foreach (var tree in compilation.SyntaxTrees)
        {
            foreach (var resolver in tree.GetRoot(output.CancellationToken).DescendantNodes().OfType<ClassDeclarationSyntax>())
            {
                if (resolver.Identifier.ValueText != "SharedMetadataResolver" ||
                    resolver.Parent is not ClassDeclarationSyntax owner ||
                    !resolver.Members.OfType<MethodDeclarationSyntax>().Any(static method =>
                        method.Identifier.ValueText == "ResolveAdditionalTypeInfo"))
                {
                    continue;
                }
                var roots = resolver.DescendantNodes().OfType<InvocationExpressionSyntax>()
                    .Select(static invocation => invocation.Expression.ToString().Replace("global::", ""))
                    .Where(byIdentity.ContainsKey).Select(identity => byIdentity[identity]).ToArray();
                var children = owner.DescendantNodes().OfType<MemberAccessExpressionSyntax>()
                    .Where(static access => access.Name.Identifier.ValueText == "MetadataScope")
                    .Select(access =>
                    {
                        var name = access.Expression.ToString().Replace("global::", "");
                        return name.Contains(".") ? name : Namespace(owner) + "." + name;
                    })
                    .Distinct(StringComparer.Ordinal).ToArray();
                scopes.Add(new Scope(owner, roots, children));
            }
        }
        var scopeByName = scopes.ToDictionary(static scope => scope.Name, StringComparer.Ordinal);
        var ownersByType = new Dictionary<string, List<Scope>>(StringComparer.Ordinal);
        foreach (var scope in scopes)
        {
            foreach (var factory in scope.Roots)
            {
                if (!ownersByType.TryGetValue(factory.TypeKey, out var owners))
                {
                    owners = [];
                    ownersByType.Add(factory.TypeKey, owners);
                }
                owners.Add(scope);
            }
        }
        foreach (var scope in scopes)
        {
            // Stop at a dependency owned by a reachable component. That component completes its
            // own compiled partial members, rather than copying its entire closure into parents.
            var reachable = new HashSet<Scope>();
            var remaining = new Stack<Scope>();
            remaining.Push(scope);
            while (remaining.Count != 0)
            {
                var current = remaining.Pop();
                if (!reachable.Add(current)) continue;
                foreach (var child in current.Children)
                    if (scopeByName.TryGetValue(child, out var next)) remaining.Push(next);
            }
            var visited = new HashSet<string>(scope.Roots.Select(static factory => factory.TypeKey), StringComparer.Ordinal);
            var pending = new Stack<Factory>(scope.Roots);
            var additional = new List<Factory>();
            while (pending.Count > 0)
            {
                output.CancellationToken.ThrowIfCancellationRequested();
                foreach (var dependency in pending.Pop().Dependencies)
                {
                    if (!byType.TryGetValue(dependency, out var factory) || !visited.Add(dependency)) continue;
                    if (ownersByType.TryGetValue(dependency, out var owners) && owners.Any(reachable.Contains)) continue;
                    additional.Add(factory);
                    pending.Push(factory);
                }
            }
            if (additional.Count == 0) continue;
            var ns = Namespace(scope.Owner);
            var builder = new StringBuilder("// <auto-generated/>\n#nullable enable\n#pragma warning disable CS0612, CS0618\n");
            builder.Append("namespace ").Append(ns).Append("\n{\npartial class ").Append(scope.Owner.Identifier.ValueText)
                .Append("\n{\nprivate sealed partial class SharedMetadataResolver\n{\n")
                .Append("static partial void ResolveAdditionalTypeInfo(global::System.Type type, global::System.Text.Json.JsonSerializerOptions options, ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result)\n{\n");
            foreach (var factory in additional.OrderBy(static factory => factory.TypeKey, StringComparer.Ordinal))
            {
                builder.Append("if (type == typeof(").Append(factory.Type.ToString()).Append(")) { result = global::")
                    .Append(factory.Identity).Append("(options); return; }\n");
            }
            builder.Append("}\n}\n}\n}\n");
            output.AddSource("AutoSDK.SharedDependencies." + ns + "." + scope.Owner.Identifier.ValueText + ".g.cs",
                SourceText.From(builder.ToString(), Encoding.UTF8));
        }
    }

    private sealed class Scope(ClassDeclarationSyntax owner, Factory[] roots, string[] children)
    {
        internal ClassDeclarationSyntax Owner { get; } = owner;
        internal string Name { get; } = Namespace(owner) + "." + owner.Identifier.ValueText;
        internal Factory[] Roots { get; } = roots;
        internal string[] Children { get; } = children;
    }

    private static string Namespace(SyntaxNode declaration) => string.Join(".", declaration.Ancestors()
        .OfType<BaseNamespaceDeclarationSyntax>().Reverse().Select(static ns => ns.Name.ToString()));

    private static string TypeKey(TypeSyntax type) => string.Concat(new RuntimeNames().Visit(type)!
        .DescendantTokens().Select(static token => token.Text)).Replace("global::", "");

    private sealed class RuntimeNames : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitPredefinedType(PredefinedTypeSyntax node)
        {
            var name = node.Keyword.Kind() switch
            {
                SyntaxKind.BoolKeyword => "Boolean", SyntaxKind.ByteKeyword => "Byte",
                SyntaxKind.SByteKeyword => "SByte", SyntaxKind.ShortKeyword => "Int16",
                SyntaxKind.UShortKeyword => "UInt16", SyntaxKind.IntKeyword => "Int32",
                SyntaxKind.UIntKeyword => "UInt32", SyntaxKind.LongKeyword => "Int64",
                SyntaxKind.ULongKeyword => "UInt64", SyntaxKind.FloatKeyword => "Single",
                SyntaxKind.DoubleKeyword => "Double", SyntaxKind.DecimalKeyword => "Decimal",
                SyntaxKind.CharKeyword => "Char", SyntaxKind.StringKeyword => "String",
                SyntaxKind.ObjectKeyword => "Object", _ => null,
            };
            return name is null ? node : SyntaxFactory.ParseTypeName("global::System." + name);
        }
    }
}
