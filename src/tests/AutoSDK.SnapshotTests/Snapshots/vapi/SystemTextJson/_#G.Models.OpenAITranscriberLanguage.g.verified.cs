//HintName: G.Models.OpenAITranscriberLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the language that will be set for the transcription.
    /// </summary>
    public enum OpenAITranscriberLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Af,
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Az,
        /// <summary>
        /// 
        /// </summary>
        Be,
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Bs,
        /// <summary>
        /// 
        /// </summary>
        Ca,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Cy,
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
        Et,
        /// <summary>
        /// 
        /// </summary>
        Fa,
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
        Gl,
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
        Hy,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Is,
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
        Kk,
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
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lv,
        /// <summary>
        /// 
        /// </summary>
        Mi,
        /// <summary>
        /// 
        /// </summary>
        Mk,
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
        Ne,
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
        Sl,
        /// <summary>
        /// 
        /// </summary>
        Sr,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Sw,
        /// <summary>
        /// 
        /// </summary>
        Ta,
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
        Ur,
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
    public static class OpenAITranscriberLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAITranscriberLanguage value)
        {
            return value switch
            {
                OpenAITranscriberLanguage.Af => "af",
                OpenAITranscriberLanguage.Ar => "ar",
                OpenAITranscriberLanguage.Az => "az",
                OpenAITranscriberLanguage.Be => "be",
                OpenAITranscriberLanguage.Bg => "bg",
                OpenAITranscriberLanguage.Bs => "bs",
                OpenAITranscriberLanguage.Ca => "ca",
                OpenAITranscriberLanguage.Cs => "cs",
                OpenAITranscriberLanguage.Cy => "cy",
                OpenAITranscriberLanguage.Da => "da",
                OpenAITranscriberLanguage.De => "de",
                OpenAITranscriberLanguage.El => "el",
                OpenAITranscriberLanguage.En => "en",
                OpenAITranscriberLanguage.Es => "es",
                OpenAITranscriberLanguage.Et => "et",
                OpenAITranscriberLanguage.Fa => "fa",
                OpenAITranscriberLanguage.Fi => "fi",
                OpenAITranscriberLanguage.Fr => "fr",
                OpenAITranscriberLanguage.Gl => "gl",
                OpenAITranscriberLanguage.He => "he",
                OpenAITranscriberLanguage.Hi => "hi",
                OpenAITranscriberLanguage.Hr => "hr",
                OpenAITranscriberLanguage.Hu => "hu",
                OpenAITranscriberLanguage.Hy => "hy",
                OpenAITranscriberLanguage.Id => "id",
                OpenAITranscriberLanguage.Is => "is",
                OpenAITranscriberLanguage.It => "it",
                OpenAITranscriberLanguage.Ja => "ja",
                OpenAITranscriberLanguage.Kk => "kk",
                OpenAITranscriberLanguage.Kn => "kn",
                OpenAITranscriberLanguage.Ko => "ko",
                OpenAITranscriberLanguage.Lt => "lt",
                OpenAITranscriberLanguage.Lv => "lv",
                OpenAITranscriberLanguage.Mi => "mi",
                OpenAITranscriberLanguage.Mk => "mk",
                OpenAITranscriberLanguage.Mr => "mr",
                OpenAITranscriberLanguage.Ms => "ms",
                OpenAITranscriberLanguage.Ne => "ne",
                OpenAITranscriberLanguage.Nl => "nl",
                OpenAITranscriberLanguage.No => "no",
                OpenAITranscriberLanguage.Pl => "pl",
                OpenAITranscriberLanguage.Pt => "pt",
                OpenAITranscriberLanguage.Ro => "ro",
                OpenAITranscriberLanguage.Ru => "ru",
                OpenAITranscriberLanguage.Sk => "sk",
                OpenAITranscriberLanguage.Sl => "sl",
                OpenAITranscriberLanguage.Sr => "sr",
                OpenAITranscriberLanguage.Sv => "sv",
                OpenAITranscriberLanguage.Sw => "sw",
                OpenAITranscriberLanguage.Ta => "ta",
                OpenAITranscriberLanguage.Th => "th",
                OpenAITranscriberLanguage.Tl => "tl",
                OpenAITranscriberLanguage.Tr => "tr",
                OpenAITranscriberLanguage.Uk => "uk",
                OpenAITranscriberLanguage.Ur => "ur",
                OpenAITranscriberLanguage.Vi => "vi",
                OpenAITranscriberLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAITranscriberLanguage? ToEnum(string value)
        {
            return value switch
            {
                "af" => OpenAITranscriberLanguage.Af,
                "ar" => OpenAITranscriberLanguage.Ar,
                "az" => OpenAITranscriberLanguage.Az,
                "be" => OpenAITranscriberLanguage.Be,
                "bg" => OpenAITranscriberLanguage.Bg,
                "bs" => OpenAITranscriberLanguage.Bs,
                "ca" => OpenAITranscriberLanguage.Ca,
                "cs" => OpenAITranscriberLanguage.Cs,
                "cy" => OpenAITranscriberLanguage.Cy,
                "da" => OpenAITranscriberLanguage.Da,
                "de" => OpenAITranscriberLanguage.De,
                "el" => OpenAITranscriberLanguage.El,
                "en" => OpenAITranscriberLanguage.En,
                "es" => OpenAITranscriberLanguage.Es,
                "et" => OpenAITranscriberLanguage.Et,
                "fa" => OpenAITranscriberLanguage.Fa,
                "fi" => OpenAITranscriberLanguage.Fi,
                "fr" => OpenAITranscriberLanguage.Fr,
                "gl" => OpenAITranscriberLanguage.Gl,
                "he" => OpenAITranscriberLanguage.He,
                "hi" => OpenAITranscriberLanguage.Hi,
                "hr" => OpenAITranscriberLanguage.Hr,
                "hu" => OpenAITranscriberLanguage.Hu,
                "hy" => OpenAITranscriberLanguage.Hy,
                "id" => OpenAITranscriberLanguage.Id,
                "is" => OpenAITranscriberLanguage.Is,
                "it" => OpenAITranscriberLanguage.It,
                "ja" => OpenAITranscriberLanguage.Ja,
                "kk" => OpenAITranscriberLanguage.Kk,
                "kn" => OpenAITranscriberLanguage.Kn,
                "ko" => OpenAITranscriberLanguage.Ko,
                "lt" => OpenAITranscriberLanguage.Lt,
                "lv" => OpenAITranscriberLanguage.Lv,
                "mi" => OpenAITranscriberLanguage.Mi,
                "mk" => OpenAITranscriberLanguage.Mk,
                "mr" => OpenAITranscriberLanguage.Mr,
                "ms" => OpenAITranscriberLanguage.Ms,
                "ne" => OpenAITranscriberLanguage.Ne,
                "nl" => OpenAITranscriberLanguage.Nl,
                "no" => OpenAITranscriberLanguage.No,
                "pl" => OpenAITranscriberLanguage.Pl,
                "pt" => OpenAITranscriberLanguage.Pt,
                "ro" => OpenAITranscriberLanguage.Ro,
                "ru" => OpenAITranscriberLanguage.Ru,
                "sk" => OpenAITranscriberLanguage.Sk,
                "sl" => OpenAITranscriberLanguage.Sl,
                "sr" => OpenAITranscriberLanguage.Sr,
                "sv" => OpenAITranscriberLanguage.Sv,
                "sw" => OpenAITranscriberLanguage.Sw,
                "ta" => OpenAITranscriberLanguage.Ta,
                "th" => OpenAITranscriberLanguage.Th,
                "tl" => OpenAITranscriberLanguage.Tl,
                "tr" => OpenAITranscriberLanguage.Tr,
                "uk" => OpenAITranscriberLanguage.Uk,
                "ur" => OpenAITranscriberLanguage.Ur,
                "vi" => OpenAITranscriberLanguage.Vi,
                "zh" => OpenAITranscriberLanguage.Zh,
                _ => null,
            };
        }
    }
}