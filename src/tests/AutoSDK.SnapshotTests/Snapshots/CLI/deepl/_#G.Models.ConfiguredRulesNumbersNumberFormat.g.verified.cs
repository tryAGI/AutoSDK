//HintName: G.Models.ConfiguredRulesNumbersNumberFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Number Format
    /// </summary>
    public enum ConfiguredRulesNumbersNumberFormat
    {
        /// <summary>
        /// 
        /// </summary>
        UseHalfWidthCommaToSeparateLargeNumbersIntoUnitsOfThreeExceptForCalendarYearsAndUseHalfWidthPeriodAsDecimalSeparator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersNumberFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersNumberFormat value)
        {
            return value switch
            {
                ConfiguredRulesNumbersNumberFormat.UseHalfWidthCommaToSeparateLargeNumbersIntoUnitsOfThreeExceptForCalendarYearsAndUseHalfWidthPeriodAsDecimalSeparator => "use_half_width_comma_to_separate_large_numbers_into_units_of_three_except_for_calendar_years_and_use_half_width_period_as_decimal_separator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersNumberFormat? ToEnum(string value)
        {
            return value switch
            {
                "use_half_width_comma_to_separate_large_numbers_into_units_of_three_except_for_calendar_years_and_use_half_width_period_as_decimal_separator" => ConfiguredRulesNumbersNumberFormat.UseHalfWidthCommaToSeparateLargeNumbersIntoUnitsOfThreeExceptForCalendarYearsAndUseHalfWidthPeriodAsDecimalSeparator,
                _ => null,
            };
        }
    }
}