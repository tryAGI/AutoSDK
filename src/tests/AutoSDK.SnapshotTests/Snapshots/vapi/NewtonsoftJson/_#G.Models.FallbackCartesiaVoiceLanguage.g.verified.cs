//HintName: G.Models.FallbackCartesiaVoiceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the language that will be used. This is optional and will default to the correct language for the voiceId.<br/>
    /// Example: en
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackCartesiaVoiceLanguage
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