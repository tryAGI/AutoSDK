//HintName: G.Models.ConfiguredRulesPunctuationSentenceBreakIndicator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Sentence Break Indicator
    /// </summary>
    public enum ConfiguredRulesPunctuationSentenceBreakIndicator
    {
        /// <summary>
        /// 
        /// </summary>
        UseEmDashWithSpaceOnEitherSide,
        /// <summary>
        /// 
        /// </summary>
        UseEmDashWithoutSpaceOnEitherSide,
        /// <summary>
        /// 
        /// </summary>
        UseEnDashWithSpaceOnEitherSide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationSentenceBreakIndicatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationSentenceBreakIndicator value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationSentenceBreakIndicator.UseEmDashWithSpaceOnEitherSide => "use_em_dash_with_space_on_either_side",
                ConfiguredRulesPunctuationSentenceBreakIndicator.UseEmDashWithoutSpaceOnEitherSide => "use_em_dash_without_space_on_either_side",
                ConfiguredRulesPunctuationSentenceBreakIndicator.UseEnDashWithSpaceOnEitherSide => "use_en_dash_with_space_on_either_side",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationSentenceBreakIndicator? ToEnum(string value)
        {
            return value switch
            {
                "use_em_dash_with_space_on_either_side" => ConfiguredRulesPunctuationSentenceBreakIndicator.UseEmDashWithSpaceOnEitherSide,
                "use_em_dash_without_space_on_either_side" => ConfiguredRulesPunctuationSentenceBreakIndicator.UseEmDashWithoutSpaceOnEitherSide,
                "use_en_dash_with_space_on_either_side" => ConfiguredRulesPunctuationSentenceBreakIndicator.UseEnDashWithSpaceOnEitherSide,
                _ => null,
            };
        }
    }
}