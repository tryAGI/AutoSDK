//HintName: G.Models.ConfiguredRulesNumbersTemperatureFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Temperature Format
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersTemperatureFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spell_out_unit")]
        SpellOutUnit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spell_out_unit_followed_by_numerals_then_korean_word_도")]
        SpellOutUnitFollowedByNumeralsThenKoreanWord도,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_arabic_numerals_followed_by_space_then_spell_out_unit")]
        UseArabicNumeralsFollowedBySpaceThenSpellOutUnit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_arabic_numerals_followed_by_unit_symbol_without_space")]
        UseArabicNumeralsFollowedByUnitSymbolWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_arabic_numerals_then_spell_out_unit")]
        UseArabicNumeralsThenSpellOutUnit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_chinese_numbers_then_spell_out_unit")]
        UseChineseNumbersThenSpellOutUnit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_italian_word_grado_and_do_not_specify_temperature_scale")]
        UseItalianWordGradoAndDoNotSpecifyTemperatureScale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_japanese_word_度_without_space")]
        UseNumeralsFollowedByJapaneseWord度WithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_korean_word_도")]
        UseNumeralsFollowedByKoreanWord도,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_space_then_spell_out_unit")]
        UseNumeralsFollowedBySpaceThenSpellOutUnit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_space_then_unit_symbol")]
        UseNumeralsFollowedBySpaceThenUnitSymbol,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_numerals_followed_by_unit_symbol_without_space")]
        UseNumeralsFollowedByUnitSymbolWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_spanish_word_grado_and_do_not_specify_temperature_scale")]
        UseSpanishWordGradoAndDoNotSpecifyTemperatureScale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersTemperatureFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersTemperatureFormat value)
        {
            return value switch
            {
                ConfiguredRulesNumbersTemperatureFormat.SpellOutUnit => "spell_out_unit",
                ConfiguredRulesNumbersTemperatureFormat.SpellOutUnitFollowedByNumeralsThenKoreanWord도 => "spell_out_unit_followed_by_numerals_then_korean_word_도",
                ConfiguredRulesNumbersTemperatureFormat.UseArabicNumeralsFollowedBySpaceThenSpellOutUnit => "use_arabic_numerals_followed_by_space_then_spell_out_unit",
                ConfiguredRulesNumbersTemperatureFormat.UseArabicNumeralsFollowedByUnitSymbolWithoutSpace => "use_arabic_numerals_followed_by_unit_symbol_without_space",
                ConfiguredRulesNumbersTemperatureFormat.UseArabicNumeralsThenSpellOutUnit => "use_arabic_numerals_then_spell_out_unit",
                ConfiguredRulesNumbersTemperatureFormat.UseChineseNumbersThenSpellOutUnit => "use_chinese_numbers_then_spell_out_unit",
                ConfiguredRulesNumbersTemperatureFormat.UseItalianWordGradoAndDoNotSpecifyTemperatureScale => "use_italian_word_grado_and_do_not_specify_temperature_scale",
                ConfiguredRulesNumbersTemperatureFormat.UseNumeralsFollowedByJapaneseWord度WithoutSpace => "use_numerals_followed_by_japanese_word_度_without_space",
                ConfiguredRulesNumbersTemperatureFormat.UseNumeralsFollowedByKoreanWord도 => "use_numerals_followed_by_korean_word_도",
                ConfiguredRulesNumbersTemperatureFormat.UseNumeralsFollowedBySpaceThenSpellOutUnit => "use_numerals_followed_by_space_then_spell_out_unit",
                ConfiguredRulesNumbersTemperatureFormat.UseNumeralsFollowedBySpaceThenUnitSymbol => "use_numerals_followed_by_space_then_unit_symbol",
                ConfiguredRulesNumbersTemperatureFormat.UseNumeralsFollowedByUnitSymbolWithoutSpace => "use_numerals_followed_by_unit_symbol_without_space",
                ConfiguredRulesNumbersTemperatureFormat.UseSpanishWordGradoAndDoNotSpecifyTemperatureScale => "use_spanish_word_grado_and_do_not_specify_temperature_scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersTemperatureFormat? ToEnum(string value)
        {
            return value switch
            {
                "spell_out_unit" => ConfiguredRulesNumbersTemperatureFormat.SpellOutUnit,
                "spell_out_unit_followed_by_numerals_then_korean_word_도" => ConfiguredRulesNumbersTemperatureFormat.SpellOutUnitFollowedByNumeralsThenKoreanWord도,
                "use_arabic_numerals_followed_by_space_then_spell_out_unit" => ConfiguredRulesNumbersTemperatureFormat.UseArabicNumeralsFollowedBySpaceThenSpellOutUnit,
                "use_arabic_numerals_followed_by_unit_symbol_without_space" => ConfiguredRulesNumbersTemperatureFormat.UseArabicNumeralsFollowedByUnitSymbolWithoutSpace,
                "use_arabic_numerals_then_spell_out_unit" => ConfiguredRulesNumbersTemperatureFormat.UseArabicNumeralsThenSpellOutUnit,
                "use_chinese_numbers_then_spell_out_unit" => ConfiguredRulesNumbersTemperatureFormat.UseChineseNumbersThenSpellOutUnit,
                "use_italian_word_grado_and_do_not_specify_temperature_scale" => ConfiguredRulesNumbersTemperatureFormat.UseItalianWordGradoAndDoNotSpecifyTemperatureScale,
                "use_numerals_followed_by_japanese_word_度_without_space" => ConfiguredRulesNumbersTemperatureFormat.UseNumeralsFollowedByJapaneseWord度WithoutSpace,
                "use_numerals_followed_by_korean_word_도" => ConfiguredRulesNumbersTemperatureFormat.UseNumeralsFollowedByKoreanWord도,
                "use_numerals_followed_by_space_then_spell_out_unit" => ConfiguredRulesNumbersTemperatureFormat.UseNumeralsFollowedBySpaceThenSpellOutUnit,
                "use_numerals_followed_by_space_then_unit_symbol" => ConfiguredRulesNumbersTemperatureFormat.UseNumeralsFollowedBySpaceThenUnitSymbol,
                "use_numerals_followed_by_unit_symbol_without_space" => ConfiguredRulesNumbersTemperatureFormat.UseNumeralsFollowedByUnitSymbolWithoutSpace,
                "use_spanish_word_grado_and_do_not_specify_temperature_scale" => ConfiguredRulesNumbersTemperatureFormat.UseSpanishWordGradoAndDoNotSpecifyTemperatureScale,
                _ => null,
            };
        }
    }
}