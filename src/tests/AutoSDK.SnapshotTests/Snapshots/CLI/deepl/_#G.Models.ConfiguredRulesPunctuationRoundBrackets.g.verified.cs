//HintName: G.Models.ConfiguredRulesPunctuationRoundBrackets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Round Brackets
    /// </summary>
    public enum ConfiguredRulesPunctuationRoundBrackets
    {
        /// <summary>
        /// 
        /// </summary>
        UseFullWidthRoundBrackets,
        /// <summary>
        /// 
        /// </summary>
        UseHalfWidthRoundBrackets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationRoundBracketsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationRoundBrackets value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationRoundBrackets.UseFullWidthRoundBrackets => "use_full_width_round_brackets",
                ConfiguredRulesPunctuationRoundBrackets.UseHalfWidthRoundBrackets => "use_half_width_round_brackets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationRoundBrackets? ToEnum(string value)
        {
            return value switch
            {
                "use_full_width_round_brackets" => ConfiguredRulesPunctuationRoundBrackets.UseFullWidthRoundBrackets,
                "use_half_width_round_brackets" => ConfiguredRulesPunctuationRoundBrackets.UseHalfWidthRoundBrackets,
                _ => null,
            };
        }
    }
}