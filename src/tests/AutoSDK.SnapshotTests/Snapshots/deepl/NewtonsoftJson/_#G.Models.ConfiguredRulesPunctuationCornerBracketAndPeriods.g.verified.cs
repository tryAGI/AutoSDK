//HintName: G.Models.ConfiguredRulesPunctuationCornerBracketAndPeriods.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Corner Bracket And Periods
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationCornerBracketAndPeriods
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="add_period_after_closing_corner_bracket_at_end_of_sentence")]
        AddPeriodAfterClosingCornerBracketAtEndOfSentence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationCornerBracketAndPeriodsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationCornerBracketAndPeriods value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationCornerBracketAndPeriods.AddPeriodAfterClosingCornerBracketAtEndOfSentence => "add_period_after_closing_corner_bracket_at_end_of_sentence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationCornerBracketAndPeriods? ToEnum(string value)
        {
            return value switch
            {
                "add_period_after_closing_corner_bracket_at_end_of_sentence" => ConfiguredRulesPunctuationCornerBracketAndPeriods.AddPeriodAfterClosingCornerBracketAtEndOfSentence,
                _ => null,
            };
        }
    }
}