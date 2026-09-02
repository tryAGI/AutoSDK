using System.Text.Json;

namespace AutoSDK.CLI.Commands;

/// <summary>
/// Reads the optional <c>--package-map</c> override file used by split-by-tags generation.
/// </summary>
/// <remarks>
/// Shape: <c>{"tags": {"&lt;openapi tag name&gt;": "&lt;PackageSuffix&gt;"}}</c>. Mapping several
/// tags to the same suffix groups them into one package; mapping a tag to a stable suffix keeps a
/// package name steady when the upstream spec renames its tags.
/// Parsed with <see cref="JsonDocument"/> rather than a serializer so the CLI stays
/// trimming/NativeAOT-safe without a serializer context entry.
/// </remarks>
internal static class PackageMapFile
{
    public static async Task<IReadOnlyDictionary<string, string>> ReadAsync(
        string path,
        CancellationToken cancellationToken = default)
    {
        var text = await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false);

        using var document = JsonDocument.Parse(text);
        if (document.RootElement.ValueKind != JsonValueKind.Object ||
            !document.RootElement.TryGetProperty("tags", out var tags) ||
            tags.ValueKind != JsonValueKind.Object)
        {
            throw new InvalidOperationException(
                $"'{path}' must be a JSON object with a \"tags\" object mapping OpenAPI tag names to package suffixes.");
        }

        var result = new Dictionary<string, string>(StringComparer.Ordinal);
        foreach (var property in tags.EnumerateObject())
        {
            if (property.Value.ValueKind != JsonValueKind.String)
            {
                throw new InvalidOperationException(
                    $"'{path}' maps tag '{property.Name}' to a {property.Value.ValueKind} value; package suffixes must be strings.");
            }

            result[property.Name] = property.Value.GetString() ?? string.Empty;
        }

        return result;
    }
}
