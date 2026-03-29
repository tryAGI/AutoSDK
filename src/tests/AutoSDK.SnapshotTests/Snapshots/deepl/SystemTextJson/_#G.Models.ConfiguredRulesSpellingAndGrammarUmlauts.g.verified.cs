//HintName: G.Models.ConfiguredRulesSpellingAndGrammarUmlauts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Umlauts
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarUmlauts
    {
        /// <summary>
        /// 
        /// </summary>
        ReplaceUmlautsWithAeOeUe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarUmlautsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarUmlauts value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarUmlauts.ReplaceUmlautsWithAeOeUe => "replace_umlauts_with_ae_oe_ue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarUmlauts? ToEnum(string value)
        {
            return value switch
            {
                "replace_umlauts_with_ae_oe_ue" => ConfiguredRulesSpellingAndGrammarUmlauts.ReplaceUmlautsWithAeOeUe,
                _ => null,
            };
        }
    }
}