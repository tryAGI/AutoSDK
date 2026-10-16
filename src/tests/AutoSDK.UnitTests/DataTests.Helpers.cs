using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public partial class DataTests : VerifyBase
{
    private Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "netstandard2.0",
        Namespace = "G",
        ClassName = "Api",
        ClsCompliantEnumPrefix = "x",
    };

    private Task VerifyAsync(
        Data data,
        string resourceName)
    {
        var schemaStrings = ToSchemaStrings(data.Schemas);
        var schemasTask =
            Verify(schemaStrings)
                .UseDirectory($"Snapshots/{resourceName}/Schemas")
                .UseFileName("_");
        var resolvedSchemasTask =
            Verify(ToResolvedStrings(data.FilteredSchemas.Where(x => x.Parent == null), data.FilteredSchemas.Count))
                .UseDirectory($"Snapshots/{resourceName}/ResolvedSchemas")
                .UseFileName("_");
        
        return Task.WhenAll(schemasTask, resolvedSchemasTask);
    }

    private static List<string> ToSchemaStrings(IReadOnlyList<SchemaContext> schemas)
    {
        var result = new List<string>(schemas.Count);
        var depthCache = new Dictionary<SchemaContext, int>(ReferenceEqualityComparer.Instance);
        var indentCache = new List<string> { string.Empty };

        foreach (var context in schemas)
        {
            var depth = GetDepth(context, depthCache);
            result.Add($"{GetIndent(depth, indentCache)}{context.Id}({context.Type})");
        }

        return result;
    }

    private static int GetDepth(SchemaContext context, Dictionary<SchemaContext, int> depthCache)
    {
        if (depthCache.TryGetValue(context, out var depth))
        {
            return depth;
        }

        depth = context.Parent is null
            ? 0
            : GetDepth(context.Parent, depthCache) + 1;
        depthCache[context] = depth;
        return depth;
    }

    private static List<string> ToResolvedStrings(IEnumerable<SchemaContext> contexts, int capacity)
    {
        var result = new List<string>(capacity);
        var indentCache = new List<string> { string.Empty };
        AddResolvedStrings(result, contexts, depth: 0, indentCache);
        return result;
    }

    private static void AddResolvedStrings(
        List<string> result,
        IEnumerable<SchemaContext> contexts,
        int depth,
        List<string> indentCache)
    {
        foreach (var context in contexts)
        {
            result.Add($"{GetIndent(depth, indentCache)}{context.Id}({context.Type})[{FormatTags(context.Tags)}]");
            AddResolvedStrings(result, context.Children, depth + 1, indentCache);
        }
    }

    private static string GetIndent(int depth, List<string> indentCache)
    {
        while (indentCache.Count <= depth)
        {
            indentCache.Add(new string(' ', indentCache.Count * 2));
        }

        return indentCache[depth];
    }

    private static string FormatTags(IEnumerable<string> tags)
    {
        using var enumerator = tags.GetEnumerator();
        if (!enumerator.MoveNext())
        {
            return string.Empty;
        }

        var first = enumerator.Current;
        if (!enumerator.MoveNext())
        {
            return first;
        }

        var builder = new System.Text.StringBuilder(first);
        do
        {
            builder.Append(", ");
            builder.Append(enumerator.Current);
        }
        while (enumerator.MoveNext());

        return builder.ToString();
    }
}
