using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.Packaging;

/// <summary>
/// Works out which OpenAPI tags can transitively reach each generated type, so split-by-tags
/// generation can give a type to a tag package instead of leaving everything in Core.
/// </summary>
/// <remarks>
/// <para>
/// Ownership is "the set of tags that reach it": a type reached by exactly one tag belongs to that
/// tag's package, anything reached by two or more (or by nothing at all) belongs to Core. That rule
/// is self-consistent, which is what makes it safe to act on — if a Core type <c>M</c> references
/// <c>N</c>, then everything reaching <c>M</c> also reaches <c>N</c>, so <c>N</c> is reached by at
/// least as many tags and is in Core too. A Core type can therefore never reference a tag-owned
/// type, and no <c>Core -&gt; tag</c> assembly reference is ever needed.
/// </para>
/// <para>
/// <see cref="SchemaContext.Tags"/> already carries a transitive tag set, but it was built for
/// <c>--include-tags</c> filtering where over-inclusion is harmless: it is depth-capped and it
/// walks only children and resolved references. Ownership is not that forgiving, so this walk is
/// uncapped and additionally follows <see cref="TypeData.SubTypes"/> and discriminator mappings —
/// the same two edges <c>JsonSerializationDirectionAnalyzer</c> had to add for the same reason.
/// </para>
/// </remarks>
public static class TagOwnershipAnalyzer
{
    /// <summary>
    /// Maps <see cref="TypeData.CSharpTypeWithoutNullability"/> to the tags that reach it.
    /// </summary>
    /// <remarks>
    /// Types reachable from no tagged operation are absent from the result; callers must read that
    /// as "shared", not as "unused".
    /// </remarks>
    public static IReadOnlyDictionary<string, ImmutableArray<string>> Analyze(
        IReadOnlyList<SchemaContext> schemas)
    {
        schemas = schemas ?? throw new ArgumentNullException(nameof(schemas));

        var tagsByType = new Dictionary<string, SortedSet<string>>(StringComparer.Ordinal);

        foreach (var tag in CollectTags(schemas))
        {
            MarkReachable(schemas, tag, tagsByType);
        }

        MergeInseparableTypes(schemas, tagsByType);

        var result = new Dictionary<string, ImmutableArray<string>>(tagsByType.Count, StringComparer.Ordinal);
        foreach (var pair in tagsByType)
        {
            result[pair.Key] = pair.Value.ToImmutableArray();
        }

        return result;
    }

    private static SortedSet<string> CollectTags(IReadOnlyList<SchemaContext> schemas)
    {
        var tags = new SortedSet<string>(StringComparer.Ordinal);
        for (var index = 0; index < schemas.Count; index++)
        {
            foreach (var tag in GetOperationTags(schemas[index]))
            {
                tags.Add(tag);
            }
        }

        return tags;
    }

    private static IEnumerable<string> GetOperationTags(SchemaContext schema)
    {
        if (!schema.IsOperation || schema.Operation?.Tags is not { } tags)
        {
            yield break;
        }

        foreach (var tag in tags)
        {
            if (!string.IsNullOrEmpty(tag?.Name))
            {
                yield return tag!.Name!;
            }
        }
    }

    /// <summary>
    /// Flood-fills the type graph from every operation carrying <paramref name="tag"/>.
    /// </summary>
    private static void MarkReachable(
        IReadOnlyList<SchemaContext> schemas,
        string tag,
        Dictionary<string, SortedSet<string>> tagsByType)
    {
        // One visited set per tag: re-entering a node from another operation of the same tag
        // cannot add anything, but a different tag must be free to visit it again.
        var visited = new HashSet<SchemaContext>();
        var stack = new Stack<SchemaContext>();

        for (var index = 0; index < schemas.Count; index++)
        {
            var schema = schemas[index];
            if (!GetOperationTags(schema).Contains(tag, StringComparer.Ordinal))
            {
                continue;
            }

            stack.Push(schema);
            Walk(stack, visited, tag, tagsByType);
        }
    }

    private static void Walk(
        Stack<SchemaContext> stack,
        HashSet<SchemaContext> visited,
        string tag,
        Dictionary<string, SortedSet<string>> tagsByType)
    {
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (!visited.Add(current))
            {
                continue;
            }

            AddTag(tagsByType, current.TypeData.CSharpTypeWithoutNullability, tag);
            foreach (var subType in current.TypeData.SubTypes)
            {
                AddTag(tagsByType, subType.Unbox<TypeData>().CSharpTypeWithoutNullability, tag);
            }

            if (current.ResolvedReference is { } resolvedReference)
            {
                stack.Push(resolvedReference);
            }

            var children = current.Children;
            for (var index = 0; index < children.Count; index++)
            {
                stack.Push(children[index]);
            }

            foreach (var derived in GetDiscriminatorMappings(current))
            {
                stack.Push(derived);
            }
        }
    }

    /// <summary>
    /// Derived components a base schema names through its discriminator mapping. They are separate
    /// components rather than children, so nothing else in the walk would reach them.
    /// </summary>
    private static IEnumerable<SchemaContext> GetDiscriminatorMappings(SchemaContext schema)
    {
        if (schema.ComponentSchemas is not { } componentSchemas ||
            schema.Schema.Discriminator?.Mapping is not { Count: > 0 } mapping)
        {
            yield break;
        }

        foreach (var value in mapping.Values)
        {
            if (value?.Reference?.Id is { } referenceId &&
                componentSchemas.TryGetValue(referenceId, out var mapped))
            {
                yield return mapped;
            }
        }
    }

    /// <summary>
    /// Gives every member of a polymorphic family the union of the family's tags.
    /// </summary>
    /// <remarks>
    /// A base class names each subtype in its generated <c>DerivedTypes</c>, so the base references
    /// every subtype and could otherwise end up in a package that cannot see one of them. Only that
    /// direction needs merging: a subtype's schema has the base among its children, so the walk
    /// already gives the base at least every tag its subtypes have.
    /// </remarks>
    private static void MergeInseparableTypes(
        IReadOnlyList<SchemaContext> schemas,
        Dictionary<string, SortedSet<string>> tagsByType)
    {
        var parents = new Dictionary<string, string>(StringComparer.Ordinal);

        for (var index = 0; index < schemas.Count; index++)
        {
            var schema = schemas[index];
            var name = schema.TypeData.CSharpTypeWithoutNullability;
            if (string.IsNullOrWhiteSpace(name))
            {
                continue;
            }

            foreach (var derived in GetDiscriminatorMappings(schema))
            {
                Union(parents, name, derived.TypeData.CSharpTypeWithoutNullability);
            }
        }

        if (parents.Count == 0)
        {
            return;
        }

        var groups = new Dictionary<string, List<string>>(StringComparer.Ordinal);
        foreach (var name in parents.Keys.ToArray())
        {
            var root = Find(parents, name);
            if (!groups.TryGetValue(root, out var members))
            {
                members = [];
                groups[root] = members;
            }

            members.Add(name);
        }

        foreach (var members in groups.Values)
        {
            var union = new SortedSet<string>(StringComparer.Ordinal);
            foreach (var member in members)
            {
                if (tagsByType.TryGetValue(member, out var tags))
                {
                    union.UnionWith(tags);
                }
            }

            if (union.Count == 0)
            {
                continue;
            }

            foreach (var member in members)
            {
                tagsByType[member] = new SortedSet<string>(union, StringComparer.Ordinal);
            }
        }
    }

    private static void Union(Dictionary<string, string> parents, string left, string right)
    {
        if (string.IsNullOrWhiteSpace(left) ||
            string.IsNullOrWhiteSpace(right) ||
            string.Equals(left, right, StringComparison.Ordinal))
        {
            return;
        }

        var leftRoot = Find(parents, left);
        var rightRoot = Find(parents, right);
        if (!string.Equals(leftRoot, rightRoot, StringComparison.Ordinal))
        {
            // Ordinal ordering keeps the chosen root independent of schema iteration order.
            if (string.CompareOrdinal(leftRoot, rightRoot) < 0)
            {
                parents[rightRoot] = leftRoot;
            }
            else
            {
                parents[leftRoot] = rightRoot;
            }
        }
    }

    private static string Find(Dictionary<string, string> parents, string name)
    {
        if (!parents.TryGetValue(name, out var parent))
        {
            parents[name] = name;
            return name;
        }

        while (!string.Equals(parent, name, StringComparison.Ordinal))
        {
            name = parent;
            parent = parents[name];
        }

        return name;
    }

    private static void AddTag(
        Dictionary<string, SortedSet<string>> tagsByType,
        string type,
        string tag)
    {
        if (string.IsNullOrWhiteSpace(type))
        {
            return;
        }

        if (!tagsByType.TryGetValue(type, out var tags))
        {
            tags = new SortedSet<string>(StringComparer.Ordinal);
            tagsByType[type] = tags;
        }

        tags.Add(tag);
    }
}
