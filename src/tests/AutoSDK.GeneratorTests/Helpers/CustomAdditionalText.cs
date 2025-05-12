using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace AutoSDK.GeneratorTests.Helpers;

public class CustomAdditionalText(string path, string text) : AdditionalText
{
    public string Text { get; } = text;

    public override string Path { get; } = path;

    public override SourceText GetText(CancellationToken cancellationToken = default)
    {
        return SourceText.From(Text);
    }

    public Dictionary<string, string> Options { get; } = new Dictionary<string, string>();
}
