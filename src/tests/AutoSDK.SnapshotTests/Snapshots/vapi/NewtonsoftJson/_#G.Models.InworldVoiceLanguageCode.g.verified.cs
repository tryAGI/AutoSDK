//HintName: G.Models.InworldVoiceLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language code for Inworld TTS synthesis<br/>
    /// Default Value: en
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InworldVoiceLanguageCode
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
    public static class InworldVoiceLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InworldVoiceLanguageCode value)
        {
            return value switch
            {
                InworldVoiceLanguageCode.Ar => "ar",
                InworldVoiceLanguageCode.De => "de",
                InworldVoiceLanguageCode.En => "en",
                InworldVoiceLanguageCode.Es => "es",
                InworldVoiceLanguageCode.Fr => "fr",
                InworldVoiceLanguageCode.He => "he",
                InworldVoiceLanguageCode.Hi => "hi",
                InworldVoiceLanguageCode.It => "it",
                InworldVoiceLanguageCode.Ja => "ja",
                InworldVoiceLanguageCode.Ko => "ko",
                InworldVoiceLanguageCode.Nl => "nl",
                InworldVoiceLanguageCode.Pl => "pl",
                InworldVoiceLanguageCode.Pt => "pt",
                InworldVoiceLanguageCode.Ru => "ru",
                InworldVoiceLanguageCode.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InworldVoiceLanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "ar" => InworldVoiceLanguageCode.Ar,
                "de" => InworldVoiceLanguageCode.De,
                "en" => InworldVoiceLanguageCode.En,
                "es" => InworldVoiceLanguageCode.Es,
                "fr" => InworldVoiceLanguageCode.Fr,
                "he" => InworldVoiceLanguageCode.He,
                "hi" => InworldVoiceLanguageCode.Hi,
                "it" => InworldVoiceLanguageCode.It,
                "ja" => InworldVoiceLanguageCode.Ja,
                "ko" => InworldVoiceLanguageCode.Ko,
                "nl" => InworldVoiceLanguageCode.Nl,
                "pl" => InworldVoiceLanguageCode.Pl,
                "pt" => InworldVoiceLanguageCode.Pt,
                "ru" => InworldVoiceLanguageCode.Ru,
                "zh" => InworldVoiceLanguageCode.Zh,
                _ => null,
            };
        }
    }
}