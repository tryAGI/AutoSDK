//HintName: G.Models.ConfiguredRulesVocabularyAbbreviations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Abbreviations
    /// </summary>
    public enum ConfiguredRulesVocabularyAbbreviations
    {
        /// <summary>
        /// 
        /// </summary>
        WriteOriginalTermThenAbbreviationAndExplanation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesVocabularyAbbreviationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesVocabularyAbbreviations value)
        {
            return value switch
            {
                ConfiguredRulesVocabularyAbbreviations.WriteOriginalTermThenAbbreviationAndExplanation => "write_original_term_then_abbreviation_and_explanation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesVocabularyAbbreviations? ToEnum(string value)
        {
            return value switch
            {
                "write_original_term_then_abbreviation_and_explanation" => ConfiguredRulesVocabularyAbbreviations.WriteOriginalTermThenAbbreviationAndExplanation,
                _ => null,
            };
        }
    }
}