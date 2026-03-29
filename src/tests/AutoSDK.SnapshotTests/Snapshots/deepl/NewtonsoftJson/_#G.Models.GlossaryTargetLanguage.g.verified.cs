//HintName: G.Models.GlossaryTargetLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language in which the target texts in the glossary are specified.<br/>
    /// Example: de
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GlossaryTargetLanguage
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