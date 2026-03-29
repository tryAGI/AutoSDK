//HintName: G.Models.ConfiguredRulesFormattingEmailAddressFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Email Address Format
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesFormattingEmailAddressFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="place_domain_in_parentheses")]
        PlaceDomainInParentheses,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="replace_at_symbol_with_english_word_at_in_brackets_and_replace_periods_with_english_word_dot_in_brackets")]
        ReplaceAtSymbolWithEnglishWordAtInBracketsAndReplacePeriodsWithEnglishWordDotInBrackets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="replace_at_symbol_with_english_word_at_in_brackets_with_space_on_either_side")]
        ReplaceAtSymbolWithEnglishWordAtInBracketsWithSpaceOnEitherSide,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="replace_at_symbol_with_english_word_at_in_parentheses_with_space_on_either_side")]
        ReplaceAtSymbolWithEnglishWordAtInParenthesesWithSpaceOnEitherSide,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="replace_at_symbol_with_english_word_at_with_space_on_either_side")]
        ReplaceAtSymbolWithEnglishWordAtWithSpaceOnEitherSide,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_standard_format")]
        UseStandardFormat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesFormattingEmailAddressFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesFormattingEmailAddressFormat value)
        {
            return value switch
            {
                ConfiguredRulesFormattingEmailAddressFormat.PlaceDomainInParentheses => "place_domain_in_parentheses",
                ConfiguredRulesFormattingEmailAddressFormat.ReplaceAtSymbolWithEnglishWordAtInBracketsAndReplacePeriodsWithEnglishWordDotInBrackets => "replace_at_symbol_with_english_word_at_in_brackets_and_replace_periods_with_english_word_dot_in_brackets",
                ConfiguredRulesFormattingEmailAddressFormat.ReplaceAtSymbolWithEnglishWordAtInBracketsWithSpaceOnEitherSide => "replace_at_symbol_with_english_word_at_in_brackets_with_space_on_either_side",
                ConfiguredRulesFormattingEmailAddressFormat.ReplaceAtSymbolWithEnglishWordAtInParenthesesWithSpaceOnEitherSide => "replace_at_symbol_with_english_word_at_in_parentheses_with_space_on_either_side",
                ConfiguredRulesFormattingEmailAddressFormat.ReplaceAtSymbolWithEnglishWordAtWithSpaceOnEitherSide => "replace_at_symbol_with_english_word_at_with_space_on_either_side",
                ConfiguredRulesFormattingEmailAddressFormat.UseStandardFormat => "use_standard_format",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesFormattingEmailAddressFormat? ToEnum(string value)
        {
            return value switch
            {
                "place_domain_in_parentheses" => ConfiguredRulesFormattingEmailAddressFormat.PlaceDomainInParentheses,
                "replace_at_symbol_with_english_word_at_in_brackets_and_replace_periods_with_english_word_dot_in_brackets" => ConfiguredRulesFormattingEmailAddressFormat.ReplaceAtSymbolWithEnglishWordAtInBracketsAndReplacePeriodsWithEnglishWordDotInBrackets,
                "replace_at_symbol_with_english_word_at_in_brackets_with_space_on_either_side" => ConfiguredRulesFormattingEmailAddressFormat.ReplaceAtSymbolWithEnglishWordAtInBracketsWithSpaceOnEitherSide,
                "replace_at_symbol_with_english_word_at_in_parentheses_with_space_on_either_side" => ConfiguredRulesFormattingEmailAddressFormat.ReplaceAtSymbolWithEnglishWordAtInParenthesesWithSpaceOnEitherSide,
                "replace_at_symbol_with_english_word_at_with_space_on_either_side" => ConfiguredRulesFormattingEmailAddressFormat.ReplaceAtSymbolWithEnglishWordAtWithSpaceOnEitherSide,
                "use_standard_format" => ConfiguredRulesFormattingEmailAddressFormat.UseStandardFormat,
                _ => null,
            };
        }
    }
}