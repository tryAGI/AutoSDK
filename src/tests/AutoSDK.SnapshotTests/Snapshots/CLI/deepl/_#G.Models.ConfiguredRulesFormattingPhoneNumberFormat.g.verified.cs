//HintName: G.Models.ConfiguredRulesFormattingPhoneNumberFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Phone Number Format
    /// </summary>
    public enum ConfiguredRulesFormattingPhoneNumberFormat
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseSpaces,
        /// <summary>
        /// 
        /// </summary>
        DoNotUseSpacesOrSpecialCharactersBetweenDigitsOfPhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        KeepOriginalFormat,
        /// <summary>
        /// 
        /// </summary>
        PlaceAreaCodeInParenthesesFollowedBySpace,
        /// <summary>
        /// 
        /// </summary>
        SeparateAreaCodeAndPhoneNumberWithSlash,
        /// <summary>
        /// 
        /// </summary>
        SeparateAreaCodeAndPhoneNumberWithSpace,
        /// <summary>
        /// 
        /// </summary>
        SeparateCountryCodeAreaCodeLocalPrefixAndLastFourDigitsWithHyphens,
        /// <summary>
        /// 
        /// </summary>
        SeparateCountryCodeAreaCodeLocalPrefixAndLastFourDigitsWithPeriods,
        /// <summary>
        /// 
        /// </summary>
        SeparateCountryCodeAreaCodeLocalPrefixAndLastFourDigitsWithSpaces,
        /// <summary>
        /// 
        /// </summary>
        UseNorthAmericanNumberingPlanFormat,
        /// <summary>
        /// 
        /// </summary>
        UseSpaceAfterCountryCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesFormattingPhoneNumberFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesFormattingPhoneNumberFormat value)
        {
            return value switch
            {
                ConfiguredRulesFormattingPhoneNumberFormat.DoNotUseSpaces => "do_not_use_spaces",
                ConfiguredRulesFormattingPhoneNumberFormat.DoNotUseSpacesOrSpecialCharactersBetweenDigitsOfPhoneNumber => "do_not_use_spaces_or_special_characters_between_digits_of_phone_number",
                ConfiguredRulesFormattingPhoneNumberFormat.KeepOriginalFormat => "keep_original_format",
                ConfiguredRulesFormattingPhoneNumberFormat.PlaceAreaCodeInParenthesesFollowedBySpace => "place_area_code_in_parentheses_followed_by_space",
                ConfiguredRulesFormattingPhoneNumberFormat.SeparateAreaCodeAndPhoneNumberWithSlash => "separate_area_code_and_phone_number_with_slash",
                ConfiguredRulesFormattingPhoneNumberFormat.SeparateAreaCodeAndPhoneNumberWithSpace => "separate_area_code_and_phone_number_with_space",
                ConfiguredRulesFormattingPhoneNumberFormat.SeparateCountryCodeAreaCodeLocalPrefixAndLastFourDigitsWithHyphens => "separate_country_code_area_code_local_prefix_and_last_four_digits_with_hyphens",
                ConfiguredRulesFormattingPhoneNumberFormat.SeparateCountryCodeAreaCodeLocalPrefixAndLastFourDigitsWithPeriods => "separate_country_code_area_code_local_prefix_and_last_four_digits_with_periods",
                ConfiguredRulesFormattingPhoneNumberFormat.SeparateCountryCodeAreaCodeLocalPrefixAndLastFourDigitsWithSpaces => "separate_country_code_area_code_local_prefix_and_last_four_digits_with_spaces",
                ConfiguredRulesFormattingPhoneNumberFormat.UseNorthAmericanNumberingPlanFormat => "use_north_american_numbering_plan_format",
                ConfiguredRulesFormattingPhoneNumberFormat.UseSpaceAfterCountryCode => "use_space_after_country_code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesFormattingPhoneNumberFormat? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_spaces" => ConfiguredRulesFormattingPhoneNumberFormat.DoNotUseSpaces,
                "do_not_use_spaces_or_special_characters_between_digits_of_phone_number" => ConfiguredRulesFormattingPhoneNumberFormat.DoNotUseSpacesOrSpecialCharactersBetweenDigitsOfPhoneNumber,
                "keep_original_format" => ConfiguredRulesFormattingPhoneNumberFormat.KeepOriginalFormat,
                "place_area_code_in_parentheses_followed_by_space" => ConfiguredRulesFormattingPhoneNumberFormat.PlaceAreaCodeInParenthesesFollowedBySpace,
                "separate_area_code_and_phone_number_with_slash" => ConfiguredRulesFormattingPhoneNumberFormat.SeparateAreaCodeAndPhoneNumberWithSlash,
                "separate_area_code_and_phone_number_with_space" => ConfiguredRulesFormattingPhoneNumberFormat.SeparateAreaCodeAndPhoneNumberWithSpace,
                "separate_country_code_area_code_local_prefix_and_last_four_digits_with_hyphens" => ConfiguredRulesFormattingPhoneNumberFormat.SeparateCountryCodeAreaCodeLocalPrefixAndLastFourDigitsWithHyphens,
                "separate_country_code_area_code_local_prefix_and_last_four_digits_with_periods" => ConfiguredRulesFormattingPhoneNumberFormat.SeparateCountryCodeAreaCodeLocalPrefixAndLastFourDigitsWithPeriods,
                "separate_country_code_area_code_local_prefix_and_last_four_digits_with_spaces" => ConfiguredRulesFormattingPhoneNumberFormat.SeparateCountryCodeAreaCodeLocalPrefixAndLastFourDigitsWithSpaces,
                "use_north_american_numbering_plan_format" => ConfiguredRulesFormattingPhoneNumberFormat.UseNorthAmericanNumberingPlanFormat,
                "use_space_after_country_code" => ConfiguredRulesFormattingPhoneNumberFormat.UseSpaceAfterCountryCode,
                _ => null,
            };
        }
    }
}