//HintName: G.Models.RequestElevenVoiceDubbingTargetLang.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target language code to dub the audio to (e.g., "es" for Spanish, "fr" for French).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequestElevenVoiceDubbingTargetLang
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en")]
        En,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hi")]
        Hi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt")]
        Pt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh")]
        Zh,
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
        [global::System.Runtime.Serialization.EnumMember(Value="de")]
        De,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ja")]
        Ja,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar")]
        Ar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ru")]
        Ru,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ko")]
        Ko,
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
        [global::System.Runtime.Serialization.EnumMember(Value="nl")]
        Nl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tr")]
        Tr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pl")]
        Pl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sv")]
        Sv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fil")]
        Fil,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ms")]
        Ms,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ro")]
        Ro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uk")]
        Uk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="el")]
        El,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cs")]
        Cs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="da")]
        Da,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fi")]
        Fi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bg")]
        Bg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hr")]
        Hr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sk")]
        Sk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ta")]
        Ta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestElevenVoiceDubbingTargetLangExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestElevenVoiceDubbingTargetLang value)
        {
            return value switch
            {
                RequestElevenVoiceDubbingTargetLang.En => "en",
                RequestElevenVoiceDubbingTargetLang.Hi => "hi",
                RequestElevenVoiceDubbingTargetLang.Pt => "pt",
                RequestElevenVoiceDubbingTargetLang.Zh => "zh",
                RequestElevenVoiceDubbingTargetLang.Es => "es",
                RequestElevenVoiceDubbingTargetLang.Fr => "fr",
                RequestElevenVoiceDubbingTargetLang.De => "de",
                RequestElevenVoiceDubbingTargetLang.Ja => "ja",
                RequestElevenVoiceDubbingTargetLang.Ar => "ar",
                RequestElevenVoiceDubbingTargetLang.Ru => "ru",
                RequestElevenVoiceDubbingTargetLang.Ko => "ko",
                RequestElevenVoiceDubbingTargetLang.Id => "id",
                RequestElevenVoiceDubbingTargetLang.It => "it",
                RequestElevenVoiceDubbingTargetLang.Nl => "nl",
                RequestElevenVoiceDubbingTargetLang.Tr => "tr",
                RequestElevenVoiceDubbingTargetLang.Pl => "pl",
                RequestElevenVoiceDubbingTargetLang.Sv => "sv",
                RequestElevenVoiceDubbingTargetLang.Fil => "fil",
                RequestElevenVoiceDubbingTargetLang.Ms => "ms",
                RequestElevenVoiceDubbingTargetLang.Ro => "ro",
                RequestElevenVoiceDubbingTargetLang.Uk => "uk",
                RequestElevenVoiceDubbingTargetLang.El => "el",
                RequestElevenVoiceDubbingTargetLang.Cs => "cs",
                RequestElevenVoiceDubbingTargetLang.Da => "da",
                RequestElevenVoiceDubbingTargetLang.Fi => "fi",
                RequestElevenVoiceDubbingTargetLang.Bg => "bg",
                RequestElevenVoiceDubbingTargetLang.Hr => "hr",
                RequestElevenVoiceDubbingTargetLang.Sk => "sk",
                RequestElevenVoiceDubbingTargetLang.Ta => "ta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestElevenVoiceDubbingTargetLang? ToEnum(string value)
        {
            return value switch
            {
                "en" => RequestElevenVoiceDubbingTargetLang.En,
                "hi" => RequestElevenVoiceDubbingTargetLang.Hi,
                "pt" => RequestElevenVoiceDubbingTargetLang.Pt,
                "zh" => RequestElevenVoiceDubbingTargetLang.Zh,
                "es" => RequestElevenVoiceDubbingTargetLang.Es,
                "fr" => RequestElevenVoiceDubbingTargetLang.Fr,
                "de" => RequestElevenVoiceDubbingTargetLang.De,
                "ja" => RequestElevenVoiceDubbingTargetLang.Ja,
                "ar" => RequestElevenVoiceDubbingTargetLang.Ar,
                "ru" => RequestElevenVoiceDubbingTargetLang.Ru,
                "ko" => RequestElevenVoiceDubbingTargetLang.Ko,
                "id" => RequestElevenVoiceDubbingTargetLang.Id,
                "it" => RequestElevenVoiceDubbingTargetLang.It,
                "nl" => RequestElevenVoiceDubbingTargetLang.Nl,
                "tr" => RequestElevenVoiceDubbingTargetLang.Tr,
                "pl" => RequestElevenVoiceDubbingTargetLang.Pl,
                "sv" => RequestElevenVoiceDubbingTargetLang.Sv,
                "fil" => RequestElevenVoiceDubbingTargetLang.Fil,
                "ms" => RequestElevenVoiceDubbingTargetLang.Ms,
                "ro" => RequestElevenVoiceDubbingTargetLang.Ro,
                "uk" => RequestElevenVoiceDubbingTargetLang.Uk,
                "el" => RequestElevenVoiceDubbingTargetLang.El,
                "cs" => RequestElevenVoiceDubbingTargetLang.Cs,
                "da" => RequestElevenVoiceDubbingTargetLang.Da,
                "fi" => RequestElevenVoiceDubbingTargetLang.Fi,
                "bg" => RequestElevenVoiceDubbingTargetLang.Bg,
                "hr" => RequestElevenVoiceDubbingTargetLang.Hr,
                "sk" => RequestElevenVoiceDubbingTargetLang.Sk,
                "ta" => RequestElevenVoiceDubbingTargetLang.Ta,
                _ => null,
            };
        }
    }
}