namespace AutoSDK.Models;

public sealed record GeneratedSdkSnippetManifest(
    IReadOnlyList<GeneratedSdkSnippetDocument> Examples)
{
    public static GeneratedSdkSnippetManifest Empty { get; } = new([]);
}

public sealed record GeneratedSdkSnippetDocument(
    int Order,
    string Title,
    string Slug,
    string Description,
    string Language,
    string Code,
    string Format,
    string OperationId,
    string? Setup = null);
