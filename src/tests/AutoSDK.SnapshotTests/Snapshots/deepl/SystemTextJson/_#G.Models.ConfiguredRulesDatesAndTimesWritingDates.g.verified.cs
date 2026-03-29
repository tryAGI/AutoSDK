//HintName: G.Models.ConfiguredRulesDatesAndTimesWritingDates.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Writing Dates
    /// </summary>
    public enum ConfiguredRulesDatesAndTimesWritingDates
    {
        /// <summary>
        /// 
        /// </summary>
        UseDdSpaceSpelledOutMonthSpaceYyyy,
        /// <summary>
        /// 
        /// </summary>
        UseNumerals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesDatesAndTimesWritingDatesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesDatesAndTimesWritingDates value)
        {
            return value switch
            {
                ConfiguredRulesDatesAndTimesWritingDates.UseDdSpaceSpelledOutMonthSpaceYyyy => "use_dd_space_spelled_out_month_space_yyyy",
                ConfiguredRulesDatesAndTimesWritingDates.UseNumerals => "use_numerals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesDatesAndTimesWritingDates? ToEnum(string value)
        {
            return value switch
            {
                "use_dd_space_spelled_out_month_space_yyyy" => ConfiguredRulesDatesAndTimesWritingDates.UseDdSpaceSpelledOutMonthSpaceYyyy,
                "use_numerals" => ConfiguredRulesDatesAndTimesWritingDates.UseNumerals,
                _ => null,
            };
        }
    }
}