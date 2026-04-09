//HintName: G.Models.ConfiguredRulesPunctuationRangeIndicator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Range Indicator
    /// </summary>
    public enum ConfiguredRulesPunctuationRangeIndicator
    {
        /// <summary>
        /// 
        /// </summary>
        UseEnDashWithSpaces,
        /// <summary>
        /// 
        /// </summary>
        UseEnDashWithoutSpaceOnEitherSide,
        /// <summary>
        /// 
        /// </summary>
        UseEnDashWithoutSpaces,
        /// <summary>
        /// 
        /// </summary>
        UseEnglishWordTo,
        /// <summary>
        /// 
        /// </summary>
        UseFullWidthDash,
        /// <summary>
        /// 
        /// </summary>
        UseFullWidthWaveDash,
        /// <summary>
        /// 
        /// </summary>
        UseGermanWordBis,
        /// <summary>
        /// 
        /// </summary>
        UseHalfWidthDash,
        /// <summary>
        /// 
        /// </summary>
        UseHyphen,
        /// <summary>
        /// 
        /// </summary>
        UseHyphenWithSpaceOnEitherSide,
        /// <summary>
        /// 
        /// </summary>
        UseHyphenWithSpaces,
        /// <summary>
        /// 
        /// </summary>
        UseHyphenWithoutSpaceOnEitherSide,
        /// <summary>
        /// 
        /// </summary>
        UseHyphenWithoutSpaces,
        /// <summary>
        /// 
        /// </summary>
        UseItalianWordsDaA,
        /// <summary>
        /// 
        /// </summary>
        UseJapaneseWordから,
        /// <summary>
        /// 
        /// </summary>
        UseKoreanWords부터까지,
        /// <summary>
        /// 
        /// </summary>
        UseSpanishWordsDeA,
        /// <summary>
        /// 
        /// </summary>
        UseTilde,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationRangeIndicatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationRangeIndicator value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationRangeIndicator.UseEnDashWithSpaces => "use_en_dash_with_spaces",
                ConfiguredRulesPunctuationRangeIndicator.UseEnDashWithoutSpaceOnEitherSide => "use_en_dash_without_space_on_either_side",
                ConfiguredRulesPunctuationRangeIndicator.UseEnDashWithoutSpaces => "use_en_dash_without_spaces",
                ConfiguredRulesPunctuationRangeIndicator.UseEnglishWordTo => "use_english_word_to",
                ConfiguredRulesPunctuationRangeIndicator.UseFullWidthDash => "use_full_width_dash",
                ConfiguredRulesPunctuationRangeIndicator.UseFullWidthWaveDash => "use_full_width_wave_dash",
                ConfiguredRulesPunctuationRangeIndicator.UseGermanWordBis => "use_german_word_bis",
                ConfiguredRulesPunctuationRangeIndicator.UseHalfWidthDash => "use_half_width_dash",
                ConfiguredRulesPunctuationRangeIndicator.UseHyphen => "use_hyphen",
                ConfiguredRulesPunctuationRangeIndicator.UseHyphenWithSpaceOnEitherSide => "use_hyphen_with_space_on_either_side",
                ConfiguredRulesPunctuationRangeIndicator.UseHyphenWithSpaces => "use_hyphen_with_spaces",
                ConfiguredRulesPunctuationRangeIndicator.UseHyphenWithoutSpaceOnEitherSide => "use_hyphen_without_space_on_either_side",
                ConfiguredRulesPunctuationRangeIndicator.UseHyphenWithoutSpaces => "use_hyphen_without_spaces",
                ConfiguredRulesPunctuationRangeIndicator.UseItalianWordsDaA => "use_italian_words_da_a",
                ConfiguredRulesPunctuationRangeIndicator.UseJapaneseWordから => "use_japanese_word_から",
                ConfiguredRulesPunctuationRangeIndicator.UseKoreanWords부터까지 => "use_korean_words_부터_까지",
                ConfiguredRulesPunctuationRangeIndicator.UseSpanishWordsDeA => "use_spanish_words_de_a",
                ConfiguredRulesPunctuationRangeIndicator.UseTilde => "use_tilde",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationRangeIndicator? ToEnum(string value)
        {
            return value switch
            {
                "use_en_dash_with_spaces" => ConfiguredRulesPunctuationRangeIndicator.UseEnDashWithSpaces,
                "use_en_dash_without_space_on_either_side" => ConfiguredRulesPunctuationRangeIndicator.UseEnDashWithoutSpaceOnEitherSide,
                "use_en_dash_without_spaces" => ConfiguredRulesPunctuationRangeIndicator.UseEnDashWithoutSpaces,
                "use_english_word_to" => ConfiguredRulesPunctuationRangeIndicator.UseEnglishWordTo,
                "use_full_width_dash" => ConfiguredRulesPunctuationRangeIndicator.UseFullWidthDash,
                "use_full_width_wave_dash" => ConfiguredRulesPunctuationRangeIndicator.UseFullWidthWaveDash,
                "use_german_word_bis" => ConfiguredRulesPunctuationRangeIndicator.UseGermanWordBis,
                "use_half_width_dash" => ConfiguredRulesPunctuationRangeIndicator.UseHalfWidthDash,
                "use_hyphen" => ConfiguredRulesPunctuationRangeIndicator.UseHyphen,
                "use_hyphen_with_space_on_either_side" => ConfiguredRulesPunctuationRangeIndicator.UseHyphenWithSpaceOnEitherSide,
                "use_hyphen_with_spaces" => ConfiguredRulesPunctuationRangeIndicator.UseHyphenWithSpaces,
                "use_hyphen_without_space_on_either_side" => ConfiguredRulesPunctuationRangeIndicator.UseHyphenWithoutSpaceOnEitherSide,
                "use_hyphen_without_spaces" => ConfiguredRulesPunctuationRangeIndicator.UseHyphenWithoutSpaces,
                "use_italian_words_da_a" => ConfiguredRulesPunctuationRangeIndicator.UseItalianWordsDaA,
                "use_japanese_word_から" => ConfiguredRulesPunctuationRangeIndicator.UseJapaneseWordから,
                "use_korean_words_부터_까지" => ConfiguredRulesPunctuationRangeIndicator.UseKoreanWords부터까지,
                "use_spanish_words_de_a" => ConfiguredRulesPunctuationRangeIndicator.UseSpanishWordsDeA,
                "use_tilde" => ConfiguredRulesPunctuationRangeIndicator.UseTilde,
                _ => null,
            };
        }
    }
}