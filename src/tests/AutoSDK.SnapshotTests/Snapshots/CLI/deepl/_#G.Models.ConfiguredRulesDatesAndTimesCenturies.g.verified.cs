//HintName: G.Models.ConfiguredRulesDatesAndTimesCenturies.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Centuries
    /// </summary>
    public enum ConfiguredRulesDatesAndTimesCenturies
    {
        /// <summary>
        /// 
        /// </summary>
        SpellOut,
        /// <summary>
        /// 
        /// </summary>
        UseArabicNumerals,
        /// <summary>
        /// 
        /// </summary>
        UseNumerals,
        /// <summary>
        /// 
        /// </summary>
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