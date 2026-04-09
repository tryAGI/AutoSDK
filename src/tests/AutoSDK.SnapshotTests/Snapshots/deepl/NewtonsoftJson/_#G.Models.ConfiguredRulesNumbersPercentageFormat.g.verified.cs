//HintName: G.Models.ConfiguredRulesNumbersPercentageFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Percentage Format
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersPercentageFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_arabic_numerals_followed_by_percent_symbol_without_space")]
        UseArabicNumeralsFollowedByPercentSymbolWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_chinese_numbers_followed_by_chinese_word_百分之")]
        UseChineseNumbersFollowedByChineseWord百分之,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_full_width_percent_symbol_without_space")]
        UseNumeralsFollowedByFullWidthPercentSymbolWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_japanese_word_パーセント_without_space")]
        UseNumeralsFollowedByJapaneseWordパーセントWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_korean_word_퍼센트")]
        UseNumeralsFollowedByKoreanWord퍼센트,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_percent_symbol")]
        UseNumeralsFollowedByPercentSymbol,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_space_then_german_word_prozent")]
        UseNumeralsFollowedBySpaceThenGermanWordProzent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_space_then_half_width_percent_symbol")]
        UseNumeralsFollowedBySpaceThenHalfWidthPercentSymbol,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_space_then_italian_word_per_cento")]
        UseNumeralsFollowedBySpaceThenItalianWordPerCento,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_space_then_italian_word_percento")]
        UseNumeralsFollowedBySpaceThenItalianWordPercento2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_space_then_korean_word_퍼센트")]
        UseNumeralsFollowedBySpaceThenKoreanWord퍼센트,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_space_then_percent_symbol")]
        UseNumeralsFollowedBySpaceThenPercentSymbol,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_space_then_spell_out_per_cent")]
        UseNumeralsFollowedBySpaceThenSpellOutPerCent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_space_then_spell_out_percent")]
        UseNumeralsFollowedBySpaceThenSpellOutPercent2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_spanish_word_por_cien")]
        UseSpanishWordPorCien,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_spanish_word_por_ciento")]
        UseSpanishWordPorCiento,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersPercentageFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersPercentageFormat value)
        {
            return value switch
            {
                ConfiguredRulesNumbersPercentageFormat.UseArabicNumeralsFollowedByPercentSymbolWithoutSpace => "use_arabic_numerals_followed_by_percent_symbol_without_space",
                ConfiguredRulesNumbersPercentageFormat.UseChineseNumbersFollowedByChineseWord百分之 => "use_chinese_numbers_followed_by_chinese_word_百分之",
                ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedByFullWidthPercentSymbolWithoutSpace => "use_numerals_followed_by_full_width_percent_symbol_without_space",
                ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedByJapaneseWordパーセントWithoutSpace => "use_numerals_followed_by_japanese_word_パーセント_without_space",
                ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedByKoreanWord퍼센트 => "use_numerals_followed_by_korean_word_퍼센트",
                ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedByPercentSymbol => "use_numerals_followed_by_percent_symbol",
                ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenGermanWordProzent => "use_numerals_followed_by_space_then_german_word_prozent",
                ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenHalfWidthPercentSymbol => "use_numerals_followed_by_space_then_half_width_percent_symbol",
                ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenItalianWordPerCento => "use_numerals_followed_by_space_then_italian_word_per_cento",
                ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenItalianWordPercento2 => "use_numerals_followed_by_space_then_italian_word_percento",
                ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenKoreanWord퍼센트 => "use_numerals_followed_by_space_then_korean_word_퍼센트",
                ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenPercentSymbol => "use_numerals_followed_by_space_then_percent_symbol",
                ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenSpellOutPerCent => "use_numerals_followed_by_space_then_spell_out_per_cent",
                ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenSpellOutPercent2 => "use_numerals_followed_by_space_then_spell_out_percent",
                ConfiguredRulesNumbersPercentageFormat.UseSpanishWordPorCien => "use_spanish_word_por_cien",
                ConfiguredRulesNumbersPercentageFormat.UseSpanishWordPorCiento => "use_spanish_word_por_ciento",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersPercentageFormat? ToEnum(string value)
        {
            return value switch
            {
                "use_arabic_numerals_followed_by_percent_symbol_without_space" => ConfiguredRulesNumbersPercentageFormat.UseArabicNumeralsFollowedByPercentSymbolWithoutSpace,
                "use_chinese_numbers_followed_by_chinese_word_百分之" => ConfiguredRulesNumbersPercentageFormat.UseChineseNumbersFollowedByChineseWord百分之,
                "use_numerals_followed_by_full_width_percent_symbol_without_space" => ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedByFullWidthPercentSymbolWithoutSpace,
                "use_numerals_followed_by_japanese_word_パーセント_without_space" => ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedByJapaneseWordパーセントWithoutSpace,
                "use_numerals_followed_by_korean_word_퍼센트" => ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedByKoreanWord퍼센트,
                "use_numerals_followed_by_percent_symbol" => ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedByPercentSymbol,
                "use_numerals_followed_by_space_then_german_word_prozent" => ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenGermanWordProzent,
                "use_numerals_followed_by_space_then_half_width_percent_symbol" => ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenHalfWidthPercentSymbol,
                "use_numerals_followed_by_space_then_italian_word_per_cento" => ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenItalianWordPerCento,
                "use_numerals_followed_by_space_then_italian_word_percento" => ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenItalianWordPercento2,
                "use_numerals_followed_by_space_then_korean_word_퍼센트" => ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenKoreanWord퍼센트,
                "use_numerals_followed_by_space_then_percent_symbol" => ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenPercentSymbol,
                "use_numerals_followed_by_space_then_spell_out_per_cent" => ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenSpellOutPerCent,
                "use_numerals_followed_by_space_then_spell_out_percent" => ConfiguredRulesNumbersPercentageFormat.UseNumeralsFollowedBySpaceThenSpellOutPercent2,
                "use_spanish_word_por_cien" => ConfiguredRulesNumbersPercentageFormat.UseSpanishWordPorCien,
                "use_spanish_word_por_ciento" => ConfiguredRulesNumbersPercentageFormat.UseSpanishWordPorCiento,
                _ => null,
            };
        }
    }
}