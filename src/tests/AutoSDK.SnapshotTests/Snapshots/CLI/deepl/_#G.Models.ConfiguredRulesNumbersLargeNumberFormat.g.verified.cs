//HintName: G.Models.ConfiguredRulesNumbersLargeNumberFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Large Number Format
    /// </summary>
    public enum ConfiguredRulesNumbersLargeNumberFormat
    {
        /// <summary>
        /// 
        /// </summary>
        AlwaysUseArabicNumerals,
        /// <summary>
        /// 
        /// </summary>
        SpellOutLargeNumbers,
        /// <summary>
        /// 
        /// </summary>
        UseAbbreviationsForLargeNumbers,
        /// <summary>
        /// 
        /// </summary>
        UseChineseCharactersForTenThousandsAndHundredMillions,
        /// <summary>
        /// 
        /// </summary>
        UseCommaToSeparateLargeNumbersIntoUnitsOfThreeExceptForCalendarYears,
        /// <summary>
        /// 
        /// </summary>
        UseKanjiForTrillionsHundredMillionsAndTenThousands,
        /// <summary>
        /// 
        /// </summary>
        UseKoreanWords만억조WithSpace,
        /// <summary>
        /// 
        /// </summary>
        UseKoreanWords만억조WithoutSpace,
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
                ConfiguredRulesNumbersLargeNumberFormat.UseKoreanWords만억조WithSpace => "use_korean_words_만_억_조_with_space",
                ConfiguredRulesNumbersLargeNumberFormat.UseKoreanWords만억조WithoutSpace => "use_korean_words_만_억_조_without_space",
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
                "use_korean_words_만_억_조_with_space" => ConfiguredRulesNumbersLargeNumberFormat.UseKoreanWords만억조WithSpace,
                "use_korean_words_만_억_조_without_space" => ConfiguredRulesNumbersLargeNumberFormat.UseKoreanWords만억조WithoutSpace,
                _ => null,
            };
        }
    }
}