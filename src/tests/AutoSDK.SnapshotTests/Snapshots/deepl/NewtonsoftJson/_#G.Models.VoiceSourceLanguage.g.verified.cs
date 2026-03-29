//HintName: G.Models.VoiceSourceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Source language of the audio stream. Must be one of the supported Voice API source languages.<br/>
    /// Language identifier must comply with IETF BCP 47 language tags.<br/>
    /// Example: en
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceSourceLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="de")]
        De,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en")]
        En,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es")]
        Es,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr")]
        Fr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="id")]
        Id,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="it")]
        It,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ja")]
        Ja,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ko")]
        Ko,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nl")]
        Nl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pl")]
        Pl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt")]
        Pt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ro")]
        Ro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ru")]
        Ru,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sv")]
        Sv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tr")]
        Tr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uk")]
        Uk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh")]
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