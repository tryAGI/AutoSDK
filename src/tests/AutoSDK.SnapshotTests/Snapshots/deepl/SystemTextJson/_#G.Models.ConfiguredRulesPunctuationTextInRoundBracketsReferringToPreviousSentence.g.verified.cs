//HintName: G.Models.ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Text In Round Brackets Referring To Previous Sentence
    /// </summary>
    public enum ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence
    {
        /// <summary>
        /// 
        /// </summary>
        AddPeriodAfterClosingRoundBracket,
        /// <summary>
        /// 
        /// </summary>
        AddPeriodBeforeClosingRoundBracket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence.AddPeriodAfterClosingRoundBracket => "add_period_after_closing_round_bracket",
                ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence.AddPeriodBeforeClosingRoundBracket => "add_period_before_closing_round_bracket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence? ToEnum(string value)
        {
            return value switch
            {
                "add_period_after_closing_round_bracket" => ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence.AddPeriodAfterClosingRoundBracket,
                "add_period_before_closing_round_bracket" => ConfiguredRulesPunctuationTextInRoundBracketsReferringToPreviousSentence.AddPeriodBeforeClosingRoundBracket,
                _ => null,
            };
        }
    }
}