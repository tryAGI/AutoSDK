//HintName: G.Models.ConfiguredRulesDatesAndTimesHoursMinutesSeparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Hours Minutes Separator
    /// </summary>
    public enum ConfiguredRulesDatesAndTimesHoursMinutesSeparator
    {
        /// <summary>
        /// 
        /// </summary>
        UseColonWithoutSpaces,
        /// <summary>
        /// 
        /// </summary>
        UseLetterHWithRegularSpaceOnEitherSide,
        /// <summary>
        /// 
        /// </summary>
        UseLetterHWithoutSpaces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesDatesAndTimesHoursMinutesSeparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesDatesAndTimesHoursMinutesSeparator value)
        {
            return value switch
            {
                ConfiguredRulesDatesAndTimesHoursMinutesSeparator.UseColonWithoutSpaces => "use_colon_without_spaces",
                ConfiguredRulesDatesAndTimesHoursMinutesSeparator.UseLetterHWithRegularSpaceOnEitherSide => "use_letter_h_with_regular_space_on_either_side",
                ConfiguredRulesDatesAndTimesHoursMinutesSeparator.UseLetterHWithoutSpaces => "use_letter_h_without_spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesDatesAndTimesHoursMinutesSeparator? ToEnum(string value)
        {
            return value switch
            {
                "use_colon_without_spaces" => ConfiguredRulesDatesAndTimesHoursMinutesSeparator.UseColonWithoutSpaces,
                "use_letter_h_with_regular_space_on_either_side" => ConfiguredRulesDatesAndTimesHoursMinutesSeparator.UseLetterHWithRegularSpaceOnEitherSide,
                "use_letter_h_without_spaces" => ConfiguredRulesDatesAndTimesHoursMinutesSeparator.UseLetterHWithoutSpaces,
                _ => null,
            };
        }
    }
}