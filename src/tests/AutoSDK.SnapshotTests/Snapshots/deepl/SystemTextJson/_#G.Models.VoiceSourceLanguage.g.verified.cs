//HintName: G.Models.VoiceSourceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Source language of the audio stream. Must be one of the supported Voice API source languages.<br/>
    /// Language identifier must comply with IETF BCP 47 language tags.<br/>
    /// Example: en
    /// </summary>
    public enum VoiceSourceLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceSourceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSourceLanguage value)
        {
            return value switch
            {
                VoiceSourceLanguage.De => "de",
                VoiceSourceLanguage.En => "en",
                VoiceSourceLanguage.Es => "es",
                VoiceSourceLanguage.Fr => "fr",
                VoiceSourceLanguage.Id => "id",
                VoiceSourceLanguage.It => "it",
                VoiceSourceLanguage.Ja => "ja",
                VoiceSourceLanguage.Ko => "ko",
                VoiceSourceLanguage.Nl => "nl",
                VoiceSourceLanguage.Pl => "pl",
                VoiceSourceLanguage.Pt => "pt",
                VoiceSourceLanguage.Ro => "ro",
                VoiceSourceLanguage.Ru => "ru",
                VoiceSourceLanguage.Sv => "sv",
                VoiceSourceLanguage.Tr => "tr",
                VoiceSourceLanguage.Uk => "uk",
                VoiceSourceLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSourceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "de" => VoiceSourceLanguage.De,
                "en" => VoiceSourceLanguage.En,
                "es" => VoiceSourceLanguage.Es,
                "fr" => VoiceSourceLanguage.Fr,
                "id" => VoiceSourceLanguage.Id,
                "it" => VoiceSourceLanguage.It,
                "ja" => VoiceSourceLanguage.Ja,
                "ko" => VoiceSourceLanguage.Ko,
                "nl" => VoiceSourceLanguage.Nl,
                "pl" => VoiceSourceLanguage.Pl,
                "pt" => VoiceSourceLanguage.Pt,
                "ro" => VoiceSourceLanguage.Ro,
                "ru" => VoiceSourceLanguage.Ru,
                "sv" => VoiceSourceLanguage.Sv,
                "tr" => VoiceSourceLanguage.Tr,
                "uk" => VoiceSourceLanguage.Uk,
                "zh" => VoiceSourceLanguage.Zh,
                _ => null,
            };
        }
    }
}