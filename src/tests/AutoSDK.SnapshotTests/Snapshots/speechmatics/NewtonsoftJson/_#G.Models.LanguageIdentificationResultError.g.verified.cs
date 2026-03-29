//HintName: G.Models.LanguageIdentificationResultError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LanguageIdentificationResultError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_UNREADABLE")]
        FileUnreadable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LOW_CONFIDENCE")]
        LowConfidence,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NO_SPEECH")]
        NoSpeech,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OTHER")]
        Other,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNEXPECTED_LANGUAGE")]
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