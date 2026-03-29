//HintName: G.Models.ConfiguredRulesPunctuationEllipsis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Ellipsis
    /// </summary>
    public enum ConfiguredRulesPunctuationEllipsis
    {
        /// <summary>
        /// 
        /// </summary>
        UseEllipsisCharacter,
        /// <summary>
        /// 
        /// </summary>
        UseOneEllipsisCharacter,
        /// <summary>
        /// 
        /// </summary>
        UseSixDotsAtTheBottom,
        /// <summary>
        /// 
        /// </summary>
        UseSixDotsInTheCenter,
        /// <summary>
        /// 
        /// </summary>
        UseThreeDotsAtTheBottom,
        /// <summary>
        /// 
        /// </summary>
        UseThreeDotsInTheCenter,
        /// <summary>
        /// 
        /// </summary>
        UseThreeEllipsisCharacters,
        /// <summary>
        /// 
        /// </summary>
        UseThreePeriods,
        /// <summary>
        /// 
        /// </summary>
        UseThreePeriodsWithoutSpaces,
        /// <summary>
        /// 
        /// </summary>
        UseThreeSpacedPeriods,
        /// <summary>
        /// 
        /// </summary>
        UseTwoEllipsisCharacters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationEllipsisExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationEllipsis value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationEllipsis.UseEllipsisCharacter => "use_ellipsis_character",
                ConfiguredRulesPunctuationEllipsis.UseOneEllipsisCharacter => "use_one_ellipsis_character",
                ConfiguredRulesPunctuationEllipsis.UseSixDotsAtTheBottom => "use_six_dots_at_the_bottom",
                ConfiguredRulesPunctuationEllipsis.UseSixDotsInTheCenter => "use_six_dots_in_the_center",
                ConfiguredRulesPunctuationEllipsis.UseThreeDotsAtTheBottom => "use_three_dots_at_the_bottom",
                ConfiguredRulesPunctuationEllipsis.UseThreeDotsInTheCenter => "use_three_dots_in_the_center",
                ConfiguredRulesPunctuationEllipsis.UseThreeEllipsisCharacters => "use_three_ellipsis_characters",
                ConfiguredRulesPunctuationEllipsis.UseThreePeriods => "use_three_periods",
                ConfiguredRulesPunctuationEllipsis.UseThreePeriodsWithoutSpaces => "use_three_periods_without_spaces",
                ConfiguredRulesPunctuationEllipsis.UseThreeSpacedPeriods => "use_three_spaced_periods",
                ConfiguredRulesPunctuationEllipsis.UseTwoEllipsisCharacters => "use_two_ellipsis_characters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationEllipsis? ToEnum(string value)
        {
            return value switch
            {
                "use_ellipsis_character" => ConfiguredRulesPunctuationEllipsis.UseEllipsisCharacter,
                "use_one_ellipsis_character" => ConfiguredRulesPunctuationEllipsis.UseOneEllipsisCharacter,
                "use_six_dots_at_the_bottom" => ConfiguredRulesPunctuationEllipsis.UseSixDotsAtTheBottom,
                "use_six_dots_in_the_center" => ConfiguredRulesPunctuationEllipsis.UseSixDotsInTheCenter,
                "use_three_dots_at_the_bottom" => ConfiguredRulesPunctuationEllipsis.UseThreeDotsAtTheBottom,
                "use_three_dots_in_the_center" => ConfiguredRulesPunctuationEllipsis.UseThreeDotsInTheCenter,
                "use_three_ellipsis_characters" => ConfiguredRulesPunctuationEllipsis.UseThreeEllipsisCharacters,
                "use_three_periods" => ConfiguredRulesPunctuationEllipsis.UseThreePeriods,
                "use_three_periods_without_spaces" => ConfiguredRulesPunctuationEllipsis.UseThreePeriodsWithoutSpaces,
                "use_three_spaced_periods" => ConfiguredRulesPunctuationEllipsis.UseThreeSpacedPeriods,
                "use_two_ellipsis_characters" => ConfiguredRulesPunctuationEllipsis.UseTwoEllipsisCharacters,
                _ => null,
            };
        }
    }
}