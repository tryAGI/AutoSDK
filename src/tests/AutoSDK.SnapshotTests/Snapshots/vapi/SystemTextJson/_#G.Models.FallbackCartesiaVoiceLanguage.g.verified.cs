//HintName: G.Models.FallbackCartesiaVoiceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the language that will be used. This is optional and will default to the correct language for the voiceId.<br/>
    /// Example: en
    /// </summary>
    public enum FallbackCartesiaVoiceLanguage
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
    public static class FallbackCartesiaVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackCartesiaVoiceLanguage value)
        {
            return value switch
            {
                FallbackCartesiaVoiceLanguage.Ar => "ar",
                FallbackCartesiaVoiceLanguage.Bg => "bg",
                FallbackCartesiaVoiceLanguage.Bn => "bn",
                FallbackCartesiaVoiceLanguage.Cs => "cs",
                FallbackCartesiaVoiceLanguage.Da => "da",
                FallbackCartesiaVoiceLanguage.De => "de",
                FallbackCartesiaVoiceLanguage.El => "el",
                FallbackCartesiaVoiceLanguage.En => "en",
                FallbackCartesiaVoiceLanguage.Es => "es",
                FallbackCartesiaVoiceLanguage.Fi => "fi",
                FallbackCartesiaVoiceLanguage.Fr => "fr",
                FallbackCartesiaVoiceLanguage.Gu => "gu",
                FallbackCartesiaVoiceLanguage.He => "he",
                FallbackCartesiaVoiceLanguage.Hi => "hi",
                FallbackCartesiaVoiceLanguage.Hr => "hr",
                FallbackCartesiaVoiceLanguage.Hu => "hu",
                FallbackCartesiaVoiceLanguage.Id => "id",
                FallbackCartesiaVoiceLanguage.It => "it",
                FallbackCartesiaVoiceLanguage.Ja => "ja",
                FallbackCartesiaVoiceLanguage.Ka => "ka",
                FallbackCartesiaVoiceLanguage.Kn => "kn",
                FallbackCartesiaVoiceLanguage.Ko => "ko",
                FallbackCartesiaVoiceLanguage.Ml => "ml",
                FallbackCartesiaVoiceLanguage.Mr => "mr",
                FallbackCartesiaVoiceLanguage.Ms => "ms",
                FallbackCartesiaVoiceLanguage.Nl => "nl",
                FallbackCartesiaVoiceLanguage.No => "no",
                FallbackCartesiaVoiceLanguage.Pa => "pa",
                FallbackCartesiaVoiceLanguage.Pl => "pl",
                FallbackCartesiaVoiceLanguage.Pt => "pt",
                FallbackCartesiaVoiceLanguage.Ro => "ro",
                FallbackCartesiaVoiceLanguage.Ru => "ru",
                FallbackCartesiaVoiceLanguage.Sk => "sk",
                FallbackCartesiaVoiceLanguage.Sv => "sv",
                FallbackCartesiaVoiceLanguage.Ta => "ta",
                FallbackCartesiaVoiceLanguage.Te => "te",
                FallbackCartesiaVoiceLanguage.Th => "th",
                FallbackCartesiaVoiceLanguage.Tl => "tl",
                FallbackCartesiaVoiceLanguage.Tr => "tr",
                FallbackCartesiaVoiceLanguage.Uk => "uk",
                FallbackCartesiaVoiceLanguage.Vi => "vi",
                FallbackCartesiaVoiceLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackCartesiaVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => FallbackCartesiaVoiceLanguage.Ar,
                "bg" => FallbackCartesiaVoiceLanguage.Bg,
                "bn" => FallbackCartesiaVoiceLanguage.Bn,
                "cs" => FallbackCartesiaVoiceLanguage.Cs,
                "da" => FallbackCartesiaVoiceLanguage.Da,
                "de" => FallbackCartesiaVoiceLanguage.De,
                "el" => FallbackCartesiaVoiceLanguage.El,
                "en" => FallbackCartesiaVoiceLanguage.En,
                "es" => FallbackCartesiaVoiceLanguage.Es,
                "fi" => FallbackCartesiaVoiceLanguage.Fi,
                "fr" => FallbackCartesiaVoiceLanguage.Fr,
                "gu" => FallbackCartesiaVoiceLanguage.Gu,
                "he" => FallbackCartesiaVoiceLanguage.He,
                "hi" => FallbackCartesiaVoiceLanguage.Hi,
                "hr" => FallbackCartesiaVoiceLanguage.Hr,
                "hu" => FallbackCartesiaVoiceLanguage.Hu,
                "id" => FallbackCartesiaVoiceLanguage.Id,
                "it" => FallbackCartesiaVoiceLanguage.It,
                "ja" => FallbackCartesiaVoiceLanguage.Ja,
                "ka" => FallbackCartesiaVoiceLanguage.Ka,
                "kn" => FallbackCartesiaVoiceLanguage.Kn,
                "ko" => FallbackCartesiaVoiceLanguage.Ko,
                "ml" => FallbackCartesiaVoiceLanguage.Ml,
                "mr" => FallbackCartesiaVoiceLanguage.Mr,
                "ms" => FallbackCartesiaVoiceLanguage.Ms,
                "nl" => FallbackCartesiaVoiceLanguage.Nl,
                "no" => FallbackCartesiaVoiceLanguage.No,
                "pa" => FallbackCartesiaVoiceLanguage.Pa,
                "pl" => FallbackCartesiaVoiceLanguage.Pl,
                "pt" => FallbackCartesiaVoiceLanguage.Pt,
                "ro" => FallbackCartesiaVoiceLanguage.Ro,
                "ru" => FallbackCartesiaVoiceLanguage.Ru,
                "sk" => FallbackCartesiaVoiceLanguage.Sk,
                "sv" => FallbackCartesiaVoiceLanguage.Sv,
                "ta" => FallbackCartesiaVoiceLanguage.Ta,
                "te" => FallbackCartesiaVoiceLanguage.Te,
                "th" => FallbackCartesiaVoiceLanguage.Th,
                "tl" => FallbackCartesiaVoiceLanguage.Tl,
                "tr" => FallbackCartesiaVoiceLanguage.Tr,
                "uk" => FallbackCartesiaVoiceLanguage.Uk,
                "vi" => FallbackCartesiaVoiceLanguage.Vi,
                "zh" => FallbackCartesiaVoiceLanguage.Zh,
                _ => null,
            };
        }
    }
}