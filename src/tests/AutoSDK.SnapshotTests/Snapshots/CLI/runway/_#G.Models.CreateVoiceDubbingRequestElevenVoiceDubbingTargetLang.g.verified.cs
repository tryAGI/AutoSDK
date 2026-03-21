//HintName: G.Models.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target language code to dub the audio to (e.g., "es" for Spanish, "fr" for French).
    /// </summary>
    public enum CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang
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
    public static class CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang value)
        {
            return value switch
            {
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.En => "en",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hi => "hi",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pt => "pt",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Zh => "zh",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Es => "es",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fr => "fr",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.De => "de",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ja => "ja",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ar => "ar",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ru => "ru",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ko => "ko",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Id => "id",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.It => "it",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Nl => "nl",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Tr => "tr",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pl => "pl",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sv => "sv",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fil => "fil",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ms => "ms",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ro => "ro",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Uk => "uk",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.El => "el",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Cs => "cs",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Da => "da",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fi => "fi",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Bg => "bg",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hr => "hr",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sk => "sk",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ta => "ta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang? ToEnum(string value)
        {
            return value switch
            {
                "en" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.En,
                "hi" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hi,
                "pt" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pt,
                "zh" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Zh,
                "es" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Es,
                "fr" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fr,
                "de" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.De,
                "ja" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ja,
                "ar" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ar,
                "ru" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ru,
                "ko" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ko,
                "id" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Id,
                "it" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.It,
                "nl" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Nl,
                "tr" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Tr,
                "pl" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pl,
                "sv" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sv,
                "fil" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fil,
                "ms" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ms,
                "ro" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ro,
                "uk" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Uk,
                "el" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.El,
                "cs" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Cs,
                "da" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Da,
                "fi" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fi,
                "bg" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Bg,
                "hr" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hr,
                "sk" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sk,
                "ta" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ta,
                _ => null,
            };
        }
    }
}