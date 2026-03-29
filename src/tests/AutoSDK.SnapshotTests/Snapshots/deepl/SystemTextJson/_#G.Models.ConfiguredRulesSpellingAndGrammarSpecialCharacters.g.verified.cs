//HintName: G.Models.ConfiguredRulesSpellingAndGrammarSpecialCharacters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Special Characters
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarSpecialCharacters
    {
        /// <summary>
        /// 
        /// </summary>
        NeverUseSymbols,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarSpecialCharactersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarSpecialCharacters value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarSpecialCharacters.NeverUseSymbols => "never_use_symbols",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarSpecialCharacters? ToEnum(string value)
        {
            return value switch
            {
                "never_use_symbols" => ConfiguredRulesSpellingAndGrammarSpecialCharacters.NeverUseSymbols,
                _ => null,
            };
        }
    }
}