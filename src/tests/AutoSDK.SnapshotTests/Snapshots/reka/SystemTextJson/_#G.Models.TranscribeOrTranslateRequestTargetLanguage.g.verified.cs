//HintName: G.Models.TranscribeOrTranslateRequestTargetLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Target language for translation. When omitted, only transcription is performed.
    /// </summary>
    public enum TranscribeOrTranslateRequestTargetLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Chinese,
        /// <summary>
        /// 
        /// </summary>
        French,
        /// <summary>
        /// 
        /// </summary>
        German,
        /// <summary>
        /// 
        /// </summary>
        Italian,
        /// <summary>
        /// 
        /// </summary>
        Japanese,
        /// <summary>
        /// 
        /// </summary>
        Korean,
        /// <summary>
        /// 
        /// </summary>
        Portuguese,
        /// <summary>
        /// 
        /// </summary>
        Spanish,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscribeOrTranslateRequestTargetLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscribeOrTranslateRequestTargetLanguage value)
        {
            return value switch
            {
                TranscribeOrTranslateRequestTargetLanguage.Chinese => "chinese",
                TranscribeOrTranslateRequestTargetLanguage.French => "french",
                TranscribeOrTranslateRequestTargetLanguage.German => "german",
                TranscribeOrTranslateRequestTargetLanguage.Italian => "italian",
                TranscribeOrTranslateRequestTargetLanguage.Japanese => "japanese",
                TranscribeOrTranslateRequestTargetLanguage.Korean => "korean",
                TranscribeOrTranslateRequestTargetLanguage.Portuguese => "portuguese",
                TranscribeOrTranslateRequestTargetLanguage.Spanish => "spanish",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscribeOrTranslateRequestTargetLanguage? ToEnum(string value)
        {
            return value switch
            {
                "chinese" => TranscribeOrTranslateRequestTargetLanguage.Chinese,
                "french" => TranscribeOrTranslateRequestTargetLanguage.French,
                "german" => TranscribeOrTranslateRequestTargetLanguage.German,
                "italian" => TranscribeOrTranslateRequestTargetLanguage.Italian,
                "japanese" => TranscribeOrTranslateRequestTargetLanguage.Japanese,
                "korean" => TranscribeOrTranslateRequestTargetLanguage.Korean,
                "portuguese" => TranscribeOrTranslateRequestTargetLanguage.Portuguese,
                "spanish" => TranscribeOrTranslateRequestTargetLanguage.Spanish,
                _ => null,
            };
        }
    }
}