//HintName: G.Models.TransliterateRequestSpokenFormNumeralsLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language for spoken form numerals (only applies when spoken_form is true)<br/>
    /// Default Value: native
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransliterateRequestSpokenFormNumeralsLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="english")]
        English,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="native")]
        Native,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransliterateRequestSpokenFormNumeralsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransliterateRequestSpokenFormNumeralsLanguage value)
        {
            return value switch
            {
                TransliterateRequestSpokenFormNumeralsLanguage.English => "english",
                TransliterateRequestSpokenFormNumeralsLanguage.Native => "native",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransliterateRequestSpokenFormNumeralsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "english" => TransliterateRequestSpokenFormNumeralsLanguage.English,
                "native" => TransliterateRequestSpokenFormNumeralsLanguage.Native,
                _ => null,
            };
        }
    }
}