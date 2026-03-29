//HintName: G.Models.ConfiguredRulesDatesAndTimesCenturies.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Centuries
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesDatesAndTimesCenturies
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spell_out")]
        SpellOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_arabic_numerals")]
        UseArabicNumerals,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals")]
        UseNumerals,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_roman_numerals")]
        UseRomanNumerals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesDatesAndTimesCenturiesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesDatesAndTimesCenturies value)
        {
            return value switch
            {
                ConfiguredRulesDatesAndTimesCenturies.SpellOut => "spell_out",
                ConfiguredRulesDatesAndTimesCenturies.UseArabicNumerals => "use_arabic_numerals",
                ConfiguredRulesDatesAndTimesCenturies.UseNumerals => "use_numerals",
                ConfiguredRulesDatesAndTimesCenturies.UseRomanNumerals => "use_roman_numerals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesDatesAndTimesCenturies? ToEnum(string value)
        {
            return value switch
            {
                "spell_out" => ConfiguredRulesDatesAndTimesCenturies.SpellOut,
                "use_arabic_numerals" => ConfiguredRulesDatesAndTimesCenturies.UseArabicNumerals,
                "use_numerals" => ConfiguredRulesDatesAndTimesCenturies.UseNumerals,
                "use_roman_numerals" => ConfiguredRulesDatesAndTimesCenturies.UseRomanNumerals,
                _ => null,
            };
        }
    }
}