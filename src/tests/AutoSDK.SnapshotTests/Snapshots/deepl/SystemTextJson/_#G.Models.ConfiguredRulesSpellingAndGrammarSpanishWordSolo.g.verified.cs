//HintName: G.Models.ConfiguredRulesSpellingAndGrammarSpanishWordSolo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Spanish Word Solo
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarSpanishWordSolo
    {
        /// <summary>
        /// 
        /// </summary>
        NeverUseAcuteAccent,
        /// <summary>
        /// 
        /// </summary>
        UseAcuteAccentWhenUsedAsAdverb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarSpanishWordSoloExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarSpanishWordSolo value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarSpanishWordSolo.NeverUseAcuteAccent => "never_use_acute_accent",
                ConfiguredRulesSpellingAndGrammarSpanishWordSolo.UseAcuteAccentWhenUsedAsAdverb => "use_acute_accent_when_used_as_adverb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarSpanishWordSolo? ToEnum(string value)
        {
            return value switch
            {
                "never_use_acute_accent" => ConfiguredRulesSpellingAndGrammarSpanishWordSolo.NeverUseAcuteAccent,
                "use_acute_accent_when_used_as_adverb" => ConfiguredRulesSpellingAndGrammarSpanishWordSolo.UseAcuteAccentWhenUsedAsAdverb,
                _ => null,
            };
        }
    }
}