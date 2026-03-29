//HintName: G.Models.SubmitTranscriptionJobRequestLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: en
    /// </summary>
    public enum SubmitTranscriptionJobRequestLanguage
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
    public static class SubmitTranscriptionJobRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitTranscriptionJobRequestLanguage value)
        {
            return value switch
            {
                SubmitTranscriptionJobRequestLanguage.Ar => "ar",
                SubmitTranscriptionJobRequestLanguage.Bg => "bg",
                SubmitTranscriptionJobRequestLanguage.Ca => "ca",
                SubmitTranscriptionJobRequestLanguage.Cmn => "cmn",
                SubmitTranscriptionJobRequestLanguage.Cs => "cs",
                SubmitTranscriptionJobRequestLanguage.Da => "da",
                SubmitTranscriptionJobRequestLanguage.De => "de",
                SubmitTranscriptionJobRequestLanguage.El => "el",
                SubmitTranscriptionJobRequestLanguage.En => "en",
                SubmitTranscriptionJobRequestLanguage.Es => "es",
                SubmitTranscriptionJobRequestLanguage.Fi => "fi",
                SubmitTranscriptionJobRequestLanguage.Fr => "fr",
                SubmitTranscriptionJobRequestLanguage.Hi => "hi",
                SubmitTranscriptionJobRequestLanguage.Hr => "hr",
                SubmitTranscriptionJobRequestLanguage.Hu => "hu",
                SubmitTranscriptionJobRequestLanguage.It => "it",
                SubmitTranscriptionJobRequestLanguage.Ja => "ja",
                SubmitTranscriptionJobRequestLanguage.Ko => "ko",
                SubmitTranscriptionJobRequestLanguage.Lt => "lt",
                SubmitTranscriptionJobRequestLanguage.Lv => "lv",
                SubmitTranscriptionJobRequestLanguage.Ms => "ms",
                SubmitTranscriptionJobRequestLanguage.Nl => "nl",
                SubmitTranscriptionJobRequestLanguage.No => "no",
                SubmitTranscriptionJobRequestLanguage.Pl => "pl",
                SubmitTranscriptionJobRequestLanguage.Pt => "pt",
                SubmitTranscriptionJobRequestLanguage.Ro => "ro",
                SubmitTranscriptionJobRequestLanguage.Ru => "ru",
                SubmitTranscriptionJobRequestLanguage.Sk => "sk",
                SubmitTranscriptionJobRequestLanguage.Sl => "sl",
                SubmitTranscriptionJobRequestLanguage.Sv => "sv",
                SubmitTranscriptionJobRequestLanguage.Tr => "tr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitTranscriptionJobRequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => SubmitTranscriptionJobRequestLanguage.Ar,
                "bg" => SubmitTranscriptionJobRequestLanguage.Bg,
                "ca" => SubmitTranscriptionJobRequestLanguage.Ca,
                "cmn" => SubmitTranscriptionJobRequestLanguage.Cmn,
                "cs" => SubmitTranscriptionJobRequestLanguage.Cs,
                "da" => SubmitTranscriptionJobRequestLanguage.Da,
                "de" => SubmitTranscriptionJobRequestLanguage.De,
                "el" => SubmitTranscriptionJobRequestLanguage.El,
                "en" => SubmitTranscriptionJobRequestLanguage.En,
                "es" => SubmitTranscriptionJobRequestLanguage.Es,
                "fi" => SubmitTranscriptionJobRequestLanguage.Fi,
                "fr" => SubmitTranscriptionJobRequestLanguage.Fr,
                "hi" => SubmitTranscriptionJobRequestLanguage.Hi,
                "hr" => SubmitTranscriptionJobRequestLanguage.Hr,
                "hu" => SubmitTranscriptionJobRequestLanguage.Hu,
                "it" => SubmitTranscriptionJobRequestLanguage.It,
                "ja" => SubmitTranscriptionJobRequestLanguage.Ja,
                "ko" => SubmitTranscriptionJobRequestLanguage.Ko,
                "lt" => SubmitTranscriptionJobRequestLanguage.Lt,
                "lv" => SubmitTranscriptionJobRequestLanguage.Lv,
                "ms" => SubmitTranscriptionJobRequestLanguage.Ms,
                "nl" => SubmitTranscriptionJobRequestLanguage.Nl,
                "no" => SubmitTranscriptionJobRequestLanguage.No,
                "pl" => SubmitTranscriptionJobRequestLanguage.Pl,
                "pt" => SubmitTranscriptionJobRequestLanguage.Pt,
                "ro" => SubmitTranscriptionJobRequestLanguage.Ro,
                "ru" => SubmitTranscriptionJobRequestLanguage.Ru,
                "sk" => SubmitTranscriptionJobRequestLanguage.Sk,
                "sl" => SubmitTranscriptionJobRequestLanguage.Sl,
                "sv" => SubmitTranscriptionJobRequestLanguage.Sv,
                "tr" => SubmitTranscriptionJobRequestLanguage.Tr,
                _ => null,
            };
        }
    }
}