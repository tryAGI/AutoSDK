//HintName: G.Models.ConfiguredRulesPunctuationCornerBracketsAndPeriods.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Corner Brackets And Periods
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationCornerBracketsAndPeriods
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_add_period_before_closing_corner_bracket_when_sentence_continues")]
        DoNotAddPeriodBeforeClosingCornerBracketWhenSentenceContinues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationCornerBracketsAndPeriodsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationCornerBracketsAndPeriods value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationCornerBracketsAndPeriods.DoNotAddPeriodBeforeClosingCornerBracketWhenSentenceContinues => "do_not_add_period_before_closing_corner_bracket_when_sentence_continues",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationCornerBracketsAndPeriods? ToEnum(string value)
        {
            return value switch
            {
                "do_not_add_period_before_closing_corner_bracket_when_sentence_continues" => ConfiguredRulesPunctuationCornerBracketsAndPeriods.DoNotAddPeriodBeforeClosingCornerBracketWhenSentenceContinues,
                _ => null,
            };
        }
    }
}