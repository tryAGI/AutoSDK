//HintName: G.Models.TranscriptionJobOptionsLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language code for transcription (ISO 639-1, or cmn for Mandarin)<br/>
    /// Default Value: en
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptionJobOptionsLanguage
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
        [global::System.Runtime.Serialization.EnumMember(Value="ca")]
        Ca,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cmn")]
        Cmn,
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
        [global::System.Runtime.Serialization.EnumMember(Value="tr")]
        Tr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionJobOptionsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionJobOptionsLanguage value)
        {
            return value switch
            {
                TranscriptionJobOptionsLanguage.Ar => "ar",
                TranscriptionJobOptionsLanguage.Bg => "bg",
                TranscriptionJobOptionsLanguage.Ca => "ca",
                TranscriptionJobOptionsLanguage.Cmn => "cmn",
                TranscriptionJobOptionsLanguage.Cs => "cs",
                TranscriptionJobOptionsLanguage.Da => "da",
                TranscriptionJobOptionsLanguage.De => "de",
                TranscriptionJobOptionsLanguage.El => "el",
                TranscriptionJobOptionsLanguage.En => "en",
                TranscriptionJobOptionsLanguage.Es => "es",
                TranscriptionJobOptionsLanguage.Fi => "fi",
                TranscriptionJobOptionsLanguage.Fr => "fr",
                TranscriptionJobOptionsLanguage.Hi => "hi",
                TranscriptionJobOptionsLanguage.Hr => "hr",
                TranscriptionJobOptionsLanguage.Hu => "hu",
                TranscriptionJobOptionsLanguage.It => "it",
                TranscriptionJobOptionsLanguage.Ja => "ja",
                TranscriptionJobOptionsLanguage.Ko => "ko",
                TranscriptionJobOptionsLanguage.Lt => "lt",
                TranscriptionJobOptionsLanguage.Lv => "lv",
                TranscriptionJobOptionsLanguage.Ms => "ms",
                TranscriptionJobOptionsLanguage.Nl => "nl",
                TranscriptionJobOptionsLanguage.No => "no",
                TranscriptionJobOptionsLanguage.Pl => "pl",
                TranscriptionJobOptionsLanguage.Pt => "pt",
                TranscriptionJobOptionsLanguage.Ro => "ro",
                TranscriptionJobOptionsLanguage.Ru => "ru",
                TranscriptionJobOptionsLanguage.Sk => "sk",
                TranscriptionJobOptionsLanguage.Sl => "sl",
                TranscriptionJobOptionsLanguage.Sv => "sv",
                TranscriptionJobOptionsLanguage.Tr => "tr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionJobOptionsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => TranscriptionJobOptionsLanguage.Ar,
                "bg" => TranscriptionJobOptionsLanguage.Bg,
                "ca" => TranscriptionJobOptionsLanguage.Ca,
                "cmn" => TranscriptionJobOptionsLanguage.Cmn,
                "cs" => TranscriptionJobOptionsLanguage.Cs,
                "da" => TranscriptionJobOptionsLanguage.Da,
                "de" => TranscriptionJobOptionsLanguage.De,
                "el" => TranscriptionJobOptionsLanguage.El,
                "en" => TranscriptionJobOptionsLanguage.En,
                "es" => TranscriptionJobOptionsLanguage.Es,
                "fi" => TranscriptionJobOptionsLanguage.Fi,
                "fr" => TranscriptionJobOptionsLanguage.Fr,
                "hi" => TranscriptionJobOptionsLanguage.Hi,
                "hr" => TranscriptionJobOptionsLanguage.Hr,
                "hu" => TranscriptionJobOptionsLanguage.Hu,
                "it" => TranscriptionJobOptionsLanguage.It,
                "ja" => TranscriptionJobOptionsLanguage.Ja,
                "ko" => TranscriptionJobOptionsLanguage.Ko,
                "lt" => TranscriptionJobOptionsLanguage.Lt,
                "lv" => TranscriptionJobOptionsLanguage.Lv,
                "ms" => TranscriptionJobOptionsLanguage.Ms,
                "nl" => TranscriptionJobOptionsLanguage.Nl,
                "no" => TranscriptionJobOptionsLanguage.No,
                "pl" => TranscriptionJobOptionsLanguage.Pl,
                "pt" => TranscriptionJobOptionsLanguage.Pt,
                "ro" => TranscriptionJobOptionsLanguage.Ro,
                "ru" => TranscriptionJobOptionsLanguage.Ru,
                "sk" => TranscriptionJobOptionsLanguage.Sk,
                "sl" => TranscriptionJobOptionsLanguage.Sl,
                "sv" => TranscriptionJobOptionsLanguage.Sv,
                "tr" => TranscriptionJobOptionsLanguage.Tr,
                _ => null,
            };
        }
    }
}