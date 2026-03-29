//HintName: G.Models.ConfiguredRulesSpellingAndGrammarEszett.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Eszett
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarEszett
    {
        /// <summary>
        /// 
        /// </summary>
        ReplaceEszettWithSs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarEszettExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarEszett value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarEszett.ReplaceEszettWithSs => "replace_eszett_with_ss",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarEszett? ToEnum(string value)
        {
            return value switch
            {
                "replace_eszett_with_ss" => ConfiguredRulesSpellingAndGrammarEszett.ReplaceEszettWithSs,
                _ => null,
            };
        }
    }
}