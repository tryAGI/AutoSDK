//HintName: G.Models.CartesiaVoiceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the language that will be used. This is optional and will default to the correct language for the voiceId.<br/>
    /// Example: en
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CartesiaVoiceLanguage
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