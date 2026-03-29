//HintName: G.Models.ConfiguredRulesSpellingAndGrammarCompoundNouns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Compound Nouns
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarCompoundNouns
    {
        /// <summary>
        /// 
        /// </summary>
        WriteAsOneWord,
        /// <summary>
        /// 
        /// </summary>
        WriteWithHyphen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarCompoundNounsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarCompoundNouns value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarCompoundNouns.WriteAsOneWord => "write_as_one_word",
                ConfiguredRulesSpellingAndGrammarCompoundNouns.WriteWithHyphen => "write_with_hyphen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarCompoundNouns? ToEnum(string value)
        {
            return value switch
            {
                "write_as_one_word" => ConfiguredRulesSpellingAndGrammarCompoundNouns.WriteAsOneWord,
                "write_with_hyphen" => ConfiguredRulesSpellingAndGrammarCompoundNouns.WriteWithHyphen,
                _ => null,
            };
        }
    }
}