using System.Collections.Concurrent;

namespace AutoSDK.UnitTests;

internal static class TestSpecCache
{
    private static readonly ConcurrentDictionary<string, string> Cache = new(StringComparer.Ordinal);

    public static string GetText(string resourceName)
    {
        return Cache.GetOrAdd(resourceName, static name => new H.Resource(name).AsString());
    }
}
