//HintName: G.Models.ConfiguredRulesDatesAndTimesCalendarEra.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Calendar Era
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesDatesAndTimesCalendarEra
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_bc_and_ad")]
        UseBcAndAd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_bce_and_ce")]
        UseBceAndCe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesDatesAndTimesCalendarEraExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesDatesAndTimesCalendarEra value)
        {
            return value switch
            {
                ConfiguredRulesDatesAndTimesCalendarEra.UseBcAndAd => "use_bc_and_ad",
                ConfiguredRulesDatesAndTimesCalendarEra.UseBceAndCe => "use_bce_and_ce",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesDatesAndTimesCalendarEra? ToEnum(string value)
        {
            return value switch
            {
                "use_bc_and_ad" => ConfiguredRulesDatesAndTimesCalendarEra.UseBcAndAd,
                "use_bce_and_ce" => ConfiguredRulesDatesAndTimesCalendarEra.UseBceAndCe,
                _ => null,
            };
        }
    }
}