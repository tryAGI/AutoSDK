//HintName: G.Models.InworldVoiceLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language code for Inworld TTS synthesis<br/>
    /// Default Value: en
    /// </summary>
    public enum InworldVoiceLanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        Ar,
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
        He,
        /// <summary>
        /// 
        /// </summary>
        Hi,
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
        Ru,
        /// <summary>
        /// 
        /// </summary>
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