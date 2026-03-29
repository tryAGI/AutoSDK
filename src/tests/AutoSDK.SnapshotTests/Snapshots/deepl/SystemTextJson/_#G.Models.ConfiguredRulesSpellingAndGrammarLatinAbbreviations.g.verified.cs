//HintName: G.Models.ConfiguredRulesSpellingAndGrammarLatinAbbreviations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Latin Abbreviations
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarLatinAbbreviations
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseLatinAbbreviations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarLatinAbbreviationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarLatinAbbreviations value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarLatinAbbreviations.DoNotUseLatinAbbreviations => "do_not_use_latin_abbreviations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarLatinAbbreviations? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_latin_abbreviations" => ConfiguredRulesSpellingAndGrammarLatinAbbreviations.DoNotUseLatinAbbreviations,
                _ => null,
            };
        }
    }
}