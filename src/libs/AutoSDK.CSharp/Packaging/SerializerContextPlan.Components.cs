using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Packaging;

internal sealed partial class SerializerContextPlan
{
    private static SerializerContextPlan CreateComponents(
        Data data, IReadOnlyDictionary<string, TypeData> types,
        Dictionary<string, HashSet<string>> edges,
        IReadOnlyDictionary<string, string[]> rootsByOperation)
    {
        // Iterative Kosaraju avoids both a recursive resolver cycle and a planner stack limit
        // on deep schemas. A component owns its types; outgoing components remain references.
        var finish = new List<string>(types.Count);
        var visited = new HashSet<string>(StringComparer.Ordinal);
        foreach (var seed in types.Keys.OrderBy(static name => name, StringComparer.Ordinal))
        {
            if (!visited.Add(seed))
            {
                continue;
            }
            var pending = new Stack<(string Name, IEnumerator<string> Edges)>();
            pending.Push((seed, edges[seed].GetEnumerator()));
            while (pending.Count != 0)
            {
                var frame = pending.Peek();
                if (frame.Edges.MoveNext())
                {
                    var next = frame.Edges.Current;
                    if (visited.Add(next))
                    {
                        pending.Push((next, edges[next].GetEnumerator()));
                    }
                }
                else
                {
                    pending.Pop().Edges.Dispose();
                    finish.Add(frame.Name);
                }
            }
        }
        var reverse = types.Keys.ToDictionary(static name => name,
            static _ => new List<string>(), StringComparer.Ordinal);
        foreach (var pair in edges)
        {
            foreach (var dependency in pair.Value)
            {
                reverse[dependency].Add(pair.Key);
            }
        }
        visited.Clear();
        var components = new List<string[]>();
        for (var index = finish.Count - 1; index >= 0; index--)
        {
            var seed = finish[index];
            if (!visited.Add(seed))
            {
                continue;
            }
            var members = new List<string>();
            var pending = new Stack<string>();
            pending.Push(seed);
            while (pending.Count != 0)
            {
                var current = pending.Pop();
                members.Add(current);
                foreach (var next in reverse[current])
                {
                    if (visited.Add(next))
                    {
                        pending.Push(next);
                    }
                }
            }
            components.Add(members.OrderBy(static name => name, StringComparer.Ordinal).ToArray());
        }
        components = components.OrderBy(static members => members[0], StringComparer.Ordinal).ToList();
        var contextByType = new Dictionary<string, string>(StringComparer.Ordinal);
        foreach (var component in components)
        {
            var context = GetContextName(data.Converters.Settings, "Component", string.Join("\n", component));
            foreach (var name in component)
            {
                contextByType.Add(name, context);
            }
        }
        var converterLookup = new ComponentConverterLookup(data);
        var groups = new List<Group>(components.Count);
        foreach (var component in components)
        {
            var context = contextByType[component[0]];
            var dependencies = component.SelectMany(name => edges[name])
                .Select(name => contextByType[name])
                .Where(name => !string.Equals(name, context, StringComparison.Ordinal))
                .Distinct(StringComparer.Ordinal).OrderBy(static name => name, StringComparer.Ordinal)
                .ToImmutableArray();
            groups.Add(new Group(context, component.Select(name => types[name]).ToImmutableArray().AsEquatableArray(),
                converterLookup.Get(component), dependencies));
        }
        var contextsByOperation = rootsByOperation.ToDictionary(static pair => pair.Key,
            pair => pair.Value.Select(name => contextByType[name]).Distinct(StringComparer.Ordinal).ToArray(),
            StringComparer.Ordinal);
        return new SerializerContextPlan(groups, contextByType, contextsByOperation);
    }

    private sealed class ComponentConverterLookup
    {
        private readonly Dictionary<string, List<string>> _byType = new(StringComparer.Ordinal);
        private readonly Dictionary<string, int> _order = new(StringComparer.Ordinal);
        private readonly List<string> _intrinsic = [];

        internal ComponentConverterLookup(Data data)
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
            foreach (var converter in data.Converters.Converters.Distinct(StringComparer.Ordinal))
            {
                _order.Add(converter, _order.Count);
                if (!targets.TryGetValue(converter, out var target))
                {
                    var generic = converter.IndexOf('<');
                    var converterName = generic >= 0 ? converter.Substring(0, generic) : converter;
                    const string marker = ".JsonConverters.";
                    var position = converterName.LastIndexOf(marker, StringComparison.Ordinal);
                    if (generic >= 0 && position >= 0 &&
                        converterName.EndsWith("JsonConverter", StringComparison.Ordinal))
                    {
                        target = converterName.Substring(0, position) + "." +
                            converterName.Substring(position + marker.Length);
                        target = target.Substring(0, target.Length - "JsonConverter".Length) +
                            converter.Substring(generic);
                    }
                    else
                    {
                        _intrinsic.Add(converter);
                        continue;
                    }
                }
                if (!_byType.TryGetValue(target, out var converters))
                {
                    converters = [];
                    _byType.Add(target, converters);
                }
                converters.Add(converter);
            }
        }

        internal ImmutableArray<string> Get(IEnumerable<string> names)
        {
            var selected = new HashSet<string>(_intrinsic, StringComparer.Ordinal);
            foreach (var name in names)
            {
                if (_byType.TryGetValue(name, out var converters))
                {
                    selected.UnionWith(converters);
                }
            }
            return selected.OrderBy(converter => _order[converter]).ToImmutableArray();
        }
    }
}
