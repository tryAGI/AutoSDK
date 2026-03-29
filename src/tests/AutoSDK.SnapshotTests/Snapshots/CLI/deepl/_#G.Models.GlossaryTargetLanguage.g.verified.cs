//HintName: G.Models.GlossaryTargetLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language in which the target texts in the glossary are specified.<br/>
    /// Example: de
    /// </summary>
    public enum GlossaryTargetLanguage
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
        Et,
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
        He,
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
        Nb,
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
        Sl,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Th,
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
    public static class GlossaryTargetLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlossaryTargetLanguage value)
        {
            return value switch
            {
                GlossaryTargetLanguage.Ar => "ar",
                GlossaryTargetLanguage.Bg => "bg",
                GlossaryTargetLanguage.Cs => "cs",
                GlossaryTargetLanguage.Da => "da",
                GlossaryTargetLanguage.De => "de",
                GlossaryTargetLanguage.El => "el",
                GlossaryTargetLanguage.En => "en",
                GlossaryTargetLanguage.Es => "es",
                GlossaryTargetLanguage.Et => "et",
                GlossaryTargetLanguage.Fi => "fi",
                GlossaryTargetLanguage.Fr => "fr",
                GlossaryTargetLanguage.He => "he",
                GlossaryTargetLanguage.Hu => "hu",
                GlossaryTargetLanguage.Id => "id",
                GlossaryTargetLanguage.It => "it",
                GlossaryTargetLanguage.Ja => "ja",
                GlossaryTargetLanguage.Ko => "ko",
                GlossaryTargetLanguage.Lt => "lt",
                GlossaryTargetLanguage.Lv => "lv",
                GlossaryTargetLanguage.Nb => "nb",
                GlossaryTargetLanguage.Nl => "nl",
                GlossaryTargetLanguage.Pl => "pl",
                GlossaryTargetLanguage.Pt => "pt",
                GlossaryTargetLanguage.Ro => "ro",
                GlossaryTargetLanguage.Ru => "ru",
                GlossaryTargetLanguage.Sk => "sk",
                GlossaryTargetLanguage.Sl => "sl",
                GlossaryTargetLanguage.Sv => "sv",
                GlossaryTargetLanguage.Th => "th",
                GlossaryTargetLanguage.Tr => "tr",
                GlossaryTargetLanguage.Uk => "uk",
                GlossaryTargetLanguage.Vi => "vi",
                GlossaryTargetLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlossaryTargetLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => GlossaryTargetLanguage.Ar,
                "bg" => GlossaryTargetLanguage.Bg,
                "cs" => GlossaryTargetLanguage.Cs,
                "da" => GlossaryTargetLanguage.Da,
                "de" => GlossaryTargetLanguage.De,
                "el" => GlossaryTargetLanguage.El,
                "en" => GlossaryTargetLanguage.En,
                "es" => GlossaryTargetLanguage.Es,
                "et" => GlossaryTargetLanguage.Et,
                "fi" => GlossaryTargetLanguage.Fi,
                "fr" => GlossaryTargetLanguage.Fr,
                "he" => GlossaryTargetLanguage.He,
                "hu" => GlossaryTargetLanguage.Hu,
                "id" => GlossaryTargetLanguage.Id,
                "it" => GlossaryTargetLanguage.It,
                "ja" => GlossaryTargetLanguage.Ja,
                "ko" => GlossaryTargetLanguage.Ko,
                "lt" => GlossaryTargetLanguage.Lt,
                "lv" => GlossaryTargetLanguage.Lv,
                "nb" => GlossaryTargetLanguage.Nb,
                "nl" => GlossaryTargetLanguage.Nl,
                "pl" => GlossaryTargetLanguage.Pl,
                "pt" => GlossaryTargetLanguage.Pt,
                "ro" => GlossaryTargetLanguage.Ro,
                "ru" => GlossaryTargetLanguage.Ru,
                "sk" => GlossaryTargetLanguage.Sk,
                "sl" => GlossaryTargetLanguage.Sl,
                "sv" => GlossaryTargetLanguage.Sv,
                "th" => GlossaryTargetLanguage.Th,
                "tr" => GlossaryTargetLanguage.Tr,
                "uk" => GlossaryTargetLanguage.Uk,
                "vi" => GlossaryTargetLanguage.Vi,
                "zh" => GlossaryTargetLanguage.Zh,
                _ => null,
            };
        }
    }
}