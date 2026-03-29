//HintName: G.Models.GlossarySourceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language in which the source texts in the glossary are specified.<br/>
    /// Example: en
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GlossarySourceLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar")]
        Ar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bg")]
        Bg,
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
        [global::System.Runtime.Serialization.EnumMember(Value="de")]
        De,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="el")]
        El,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en")]
        En,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es")]
        Es,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="et")]
        Et,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fi")]
        Fi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr")]
        Fr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="he")]
        He,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hu")]
        Hu,
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
        [global::System.Runtime.Serialization.EnumMember(Value="ja")]
        Ja,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ko")]
        Ko,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lt")]
        Lt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lv")]
        Lv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nb")]
        Nb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nl")]
        Nl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pl")]
        Pl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt")]
        Pt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ro")]
        Ro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ru")]
        Ru,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sk")]
        Sk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sl")]
        Sl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sv")]
        Sv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="th")]
        Th,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tr")]
        Tr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uk")]
        Uk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vi")]
        Vi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh")]
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