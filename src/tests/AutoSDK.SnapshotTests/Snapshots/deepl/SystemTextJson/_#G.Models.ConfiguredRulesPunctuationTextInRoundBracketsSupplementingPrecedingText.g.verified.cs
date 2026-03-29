//HintName: G.Models.ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Text In Round Brackets Supplementing Preceding Text
    /// </summary>
    public enum ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText
    {
        /// <summary>
        /// 
        /// </summary>
        AddPeriodAfterClosingRoundBracket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingTextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText.AddPeriodAfterClosingRoundBracket => "add_period_after_closing_round_bracket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText? ToEnum(string value)
        {
            return value switch
            {
                "add_period_after_closing_round_bracket" => ConfiguredRulesPunctuationTextInRoundBracketsSupplementingPrecedingText.AddPeriodAfterClosingRoundBracket,
                _ => null,
            };
        }
    }
}