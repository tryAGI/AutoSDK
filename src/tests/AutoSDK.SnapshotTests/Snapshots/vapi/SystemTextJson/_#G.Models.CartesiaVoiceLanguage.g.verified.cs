//HintName: G.Models.CartesiaVoiceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the language that will be used. This is optional and will default to the correct language for the voiceId.<br/>
    /// Example: en
    /// </summary>
    public enum CartesiaVoiceLanguage
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
    public static class CartesiaVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaVoiceLanguage value)
        {
            return value switch
            {
                CartesiaVoiceLanguage.Ar => "ar",
                CartesiaVoiceLanguage.Bg => "bg",
                CartesiaVoiceLanguage.Bn => "bn",
                CartesiaVoiceLanguage.Cs => "cs",
                CartesiaVoiceLanguage.Da => "da",
                CartesiaVoiceLanguage.De => "de",
                CartesiaVoiceLanguage.El => "el",
                CartesiaVoiceLanguage.En => "en",
                CartesiaVoiceLanguage.Es => "es",
                CartesiaVoiceLanguage.Fi => "fi",
                CartesiaVoiceLanguage.Fr => "fr",
                CartesiaVoiceLanguage.Gu => "gu",
                CartesiaVoiceLanguage.He => "he",
                CartesiaVoiceLanguage.Hi => "hi",
                CartesiaVoiceLanguage.Hr => "hr",
                CartesiaVoiceLanguage.Hu => "hu",
                CartesiaVoiceLanguage.Id => "id",
                CartesiaVoiceLanguage.It => "it",
                CartesiaVoiceLanguage.Ja => "ja",
                CartesiaVoiceLanguage.Ka => "ka",
                CartesiaVoiceLanguage.Kn => "kn",
                CartesiaVoiceLanguage.Ko => "ko",
                CartesiaVoiceLanguage.Ml => "ml",
                CartesiaVoiceLanguage.Mr => "mr",
                CartesiaVoiceLanguage.Ms => "ms",
                CartesiaVoiceLanguage.Nl => "nl",
                CartesiaVoiceLanguage.No => "no",
                CartesiaVoiceLanguage.Pa => "pa",
                CartesiaVoiceLanguage.Pl => "pl",
                CartesiaVoiceLanguage.Pt => "pt",
                CartesiaVoiceLanguage.Ro => "ro",
                CartesiaVoiceLanguage.Ru => "ru",
                CartesiaVoiceLanguage.Sk => "sk",
                CartesiaVoiceLanguage.Sv => "sv",
                CartesiaVoiceLanguage.Ta => "ta",
                CartesiaVoiceLanguage.Te => "te",
                CartesiaVoiceLanguage.Th => "th",
                CartesiaVoiceLanguage.Tl => "tl",
                CartesiaVoiceLanguage.Tr => "tr",
                CartesiaVoiceLanguage.Uk => "uk",
                CartesiaVoiceLanguage.Vi => "vi",
                CartesiaVoiceLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => CartesiaVoiceLanguage.Ar,
                "bg" => CartesiaVoiceLanguage.Bg,
                "bn" => CartesiaVoiceLanguage.Bn,
                "cs" => CartesiaVoiceLanguage.Cs,
                "da" => CartesiaVoiceLanguage.Da,
                "de" => CartesiaVoiceLanguage.De,
                "el" => CartesiaVoiceLanguage.El,
                "en" => CartesiaVoiceLanguage.En,
                "es" => CartesiaVoiceLanguage.Es,
                "fi" => CartesiaVoiceLanguage.Fi,
                "fr" => CartesiaVoiceLanguage.Fr,
                "gu" => CartesiaVoiceLanguage.Gu,
                "he" => CartesiaVoiceLanguage.He,
                "hi" => CartesiaVoiceLanguage.Hi,
                "hr" => CartesiaVoiceLanguage.Hr,
                "hu" => CartesiaVoiceLanguage.Hu,
                "id" => CartesiaVoiceLanguage.Id,
                "it" => CartesiaVoiceLanguage.It,
                "ja" => CartesiaVoiceLanguage.Ja,
                "ka" => CartesiaVoiceLanguage.Ka,
                "kn" => CartesiaVoiceLanguage.Kn,
                "ko" => CartesiaVoiceLanguage.Ko,
                "ml" => CartesiaVoiceLanguage.Ml,
                "mr" => CartesiaVoiceLanguage.Mr,
                "ms" => CartesiaVoiceLanguage.Ms,
                "nl" => CartesiaVoiceLanguage.Nl,
                "no" => CartesiaVoiceLanguage.No,
                "pa" => CartesiaVoiceLanguage.Pa,
                "pl" => CartesiaVoiceLanguage.Pl,
                "pt" => CartesiaVoiceLanguage.Pt,
                "ro" => CartesiaVoiceLanguage.Ro,
                "ru" => CartesiaVoiceLanguage.Ru,
                "sk" => CartesiaVoiceLanguage.Sk,
                "sv" => CartesiaVoiceLanguage.Sv,
                "ta" => CartesiaVoiceLanguage.Ta,
                "te" => CartesiaVoiceLanguage.Te,
                "th" => CartesiaVoiceLanguage.Th,
                "tl" => CartesiaVoiceLanguage.Tl,
                "tr" => CartesiaVoiceLanguage.Tr,
                "uk" => CartesiaVoiceLanguage.Uk,
                "vi" => CartesiaVoiceLanguage.Vi,
                "zh" => CartesiaVoiceLanguage.Zh,
                _ => null,
            };
        }
    }
}