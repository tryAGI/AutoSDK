//HintName: G.Models.GlossarySourceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language in which the source texts in the glossary are specified.<br/>
    /// Example: en
    /// </summary>
    public enum GlossarySourceLanguage
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
    public static class GlossarySourceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlossarySourceLanguage value)
        {
            return value switch
            {
                GlossarySourceLanguage.Ar => "ar",
                GlossarySourceLanguage.Bg => "bg",
                GlossarySourceLanguage.Cs => "cs",
                GlossarySourceLanguage.Da => "da",
                GlossarySourceLanguage.De => "de",
                GlossarySourceLanguage.El => "el",
                GlossarySourceLanguage.En => "en",
                GlossarySourceLanguage.Es => "es",
                GlossarySourceLanguage.Et => "et",
                GlossarySourceLanguage.Fi => "fi",
                GlossarySourceLanguage.Fr => "fr",
                GlossarySourceLanguage.He => "he",
                GlossarySourceLanguage.Hu => "hu",
                GlossarySourceLanguage.Id => "id",
                GlossarySourceLanguage.It => "it",
                GlossarySourceLanguage.Ja => "ja",
                GlossarySourceLanguage.Ko => "ko",
                GlossarySourceLanguage.Lt => "lt",
                GlossarySourceLanguage.Lv => "lv",
                GlossarySourceLanguage.Nb => "nb",
                GlossarySourceLanguage.Nl => "nl",
                GlossarySourceLanguage.Pl => "pl",
                GlossarySourceLanguage.Pt => "pt",
                GlossarySourceLanguage.Ro => "ro",
                GlossarySourceLanguage.Ru => "ru",
                GlossarySourceLanguage.Sk => "sk",
                GlossarySourceLanguage.Sl => "sl",
                GlossarySourceLanguage.Sv => "sv",
                GlossarySourceLanguage.Th => "th",
                GlossarySourceLanguage.Tr => "tr",
                GlossarySourceLanguage.Uk => "uk",
                GlossarySourceLanguage.Vi => "vi",
                GlossarySourceLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlossarySourceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => GlossarySourceLanguage.Ar,
                "bg" => GlossarySourceLanguage.Bg,
                "cs" => GlossarySourceLanguage.Cs,
                "da" => GlossarySourceLanguage.Da,
                "de" => GlossarySourceLanguage.De,
                "el" => GlossarySourceLanguage.El,
                "en" => GlossarySourceLanguage.En,
                "es" => GlossarySourceLanguage.Es,
                "et" => GlossarySourceLanguage.Et,
                "fi" => GlossarySourceLanguage.Fi,
                "fr" => GlossarySourceLanguage.Fr,
                "he" => GlossarySourceLanguage.He,
                "hu" => GlossarySourceLanguage.Hu,
                "id" => GlossarySourceLanguage.Id,
                "it" => GlossarySourceLanguage.It,
                "ja" => GlossarySourceLanguage.Ja,
                "ko" => GlossarySourceLanguage.Ko,
                "lt" => GlossarySourceLanguage.Lt,
                "lv" => GlossarySourceLanguage.Lv,
                "nb" => GlossarySourceLanguage.Nb,
                "nl" => GlossarySourceLanguage.Nl,
                "pl" => GlossarySourceLanguage.Pl,
                "pt" => GlossarySourceLanguage.Pt,
                "ro" => GlossarySourceLanguage.Ro,
                "ru" => GlossarySourceLanguage.Ru,
                "sk" => GlossarySourceLanguage.Sk,
                "sl" => GlossarySourceLanguage.Sl,
                "sv" => GlossarySourceLanguage.Sv,
                "th" => GlossarySourceLanguage.Th,
                "tr" => GlossarySourceLanguage.Tr,
                "uk" => GlossarySourceLanguage.Uk,
                "vi" => GlossarySourceLanguage.Vi,
                "zh" => GlossarySourceLanguage.Zh,
                _ => null,
            };
        }
    }
}