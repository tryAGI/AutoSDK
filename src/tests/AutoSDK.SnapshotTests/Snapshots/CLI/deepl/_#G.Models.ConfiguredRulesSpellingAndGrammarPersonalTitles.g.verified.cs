//HintName: G.Models.ConfiguredRulesSpellingAndGrammarPersonalTitles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Personal Titles
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarPersonalTitles
    {
        /// <summary>
        /// 
        /// </summary>
        Abbreviate,
        /// <summary>
        /// 
        /// </summary>
        DoNotAbbreviate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarPersonalTitlesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarPersonalTitles value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarPersonalTitles.Abbreviate => "abbreviate",
                ConfiguredRulesSpellingAndGrammarPersonalTitles.DoNotAbbreviate => "do_not_abbreviate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarPersonalTitles? ToEnum(string value)
        {
            return value switch
            {
                "abbreviate" => ConfiguredRulesSpellingAndGrammarPersonalTitles.Abbreviate,
                "do_not_abbreviate" => ConfiguredRulesSpellingAndGrammarPersonalTitles.DoNotAbbreviate,
                _ => null,
            };
        }
    }
}