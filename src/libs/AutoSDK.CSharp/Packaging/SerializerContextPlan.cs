using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.Packaging;

/// <summary>
/// Groups metadata by the operations that need it. Shared models keep a shared context, while
/// independent operation graphs never fall back to the complete SDK.
/// </summary>
internal sealed class SerializerContextPlan
{
    internal sealed class Group(string name, EquatableArray<TypeData> types, ImmutableArray<string> converters)
    {
        internal string Name { get; } = name;
        internal EquatableArray<TypeData> Types { get; } = types;
        internal ImmutableArray<string> Converters { get; } = converters;
    }

    public IReadOnlyList<Group> Groups { get; }
    public IReadOnlyDictionary<string, string> ModelContexts { get; }
    public IReadOnlyDictionary<string, string[]> OperationContexts { get; }

    private SerializerContextPlan(
        IReadOnlyList<Group> groups,
        IReadOnlyDictionary<string, string> modelContexts,
        IReadOnlyDictionary<string, string[]> operationContexts)
    {
        Groups = groups;
        ModelContexts = modelContexts;
        OperationContexts = operationContexts;
    }

    public static SerializerContextPlan Create(Data data)
    {
        var types = new Dictionary<string, TypeData>(StringComparer.Ordinal);
        var edges = new Dictionary<string, HashSet<string>>(StringComparer.Ordinal);
        void AddType(TypeData type)
        {
            var name = type.CSharpTypeWithoutNullability;
            if (string.IsNullOrWhiteSpace(name))
            {
                return;
            }
            if (types.TryGetValue(name, out var existing))
            {
                // Both T and T? share the graph node, but a scope must register Nullable<T>
                // whenever any property uses it. Preserve reference-type reclassification too.
                if (existing.IsValueType && (!type.IsValueType ||
                    type.CSharpTypeWithNullability.EndsWith("?", StringComparison.Ordinal)))
                {
                    types[name] = type;
                }
                return;
            }
            types.Add(name, type);
            edges[name] = new HashSet<string>(StringComparer.Ordinal);
            foreach (var boxed in type.SubTypes)
            {
                var child = boxed.Unbox<TypeData>();
                AddType(child);
                if (!string.IsNullOrWhiteSpace(child.CSharpTypeWithoutNullability))
                {
                    edges[name].Add(child.CSharpTypeWithoutNullability);
                }
            }
        }

        foreach (var type in data.Types)
        {
            AddType(type);
        }
        foreach (var model in data.Classes.Concat(data.Enums))
        {
            foreach (var property in model.Properties)
            {
                AddType(property.Type);
            }
        }
        foreach (var union in data.AnyOfs.Where(static union => union.IsNamed))
        {
            if (union.DiscriminatorType is { } discriminator)
            {
                AddType(discriminator);
            }
            foreach (var property in union.Properties)
            {
                AddType(property.Type);
            }
        }
        // Use the emitted C# graph, including inheritance and discriminator variants. Schema
        // traversal is depth limited and cannot establish that an omitted reference is safe.
        foreach (var model in data.Classes.Concat(data.Enums))
        {
            if (!edges.TryGetValue(model.GlobalClassName, out var references))
            {
                continue;
            }
            foreach (var property in model.Properties)
            {
                references.Add(property.Type.CSharpTypeWithoutNullability);
            }
            references.Add(model.BaseClass);
            foreach (var derived in model.DerivedTypes)
            {
                references.Add(derived.GlobalClassName);
            }
        }
        foreach (var union in data.AnyOfs.Where(static union => union.IsNamed))
        {
            if (edges.TryGetValue($"global::{union.Namespace}.{union.Name}", out var references))
            {
                if (union.DiscriminatorType is { } discriminator)
                {
                    references.Add(discriminator.CSharpTypeWithoutNullability);
                }
                foreach (var property in union.Properties)
                {
                    references.Add(property.Type.CSharpTypeWithoutNullability);
                }
            }
        }
        foreach (var pair in edges)
        {
            foreach (var name in ModelOwnershipResolver.GetGlobalTypeNames(pair.Key))
            {
                if (types.ContainsKey(name) && !string.Equals(pair.Key, name, StringComparison.Ordinal))
                {
                    pair.Value.Add(name);
                }
            }
            pair.Value.RemoveWhere(name => !types.ContainsKey(name));
        }

        HashSet<string> Reach(IEnumerable<string> roots)
        {
            var result = new HashSet<string>(StringComparer.Ordinal);
            var pending = new Stack<string>(roots);
            while (pending.Count != 0)
            {
                var name = pending.Pop();
                if (!edges.TryGetValue(name, out var references) || !result.Add(name))
                {
                    continue;
                }
                foreach (var reference in references)
                {
                    pending.Push(reference);
                }
            }
            return result;
        }

        var operations = data.Methods
            .GroupBy(static method => method.Id, StringComparer.Ordinal)
            .OrderBy(static group => group.Key, StringComparer.Ordinal)
            .ToArray();
        var users = types.Keys.ToDictionary(static name => name, static _ => new List<int>(), StringComparer.Ordinal);
        var rootsByOperation = new Dictionary<string, string[]>(StringComparer.Ordinal);
        for (var index = 0; index < operations.Length; index++)
        {
            var roots = operations[index].SelectMany(GetOperationTypes)
                .Select(static type => type.CSharpTypeWithoutNullability)
                .Where(types.ContainsKey).Distinct(StringComparer.Ordinal).ToArray();
            rootsByOperation.Add(operations[index].Key, roots);
            foreach (var name in Reach(roots))
            {
                users[name].Add(index);
            }
        }

        // Only entry types need independently generated metadata. Internal model helpers reuse
        // the smallest existing graph containing that model; generating another complete STJ
        // closure for every internal type multiplies source compilation without improving endpoint
        // retention. No operation can reference the separate orphan context.
        var entryTypes = new HashSet<string>(rootsByOperation.Values.SelectMany(static roots => roots), StringComparer.Ordinal);
        var buckets = users.Where(pair => entryTypes.Contains(pair.Key))
            .GroupBy(pair => string.Join(",", pair.Value), StringComparer.Ordinal)
            .Select(static bucket => bucket.Select(static pair => pair.Key).OrderBy(static name => name, StringComparer.Ordinal).ToArray())
            .OrderBy(static bucket => bucket[0], StringComparer.Ordinal)
            .ToArray();
        var contextByType = new Dictionary<string, string>(StringComparer.Ordinal);
        var groups = new List<Group>(buckets.Length);
        var contextByClosure = new Dictionary<string, string>(StringComparer.Ordinal);
        foreach (var bucket in buckets)
        {
            var closure = Reach(bucket).OrderBy(static name => name, StringComparer.Ordinal).ToArray();
            var signature = string.Join("\n", closure);
            if (!contextByClosure.TryGetValue(signature, out var context))
            {
                context = GetContextName(data.Converters.Settings, "Graph", signature);
                contextByClosure.Add(signature, context);
                groups.Add(new Group(context,
                    closure.Select(name => types[name]).ToImmutableArray().AsEquatableArray(),
                    GetConverters(data, new HashSet<string>(closure, StringComparer.Ordinal))));
            }
            foreach (var name in bucket)
            {
                contextByType.Add(name, context);
            }
        }
        foreach (var group in groups.OrderBy(static group => group.Types.Length))
        {
            foreach (var type in group.Types)
            {
                if (!contextByType.ContainsKey(type.CSharpTypeWithoutNullability))
                {
                    contextByType.Add(type.CSharpTypeWithoutNullability, group.Name);
                }
            }
        }
        var orphanTypes = types.Keys.Where(name => !contextByType.ContainsKey(name)).ToArray();
        var sdkPrefix = "global::" + data.Converters.Settings.Namespace + ".";
        var orphanModels = new HashSet<string>(orphanTypes.Where(name =>
            ModelOwnershipResolver.GetGlobalTypeNames(name).Any(globalName =>
                globalName.StartsWith(sdkPrefix, StringComparison.Ordinal))), StringComparer.Ordinal);
        var neighbors = orphanModels.ToDictionary(static name => name,
            static _ => new HashSet<string>(StringComparer.Ordinal), StringComparer.Ordinal);
        foreach (var name in orphanModels)
        {
            foreach (var dependency in edges[name].Where(orphanModels.Contains))
            {
                neighbors[name].Add(dependency);
                neighbors[dependency].Add(name);
            }
        }
        var remaining = new HashSet<string>(orphanModels, StringComparer.Ordinal);
        var orphanComponents = new List<string[]>();
        foreach (var seed in orphanModels.OrderBy(static name => name, StringComparer.Ordinal))
        {
            if (!remaining.Remove(seed))
            {
                continue;
            }
            var component = new List<string> { seed };
            var pending = new Stack<string>();
            pending.Push(seed);
            while (pending.Count != 0)
            {
                foreach (var neighbor in neighbors[pending.Pop()])
                {
                    if (remaining.Remove(neighbor))
                    {
                        component.Add(neighbor);
                        pending.Push(neighbor);
                    }
                }
            }
            orphanComponents.Add(component.ToArray());
        }
        var intrinsicOrphans = orphanTypes.Where(name => !orphanModels.Contains(name)).ToArray();
        if (intrinsicOrphans.Length != 0)
        {
            orphanComponents.Add(intrinsicOrphans);
        }
        foreach (var component in orphanComponents)
        {
            var closure = Reach(component).OrderBy(static name => name, StringComparer.Ordinal).ToArray();
            var context = GetContextName(data.Converters.Settings, "Orphans", string.Join("\n", closure));
            groups.Add(new Group(context, closure.Select(name => types[name]).ToImmutableArray().AsEquatableArray(),
                GetConverters(data, new HashSet<string>(closure, StringComparer.Ordinal))));
            foreach (var name in component)
            {
                contextByType.Add(name, context);
            }
        }
        var contextsByOperation = rootsByOperation.ToDictionary(
            static pair => pair.Key,
            pair => pair.Value.Select(name => contextByType[name]).Distinct(StringComparer.Ordinal).ToArray(),
            StringComparer.Ordinal);
        return new SerializerContextPlan(groups, contextByType, contextsByOperation);
    }

    internal static string GetContextName(Settings settings, string kind, string identity)
    {
        var bytes = System.Text.Encoding.UTF8.GetBytes(identity);
#if NET5_0_OR_GREATER
        var hash = System.Security.Cryptography.SHA256.HashData(bytes);
        var suffix = Convert.ToHexString(hash, 0, 8);
#else
        using var algorithm = System.Security.Cryptography.SHA256.Create();
        var hash = algorithm.ComputeHash(bytes);
        var suffix = BitConverter.ToString(hash, 0, 8).Replace("-", string.Empty);
#endif
        return settings.JsonSerializerContext + kind + "_" + suffix;
    }

    private static IEnumerable<TypeData> GetOperationTypes(EndPoint method)
    {
        yield return method.RequestType;
        yield return method.RequestInitializationType;
        yield return method.SuccessResponse.Type;
        foreach (var response in method.ErrorResponses)
        {
            yield return response.Type;
        }
        foreach (var parameter in method.Parameters)
        {
            yield return parameter.Type;
        }
    }

    private static ImmutableArray<string> GetConverters(Data data, HashSet<string> closure)
    {
        var targets = new Dictionary<string, string>(StringComparer.Ordinal);
        foreach (var model in data.Enums.Where(static model => model.Style == ModelStyle.Enumeration))
        {
            targets[$"global::{model.Namespace}.JsonConverters.{model.ClassName}JsonConverter"] = model.GlobalClassName;
            targets[$"global::{model.Namespace}.JsonConverters.{model.ClassName}NullableJsonConverter"] = model.GlobalClassName;
        }
        foreach (var union in data.AnyOfs.Where(static union => union.IsNamed))
        {
            targets[$"global::{union.Namespace}.JsonConverters.{union.Name}JsonConverter"] = $"global::{union.Namespace}.{union.Name}";
        }

        return data.Converters.Converters.Where(converter =>
        {
            if (targets.TryGetValue(converter, out var target))
            {
                return closure.Contains(target);
            }
            var generic = converter.IndexOf('<');
            if (generic >= 0)
            {
                // Anonymous union converters name their exact closed union, including primitive
                // arguments. Looking only for model arguments treats primitive unions as global.
                var converterName = converter.Substring(0, generic);
                const string marker = ".JsonConverters.";
                var position = converterName.LastIndexOf(marker, StringComparison.Ordinal);
                if (position >= 0 && converterName.EndsWith("JsonConverter", StringComparison.Ordinal))
                {
                    var unionName = converterName.Substring(0, position) + "." +
                        converterName.Substring(position + marker.Length);
                    unionName = unionName.Substring(0, unionName.Length - "JsonConverter".Length) + converter.Substring(generic);
                    return closure.Contains(unionName);
                }
            }
            // Unix timestamps and other runtime converters do not refer to SDK model types.
            return true;
        }).ToImmutableArray();
    }
}
