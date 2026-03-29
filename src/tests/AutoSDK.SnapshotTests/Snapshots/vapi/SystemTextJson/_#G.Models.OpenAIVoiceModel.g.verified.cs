//HintName: G.Models.OpenAIVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used for text-to-speech.
    /// </summary>
    public enum OpenAIVoiceModel
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
    public static class OpenAIVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIVoiceModel value)
        {
            return value switch
            {
                OpenAIVoiceModel.Gpt4oMiniTts => "gpt-4o-mini-tts",
                OpenAIVoiceModel.Tts1 => "tts-1",
                OpenAIVoiceModel.Tts1Hd => "tts-1-hd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-mini-tts" => OpenAIVoiceModel.Gpt4oMiniTts,
                "tts-1" => OpenAIVoiceModel.Tts1,
                "tts-1-hd" => OpenAIVoiceModel.Tts1Hd,
                _ => null,
            };
        }
    }
}