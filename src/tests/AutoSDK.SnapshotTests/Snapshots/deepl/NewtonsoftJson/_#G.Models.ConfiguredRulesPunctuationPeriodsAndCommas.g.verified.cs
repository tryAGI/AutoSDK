//HintName: G.Models.ConfiguredRulesPunctuationPeriodsAndCommas.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Periods And Commas
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationPeriodsAndCommas
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_full_width_japanese_periods_and_full_width_japanese_commas")]
        UseFullWidthJapanesePeriodsAndFullWidthJapaneseCommas,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_full_width_japanese_periods_and_full_width_non_japanese_commas")]
        UseFullWidthJapanesePeriodsAndFullWidthNonJapaneseCommas,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_full_width_non_japanese_periods_and_full_width_japanese_commas")]
        UseFullWidthNonJapanesePeriodsAndFullWidthJapaneseCommas,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_full_width_non_japanese_periods_and_full_width_non_japanese_commas")]
        UseFullWidthNonJapanesePeriodsAndFullWidthNonJapaneseCommas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationPeriodsAndCommasExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationPeriodsAndCommas value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationPeriodsAndCommas.UseFullWidthJapanesePeriodsAndFullWidthJapaneseCommas => "use_full_width_japanese_periods_and_full_width_japanese_commas",
                ConfiguredRulesPunctuationPeriodsAndCommas.UseFullWidthJapanesePeriodsAndFullWidthNonJapaneseCommas => "use_full_width_japanese_periods_and_full_width_non_japanese_commas",
                ConfiguredRulesPunctuationPeriodsAndCommas.UseFullWidthNonJapanesePeriodsAndFullWidthJapaneseCommas => "use_full_width_non_japanese_periods_and_full_width_japanese_commas",
                ConfiguredRulesPunctuationPeriodsAndCommas.UseFullWidthNonJapanesePeriodsAndFullWidthNonJapaneseCommas => "use_full_width_non_japanese_periods_and_full_width_non_japanese_commas",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationPeriodsAndCommas? ToEnum(string value)
        {
            return value switch
            {
                "use_full_width_japanese_periods_and_full_width_japanese_commas" => ConfiguredRulesPunctuationPeriodsAndCommas.UseFullWidthJapanesePeriodsAndFullWidthJapaneseCommas,
                "use_full_width_japanese_periods_and_full_width_non_japanese_commas" => ConfiguredRulesPunctuationPeriodsAndCommas.UseFullWidthJapanesePeriodsAndFullWidthNonJapaneseCommas,
                "use_full_width_non_japanese_periods_and_full_width_japanese_commas" => ConfiguredRulesPunctuationPeriodsAndCommas.UseFullWidthNonJapanesePeriodsAndFullWidthJapaneseCommas,
                "use_full_width_non_japanese_periods_and_full_width_non_japanese_commas" => ConfiguredRulesPunctuationPeriodsAndCommas.UseFullWidthNonJapanesePeriodsAndFullWidthNonJapaneseCommas,
                _ => null,
            };
        }
    }
}