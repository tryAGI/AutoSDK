//HintName: G.Models.ConfiguredRulesSpellingAndGrammarCompleteSentences.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Complete Sentences
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarCompleteSentences
    {
        /// <summary>
        /// 
        /// </summary>
        AlwaysWriteCompleteSentences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarCompleteSentencesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarCompleteSentences value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarCompleteSentences.AlwaysWriteCompleteSentences => "always_write_complete_sentences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarCompleteSentences? ToEnum(string value)
        {
            return value switch
            {
                "always_write_complete_sentences" => ConfiguredRulesSpellingAndGrammarCompleteSentences.AlwaysWriteCompleteSentences,
                _ => null,
            };
        }
    }
}