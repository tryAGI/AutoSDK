namespace AutoSDK.Models;

public sealed class GeneratedSdkSnippetManifest
{
    public GeneratedSdkSnippetManifest(IReadOnlyList<GeneratedSdkSnippetDocument> examples)
    {
        Examples = examples;
    }

    public IReadOnlyList<GeneratedSdkSnippetDocument> Examples { get; set; }

    public static GeneratedSdkSnippetManifest Empty { get; } = new([]);
}

public sealed class GeneratedSdkSnippetDocument
{
    public GeneratedSdkSnippetDocument(
        int order,
        string title,
        string slug,
        string description,
        string language,
        string code,
        string format,
        string operationId,
        string? setup = null)
    {
        Order = order;
        Title = title;
        Slug = slug;
        Description = description;
        Language = language;
        Code = code;
        Format = format;
        OperationId = operationId;
        Setup = setup;
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }
    public string Language { get; set; }
    public string Code { get; set; }
    public string Format { get; set; }
    public string OperationId { get; set; }
    public string? Setup { get; set; }
}
