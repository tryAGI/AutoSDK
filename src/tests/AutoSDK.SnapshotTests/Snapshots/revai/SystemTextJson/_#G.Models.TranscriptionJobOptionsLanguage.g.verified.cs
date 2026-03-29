//HintName: G.Models.TranscriptionJobOptionsLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language code for transcription (ISO 639-1, or cmn for Mandarin)<br/>
    /// Default Value: en
    /// </summary>
    public enum TranscriptionJobOptionsLanguage
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
        Ca,
        /// <summary>
        /// 
        /// </summary>
        Cmn,
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