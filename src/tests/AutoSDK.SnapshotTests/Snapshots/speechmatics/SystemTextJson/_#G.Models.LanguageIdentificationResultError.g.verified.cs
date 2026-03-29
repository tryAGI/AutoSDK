//HintName: G.Models.LanguageIdentificationResultError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LanguageIdentificationResultError
    {
        /// <summary>
        /// 
        /// </summary>
        FileUnreadable,
        /// <summary>
        /// 
        /// </summary>
        LowConfidence,
        /// <summary>
        /// 
        /// </summary>
        NoSpeech,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        UnexpectedLanguage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageIdentificationResultErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageIdentificationResultError value)
        {
            return value switch
            {
                LanguageIdentificationResultError.FileUnreadable => "FILE_UNREADABLE",
                LanguageIdentificationResultError.LowConfidence => "LOW_CONFIDENCE",
                LanguageIdentificationResultError.NoSpeech => "NO_SPEECH",
                LanguageIdentificationResultError.Other => "OTHER",
                LanguageIdentificationResultError.UnexpectedLanguage => "UNEXPECTED_LANGUAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageIdentificationResultError? ToEnum(string value)
        {
            return value switch
            {
                "FILE_UNREADABLE" => LanguageIdentificationResultError.FileUnreadable,
                "LOW_CONFIDENCE" => LanguageIdentificationResultError.LowConfidence,
                "NO_SPEECH" => LanguageIdentificationResultError.NoSpeech,
                "OTHER" => LanguageIdentificationResultError.Other,
                "UNEXPECTED_LANGUAGE" => LanguageIdentificationResultError.UnexpectedLanguage,
                _ => null,
            };
        }
    }
}