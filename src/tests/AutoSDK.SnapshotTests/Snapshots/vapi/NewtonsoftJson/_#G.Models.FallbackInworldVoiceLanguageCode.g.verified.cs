//HintName: G.Models.FallbackInworldVoiceLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language code for Inworld TTS synthesis<br/>
    /// Default Value: en
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackInworldVoiceLanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar")]
        Ar,
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
        [global::System.Runtime.Serialization.EnumMember(Value="he")]
        He,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hi")]
        Hi,
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
        [global::System.Runtime.Serialization.EnumMember(Value="ru")]
        Ru,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh")]
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackInworldVoiceLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackInworldVoiceLanguageCode value)
        {
            return value switch
            {
                FallbackInworldVoiceLanguageCode.Ar => "ar",
                FallbackInworldVoiceLanguageCode.De => "de",
                FallbackInworldVoiceLanguageCode.En => "en",
                FallbackInworldVoiceLanguageCode.Es => "es",
                FallbackInworldVoiceLanguageCode.Fr => "fr",
                FallbackInworldVoiceLanguageCode.He => "he",
                FallbackInworldVoiceLanguageCode.Hi => "hi",
                FallbackInworldVoiceLanguageCode.It => "it",
                FallbackInworldVoiceLanguageCode.Ja => "ja",
                FallbackInworldVoiceLanguageCode.Ko => "ko",
                FallbackInworldVoiceLanguageCode.Nl => "nl",
                FallbackInworldVoiceLanguageCode.Pl => "pl",
                FallbackInworldVoiceLanguageCode.Pt => "pt",
                FallbackInworldVoiceLanguageCode.Ru => "ru",
                FallbackInworldVoiceLanguageCode.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackInworldVoiceLanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "ar" => FallbackInworldVoiceLanguageCode.Ar,
                "de" => FallbackInworldVoiceLanguageCode.De,
                "en" => FallbackInworldVoiceLanguageCode.En,
                "es" => FallbackInworldVoiceLanguageCode.Es,
                "fr" => FallbackInworldVoiceLanguageCode.Fr,
                "he" => FallbackInworldVoiceLanguageCode.He,
                "hi" => FallbackInworldVoiceLanguageCode.Hi,
                "it" => FallbackInworldVoiceLanguageCode.It,
                "ja" => FallbackInworldVoiceLanguageCode.Ja,
                "ko" => FallbackInworldVoiceLanguageCode.Ko,
                "nl" => FallbackInworldVoiceLanguageCode.Nl,
                "pl" => FallbackInworldVoiceLanguageCode.Pl,
                "pt" => FallbackInworldVoiceLanguageCode.Pt,
                "ru" => FallbackInworldVoiceLanguageCode.Ru,
                "zh" => FallbackInworldVoiceLanguageCode.Zh,
                _ => null,
            };
        }
    }
}