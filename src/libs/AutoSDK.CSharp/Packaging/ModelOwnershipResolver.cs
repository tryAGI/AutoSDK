using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using AutoSDK.Helpers;
using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Packaging;

/// <summary>
/// Turns <see cref="TagOwnershipAnalyzer"/>'s reachability sets into the final decision about which
/// generated models a tag package may take from Core.
/// </summary>
/// <remarks>
/// Both the package planner (which routes files) and the render (which has to emit a matching
/// serializer context per package) need exactly the same answer, so the decision lives here rather
/// than in either of them. It is recomputed on each call instead of being carried on
/// <see cref="Data"/>, which keeps the incremental generator's equatable model untouched; the
/// computation is deterministic and only runs in split-by-tags mode.
/// </remarks>
public static class ModelOwnershipResolver
{
    /// <summary>
    /// Maps a generated type's global class name to the OpenAPI tag that exclusively owns it.
    /// Types absent from the result belong to Core.
    /// </summary>
    public static IReadOnlyDictionary<string, string> Resolve(Data data)
    {
        var ownership = TagOwnershipAnalyzer.Analyze(data.FilteredSchemas);
        var owners = new Dictionary<string, string>(StringComparer.Ordinal);
        if (ownership.Count == 0)
        {
            return owners;
        }

        var models = data.Classes.Concat(data.Enums).ToArray();
        var nestingGroups = GroupByNesting(models);
        foreach (var group in nestingGroups)
        {
            // A nesting chain is one C# type, so it moves as a unit or not at all. Conservative on
            // purpose: reachability makes a nested model's tag set a superset of its parent's, so a
            // group can legitimately disagree and Core is always the safe answer.
            var tag = ResolveUnanimousTag(group.Value, ownership);
            if (tag is null)
            {
                continue;
            }

            foreach (var model in group.Value)
            {
                owners[model.GlobalClassName] = tag;
            }
        }

        // Named unions are model-like and safe to move: their variants are children of the union in
        // the schema graph, so the walk already gives every variant at least the union's tags.
        // Anonymous unions are the shared AnyOf/OneOf generics and stay in Core.
        foreach (var anyOf in data.AnyOfs)
        {
            if (!anyOf.IsNamed)
            {
                continue;
            }

            var name = $"global::{anyOf.Namespace}.{anyOf.Name}";
            if (ResolveSingleTag(name, ownership) is { } tag)
            {
                owners[name] = tag;
            }
        }

        DemoteCrossPackageReferences(data, models, nestingGroups, owners);

        return owners;
    }

    /// <summary>
    /// Moves back to Core anything a package outside its own would have to reference.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Schema reachability alone is not sound enough to act on. The schema graph AutoSDK builds is
    /// depth- and cycle-limited, so on a large specification -- <c>specs/github.yaml</c> is the case
    /// that proved it -- a model can end up referenced by a generated type the walk never connected
    /// it to, and Core would then name a type that had moved into a tag assembly.
    /// </para>
    /// <para>
    /// So reachability is treated as a proposal and the generated C# reference graph as the proof:
    /// whenever a type is referenced from a different package than the one that claimed it, the
    /// claim is dropped. Demotion only ever moves types towards Core, so the fixed point is reached
    /// in a bounded number of passes.
    /// </para>
    /// </remarks>
    private static void DemoteCrossPackageReferences(
        Data data,
        ModelData[] models,
        Dictionary<string, List<ModelData>> nestingGroups,
        Dictionary<string, string> owners)
    {
        if (owners.Count == 0)
        {
            return;
        }

        var referencesBySource = new List<(string Source, string[] References)>(models.Length + data.AnyOfs.Length);
        foreach (var model in models)
        {
            referencesBySource.Add((model.GlobalClassName, GetReferencedTypeNames(model).ToArray()));
        }

        foreach (var anyOf in data.AnyOfs)
        {
            var references = anyOf.Properties
                .SelectMany(static property => Flatten(property.Type, depth: 0))
                .ToArray();
            referencesBySource.Add(($"global::{anyOf.Namespace}.{anyOf.Name}", references));
        }

        // Converter registrations are a reference the model graph does not show. An anonymous union
        // converter is a generic instantiation -- OneOfJsonConverter<VariantA, VariantB> -- so it
        // has to be registered somewhere that can see every argument. One package can, as long as
        // all the arguments agree on it; when they do not, none can, and they all go back to Core.
        var converterTypeNames = data.Converters.Converters
            .Select(x => GetGlobalTypeNames(x).Distinct(StringComparer.Ordinal).ToArray())
            .Where(static x => x.Length > 1)
            .ToArray();

        bool changed;
        do
        {
            changed = false;

            foreach (var names in converterTypeNames)
            {
                if (CountDistinctOwners(names, owners) < 2)
                {
                    continue;
                }

                foreach (var name in names)
                {
                    changed |= owners.Remove(name);
                }
            }

            foreach (var (source, references) in referencesBySource)
            {
                owners.TryGetValue(source, out var sourceOwner);
                foreach (var reference in references)
                {
                    if (owners.TryGetValue(reference, out var referenceOwner) &&
                        !string.Equals(sourceOwner, referenceOwner, StringComparison.Ordinal))
                    {
                        owners.Remove(reference);
                        changed = true;
                    }
                }
            }

            // A demotion can break a nesting chain apart, and a nested partial cannot span
            // assemblies, so the whole chain has to follow its demoted member back to Core.
            foreach (var group in nestingGroups.Values)
            {
                var owned = group.Count(x => owners.ContainsKey(x.GlobalClassName));
                if (owned != 0 && owned != group.Count)
                {
                    foreach (var model in group)
                    {
                        changed |= owners.Remove(model.GlobalClassName);
                    }
                }
            }
        }
        while (changed);
    }

    private static int CountDistinctOwners(
        IReadOnlyList<string> names,
        Dictionary<string, string> owners)
    {
        HashSet<string>? distinct = null;
        foreach (var name in names)
        {
            if (owners.TryGetValue(name, out var owner))
            {
                distinct ??= new HashSet<string>(StringComparer.Ordinal);
                distinct.Add(owner);
            }
        }

        return distinct?.Count ?? 0;
    }

    /// <summary>
    /// Every <c>global::</c>-qualified type name appearing in a generated type expression.
    /// </summary>
    private static IEnumerable<string> GetGlobalTypeNames(string expression)
    {
        var index = 0;
        while (index < expression.Length)
        {
            var start = expression.IndexOf("global::", index, StringComparison.Ordinal);
            if (start < 0)
            {
                yield break;
            }

            var end = start + "global::".Length;
            while (end < expression.Length &&
                   (char.IsLetterOrDigit(expression[end]) || expression[end] == '_' || expression[end] == '.'))
            {
                end++;
            }

            yield return expression.Substring(start, end - start);
            index = end;
        }
    }

    private static IEnumerable<string> GetReferencedTypeNames(ModelData model)
    {
        foreach (var property in model.Properties)
        {
            foreach (var name in Flatten(property.Type, depth: 0))
            {
                yield return name;
            }
        }

        if (!string.IsNullOrWhiteSpace(model.BaseClass))
        {
            yield return model.BaseClass;
        }

        foreach (var derived in model.DerivedTypes)
        {
            yield return derived.GlobalClassName;
        }
    }

    /// <summary>
    /// A type and every type named inside it, so <c>IList&lt;Owned&gt;</c> counts as referencing
    /// <c>Owned</c>.
    /// </summary>
    private static IEnumerable<string> Flatten(TypeData type, int depth)
    {
        if (depth > 16)
        {
            yield break;
        }

        yield return type.CSharpTypeWithoutNullability;

        foreach (var subType in type.SubTypes)
        {
            foreach (var name in Flatten(subType.Unbox<TypeData>(), depth + 1))
            {
                yield return name;
            }
        }
    }

    /// <summary>
    /// The tag whose package a generated type belongs in, or <see langword="null"/> for Core.
    /// </summary>
    /// <remarks>
    /// Also resolves composite types — arrays, dictionaries, union closures — from the names
    /// inside them, so an <c>IList&lt;OwnedModel&gt;</c> registration follows the model it names
    /// instead of being left behind in Core where the type is not visible. The names are tokenized
    /// rather than substring-matched: <c>GitHub.Topic</c> is a prefix of
    /// <c>GitHub.TopicSearchResultItem</c>, and matching on that put registrations in a package
    /// that could not see the type. A composite naming models owned by two different tags belongs
    /// to neither, so it stays in Core.
    /// </remarks>
    public static string? ResolveTypeOwner(
        string csharpTypeWithoutNullability,
        IReadOnlyDictionary<string, string> owners)
    {
        owners = owners ?? throw new ArgumentNullException(nameof(owners));

        if (string.IsNullOrWhiteSpace(csharpTypeWithoutNullability))
        {
            return null;
        }

        if (owners.TryGetValue(csharpTypeWithoutNullability, out var tag))
        {
            return tag;
        }

        string? resolved = null;
        foreach (var name in GetGlobalTypeNames(csharpTypeWithoutNullability))
        {
            if (!owners.TryGetValue(name, out var owner))
            {
                continue;
            }

            if (resolved is not null &&
                !string.Equals(resolved, owner, StringComparison.Ordinal))
            {
                return null;
            }

            resolved = owner;
        }

        return resolved;
    }

    /// <summary>
    /// The generated JSON converters each owning tag takes with its models.
    /// </summary>
    /// <remarks>
    /// Built from the models rather than by matching converter names, so it stays in step with the
    /// list <c>Data</c> assembles. A converter registered in a package that cannot see its target
    /// type would not compile, and one registered nowhere would silently change serialization.
    /// </remarks>
    public static IReadOnlyDictionary<string, ImmutableArray<string>> ResolveConverters(
        Data data,
        IReadOnlyDictionary<string, string> owners)
    {
        owners = owners ?? throw new ArgumentNullException(nameof(owners));

        var byTag = new Dictionary<string, List<string>>(StringComparer.Ordinal);

        foreach (var value in data.Enums)
        {
            if (value.Style != ModelStyle.Enumeration ||
                !owners.TryGetValue(value.GlobalClassName, out var tag))
            {
                continue;
            }

            Add(byTag, tag, $"global::{value.Namespace}.JsonConverters.{value.ClassName}JsonConverter");
            Add(byTag, tag, $"global::{value.Namespace}.JsonConverters.{value.ClassName}NullableJsonConverter");
        }

        foreach (var value in data.AnyOfs)
        {
            if (!value.IsNamed ||
                !value.Settings.UsesSystemTextJson() ||
                !owners.TryGetValue($"global::{value.Namespace}.{value.Name}", out var tag))
            {
                continue;
            }

            Add(byTag, tag, $"global::{value.Namespace}.JsonConverters.{value.Name}JsonConverter");
        }

        // Anonymous union converters are generic instantiations rather than named types, so they
        // are placed by the arguments they close over. Resolve returns null unless every owned
        // argument agrees, which is exactly when one package can see them all.
        var byModel = new HashSet<string>(byTag.Values.SelectMany(static x => x), StringComparer.Ordinal);
        foreach (var converter in data.Converters.Converters)
        {
            if (!byModel.Contains(converter) &&
                ResolveTypeOwner(converter, owners) is { } converterTag)
            {
                Add(byTag, converterTag, converter);
            }
        }

        var result = new Dictionary<string, ImmutableArray<string>>(byTag.Count, StringComparer.Ordinal);
        foreach (var pair in byTag)
        {
            result[pair.Key] = pair.Value.ToImmutableArray();
        }

        return result;
    }

    private static void Add(Dictionary<string, List<string>> byTag, string tag, string converter)
    {
        if (!byTag.TryGetValue(tag, out var converters))
        {
            converters = [];
            byTag[tag] = converters;
        }

        converters.Add(converter);
    }

    private static Dictionary<string, List<ModelData>> GroupByNesting(IReadOnlyList<ModelData> models)
    {
        var groups = new Dictionary<string, List<ModelData>>(StringComparer.Ordinal);
        foreach (var model in models)
        {
            // Unless the naming convention flattens them, an inline model is emitted as a nested
            // partial class inside its parents, and a nested partial cannot span assemblies.
            var key = model.Parents.Length == 0
                ? model.GlobalClassName
                : $"{model.Namespace}.{model.Parents[0].Unbox<ModelData>().ClassName}";

            if (!groups.TryGetValue(key, out var members))
            {
                members = [];
                groups[key] = members;
            }

            members.Add(model);
        }

        return groups;
    }

    private static string? ResolveUnanimousTag(
        List<ModelData> members,
        IReadOnlyDictionary<string, ImmutableArray<string>> ownership)
    {
        string? tag = null;
        foreach (var member in members)
        {
            var memberTag = ResolveSingleTag(member.GlobalClassName, ownership);
            if (memberTag is null ||
                (tag is not null && !string.Equals(tag, memberTag, StringComparison.Ordinal)))
            {
                return null;
            }

            tag = memberTag;
        }

        return tag;
    }

    private static string? ResolveSingleTag(
        string globalClassName,
        IReadOnlyDictionary<string, ImmutableArray<string>> ownership)
    {
        return ownership.TryGetValue(globalClassName, out var tags) && tags.Length == 1
            ? tags[0]
            : null;
    }
}
