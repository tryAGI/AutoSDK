//HintName: G.Models.ConfiguredRulesDatesAndTimesYears.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Years
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesDatesAndTimesYears
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_apostrophe_yy")]
        UseApostropheYy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_common_era")]
        UseCommonEra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_japanese_imperial_era")]
        UseJapaneseImperialEra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_yyyy")]
        UseYyyy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesDatesAndTimesYearsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesDatesAndTimesYears value)
        {
            return value switch
            {
                ConfiguredRulesDatesAndTimesYears.UseApostropheYy => "use_apostrophe_yy",
                ConfiguredRulesDatesAndTimesYears.UseCommonEra => "use_common_era",
                ConfiguredRulesDatesAndTimesYears.UseJapaneseImperialEra => "use_japanese_imperial_era",
                ConfiguredRulesDatesAndTimesYears.UseYyyy => "use_yyyy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesDatesAndTimesYears? ToEnum(string value)
        {
            return value switch
            {
                "use_apostrophe_yy" => ConfiguredRulesDatesAndTimesYears.UseApostropheYy,
                "use_common_era" => ConfiguredRulesDatesAndTimesYears.UseCommonEra,
                "use_japanese_imperial_era" => ConfiguredRulesDatesAndTimesYears.UseJapaneseImperialEra,
                "use_yyyy" => ConfiguredRulesDatesAndTimesYears.UseYyyy,
                _ => null,
            };
        }
    }
}