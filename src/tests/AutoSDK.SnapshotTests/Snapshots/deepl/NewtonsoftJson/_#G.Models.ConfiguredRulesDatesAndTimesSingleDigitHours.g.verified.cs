//HintName: G.Models.ConfiguredRulesDatesAndTimesSingleDigitHours.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Single Digit Hours
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesDatesAndTimesSingleDigitHours
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
    public static class ConfiguredRulesDatesAndTimesSingleDigitHoursExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesDatesAndTimesSingleDigitHours value)
        {
            return value switch
            {
                ConfiguredRulesDatesAndTimesSingleDigitHours.DoNotUseLeadingZero => "do_not_use_leading_zero",
                ConfiguredRulesDatesAndTimesSingleDigitHours.UseLeadingZero => "use_leading_zero",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesDatesAndTimesSingleDigitHours? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_leading_zero" => ConfiguredRulesDatesAndTimesSingleDigitHours.DoNotUseLeadingZero,
                "use_leading_zero" => ConfiguredRulesDatesAndTimesSingleDigitHours.UseLeadingZero,
                _ => null,
            };
        }
    }
}