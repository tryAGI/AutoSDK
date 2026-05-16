//HintName: G.Models.TranscriptionStreamLanguageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be 'transcription.language'.
    /// </summary>
    public enum TranscriptionStreamLanguageType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptionLanguage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionStreamLanguageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionStreamLanguageType value)
        {
            return value switch
            {
                TranscriptionStreamLanguageType.TranscriptionLanguage => "transcription.language",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionStreamLanguageType? ToEnum(string value)
        {
            return value switch
            {
                "transcription.language" => TranscriptionStreamLanguageType.TranscriptionLanguage,
                _ => null,
            };
        }
    }
}