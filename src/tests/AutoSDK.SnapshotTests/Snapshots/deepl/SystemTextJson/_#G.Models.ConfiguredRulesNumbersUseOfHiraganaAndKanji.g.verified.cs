//HintName: G.Models.ConfiguredRulesNumbersUseOfHiraganaAndKanji.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Use Of Hiragana And Kanji
    /// </summary>
    public enum ConfiguredRulesNumbersUseOfHiraganaAndKanji
    {
        /// <summary>
        /// 
        /// </summary>
        UseHiraganaJapaneseWord__Or__WhenUsingArabicNumeralsInHorizontalWritingButUseKanjiJapaneseWord__Or__WhenUsingKanjiNumbers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersUseOfHiraganaAndKanjiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersUseOfHiraganaAndKanji value)
        {
            return value switch
            {
                ConfiguredRulesNumbersUseOfHiraganaAndKanji.UseHiraganaJapaneseWord__Or__WhenUsingArabicNumeralsInHorizontalWritingButUseKanjiJapaneseWord__Or__WhenUsingKanjiNumbers => "use_hiragana_japanese_word_か所_or_か月_when_using_arabic_numerals_in_horizontal_writing_but_use_kanji_japanese_word_箇所_or_箇月_when_using_kanji_numbers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersUseOfHiraganaAndKanji? ToEnum(string value)
        {
            return value switch
            {
                "use_hiragana_japanese_word_か所_or_か月_when_using_arabic_numerals_in_horizontal_writing_but_use_kanji_japanese_word_箇所_or_箇月_when_using_kanji_numbers" => ConfiguredRulesNumbersUseOfHiraganaAndKanji.UseHiraganaJapaneseWord__Or__WhenUsingArabicNumeralsInHorizontalWritingButUseKanjiJapaneseWord__Or__WhenUsingKanjiNumbers,
                _ => null,
            };
        }
    }
}