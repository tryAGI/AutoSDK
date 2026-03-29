//HintName: G.Models.ConfiguredRulesNumbersCurrencyFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Currency Format
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersCurrencyFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spell_out")]
        SpellOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spell_out_currency_name_followed_by_amount_in_arabic_numerals_without_space")]
        SpellOutCurrencyNameFollowedByAmountInArabicNumeralsWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spell_out_currency_name_followed_by_amount_in_chinese")]
        SpellOutCurrencyNameFollowedByAmountInChinese,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_amount_followed_by_currency_symbol_without_space")]
        UseAmountFollowedByCurrencySymbolWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_amount_followed_by_space_then_currency_symbol")]
        UseAmountFollowedBySpaceThenCurrencySymbol,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_amount_followed_by_space_then_iso_code")]
        UseAmountFollowedBySpaceThenIsoCode,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_amount_followed_by_space_then_spell_out_currency_name")]
        UseAmountFollowedBySpaceThenSpellOutCurrencyName,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_amount_followed_by_space_then_spell_out_currency_name_in_lowercase")]
        UseAmountFollowedBySpaceThenSpellOutCurrencyNameInLowercase,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_amount_followed_by_spelled_out_currency_name_in_japanese_without_space")]
        UseAmountFollowedBySpelledOutCurrencyNameInJapaneseWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_amount_followed_by_spelled_out_currency_name_without_space")]
        UseAmountFollowedBySpelledOutCurrencyNameWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_currency_symbol_but_spell_out_if_no_symbol_exists")]
        UseCurrencySymbolButSpellOutIfNoSymbolExists,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_currency_symbol_but_use_iso_code_if_no_symbol_exists")]
        UseCurrencySymbolButUseIsoCodeIfNoSymbolExists,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_currency_symbol_followed_by_amount_in_arabic_numerals_without_space")]
        UseCurrencySymbolFollowedByAmountInArabicNumeralsWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_currency_symbol_followed_by_amount_without_space")]
        UseCurrencySymbolFollowedByAmountWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_currency_symbol_followed_by_space_then_amount")]
        UseCurrencySymbolFollowedBySpaceThenAmount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_currency_symbol_followed_by_space_then_amount_in_arabic_numerals")]
        UseCurrencySymbolFollowedBySpaceThenAmountInArabicNumerals,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_full_width_currency_symbol_followed_by_amount_without_space")]
        UseFullWidthCurrencySymbolFollowedByAmountWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_half_width_currency_symbol_followed_by_amount_without_space")]
        UseHalfWidthCurrencySymbolFollowedByAmountWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_half_width_currency_symbol_followed_by_space_then_amount")]
        UseHalfWidthCurrencySymbolFollowedBySpaceThenAmount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_iso_code")]
        UseIsoCode,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_iso_code_followed_by_space_then_amount")]
        UseIsoCodeFollowedBySpaceThenAmount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_iso_code_followed_by_space_then_amount_in_arabic_numerals")]
        UseIsoCodeFollowedBySpaceThenAmountInArabicNumerals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersCurrencyFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersCurrencyFormat value)
        {
            return value switch
            {
                ConfiguredRulesNumbersCurrencyFormat.SpellOut => "spell_out",
                ConfiguredRulesNumbersCurrencyFormat.SpellOutCurrencyNameFollowedByAmountInArabicNumeralsWithoutSpace => "spell_out_currency_name_followed_by_amount_in_arabic_numerals_without_space",
                ConfiguredRulesNumbersCurrencyFormat.SpellOutCurrencyNameFollowedByAmountInChinese => "spell_out_currency_name_followed_by_amount_in_chinese",
                ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedByCurrencySymbolWithoutSpace => "use_amount_followed_by_currency_symbol_without_space",
                ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedBySpaceThenCurrencySymbol => "use_amount_followed_by_space_then_currency_symbol",
                ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedBySpaceThenIsoCode => "use_amount_followed_by_space_then_iso_code",
                ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedBySpaceThenSpellOutCurrencyName => "use_amount_followed_by_space_then_spell_out_currency_name",
                ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedBySpaceThenSpellOutCurrencyNameInLowercase => "use_amount_followed_by_space_then_spell_out_currency_name_in_lowercase",
                ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedBySpelledOutCurrencyNameInJapaneseWithoutSpace => "use_amount_followed_by_spelled_out_currency_name_in_japanese_without_space",
                ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedBySpelledOutCurrencyNameWithoutSpace => "use_amount_followed_by_spelled_out_currency_name_without_space",
                ConfiguredRulesNumbersCurrencyFormat.UseCurrencySymbolButSpellOutIfNoSymbolExists => "use_currency_symbol_but_spell_out_if_no_symbol_exists",
                ConfiguredRulesNumbersCurrencyFormat.UseCurrencySymbolButUseIsoCodeIfNoSymbolExists => "use_currency_symbol_but_use_iso_code_if_no_symbol_exists",
                ConfiguredRulesNumbersCurrencyFormat.UseCurrencySymbolFollowedByAmountInArabicNumeralsWithoutSpace => "use_currency_symbol_followed_by_amount_in_arabic_numerals_without_space",
                ConfiguredRulesNumbersCurrencyFormat.UseCurrencySymbolFollowedByAmountWithoutSpace => "use_currency_symbol_followed_by_amount_without_space",
                ConfiguredRulesNumbersCurrencyFormat.UseCurrencySymbolFollowedBySpaceThenAmount => "use_currency_symbol_followed_by_space_then_amount",
                ConfiguredRulesNumbersCurrencyFormat.UseCurrencySymbolFollowedBySpaceThenAmountInArabicNumerals => "use_currency_symbol_followed_by_space_then_amount_in_arabic_numerals",
                ConfiguredRulesNumbersCurrencyFormat.UseFullWidthCurrencySymbolFollowedByAmountWithoutSpace => "use_full_width_currency_symbol_followed_by_amount_without_space",
                ConfiguredRulesNumbersCurrencyFormat.UseHalfWidthCurrencySymbolFollowedByAmountWithoutSpace => "use_half_width_currency_symbol_followed_by_amount_without_space",
                ConfiguredRulesNumbersCurrencyFormat.UseHalfWidthCurrencySymbolFollowedBySpaceThenAmount => "use_half_width_currency_symbol_followed_by_space_then_amount",
                ConfiguredRulesNumbersCurrencyFormat.UseIsoCode => "use_iso_code",
                ConfiguredRulesNumbersCurrencyFormat.UseIsoCodeFollowedBySpaceThenAmount => "use_iso_code_followed_by_space_then_amount",
                ConfiguredRulesNumbersCurrencyFormat.UseIsoCodeFollowedBySpaceThenAmountInArabicNumerals => "use_iso_code_followed_by_space_then_amount_in_arabic_numerals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersCurrencyFormat? ToEnum(string value)
        {
            return value switch
            {
                "spell_out" => ConfiguredRulesNumbersCurrencyFormat.SpellOut,
                "spell_out_currency_name_followed_by_amount_in_arabic_numerals_without_space" => ConfiguredRulesNumbersCurrencyFormat.SpellOutCurrencyNameFollowedByAmountInArabicNumeralsWithoutSpace,
                "spell_out_currency_name_followed_by_amount_in_chinese" => ConfiguredRulesNumbersCurrencyFormat.SpellOutCurrencyNameFollowedByAmountInChinese,
                "use_amount_followed_by_currency_symbol_without_space" => ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedByCurrencySymbolWithoutSpace,
                "use_amount_followed_by_space_then_currency_symbol" => ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedBySpaceThenCurrencySymbol,
                "use_amount_followed_by_space_then_iso_code" => ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedBySpaceThenIsoCode,
                "use_amount_followed_by_space_then_spell_out_currency_name" => ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedBySpaceThenSpellOutCurrencyName,
                "use_amount_followed_by_space_then_spell_out_currency_name_in_lowercase" => ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedBySpaceThenSpellOutCurrencyNameInLowercase,
                "use_amount_followed_by_spelled_out_currency_name_in_japanese_without_space" => ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedBySpelledOutCurrencyNameInJapaneseWithoutSpace,
                "use_amount_followed_by_spelled_out_currency_name_without_space" => ConfiguredRulesNumbersCurrencyFormat.UseAmountFollowedBySpelledOutCurrencyNameWithoutSpace,
                "use_currency_symbol_but_spell_out_if_no_symbol_exists" => ConfiguredRulesNumbersCurrencyFormat.UseCurrencySymbolButSpellOutIfNoSymbolExists,
                "use_currency_symbol_but_use_iso_code_if_no_symbol_exists" => ConfiguredRulesNumbersCurrencyFormat.UseCurrencySymbolButUseIsoCodeIfNoSymbolExists,
                "use_currency_symbol_followed_by_amount_in_arabic_numerals_without_space" => ConfiguredRulesNumbersCurrencyFormat.UseCurrencySymbolFollowedByAmountInArabicNumeralsWithoutSpace,
                "use_currency_symbol_followed_by_amount_without_space" => ConfiguredRulesNumbersCurrencyFormat.UseCurrencySymbolFollowedByAmountWithoutSpace,
                "use_currency_symbol_followed_by_space_then_amount" => ConfiguredRulesNumbersCurrencyFormat.UseCurrencySymbolFollowedBySpaceThenAmount,
                "use_currency_symbol_followed_by_space_then_amount_in_arabic_numerals" => ConfiguredRulesNumbersCurrencyFormat.UseCurrencySymbolFollowedBySpaceThenAmountInArabicNumerals,
                "use_full_width_currency_symbol_followed_by_amount_without_space" => ConfiguredRulesNumbersCurrencyFormat.UseFullWidthCurrencySymbolFollowedByAmountWithoutSpace,
                "use_half_width_currency_symbol_followed_by_amount_without_space" => ConfiguredRulesNumbersCurrencyFormat.UseHalfWidthCurrencySymbolFollowedByAmountWithoutSpace,
                "use_half_width_currency_symbol_followed_by_space_then_amount" => ConfiguredRulesNumbersCurrencyFormat.UseHalfWidthCurrencySymbolFollowedBySpaceThenAmount,
                "use_iso_code" => ConfiguredRulesNumbersCurrencyFormat.UseIsoCode,
                "use_iso_code_followed_by_space_then_amount" => ConfiguredRulesNumbersCurrencyFormat.UseIsoCodeFollowedBySpaceThenAmount,
                "use_iso_code_followed_by_space_then_amount_in_arabic_numerals" => ConfiguredRulesNumbersCurrencyFormat.UseIsoCodeFollowedBySpaceThenAmountInArabicNumerals,
                _ => null,
            };
        }
    }
}