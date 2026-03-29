//HintName: G.Models.SupportedLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
    /// </summary>
    public enum SupportedLanguage
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
        Bn,
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
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Gu,
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
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Hu,
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
        Ka,
        /// <summary>
        /// 
        /// </summary>
        Kn,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Ml,
        /// <summary>
        /// 
        /// </summary>
        Mr,
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
        No,
        /// <summary>
        /// 
        /// </summary>
        Pa,
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
        Te,
        /// <summary>
        /// 
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tl,
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
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SupportedLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupportedLanguage value)
        {
            return value switch
            {
                SupportedLanguage.Ar => "ar",
                SupportedLanguage.Bg => "bg",
                SupportedLanguage.Bn => "bn",
                SupportedLanguage.Cs => "cs",
                SupportedLanguage.Da => "da",
                SupportedLanguage.De => "de",
                SupportedLanguage.El => "el",
                SupportedLanguage.En => "en",
                SupportedLanguage.Es => "es",
                SupportedLanguage.Fi => "fi",
                SupportedLanguage.Fr => "fr",
                SupportedLanguage.Gu => "gu",
                SupportedLanguage.He => "he",
                SupportedLanguage.Hi => "hi",
                SupportedLanguage.Hr => "hr",
                SupportedLanguage.Hu => "hu",
                SupportedLanguage.Id => "id",
                SupportedLanguage.It => "it",
                SupportedLanguage.Ja => "ja",
                SupportedLanguage.Ka => "ka",
                SupportedLanguage.Kn => "kn",
                SupportedLanguage.Ko => "ko",
                SupportedLanguage.Ml => "ml",
                SupportedLanguage.Mr => "mr",
                SupportedLanguage.Ms => "ms",
                SupportedLanguage.Nl => "nl",
                SupportedLanguage.No => "no",
                SupportedLanguage.Pa => "pa",
                SupportedLanguage.Pl => "pl",
                SupportedLanguage.Pt => "pt",
                SupportedLanguage.Ro => "ro",
                SupportedLanguage.Ru => "ru",
                SupportedLanguage.Sk => "sk",
                SupportedLanguage.Sv => "sv",
                SupportedLanguage.Ta => "ta",
                SupportedLanguage.Te => "te",
                SupportedLanguage.Th => "th",
                SupportedLanguage.Tl => "tl",
                SupportedLanguage.Tr => "tr",
                SupportedLanguage.Uk => "uk",
                SupportedLanguage.Vi => "vi",
                SupportedLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupportedLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => SupportedLanguage.Ar,
                "bg" => SupportedLanguage.Bg,
                "bn" => SupportedLanguage.Bn,
                "cs" => SupportedLanguage.Cs,
                "da" => SupportedLanguage.Da,
                "de" => SupportedLanguage.De,
                "el" => SupportedLanguage.El,
                "en" => SupportedLanguage.En,
                "es" => SupportedLanguage.Es,
                "fi" => SupportedLanguage.Fi,
                "fr" => SupportedLanguage.Fr,
                "gu" => SupportedLanguage.Gu,
                "he" => SupportedLanguage.He,
                "hi" => SupportedLanguage.Hi,
                "hr" => SupportedLanguage.Hr,
                "hu" => SupportedLanguage.Hu,
                "id" => SupportedLanguage.Id,
                "it" => SupportedLanguage.It,
                "ja" => SupportedLanguage.Ja,
                "ka" => SupportedLanguage.Ka,
                "kn" => SupportedLanguage.Kn,
                "ko" => SupportedLanguage.Ko,
                "ml" => SupportedLanguage.Ml,
                "mr" => SupportedLanguage.Mr,
                "ms" => SupportedLanguage.Ms,
                "nl" => SupportedLanguage.Nl,
                "no" => SupportedLanguage.No,
                "pa" => SupportedLanguage.Pa,
                "pl" => SupportedLanguage.Pl,
                "pt" => SupportedLanguage.Pt,
                "ro" => SupportedLanguage.Ro,
                "ru" => SupportedLanguage.Ru,
                "sk" => SupportedLanguage.Sk,
                "sv" => SupportedLanguage.Sv,
                "ta" => SupportedLanguage.Ta,
                "te" => SupportedLanguage.Te,
                "th" => SupportedLanguage.Th,
                "tl" => SupportedLanguage.Tl,
                "tr" => SupportedLanguage.Tr,
                "uk" => SupportedLanguage.Uk,
                "vi" => SupportedLanguage.Vi,
                "zh" => SupportedLanguage.Zh,
                _ => null,
            };
        }
    }
}