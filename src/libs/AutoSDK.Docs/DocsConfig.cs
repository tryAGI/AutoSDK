using System.Text.Json;

namespace AutoSDK.Docs;

public sealed record DocsConfig
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true,
    };

    public string? BrandName { get; init; }

    public string? Namespace { get; init; }

    public string? ClientClassName { get; init; }

    public string? ApiKeyVariableName { get; init; }

    public string? ExampleIntro { get; init; }

    public string? ExampleSourceDirectory { get; init; }

    public string? DocsExamplesDirectory { get; init; }

    public string? ReadmeExamplesStartMarker { get; init; }

    public string? ReadmeExamplesEndMarker { get; init; }

    public string? MkDocsExamplesStartMarker { get; init; }

    public string? MkDocsExamplesEndMarker { get; init; }

    public Dictionary<string, string>? ClientReplacements { get; init; }

    public static async Task<DocsConfig> LoadAsync(
        string solutionDirectory,
        string? configPath = null,
        CancellationToken cancellationToken = default)
    {
        var resolvedPath = GetConfigPath(solutionDirectory, configPath);
        if (!File.Exists(resolvedPath))
        {
            return new DocsConfig();
        }

        var json = await File.ReadAllTextAsync(resolvedPath, cancellationToken).ConfigureAwait(false);
        var config = JsonSerializer.Deserialize<DocsConfig>(json, SerializerOptions);

        return config ?? new DocsConfig();
    }

    private static string GetConfigPath(string solutionDirectory, string? configPath)
    {
        if (string.IsNullOrWhiteSpace(configPath))
        {
            return Path.Combine(solutionDirectory, "autosdk.docs.json");
        }

        return Path.IsPathRooted(configPath)
            ? configPath
            : Path.GetFullPath(Path.Combine(solutionDirectory, configPath));
    }
}
