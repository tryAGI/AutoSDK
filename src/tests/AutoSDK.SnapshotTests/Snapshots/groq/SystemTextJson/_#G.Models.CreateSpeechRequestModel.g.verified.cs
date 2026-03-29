//HintName: G.Models.CreateSpeechRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpeechRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        PlayaiTts,
        /// <summary>
        /// 
        /// </summary>
        PlayaiTtsArabic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechRequestModel value)
        {
            return value switch
            {
                CreateSpeechRequestModel.PlayaiTts => "playai-tts",
                CreateSpeechRequestModel.PlayaiTtsArabic => "playai-tts-arabic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "playai-tts" => CreateSpeechRequestModel.PlayaiTts,
                "playai-tts-arabic" => CreateSpeechRequestModel.PlayaiTtsArabic,
                _ => null,
            };
        }
    }
}