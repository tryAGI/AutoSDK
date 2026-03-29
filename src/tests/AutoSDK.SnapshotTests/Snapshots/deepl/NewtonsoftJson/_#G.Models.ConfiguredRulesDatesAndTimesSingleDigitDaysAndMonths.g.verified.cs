//HintName: G.Models.ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Single Digit Days And Months
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesDatesAndTimesSingleDigitDaysAndMonths
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use_leading_zero")]
        DoNotUseLeadingZero,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_leading_zero")]
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