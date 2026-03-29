//HintName: G.Models.ConfiguredRulesPunctuationBracket.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Bracket
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationBracket
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_hexagonal_brackets")]
        UseHexagonalBrackets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_lenticular_brackets")]
        UseLenticularBrackets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_parentheses")]
        UseParentheses,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_square_brackets_for_nationality_and_hexagonal_brackets_for_historical_period")]
        UseSquareBracketsForNationalityAndHexagonalBracketsForHistoricalPeriod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationBracketExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationBracket value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationBracket.UseHexagonalBrackets => "use_hexagonal_brackets",
                ConfiguredRulesPunctuationBracket.UseLenticularBrackets => "use_lenticular_brackets",
                ConfiguredRulesPunctuationBracket.UseParentheses => "use_parentheses",
                ConfiguredRulesPunctuationBracket.UseSquareBracketsForNationalityAndHexagonalBracketsForHistoricalPeriod => "use_square_brackets_for_nationality_and_hexagonal_brackets_for_historical_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationBracket? ToEnum(string value)
        {
            return value switch
            {
                "use_hexagonal_brackets" => ConfiguredRulesPunctuationBracket.UseHexagonalBrackets,
                "use_lenticular_brackets" => ConfiguredRulesPunctuationBracket.UseLenticularBrackets,
                "use_parentheses" => ConfiguredRulesPunctuationBracket.UseParentheses,
                "use_square_brackets_for_nationality_and_hexagonal_brackets_for_historical_period" => ConfiguredRulesPunctuationBracket.UseSquareBracketsForNationalityAndHexagonalBracketsForHistoricalPeriod,
                _ => null,
            };
        }
    }
}