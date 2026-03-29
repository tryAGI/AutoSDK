//HintName: G.Models.FallbackOpenAIVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used for text-to-speech.
    /// </summary>
    public enum FallbackOpenAIVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniTts,
        /// <summary>
        /// 
        /// </summary>
        Tts1,
        /// <summary>
        /// 
        /// </summary>
        Tts1Hd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackOpenAIVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackOpenAIVoiceModel value)
        {
            return value switch
            {
                FallbackOpenAIVoiceModel.Gpt4oMiniTts => "gpt-4o-mini-tts",
                FallbackOpenAIVoiceModel.Tts1 => "tts-1",
                FallbackOpenAIVoiceModel.Tts1Hd => "tts-1-hd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackOpenAIVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-mini-tts" => FallbackOpenAIVoiceModel.Gpt4oMiniTts,
                "tts-1" => FallbackOpenAIVoiceModel.Tts1,
                "tts-1-hd" => FallbackOpenAIVoiceModel.Tts1Hd,
                _ => null,
            };
        }
    }
}