//HintName: G.Models.ConfiguredRulesNumbersReferenceToSymbol.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Reference To Symbol
    /// </summary>
    public enum ConfiguredRulesNumbersReferenceToSymbol
    {
        /// <summary>
        /// 
        /// </summary>
        SpellOutSymbolNameFollowedBySymbolInParentheses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersReferenceToSymbolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersReferenceToSymbol value)
        {
            return value switch
            {
                ConfiguredRulesNumbersReferenceToSymbol.SpellOutSymbolNameFollowedBySymbolInParentheses => "spell_out_symbol_name_followed_by_symbol_in_parentheses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersReferenceToSymbol? ToEnum(string value)
        {
            return value switch
            {
                "spell_out_symbol_name_followed_by_symbol_in_parentheses" => ConfiguredRulesNumbersReferenceToSymbol.SpellOutSymbolNameFollowedBySymbolInParentheses,
                _ => null,
            };
        }
    }
}