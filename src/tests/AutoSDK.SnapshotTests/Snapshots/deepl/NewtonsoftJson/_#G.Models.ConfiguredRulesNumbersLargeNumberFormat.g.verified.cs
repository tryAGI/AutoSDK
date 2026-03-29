//HintName: G.Models.ConfiguredRulesNumbersLargeNumberFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Large Number Format
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersLargeNumberFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="always_use_arabic_numerals")]
        AlwaysUseArabicNumerals,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spell_out_large_numbers")]
        SpellOutLargeNumbers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_abbreviations_for_large_numbers")]
        UseAbbreviationsForLargeNumbers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_chinese_characters_for_ten_thousands_and_hundred_millions")]
        UseChineseCharactersForTenThousandsAndHundredMillions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_comma_to_separate_large_numbers_into_units_of_three_except_for_calendar_years")]
        UseCommaToSeparateLargeNumbersIntoUnitsOfThreeExceptForCalendarYears,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_kanji_for_trillions_hundred_millions_and_ten_thousands")]
        UseKanjiForTrillionsHundredMillionsAndTenThousands,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_korean_words_만_억_조_with_space")]
        UseKoreanWords___WithSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_korean_words_만_억_조_without_space")]
        UseKoreanWords___WithoutSpace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersLargeNumberFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersLargeNumberFormat value)
        {
            return value switch
            {
                ConfiguredRulesNumbersLargeNumberFormat.AlwaysUseArabicNumerals => "always_use_arabic_numerals",
                ConfiguredRulesNumbersLargeNumberFormat.SpellOutLargeNumbers => "spell_out_large_numbers",
                ConfiguredRulesNumbersLargeNumberFormat.UseAbbreviationsForLargeNumbers => "use_abbreviations_for_large_numbers",
                ConfiguredRulesNumbersLargeNumberFormat.UseChineseCharactersForTenThousandsAndHundredMillions => "use_chinese_characters_for_ten_thousands_and_hundred_millions",
                ConfiguredRulesNumbersLargeNumberFormat.UseCommaToSeparateLargeNumbersIntoUnitsOfThreeExceptForCalendarYears => "use_comma_to_separate_large_numbers_into_units_of_three_except_for_calendar_years",
                ConfiguredRulesNumbersLargeNumberFormat.UseKanjiForTrillionsHundredMillionsAndTenThousands => "use_kanji_for_trillions_hundred_millions_and_ten_thousands",
                ConfiguredRulesNumbersLargeNumberFormat.UseKoreanWords___WithSpace => "use_korean_words_만_억_조_with_space",
                ConfiguredRulesNumbersLargeNumberFormat.UseKoreanWords___WithoutSpace => "use_korean_words_만_억_조_without_space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersLargeNumberFormat? ToEnum(string value)
        {
            return value switch
            {
                "always_use_arabic_numerals" => ConfiguredRulesNumbersLargeNumberFormat.AlwaysUseArabicNumerals,
                "spell_out_large_numbers" => ConfiguredRulesNumbersLargeNumberFormat.SpellOutLargeNumbers,
                "use_abbreviations_for_large_numbers" => ConfiguredRulesNumbersLargeNumberFormat.UseAbbreviationsForLargeNumbers,
                "use_chinese_characters_for_ten_thousands_and_hundred_millions" => ConfiguredRulesNumbersLargeNumberFormat.UseChineseCharactersForTenThousandsAndHundredMillions,
                "use_comma_to_separate_large_numbers_into_units_of_three_except_for_calendar_years" => ConfiguredRulesNumbersLargeNumberFormat.UseCommaToSeparateLargeNumbersIntoUnitsOfThreeExceptForCalendarYears,
                "use_kanji_for_trillions_hundred_millions_and_ten_thousands" => ConfiguredRulesNumbersLargeNumberFormat.UseKanjiForTrillionsHundredMillionsAndTenThousands,
                "use_korean_words_만_억_조_with_space" => ConfiguredRulesNumbersLargeNumberFormat.UseKoreanWords___WithSpace,
                "use_korean_words_만_억_조_without_space" => ConfiguredRulesNumbersLargeNumberFormat.UseKoreanWords___WithoutSpace,
                _ => null,
            };
        }
    }
}