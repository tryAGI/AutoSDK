//HintName: G.Models.RequestElevenVoiceDubbingTargetLang.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target language code to dub the audio to (e.g., "es" for Spanish, "fr" for French).
    /// </summary>
    public enum RequestElevenVoiceDubbingTargetLang
    {
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Zh,
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
        De,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Ko,
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
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Fil,
        /// <summary>
        /// 
        /// </summary>
        Ms,
        /// <summary>
        /// 
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        El,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Da,
        /// <summary>
        /// 
        /// </summary>
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Sk,
        /// <summary>
        /// 
        /// </summary>
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