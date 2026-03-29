//HintName: G.Models.ConfiguredRulesNumbersKanjiNumbers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Kanji Numbers
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersKanjiNumbers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_kanji_numbers_for_numbers_in_phrases_and_counting_method_based_on_native_japanese_readings")]
        UseKanjiNumbersForNumbersInPhrasesAndCountingMethodBasedOnNativeJapaneseReadings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersKanjiNumbersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersKanjiNumbers value)
        {
            return value switch
            {
                ConfiguredRulesNumbersKanjiNumbers.UseKanjiNumbersForNumbersInPhrasesAndCountingMethodBasedOnNativeJapaneseReadings => "use_kanji_numbers_for_numbers_in_phrases_and_counting_method_based_on_native_japanese_readings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersKanjiNumbers? ToEnum(string value)
        {
            return value switch
            {
                "use_kanji_numbers_for_numbers_in_phrases_and_counting_method_based_on_native_japanese_readings" => ConfiguredRulesNumbersKanjiNumbers.UseKanjiNumbersForNumbersInPhrasesAndCountingMethodBasedOnNativeJapaneseReadings,
                _ => null,
            };
        }
    }
}