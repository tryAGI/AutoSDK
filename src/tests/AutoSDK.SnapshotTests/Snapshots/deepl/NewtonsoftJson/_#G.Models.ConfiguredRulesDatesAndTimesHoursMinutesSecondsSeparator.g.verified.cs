//HintName: G.Models.ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Hours Minutes Seconds Separator
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_colon")]
        UseColon,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_period")]
        UsePeriod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator value)
        {
            return value switch
            {
                ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator.UseColon => "use_colon",
                ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator.UsePeriod => "use_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator? ToEnum(string value)
        {
            return value switch
            {
                "use_colon" => ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator.UseColon,
                "use_period" => ConfiguredRulesDatesAndTimesHoursMinutesSecondsSeparator.UsePeriod,
                _ => null,
            };
        }
    }
}