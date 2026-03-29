//HintName: G.Models.ConfiguredRulesDatesAndTimesTimeFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Time Format
    /// </summary>
    public enum ConfiguredRulesDatesAndTimesTimeFormat
    {
        /// <summary>
        /// 
        /// </summary>
        SpellOutTimeInWords,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndDoNotSpecifyMorningOrEvening,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndLowercaseAmOrPmWithPeriods,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndLowercaseAmOrPmWithPeriodsExceptUseNoonAndMidnightInsteadOf12AmAnd12Pm,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndLowercaseAmOrPmWithoutPeriods,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndLowercaseAmOrPmWithoutPeriodsExceptUseNoonAndMidnightInsteadOf12AmAnd12Pm,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndSpecifyMorningOrEvening,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndUppercaseAmOrPmWithPeriods,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndUppercaseAmOrPmWithPeriodsExceptUseNoonAndMidnightInsteadOf12AmAnd12Pm,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndUppercaseAmOrPmWithoutPeriods,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndUppercaseAmOrPmWithoutPeriodsExceptUseNoonAndMidnightInsteadOf12AmAnd12Pm,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndWriteChineseWord__Or__OrChineseWord__Or__FollowedByArabicNumerals,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndWriteChineseWord__Or__OrChineseWord__Or__FollowedByArabicNumeralsWithChineseWord_ForHours,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndWriteChineseWord__Or__OrChineseWord__Or__FollowedByArabicNumeralsWithChineseWords_And_ForHoursAndMinutes,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockAndWriteChineseWord__Or__OrChineseWord__Or__FollowedByChineseNumbersWithChineseWords_And_ForHoursAndMinutes,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockWithArabicNumeralsAndColon,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockWithKoreanWords_And_,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockWithoutLeadingZeroOrMinutesForFullHoursUseColonAsSeparatorAndLowercaseAmOrPmWithoutPeriods,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockWithoutLeadingZeroOrMinutesForFullHoursUseColonAsSeparatorAndUppercaseAmOrPmWithoutPeriods,
        /// <summary>
        /// 
        /// </summary>
        Use12HourClockWithoutLeadingZeroUsePeriodAsSeparatorAndLowercaseAmOrPmWithPeriodsAndSpaces,
        /// <summary>
        /// 
        /// </summary>
        Use24HourClock,
        /// <summary>
        /// 
        /// </summary>
        Use24HourClockWithArabicNumeralsAndColon,
        /// <summary>
        /// 
        /// </summary>
        Use24HourClockWithColonAsSeparator,
        /// <summary>
        /// 
        /// </summary>
        Use24HourClockWithKoreanWords_And_,
        /// <summary>
        /// 
        /// </summary>
        Use24HourClockWithPeriodAsSeparator,
        /// <summary>
        /// 
        /// </summary>
        UseHhColonMmGermanWordUhrWithLeadingZerosForSingleDigitHours,
        /// <summary>
        /// 
        /// </summary>
        UseHhColonMmGermanWordUhrWithoutLeadingZerosForSingleDigitHours,
        /// <summary>
        /// 
        /// </summary>
        UseHhPeriodMmGermanWordUhrWithLeadingZerosForSingleDigitHours,
        /// <summary>
        /// 
        /// </summary>
        UseHhPeriodMmGermanWordUhrWithoutLeadingZerosForSingleDigitHours,
        /// <summary>
        /// 
        /// </summary>
        UseHhPeriodMmGermanWordUhrWithoutLeadingZerosForSingleDigitHoursAndForFullHoursStateHourOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesDatesAndTimesTimeFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesDatesAndTimesTimeFormat value)
        {
            return value switch
            {
                ConfiguredRulesDatesAndTimesTimeFormat.SpellOutTimeInWords => "spell_out_time_in_words",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndDoNotSpecifyMorningOrEvening => "use_12_hour_clock_and_do_not_specify_morning_or_evening",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndLowercaseAmOrPmWithPeriods => "use_12_hour_clock_and_lowercase_am_or_pm_with_periods",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndLowercaseAmOrPmWithPeriodsExceptUseNoonAndMidnightInsteadOf12AmAnd12Pm => "use_12_hour_clock_and_lowercase_am_or_pm_with_periods_except_use_noon_and_midnight_instead_of_12_am_and_12_pm",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndLowercaseAmOrPmWithoutPeriods => "use_12_hour_clock_and_lowercase_am_or_pm_without_periods",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndLowercaseAmOrPmWithoutPeriodsExceptUseNoonAndMidnightInsteadOf12AmAnd12Pm => "use_12_hour_clock_and_lowercase_am_or_pm_without_periods_except_use_noon_and_midnight_instead_of_12_am_and_12_pm",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndSpecifyMorningOrEvening => "use_12_hour_clock_and_specify_morning_or_evening",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndUppercaseAmOrPmWithPeriods => "use_12_hour_clock_and_uppercase_am_or_pm_with_periods",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndUppercaseAmOrPmWithPeriodsExceptUseNoonAndMidnightInsteadOf12AmAnd12Pm => "use_12_hour_clock_and_uppercase_am_or_pm_with_periods_except_use_noon_and_midnight_instead_of_12_am_and_12_pm",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndUppercaseAmOrPmWithoutPeriods => "use_12_hour_clock_and_uppercase_am_or_pm_without_periods",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndUppercaseAmOrPmWithoutPeriodsExceptUseNoonAndMidnightInsteadOf12AmAnd12Pm => "use_12_hour_clock_and_uppercase_am_or_pm_without_periods_except_use_noon_and_midnight_instead_of_12_am_and_12_pm",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndWriteChineseWord__Or__OrChineseWord__Or__FollowedByArabicNumerals => "use_12_hour_clock_and_write_chinese_word_上午_or_下午_or_chinese_word_早上_or_晚上_followed_by_arabic_numerals",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndWriteChineseWord__Or__OrChineseWord__Or__FollowedByArabicNumeralsWithChineseWord_ForHours => "use_12_hour_clock_and_write_chinese_word_上午_or_下午_or_chinese_word_早上_or_晚上_followed_by_arabic_numerals_with_chinese_word_点_for_hours",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndWriteChineseWord__Or__OrChineseWord__Or__FollowedByArabicNumeralsWithChineseWords_And_ForHoursAndMinutes => "use_12_hour_clock_and_write_chinese_word_上午_or_下午_or_chinese_word_早上_or_晚上_followed_by_arabic_numerals_with_chinese_words_时_and_分_for_hours_and_minutes",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndWriteChineseWord__Or__OrChineseWord__Or__FollowedByChineseNumbersWithChineseWords_And_ForHoursAndMinutes => "use_12_hour_clock_and_write_chinese_word_上午_or_下午_or_chinese_word_早上_or_晚上_followed_by_chinese_numbers_with_chinese_words_时_and_分_for_hours_and_minutes",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockWithArabicNumeralsAndColon => "use_12_hour_clock_with_arabic_numerals_and_colon",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockWithKoreanWords_And_ => "use_12_hour_clock_with_korean_words_시_and_분",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockWithoutLeadingZeroOrMinutesForFullHoursUseColonAsSeparatorAndLowercaseAmOrPmWithoutPeriods => "use_12_hour_clock_without_leading_zero_or_minutes_for_full_hours_use_colon_as_separator_and_lowercase_am_or_pm_without_periods",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockWithoutLeadingZeroOrMinutesForFullHoursUseColonAsSeparatorAndUppercaseAmOrPmWithoutPeriods => "use_12_hour_clock_without_leading_zero_or_minutes_for_full_hours_use_colon_as_separator_and_uppercase_am_or_pm_without_periods",
                ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockWithoutLeadingZeroUsePeriodAsSeparatorAndLowercaseAmOrPmWithPeriodsAndSpaces => "use_12_hour_clock_without_leading_zero_use_period_as_separator_and_lowercase_am_or_pm_with_periods_and_spaces",
                ConfiguredRulesDatesAndTimesTimeFormat.Use24HourClock => "use_24_hour_clock",
                ConfiguredRulesDatesAndTimesTimeFormat.Use24HourClockWithArabicNumeralsAndColon => "use_24_hour_clock_with_arabic_numerals_and_colon",
                ConfiguredRulesDatesAndTimesTimeFormat.Use24HourClockWithColonAsSeparator => "use_24_hour_clock_with_colon_as_separator",
                ConfiguredRulesDatesAndTimesTimeFormat.Use24HourClockWithKoreanWords_And_ => "use_24_hour_clock_with_korean_words_시_and_분",
                ConfiguredRulesDatesAndTimesTimeFormat.Use24HourClockWithPeriodAsSeparator => "use_24_hour_clock_with_period_as_separator",
                ConfiguredRulesDatesAndTimesTimeFormat.UseHhColonMmGermanWordUhrWithLeadingZerosForSingleDigitHours => "use_hh_colon_mm_german_word_uhr_with_leading_zeros_for_single_digit_hours",
                ConfiguredRulesDatesAndTimesTimeFormat.UseHhColonMmGermanWordUhrWithoutLeadingZerosForSingleDigitHours => "use_hh_colon_mm_german_word_uhr_without_leading_zeros_for_single_digit_hours",
                ConfiguredRulesDatesAndTimesTimeFormat.UseHhPeriodMmGermanWordUhrWithLeadingZerosForSingleDigitHours => "use_hh_period_mm_german_word_uhr_with_leading_zeros_for_single_digit_hours",
                ConfiguredRulesDatesAndTimesTimeFormat.UseHhPeriodMmGermanWordUhrWithoutLeadingZerosForSingleDigitHours => "use_hh_period_mm_german_word_uhr_without_leading_zeros_for_single_digit_hours",
                ConfiguredRulesDatesAndTimesTimeFormat.UseHhPeriodMmGermanWordUhrWithoutLeadingZerosForSingleDigitHoursAndForFullHoursStateHourOnly => "use_hh_period_mm_german_word_uhr_without_leading_zeros_for_single_digit_hours_and_for_full_hours_state_hour_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesDatesAndTimesTimeFormat? ToEnum(string value)
        {
            return value switch
            {
                "spell_out_time_in_words" => ConfiguredRulesDatesAndTimesTimeFormat.SpellOutTimeInWords,
                "use_12_hour_clock_and_do_not_specify_morning_or_evening" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndDoNotSpecifyMorningOrEvening,
                "use_12_hour_clock_and_lowercase_am_or_pm_with_periods" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndLowercaseAmOrPmWithPeriods,
                "use_12_hour_clock_and_lowercase_am_or_pm_with_periods_except_use_noon_and_midnight_instead_of_12_am_and_12_pm" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndLowercaseAmOrPmWithPeriodsExceptUseNoonAndMidnightInsteadOf12AmAnd12Pm,
                "use_12_hour_clock_and_lowercase_am_or_pm_without_periods" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndLowercaseAmOrPmWithoutPeriods,
                "use_12_hour_clock_and_lowercase_am_or_pm_without_periods_except_use_noon_and_midnight_instead_of_12_am_and_12_pm" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndLowercaseAmOrPmWithoutPeriodsExceptUseNoonAndMidnightInsteadOf12AmAnd12Pm,
                "use_12_hour_clock_and_specify_morning_or_evening" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndSpecifyMorningOrEvening,
                "use_12_hour_clock_and_uppercase_am_or_pm_with_periods" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndUppercaseAmOrPmWithPeriods,
                "use_12_hour_clock_and_uppercase_am_or_pm_with_periods_except_use_noon_and_midnight_instead_of_12_am_and_12_pm" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndUppercaseAmOrPmWithPeriodsExceptUseNoonAndMidnightInsteadOf12AmAnd12Pm,
                "use_12_hour_clock_and_uppercase_am_or_pm_without_periods" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndUppercaseAmOrPmWithoutPeriods,
                "use_12_hour_clock_and_uppercase_am_or_pm_without_periods_except_use_noon_and_midnight_instead_of_12_am_and_12_pm" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndUppercaseAmOrPmWithoutPeriodsExceptUseNoonAndMidnightInsteadOf12AmAnd12Pm,
                "use_12_hour_clock_and_write_chinese_word_上午_or_下午_or_chinese_word_早上_or_晚上_followed_by_arabic_numerals" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndWriteChineseWord__Or__OrChineseWord__Or__FollowedByArabicNumerals,
                "use_12_hour_clock_and_write_chinese_word_上午_or_下午_or_chinese_word_早上_or_晚上_followed_by_arabic_numerals_with_chinese_word_点_for_hours" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndWriteChineseWord__Or__OrChineseWord__Or__FollowedByArabicNumeralsWithChineseWord_ForHours,
                "use_12_hour_clock_and_write_chinese_word_上午_or_下午_or_chinese_word_早上_or_晚上_followed_by_arabic_numerals_with_chinese_words_时_and_分_for_hours_and_minutes" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndWriteChineseWord__Or__OrChineseWord__Or__FollowedByArabicNumeralsWithChineseWords_And_ForHoursAndMinutes,
                "use_12_hour_clock_and_write_chinese_word_上午_or_下午_or_chinese_word_早上_or_晚上_followed_by_chinese_numbers_with_chinese_words_时_and_分_for_hours_and_minutes" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockAndWriteChineseWord__Or__OrChineseWord__Or__FollowedByChineseNumbersWithChineseWords_And_ForHoursAndMinutes,
                "use_12_hour_clock_with_arabic_numerals_and_colon" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockWithArabicNumeralsAndColon,
                "use_12_hour_clock_with_korean_words_시_and_분" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockWithKoreanWords_And_,
                "use_12_hour_clock_without_leading_zero_or_minutes_for_full_hours_use_colon_as_separator_and_lowercase_am_or_pm_without_periods" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockWithoutLeadingZeroOrMinutesForFullHoursUseColonAsSeparatorAndLowercaseAmOrPmWithoutPeriods,
                "use_12_hour_clock_without_leading_zero_or_minutes_for_full_hours_use_colon_as_separator_and_uppercase_am_or_pm_without_periods" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockWithoutLeadingZeroOrMinutesForFullHoursUseColonAsSeparatorAndUppercaseAmOrPmWithoutPeriods,
                "use_12_hour_clock_without_leading_zero_use_period_as_separator_and_lowercase_am_or_pm_with_periods_and_spaces" => ConfiguredRulesDatesAndTimesTimeFormat.Use12HourClockWithoutLeadingZeroUsePeriodAsSeparatorAndLowercaseAmOrPmWithPeriodsAndSpaces,
                "use_24_hour_clock" => ConfiguredRulesDatesAndTimesTimeFormat.Use24HourClock,
                "use_24_hour_clock_with_arabic_numerals_and_colon" => ConfiguredRulesDatesAndTimesTimeFormat.Use24HourClockWithArabicNumeralsAndColon,
                "use_24_hour_clock_with_colon_as_separator" => ConfiguredRulesDatesAndTimesTimeFormat.Use24HourClockWithColonAsSeparator,
                "use_24_hour_clock_with_korean_words_시_and_분" => ConfiguredRulesDatesAndTimesTimeFormat.Use24HourClockWithKoreanWords_And_,
                "use_24_hour_clock_with_period_as_separator" => ConfiguredRulesDatesAndTimesTimeFormat.Use24HourClockWithPeriodAsSeparator,
                "use_hh_colon_mm_german_word_uhr_with_leading_zeros_for_single_digit_hours" => ConfiguredRulesDatesAndTimesTimeFormat.UseHhColonMmGermanWordUhrWithLeadingZerosForSingleDigitHours,
                "use_hh_colon_mm_german_word_uhr_without_leading_zeros_for_single_digit_hours" => ConfiguredRulesDatesAndTimesTimeFormat.UseHhColonMmGermanWordUhrWithoutLeadingZerosForSingleDigitHours,
                "use_hh_period_mm_german_word_uhr_with_leading_zeros_for_single_digit_hours" => ConfiguredRulesDatesAndTimesTimeFormat.UseHhPeriodMmGermanWordUhrWithLeadingZerosForSingleDigitHours,
                "use_hh_period_mm_german_word_uhr_without_leading_zeros_for_single_digit_hours" => ConfiguredRulesDatesAndTimesTimeFormat.UseHhPeriodMmGermanWordUhrWithoutLeadingZerosForSingleDigitHours,
                "use_hh_period_mm_german_word_uhr_without_leading_zeros_for_single_digit_hours_and_for_full_hours_state_hour_only" => ConfiguredRulesDatesAndTimesTimeFormat.UseHhPeriodMmGermanWordUhrWithoutLeadingZerosForSingleDigitHoursAndForFullHoursStateHourOnly,
                _ => null,
            };
        }
    }
}