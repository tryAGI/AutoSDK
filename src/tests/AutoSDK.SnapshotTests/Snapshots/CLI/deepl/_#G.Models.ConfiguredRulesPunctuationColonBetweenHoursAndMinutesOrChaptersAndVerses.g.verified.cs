//HintName: G.Models.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Colon Between Hours And Minutes Or Chapters And Verses
    /// </summary>
    public enum ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseSpaceBeforeOrAfterColon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVersesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses.DoNotUseSpaceBeforeOrAfterColon => "do_not_use_space_before_or_after_colon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_space_before_or_after_colon" => ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses.DoNotUseSpaceBeforeOrAfterColon,
                _ => null,
            };
        }
    }
}