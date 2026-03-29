//HintName: G.Models.TranslateSpeechRequestLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language of the audio (BCP-47)
    /// </summary>
    public enum TranslateSpeechRequestLanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        AsIn,
        /// <summary>
        /// 
        /// </summary>
        BnIn,
        /// <summary>
        /// 
        /// </summary>
        BrxIn,
        /// <summary>
        /// 
        /// </summary>
        DoiIn,
        /// <summary>
        /// 
        /// </summary>
        EnIn,
        /// <summary>
        /// 
        /// </summary>
        GuIn,
        /// <summary>
        /// 
        /// </summary>
        HiIn,
        /// <summary>
        /// 
        /// </summary>
        KnIn,
        /// <summary>
        /// 
        /// </summary>
        KokIn,
        /// <summary>
        /// 
        /// </summary>
        KsIn,
        /// <summary>
        /// 
        /// </summary>
        MaiIn,
        /// <summary>
        /// 
        /// </summary>
        MlIn,
        /// <summary>
        /// 
        /// </summary>
        MniIn,
        /// <summary>
        /// 
        /// </summary>
        MrIn,
        /// <summary>
        /// 
        /// </summary>
        NeIn,
        /// <summary>
        /// 
        /// </summary>
        OdIn,
        /// <summary>
        /// 
        /// </summary>
        PaIn,
        /// <summary>
        /// 
        /// </summary>
        SaIn,
        /// <summary>
        /// 
        /// </summary>
        SatIn,
        /// <summary>
        /// 
        /// </summary>
        SdIn,
        /// <summary>
        /// 
        /// </summary>
        TaIn,
        /// <summary>
        /// 
        /// </summary>
        TeIn,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        UrIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslateSpeechRequestLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateSpeechRequestLanguageCode value)
        {
            return value switch
            {
                TranslateSpeechRequestLanguageCode.AsIn => "as-IN",
                TranslateSpeechRequestLanguageCode.BnIn => "bn-IN",
                TranslateSpeechRequestLanguageCode.BrxIn => "brx-IN",
                TranslateSpeechRequestLanguageCode.DoiIn => "doi-IN",
                TranslateSpeechRequestLanguageCode.EnIn => "en-IN",
                TranslateSpeechRequestLanguageCode.GuIn => "gu-IN",
                TranslateSpeechRequestLanguageCode.HiIn => "hi-IN",
                TranslateSpeechRequestLanguageCode.KnIn => "kn-IN",
                TranslateSpeechRequestLanguageCode.KokIn => "kok-IN",
                TranslateSpeechRequestLanguageCode.KsIn => "ks-IN",
                TranslateSpeechRequestLanguageCode.MaiIn => "mai-IN",
                TranslateSpeechRequestLanguageCode.MlIn => "ml-IN",
                TranslateSpeechRequestLanguageCode.MniIn => "mni-IN",
                TranslateSpeechRequestLanguageCode.MrIn => "mr-IN",
                TranslateSpeechRequestLanguageCode.NeIn => "ne-IN",
                TranslateSpeechRequestLanguageCode.OdIn => "od-IN",
                TranslateSpeechRequestLanguageCode.PaIn => "pa-IN",
                TranslateSpeechRequestLanguageCode.SaIn => "sa-IN",
                TranslateSpeechRequestLanguageCode.SatIn => "sat-IN",
                TranslateSpeechRequestLanguageCode.SdIn => "sd-IN",
                TranslateSpeechRequestLanguageCode.TaIn => "ta-IN",
                TranslateSpeechRequestLanguageCode.TeIn => "te-IN",
                TranslateSpeechRequestLanguageCode.Unknown => "unknown",
                TranslateSpeechRequestLanguageCode.UrIn => "ur-IN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateSpeechRequestLanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "as-IN" => TranslateSpeechRequestLanguageCode.AsIn,
                "bn-IN" => TranslateSpeechRequestLanguageCode.BnIn,
                "brx-IN" => TranslateSpeechRequestLanguageCode.BrxIn,
                "doi-IN" => TranslateSpeechRequestLanguageCode.DoiIn,
                "en-IN" => TranslateSpeechRequestLanguageCode.EnIn,
                "gu-IN" => TranslateSpeechRequestLanguageCode.GuIn,
                "hi-IN" => TranslateSpeechRequestLanguageCode.HiIn,
                "kn-IN" => TranslateSpeechRequestLanguageCode.KnIn,
                "kok-IN" => TranslateSpeechRequestLanguageCode.KokIn,
                "ks-IN" => TranslateSpeechRequestLanguageCode.KsIn,
                "mai-IN" => TranslateSpeechRequestLanguageCode.MaiIn,
                "ml-IN" => TranslateSpeechRequestLanguageCode.MlIn,
                "mni-IN" => TranslateSpeechRequestLanguageCode.MniIn,
                "mr-IN" => TranslateSpeechRequestLanguageCode.MrIn,
                "ne-IN" => TranslateSpeechRequestLanguageCode.NeIn,
                "od-IN" => TranslateSpeechRequestLanguageCode.OdIn,
                "pa-IN" => TranslateSpeechRequestLanguageCode.PaIn,
                "sa-IN" => TranslateSpeechRequestLanguageCode.SaIn,
                "sat-IN" => TranslateSpeechRequestLanguageCode.SatIn,
                "sd-IN" => TranslateSpeechRequestLanguageCode.SdIn,
                "ta-IN" => TranslateSpeechRequestLanguageCode.TaIn,
                "te-IN" => TranslateSpeechRequestLanguageCode.TeIn,
                "unknown" => TranslateSpeechRequestLanguageCode.Unknown,
                "ur-IN" => TranslateSpeechRequestLanguageCode.UrIn,
                _ => null,
            };
        }
    }
}