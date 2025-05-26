using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace AutoSDK.GeneratorTests.Helpers;

public class AdditionalTextOptionsProvider : AnalyzerConfigOptionsProvider
{
    private readonly Dictionary<string, string> globalOptions = [];

    public AdditionalTextOptionsProvider(Dictionary<string, string>? globalOptions = null)
    {
        if (globalOptions is not null && globalOptions.Count != 0)
        {
            this.globalOptions = globalOptions.
                ToDictionary(
                    k => $"build_property.AutoSDK_{k.Key}",
                    v => v.Value
                );
        }
    }
    public override AnalyzerConfigOptions GlobalOptions => new DictionaryAnalyzerConfigOptions(globalOptions);

    //
    // Summary:
    //     Gets options for a given file.
    public override AnalyzerConfigOptions GetOptions(AdditionalText textFile)
    {
        if (textFile is not CustomAdditionalText customTextFile)
        {
            throw new ArgumentException("Invalid type", nameof(textFile));
        }
        return new DictionaryAnalyzerConfigOptions(
            customTextFile.Options
                .ToDictionary(
                    k => $"build_metadata.AdditionalFiles.AutoSDK_{k.Key}",
                    v => v.Value
                )
        );
    }

    public override AnalyzerConfigOptions GetOptions(SyntaxTree tree)
    {
        return new DictionaryAnalyzerConfigOptions([]);
    }
}
