//HintName: G.Models.ConfiguredRulesStyleAndToneSimpleWordsAndSentences.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Simple Words And Sentences
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneSimpleWordsAndSentences
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_simple_words_and_sentences_avoid_hard_to_translate_words_and_figures_of_speech")]
        UseSimpleWordsAndSentencesAvoidHardToTranslateWordsAndFiguresOfSpeech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneSimpleWordsAndSentencesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneSimpleWordsAndSentences value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneSimpleWordsAndSentences.UseSimpleWordsAndSentencesAvoidHardToTranslateWordsAndFiguresOfSpeech => "use_simple_words_and_sentences_avoid_hard_to_translate_words_and_figures_of_speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneSimpleWordsAndSentences? ToEnum(string value)
        {
            return value switch
            {
                "use_simple_words_and_sentences_avoid_hard_to_translate_words_and_figures_of_speech" => ConfiguredRulesStyleAndToneSimpleWordsAndSentences.UseSimpleWordsAndSentencesAvoidHardToTranslateWordsAndFiguresOfSpeech,
                _ => null,
            };
        }
    }
}