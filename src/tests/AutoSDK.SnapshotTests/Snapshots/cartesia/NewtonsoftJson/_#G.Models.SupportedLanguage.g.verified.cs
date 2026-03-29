//HintName: G.Models.SupportedLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SupportedLanguage
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
        [global::System.Runtime.Serialization.EnumMember(Value="bn")]
        Bn,
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
        [global::System.Runtime.Serialization.EnumMember(Value="gu")]
        Gu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="he")]
        He,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hi")]
        Hi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hr")]
        Hr,
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
        [global::System.Runtime.Serialization.EnumMember(Value="ka")]
        Ka,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kn")]
        Kn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ko")]
        Ko,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ml")]
        Ml,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mr")]
        Mr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ms")]
        Ms,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nl")]
        Nl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no")]
        No,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pa")]
        Pa,
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
        [global::System.Runtime.Serialization.EnumMember(Value="sv")]
        Sv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ta")]
        Ta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="te")]
        Te,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="th")]
        Th,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tl")]
        Tl,
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