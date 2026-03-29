//HintName: G.Models.ConfiguredRulesPunctuationFullSentenceInRoundBrackets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Full Sentence In Round Brackets
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationFullSentenceInRoundBrackets
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="add_period_before_closing_round_bracket")]
        AddPeriodBeforeClosingRoundBracket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationFullSentenceInRoundBracketsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationFullSentenceInRoundBrackets value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationFullSentenceInRoundBrackets.AddPeriodBeforeClosingRoundBracket => "add_period_before_closing_round_bracket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationFullSentenceInRoundBrackets? ToEnum(string value)
        {
            return value switch
            {
                "add_period_before_closing_round_bracket" => ConfiguredRulesPunctuationFullSentenceInRoundBrackets.AddPeriodBeforeClosingRoundBracket,
                _ => null,
            };
        }
    }
}