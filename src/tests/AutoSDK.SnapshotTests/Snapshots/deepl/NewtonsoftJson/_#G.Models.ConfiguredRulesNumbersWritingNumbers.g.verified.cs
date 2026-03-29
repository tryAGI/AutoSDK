//HintName: G.Models.ConfiguredRulesNumbersWritingNumbers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Writing Numbers
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersWritingNumbers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="always_use_kanji_numbers")]
        AlwaysUseKanjiNumbers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_arabic_numerals")]
        UseArabicNumerals,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_full_width_arabic_numerals_and_only_use_kanji_numbers_where_it_would_otherwise_sound_unnatural")]
        UseFullWidthArabicNumeralsAndOnlyUseKanjiNumbersWhereItWouldOtherwiseSoundUnnatural,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_half_width_arabic_numerals_and_only_use_kanji_numbers_where_it_would_otherwise_sound_unnatural")]
        UseHalfWidthArabicNumeralsAndOnlyUseKanjiNumbersWhereItWouldOtherwiseSoundUnnatural,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersWritingNumbersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersWritingNumbers value)
        {
            return value switch
            {
                ConfiguredRulesNumbersWritingNumbers.AlwaysUseKanjiNumbers => "always_use_kanji_numbers",
                ConfiguredRulesNumbersWritingNumbers.UseArabicNumerals => "use_arabic_numerals",
                ConfiguredRulesNumbersWritingNumbers.UseFullWidthArabicNumeralsAndOnlyUseKanjiNumbersWhereItWouldOtherwiseSoundUnnatural => "use_full_width_arabic_numerals_and_only_use_kanji_numbers_where_it_would_otherwise_sound_unnatural",
                ConfiguredRulesNumbersWritingNumbers.UseHalfWidthArabicNumeralsAndOnlyUseKanjiNumbersWhereItWouldOtherwiseSoundUnnatural => "use_half_width_arabic_numerals_and_only_use_kanji_numbers_where_it_would_otherwise_sound_unnatural",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersWritingNumbers? ToEnum(string value)
        {
            return value switch
            {
                "always_use_kanji_numbers" => ConfiguredRulesNumbersWritingNumbers.AlwaysUseKanjiNumbers,
                "use_arabic_numerals" => ConfiguredRulesNumbersWritingNumbers.UseArabicNumerals,
                "use_full_width_arabic_numerals_and_only_use_kanji_numbers_where_it_would_otherwise_sound_unnatural" => ConfiguredRulesNumbersWritingNumbers.UseFullWidthArabicNumeralsAndOnlyUseKanjiNumbersWhereItWouldOtherwiseSoundUnnatural,
                "use_half_width_arabic_numerals_and_only_use_kanji_numbers_where_it_would_otherwise_sound_unnatural" => ConfiguredRulesNumbersWritingNumbers.UseHalfWidthArabicNumeralsAndOnlyUseKanjiNumbersWhereItWouldOtherwiseSoundUnnatural,
                _ => null,
            };
        }
    }
}