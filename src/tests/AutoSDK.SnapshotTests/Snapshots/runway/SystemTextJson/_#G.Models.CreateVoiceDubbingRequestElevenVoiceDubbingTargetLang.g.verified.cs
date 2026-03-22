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
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Bg,
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
        De,
        /// <summary>
        /// 
        /// </summary>
        El,
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
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Fil,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Hr,
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
        Ms,
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
        Sk,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Ta,
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
    public static class CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang value)
        {
            return value switch
            {
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ar => "ar",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Bg => "bg",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Cs => "cs",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Da => "da",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.De => "de",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.El => "el",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.En => "en",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Es => "es",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fi => "fi",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fil => "fil",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fr => "fr",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hi => "hi",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hr => "hr",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Id => "id",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.It => "it",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ja => "ja",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ko => "ko",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ms => "ms",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Nl => "nl",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pl => "pl",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pt => "pt",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ro => "ro",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ru => "ru",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sk => "sk",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sv => "sv",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ta => "ta",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Tr => "tr",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Uk => "uk",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Zh => "zh",
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
                "ar" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ar,
                "bg" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Bg,
                "cs" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Cs,
                "da" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Da,
                "de" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.De,
                "el" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.El,
                "en" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.En,
                "es" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Es,
                "fi" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fi,
                "fil" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fil,
                "fr" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fr,
                "hi" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hi,
                "hr" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hr,
                "id" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Id,
                "it" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.It,
                "ja" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ja,
                "ko" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ko,
                "ms" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ms,
                "nl" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Nl,
                "pl" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pl,
                "pt" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pt,
                "ro" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ro,
                "ru" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ru,
                "sk" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sk,
                "sv" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sv,
                "ta" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ta,
                "tr" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Tr,
                "uk" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Uk,
                "zh" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Zh,
                _ => null,
            };
        }
    }
}