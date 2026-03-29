//HintName: G.Models.ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Single Digit Days And Months
    /// </summary>
    public enum ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseLeadingZero,
        /// <summary>
        /// 
        /// </summary>
        UseLeadingZero,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonthsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths value)
        {
            return value switch
            {
                ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths.DoNotUseLeadingZero => "do_not_use_leading_zero",
                ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths.UseLeadingZero => "use_leading_zero",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_leading_zero" => ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths.DoNotUseLeadingZero,
                "use_leading_zero" => ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths.UseLeadingZero,
                _ => null,
            };
        }
    }
}